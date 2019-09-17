using System;
using System.Collections.Generic;
using System.Text;
using Appli.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Appli.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Interview> Interview { get; set; }
        public DbSet<JobApplication> JobApplication { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //create a date created for JobApplication
            modelBuilder.Entity<JobApplication>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");
            //create a last contact date for JobApplication
            modelBuilder.Entity<JobApplication>()
                .Property(b => b.LastContact)
                .HasDefaultValueSql("GETDATE()");
            //create a date for Interview
            modelBuilder.Entity<Interview>()
                .Property(b => b.Date)
                .HasDefaultValueSql("GETDATE()");

            // Restrict deletion of related Recruiter when Job Application entry is removed
            modelBuilder.Entity<Recruiter>()
                .HasMany(a => a.JobApplications)
                .WithOne(l => l.Recruiter)
                .OnDelete(DeleteBehavior.Restrict);

            // Cascades deletion of related Job Application when Interview entry is removed
            modelBuilder.Entity<JobApplication>()
                .HasMany(a => a.Interviews)
                .WithOne(l => l.JobApplication)
                .OnDelete(DeleteBehavior.Cascade);

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Deep",
                LastName = "Patel",
                UserName = "deep@patel.com",
                NormalizedUserName = "DEEP@PATEL.COM",
                Email = "deep@patel.com",
                NormalizedEmail = "DEEP@PATEL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Password1?");
            modelBuilder.Entity<ApplicationUser>().HasData(user);
            modelBuilder.Entity<Interview>().HasData(
                new Interview()
                {
                    Id = 1,
                    JobApplicationId = 1,
                    Date = DateTime.Now.Date,
                    Address = "510 Old Hickory Blvd",
                    Notes = "Wear a nice shirt"
                },
                new Interview()
                {
                    Id = 2,
                    JobApplicationId = 1,
                    Date = DateTime.Now.Date.AddDays(+10),
                    Address = "50 Hickory Blvd",
                    Notes = "Wear a really nice shirt"
                },
                new Interview()
                {
                    Id = 3,
                    JobApplicationId = 2,
                    Date = DateTime.Now.Date.AddDays(+17),
                    Address = "5100 Old Blvd",
                    Notes = "Wear a nice shirt like Deep would"
                },
                new Interview()
                {
                    Id = 4,
                    JobApplicationId = 2,
                    Date = DateTime.Now.Date.AddDays(+10),
                    Address = "100 Old Town Road",
                    Notes = "Smile"
                }
            );
            modelBuilder.Entity<Recruiter>().HasData(
                new Recruiter()
                {
                    Id = 1,
                    UserId = user.Id,
                    FullName = "Janki Patel",
                    PhoneNumber = "615-224-2345",
                    EmailAddress = "janki@deep.com",
                    IsActive = true,
                },
                new Recruiter()
                {
                    Id = 2,
                    UserId = user.Id,
                    FullName = "Anuj Patel",
                    PhoneNumber = "615-334-4565",
                    EmailAddress = "anuj@deep.com",
                    IsActive = true,

                },
                new Recruiter()
                {
                    Id = 3,
                    UserId = user.Id,
                    FullName = "Shreeda Patel",
                    PhoneNumber = "847-123-4565",
                    EmailAddress = "Shreeda@deep.com",
                    IsActive = true,
                }
            );
            modelBuilder.Entity<JobApplication>().HasData(
               new JobApplication()
               {
                   Id = 1,
                   UserId = user.Id,
                   CompanyName = "Google",
                   Position = "Full Stack Dev",
                   Offer = "$1,000,000 and dental",
                   LastContact = DateTime.Now.AddDays(-10),
                   PositionLink = "www.google.com",
                   Rejected = false,
                   IsActive = true,
                   Notes = "I'm still on the fence about this company, I was hoping for more health coverage than dental"
               },
               new JobApplication()
               {
                   Id = 2,
                   UserId = user.Id,
                   CompanyName = "Apple",
                   Position = "Front End Dev",
                   Offer = "$1,000,001 and vision",
                   LastContact = DateTime.Now.AddDays(-3),
                   PositionLink = "www.apple.com",
                   Rejected = false,
                   IsActive = true,
                   Notes = "Really like this company, I'm just more of an orange guy"
                },
                new JobApplication()
                {
                    Id = 3,
                    UserId = user.Id,
                    CompanyName = "Facebook",
                    Position = "React End Dev",
                    Offer = "$1,000,002 and health",
                    LastContact = DateTime.Now.AddDays(-6),
                    PositionLink = "www.facebook.com",
                    Rejected = false,
                    IsActive = true,
                    Notes = "Really dont like this company, pretty sure the CEO is a lizard person"
                }
           );
        }
    }
}