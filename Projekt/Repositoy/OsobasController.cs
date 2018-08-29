using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Models;

namespace Projekt.Repositoy
{
    [Route("api/[controller]")]
    [ApiController]
    public class OsobasController : ControllerBase
    {
        private readonly EvidencijaIN2ProjekataStudContext _context;

        public OsobasController(EvidencijaIN2ProjekataStudContext context)
        {
            _context = context;
        }

        // GET: api/Osobas
        [HttpGet]
        public IEnumerable<Osoba> GetOsoba()
        {
            return _context.Osoba;
        }

        // GET: api/Osobas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOsoba([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var osoba = await _context.Osoba.FindAsync(id);

            if (osoba == null)
            {
                return NotFound();
            }

            return Ok(osoba);
        }

        // PUT: api/Osobas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOsoba([FromRoute] int id, [FromBody] Osoba osoba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != osoba.IdOsobe)
            {
                return BadRequest();
            }

            _context.Entry(osoba).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OsobaExists(id))
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

        // POST: api/Osobas
        [HttpPost]
        public async Task<IActionResult> PostOsoba([FromBody] Osoba osoba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Osoba.Add(osoba);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOsoba", new { id = osoba.IdOsobe }, osoba);
        }

        // DELETE: api/Osobas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOsoba([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var osoba = await _context.Osoba.FindAsync(id);
            if (osoba == null)
            {
                return NotFound();
            }

            _context.Osoba.Remove(osoba);
            await _context.SaveChangesAsync();

            return Ok(osoba);
        }

        private bool OsobaExists(int id)
        {
            return _context.Osoba.Any(e => e.IdOsobe == id);
        }
    }
}