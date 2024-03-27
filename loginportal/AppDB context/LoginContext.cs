using loginportal.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
namespace loginportal.AppDB_context
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions options) : base(options)
        {
           
        }

        // Define DbSet properties for your entities
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Login> Login { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

        }
    }
}
