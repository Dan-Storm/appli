using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Appli.Data;
using Appli.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Appli.Controllers
{
    [Authorize]
    public class JobApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public JobApplicationsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: JobApplications
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var applicationDbContext = _context.JobApplication
                .Include(j => j.Recruiter)
                .Include(j => j.Interviews)
                .Include(j => j.User)
                .Where(j => j.UserId == user.Id); 
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: JobApplications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var jobApplication = await _context.JobApplication
                .Include(j => j.Recruiter)
                .Include(j => j.Interviews)
                .Include(j => j.User)
                .Where(j => j.UserId == user.Id)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobApplication == null)
            {
                return NotFound();
            }

            return View(jobApplication);
        }

        // GET: JobApplications/Create
        public IActionResult Create()
        {
            var recruiterList = new SelectList(_context.Recruiter, "Id", "FullName").ToList();
            recruiterList.Insert(0, new SelectListItem
            {
                Text = "Select Recruiter",
                Value = "null"
            });
            ViewData["RecruiterId"] = recruiterList; return View();
        }

        // POST: JobApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,DateCreated,CompanyName,Position,RecruiterId,PositionLink,Rejected,Offer,LastContact,Notes,IsActive")] JobApplication jobApplication)
        {
            if (jobApplication.RecruiterId.ToString() == "null")
            {
                jobApplication.RecruiterId = null;
            }

            ModelState.Remove("UserId");
            ModelState.Remove("RecruiterId");
            if (ModelState.IsValid)
            {
                var user = await GetUserAsync();
                jobApplication.UserId = user.Id;
                _context.Add(jobApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var recruiterList = new SelectList(_context.Recruiter, "Id", "FullName", jobApplication.RecruiterId).ToList();
            recruiterList.Insert(0, new SelectListItem
            {
                Text = "Select Recruiter",
                Value = "null"
            });
            ViewData["RecruiterId"] = recruiterList;
            return View(jobApplication);
        }

        // GET: JobApplications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobApplication = await _context.JobApplication
               .Include(j => j.Interviews)
               .FirstOrDefaultAsync(m => m.Id == id);
            if (jobApplication == null)
            {
                return NotFound();
            }
            var recruiterList = new SelectList(_context.Recruiter, "Id", "FullName", jobApplication.RecruiterId).ToList();
            recruiterList.Insert(0, new SelectListItem
            {
                Text = "Select Recruiter",
                Value = "null"
            });
            ViewData["RecruiterId"] = recruiterList;
            return View(jobApplication);
        }

        // POST: JobApplications/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,DateCreated,CompanyName,Position,RecruiterId,PositionLink,Rejected,Offer,LastContact,Notes,IsActive")] JobApplication jobApplication)
        {
            if (jobApplication.RecruiterId.ToString() == "null")
            {
                jobApplication.RecruiterId = null;
            }

            if (id != jobApplication.Id)
            {
                return NotFound();
            }

            ModelState.Remove("UserId");
            ModelState.Remove("RecruiterId");
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await GetUserAsync();
                    jobApplication.UserId = user.Id;
                    _context.Update(jobApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobApplicationExists(jobApplication.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var recruiterList = new SelectList(_context.Recruiter, "Id", "FullName", jobApplication.RecruiterId).ToList();
            recruiterList.Insert(0, new SelectListItem
            {
                Text = "Select Recruiter",
                Value = "null"
            });
            ViewData["RecruiterId"] = recruiterList;
            return View(jobApplication);
        }

        // GET: JobApplications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobApplication = await _context.JobApplication
                .Include(j => j.Recruiter)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobApplication == null)
            {
                return NotFound();
            }

            return View(jobApplication);
        }

        // POST: JobApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobApplication = await _context.JobApplication.FindAsync(id);
            _context.JobApplication.Remove(jobApplication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobApplicationExists(int id)
        {
            return _context.JobApplication.Any(e => e.Id == id);
        }

        private Task<ApplicationUser> GetUserAsync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
        }
    }
}
