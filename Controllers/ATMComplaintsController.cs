using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using atmcc.Data;
using atmcc.Models;

namespace atmcc.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ATMComplaintssController : ControllerBase
    {
        private readonly atmccContext _context;

        public ATMComplaintssController(atmccContext context)
        {
            _context = context;
        }

        // GET: api/ATMComplaints
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ATMComplaint>>> Get()
        {
            return await _context.ATMComplaint.ToListAsync();
        }

        /*

        // GET: api/ATMComplaints/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ATMComplaint>> GetATMComplaint(int id)
        {
            var aTMComplaint = await _context.ATMComplaint.FindAsync(id);

            if (aTMComplaint == null)
            {
                return NotFound();
            }

            return aTMComplaint;
        }

        PUT: api/ATMComplaints/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutATMComplaint(int id, ATMComplaint aTMComplaint)
        {
            if (id != aTMComplaint.ID)
            {
                return BadRequest();
            }

            _context.Entry(aTMComplaint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ATMComplaintExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        } */

        // POST: api/ATMComplaints
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ATMComplaint>> PostATMComplaint(ATMComplaint aTMComplaint)
        {
            _context.ATMComplaint.Add(aTMComplaint);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetATMComplaint", new { id = 0 }, aTMComplaint);
        }

        // DELETE: api/ATMComplaints/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteATMComplaint(int id)
        {
            var aTMComplaint = await _context.ATMComplaint.FindAsync(id);
            if (aTMComplaint == null)
            {
                return NotFound();
            }

            _context.ATMComplaint.Remove(aTMComplaint);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ATMComplaintExists(string complaintRef)
        {
            return _context.ATMComplaint.Any(e => e.ComplaintRef == complaintRef);
        }
    }
}
