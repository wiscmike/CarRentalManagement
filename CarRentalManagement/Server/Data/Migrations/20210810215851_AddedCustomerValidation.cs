using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
