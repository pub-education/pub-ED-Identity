using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class cityCountryStringsApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Discriminator",
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

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47b5e103-773d-44cf-9806-f5166b1402b8", "47b5e103-773d-44cf-9806-f5166b1402b8", "admin", "ADMIN" },
                    { "18b1419a-fa9f-4f6c-98c6-f386375efdcd", "18b1419a-fa9f-4f6c-98c6-f386375efdcd", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CityId", "ConcurrencyStamp", "Country", "CountryId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b29269ef-3770-46eb-ac94-7c6af527e681", 0, null, 12, "47b5e103-773d-44cf-9806-f5166b1402b8", null, 0, "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAEOPstK0qlCayq3O1ZNFyi4FI/nNQSXswR9Piq2l3VDv/MCbGYKtc1Jg7/9rjsIJojw==", null, false, "47b5e103-773d-44cf-9806-f5166b1402b8", false, "admin@data4mat.com" },
                    { "76018987-d4ce-4b5c-8f71-55499f37eff7", 0, null, 1, "18b1419a-fa9f-4f6c-98c6-f386375efdcd", null, 0, "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAEKsKtAqHuGKwBmtHodsc31nrQ1smPcCJhR3YPgJNfBINiBmhVtweI/caq95A+Uqb/w==", null, false, "18b1419a-fa9f-4f6c-98c6-f386375efdcd", false, "chris@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "47b5e103-773d-44cf-9806-f5166b1402b8", "b29269ef-3770-46eb-ac94-7c6af527e681" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "18b1419a-fa9f-4f6c-98c6-f386375efdcd", "76018987-d4ce-4b5c-8f71-55499f37eff7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18b1419a-fa9f-4f6c-98c6-f386375efdcd", "76018987-d4ce-4b5c-8f71-55499f37eff7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "47b5e103-773d-44cf-9806-f5166b1402b8", "b29269ef-3770-46eb-ac94-7c6af527e681" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18b1419a-fa9f-4f6c-98c6-f386375efdcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b5e103-773d-44cf-9806-f5166b1402b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76018987-d4ce-4b5c-8f71-55499f37eff7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b29269ef-3770-46eb-ac94-7c6af527e681");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
