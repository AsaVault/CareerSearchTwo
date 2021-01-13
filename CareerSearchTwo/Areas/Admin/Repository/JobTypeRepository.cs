using CareerSearchTwo.Areas.Admin.Data;
using CareerSearchTwo.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    public class JobTypeRepository : IJobTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public JobTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(JobType jobType)
        {
            await _context.jobTypes.AddAsync(jobType);
            await _context.SaveChangesAsync();
        }

        public async Task<JobType> Get(int id)
        {
            var get = await _context.jobTypes.FindAsync(id);
            return get;
        }

        public async Task<IEnumerable<JobType>> GetAll()
        {
            var getAll = await _context.jobTypes.OrderByDescending(a => a.Id).ToListAsync();
            return getAll;
        }

        public async Task Remove(int id)
        {
            var delete = await _context.jobTypes.FindAsync(id);
            _context.jobTypes.Remove(delete);
           await _context.SaveChangesAsync();
        }

        public async Task Update(JobType jobType)
        {
            _context.jobTypes.Update(jobType);
            await _context.SaveChangesAsync();
        }
    }
}
