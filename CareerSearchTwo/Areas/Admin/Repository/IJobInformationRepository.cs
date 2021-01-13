using CareerSearchTwo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    interface IJobInformationRepository
    {
        Task<IEnumerable<JobInformation>> GetAll();
        Task<JobInformation> Get(int id);
        Task Remove(int id);
        Task Update(JobInformation jobInformation);
        Task Add(JobInformation jobInformation);
    }
}
