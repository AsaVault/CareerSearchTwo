using CareerSearchTwo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    public interface IJobSeekerRepository
    {
        Task<IEnumerable<JobSeeker>> GetAll();
        Task<JobSeeker> Get(int id);
        Task Remove(int id);
        Task Update(JobSeeker jobseeker);
        Task Add(JobSeeker jobseeker);
    }
}
