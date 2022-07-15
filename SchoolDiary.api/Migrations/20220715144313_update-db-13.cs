using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Lesson",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    MarkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Present = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark", x => x.MarkID);
                });

            migrationBuilder.CreateTable(
                name: "LessonMark",
                columns: table => new
                {
                    LessonMarkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_LessonID = table.Column<int>(type: "int", nullable: false),
                    FK_MarkID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonMark", x => x.LessonMarkID);
                    table.ForeignKey(
                        name: "FK_LessonMark_Lesson_FK_LessonID",
                        column: x => x.FK_LessonID,
                        principalTable: "Lesson",
                        principalColumn: "LessonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonMark_Mark_FK_MarkID",
                        column: x => x.FK_MarkID,
                        principalTable: "Mark",
                        principalColumn: "MarkID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonMark_FK_LessonID",
                table: "LessonMark",
                column: "FK_LessonID");

            migrationBuilder.CreateIndex(
                name: "IX_LessonMark_FK_MarkID",
                table: "LessonMark",
                column: "FK_MarkID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonMark");

            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Lesson");
        }
    }
}
