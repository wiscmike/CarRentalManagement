using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3620d7cf-b86a-4333-8848-d3698532d319", "7fbd2b72-14dd-4e9d-b4ee-b391cb0767e4", "User", "USER" },
                    { "4fe0b7ce-e739-42f2-9ef9-4443993b2179", "b1085401-1f31-4f91-a061-5717d3c4727c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 376, DateTimeKind.Local).AddTicks(6849), new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9619), new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9633), new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9638), new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9642), new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9646), new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9649), new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9653), new DateTime(2021, 7, 23, 10, 21, 21, 378, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 379, DateTimeKind.Local).AddTicks(9550), new DateTime(2021, 7, 23, 10, 21, 21, 379, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 379, DateTimeKind.Local).AddTicks(9568), new DateTime(2021, 7, 23, 10, 21, 21, 379, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 379, DateTimeKind.Local).AddTicks(9572), new DateTime(2021, 7, 23, 10, 21, 21, 379, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 379, DateTimeKind.Local).AddTicks(9577), new DateTime(2021, 7, 23, 10, 21, 21, 379, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3501), new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3517), new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3522), new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3526), new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3530), new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3534), new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3538), new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3542), new DateTime(2021, 7, 23, 10, 21, 21, 380, DateTimeKind.Local).AddTicks(3544) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3620d7cf-b86a-4333-8848-d3698532d319");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe0b7ce-e739-42f2-9ef9-4443993b2179");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 720, DateTimeKind.Local).AddTicks(4554), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8451), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8468), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8472), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8476), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8480), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8485), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8489), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8265), new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8287), new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8291), new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8295), new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2269), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2288), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2293), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2297), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2301), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2305), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2309), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2313), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2315) });
        }
    }
}
