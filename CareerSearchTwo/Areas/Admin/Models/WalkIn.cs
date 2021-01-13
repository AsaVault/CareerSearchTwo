using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Models
{
    public class WalkIn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public ICollection<FunctionalArea> FunctionalAreas { get; set; }
        public JobEmployer JobEmployer { get; set; }


    }
}
