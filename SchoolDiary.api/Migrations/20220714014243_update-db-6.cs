using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonParent_Parent_FK_ParentID",
                table: "PersonParent");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("dd2326c0-b238-4048-b152-42b7b538ac71"));

            migrationBuilder.AlterColumn<int>(
                name: "FK_ParentID",
                table: "PersonParent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[] { new Guid("2017f210-3bae-4642-a8e4-fb2c879f0e20"), null, null, "test@test.com", null, null, "AQAAAAEAACcQAAAAEKagpYTaF6bqrs3Uufuuk2W90+hfPoz5uVR11oFOOvbx9rIMWML4udQCEtyaPNPY6Q==", null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonParent_Parent_FK_ParentID",
                table: "PersonParent",
                column: "FK_ParentID",
                principalTable: "Parent",
                principalColumn: "ParentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonParent_Parent_FK_ParentID",
                table: "PersonParent");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2017f210-3bae-4642-a8e4-fb2c879f0e20"));

            migrationBuilder.AlterColumn<int>(
                name: "FK_ParentID",
                table: "PersonParent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[] { new Guid("dd2326c0-b238-4048-b152-42b7b538ac71"), null, null, "test@test.com", null, null, "AQAAAAEAACcQAAAAEFJFQYavpv+yu6oassXo+OaejZRcuK0SreqRfln3QRVeLbdcvUR6Ftrh+xosasA0OA==", null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonParent_Parent_FK_ParentID",
                table: "PersonParent",
                column: "FK_ParentID",
                principalTable: "Parent",
                principalColumn: "ParentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
