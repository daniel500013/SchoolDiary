using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonParent_Parent_ParentID",
                table: "PersonParent");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2a5a6c19-e060-4b68-970a-14bcf84ceeb6"));

            migrationBuilder.RenameColumn(
                name: "ParentID",
                table: "PersonParent",
                newName: "FK_ParentID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonParent_ParentID",
                table: "PersonParent",
                newName: "IX_PersonParent_FK_ParentID");

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[] { new Guid("259764c6-c2b6-461a-9c62-8fc3121e2bf2"), null, null, "test@test.com", null, null, "AQAAAAEAACcQAAAAENDXpGfYNV19p4FajpQzCx+gOMeAUxFBffyyyvKCOzSbyhEIrSaAUohsI5X+Xv1wrQ==", null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonParent_Parent_FK_ParentID",
                table: "PersonParent",
                column: "FK_ParentID",
                principalTable: "Parent",
                principalColumn: "ParentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonParent_Parent_FK_ParentID",
                table: "PersonParent");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("259764c6-c2b6-461a-9c62-8fc3121e2bf2"));

            migrationBuilder.RenameColumn(
                name: "FK_ParentID",
                table: "PersonParent",
                newName: "ParentID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonParent_FK_ParentID",
                table: "PersonParent",
                newName: "IX_PersonParent_ParentID");

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[] { new Guid("2a5a6c19-e060-4b68-970a-14bcf84ceeb6"), null, null, "test@test.com", null, null, "AQAAAAEAACcQAAAAEM8IgGU60dYUZXFF4fWVllbhM1VogG7n9FIvQ0okw0zxoEEzlreBklgK8AmWKqRI0g==", null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonParent_Parent_ParentID",
                table: "PersonParent",
                column: "ParentID",
                principalTable: "Parent",
                principalColumn: "ParentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
