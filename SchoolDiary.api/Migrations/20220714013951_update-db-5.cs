using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("259764c6-c2b6-461a-9c62-8fc3121e2bf2"));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parent",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[] { new Guid("dd2326c0-b238-4048-b152-42b7b538ac71"), null, null, "test@test.com", null, null, "AQAAAAEAACcQAAAAEFJFQYavpv+yu6oassXo+OaejZRcuK0SreqRfln3QRVeLbdcvUR6Ftrh+xosasA0OA==", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("dd2326c0-b238-4048-b152-42b7b538ac71"));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parent",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[] { new Guid("259764c6-c2b6-461a-9c62-8fc3121e2bf2"), null, null, "test@test.com", null, null, "AQAAAAEAACcQAAAAENDXpGfYNV19p4FajpQzCx+gOMeAUxFBffyyyvKCOzSbyhEIrSaAUohsI5X+Xv1wrQ==", null, null });
        }
    }
}
