using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class newEntityInApplicationDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2000eff-df2d-4cc9-bbc8-4894ba971867", "b2000eff-df2d-4cc9-bbc8-4894ba971867", "admin", "ADMIN" },
                    { "b1c81275-c32c-4e7d-abb4-eb6bd75acd99", "b1c81275-c32c-4e7d-abb4-eb6bd75acd99", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CountryId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9271afc2-6ef8-402b-a624-b9f5ab3cfc9d", 0, 12, "5cba4be1-e13d-4b06-90c5-abb55c31cab8", 0, "ApplicationUser", "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN", "AQAAAAEAACcQAAAAEDHC9Uv70/t+nn+/OZ4uJCw10knSHWGhX+uOh4hMAzZ1s8XUVtZfhgY+sPDeWSal+Q==", null, false, "84070004-ec7b-4d10-93be-753475747d28", false, "admin" },
                    { "840671d2-bd61-43f7-8684-8e752f3759dd", 0, 1, "345e4a41-ea7c-4842-8a18-f4e97b4ccc58", 0, "ApplicationUser", "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS", "AQAAAAEAACcQAAAAEP9no5DoiKVnAd0Lv6WG8tSP0qL61uG0wYZbkZE6MD7LiXn9ahIfciahpqOeHO7O9g==", null, false, "3d5adcce-315d-4e88-b664-a19c212270c9", false, "chris" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b2000eff-df2d-4cc9-bbc8-4894ba971867", "9271afc2-6ef8-402b-a624-b9f5ab3cfc9d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b1c81275-c32c-4e7d-abb4-eb6bd75acd99", "840671d2-bd61-43f7-8684-8e752f3759dd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1c81275-c32c-4e7d-abb4-eb6bd75acd99", "840671d2-bd61-43f7-8684-8e752f3759dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2000eff-df2d-4cc9-bbc8-4894ba971867", "9271afc2-6ef8-402b-a624-b9f5ab3cfc9d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1c81275-c32c-4e7d-abb4-eb6bd75acd99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2000eff-df2d-4cc9-bbc8-4894ba971867");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "840671d2-bd61-43f7-8684-8e752f3759dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9271afc2-6ef8-402b-a624-b9f5ab3cfc9d");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d1562e03-86bc-432b-85df-8a84045da1c6", "d1562e03-86bc-432b-85df-8a84045da1c6", "admin", "ADMIN" },
                    { "597c1a6b-20fa-44bb-86c7-74c60bde383c", "597c1a6b-20fa-44bb-86c7-74c60bde383c", "user", "USER" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d1562e03-86bc-432b-85df-8a84045da1c6", "9210c463-8f58-4656-86e5-7b67801a8716" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "597c1a6b-20fa-44bb-86c7-74c60bde383c", "ec7367b0-b140-4df8-8656-fc319fe7c1cc" });
        }
    }
}
