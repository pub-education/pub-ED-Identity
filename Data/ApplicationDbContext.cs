using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CityClass> Cities { get; set; }

        public DbSet<CountryClass> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            
            builder.Entity<CountryClass>().HasData(
                new CountryClass { Id = 1, Name = "Sweden" },
                new CountryClass { Id = 2, Name = "Philippines" },
                new CountryClass { Id = 3, Name = "USA" },
                new CountryClass { Id = 4, Name = "Norway" },
                new CountryClass { Id = 5, Name = "Australia" }
                );
            builder.Entity<CityClass>().HasData(
                new CityClass { Id = 1, Name = "Gothenburg", CountryRefId = 1 },
                new CityClass { Id = 2, Name = "Stockholm", CountryRefId = 1 },
                new CityClass { Id = 3, Name = "Las Pinas", CountryRefId = 2 },
                new CityClass { Id = 4, Name = "Manila", CountryRefId = 2 },
                new CityClass { Id = 5, Name = "Riverside", CountryRefId = 3 },
                new CityClass { Id = 6, Name = "Anaheim", CountryRefId = 3 },
                new CityClass { Id = 7, Name = "Honolulu", CountryRefId = 3 },
                new CityClass { Id = 8, Name = "Miami", CountryRefId = 3 },
                new CityClass { Id = 9, Name = "Oslo", CountryRefId = 4 },
                new CityClass { Id = 10, Name = "Geiranger", CountryRefId = 4 },
                new CityClass { Id = 11, Name = "Liland", CountryRefId = 4 },
                new CityClass { Id = 12, Name = "Brisbane", CountryRefId = 5 },
                new CityClass { Id = 13, Name = "Cairns", CountryRefId = 5 },
                new CityClass { Id = 14, Name = "Perth", CountryRefId = 5 },
                new CityClass { Id = 15, Name = "Sydney", CountryRefId = 5 },
                new CityClass { Id = 16, Name = "Canberra", CountryRefId = 5 }
                );

            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string adminId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole
                {
                    Id = userRoleId,
                    Name = "user",
                    NormalizedName = "USER",
                    ConcurrencyStamp=userRoleId
                });

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            var AdminUser = new ApplicationUser
            {
                Id = adminId,
                FirstName = "admin",
                LastName = "admin",
                Email = "admin@data4mat.com",
                NormalizedEmail = "ADMIN@DATA4MAT.COM",
                EmailConfirmed = true,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                ConcurrencyStamp=adminRoleId,
                SecurityStamp=adminRoleId,
                CityId = 12
            };

            
            var SiteUser = new ApplicationUser
            {
                Id = userId,
                FirstName = "Chris",
                LastName = "Johannesson",
                Email = "chris@data4mat.com",
                NormalizedEmail = "CHRIS@DATA4MAT.COM",
                EmailConfirmed = true,
                UserName = "chris",
                NormalizedUserName = "CHRIS",
                ConcurrencyStamp = userRoleId,
                SecurityStamp=userRoleId,
                CityId = 1
            };

            
            AdminUser.PasswordHash = passwordHasher.HashPassword(AdminUser, "admin");
            builder.Entity<ApplicationUser>().HasData(AdminUser);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminId
                });

            SiteUser.PasswordHash = passwordHasher.HashPassword(SiteUser, "1234");
            builder.Entity<ApplicationUser>().HasData(SiteUser);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = userId
                });
       
        }
        
    }
}
