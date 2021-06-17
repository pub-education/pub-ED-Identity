using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class StampInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
