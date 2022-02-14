using atmcc.Data;
using atmcc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atmcc.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ATMComplaintController : ControllerBase
    {
        private atmccContext _context;

        public ATMComplaintController(atmccContext context)
        {
            _context = context;
        }

        // GET: api/ATMComplaints
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ATMComplaint>>> Get()
        {
            return await _context.ATMComplaint.ToListAsync();
        }

        //[HttpGet]
        //public async Task<ActionResult<ATMComplaint>> Get(int id)
        //{
        //    var aTMComplaint = await _context.ATMComplaint.FindAsync(id);

        //    if (aTMComplaint == null)
        //    {
        //        return NotFound();
        //    }

        //    return aTMComplaint;
        //}

        // POST: api/ATMComplaints
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ATMComplaint>> Post(ATMComplaint aTMComplaint)
        {
            _context.ATMComplaint.Add(aTMComplaint);
            await _context.SaveChangesAsync();

           return CreatedAtAction("Get", new { id = 0 }, aTMComplaint.ComplaintRef);
        }

        // DELETE: api/ATMComplaints/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
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
