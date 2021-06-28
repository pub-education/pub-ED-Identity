using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e7281058-1a8b-4968-9b4a-216c13e8c63f", "55baeffd-ada6-4f07-a0bf-912e7172153a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75bd005a-632c-470e-b868-da61859590cb", "d8640500-3e4f-40e6-a28e-36cda5d9b2cf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75bd005a-632c-470e-b868-da61859590cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7281058-1a8b-4968-9b4a-216c13e8c63f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55baeffd-ada6-4f07-a0bf-912e7172153a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8640500-3e4f-40e6-a28e-36cda5d9b2cf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33190ae2-480a-40f8-9ee0-c2577af8c178", "33190ae2-480a-40f8-9ee0-c2577af8c178", "admin", "ADMIN" },
                    { "9291a763-5d38-47f6-8d0b-47bdc9df7c9f", "9291a763-5d38-47f6-8d0b-47bdc9df7c9f", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CountryId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "858c004a-d447-456f-b067-e296b24cb405", 0, null, "33190ae2-480a-40f8-9ee0-c2577af8c178", null, "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAEMS062CkfycnO9eT2hL3fIo3au8PkfA/Cy1q3CTXidBKShKNftQ4apAG0lwWCQ6jmg==", null, false, "33190ae2-480a-40f8-9ee0-c2577af8c178", false, "admin@data4mat.com" },
                    { "a9b76bd0-de9d-4ad2-9438-64fc420936e7", 0, null, "9291a763-5d38-47f6-8d0b-47bdc9df7c9f", null, "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAEJJJxVBJxYCzKhHyq8Xf5JnvSr8yHlSXwr2cfILpl7Y/V4mdGwMSczj9IJNegj2UDQ==", null, false, "9291a763-5d38-47f6-8d0b-47bdc9df7c9f", false, "chris@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "33190ae2-480a-40f8-9ee0-c2577af8c178", "858c004a-d447-456f-b067-e296b24cb405" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9291a763-5d38-47f6-8d0b-47bdc9df7c9f", "a9b76bd0-de9d-4ad2-9438-64fc420936e7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33190ae2-480a-40f8-9ee0-c2577af8c178", "858c004a-d447-456f-b067-e296b24cb405" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9291a763-5d38-47f6-8d0b-47bdc9df7c9f", "a9b76bd0-de9d-4ad2-9438-64fc420936e7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33190ae2-480a-40f8-9ee0-c2577af8c178");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9291a763-5d38-47f6-8d0b-47bdc9df7c9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "858c004a-d447-456f-b067-e296b24cb405");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9b76bd0-de9d-4ad2-9438-64fc420936e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e7281058-1a8b-4968-9b4a-216c13e8c63f", "e7281058-1a8b-4968-9b4a-216c13e8c63f", "admin", "ADMIN" },
                    { "75bd005a-632c-470e-b868-da61859590cb", "75bd005a-632c-470e-b868-da61859590cb", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CountryId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "55baeffd-ada6-4f07-a0bf-912e7172153a", 0, null, "e7281058-1a8b-4968-9b4a-216c13e8c63f", null, "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAEEslpWZj8ElOjY/Rhaxe5MgFADW42rDvaToXSjnicpYXQHN83p2bQIRVpRsarr9kgg==", null, false, "e7281058-1a8b-4968-9b4a-216c13e8c63f", false, "admin@data4mat.com" },
                    { "d8640500-3e4f-40e6-a28e-36cda5d9b2cf", 0, null, "75bd005a-632c-470e-b868-da61859590cb", null, "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAECov84hVhLK0RVqXyTPUYZQ4tPLMoCYdgjC6gISXpEoniOF5ovV66p52uBGQ9rzs3Q==", null, false, "75bd005a-632c-470e-b868-da61859590cb", false, "chris@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e7281058-1a8b-4968-9b4a-216c13e8c63f", "55baeffd-ada6-4f07-a0bf-912e7172153a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "75bd005a-632c-470e-b868-da61859590cb", "d8640500-3e4f-40e6-a28e-36cda5d9b2cf" });
        }
    }
}
