using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpToHealthApi.Entities
{
    public class CareSeekerEntity
    {
        public int ID { get; set; }

        public int PhoneNumber { get; set; }

        public string Address { get; set; }

        public string CareRequired { get; set; }

        public string WhenNeeded { get; set; }

        public string Name { get; set; }
    }
}
