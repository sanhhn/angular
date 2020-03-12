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
    public class GridColumnsController : ControllerBase
     {
         private readonly DbApiContext _context;

        public GridColumnsController(DbApiContext context)
        {
            _context = context;
        }

        // // GET: api/GridColumns
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<GridColumns>>> GetGridColumns()
        // {
        //     return await _context.GridColumns.ToListAsync();
        // }

        // GET: api/GridColumns/5
        [HttpGet]
        public async Task<ActionResult<GridColumns>> GetGridColumns(string gridKey)
        {
            var gridColumns = await _context.GridColumns.Where(e => e.GridKey == gridKey).ToListAsync();

            if (!gridColumns.Any())
            {
                return NotFound();
            }

            return Ok(gridColumns);
        }

        // PUT: api/GridColumns/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGridColumns(string id, GridColumns gridColumns)
        {
            string[] ids = id.Split(';');

            if(ids.Length == 0) return BadRequest();

            string projectCode = ids[0];
            string gridKey = ids[1];
            string columnName = ids[2];

            if (projectCode != gridColumns.GridKey || gridKey != gridColumns.GridKey || columnName != gridColumns.ColumnName)
            {
                return BadRequest();
            }

            _context.Entry(gridColumns).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GridColumnsExists(projectCode, gridKey, columnName))
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

        // POST: api/GridColumns
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<GridColumns>> PostGridColumns(GridColumns gridColumns)
        {
            _context.GridColumns.Add(gridColumns);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GridColumnsExists(gridColumns.ProjectCode, gridColumns.GridKey, gridColumns.ColumnName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetGridColumns), new { id = gridColumns.GridKey }, gridColumns);
        }

        // DELETE: api/GridColumns/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GridColumns>> DeleteGridColumns(string id)
        {
            string[] ids = id.Split(';');

            if(ids.Length == 0) return BadRequest();

            string projectCode = ids[0];
            string gridKey = ids[1];
            string columnName = ids[2];

            var gridColumns = await _context.GridColumns.FindAsync(id);
            if (gridColumns == null)
            {
                return NotFound();
            }

            _context.GridColumns.Remove(gridColumns);
            await _context.SaveChangesAsync();

            return gridColumns;
        }

        private bool GridColumnsExists(string projectCode, string gridKey, string columnName)
        {
            return _context.GridColumns.Any(e => e.ProjectCode == projectCode && e.GridKey == gridKey && e.ColumnName == columnName );
        }
    }
}
