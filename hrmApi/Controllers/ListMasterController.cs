using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using hrmApi.Models;

namespace hrmApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListMasterController : ControllerBase
    {
        private readonly DbApiContext _context;

        public ListMasterController(DbApiContext context)
        {
            _context = context;
        }

        // GET: api/ListMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SysLists>>> GetSysLists()
        {
            return await _context.SysLists.ToListAsync();
        }

        // GET: api/ListMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SysLists>> GetSysLists(string id)
        {
            var sysLists = await _context.SysLists.FindAsync(id);

            if (sysLists == null)
            {
                return NotFound();
            }

            return sysLists;
        }

        // PUT: api/ListMaster/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSysLists(string id, SysLists sysLists)
        {
            if (id != sysLists.ListID)
            {
                return BadRequest();
            }

            _context.Entry(sysLists).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SysListsExists(id))
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

        // POST: api/ListMaster
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SysLists>> PostSysLists(SysLists sysLists)
        {
            _context.SysLists.Add(sysLists);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SysListsExists(sysLists.ListID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSysLists", new { id = sysLists.ListID }, sysLists);
        }

        // DELETE: api/ListMaster/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SysLists>> DeleteSysLists(string id)
        {
            var sysLists = await _context.SysLists.FindAsync(id);
            if (sysLists == null)
            {
                return NotFound();
            }

            _context.SysLists.Remove(sysLists);
            await _context.SaveChangesAsync();

            return sysLists;
        }

        private bool SysListsExists(string id)
        {
            return _context.SysLists.Any(e => e.ListID == id);
        }
    }
}
