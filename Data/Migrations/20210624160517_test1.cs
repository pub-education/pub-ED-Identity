using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18b1419a-fa9f-4f6c-98c6-f386375efdcd", "18b1419a-fa9f-4f6c-98c6-f386375efdcd", "user", "USER" },
                    { "47b5e103-773d-44cf-9806-f5166b1402b8", "47b5e103-773d-44cf-9806-f5166b1402b8", "admin", "ADMIN" }
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
                values: new object[] { "47b5e103-773d-44cf-9806-f5166b1402b8", "b29269ef-3770-46eb-ac94-7c6af527e681" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "18b1419a-fa9f-4f6c-98c6-f386375efdcd", "76018987-d4ce-4b5c-8f71-55499f37eff7" });
        }
    }
}
