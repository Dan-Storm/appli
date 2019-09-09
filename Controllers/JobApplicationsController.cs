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

namespace Appli.Controllers
{
    [Authorize]
    public class JobApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JobApplications
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.JobApplication.Include(j => j.Recruiter);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: JobApplications/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: JobApplications/Create
        public IActionResult Create()
        {
            ViewData["RecruiterId"] = new SelectList(_context.Recruiter, "Id", "EmailAddress");
            return View();
        }

        // POST: JobApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,DateCreated,NextInterview,CompanyName,Position,RecruiterId,PositionLink,Rejected,Offer,LastContact,Notes,IsActive")] JobApplication jobApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RecruiterId"] = new SelectList(_context.Recruiter, "Id", "EmailAddress", jobApplication.RecruiterId);
            return View(jobApplication);
        }

        // GET: JobApplications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobApplication = await _context.JobApplication.FindAsync(id);
            if (jobApplication == null)
            {
                return NotFound();
            }
            ViewData["RecruiterId"] = new SelectList(_context.Recruiter, "Id", "EmailAddress", jobApplication.RecruiterId);
            return View(jobApplication);
        }

        // POST: JobApplications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,DateCreated,NextInterview,CompanyName,Position,RecruiterId,PositionLink,Rejected,Offer,LastContact,Notes,IsActive")] JobApplication jobApplication)
        {
            if (id != jobApplication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
            ViewData["RecruiterId"] = new SelectList(_context.Recruiter, "Id", "EmailAddress", jobApplication.RecruiterId);
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
    }
}