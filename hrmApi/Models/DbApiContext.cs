using Microsoft.EntityFrameworkCore;

namespace hrmApi.Models
{
    public class DbApiContext : DbContext
    {
        public DbApiContext(DbContextOptions<DbApiContext> options)
            : base(options)
        {
        }

        public DbSet<GridColumns> GridColumns { get; set; }
        public DbSet<SysLists> SysLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GridColumns>(entity =>
            {
                entity.HasKey(e => new { e.ProjectCode, e.GridKey, e.ColumnName });
                entity.ToTable("SYS_tblGridColumns");
            });

            modelBuilder.Entity<SysLists>(entity =>
            {
                entity.HasKey(e => new { e.ListID });
                entity.ToTable("SYS_Lists");
            });            
        }
        
    }
}