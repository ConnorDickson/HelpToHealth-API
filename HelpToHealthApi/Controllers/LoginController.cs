using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HelpToHealthApi.Data;
using HelpToHealthApi.Entities;
using HelpToHealthApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpToHealthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly HelpToHealthApiContext _context;

        public LoginController(HelpToHealthApiContext context, IMapper mapper)
        {
            _context = context;
            Mapper = mapper;
        }

        public IMapper Mapper { get; }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginDetails)
        {
            var careGiver = _context.CareGivers.FirstOrDefault(x => x.Name.Equals(loginDetails.Username) && x.Password.Equals(loginDetails.Password));

            if (careGiver != null)
            {
                return Ok(Mapper.Map<CareGiverModel>(careGiver));
            }

            var volunteer = _context.CareVolunteers.FirstOrDefault(x => x.Name.Equals(loginDetails.Username) && x.Password.Equals(loginDetails.Password));

            if (volunteer != null)
            {
                return Ok(Mapper.Map<CareVolunteerModel>(volunteer));
            }

            return NotFound();
        }

    }
}