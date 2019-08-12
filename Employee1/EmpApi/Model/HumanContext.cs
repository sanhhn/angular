using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//https://www.learnentityframeworkcore.com/walkthroughs/aspnetcore-application

//https://www.learnentityframeworkcore.com/walkthroughs/existing-database
//https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx

// https://tecadmin.net/remove-docker-images-and-containers/
// sudo docker pull microsoft/mssql-server-linux:2017-latest
// sudo docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=sqlSa@123' -p 1433:1433 --name sqlsanh -d microsoft/mssql-server-linux:2017-latest
// docker ps -a
// mssql -u sa -p sqlSa@123

// dotnet ef dbcontext scaffold "Server=localhost;Database=Human;User ID=sa;password=sqlSa@123;" Microsoft.EntityFrameworkCore.SqlServer -o Model

// User ID=sa;password=sqlSa@123;server=localhost;Database=Human;

// dotnet restore
// dotnet build
// dotnet ef dbcontext scaffold "Server=localhost;Database=Human;User ID=sa;password=sqlSa@123;" Microsoft.EntityFrameworkCore.SqlServer -o Model

namespace EmpApi.Model
{
    public partial class HumanContext : DbContext
    {
        public HumanContext()
        {
        }

        public HumanContext(DbContextOptions<HumanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // if (!optionsBuilder.IsConfigured)
            // {
            //     string connectionString = Configuration.GetConnectionString("DefaultConnection");
            //     optionsBuilder.UseSqlServer(connectionString);
            // }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<EmployeeDetails>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AF2DBB99882C74DC");

                entity.Property(e => e.Adress).HasMaxLength(250);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.PinCode).HasMaxLength(50);
            });
        }
    }
}
