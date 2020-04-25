using GoogleApi.Entities.Maps.Common;
using HelpToHealthApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpToHealthApi.Models
{
    public class NearbyVolunteersResponse
    {
        public CareVolunteerEntity CareVolunteer { get; set; }

        public Distance Distance { get; set; }

        public Duration Duration { get; set; }
    }
}
