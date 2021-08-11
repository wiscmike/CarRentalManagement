using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3620d7cf-b86a-4333-8848-d3698532d319",
                column: "ConcurrencyStamp",
                value: "607b704b-d795-4543-8494-3aca6a0b6268");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                column: "ConcurrencyStamp",
                value: "70413a52-1779-4b5f-9ffb-de842a9ddb7f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a64c9bb9-bc7b-4bf0-9309-324ffa6167f6", "AQAAAAEAACcQAAAAEIzzfo01Nci7YaOQ3peY+vThcQDXNXl/PMTM5JFbmuGPP1B/M7nJ5Kxm7cOKCfKfzw==", "cf87139d-0020-4507-8d96-0acc1d5f7a22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9BB159FA-1AE6-478B-A4F3-43BE5B450134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9363796a-02ad-4a5c-8e8c-1fc45ec6b779", "AQAAAAEAACcQAAAAEDV3VxQjs2BjYC9wegzsJfNUEAqNtMoXaGJRoBK2AlCZyMRjlTvkYUbepGuf2G4M4g==", "cb516ad5-b22c-4740-8173-d77ac3f9fbda" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 63, DateTimeKind.Local).AddTicks(1636), new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6582), new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6597), new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6601), new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6605), new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6609), new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6613), new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6617), new DateTime(2021, 8, 10, 10, 3, 25, 65, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 66, DateTimeKind.Local).AddTicks(6724), new DateTime(2021, 8, 10, 10, 3, 25, 66, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 66, DateTimeKind.Local).AddTicks(6742), new DateTime(2021, 8, 10, 10, 3, 25, 66, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 66, DateTimeKind.Local).AddTicks(6747), new DateTime(2021, 8, 10, 10, 3, 25, 66, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 66, DateTimeKind.Local).AddTicks(6751), new DateTime(2021, 8, 10, 10, 3, 25, 66, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(609), new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(626), new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(630), new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(634), new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(674), new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(679), new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(683), new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(687), new DateTime(2021, 8, 10, 10, 3, 25, 67, DateTimeKind.Local).AddTicks(688) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
