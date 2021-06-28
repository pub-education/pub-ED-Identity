using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cities_CityClassId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Countries_CountryClassId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CityClassId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CountryClassId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29a3b20b-232a-4555-8201-c06e6c36ed4b", "8fb21070-4f52-4179-af57-dcbfbe97a35a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4baa6bdb-9c99-44a5-b077-1ca5655ee230", "ee3adc45-e4fd-4077-aef6-4e67904f1a5d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29a3b20b-232a-4555-8201-c06e6c36ed4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4baa6bdb-9c99-44a5-b077-1ca5655ee230");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fb21070-4f52-4179-af57-dcbfbe97a35a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee3adc45-e4fd-4077-aef6-4e67904f1a5d");

            migrationBuilder.DropColumn(
                name: "CityClassId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CountryClassId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicationUserCityClass",
                columns: table => new
                {
                    CitiesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserCityClass", x => new { x.CitiesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserCityClass_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserCityClass_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserCountryClass",
                columns: table => new
                {
                    CountriesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserCountryClass", x => new { x.CountriesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserCountryClass_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserCountryClass_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eef91497-88c7-48a0-be6f-794aa369d59d", "eef91497-88c7-48a0-be6f-794aa369d59d", "admin", "ADMIN" },
                    { "41ef0dae-3e3f-4eff-9948-d4823e639615", "41ef0dae-3e3f-4eff-9948-d4823e639615", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CountryId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9c1c1d7d-cdc2-406e-88cb-826e4db3c626", 0, 1, "eef91497-88c7-48a0-be6f-794aa369d59d", 1, "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAEDY1AMRL3ajh/eLA2fF5Ca9QKRYDClv/dvT8DNOW8mjJZ/WIBHEjLh2T9bh25yWqMQ==", null, false, "eef91497-88c7-48a0-be6f-794aa369d59d", false, "admin@data4mat.com" },
                    { "a3c309fe-a9b4-4fe3-9240-522d552d8fa3", 0, 1, "41ef0dae-3e3f-4eff-9948-d4823e639615", 1, "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAEMFKDu0aoXCYC+qiT+rbBYD1ciYsVG8yGJ3/BTxNCsfWHC316qeSxbOKdNanVk9u5Q==", null, false, "41ef0dae-3e3f-4eff-9948-d4823e639615", false, "chris@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eef91497-88c7-48a0-be6f-794aa369d59d", "9c1c1d7d-cdc2-406e-88cb-826e4db3c626" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "41ef0dae-3e3f-4eff-9948-d4823e639615", "a3c309fe-a9b4-4fe3-9240-522d552d8fa3" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserCityClass_UsersId",
                table: "ApplicationUserCityClass",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserCountryClass_UsersId",
                table: "ApplicationUserCountryClass",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserCityClass");

            migrationBuilder.DropTable(
                name: "ApplicationUserCountryClass");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eef91497-88c7-48a0-be6f-794aa369d59d", "9c1c1d7d-cdc2-406e-88cb-826e4db3c626" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41ef0dae-3e3f-4eff-9948-d4823e639615", "a3c309fe-a9b4-4fe3-9240-522d552d8fa3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41ef0dae-3e3f-4eff-9948-d4823e639615");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eef91497-88c7-48a0-be6f-794aa369d59d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c1c1d7d-cdc2-406e-88cb-826e4db3c626");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3c309fe-a9b4-4fe3-9240-522d552d8fa3");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CityClassId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryClassId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29a3b20b-232a-4555-8201-c06e6c36ed4b", "29a3b20b-232a-4555-8201-c06e6c36ed4b", "admin", "ADMIN" },
                    { "4baa6bdb-9c99-44a5-b077-1ca5655ee230", "4baa6bdb-9c99-44a5-b077-1ca5655ee230", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityClassId", "CityId", "ConcurrencyStamp", "CountryClassId", "CountryId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8fb21070-4f52-4179-af57-dcbfbe97a35a", 0, null, 1, "29a3b20b-232a-4555-8201-c06e6c36ed4b", null, 1, "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAEGqWsAtIKg914UJhiFswvJ2yk25o+trIN13f0PMFlTwBJsuYuHhsZ5CU2mSJswB8CA==", null, false, "29a3b20b-232a-4555-8201-c06e6c36ed4b", false, "admin@data4mat.com" },
                    { "ee3adc45-e4fd-4077-aef6-4e67904f1a5d", 0, null, 1, "4baa6bdb-9c99-44a5-b077-1ca5655ee230", null, 1, "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAEC5D/uyLV6Mo24S21kzlw/G1QcDU5D9eHY7fHrkkdzNmvj6M+Kdrg26Z5gaCt2JTRA==", null, false, "4baa6bdb-9c99-44a5-b077-1ca5655ee230", false, "chris@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "29a3b20b-232a-4555-8201-c06e6c36ed4b", "8fb21070-4f52-4179-af57-dcbfbe97a35a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4baa6bdb-9c99-44a5-b077-1ca5655ee230", "ee3adc45-e4fd-4077-aef6-4e67904f1a5d" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityClassId",
                table: "AspNetUsers",
                column: "CityClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CountryClassId",
                table: "AspNetUsers",
                column: "CountryClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cities_CityClassId",
                table: "AspNetUsers",
                column: "CityClassId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Countries_CountryClassId",
                table: "AspNetUsers",
                column: "CountryClassId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
