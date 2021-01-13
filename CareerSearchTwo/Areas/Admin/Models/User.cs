using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Models
{
    public class User : IdentityUser
    {
        public int id { get; set; }
        public int FulName { get; set; }
        public ICollection <JobSeeker> JobSeekers { get; set; }
        public ICollection<JobEmployer> JobEmployers { get; set; }
        public string Tel { get; internal set; }
    }
}
