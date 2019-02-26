using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicalAppointment.Core;
using MedicalAppointment.Core.Entities;

namespace MedicalAppointment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisponibilityController : ControllerBase
    {
        private readonly MedicalAppointmentContext _context;

        public DisponibilityController(MedicalAppointmentContext context)
        {
            _context = context;
        }

        // GET: api/Disponibility
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Disponibility>>> GetDisponibility()
        {
            return await _context.Disponibility.ToListAsync();
        }

        // GET: api/Disponibility/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Disponibility>> GetDisponibility(Guid id)
        {
            var disponibility = await _context.Disponibility.FindAsync(id);

            if (disponibility == null)
            {
                return NotFound();
            }

            return disponibility;
        }

        // PUT: api/Disponibility/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDisponibility(Guid id, Disponibility disponibility)
        {
            if (id != disponibility.DisponibilityId)
            {
                return BadRequest();
            }

            _context.Entry(disponibility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DisponibilityExists(id))
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

        // POST: api/Disponibility
        [HttpPost]
        public async Task<ActionResult<Disponibility>> PostDisponibility(Disponibility disponibility)
        {
            _context.Disponibility.Add(disponibility);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDisponibility", new { id = disponibility.DisponibilityId }, disponibility);
        }

        // DELETE: api/Disponibility/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Disponibility>> DeleteDisponibility(Guid id)
        {
            var disponibility = await _context.Disponibility.FindAsync(id);
            if (disponibility == null)
            {
                return NotFound();
            }

            _context.Disponibility.Remove(disponibility);
            await _context.SaveChangesAsync();

            return disponibility;
        }

        private bool DisponibilityExists(Guid id)
        {
            return _context.Disponibility.Any(e => e.DisponibilityId == id);
        }
    }
}
