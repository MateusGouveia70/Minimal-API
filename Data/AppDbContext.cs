using Microsoft.EntityFrameworkCore;
using MiniToto.Models;

namespace MiniToto.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=app.db;Trusted_Connection=True");
        }
    }
}
