using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class dataInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "597c1a6b-20fa-44bb-86c7-74c60bde383c", "597c1a6b-20fa-44bb-86c7-74c60bde383c", "user", "USER" },
                    { "d1562e03-86bc-432b-85df-8a84045da1c6", "d1562e03-86bc-432b-85df-8a84045da1c6", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9210c463-8f58-4656-86e5-7b67801a8716", 0, 12, "e819ba02-6527-4f87-9e30-5c1beca36f29", "ApplicationUser", "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN", "AQAAAAEAACcQAAAAEDUBT9fqdbXATbwxKTfbD6tNKoT2T+pLpSBrntxFC5Y8BPo9r02MrPIg7opVt+eViw==", null, false, "31c93c40-f52e-48b2-938e-a0e0009fa0c6", false, "admin" },
                    { "ec7367b0-b140-4df8-8656-fc319fe7c1cc", 0, 1, "3ab8323e-37db-4ec4-a1d9-21a19d6b00f2", "ApplicationUser", "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS", "AQAAAAEAACcQAAAAEPnVkrbtXYSaX8uekp7jB42zf9VTWMetolsSvjXDO3ZdrhShDtRUpXN2BWFwqxcFtw==", null, false, "27de0db1-f63b-4e89-8fe8-a66efdb8bf38", false, "chris" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryClassId", "CountryRefId", "Name" },
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
                values: new object[] { "d1562e03-86bc-432b-85df-8a84045da1c6", "9210c463-8f58-4656-86e5-7b67801a8716" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "597c1a6b-20fa-44bb-86c7-74c60bde383c", "ec7367b0-b140-4df8-8656-fc319fe7c1cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1562e03-86bc-432b-85df-8a84045da1c6", "9210c463-8f58-4656-86e5-7b67801a8716" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "597c1a6b-20fa-44bb-86c7-74c60bde383c", "ec7367b0-b140-4df8-8656-fc319fe7c1cc" });

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
                keyValue: "597c1a6b-20fa-44bb-86c7-74c60bde383c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1562e03-86bc-432b-85df-8a84045da1c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9210c463-8f58-4656-86e5-7b67801a8716");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec7367b0-b140-4df8-8656-fc319fe7c1cc");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
