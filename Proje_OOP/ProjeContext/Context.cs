using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.ProjeContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQL Server Bağlantı Kodu
            optionsBuilder.UseSqlServer("server=ROUTINUES;database=DbNewOopCore;integrated security=true;");
        }

        //Veritabanında tablolarımızı oluşturacak kodlar.
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
