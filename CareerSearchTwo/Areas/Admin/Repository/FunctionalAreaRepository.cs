using CareerSearchTwo.Areas.Admin.Data;
using CareerSearchTwo.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    public class FunctionalAreaRepository : IFunctionalAreaRepository
    {
        private readonly ApplicationDbContext _context;
        public FunctionalAreaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(FunctionalArea functionalArea)
        {
            await _context.FunctionalAreas.AddAsync(functionalArea);
            await _context.SaveChangesAsync();
        }

        public async Task<FunctionalArea> Get(int id)
        {
            var get = await _context.FunctionalAreas.FindAsync(id);
            return get;
        }

        public async Task<IEnumerable<FunctionalArea>> GetAll()
        {
            var getAll = await _context.FunctionalAreas.OrderByDescending(a => a.Id).ToListAsync();
            return getAll;

        }

        public async Task Remove(int id)
        {
             var delete = await _context.FunctionalAreas.FindAsync(id);
            _context.FunctionalAreas.Remove(delete);
            await _context.SaveChangesAsync();
        }

        public async Task Update(FunctionalArea functionalArea)
        {
            _context.FunctionalAreas.Update(functionalArea);
            await _context.SaveChangesAsync();
        }
    }
}
