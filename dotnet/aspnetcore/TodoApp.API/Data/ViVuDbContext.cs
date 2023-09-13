using Microsoft.EntityFrameworkCore;
using TodoApp.API.Models;

namespace TodoApp.API.Data
{
    public class ViVuDbContext : DbContext
    {
        public ViVuDbContext(DbContextOptions<ViVuDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}