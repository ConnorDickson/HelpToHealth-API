using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpToHealthApi.Data;
using HelpToHealthApi.Entities;

namespace HelpToHealthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationActionsController : ControllerBase
    {
        private readonly HelpToHealthApiContext _context;

        public OrganisationActionsController(HelpToHealthApiContext context)
        {
            _context = context;
        }

        // GET: api/OrganisationActions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrganisationEntity>>> GetOrganisationEntity()
        {
            return await _context.Organisations.ToListAsync();
        }

        // GET: api/OrganisationActions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrganisationEntity>> GetOrganisationEntity(int id)
        {
            var organisationEntity = await _context.Organisations.FindAsync(id);

            if (organisationEntity == null)
            {
                return NotFound();
            }

            return organisationEntity;
        }

        // PUT: api/OrganisationActions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganisationEntity(int id, OrganisationEntity organisationEntity)
        {
            if (id != organisationEntity.ID)
            {
                return BadRequest();
            }

            _context.Entry(organisationEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganisationEntityExists(id))
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

        // POST: api/OrganisationActions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Route("registerOrganisation")]
        public async Task<ActionResult<OrganisationEntity>> RegisterOrganisationAsync(OrganisationEntity organisationEntity)
        {
            _context.Organisations.Add(organisationEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrganisationEntity", new { id = organisationEntity.ID }, organisationEntity);
        }

        // DELETE: api/OrganisationActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrganisationEntity>> DeleteOrganisationEntity(int id)
        {
            var organisationEntity = await _context.Organisations.FindAsync(id);
            if (organisationEntity == null)
            {
                return NotFound();
            }

            _context.Organisations.Remove(organisationEntity);
            await _context.SaveChangesAsync();

            return organisationEntity;
        }

        private bool OrganisationEntityExists(int id)
        {
            return _context.Organisations.Any(e => e.ID == id);
        }
    }
}
