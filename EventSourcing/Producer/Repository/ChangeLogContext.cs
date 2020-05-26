using Microsoft.EntityFrameworkCore;
using Producer.Models;

namespace Producer.Repository
{
    public class ChangeLogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=EventSourcing;Integrated Security=True");
        }

        public DbSet<ChangeLog> ChangeLog{ get; set; }
    }
}
