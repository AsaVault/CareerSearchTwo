using CareerSearchTwo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    public interface ITopJobRepository
    {
        Task<IEnumerable<TopJob>> GetAll();
        Task<TopJob> Get(int id);
        Task Remove(int id);
        Task Update(TopJob topJob);
        Task Add(TopJob topJob);
    }
}
