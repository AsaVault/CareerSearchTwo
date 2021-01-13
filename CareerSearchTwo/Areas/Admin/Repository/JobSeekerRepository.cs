using CareerSearchTwo.Areas.Admin.Data;
using CareerSearchTwo.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    public class JobSeekerRepository : IJobSeekerRepository
    {
        private readonly ApplicationDbContext _context;
        public JobSeekerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(JobSeeker jobseeker)
        {
            await _context.JobSeekers.AddAsync(jobseeker);
            await _context.SaveChangesAsync();
        }

        public async Task<JobSeeker> Get(int id)
        {
            var get = await _context.JobSeekers.FindAsync(id);
            return get;
        }

        public async Task<IEnumerable<JobSeeker>> GetAll()
        {
            var getAll = await _context.JobSeekers.OrderByDescending(a => a.Id).ToListAsync();
            return getAll;
        }

        public async Task Remove(int id)
        {
            var delete = await _context.JobSeekers.FindAsync(id);
            _context.JobSeekers.Remove(delete);
            await _context.SaveChangesAsync();
        }

        public async Task Update(JobSeeker jobseeker)
        {
            _context.JobSeekers.Update(jobseeker);
            await _context.SaveChangesAsync();

        }
    }
}
