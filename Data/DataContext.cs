using blog.Models;
using Microsoft.EntityFrameworkCore;

namespace blog.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Post> Posts { get; set; }
    }
}