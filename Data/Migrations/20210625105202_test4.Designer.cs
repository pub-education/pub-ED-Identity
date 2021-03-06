// <auto-generated />
using System;
using Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Identity.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210625105202_test4")]
    partial class test4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Identity.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "858c004a-d447-456f-b067-e296b24cb405",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "33190ae2-480a-40f8-9ee0-c2577af8c178",
                            Email = "admin@data4mat.com",
                            EmailConfirmed = true,
                            FirstName = "admin",
                            LastName = "admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@DATA4MAT.COM",
                            NormalizedUserName = "ADMIN@DATA4MAT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMS062CkfycnO9eT2hL3fIo3au8PkfA/Cy1q3CTXidBKShKNftQ4apAG0lwWCQ6jmg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "33190ae2-480a-40f8-9ee0-c2577af8c178",
                            TwoFactorEnabled = false,
                            UserName = "admin@data4mat.com"
                        },
                        new
                        {
                            Id = "a9b76bd0-de9d-4ad2-9438-64fc420936e7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9291a763-5d38-47f6-8d0b-47bdc9df7c9f",
                            Email = "chris@data4mat.com",
                            EmailConfirmed = true,
                            FirstName = "Chris",
                            LastName = "Johannesson",
                            LockoutEnabled = false,
                            NormalizedEmail = "CHRIS@DATA4MAT.COM",
                            NormalizedUserName = "CHRIS@DATA4MAT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJJJxVBJxYCzKhHyq8Xf5JnvSr8yHlSXwr2cfILpl7Y/V4mdGwMSczj9IJNegj2UDQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9291a763-5d38-47f6-8d0b-47bdc9df7c9f",
                            TwoFactorEnabled = false,
                            UserName = "chris@data4mat.com"
                        });
                });

            modelBuilder.Entity("Identity.Models.CityClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryClassId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryClassId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Gothenburg"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 2,
                            Name = "Las Pinas"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "Manila"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 3,
                            Name = "Riverside"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 3,
                            Name = "Anaheim"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 3,
                            Name = "Honolulu"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 3,
                            Name = "Miami"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 4,
                            Name = "Oslo"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 4,
                            Name = "Geiranger"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 4,
                            Name = "Liland"
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 5,
                            Name = "Brisbane"
                        },
                        new
                        {
                            Id = 13,
                            CountryId = 5,
                            Name = "Cairns"
                        },
                        new
                        {
                            Id = 14,
                            CountryId = 5,
                            Name = "Perth"
                        },
                        new
                        {
                            Id = 15,
                            CountryId = 5,
                            Name = "Sydney"
                        },
                        new
                        {
                            Id = 16,
                            CountryId = 5,
                            Name = "Canberra"
                        });
                });

            modelBuilder.Entity("Identity.Models.CountryClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sweden"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Philippines"
                        },
                        new
                        {
                            Id = 3,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Norway"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Australia"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "33190ae2-480a-40f8-9ee0-c2577af8c178",
                            ConcurrencyStamp = "33190ae2-480a-40f8-9ee0-c2577af8c178",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "9291a763-5d38-47f6-8d0b-47bdc9df7c9f",
                            ConcurrencyStamp = "9291a763-5d38-47f6-8d0b-47bdc9df7c9f",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "858c004a-d447-456f-b067-e296b24cb405",
                            RoleId = "33190ae2-480a-40f8-9ee0-c2577af8c178"
                        },
                        new
                        {
                            UserId = "a9b76bd0-de9d-4ad2-9438-64fc420936e7",
                            RoleId = "9291a763-5d38-47f6-8d0b-47bdc9df7c9f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Identity.Models.ApplicationUser", b =>
                {
                    b.HasOne("Identity.Models.CityClass", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Identity.Models.CountryClass", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Identity.Models.CityClass", b =>
                {
                    b.HasOne("Identity.Models.CountryClass", null)
                        .WithMany("Cities")
                        .HasForeignKey("CountryClassId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Identity.Models.CountryClass", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
