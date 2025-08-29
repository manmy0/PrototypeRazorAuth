using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Models;

namespace PrototypeRazorAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CDL> CDL { get; set; }
        public DbSet<Competencies> Competencies { get; set; }
        public DbSet<Dashboard> Dashboard { get; set; }
        public DbSet<Goals> Goals { get; set; }
        public DbSet<Networking> Networking { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Summary> Summary { get; set; }

    }
}
