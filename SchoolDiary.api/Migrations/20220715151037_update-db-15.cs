using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Approve",
                columns: table => new
                {
                    ApproveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Positive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approve", x => x.ApproveID);
                });

            migrationBuilder.CreateTable(
                name: "LessonApprove",
                columns: table => new
                {
                    LessonApproveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_LessonID = table.Column<int>(type: "int", nullable: false),
                    FK_GradeID = table.Column<int>(type: "int", nullable: false),
                    FK_ApproveID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonApprove", x => x.LessonApproveID);
                    table.ForeignKey(
                        name: "FK_LessonApprove_Approve_FK_ApproveID",
                        column: x => x.FK_ApproveID,
                        principalTable: "Approve",
                        principalColumn: "ApproveID");
                    table.ForeignKey(
                        name: "FK_LessonApprove_Lesson_FK_LessonID",
                        column: x => x.FK_LessonID,
                        principalTable: "Lesson",
                        principalColumn: "LessonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonApprove_FK_ApproveID",
                table: "LessonApprove",
                column: "FK_ApproveID");

            migrationBuilder.CreateIndex(
                name: "IX_LessonApprove_FK_LessonID",
                table: "LessonApprove",
                column: "FK_LessonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonApprove");

            migrationBuilder.DropTable(
                name: "Approve");
        }
    }
}
