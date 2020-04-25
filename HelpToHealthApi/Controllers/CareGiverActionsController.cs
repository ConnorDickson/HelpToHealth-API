using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpToHealthApi.Data;
using HelpToHealthApi.Entities;
using RestSharp;
using GoogleApi.Entities.Maps.DistanceMatrix.Response;
using GoogleApi.Entities.Maps.DistanceMatrix.Request;
using GoogleApi;

namespace HelpToHealthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareGiverActionsController : ControllerBase
    {
        private readonly HelpToHealthApiContext _context;
        private readonly IRestClient _googleApiClient;

        public string GoogleAPIKey { get; }

        public CareGiverActionsController(HelpToHealthApiContext context, IRestClient googleAPIClient, string googleAPIKey)
        {
            _context = context;
            _googleApiClient = googleAPIClient;
            GoogleAPIKey = googleAPIKey;
        }

        // GET: api/CareGiverActions
        [HttpGet]
        [Route("nearLocation")]
        public async Task<ActionResult<IEnumerable<CareGiverEntity>>> GetCareVolunteersNearLocation(string clientLocation)
        {
            //Get all careVolunteer locations
            var volunteers = await _context.CareVolunteers.ToListAsync();
            var volunteerAddresses = string.Join('|', volunteers.Select(x => x.Address).ToArray());

            //Google API search near location
            var r = new DistanceMatrixRequest
            {
                OriginsRaw = volunteerAddresses,
                DestinationsRaw = clientLocation,
                Units = GoogleApi.Entities.Maps.Common.Enums.Units.Imperial,
                Key = GoogleAPIKey
            };
            var re = GoogleMaps.DistanceMatrix.Query(r);

            foreach (var volunteer in volunteers)
            {

            }
            
            return Ok(re);
        }

        // GET: api/CareGiverActions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CareGiverEntity>>> GetCareGiverEntity()
        {
            return await _context.CareGivers.ToListAsync();
        }

        // GET: api/CareGiverActions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CareGiverEntity>> GetCareGiverEntity(int id)
        {
            var careGiverEntity = await _context.CareGivers.FindAsync(id);

            if (careGiverEntity == null)
            {
                return NotFound();
            }

            return careGiverEntity;
        }

        // PUT: api/CareGiverActions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCareGiverEntity(int id, CareGiverEntity careGiverEntity)
        {
            if (id != careGiverEntity.ID)
            {
                return BadRequest();
            }

            _context.Entry(careGiverEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CareGiverEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CareGiverActions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Route("registerCareGiver")]
        public async Task<ActionResult<CareGiverEntity>> RegisterCareGiver(CareGiverEntity careGiverEntity)
        {
            _context.CareGivers.Add(careGiverEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCareGiverEntity", new { id = careGiverEntity.ID }, careGiverEntity);
        }

        private bool CareGiverEntityExists(int id)
        {
            return _context.CareGivers.Any(e => e.ID == id);
        }
    }
}
