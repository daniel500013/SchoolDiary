using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    GradeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeValue = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.GradeID);
                });

            migrationBuilder.CreateTable(
                name: "LessonGrade",
                columns: table => new
                {
                    GradeLessonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_LessonID = table.Column<int>(type: "int", nullable: false),
                    FK_GradeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonGrade", x => x.GradeLessonID);
                    table.ForeignKey(
                        name: "FK_LessonGrade_Grade_FK_GradeID",
                        column: x => x.FK_GradeID,
                        principalTable: "Grade",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonGrade_Lesson_FK_LessonID",
                        column: x => x.FK_LessonID,
                        principalTable: "Lesson",
                        principalColumn: "LessonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonGrade_FK_GradeID",
                table: "LessonGrade",
                column: "FK_GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_LessonGrade_FK_LessonID",
                table: "LessonGrade",
                column: "FK_LessonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonGrade");

            migrationBuilder.DropTable(
                name: "Grade");
        }
    }
}
