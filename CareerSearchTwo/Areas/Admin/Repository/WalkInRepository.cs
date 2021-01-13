using CareerSearchTwo.Areas.Admin.Data;
using CareerSearchTwo.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    public class WalkInRepository : IWalkInRepository
    {
        private readonly ApplicationDbContext _context;
        public WalkInRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(WalkIn walkIn)
        {
            await _context.WalkIns.AddAsync(walkIn);
            await _context.SaveChangesAsync();
        }

        public async Task<WalkIn> Get(int id)
        {
            var get = await _context.WalkIns.FindAsync(id);
            return get;
        }

        public async Task<IEnumerable<WalkIn>> GetAll()
        {
            var get = await _context.WalkIns.OrderByDescending(a => a.Id).ToListAsync();
            return get;
        }

        public async Task Remove(int id)
        {
            var delete = await _context.WalkIns.FindAsync(id);
            _context.WalkIns.Remove(delete);
            await _context.SaveChangesAsync();
        }

        public async Task Update(WalkIn walkIn)
        {
            _context.WalkIns.Update(walkIn);
            await _context.SaveChangesAsync();
        }
    }
}
