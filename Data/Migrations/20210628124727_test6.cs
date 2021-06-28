using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4baa6bdb-9c99-44a5-b077-1ca5655ee230", "4baa6bdb-9c99-44a5-b077-1ca5655ee230", "user", "USER" },
                    { "29a3b20b-232a-4555-8201-c06e6c36ed4b", "29a3b20b-232a-4555-8201-c06e6c36ed4b", "admin", "ADMIN" }
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
                table: "Cities",
                columns: new[] { "Id", "CountryClassId", "CountryId", "Name" },
                values: new object[,]
                {
                    { 2, null, 1, "Stockholm" },
                    { 16, null, 5, "Canberra" },
                    { 15, null, 5, "Sydney" },
                    { 14, null, 5, "Perth" },
                    { 13, null, 5, "Cairns" },
                    { 1, null, 1, "Gothenburg" },
                    { 10, null, 4, "Geiranger" },
                    { 12, null, 5, "Brisbane" },
                    { 8, null, 3, "Miami" },
                    { 7, null, 3, "Honolulu" },
                    { 6, null, 3, "Anaheim" },
                    { 5, null, 3, "Riverside" },
                    { 4, null, 2, "Manila" },
                    { 3, null, 2, "Las Pinas" },
                    { 9, null, 4, "Oslo" },
                    { 11, null, 4, "Liland" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sweden" },
                    { 2, "Philippines" },
                    { 3, "USA" },
                    { 4, "Norway" },
                    { 5, "Australia" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "29a3b20b-232a-4555-8201-c06e6c36ed4b", "8fb21070-4f52-4179-af57-dcbfbe97a35a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4baa6bdb-9c99-44a5-b077-1ca5655ee230", "ee3adc45-e4fd-4077-aef6-4e67904f1a5d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29a3b20b-232a-4555-8201-c06e6c36ed4b", "8fb21070-4f52-4179-af57-dcbfbe97a35a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4baa6bdb-9c99-44a5-b077-1ca5655ee230", "ee3adc45-e4fd-4077-aef6-4e67904f1a5d" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

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

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
        }
    }
}
