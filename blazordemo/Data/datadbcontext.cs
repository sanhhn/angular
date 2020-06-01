using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace blazordemo.Data
{
    public class datadbcontext: DbContext
    {
        public datadbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Gadget> Gadgets { get; set; }
    }
}