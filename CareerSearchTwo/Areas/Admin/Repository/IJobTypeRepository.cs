using CareerSearchTwo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    public interface IJobTypeRepository
    {
        Task<IEnumerable<JobType>> GetAll();
        Task<JobType> Get(int id);
        Task Remove(int id);
        Task Update(JobType jobType);
        Task Add(JobType jobType);
    }
}
