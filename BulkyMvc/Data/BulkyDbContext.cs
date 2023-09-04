using BulkyMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyMvc.Data
{
    public class BulkyDbContext : DbContext
    {
        public BulkyDbContext(DbContextOptions<BulkyDbContext> options)
       : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

    }
}
