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
    public class SpecialistController : ControllerBase
    {
        private readonly MedicalAppointmentContext _context;

        public SpecialistController(MedicalAppointmentContext context)
        {
            _context = context;
        }

        // GET: api/Specialist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Specialist>>> GetSpecialist()
        {
            return await _context.Specialist.ToListAsync();
        }

        // GET: api/Specialist/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Specialist>> GetSpecialist(Guid id)
        {
            var specialist = await _context.Specialist.FindAsync(id);

            if (specialist == null)
            {
                return NotFound();
            }

            return specialist;
        }

        // PUT: api/Specialist/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecialist(Guid id, Specialist specialist)
        {
            if (id != specialist.SpecialistId)
            {
                return BadRequest();
            }

            _context.Entry(specialist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecialistExists(id))
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

        // POST: api/Specialist
        [HttpPost]
        public async Task<ActionResult<Specialist>> PostSpecialist(Specialist specialist)
        {
            _context.Specialist.Add(specialist);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SpecialistExists(specialist.SpecialistId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSpecialist", new { id = specialist.SpecialistId }, specialist);
        }

        // DELETE: api/Specialist/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Specialist>> DeleteSpecialist(Guid id)
        {
            var specialist = await _context.Specialist.FindAsync(id);
            if (specialist == null)
            {
                return NotFound();
            }

            _context.Specialist.Remove(specialist);
            await _context.SaveChangesAsync();

            return specialist;
        }

        private bool SpecialistExists(Guid id)
        {
            return _context.Specialist.Any(e => e.SpecialistId == id);
        }
    }
}
