using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Models
{
    public class TopJob
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public JobEmployer JobEmployer { get; set; }
        public  ICollection<JobInformation> JobInformations { get; set; }
        public ICollection<FunctionalArea> FunctionalAreas { get; set; } //Many to Many With FuntionalArea(i used Collection Navigation Properties for both)


    }
}
