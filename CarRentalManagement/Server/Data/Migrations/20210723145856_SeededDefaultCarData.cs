using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 23, 9, 58, 55, 720, DateTimeKind.Local).AddTicks(4554), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(7875), "Black", "System" },
                    { 2, "System", new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8451), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8464), "White", "System" },
                    { 3, "System", new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8468), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8470), "Green", "System" },
                    { 4, "System", new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8472), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8474), "Blue", "System" },
                    { 5, "System", new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8476), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8478), "Silver", "System" },
                    { 6, "System", new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8480), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8482), "Red", "System" },
                    { 7, "System", new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8485), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8486), "Gray", "System" },
                    { 8, "System", new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8489), new DateTime(2021, 7, 23, 9, 58, 55, 722, DateTimeKind.Local).AddTicks(8490), "Yellow", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 4, "System", new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8295), new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8297), "Ford", "System" },
                    { 3, "System", new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8291), new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8293), "Tesla", "System" },
                    { 2, "System", new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8287), new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8289), "Subaru", "System" },
                    { 1, "System", new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8265), new DateTime(2021, 7, 23, 9, 58, 55, 723, DateTimeKind.Local).AddTicks(8282), "Honda", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2269), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2284), "Pilot", "System" },
                    { 2, "System", new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2288), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2290), "Accord", "System" },
                    { 3, "System", new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2293), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2295), "Outback", "System" },
                    { 4, "System", new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2297), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2299), "Forester", "System" },
                    { 5, "System", new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2301), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2303), "Model Y", "System" },
                    { 6, "System", new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2305), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2307), "Model 3", "System" },
                    { 7, "System", new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2309), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2311), "Mustang Shelby GT500", "System" },
                    { 8, "System", new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2313), new DateTime(2021, 7, 23, 9, 58, 55, 724, DateTimeKind.Local).AddTicks(2315), "F-150", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
