using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245", "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245", "user", "USER" },
                    { "1d0b387f-bd66-441b-88d1-97b2b5afa5bf", "1d0b387f-bd66-441b-88d1-97b2b5afa5bf", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CityId", "ConcurrencyStamp", "Country", "CountryId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "278ffd82-5c7e-4c3d-8ceb-2dd382cd9011", 0, null, 12, "1d0b387f-bd66-441b-88d1-97b2b5afa5bf", null, 0, "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", null, "AQAAAAEAACcQAAAAEMl7gi0RUN4U03OARGHTjPeoxyaxWN2Jvz95nkxNMEu83S+vUTocqeT+CQ+JV+XI5A==", null, false, "1d0b387f-bd66-441b-88d1-97b2b5afa5bf", false, "admin@data4mat.com" },
                    { "57a2906d-ef97-4b0d-bd84-d8eb09f4701a", 0, null, 1, "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245", null, 0, "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", null, "AQAAAAEAACcQAAAAEPORJ0Sktew0NDv9ovUNlxnpmEkB2L0pPBtQFr96ddkjTHdxY8QC6WhDmy1rDzXw2g==", null, false, "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245", false, "chris@data4mat.com" }
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
                values: new object[] { "1d0b387f-bd66-441b-88d1-97b2b5afa5bf", "278ffd82-5c7e-4c3d-8ceb-2dd382cd9011" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245", "57a2906d-ef97-4b0d-bd84-d8eb09f4701a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d0b387f-bd66-441b-88d1-97b2b5afa5bf", "278ffd82-5c7e-4c3d-8ceb-2dd382cd9011" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245", "57a2906d-ef97-4b0d-bd84-d8eb09f4701a" });

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
                keyValue: "1d0b387f-bd66-441b-88d1-97b2b5afa5bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "278ffd82-5c7e-4c3d-8ceb-2dd382cd9011");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57a2906d-ef97-4b0d-bd84-d8eb09f4701a");
        }
    }
}
