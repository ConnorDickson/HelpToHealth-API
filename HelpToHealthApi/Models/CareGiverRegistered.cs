﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpToHealthApi.Models
{
    public class CareGiverRegistered
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}