using CareerSearchTwo.Areas.Admin.Data;
using CareerSearchTwo.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    public class JobInformationRepository : IJobInformationRepository
    {
        private readonly ApplicationDbContext _context;
        public JobInformationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(JobInformation jobInformation)
        {
             await _context.JobInformations.AddAsync(jobInformation);
            await _context.SaveChangesAsync();
        }

        public async Task<JobInformation> Get(int id)
        {
            var get = await _context.JobInformations.FindAsync();
            return get;
        }

        public async Task<IEnumerable<JobInformation>> GetAll()
        {
            var getAll = await _context.JobInformations.OrderByDescending(a => a.Id).ToListAsync();
            return getAll;
        }

        public async Task Remove(int id)
        {
            var delete = await _context.JobInformations.FindAsync(id);
            _context.JobInformations.Remove(delete);
            await _context.SaveChangesAsync();
        }

        public async Task Update(JobInformation jobInformation)
        {
            _context.JobInformations.Update(jobInformation);
            await _context.SaveChangesAsync();
        }
    }
}
