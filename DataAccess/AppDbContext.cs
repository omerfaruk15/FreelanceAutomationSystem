using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Calisan> Employees { get; set; } 
        public DbSet<Gorev> Tasks { get; set; }      



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
      
            optionsBuilder.UseSqlServer("Server=.;Database=yonetim_sistemi;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gorev>()
                .HasDiscriminator<string>("TaskType")
                .HasValue<YazilimGorevi>("Yazılım")
                .HasValue<TasarimGorevi>("Tasarım");

            base.OnModelCreating(modelBuilder);
        }
    }


}