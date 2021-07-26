using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3620d7cf-b86a-4333-8848-d3698532d319",
                column: "ConcurrencyStamp",
                value: "0fa3fb87-c503-45c8-8ab5-905e156cb80a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                column: "ConcurrencyStamp",
                value: "b37ada6d-7a6a-4d15-b6ac-6b2b32d21bf4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8", 0, "8956cc02-5a35-49a7-9b0e-7eaf8ad0aa4d", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKy4eqX9XvjB5GTDyC8Hu4M+Ridd0J1Bu20octQ7js5BIyqzwcHyQWMlnMjq99wPtw==", null, false, "72dcf8ed-6a73-4f49-9295-15e52a7e1c8e", false, "user@localhost.com" },
                    { "9BB159FA-1AE6-478B-A4F3-43BE5B450134", 0, "26c11e52-fecd-4907-a2b5-2c32fada93d8", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENoGy4fkJk8G/b2fEC0/VGBLUV+unFFe+ZDXWC3aIlRZK1OKVqCnO9+ne4FS2RafkQ==", null, false, "593fe018-fd7a-4c88-a304-18bfbb06df78", false, "admin@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 689, DateTimeKind.Local).AddTicks(4046), new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5372), new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5387), new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5391), new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5395), new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5399), new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5403), new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5407), new DateTime(2021, 7, 26, 7, 53, 9, 691, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(5320), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(5340), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(5344), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(5348), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9298), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9317), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9321), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9325), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9329), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9333), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9337), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9341), new DateTime(2021, 7, 26, 7, 53, 9, 692, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3620d7cf-b86a-4333-8848-d3698532d319", "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4fe0b7ce-e739-42f2-9ef9-4443993b2179", "9BB159FA-1AE6-478B-A4F3-43BE5B450134" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3620d7cf-b86a-4333-8848-d3698532d319", "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4fe0b7ce-e739-42f2-9ef9-4443993b2179", "9BB159FA-1AE6-478B-A4F3-43BE5B450134" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9BB159FA-1AE6-478B-A4F3-43BE5B450134");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "Firstname");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3620d7cf-b86a-4333-8848-d3698532d319",
                column: "ConcurrencyStamp",
                value: "7fbd2b72-14dd-4e9d-b4ee-b391cb0767e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                column: "ConcurrencyStamp",
                value: "b1085401-1f31-4f91-a061-5717d3c4727c");

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
    }
}
