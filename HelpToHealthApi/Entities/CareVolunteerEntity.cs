﻿using HelpToHealthApi.Extensions;

namespace HelpToHealthApi.Entities
{
    public class CareVolunteerEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string AvailabilityFrom { get; set; }

        public string AvailabilityTo { get; set; }

        public string WillingToDo { get; set; }

        public string TrainingCompleted { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }
    }
}
