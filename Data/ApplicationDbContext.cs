using CRISPER.Models;
using CRISPR.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace CRISPER.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<IdentityUser>? users { get; set; }
        public DbSet<DataSet>? DataSets { get; set; }
  public DbSet<Model>? Model { get; set; }

        
            
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>()
                .HasDiscriminator<string>("UserType")
                .HasValue<IdentityUser>("User");
        }
      
    }

}