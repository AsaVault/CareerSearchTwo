
using CareerSearchTwo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.ViewModel
{
    public class TopJobViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public JobEmployer JobEmployer { get; set; }
        public ICollection<JobInformation> JobInformations { get; set; }
        public ICollection<FunctionalArea> FunctionalAreas { get; set; }
    }
}
