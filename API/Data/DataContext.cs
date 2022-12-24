using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data 
{
    public class DataContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; } /// Represnts a Table in the DB
        
        public DataContext(DbContextOptions options) : base(options) { }
    }
}