using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using HelpToHealthApi.Entities;
using HelpToHealthApi.Models;

namespace HelpToHealthApi
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CareGiverEntity, CareGiverModel>();


            CreateMap<CareVolunteerEntity, CareVolunteerModel>();
        }
    }
}
