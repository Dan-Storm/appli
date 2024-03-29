﻿using System;
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
    public class InterviewsController : Controller
    {
        private readonly ApplicationDbContext _context;
        //private readonly UserManager<ApplicationUser> _userManager;

        public InterviewsController(ApplicationDbContext context/*, UserManager<ApplicationUser> userManager*/)
        {
            _context = context;
            //_userManager = userManager;

        }

        // GET: Interviews
        public async Task<IActionResult> Index(int? id)
        {
            var applicationDbContext = await _context.Interview
                .Include(i => i.JobApplication)
                .Where(i => i.JobApplicationId == id)
                .ToListAsync();
            if (applicationDbContext.Count == 0)
            {
                return RedirectToAction(nameof(Create), new { JobApplicationId = id });
            }
            return View(applicationDbContext);
        }

        // GET: Interviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interview
                .Include(i => i.JobApplication)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interview == null)
            {
                return NotFound();
            }

            return View(interview);
        }

        // GET: Interviews/Create
        public IActionResult Create(int? JobApplicationId)
        {

            ViewData["JobApplicationId"] = JobApplicationId;
            return View();
        }

        // POST: Interviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JobApplicationId,Date,Address,Notes")] Interview interview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = interview.JobApplicationId });
            }
            ViewData["JobApplicationId"] = new SelectList(_context.JobApplication, "Id", "CompanyName", interview.JobApplicationId);
            return View(interview);
        }

        // GET: Interviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interview.FindAsync(id);
            if (interview == null)
            {
                return NotFound();
            }
            ViewData["JobApplicationId"] = new SelectList(_context.JobApplication, "Id", "CompanyName", interview.JobApplicationId);
            return View(interview);
        }

        // POST: Interviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JobApplicationId,Date,Address,Notes")] Interview interview)
        {
            if (id != interview.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterviewExists(interview.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = interview.JobApplicationId});
            }
            ViewData["JobApplicationId"] = new SelectList(_context.JobApplication, "Id", "CompanyName", interview.JobApplicationId);
            return View(interview);
        }

        // GET: Interviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interview
                .Include(i => i.JobApplication)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interview == null)
            {
                return NotFound();
            }

            return View(interview);
        }

        // POST: Interviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interview = await _context.Interview.FindAsync(id);
            _context.Interview.Remove(interview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { id = interview.JobApplicationId });
        }

        private bool InterviewExists(int id)
        {
            return _context.Interview.Any(e => e.Id == id);
        }
    }
}
