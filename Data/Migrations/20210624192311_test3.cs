using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Data.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "CountryRefId",
                table: "Cities",
                newName: "CountryId");

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cities_CityId",
                table: "AspNetUsers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Countries_CountryId",
                table: "AspNetUsers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cities_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Countries_CountryId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers");

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

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Cities",
                newName: "CountryRefId");

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

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d0b387f-bd66-441b-88d1-97b2b5afa5bf", "1d0b387f-bd66-441b-88d1-97b2b5afa5bf", "admin", "ADMIN" },
                    { "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245", "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245", "user", "USER" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1d0b387f-bd66-441b-88d1-97b2b5afa5bf", "278ffd82-5c7e-4c3d-8ceb-2dd382cd9011" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "360e7fe5-2ef4-4ee4-8c66-fa22e2d50245", "57a2906d-ef97-4b0d-bd84-d8eb09f4701a" });
        }
    }
}
