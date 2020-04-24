using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpToHealthApi.Entities
{
    public class CareVolunteerEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public int AvailabilityFrom { get; set; }

        public int AvailabilityTo { get; set; }

        public List<string> WillingToDo { get; set; }

        public List<string> TrainingCompleted { get; set; }

        public decimal XCoordinate { get; set; }

        public decimal YCoordinate { get; set; }
    }
}
