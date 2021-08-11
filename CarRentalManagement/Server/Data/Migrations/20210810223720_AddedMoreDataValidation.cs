using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedMoreDataValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3620d7cf-b86a-4333-8848-d3698532d319",
                column: "ConcurrencyStamp",
                value: "e1f7a871-e86f-44bf-94a7-67db587e1e3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                column: "ConcurrencyStamp",
                value: "8f716567-b584-48b7-b5bf-9bf1e82705e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8260cc7-e535-4295-ab12-665115bf6043", "AQAAAAEAACcQAAAAECBThvBzYCv9zV8mdT0qdzAO1nNlCfc/N40Gj7/2IWCT2kToIYamQbjS2uIPVIXLLg==", "81d19ff5-fcbe-4172-a12c-d4c815d5b149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9BB159FA-1AE6-478B-A4F3-43BE5B450134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8c19b93-258d-47bc-bb66-828679bd373c", "AQAAAAEAACcQAAAAEMW/sL49vO9c9jz7ZAyCLu4NJvu7fYxi4u4C1x2Ykr7lCy8+CkX2s5lSpxutJUMi8A==", "c67abaad-afba-4069-a4c4-4f427b2ea831" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 428, DateTimeKind.Local).AddTicks(6195), new DateTime(2021, 8, 10, 17, 37, 20, 430, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(47), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(61), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(65), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(69), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(72), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(76), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(80), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(9536), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(9554), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(9558), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(9562), new DateTime(2021, 8, 10, 17, 37, 20, 431, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3521), new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3538), new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3543), new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3546), new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3586), new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3591), new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3595), new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3599), new DateTime(2021, 8, 10, 17, 37, 20, 432, DateTimeKind.Local).AddTicks(3601) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3620d7cf-b86a-4333-8848-d3698532d319",
                column: "ConcurrencyStamp",
                value: "dc080087-9bdb-4a8f-b508-d4cc034ddc35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                column: "ConcurrencyStamp",
                value: "917cb0cf-3d69-4525-b12b-a8d7b8e31671");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad0293ed-6275-483c-83ec-75a0ace73f77", "AQAAAAEAACcQAAAAEHS/SWdmWD8LY9jzE/K+whgQgbtE7mqF9qiDMLyBkISAJCeiL5f5gpwp6v//bNC35g==", "5622bb49-30e1-4db5-9400-9d71154a1d63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9BB159FA-1AE6-478B-A4F3-43BE5B450134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e3f8d4a-499f-470b-8245-1cd7622558c8", "AQAAAAEAACcQAAAAECOKesCnbgK2O9XsZjyU+LBRipltoLVzf/9cLWPq3cAH8j8ElXi49TwizEhbSj+G9Q==", "e82cb746-6460-4004-a413-a86d86277e8d" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 489, DateTimeKind.Local).AddTicks(9003), new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2834), new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2849), new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2853), new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2857), new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2861), new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2865), new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2869), new DateTime(2021, 8, 10, 16, 58, 51, 492, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(2406), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(2425), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(2429), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(2433), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6295), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6312), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6316), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6320), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6324), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6328), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6332), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6335), new DateTime(2021, 8, 10, 16, 58, 51, 493, DateTimeKind.Local).AddTicks(6337) });
        }
    }
}
