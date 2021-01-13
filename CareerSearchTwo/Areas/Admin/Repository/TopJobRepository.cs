using CareerSearchTwo.Areas.Admin.Data;
using CareerSearchTwo.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    public class TopJobRepository : ITopJobRepository
    {
        private readonly ApplicationDbContext _context;
        public TopJobRepository(ApplicationDbContext context)
        {

        }

        public async Task Add(TopJob topJob)
        {
            await _context.TopJobs.AddAsync(topJob);
            await _context.SaveChangesAsync();
        }

        public async Task<TopJob> Get(int id)
        {
            var get = await _context.TopJobs.FindAsync(id);
            return get;
        }

        public async Task<IEnumerable<TopJob>> GetAll()
        {
            var getAll = await _context.TopJobs.OrderByDescending(a => a.Id).ToListAsync();
            return getAll;
        }

        public async Task Remove(int id)
        {
            var delete = await _context.TopJobs.FindAsync(id);
            _context.TopJobs.Remove(delete);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TopJob topJob)
        {
            _context.TopJobs.Update(topJob);
            await _context.SaveChangesAsync();
        }
    }
}
