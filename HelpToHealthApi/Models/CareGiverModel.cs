using HelpToHealthApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpToHealthApi.Models
{
    public class CareGiverModel
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

        public string UserType { get; } = "Professional";
    }
}
