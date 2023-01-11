using EntityExamples.Model;
using EntityFramework2.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework2.db
{
    internal class DemoDbContext:DbContext
    {
        public DbSet<Student> Students{ get; set; }
        public DbSet<Employee> Employees { get; set; }
      



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source=localhost\SQLEXPRESS;Initial Catalog=ReRideDb3;Integrated Security=True
            //Data Source=localhost\SQLEXPRESS;Initial Catalog=Sample_Db;Integrated Security=True
            var path = "Server=localhost\\SQLEXPRESS;Database=ZZZZZZZZZZZZDB2;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(path);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
