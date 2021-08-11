using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDataStringLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "Vehicles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3620d7cf-b86a-4333-8848-d3698532d319",
                column: "ConcurrencyStamp",
                value: "b8dbced8-7430-4c44-a122-c3e86ac51af6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                column: "ConcurrencyStamp",
                value: "add5803d-e672-4208-bd89-71139ee4e589");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00f59155-79de-4678-9654-483079ea9786", "AQAAAAEAACcQAAAAECTtgkkDtfRLwIeatlPR7KizG5D7NVSHp1y1v9ZeX5viwEDNZ2a7akewxcROLFkNlQ==", "a7629c59-5bca-4e0e-992c-5ba43c02718e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9BB159FA-1AE6-478B-A4F3-43BE5B450134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce566d24-3c59-4171-b754-49b235dde7ca", "AQAAAAEAACcQAAAAEOVJizVMWkac8DuFVTktHSlqb6Is17EvDksPc7zk9oYzh39VbM7afAIq4PWZUY6Puw==", "42a72c3a-1143-4bf5-92ee-b5e6bc794c6e" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 925, DateTimeKind.Local).AddTicks(8930), new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2056), new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2070), new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2074), new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2077), new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2081), new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2085), new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2089), new DateTime(2021, 8, 10, 17, 41, 37, 928, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(1387), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(1404), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(1408), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(1412), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5231), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5246), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5250), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5254), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5258), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5262), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5266), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5270), new DateTime(2021, 8, 10, 17, 41, 37, 929, DateTimeKind.Local).AddTicks(5272) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
