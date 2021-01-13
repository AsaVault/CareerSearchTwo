using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Models
{
    public class JobEmployer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyMail { get; set; }
        public string Tel { get; set; }
        public string CompanyLocation { get; set; }
        public ICollection<FunctionalArea> FunctionalAreas { get; set; }
        public ICollection<TopJob> TopJobs { get; set; }
        public ICollection <WalkIn> WalkIns { get; set; }
        public ICollection<JobType> JobType { get; set; }
        public User User { get; set; }





    }
}
