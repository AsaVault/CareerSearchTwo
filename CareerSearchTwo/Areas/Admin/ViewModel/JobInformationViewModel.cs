using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.ViewModel
{
    public class JobInformationViewModel
    {
        public int Id { get; set; }
        public string Qualification { get; set; }
        public string Salary { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string AgeLimit { get; set; }

    }
}
