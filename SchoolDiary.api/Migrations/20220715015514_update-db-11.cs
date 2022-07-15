using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FK_PersonClass",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_FK_PersonClass",
                table: "Subject",
                column: "FK_PersonClass");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_PersonClass_FK_PersonClass",
                table: "Subject",
                column: "FK_PersonClass",
                principalTable: "PersonClass",
                principalColumn: "UserClassID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_PersonClass_FK_PersonClass",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_FK_PersonClass",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "FK_PersonClass",
                table: "Subject");
        }
    }
}
