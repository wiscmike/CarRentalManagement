using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddCustomerNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3620d7cf-b86a-4333-8848-d3698532d319",
                column: "ConcurrencyStamp",
                value: "ae9974cb-e1b2-4e4a-b7b3-088e2fa4d743");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                column: "ConcurrencyStamp",
                value: "8cb1c436-485a-4ee1-b27d-f98889bf765e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32bbbb2d-ada2-4750-96a4-976f5de6faa1", "AQAAAAEAACcQAAAAECAxPEawuUbgak4R3cALLsAsrm/d6zDWS0K0YYVnu9MuS7caRzLFbx2bbpaTtCqnXg==", "b0184bd4-198b-4c0f-aebf-9a09b77173de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9BB159FA-1AE6-478B-A4F3-43BE5B450134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60bc374e-12d9-48ac-945c-fe4950bee2a6", "AQAAAAEAACcQAAAAEG1dIKR6xRYThffhlNna/MwsWwxrjmZNSTN+1cdSagrae85He14W20ZUshvL/67POg==", "c8d849c7-4feb-4150-afff-f9bb5a38b121" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 357, DateTimeKind.Local).AddTicks(7218), new DateTime(2021, 8, 8, 13, 42, 13, 359, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(375), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(389), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(393), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(397), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(401), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(405), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(409), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(9938), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(9957), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(9961), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(9965), new DateTime(2021, 8, 8, 13, 42, 13, 360, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3819), new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3836), new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3841), new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3845), new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3849), new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3853), new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3856), new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3860), new DateTime(2021, 8, 8, 13, 42, 13, 361, DateTimeKind.Local).AddTicks(3862) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8956cc02-5a35-49a7-9b0e-7eaf8ad0aa4d", "AQAAAAEAACcQAAAAEKy4eqX9XvjB5GTDyC8Hu4M+Ridd0J1Bu20octQ7js5BIyqzwcHyQWMlnMjq99wPtw==", "72dcf8ed-6a73-4f49-9295-15e52a7e1c8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9BB159FA-1AE6-478B-A4F3-43BE5B450134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26c11e52-fecd-4907-a2b5-2c32fada93d8", "AQAAAAEAACcQAAAAENoGy4fkJk8G/b2fEC0/VGBLUV+unFFe+ZDXWC3aIlRZK1OKVqCnO9+ne4FS2RafkQ==", "593fe018-fd7a-4c88-a304-18bfbb06df78" });

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
        }
    }
}
