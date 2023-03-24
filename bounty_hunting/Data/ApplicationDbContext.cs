using bounty_hunting.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using bounty_hunting.Enums;

namespace bounty_hunting.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                  
        }

        //Db Sets go here
        public DbSet<Bounty> Bounties { get; set; }
        public DbSet<Jacket> Jackets { get; set; }
        public DbSet<JacketAttachment> JacketAttachments { get; set; }


        //Seed Method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Bounty>().ToTable(nameof(Bounty));          
            modelBuilder.Entity<Jacket>().ToTable(nameof(Jacket));
            modelBuilder.Entity<JacketAttachment>().ToTable(nameof(JacketAttachment));

            #region Seed Data

            // Seed Users          
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Gary",
                    LastName = "Pierce",
                    Status = "A",
                    EmailConfirmed = true,
                    Email = "gpierce@email.com",
                    NormalizedEmail = "GPIERCE@EMAIL.COM",
                    UserName = "gpierce@email.com",
                    NormalizedUserName = "GPIERCE@EMAIL.COM",
                    PhoneNumber = "3361234567",
                    LockoutEnabled = false,
                    TwoFactorEnabled = false,
                    AccessFailedCount = 0,
                    PasswordHash = "Abc123!"
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Nick",
                    LastName = "Faircloth",
                    Status = "A",
                    EmailConfirmed = true,
                    Email = "nfaircloth@email.com",
                    NormalizedEmail = "NFAIRCLOTH@EMAIL.COM",
                    UserName = "nfaircloth@email.com",
                    NormalizedUserName = "NFAIRCLOTH@EMAIL.COM",
                    PhoneNumber = "3362345678",
                    LockoutEnabled = false,
                    TwoFactorEnabled = false,
                    AccessFailedCount = 0,
                    PasswordHash = "Abc123!"
                });

            //Seed Roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "SuperAdmin"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User"
                });

            // Seed user roles

            #endregion
        }
    }
}