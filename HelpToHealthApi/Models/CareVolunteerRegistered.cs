using HelpToHealthApi.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpToHealthApi.Models
{
    public class CareVolunteerRegistered
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public int AvailabilityFrom { get; set; }

        public int AvailabilityTo { get; set; }

        public string WillingToDo { get; set; }

        public string TrainingCompleted { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        private string _password;

        public string Password
        {
            get
            {
                return _password.Base64Decode();
            }
            set
            {
                _password = value.Base64Encode();
            }
        }
    }
}
