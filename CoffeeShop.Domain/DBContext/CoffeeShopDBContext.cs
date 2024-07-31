using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Domain.DBContext
{
    public partial class CoffeeShopDBContext : DbContext
    {
        public CoffeeShopDBContext()
        {
        }
        public CoffeeShopDBContext(DbContextOptions<CoffeeShopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerLoyaltyPoints> CustomerLoyaltyPoints { get; set; }
        public virtual DbSet<ItemSize> ItemSize { get; set; }
        public virtual DbSet<LoyaltyTypes> LoyaltyTypes { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Item> Items { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerLoyaltyPoints>(entity =>
            {
                entity.Property(e => e.Points);

                entity.Property(e => e.CreatedDate);
            });

            modelBuilder.Entity<ItemSize>(entity =>
            {
                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoyaltyTypes>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderDate);

                entity.Property(e => e.TotalAmount);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
