using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace HelpToHealthApi.Entities
{
    public class CareGiverEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int OrganisationEntityID { get; set; }

        public OrganisationEntity Organisation { get; set; }

        public string Availability { get; set; }

        public string TypesOfCare { get; set; }

    }
}
