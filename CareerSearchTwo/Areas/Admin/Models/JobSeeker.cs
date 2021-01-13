using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Models
{
    public class JobSeeker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Qualification { get; set; }
        public int Age { get; set; }
        public  string UploadFile { get; set; }
        public string ExperienceLevel { get; set; }
        public string Skills { get; set; }
        public string ContactInformation { get; set; }
        public User User { get; set; }


    }
}
