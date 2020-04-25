using HelpToHealthApi.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HelpToHealthApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(HelpToHealthApiContext context)
        {
            context.Database.EnsureCreated();

            context.Database.ExecuteSqlRaw("TRUNCATE TABLE CareGivers");
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE CareVolunteers");

            var organisation = new OrganisationEntity
            {
                Email = "organisation@htomail.co.uk",
                Name = "Hospital A",
                OrganisationType = "Public",
                CareGivers = new List<CareGiverEntity>()
            };

            var careGivers = new CareGiverEntity[]
            {
                new CareGiverEntity
                {
                    Address = "1 Apple Park Way, Cupertino, CA 95014, USA",
                    Email = "careGiver1@hotmail.co.uk",
                    Name = "John Smith",
                    PhoneNumber = "07813116321"
                },
                new CareGiverEntity
                {
                    Address = "26 Federal Plaza, New York, NY 10278, USA",
                    Email = "careGiver2@hotmail.co.uk",
                    Name = "Sam Dickkson",
                    PhoneNumber = "07813129431"
                },
                new CareGiverEntity
                {
                    Address = "Legacy Bldg, Belfast BT3 9DT, UK",
                    Email = "careGiver3@hotmail.co.uk",
                    Name = "Sarah Woodview",
                    PhoneNumber = "07813038729"
                }
            };

            foreach (CareGiverEntity careGiver in careGivers)
            {
                organisation.CareGivers.Add(careGiver);
            }

            context.Organisations.Add(organisation);

            var careVolunteers = new CareVolunteerEntity[]
            {
                new CareVolunteerEntity
                {
                    Address = "5 Ormonde Cres, Belfast BT6 9FL, UK",
                    PhoneNumber = "07712345432",
                    Name = "Faraz Goff",
                    Latitude = 54.5847523M,
                    Longitude = -5.891415599999999M,
                    Password = "testPassword1",
                    TrainingCompleted = "No",
                    WillingToDo = "Shopping",
                    AvailabilityFrom = "Mon 9am",
                    AvailabilityTo = "Fri 5pm",
                    Email = "Email"
                },
                new CareVolunteerEntity
                {
                    Address = "12 Loopland Parade, Belfast BT6 9EF, UK",
                    PhoneNumber = "07718437432",
                    Name = "Tony Ryan",
                    Latitude = 54.5858078M,
                    Longitude = -5.893081200000001M,
                    Password = "testPassword2",
                    TrainingCompleted = "No",
                    WillingToDo = "Shopping",
                    AvailabilityFrom = "Mon 9am",
                    AvailabilityTo = "Fri 5pm",
                    Email = "Email"
                },
                new CareVolunteerEntity
                {
                    Address = "42 Orby Gardens, Belfast BT5 5HS, UK",
                    PhoneNumber = "07718437432",
                    Name = "Koa Sharp",
                    Latitude = 54.5871322M,
                    Longitude = -5.8904577M,
                    Password = "testPassword3",
                    TrainingCompleted = "No",
                    WillingToDo = "Shopping",
                    AvailabilityFrom = "Mon 9am",
                    AvailabilityTo = "Fri 5pm",
                    Email = "Email"
                },
                new CareVolunteerEntity
                {
                    Address = "6 Balkan St, Belfast BT12 4FG, UK",
                    PhoneNumber = "07718437432",
                    Name = "Nusaybah Cairns",
                    Latitude = 54.5973224M,
                    Longitude = -5.948408800000002M,
                    Password = "testPassword4",
                    TrainingCompleted = "No",
                    WillingToDo = "Shopping",
                    AvailabilityFrom = "Mon 9am",
                    AvailabilityTo = "Fri 5pm",
                    Email = "Email"
                },
                new CareVolunteerEntity
                {
                    Address = "13 Oaklands Antrim BT41 1LS",
                    PhoneNumber = "07718437432",
                    Name = "Myra Baxter",
                    Latitude = 54.714300M,
                    Longitude = -6.191598M,
                    Password = "testPassword5",
                    TrainingCompleted = "No",
                    WillingToDo = "Shopping",
                    AvailabilityFrom = "Mon 9am",
                    AvailabilityTo = "Fri 5pm",
                    Email = "Email"
                },
            };

            foreach (var careGiver in careVolunteers)
            {
                context.CareVolunteers.Add(careGiver);
            }

            
            context.SaveChanges();
        }
    }
}
