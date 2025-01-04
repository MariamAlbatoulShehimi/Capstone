using Capstone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Capstone.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define the DbSets
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // Configure the model with seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure 'AddedDate' to use the current date by default (only for new entries)
            modelBuilder.Entity<Product>()
                .Property(p => p.AddedDate)
                .HasDefaultValueSql("GETDATE()"); // For SQL Server. Use CURRENT_TIMESTAMP for other DBs.

            // Seed Category Data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Shelter Assistance", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Food Support", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Essential Supplies", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Aya", PhoneNumber="123456" },
                new Company { Id = 2, Name = "Ali", PhoneNumber="112233" }
            );

            // Seed Product Data
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Blanket",
                    Description = "Warm and soft blanket for cold weather.",
                    QuantityAvailable = 50,
                    Location = "Beirut",
                    //IsNew = true,
                    //IsDonated = true, // Item is donated
                    AddedDate =  DateTime.Now,
                    Condition = "New",
                    //IsActive = true,
                    ListPrice = 0, // Donated items should have price set to 0
                    CategoryId= 1,
                    ImageUrl=" "
                },
                new Product
                {
                    Id = 2,
                    Name = "Canned Food Package",
                    Description = "Pack of canned food for long shelf life.",
                    QuantityAvailable = 100,
                    Location = "Tripoli",
                    //IsNew = true,
                    //IsDonated = true, // Item is donated
                    AddedDate = new DateTime(2024, 1, 2),
                    Condition = "New",
                    //IsActive = true,
                    ListPrice = 0 ,// Donated items should have price set to 0
                    CategoryId = 2,
                    ImageUrl = " "
                },
                new Product
                {
                    Id = 3,
                    Name = "Pillow",
                    Description = "Comfortable pillow for better sleep.",
                    QuantityAvailable = 30,
                    Location = "Zahle",
                    //IsNew = true,
                    //IsDonated = false, // Not donated
                    AddedDate = new DateTime(2024, 1, 3),
                    Condition = "New",
                    //IsActive = true,
                    ListPrice = 10.75, // Regular price for non-donated items
                     CategoryId = 3,
                    ImageUrl = " "
                },
                new Product
                {
                    Id = 4,
                    Name = "Sleeping Bag",
                    Description = "Lightweight sleeping bag suitable for outdoor use.",
                    QuantityAvailable = 20,
                    Location = "Bekaa Valley",
                   // IsNew = false,
                    //IsDonated = false, // Not donated
                    AddedDate = new DateTime(2024, 1, 4),
                    Condition = "Used",
                    //IsActive = true,
                    ListPrice = 8.99, // Regular price for non-donated items
                     CategoryId = 2,
                    ImageUrl = " "
                },
                new Product
                {
                    Id = 5,
                    Name = "Hygiene Kit",
                    Description = "Essential hygiene products for personal care.",
                    QuantityAvailable = 50,
                    Location = "Sidon",
                    //IsNew = true,
                    //IsDonated = true, // Item is donated
                    AddedDate = new DateTime(2024, 1, 5),
                    Condition = "New",
                    //IsActive = true,
                    ListPrice = 0 ,// Donated items should have price set to 0
                     CategoryId = 1,
                    ImageUrl = " "
                },
                new Product
                {
                    Id = 6,
                    Name = "Winter Jacket",
                    Description = "Warm jacket for cold seasons.",
                    QuantityAvailable = 40,
                    Location = "Baalbek",
                    //IsNew = false,
                   // IsDonated = false, // Not donated
                    AddedDate = new DateTime(2024, 1, 6),
                    Condition = "Good",
                    //IsActive = true,
                    ListPrice = 15.50 ,// Regular price for non-donated items
                     CategoryId = 2,
                    ImageUrl = " "
                }
            );
        }
    }
}
