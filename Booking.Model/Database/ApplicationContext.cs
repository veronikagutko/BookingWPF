using Booking.Model.Models;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using System.Xml.Schema;


namespace Booking.Model.Database
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Phone;Integrated Security=True;Pooling=False");
        }
        public DbSet<Phone> Phones { get; set; }
    }
}
