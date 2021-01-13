using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Models
{
    public class FunctionalArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public JobEmployer JobEmployers { get; set; }
        public WalkIn WalkIns { get; set; }
        public ICollection<TopJob> TopJobs { get; set; } //Many to Many With FuntionalArea(i used Collection Navigation Properties for both)


    }
}
