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
    public class CareVolunteerActionsController : ControllerBase
    {
        private readonly HelpToHealthApiContext _context;

        public CareVolunteerActionsController(HelpToHealthApiContext context)
        {
            _context = context;
        }

        // GET: api/CareVolunteerActions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CareVolunteerEntity>>> GetCareVolunteerEntity()
        {
            return await _context.CareVolunteerEntity.ToListAsync();
        }

        // GET: api/CareVolunteerActions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CareVolunteerEntity>> GetCareVolunteerEntity(int id)
        {
            var careVolunteerEntity = await _context.CareVolunteerEntity.FindAsync(id);

            if (careVolunteerEntity == null)
            {
                return NotFound();
            }

            return careVolunteerEntity;
        }

        // PUT: api/CareVolunteerActions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCareVolunteerEntity(int id, CareVolunteerEntity careVolunteerEntity)
        {
            if (id != careVolunteerEntity.ID)
            {
                return BadRequest();
            }

            _context.Entry(careVolunteerEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CareVolunteerEntityExists(id))
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

        // POST: api/CareVolunteerActions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Route("registerCareVolunteer")]
        public async Task<ActionResult<CareVolunteerEntity>> RegisterCareVolunteer(CareVolunteerEntity careVolunteerEntity)
        {
            _context.CareVolunteerEntity.Add(careVolunteerEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCareVolunteerEntity", new { id = careVolunteerEntity.ID }, careVolunteerEntity);
        }

        // DELETE: api/CareVolunteerActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CareVolunteerEntity>> DeleteCareVolunteerEntity(int id)
        {
            var careVolunteerEntity = await _context.CareVolunteerEntity.FindAsync(id);
            if (careVolunteerEntity == null)
            {
                return NotFound();
            }

            _context.CareVolunteerEntity.Remove(careVolunteerEntity);
            await _context.SaveChangesAsync();

            return careVolunteerEntity;
        }

        private bool CareVolunteerEntityExists(int id)
        {
            return _context.CareVolunteerEntity.Any(e => e.ID == id);
        }
    }
}
