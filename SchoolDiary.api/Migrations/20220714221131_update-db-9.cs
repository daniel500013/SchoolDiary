using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClass_Class_FK_ClassID",
                table: "UserClass");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClass_Person_FK_UserUUID",
                table: "UserClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClass",
                table: "UserClass");

            migrationBuilder.RenameTable(
                name: "UserClass",
                newName: "PersonClass");

            migrationBuilder.RenameIndex(
                name: "IX_UserClass_FK_UserUUID",
                table: "PersonClass",
                newName: "IX_PersonClass_FK_UserUUID");

            migrationBuilder.RenameIndex(
                name: "IX_UserClass_FK_ClassID",
                table: "PersonClass",
                newName: "IX_PersonClass_FK_ClassID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonClass",
                table: "PersonClass",
                column: "UserClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonClass_Class_FK_ClassID",
                table: "PersonClass",
                column: "FK_ClassID",
                principalTable: "Class",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonClass_Person_FK_UserUUID",
                table: "PersonClass",
                column: "FK_UserUUID",
                principalTable: "Person",
                principalColumn: "UserUUID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonClass_Class_FK_ClassID",
                table: "PersonClass");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonClass_Person_FK_UserUUID",
                table: "PersonClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonClass",
                table: "PersonClass");

            migrationBuilder.RenameTable(
                name: "PersonClass",
                newName: "UserClass");

            migrationBuilder.RenameIndex(
                name: "IX_PersonClass_FK_UserUUID",
                table: "UserClass",
                newName: "IX_UserClass_FK_UserUUID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonClass_FK_ClassID",
                table: "UserClass",
                newName: "IX_UserClass_FK_ClassID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClass",
                table: "UserClass",
                column: "UserClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClass_Class_FK_ClassID",
                table: "UserClass",
                column: "FK_ClassID",
                principalTable: "Class",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClass_Person_FK_UserUUID",
                table: "UserClass",
                column: "FK_UserUUID",
                principalTable: "Person",
                principalColumn: "UserUUID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
