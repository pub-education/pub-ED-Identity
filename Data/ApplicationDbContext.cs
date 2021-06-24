using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        [PersonalData]
        public DbSet<CityClass> Cities { get; set; }

        [PersonalData]
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
                new CityClass { Id = 1, Name = "Gothenburg", CountryId = 1 },
                new CityClass { Id = 2, Name = "Stockholm", CountryId = 1 },
                new CityClass { Id = 3, Name = "Las Pinas", CountryId = 2 },
                new CityClass { Id = 4, Name = "Manila", CountryId = 2 },
                new CityClass { Id = 5, Name = "Riverside", CountryId = 3 },
                new CityClass { Id = 6, Name = "Anaheim", CountryId = 3 },
                new CityClass { Id = 7, Name = "Honolulu", CountryId = 3 },
                new CityClass { Id = 8, Name = "Miami", CountryId = 3 },
                new CityClass { Id = 9, Name = "Oslo", CountryId = 4 },
                new CityClass { Id = 10, Name = "Geiranger", CountryId = 4 },
                new CityClass { Id = 11, Name = "Liland", CountryId = 4 },
                new CityClass { Id = 12, Name = "Brisbane", CountryId = 5 },
                new CityClass { Id = 13, Name = "Cairns", CountryId = 5 },
                new CityClass { Id = 14, Name = "Perth", CountryId = 5 },
                new CityClass { Id = 15, Name = "Sydney", CountryId = 5 },
                new CityClass { Id = 16, Name = "Canberra", CountryId = 5 }
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
                UserName = "admin@data4mat.com",
                NormalizedUserName = "ADMIN@DATA4MAT.COM",
                ConcurrencyStamp = adminRoleId,
                SecurityStamp = adminRoleId
            };

            
            var SiteUser = new ApplicationUser
            {
                Id = userId,
                FirstName = "Chris",
                LastName = "Johannesson",
                Email = "chris@data4mat.com",
                NormalizedEmail = "CHRIS@DATA4MAT.COM",
                EmailConfirmed = true,
                UserName = "chris@data4mat.com",
                NormalizedUserName = "CHRIS@DATA4MAT.COM",
                ConcurrencyStamp = userRoleId,
                SecurityStamp=userRoleId
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
