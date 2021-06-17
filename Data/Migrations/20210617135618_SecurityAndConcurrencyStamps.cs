using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class SecurityAndConcurrencyStamps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b4244e7e-2ea5-46d2-8ea4-1cde91c278d1", "1c075b86-3f52-48f1-b89b-7ac67ec4cf82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12c7dee4-9322-4030-94b9-e43d6dc4171a", "a3e23b3f-6af8-435c-876f-ba46bd353802" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12c7dee4-9322-4030-94b9-e43d6dc4171a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4244e7e-2ea5-46d2-8ea4-1cde91c278d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c075b86-3f52-48f1-b89b-7ac67ec4cf82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3e23b3f-6af8-435c-876f-ba46bd353802");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "b4244e7e-2ea5-46d2-8ea4-1cde91c278d1", "b4244e7e-2ea5-46d2-8ea4-1cde91c278d1", "admin", "ADMIN" },
                    { "12c7dee4-9322-4030-94b9-e43d6dc4171a", "24be449f-2729-4ab5-8d8a-a1c2ebcbbb30", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CountryId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c075b86-3f52-48f1-b89b-7ac67ec4cf82", 0, 12, "94ef10d7-cc77-4b78-85b0-64060925b557", 0, "ApplicationUser", "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN", "AQAAAAEAACcQAAAAELy5aPZ7pDNOOiSSm7/2TPBtVY/yH5MEcudnuq3NXMi8Q07VbnZUgCzGuiBay6oMew==", null, false, "b4244e7e-2ea5-46d2-8ea4-1cde91c278d1", false, "admin" },
                    { "a3e23b3f-6af8-435c-876f-ba46bd353802", 0, 1, "12c7dee4-9322-4030-94b9-e43d6dc4171a", 0, "ApplicationUser", "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS", "AQAAAAEAACcQAAAAEA/6jouVVV3GjiNjePainiPkJWiyrliLdfq7TSgyY1Fk6KXPlu9Um6sST72nFiyrlw==", null, false, "12c7dee4-9322-4030-94b9-e43d6dc4171a", false, "chris" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b4244e7e-2ea5-46d2-8ea4-1cde91c278d1", "1c075b86-3f52-48f1-b89b-7ac67ec4cf82" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "12c7dee4-9322-4030-94b9-e43d6dc4171a", "a3e23b3f-6af8-435c-876f-ba46bd353802" });
        }
    }
}
