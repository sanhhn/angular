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
    public class TodoItemsController : ControllerBase
    {
         // // GET: api/ListMaster
        // [HttpGet]
        // public async Task<ActionResult<DataTable>> GetListMaster()
        // {
        //     DataTable table = new DataTable();
        //     table.Columns.Add("Dosage", typeof(int));
        //     table.Columns.Add("Drug", typeof(string));
        //     table.Columns.Add("Patient", typeof(string));
        //     table.Columns.Add("Date", typeof(DateTime));

        //     // Step 3: here we add 5 rows.
        //     table.Rows.Add(25, "Indocin1", "David", DateTime.Now);
        //     table.Rows.Add(50, "Enebrel1", "Sam", DateTime.Now);
        //     table.Rows.Add(10, "Hydralazine1", "Christoff", DateTime.Now);
        //     table.Rows.Add(21, "Combivent1", "Janet", DateTime.Now);
        //     table.Rows.Add(100, "Dilantin1", "Melanie", DateTime.Now);
            
        //     return  await Task.FromResult(table);
        // }

        // // GET: api/ListMaster
        // [Route("GetListMaster2")]
        // [HttpGet]
        // public DataTable GetListMaster2()
        // {
        //     DataTable table = new DataTable();
        //     table.Columns.Add("Dosage", typeof(int));
        //     table.Columns.Add("Drug", typeof(string));
        //     table.Columns.Add("Patient", typeof(string));
        //     table.Columns.Add("Date", typeof(DateTime));

        //     // Step 3: here we add 5 rows.
        //     table.Rows.Add(25, "Indocin", "David", DateTime.Now);
        //     table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
        //     table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
        //     table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
        //     table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);

        //     return  table;
        // }

        
        // private readonly DbApiContext _context;

        // public TodoItemsController(DbApiContext context)
        // {
        //     _context = context;
        // }

        // // GET: api/TodoItems
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        // {
        //     return await _context.TodoItems.ToListAsync();
        // }

        // // GET: api/TodoItems/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        // {
        //     var todoItem = await _context.TodoItems.FindAsync(id);

        //     if (todoItem == null)
        //     {
        //         return NotFound();
        //     }

        //     return todoItem;
        // }

        // // PUT: api/TodoItems/5
        // // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // // more details see https://aka.ms/RazorPagesCRUD.
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        // {
        //     if (id != todoItem.Id)
        //     {
        //         return BadRequest();
        //     }

        //     // _context.Entry(todoItem).State = EntityState.Modified;
        //     var todoItem1 = await _context.TodoItems.FindAsync(id);
        //     if (todoItem1 == null)
        //     {
        //         return NotFound();
        //     }

        //     todoItem1.Name = todoItem.Name;
        //     todoItem1.IsComplete = todoItem.IsComplete;
        //     _context.Entry(todoItem1).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!TodoItemExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // // POST: api/TodoItems
        // // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // // more details see https://aka.ms/RazorPagesCRUD.
        // [HttpPost]
        // public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        // {
        //     _context.TodoItems.Add(todoItem);
        //     await _context.SaveChangesAsync();

        //     //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        //     return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        // }

        // // DELETE: api/TodoItems/5
        // [HttpDelete("{id}")]
        // public async Task<ActionResult<TodoItem>> DeleteTodoItem(long id)
        // {
        //     var todoItem = await _context.TodoItems.FindAsync(id);
        //     if (todoItem == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.TodoItems.Remove(todoItem);
        //     await _context.SaveChangesAsync();

        //     return todoItem;
        // }

        // private bool TodoItemExists(long id)
        // {
        //     return _context.TodoItems.Any(e => e.Id == id);
        // }
    }
}
