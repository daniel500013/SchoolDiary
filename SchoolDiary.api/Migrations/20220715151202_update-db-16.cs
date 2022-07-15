using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonApprove_Approve_FK_ApproveID",
                table: "LessonApprove");

            migrationBuilder.DropColumn(
                name: "FK_GradeID",
                table: "LessonApprove");

            migrationBuilder.AlterColumn<int>(
                name: "FK_ApproveID",
                table: "LessonApprove",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonApprove_Approve_FK_ApproveID",
                table: "LessonApprove",
                column: "FK_ApproveID",
                principalTable: "Approve",
                principalColumn: "ApproveID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonApprove_Approve_FK_ApproveID",
                table: "LessonApprove");

            migrationBuilder.AlterColumn<int>(
                name: "FK_ApproveID",
                table: "LessonApprove",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FK_GradeID",
                table: "LessonApprove",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonApprove_Approve_FK_ApproveID",
                table: "LessonApprove",
                column: "FK_ApproveID",
                principalTable: "Approve",
                principalColumn: "ApproveID");
        }
    }
}
