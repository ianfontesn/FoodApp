using FoodApp.Menu.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Menu.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Product>  Products   { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(k => k.Id);

                entity.Property(p => p.ReferenceCode)
                .HasMaxLength(10)
                .IsRequired();

                entity.Property(p => p.Name)
                .HasMaxLength(255)
                .IsRequired();
                
                entity.Property(p => p.Description)
               .HasMaxLength(255);

                entity.Property(p => p.Price)
                .HasPrecision(8, 2);

                entity.Property(p => p.ImageUrl)
               .HasMaxLength(255);

            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(k => k.Id);

                entity.Property(p => p.ReferenceCode)
                .HasMaxLength(10)
                .IsRequired();

                entity.Property(p => p.Name)
                .HasMaxLength(255)
                .IsRequired();

                entity.Property(p => p.Description)
               .HasMaxLength(255);

                entity.Property(p => p.ImageUrl)
               .HasMaxLength(255);

                entity.HasMany(p => p.Products)
                .WithMany(p => p.Category)
                .UsingEntity(entity => entity.ToTable("CategoryProduct"));
                

            });
        }
    }
}