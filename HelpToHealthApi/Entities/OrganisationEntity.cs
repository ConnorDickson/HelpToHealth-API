﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpToHealthApi.Entities
{
    public class OrganisationEntity
    {
        public int ID { get; set; }

        public string OrganisationType { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<CareGiverEntity> CareGivers { get; set; }
    }
}
