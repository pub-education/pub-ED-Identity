using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class changedUserNameInContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15639af8-2125-4ad8-a4aa-6a3ebdbcb021", "b7eb8ee5-a39d-4c16-b5a0-6184294b9118" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4ee58f6-e7bf-43e8-8307-8b3984278b00", "e79586b8-8a37-4b98-80dc-f5aea62ef7cc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15639af8-2125-4ad8-a4aa-6a3ebdbcb021");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4ee58f6-e7bf-43e8-8307-8b3984278b00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7eb8ee5-a39d-4c16-b5a0-6184294b9118");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e79586b8-8a37-4b98-80dc-f5aea62ef7cc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8be91d9b-99d2-4b3b-b7d8-fe9affabb432", "8be91d9b-99d2-4b3b-b7d8-fe9affabb432", "admin", "ADMIN" },
                    { "b076cab0-8dc8-4bd5-b24a-b5b001ae18ad", "b076cab0-8dc8-4bd5-b24a-b5b001ae18ad", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CountryId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9f2237d9-165b-4df5-9d5d-1416a3147382", 0, 12, "8be91d9b-99d2-4b3b-b7d8-fe9affabb432", 0, "ApplicationUser", "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAEFm9VKeyz8iA7+u4szXy0ToiOHnNolMZ8avVs8jogMsBuEdkwsdx7QAZOEwlmoId8g==", null, false, "8be91d9b-99d2-4b3b-b7d8-fe9affabb432", false, "admin@data4mat.com" },
                    { "36c3ecd2-fa08-4008-8b30-fcd4debe2843", 0, 1, "b076cab0-8dc8-4bd5-b24a-b5b001ae18ad", 0, "ApplicationUser", "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAEEuI0xRfTuQz7rJm3QWv+ZqNl+p44GObK8a3pvHBFYlyozPNDTEcoI9RPpuzQZKEUQ==", null, false, "b076cab0-8dc8-4bd5-b24a-b5b001ae18ad", false, "chris@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8be91d9b-99d2-4b3b-b7d8-fe9affabb432", "9f2237d9-165b-4df5-9d5d-1416a3147382" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b076cab0-8dc8-4bd5-b24a-b5b001ae18ad", "36c3ecd2-fa08-4008-8b30-fcd4debe2843" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b076cab0-8dc8-4bd5-b24a-b5b001ae18ad", "36c3ecd2-fa08-4008-8b30-fcd4debe2843" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8be91d9b-99d2-4b3b-b7d8-fe9affabb432", "9f2237d9-165b-4df5-9d5d-1416a3147382" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8be91d9b-99d2-4b3b-b7d8-fe9affabb432");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b076cab0-8dc8-4bd5-b24a-b5b001ae18ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36c3ecd2-fa08-4008-8b30-fcd4debe2843");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f2237d9-165b-4df5-9d5d-1416a3147382");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f4ee58f6-e7bf-43e8-8307-8b3984278b00", "f4ee58f6-e7bf-43e8-8307-8b3984278b00", "admin", "ADMIN" },
                    { "15639af8-2125-4ad8-a4aa-6a3ebdbcb021", "15639af8-2125-4ad8-a4aa-6a3ebdbcb021", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CountryId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e79586b8-8a37-4b98-80dc-f5aea62ef7cc", 0, 12, "f4ee58f6-e7bf-43e8-8307-8b3984278b00", 0, "ApplicationUser", "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN", "AQAAAAEAACcQAAAAEADTzEOXshb2KeP+RHuW2xhPpHjJVUeeCiq88RmgFlEEQu0ZpKkWx/CzarHPE19FYg==", null, false, "f4ee58f6-e7bf-43e8-8307-8b3984278b00", false, "admin" },
                    { "b7eb8ee5-a39d-4c16-b5a0-6184294b9118", 0, 1, "15639af8-2125-4ad8-a4aa-6a3ebdbcb021", 0, "ApplicationUser", "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS", "AQAAAAEAACcQAAAAEG+kHRRdYaJwAzQpCKiTB9DjmQWD2vYYSkjnuF8cx4ftAxHwIEGJu2G4v8nXiQu+7A==", null, false, "15639af8-2125-4ad8-a4aa-6a3ebdbcb021", false, "chris" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f4ee58f6-e7bf-43e8-8307-8b3984278b00", "e79586b8-8a37-4b98-80dc-f5aea62ef7cc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "15639af8-2125-4ad8-a4aa-6a3ebdbcb021", "b7eb8ee5-a39d-4c16-b5a0-6184294b9118" });
        }
    }
}
