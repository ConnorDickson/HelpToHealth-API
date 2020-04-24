using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelpToHealthApi.Entities;

namespace HelpToHealthApi.Data
{
    public class HelpToHealthApiContext : DbContext
    {
        public HelpToHealthApiContext (DbContextOptions<HelpToHealthApiContext> options)
            : base(options)
        {
        }

        public DbSet<HelpToHealthApi.Entities.CareGiverEntity> CareGiverEntity { get; set; }

        public DbSet<HelpToHealthApi.Entities.CareVolunteerEntity> CareVolunteerEntity { get; set; }

        public DbSet<HelpToHealthApi.Entities.OrganisationEntity> OrganisationEntity { get; set; }
    }
}
