using CareerSearchTwo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.ViewModel
{
    public class JobTypeViewModel
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public JobEmployer JobEmployers { get; set; }
        public ICollection<JobInformation> JobInformations { get; set; }
    }
}
