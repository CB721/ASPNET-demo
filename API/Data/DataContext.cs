using Microsoft.EntityFrameworkCore;
using ASPNETAngularDemo.API.Entities;

namespace ASPNETAngularDemo.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
    }
}