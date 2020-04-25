using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpToHealthApi.Models
{
    public class OrganisationRegistered
    {
        public int ID { get; set; }

        public int OrganisationType { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
