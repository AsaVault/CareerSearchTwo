using CareerSearchTwo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Repository
{
    interface IFunctionalAreaRepository
    {
        Task <IEnumerable<FunctionalArea>> GetAll();
        Task<FunctionalArea> Get(int id);
        Task Remove(int id);
        Task Update(FunctionalArea functionalArea);
        Task Add(FunctionalArea functionalArea);


        
    }
}
