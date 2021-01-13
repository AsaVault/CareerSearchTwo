using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Models
{
    public class JobType
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public JobEmployer JobEmployers { get; set; }
        public ICollection<JobInformation> JobInformations { get; set; }


    }
}
