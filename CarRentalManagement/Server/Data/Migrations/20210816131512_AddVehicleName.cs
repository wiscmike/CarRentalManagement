using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddVehicleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VehicleImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3620d7cf-b86a-4333-8848-d3698532d319",
                column: "ConcurrencyStamp",
                value: "906c3e61-8285-46f9-994c-a8cb19f8760a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                column: "ConcurrencyStamp",
                value: "1b963567-ca24-4d3f-9099-3a7d0e070b42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44423539-8bd4-4b9b-81da-bed9c9b91d62", "AQAAAAEAACcQAAAAEL8u+ar051cYvIa40rhE37bd54wN3HJ0u7ZlWxLE9+/8SF/9FF7SUsnJKqjg/FtA4A==", "cd11a5df-7a4f-4b8e-9150-bc193e154f5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9BB159FA-1AE6-478B-A4F3-43BE5B450134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff18ff5-745f-43d3-9172-63a5c6226fc5", "AQAAAAEAACcQAAAAEHA8Pwgjkfml8O9j1LX796feq9KEu2Law0Y4+7W0a0wPQTLGUE/lyJ5DUDW3qsukOw==", "8010bbb0-85ad-43a7-8df9-6a5f4213e969" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 591, DateTimeKind.Local).AddTicks(3683), new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7071), new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7084), new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7089), new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7093), new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7097), new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7101), new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7105), new DateTime(2021, 8, 16, 8, 15, 11, 593, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 594, DateTimeKind.Local).AddTicks(6516), new DateTime(2021, 8, 16, 8, 15, 11, 594, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 594, DateTimeKind.Local).AddTicks(6532), new DateTime(2021, 8, 16, 8, 15, 11, 594, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 594, DateTimeKind.Local).AddTicks(6536), new DateTime(2021, 8, 16, 8, 15, 11, 594, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 594, DateTimeKind.Local).AddTicks(6540), new DateTime(2021, 8, 16, 8, 15, 11, 594, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(383), new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(399), new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(403), new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(407), new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(411), new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(415), new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(419), new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(423), new DateTime(2021, 8, 16, 8, 15, 11, 595, DateTimeKind.Local).AddTicks(425) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleImageName",
                table: "Vehicles");

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
    }
}
