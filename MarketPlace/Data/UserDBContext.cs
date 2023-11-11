using MarketPlace.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MarketPlace.Data
{
    public class UserDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreditCard>() //sets up a one to many relationship between User and Creditcard
            .HasOne(c => c.User).WithMany(c => c.CreditCards)
            .HasForeignKey(c => c.User_ID);
            modelBuilder.Entity<Order>() //sets up a one to many relationship between User and Orders
            .HasOne(c => c.User).WithMany(c => c.Orders)
            .HasForeignKey(c => c.User_ID);
            modelBuilder.Entity<Address>() //sets up a one to many relationship between User and Addresses
            .HasOne(c => c.User).WithMany(c => c.Addresses)
            .HasForeignKey(c => c.User_ID);
        }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}