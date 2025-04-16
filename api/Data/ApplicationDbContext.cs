using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions)
         : base(dbContextOptions)
        {   
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Download> Downloads { get; set; }
        public DbSet<Image> Images{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fix multiple cascade paths: tránh dùng Cascade ở cả 2 phía

            // Cấu hình Download -> User: KHÔNG dùng Cascade
            modelBuilder.Entity<Download>()
                .HasOne(d => d.User)
                .WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict); // hoặc NoAction

            // Download -> Image: giữ Cascade nếu muốn xóa ảnh thì xóa download luôn
            modelBuilder.Entity<Download>()
                .HasOne(d => d.Image)
                .WithMany()
                .HasForeignKey(d => d.ImageId)
                .OnDelete(DeleteBehavior.Cascade);

            // Image -> Photographer (User): KHÔNG dùng Cascade
            modelBuilder.Entity<Image>()
                .HasOne(i => i.Photographer)
                .WithMany()
                .HasForeignKey(i => i.PhotographerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Cấu hình decimal chính xác cho các trường Price tránh cảnh báo
            modelBuilder.Entity<Image>()
                .Property(i => i.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.Price)
                .HasPrecision(18, 2);
        }
    }
        
    
}