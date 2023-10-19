using Microsoft.EntityFrameworkCore;

namespace tyuiu.oop.SidorovAY.NetCoreWebAppMVC.DataModels
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
    }
}
