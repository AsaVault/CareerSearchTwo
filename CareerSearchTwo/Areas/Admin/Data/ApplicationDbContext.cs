using CareerSearchTwo.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
                
        }

        public DbSet<FunctionalArea> FunctionalAreas { get; set; }
        public DbSet<JobEmployer> JobEmployers { get; set; }
        public DbSet<JobInformation> JobInformations { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobType> jobTypes { get; set; }
        public DbSet<TopJob> TopJobs { get; set; }
        public DbSet<WalkIn> WalkIns { get; set; }
        public DbSet<User> Users { get; set; }







    }
}
