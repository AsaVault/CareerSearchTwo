using CareerSearchTwo.Areas.Admin.Data;
using CareerSearchTwo.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    
    public class JobEmployerRepository : IJobEmployerRepository

    {
        private readonly ApplicationDbContext _context;
        public JobEmployerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(JobEmployer jobEmployer)
        {
            await _context.JobEmployers.AddAsync(jobEmployer);
            await _context.SaveChangesAsync();
        }

        public async Task<JobEmployer> Get(int id)
        {
            var get = await _context.JobEmployers.FindAsync(id);
            return get;

        }

        public async Task<IEnumerable<JobEmployer>> GetAll()
        {
            var getAll = await _context.JobEmployers.OrderByDescending(a => a.Id).ToListAsync();
            return getAll;
        }

        public async Task Remove(int id)
        {
            var delete = await _context.JobEmployers.FindAsync(id);
            _context.JobEmployers.Remove(delete);
            await _context.SaveChangesAsync();
        }

        public async Task Update(JobEmployer jobEmployer)
        {
            _context.JobEmployers.Update(jobEmployer);
            await _context.SaveChangesAsync();

        }
    }
}
