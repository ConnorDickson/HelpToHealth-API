using HelpToHealthApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace HelpToHealthApi.Data
{
    public class HelpToHealthApiContext : DbContext
    {
        public HelpToHealthApiContext (DbContextOptions<HelpToHealthApiContext> options)
            : base(options)
        {
        }

        public DbSet<CareGiverEntity> CareGivers { get; set; }

        public DbSet<CareVolunteerEntity> CareVolunteers { get; set; }

        public DbSet<OrganisationEntity> Organisations { get; set; }

    }
}
