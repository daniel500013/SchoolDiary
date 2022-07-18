using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Approve",
                columns: new[] { "ApproveID", "Description", "Positive" },
                values: new object[,]
                {
                    { 1, "", true },
                    { 2, "", true },
                    { 3, "", false },
                    { 4, "", true },
                    { 5, "", false },
                    { 6, "", true },
                    { 7, "", true },
                    { 8, "", true },
                    { 9, "", true },
                    { 10, "", true },
                    { 11, "", false },
                    { 12, "", false },
                    { 13, "", false },
                    { 14, "", true },
                    { 15, "", false },
                    { 16, "", true },
                    { 17, "", true },
                    { 18, "", false },
                    { 19, "", false },
                    { 20, "", true },
                    { 21, "", true },
                    { 22, "", true },
                    { 23, "", false },
                    { 24, "", false },
                    { 25, "", true },
                    { 26, "", false },
                    { 27, "", true },
                    { 28, "", false },
                    { 29, "", false },
                    { 30, "", false }
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "ClassID", "ClassNumber", "Description", "Profile" },
                values: new object[,]
                {
                    { 1, 1, null, "Q" },
                    { 2, 2, null, "W" },
                    { 3, 3, null, "E" },
                    { 4, 4, null, "R" },
                    { 5, 5, null, "T" },
                    { 6, 6, null, "Y" },
                    { 7, 7, null, "U" },
                    { 8, 8, null, "I" },
                    { 9, 9, null, "O" },
                    { 10, 10, null, "P" }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 1, "", 1, 2 },
                    { 2, "", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 3, "", 6, 2 },
                    { 4, "", 6, 1 },
                    { 5, "", 3, 3 },
                    { 6, "", 2, 2 },
                    { 7, "", 3, 3 },
                    { 8, "", 3, 1 },
                    { 9, "", 1, 2 },
                    { 10, "", 1, 1 },
                    { 11, "", 4, 3 },
                    { 12, "", 4, 2 },
                    { 13, "", 3, 2 },
                    { 14, "", 6, 3 },
                    { 15, "", 4, 1 },
                    { 16, "", 3, 2 },
                    { 17, "", 6, 1 },
                    { 18, "", 6, 2 },
                    { 19, "", 5, 2 },
                    { 20, "", 6, 2 },
                    { 21, "", 3, 3 },
                    { 22, "", 5, 1 },
                    { 23, "", 2, 2 },
                    { 24, "", 3, 1 },
                    { 25, "", 1, 3 },
                    { 26, "", 5, 2 },
                    { 27, "", 6, 1 },
                    { 28, "", 6, 2 },
                    { 29, "", 4, 1 },
                    { 30, "", 6, 3 },
                    { 31, "", 2, 2 },
                    { 32, "", 1, 2 },
                    { 33, "", 4, 1 },
                    { 34, "", 2, 3 },
                    { 35, "", 3, 1 },
                    { 36, "", 1, 2 },
                    { 37, "", 5, 2 },
                    { 38, "", 6, 2 },
                    { 39, "", 1, 1 },
                    { 40, "", 2, 1 },
                    { 41, "", 6, 1 },
                    { 42, "", 4, 1 },
                    { 43, "", 1, 2 },
                    { 44, "", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 45, "", 4, 2 },
                    { 46, "", 5, 2 },
                    { 47, "", 4, 2 },
                    { 48, "", 3, 2 },
                    { 49, "", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "English" },
                    { 2, 1, 2, "History" },
                    { 3, 1, 3, "Geography" },
                    { 4, 1, 4, "Geography" },
                    { 5, 1, 5, "Math" },
                    { 6, 1, 6, "History" },
                    { 7, 1, 7, "Chemistry" },
                    { 8, 1, 8, "Geography" },
                    { 9, 2, 1, "Math" },
                    { 10, 2, 2, "History" },
                    { 11, 2, 3, "Math" },
                    { 12, 2, 4, "Physics" },
                    { 13, 2, 5, "History" },
                    { 14, 2, 6, "English" },
                    { 15, 2, 7, "Polish" },
                    { 16, 2, 8, "Polish" },
                    { 17, 3, 1, "Chemistry" },
                    { 18, 3, 2, "Math" },
                    { 19, 3, 3, "Physics" },
                    { 20, 3, 4, "Math" },
                    { 21, 3, 5, "Physics" },
                    { 22, 3, 6, "English" },
                    { 23, 3, 7, "English" },
                    { 24, 3, 8, "Physics" },
                    { 25, 4, 1, "Physics" },
                    { 26, 4, 2, "English" },
                    { 27, 4, 3, "Chemistry" },
                    { 28, 4, 4, "Polish" },
                    { 29, 4, 5, "Geography" },
                    { 30, 4, 6, "Geography" },
                    { 31, 4, 7, "Polish" },
                    { 32, 4, 8, "Chemistry" },
                    { 33, 5, 1, "Math" },
                    { 34, 5, 2, "Physics" },
                    { 35, 5, 3, "English" },
                    { 36, 5, 4, "Polish" },
                    { 37, 5, 5, "Polish" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 38, 5, 6, "English" },
                    { 39, 5, 7, "English" },
                    { 40, 5, 8, "Physics" },
                    { 41, 1, 1, "Chemistry" },
                    { 42, 1, 2, "PE" },
                    { 43, 1, 3, "Geography" },
                    { 44, 1, 4, "History" },
                    { 45, 1, 5, "Geography" },
                    { 46, 1, 6, "Geography" },
                    { 47, 1, 7, "Geography" },
                    { 48, 1, 8, "History" },
                    { 49, 2, 1, "PE" },
                    { 50, 2, 2, "Physics" },
                    { 51, 2, 3, "Geography" },
                    { 52, 2, 4, "English" },
                    { 53, 2, 5, "Polish" },
                    { 54, 2, 6, "Math" },
                    { 55, 2, 7, "Chemistry" },
                    { 56, 2, 8, "Geography" },
                    { 57, 3, 1, "Chemistry" },
                    { 58, 3, 2, "History" },
                    { 59, 3, 3, "Geography" },
                    { 60, 3, 4, "Chemistry" },
                    { 61, 3, 5, "Physics" },
                    { 62, 3, 6, "Polish" },
                    { 63, 3, 7, "Geography" },
                    { 64, 3, 8, "Physics" },
                    { 65, 4, 1, "Chemistry" },
                    { 66, 4, 2, "Geography" },
                    { 67, 4, 3, "Polish" },
                    { 68, 4, 4, "Chemistry" },
                    { 69, 4, 5, "Polish" },
                    { 70, 4, 6, "PE" },
                    { 71, 4, 7, "Chemistry" },
                    { 72, 4, 8, "History" },
                    { 73, 5, 1, "PE" },
                    { 74, 5, 2, "History" },
                    { 75, 5, 3, "Geography" },
                    { 76, 5, 4, "PE" },
                    { 77, 5, 5, "English" },
                    { 78, 5, 6, "English" },
                    { 79, 5, 7, "English" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 80, 5, 8, "Polish" },
                    { 81, 1, 1, "History" },
                    { 82, 1, 2, "PE" },
                    { 83, 1, 3, "Geography" },
                    { 84, 1, 4, "Chemistry" },
                    { 85, 1, 5, "PE" },
                    { 86, 1, 6, "History" },
                    { 87, 1, 7, "Chemistry" },
                    { 88, 1, 8, "Geography" },
                    { 89, 2, 1, "PE" },
                    { 90, 2, 2, "Math" },
                    { 91, 2, 3, "PE" },
                    { 92, 2, 4, "Geography" },
                    { 93, 2, 5, "Chemistry" },
                    { 94, 2, 6, "PE" },
                    { 95, 2, 7, "History" },
                    { 96, 2, 8, "History" },
                    { 97, 3, 1, "English" },
                    { 98, 3, 2, "English" },
                    { 99, 3, 3, "Geography" },
                    { 100, 3, 4, "Polish" },
                    { 101, 3, 5, "Physics" },
                    { 102, 3, 6, "History" },
                    { 103, 3, 7, "Math" },
                    { 104, 3, 8, "Math" },
                    { 105, 4, 1, "History" },
                    { 106, 4, 2, "Polish" },
                    { 107, 4, 3, "Polish" },
                    { 108, 4, 4, "History" },
                    { 109, 4, 5, "Physics" },
                    { 110, 4, 6, "Polish" },
                    { 111, 4, 7, "Chemistry" },
                    { 112, 4, 8, "Geography" },
                    { 113, 5, 1, "Physics" },
                    { 114, 5, 2, "Chemistry" },
                    { 115, 5, 3, "Polish" },
                    { 116, 5, 4, "Chemistry" },
                    { 117, 5, 5, "Chemistry" },
                    { 118, 5, 6, "Math" },
                    { 119, 5, 7, "English" },
                    { 120, 5, 8, "Polish" },
                    { 121, 1, 1, "History" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 122, 1, 2, "Polish" },
                    { 123, 1, 3, "Math" },
                    { 124, 1, 4, "Chemistry" },
                    { 125, 1, 5, "Math" },
                    { 126, 1, 6, "Geography" },
                    { 127, 1, 7, "Chemistry" },
                    { 128, 1, 8, "Chemistry" },
                    { 129, 2, 1, "Geography" },
                    { 130, 2, 2, "English" },
                    { 131, 2, 3, "Math" },
                    { 132, 2, 4, "Physics" },
                    { 133, 2, 5, "English" },
                    { 134, 2, 6, "Math" },
                    { 135, 2, 7, "Chemistry" },
                    { 136, 2, 8, "Geography" },
                    { 137, 3, 1, "Physics" },
                    { 138, 3, 2, "Chemistry" },
                    { 139, 3, 3, "English" },
                    { 140, 3, 4, "History" },
                    { 141, 3, 5, "English" },
                    { 142, 3, 6, "Math" },
                    { 143, 3, 7, "PE" },
                    { 144, 3, 8, "Geography" },
                    { 145, 4, 1, "History" },
                    { 146, 4, 2, "English" },
                    { 147, 4, 3, "English" },
                    { 148, 4, 4, "Physics" },
                    { 149, 4, 5, "Math" },
                    { 150, 4, 6, "PE" },
                    { 151, 4, 7, "History" },
                    { 152, 4, 8, "PE" },
                    { 153, 5, 1, "History" },
                    { 154, 5, 2, "Geography" },
                    { 155, 5, 3, "History" },
                    { 156, 5, 4, "Geography" },
                    { 157, 5, 5, "PE" },
                    { 158, 5, 6, "Chemistry" },
                    { 159, 5, 7, "English" },
                    { 160, 5, 8, "History" },
                    { 161, 1, 1, "Math" },
                    { 162, 1, 2, "Polish" },
                    { 163, 1, 3, "Math" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 164, 1, 4, "Chemistry" },
                    { 165, 1, 5, "Physics" },
                    { 166, 1, 6, "English" },
                    { 167, 1, 7, "English" },
                    { 168, 1, 8, "English" },
                    { 169, 2, 1, "Chemistry" },
                    { 170, 2, 2, "Math" },
                    { 171, 2, 3, "Physics" },
                    { 172, 2, 4, "Math" },
                    { 173, 2, 5, "Geography" },
                    { 174, 2, 6, "History" },
                    { 175, 2, 7, "Physics" },
                    { 176, 2, 8, "Math" },
                    { 177, 3, 1, "Math" },
                    { 178, 3, 2, "Math" },
                    { 179, 3, 3, "PE" },
                    { 180, 3, 4, "Geography" },
                    { 181, 3, 5, "Polish" },
                    { 182, 3, 6, "Chemistry" },
                    { 183, 3, 7, "Geography" },
                    { 184, 3, 8, "Polish" },
                    { 185, 4, 1, "Physics" },
                    { 186, 4, 2, "History" },
                    { 187, 4, 3, "PE" },
                    { 188, 4, 4, "Physics" },
                    { 189, 4, 5, "Chemistry" },
                    { 190, 4, 6, "Physics" },
                    { 191, 4, 7, "History" },
                    { 192, 4, 8, "PE" },
                    { 193, 5, 1, "Math" },
                    { 194, 5, 2, "History" },
                    { 195, 5, 3, "Geography" },
                    { 196, 5, 4, "Geography" },
                    { 197, 5, 5, "English" },
                    { 198, 5, 6, "Geography" },
                    { 199, 5, 7, "History" },
                    { 200, 5, 8, "Physics" },
                    { 201, 1, 1, "English" },
                    { 202, 1, 2, "Polish" },
                    { 203, 1, 3, "PE" },
                    { 204, 1, 4, "Physics" },
                    { 205, 1, 5, "Geography" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 206, 1, 6, "Geography" },
                    { 207, 1, 7, "PE" },
                    { 208, 1, 8, "Geography" },
                    { 209, 2, 1, "Chemistry" },
                    { 210, 2, 2, "Math" },
                    { 211, 2, 3, "History" },
                    { 212, 2, 4, "Polish" },
                    { 213, 2, 5, "History" },
                    { 214, 2, 6, "Physics" },
                    { 215, 2, 7, "Geography" },
                    { 216, 2, 8, "Geography" },
                    { 217, 3, 1, "History" },
                    { 218, 3, 2, "Math" },
                    { 219, 3, 3, "Physics" },
                    { 220, 3, 4, "Polish" },
                    { 221, 3, 5, "Physics" },
                    { 222, 3, 6, "PE" },
                    { 223, 3, 7, "Geography" },
                    { 224, 3, 8, "Polish" },
                    { 225, 4, 1, "PE" },
                    { 226, 4, 2, "Geography" },
                    { 227, 4, 3, "English" },
                    { 228, 4, 4, "PE" },
                    { 229, 4, 5, "Physics" },
                    { 230, 4, 6, "History" },
                    { 231, 4, 7, "Math" },
                    { 232, 4, 8, "Polish" },
                    { 233, 5, 1, "Math" },
                    { 234, 5, 2, "Physics" },
                    { 235, 5, 3, "Chemistry" },
                    { 236, 5, 4, "Physics" },
                    { 237, 5, 5, "PE" },
                    { 238, 5, 6, "Physics" },
                    { 239, 5, 7, "Chemistry" },
                    { 240, 5, 8, "Math" },
                    { 241, 1, 1, "Polish" },
                    { 242, 1, 2, "PE" },
                    { 243, 1, 3, "Physics" },
                    { 244, 1, 4, "Chemistry" },
                    { 245, 1, 5, "Geography" },
                    { 246, 1, 6, "Polish" },
                    { 247, 1, 7, "Math" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 248, 1, 8, "Geography" },
                    { 249, 2, 1, "PE" },
                    { 250, 2, 2, "Polish" },
                    { 251, 2, 3, "Polish" },
                    { 252, 2, 4, "Chemistry" },
                    { 253, 2, 5, "PE" },
                    { 254, 2, 6, "Chemistry" },
                    { 255, 2, 7, "Math" },
                    { 256, 2, 8, "Chemistry" },
                    { 257, 3, 1, "PE" },
                    { 258, 3, 2, "PE" },
                    { 259, 3, 3, "Physics" },
                    { 260, 3, 4, "English" },
                    { 261, 3, 5, "PE" },
                    { 262, 3, 6, "Polish" },
                    { 263, 3, 7, "Chemistry" },
                    { 264, 3, 8, "Physics" },
                    { 265, 4, 1, "History" },
                    { 266, 4, 2, "History" },
                    { 267, 4, 3, "PE" },
                    { 268, 4, 4, "English" },
                    { 269, 4, 5, "PE" },
                    { 270, 4, 6, "English" },
                    { 271, 4, 7, "History" },
                    { 272, 4, 8, "History" },
                    { 273, 5, 1, "History" },
                    { 274, 5, 2, "English" },
                    { 275, 5, 3, "Polish" },
                    { 276, 5, 4, "English" },
                    { 277, 5, 5, "Geography" },
                    { 278, 5, 6, "English" },
                    { 279, 5, 7, "Chemistry" },
                    { 280, 5, 8, "Polish" },
                    { 281, 1, 1, "Physics" },
                    { 282, 1, 2, "PE" },
                    { 283, 1, 3, "Physics" },
                    { 284, 1, 4, "Physics" },
                    { 285, 1, 5, "English" },
                    { 286, 1, 6, "Math" },
                    { 287, 1, 7, "Geography" },
                    { 288, 1, 8, "Chemistry" },
                    { 289, 2, 1, "Polish" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 290, 2, 2, "Chemistry" },
                    { 291, 2, 3, "Polish" },
                    { 292, 2, 4, "Math" },
                    { 293, 2, 5, "Chemistry" },
                    { 294, 2, 6, "Polish" },
                    { 295, 2, 7, "History" },
                    { 296, 2, 8, "Math" },
                    { 297, 3, 1, "PE" },
                    { 298, 3, 2, "Physics" },
                    { 299, 3, 3, "Math" },
                    { 300, 3, 4, "Geography" },
                    { 301, 3, 5, "Physics" },
                    { 302, 3, 6, "Geography" },
                    { 303, 3, 7, "Geography" },
                    { 304, 3, 8, "PE" },
                    { 305, 4, 1, "Geography" },
                    { 306, 4, 2, "History" },
                    { 307, 4, 3, "English" },
                    { 308, 4, 4, "PE" },
                    { 309, 4, 5, "Geography" },
                    { 310, 4, 6, "Chemistry" },
                    { 311, 4, 7, "Geography" },
                    { 312, 4, 8, "PE" },
                    { 313, 5, 1, "PE" },
                    { 314, 5, 2, "English" },
                    { 315, 5, 3, "Polish" },
                    { 316, 5, 4, "Geography" },
                    { 317, 5, 5, "English" },
                    { 318, 5, 6, "Polish" },
                    { 319, 5, 7, "History" },
                    { 320, 5, 8, "Physics" },
                    { 321, 1, 1, "Math" },
                    { 322, 1, 2, "Math" },
                    { 323, 1, 3, "Geography" },
                    { 324, 1, 4, "Physics" },
                    { 325, 1, 5, "Polish" },
                    { 326, 1, 6, "Polish" },
                    { 327, 1, 7, "English" },
                    { 328, 1, 8, "PE" },
                    { 329, 2, 1, "English" },
                    { 330, 2, 2, "Chemistry" },
                    { 331, 2, 3, "History" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 332, 2, 4, "Physics" },
                    { 333, 2, 5, "English" },
                    { 334, 2, 6, "History" },
                    { 335, 2, 7, "PE" },
                    { 336, 2, 8, "Math" },
                    { 337, 3, 1, "PE" },
                    { 338, 3, 2, "History" },
                    { 339, 3, 3, "Physics" },
                    { 340, 3, 4, "English" },
                    { 341, 3, 5, "Geography" },
                    { 342, 3, 6, "History" },
                    { 343, 3, 7, "Math" },
                    { 344, 3, 8, "Polish" },
                    { 345, 4, 1, "Physics" },
                    { 346, 4, 2, "History" },
                    { 347, 4, 3, "Math" },
                    { 348, 4, 4, "History" },
                    { 349, 4, 5, "Math" },
                    { 350, 4, 6, "Geography" },
                    { 351, 4, 7, "Physics" },
                    { 352, 4, 8, "History" },
                    { 353, 5, 1, "PE" },
                    { 354, 5, 2, "PE" },
                    { 355, 5, 3, "PE" },
                    { 356, 5, 4, "Geography" },
                    { 357, 5, 5, "Physics" },
                    { 358, 5, 6, "History" },
                    { 359, 5, 7, "PE" },
                    { 360, 5, 8, "Geography" },
                    { 361, 1, 1, "English" },
                    { 362, 1, 2, "Chemistry" },
                    { 363, 1, 3, "Physics" },
                    { 364, 1, 4, "Math" },
                    { 365, 1, 5, "PE" },
                    { 366, 1, 6, "Geography" },
                    { 367, 1, 7, "History" },
                    { 368, 1, 8, "Math" },
                    { 369, 2, 1, "Polish" },
                    { 370, 2, 2, "Polish" },
                    { 371, 2, 3, "Polish" },
                    { 372, 2, 4, "English" },
                    { 373, 2, 5, "Geography" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 374, 2, 6, "PE" },
                    { 375, 2, 7, "PE" },
                    { 376, 2, 8, "Geography" },
                    { 377, 3, 1, "English" },
                    { 378, 3, 2, "Geography" },
                    { 379, 3, 3, "Chemistry" },
                    { 380, 3, 4, "English" },
                    { 381, 3, 5, "English" },
                    { 382, 3, 6, "Chemistry" },
                    { 383, 3, 7, "Geography" },
                    { 384, 3, 8, "Geography" },
                    { 385, 4, 1, "Chemistry" },
                    { 386, 4, 2, "Chemistry" },
                    { 387, 4, 3, "Math" },
                    { 388, 4, 4, "Physics" },
                    { 389, 4, 5, "PE" },
                    { 390, 4, 6, "English" },
                    { 391, 4, 7, "Physics" },
                    { 392, 4, 8, "Polish" },
                    { 393, 5, 1, "Physics" },
                    { 394, 5, 2, "Physics" },
                    { 395, 5, 3, "English" },
                    { 396, 5, 4, "Physics" },
                    { 397, 5, 5, "Math" },
                    { 398, 5, 6, "Polish" },
                    { 399, 5, 7, "English" },
                    { 400, 5, 8, "PE" }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "Present" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 18, 1, 29, 17, 765, DateTimeKind.Local).AddTicks(2295), true },
                    { 2, new DateTime(2022, 7, 17, 15, 21, 39, 435, DateTimeKind.Local).AddTicks(6210), false },
                    { 3, new DateTime(2022, 7, 17, 6, 16, 27, 572, DateTimeKind.Local).AddTicks(3727), true },
                    { 4, new DateTime(2022, 7, 17, 10, 40, 14, 495, DateTimeKind.Local).AddTicks(3138), true },
                    { 5, new DateTime(2022, 7, 17, 5, 0, 8, 866, DateTimeKind.Local).AddTicks(1794), false },
                    { 6, new DateTime(2022, 7, 17, 11, 17, 30, 601, DateTimeKind.Local).AddTicks(5561), true },
                    { 7, new DateTime(2022, 7, 17, 12, 59, 49, 262, DateTimeKind.Local).AddTicks(6509), false },
                    { 8, new DateTime(2022, 7, 18, 0, 43, 32, 378, DateTimeKind.Local).AddTicks(1682), true },
                    { 9, new DateTime(2022, 7, 17, 21, 45, 12, 835, DateTimeKind.Local).AddTicks(9242), false },
                    { 10, new DateTime(2022, 7, 17, 14, 12, 17, 874, DateTimeKind.Local).AddTicks(1822), true },
                    { 11, new DateTime(2022, 7, 17, 19, 22, 16, 125, DateTimeKind.Local).AddTicks(175), true },
                    { 12, new DateTime(2022, 7, 17, 13, 20, 21, 847, DateTimeKind.Local).AddTicks(9515), true },
                    { 13, new DateTime(2022, 7, 17, 18, 14, 31, 457, DateTimeKind.Local).AddTicks(8331), false },
                    { 14, new DateTime(2022, 7, 17, 21, 54, 11, 822, DateTimeKind.Local).AddTicks(7368), true },
                    { 15, new DateTime(2022, 7, 17, 8, 1, 30, 784, DateTimeKind.Local).AddTicks(913), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "Present" },
                values: new object[,]
                {
                    { 16, new DateTime(2022, 7, 17, 18, 11, 48, 283, DateTimeKind.Local).AddTicks(3602), true },
                    { 17, new DateTime(2022, 7, 17, 21, 8, 5, 735, DateTimeKind.Local).AddTicks(1879), true },
                    { 18, new DateTime(2022, 7, 18, 0, 29, 8, 24, DateTimeKind.Local).AddTicks(8666), true },
                    { 19, new DateTime(2022, 7, 17, 2, 52, 20, 814, DateTimeKind.Local).AddTicks(4139), false },
                    { 20, new DateTime(2022, 7, 17, 13, 7, 19, 518, DateTimeKind.Local).AddTicks(9056), true },
                    { 21, new DateTime(2022, 7, 17, 9, 29, 7, 422, DateTimeKind.Local).AddTicks(6161), false },
                    { 22, new DateTime(2022, 7, 17, 7, 25, 42, 527, DateTimeKind.Local).AddTicks(6106), true },
                    { 23, new DateTime(2022, 7, 17, 4, 41, 39, 721, DateTimeKind.Local).AddTicks(1833), false },
                    { 24, new DateTime(2022, 7, 17, 8, 21, 16, 182, DateTimeKind.Local).AddTicks(2526), false },
                    { 25, new DateTime(2022, 7, 17, 9, 46, 14, 388, DateTimeKind.Local).AddTicks(8237), false },
                    { 26, new DateTime(2022, 7, 17, 20, 42, 39, 579, DateTimeKind.Local).AddTicks(4505), false },
                    { 27, new DateTime(2022, 7, 17, 12, 24, 14, 548, DateTimeKind.Local).AddTicks(584), true },
                    { 28, new DateTime(2022, 7, 17, 14, 49, 17, 756, DateTimeKind.Local).AddTicks(8775), true },
                    { 29, new DateTime(2022, 7, 17, 2, 15, 15, 481, DateTimeKind.Local).AddTicks(8327), true },
                    { 30, new DateTime(2022, 7, 17, 3, 46, 10, 442, DateTimeKind.Local).AddTicks(1018), true },
                    { 31, new DateTime(2022, 7, 17, 11, 55, 43, 106, DateTimeKind.Local).AddTicks(1170), false },
                    { 32, new DateTime(2022, 7, 17, 5, 4, 34, 463, DateTimeKind.Local).AddTicks(7976), false },
                    { 33, new DateTime(2022, 7, 17, 7, 27, 23, 111, DateTimeKind.Local).AddTicks(6577), false },
                    { 34, new DateTime(2022, 7, 17, 9, 24, 11, 5, DateTimeKind.Local).AddTicks(5069), false },
                    { 35, new DateTime(2022, 7, 17, 2, 20, 14, 870, DateTimeKind.Local).AddTicks(8897), true },
                    { 36, new DateTime(2022, 7, 17, 18, 25, 7, 882, DateTimeKind.Local).AddTicks(2079), false },
                    { 37, new DateTime(2022, 7, 17, 9, 59, 52, 843, DateTimeKind.Local).AddTicks(5271), false },
                    { 38, new DateTime(2022, 7, 17, 17, 37, 48, 852, DateTimeKind.Local).AddTicks(215), false },
                    { 39, new DateTime(2022, 7, 17, 8, 1, 25, 458, DateTimeKind.Local).AddTicks(6947), true },
                    { 40, new DateTime(2022, 7, 17, 15, 3, 31, 238, DateTimeKind.Local).AddTicks(887), true },
                    { 41, new DateTime(2022, 7, 17, 8, 26, 12, 18, DateTimeKind.Local).AddTicks(7335), true },
                    { 42, new DateTime(2022, 7, 18, 1, 38, 10, 893, DateTimeKind.Local).AddTicks(2355), false },
                    { 43, new DateTime(2022, 7, 17, 23, 58, 19, 385, DateTimeKind.Local).AddTicks(8818), false },
                    { 44, new DateTime(2022, 7, 17, 21, 51, 24, 591, DateTimeKind.Local).AddTicks(3232), false },
                    { 45, new DateTime(2022, 7, 17, 22, 41, 18, 521, DateTimeKind.Local).AddTicks(6527), true },
                    { 46, new DateTime(2022, 7, 17, 4, 35, 26, 572, DateTimeKind.Local).AddTicks(1732), false },
                    { 47, new DateTime(2022, 7, 17, 5, 15, 13, 430, DateTimeKind.Local).AddTicks(9432), true },
                    { 48, new DateTime(2022, 7, 17, 7, 2, 9, 335, DateTimeKind.Local).AddTicks(6068), false },
                    { 49, new DateTime(2022, 7, 17, 12, 15, 14, 797, DateTimeKind.Local).AddTicks(3784), false }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Sara75@yahoo.com", "Sara", "Kling", "1-216-347-3423" },
                    { 2, "Nicolas_Flatley@hotmail.com", "Nicolas", "Flatley", "747-918-1775" },
                    { 3, "Johnathan_Blanda@gmail.com", "Johnathan", "Blanda", "1-677-555-8357 x85850" },
                    { 4, "Sergio24@yahoo.com", "Sergio", "Connelly", "(449) 929-2747 x187" },
                    { 5, "Jessie_Littel10@yahoo.com", "Jessie", "Littel", "1-639-431-4273 x703" },
                    { 6, "Bernadette.Kilback64@gmail.com", "Bernadette", "Kilback", "975.929.8401" },
                    { 7, "Alicia_Cormier@yahoo.com", "Alicia", "Cormier", "1-561-732-0016 x21064" },
                    { 8, "Clifton88@yahoo.com", "Clifton", "Rosenbaum", "318.394.2344 x33899" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 9, "Ana.Murray@gmail.com", "Ana", "Murray", "710.389.5354" },
                    { 10, "Marion68@yahoo.com", "Marion", "Smith", "626-447-9177 x20364" },
                    { 11, "Esther_Gorczany@gmail.com", "Esther", "Gorczany", "(692) 715-3825 x108" },
                    { 12, "Vanessa.Carter@hotmail.com", "Vanessa", "Carter", "713-665-8144 x333" },
                    { 13, "Stacy_Runolfsdottir@yahoo.com", "Stacy", "Runolfsdottir", "386-855-6640" },
                    { 14, "Rosie_Terry@yahoo.com", "Rosie", "Terry", "(486) 828-0482 x130" },
                    { 15, "Rebecca.Purdy17@gmail.com", "Rebecca", "Purdy", "1-913-688-9310 x4901" },
                    { 16, "Domingo94@gmail.com", "Domingo", "Jacobs", "(597) 999-9983" },
                    { 17, "Lloyd_Renner@yahoo.com", "Lloyd", "Renner", "799-668-8275 x82205" },
                    { 18, "Lena.Feeney84@hotmail.com", "Lena", "Feeney", "791.901.3504 x801" },
                    { 19, "Jessie.Ratke41@hotmail.com", "Jessie", "Ratke", "266.476.9322" },
                    { 20, "Jack.Huel87@yahoo.com", "Jack", "Huel", "1-477-525-2310" },
                    { 21, "Kyle55@yahoo.com", "Kyle", "Walker", "(640) 754-8598 x56840" },
                    { 22, "Evelyn.Koelpin37@gmail.com", "Evelyn", "Koelpin", "703.335.9888 x025" },
                    { 23, "Kristin_Gutkowski47@hotmail.com", "Kristin", "Gutkowski", "287-466-1315" },
                    { 24, "Jack.Hirthe@yahoo.com", "Jack", "Hirthe", "1-963-620-2022" },
                    { 25, "Bruce.Wisozk37@hotmail.com", "Bruce", "Wisozk", "566-602-1924 x089" },
                    { 26, "Lori.Crist@yahoo.com", "Lori", "Crist", "625-701-6527 x3450" },
                    { 27, "Edmund.Klocko57@gmail.com", "Edmund", "Klocko", "225-923-4809 x90674" },
                    { 28, "William36@hotmail.com", "William", "Will", "1-773-431-8469" },
                    { 29, "Cheryl.Bartoletti46@hotmail.com", "Cheryl", "Bartoletti", "(631) 490-5051" },
                    { 30, "Alberta.Dooley@yahoo.com", "Alberta", "Dooley", "(858) 958-2759" },
                    { 31, "Harry_McKenzie14@gmail.com", "Harry", "McKenzie", "1-778-431-1865" },
                    { 32, "Ashley.Wolff8@hotmail.com", "Ashley", "Wolff", "422-335-0578" },
                    { 33, "Salvatore.Sanford@yahoo.com", "Salvatore", "Sanford", "(575) 280-2517 x412" },
                    { 34, "Ricardo_Rempel87@hotmail.com", "Ricardo", "Rempel", "(853) 453-1324 x14644" },
                    { 35, "Kirk19@yahoo.com", "Kirk", "Schulist", "1-875-390-8165 x1768" },
                    { 36, "Connie.Dooley@gmail.com", "Connie", "Dooley", "449.351.6689 x7611" },
                    { 37, "Dan44@gmail.com", "Dan", "Skiles", "1-689-432-0411 x7626" },
                    { 38, "Opal.Heaney@hotmail.com", "Opal", "Heaney", "(900) 495-1149" },
                    { 39, "Tammy21@yahoo.com", "Tammy", "Kerluke", "350-573-8690 x118" },
                    { 40, "Doreen8@gmail.com", "Doreen", "Koss", "722.741.5393 x179" },
                    { 41, "Lee.Gulgowski@yahoo.com", "Lee", "Gulgowski", "326.869.8441 x16645" },
                    { 42, "Lowell_Schuster90@yahoo.com", "Lowell", "Schuster", "656.445.7744 x33801" },
                    { 43, "Agnes68@hotmail.com", "Agnes", "Friesen", "1-460-382-9914" },
                    { 44, "Rudolph_Monahan10@yahoo.com", "Rudolph", "Monahan", "352-580-0338 x470" },
                    { 45, "Tammy42@hotmail.com", "Tammy", "Keeling", "270-993-4783 x900" },
                    { 46, "Chad_Daugherty@yahoo.com", "Chad", "Daugherty", "890-581-8065" },
                    { 47, "Nick59@gmail.com", "Nick", "Champlin", "(494) 517-1493" },
                    { 48, "Leslie_Dibbert@yahoo.com", "Leslie", "Dibbert", "606-636-8098 x273" },
                    { 49, "Micheal.Weissnat30@gmail.com", "Micheal", "Weissnat", "230-487-2950 x660" },
                    { 50, "Cecilia_Baumbach69@hotmail.com", "Cecilia", "Baumbach", "286-201-2433 x017" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 51, "Joanna_Gislason@yahoo.com", "Joanna", "Gislason", "(593) 538-5684" },
                    { 52, "Nettie17@hotmail.com", "Nettie", "Cassin", "1-621-690-1626 x2935" },
                    { 53, "Devin.Macejkovic@gmail.com", "Devin", "Macejkovic", "330-866-9495 x32306" },
                    { 54, "Suzanne.Stiedemann@hotmail.com", "Suzanne", "Stiedemann", "401-492-2265" },
                    { 55, "Alfred_Wyman40@gmail.com", "Alfred", "Wyman", "279-876-0573 x544" },
                    { 56, "Peter94@gmail.com", "Peter", "Koepp", "427-214-9735 x64948" },
                    { 57, "Karla.Gusikowski@gmail.com", "Karla", "Gusikowski", "642.969.7512 x675" },
                    { 58, "Sidney.Hoeger@gmail.com", "Sidney", "Hoeger", "1-985-670-8297" },
                    { 59, "Dominick.Rice45@yahoo.com", "Dominick", "Rice", "1-477-727-2882 x1021" },
                    { 60, "Amy.Hoppe@yahoo.com", "Amy", "Hoppe", "577.715.7954 x50283" },
                    { 61, "Terence62@gmail.com", "Terence", "Schowalter", "1-779-849-0932" },
                    { 62, "Frances_Kling66@hotmail.com", "Frances", "Kling", "983.813.0893 x299" },
                    { 63, "Arthur_Cremin@yahoo.com", "Arthur", "Cremin", "253-591-9609" },
                    { 64, "Jay_Grant84@yahoo.com", "Jay", "Grant", "739-876-2793" },
                    { 65, "Blake.Thompson@yahoo.com", "Blake", "Thompson", "1-492-418-9124 x229" },
                    { 66, "Opal82@yahoo.com", "Opal", "Schmidt", "1-342-669-6791" },
                    { 67, "Jose95@hotmail.com", "Jose", "Marks", "(612) 301-2835 x755" },
                    { 68, "Justin_Cormier29@yahoo.com", "Justin", "Cormier", "514-655-8927 x314" },
                    { 69, "Jonathan.Grimes64@hotmail.com", "Jonathan", "Grimes", "200-585-6815 x3149" },
                    { 70, "Nadine23@yahoo.com", "Nadine", "Fritsch", "741-924-0386 x30254" },
                    { 71, "Rudolph.Champlin@yahoo.com", "Rudolph", "Champlin", "(825) 836-5316 x324" },
                    { 72, "Lila.Herman@yahoo.com", "Lila", "Herman", "421.437.5101" },
                    { 73, "Samantha_Jakubowski@yahoo.com", "Samantha", "Jakubowski", "570.782.8864 x905" },
                    { 74, "Angelica.Harvey@yahoo.com", "Angelica", "Harvey", "797-709-2385 x7856" },
                    { 75, "Maryann.Jenkins98@yahoo.com", "Maryann", "Jenkins", "1-501-524-3021" },
                    { 76, "Ian88@yahoo.com", "Ian", "Bartell", "1-746-385-7985 x0295" },
                    { 77, "Cory.Anderson62@gmail.com", "Cory", "Anderson", "1-632-575-2471 x292" },
                    { 78, "Sara.Hane42@yahoo.com", "Sara", "Hane", "521-935-3934" },
                    { 79, "Al57@gmail.com", "Al", "Auer", "313.531.7261" },
                    { 80, "Benny.Greenfelder@hotmail.com", "Benny", "Greenfelder", "610.603.7166 x768" },
                    { 81, "Ramona.Terry7@hotmail.com", "Ramona", "Terry", "(818) 472-6852" },
                    { 82, "Tony.Schneider88@hotmail.com", "Tony", "Schneider", "671.929.2560 x568" },
                    { 83, "Mathew_Runolfsdottir23@yahoo.com", "Mathew", "Runolfsdottir", "(864) 606-3756 x55647" },
                    { 84, "Shaun.Krajcik@gmail.com", "Shaun", "Krajcik", "1-871-660-4277 x6100" },
                    { 85, "Pamela.Jacobs10@hotmail.com", "Pamela", "Jacobs", "344-454-7502 x98307" },
                    { 86, "Tommy_Heaney78@yahoo.com", "Tommy", "Heaney", "909.604.0844" },
                    { 87, "Nelson.Ernser@yahoo.com", "Nelson", "Ernser", "1-390-767-2689 x5738" },
                    { 88, "Clint31@hotmail.com", "Clint", "Runte", "(927) 660-1276" },
                    { 89, "Allan_Thompson89@hotmail.com", "Allan", "Thompson", "1-614-946-9229 x5698" },
                    { 90, "Gina_Daugherty@hotmail.com", "Gina", "Daugherty", "(616) 768-9503 x62089" },
                    { 91, "Eric.Weber@hotmail.com", "Eric", "Weber", "1-274-717-8204 x72884" },
                    { 92, "Leonard_Feest@hotmail.com", "Leonard", "Feest", "423.390.6074" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 93, "Warren53@hotmail.com", "Warren", "Cole", "310-587-9801 x406" },
                    { 94, "Sue.Pfannerstill@yahoo.com", "Sue", "Pfannerstill", "1-881-595-1099" },
                    { 95, "Angelo.Doyle64@gmail.com", "Angelo", "Doyle", "(210) 727-8560" },
                    { 96, "Abraham_Bashirian@hotmail.com", "Abraham", "Bashirian", "730-845-6366" },
                    { 97, "Alma_Shields@hotmail.com", "Alma", "Shields", "950-814-0052" },
                    { 98, "Ana18@gmail.com", "Ana", "Hickle", "1-311-324-7537 x21481" },
                    { 99, "Wallace7@hotmail.com", "Wallace", "Mitchell", "1-866-606-8430 x87790" },
                    { 100, "Saul57@yahoo.com", "Saul", "Wilderman", "1-239-827-3583 x5058" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("036c372b-e002-4162-9602-132f03ea784e"), null, null, "Audrey_Leannon21@gmail.com", null, null, "", null, null },
                    { new Guid("056f440c-c986-40b0-9357-4a4d40e498a4"), null, null, "Douglas.Lindgren67@hotmail.com", null, null, "", null, null },
                    { new Guid("06906685-3ce5-4100-b691-881c8a0291ee"), null, null, "Stella_Schmitt@yahoo.com", null, null, "", null, null },
                    { new Guid("08ce2ac6-710d-4a7d-8dc9-65d487f77cdf"), null, null, "Eva_Stark@yahoo.com", null, null, "", null, null },
                    { new Guid("0b85ee8d-d395-44c8-8195-f77188a0b1e8"), null, null, "Chad.Kuhn@hotmail.com", null, null, "", null, null },
                    { new Guid("0ded0e2a-f77e-4570-a909-9e8cd5d71ea7"), null, null, "Joyce_Prosacco52@yahoo.com", null, null, "", null, null },
                    { new Guid("0e12725f-878e-492f-b31c-64c90efcb6d3"), null, null, "Evelyn3@gmail.com", null, null, "", null, null },
                    { new Guid("13ec9f61-4837-4af4-ad0e-0a32b4f7f2aa"), null, null, "Homer.Lynch@gmail.com", null, null, "", null, null },
                    { new Guid("15b24ee0-0762-4815-bc4c-f22adc35964a"), null, null, "Shaun_OConner39@yahoo.com", null, null, "", null, null },
                    { new Guid("1832a4ce-2fb4-4982-a3cb-1ecc3463f3c3"), null, null, "Lyle.Anderson90@hotmail.com", null, null, "", null, null },
                    { new Guid("1ba9b1ff-e99e-453e-9f85-fa126ccffcd5"), null, null, "Richard.Walker@hotmail.com", null, null, "", null, null },
                    { new Guid("1be54727-a727-4a9d-bb56-95a1ef613b80"), null, null, "Georgia91@gmail.com", null, null, "", null, null },
                    { new Guid("1d2bad30-f734-4d24-a7bc-5cef29864b05"), null, null, "Terrell17@yahoo.com", null, null, "", null, null },
                    { new Guid("1ea652a3-9184-44e7-a2a8-2f186ad13ad6"), null, null, "Carlton_OConner@gmail.com", null, null, "", null, null },
                    { new Guid("23909c57-1326-4fed-8c93-de20dfcdac3e"), null, null, "Lynne.Maggio@yahoo.com", null, null, "", null, null },
                    { new Guid("2529b148-5aa3-483c-8490-da47137efffe"), null, null, "Elbert32@hotmail.com", null, null, "", null, null },
                    { new Guid("263f7539-3b39-4f81-965a-2897a8f0a62e"), null, null, "Joan.Green65@hotmail.com", null, null, "", null, null },
                    { new Guid("2698821e-a146-43be-b63e-e80b4167b9e4"), null, null, "Randolph15@yahoo.com", null, null, "", null, null },
                    { new Guid("26d37d90-eac9-4dd2-9df2-ee1c7aa65c0b"), null, null, "Bertha75@hotmail.com", null, null, "", null, null },
                    { new Guid("28a86d7e-55f8-4675-9bee-ac8a5e4e28f7"), null, null, "Molly63@gmail.com", null, null, "", null, null },
                    { new Guid("2ab7d0e0-0a38-4774-b0f9-78d31539509d"), null, null, "Lillian.Johns76@yahoo.com", null, null, "", null, null },
                    { new Guid("2d073fad-47d3-4519-bc69-b5a56bc8c5d7"), null, null, "Jordan.Schaden94@gmail.com", null, null, "", null, null },
                    { new Guid("2f0e85dd-f480-4562-94cc-ab45510c55e5"), null, null, "Muriel.Abernathy@hotmail.com", null, null, "", null, null },
                    { new Guid("30dfa9d9-e439-4cd3-bc56-da0f5d8079f8"), null, null, "Dana_Brekke75@yahoo.com", null, null, "", null, null },
                    { new Guid("3169052d-1fa7-479b-a35a-0590d32c1435"), null, null, "Clifton12@gmail.com", null, null, "", null, null },
                    { new Guid("32ec4e7d-671a-42e2-8bed-91adf7a6e9ab"), null, null, "Ira_Emard5@yahoo.com", null, null, "", null, null },
                    { new Guid("347639f1-711a-4bf9-9e2e-0810945f6cb6"), null, null, "Bertha29@hotmail.com", null, null, "", null, null },
                    { new Guid("355d6f15-0fb5-4440-ac69-ea4649150413"), null, null, "Eric.Roob32@yahoo.com", null, null, "", null, null },
                    { new Guid("380c2a9a-5f3e-4a30-b33d-b6863319f28f"), null, null, "Trevor.Heathcote@hotmail.com", null, null, "", null, null },
                    { new Guid("38e03e23-2c4c-4391-b693-d80ae7dd2eff"), null, null, "Leonard.Wyman76@hotmail.com", null, null, "", null, null },
                    { new Guid("3e930951-79e4-4958-b24d-2276c3381397"), null, null, "Lydia87@hotmail.com", null, null, "", null, null },
                    { new Guid("478c0c94-ddc7-4f5e-8ec7-0822f89de52e"), null, null, "Marcella_Kris@hotmail.com", null, null, "", null, null },
                    { new Guid("4aa9ff06-8a75-46cf-ab7c-2339d2061415"), null, null, "Nicholas72@yahoo.com", null, null, "", null, null },
                    { new Guid("4ef8373d-ec91-426c-be97-d4eac57eced5"), null, null, "Roderick_Nienow35@yahoo.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("509a1833-0cb2-44fd-97f4-7b40699818a5"), null, null, "Trevor29@yahoo.com", null, null, "", null, null },
                    { new Guid("50e60685-7500-4e6e-bc68-4bee9ea0695e"), null, null, "Antonio91@hotmail.com", null, null, "", null, null },
                    { new Guid("56a6f72c-ce56-45f2-a7e1-2d3b5fc738cd"), null, null, "Marcia.Oberbrunner85@yahoo.com", null, null, "", null, null },
                    { new Guid("56a753bb-d56c-44e7-8513-5e3eb14b5da5"), null, null, "Boyd_Bernhard@yahoo.com", null, null, "", null, null },
                    { new Guid("5cd28d24-e8e5-477e-a4c2-02dc3fe2bea8"), null, null, "Essie71@gmail.com", null, null, "", null, null },
                    { new Guid("5cdeb854-329a-496a-bd74-b11207696cba"), null, null, "Julius.Hegmann33@yahoo.com", null, null, "", null, null },
                    { new Guid("5fee716a-fbcb-40bc-be6d-edd662bf5103"), null, null, "Priscilla41@gmail.com", null, null, "", null, null },
                    { new Guid("679a7e91-1103-4f43-bbc1-46c1802cce1b"), null, null, "Leo.Rogahn59@yahoo.com", null, null, "", null, null },
                    { new Guid("6935011d-9810-449b-842e-bde860e9a6cc"), null, null, "Preston.Runte46@yahoo.com", null, null, "", null, null },
                    { new Guid("697abd26-64a5-4d52-a037-8667f7263a7b"), null, null, "Francisco47@hotmail.com", null, null, "", null, null },
                    { new Guid("6cb5634f-d465-4e0d-9546-27b834aa4755"), null, null, "Wilson.Brown@yahoo.com", null, null, "", null, null },
                    { new Guid("6f69b66a-adbd-46c2-bea0-7a441eeb5f0c"), null, null, "Arthur_Mills@hotmail.com", null, null, "", null, null },
                    { new Guid("70e2b282-fcfa-4f9c-b8fd-76654df0d06f"), null, null, "George3@yahoo.com", null, null, "", null, null },
                    { new Guid("791b169d-63df-42ed-87d8-364958449785"), null, null, "Irvin.Yundt@hotmail.com", null, null, "", null, null },
                    { new Guid("7a99d1ee-d5d3-47aa-8d1d-b0058d3fc042"), null, null, "Natalie_Wilderman60@hotmail.com", null, null, "", null, null },
                    { new Guid("7db407d6-faaf-4428-ae32-010d6b128150"), null, null, "Aaron10@gmail.com", null, null, "", null, null },
                    { new Guid("7e0c710f-1408-4f67-8ad0-df646d97f4ad"), null, null, "Mable.Bashirian@gmail.com", null, null, "", null, null },
                    { new Guid("82714640-3aba-44a2-88e8-bf9081f2815a"), null, null, "Toni.Herzog@yahoo.com", null, null, "", null, null },
                    { new Guid("83651cc1-8b2b-4c11-9403-e6f853252ed6"), null, null, "Allan_Hamill@hotmail.com", null, null, "", null, null },
                    { new Guid("84f27634-a5e2-4ac5-ad75-63fe63aeddd6"), null, null, "Muriel.Hahn36@gmail.com", null, null, "", null, null },
                    { new Guid("85e2ad46-c186-4457-8aaa-720f52b0f615"), null, null, "Kathleen92@hotmail.com", null, null, "", null, null },
                    { new Guid("85fe2e66-f975-4066-afe0-83c72ad57732"), null, null, "Mack.Marks83@hotmail.com", null, null, "", null, null },
                    { new Guid("932733f9-fa8b-49a0-9d44-4ac13e9df18d"), null, null, "Kirk34@yahoo.com", null, null, "", null, null },
                    { new Guid("96382db9-7edb-4a8a-8281-e25ae4cc48b7"), null, null, "Grace.Satterfield21@hotmail.com", null, null, "", null, null },
                    { new Guid("967621f4-4446-404b-a20e-93c42611c3ff"), null, null, "Rachel.Gorczany@gmail.com", null, null, "", null, null },
                    { new Guid("9680bb13-3c47-417c-b639-4bae141f6254"), null, null, "Marta46@hotmail.com", null, null, "", null, null },
                    { new Guid("9b22fb29-3ccf-4225-b98d-7d1a00bc3299"), null, null, "Bradford10@gmail.com", null, null, "", null, null },
                    { new Guid("9cd1455c-311f-4b61-88a1-4260e4953339"), null, null, "Elsie55@gmail.com", null, null, "", null, null },
                    { new Guid("9cdcc68c-e423-4d9c-85c1-402b50564a6e"), null, null, "Robyn.Sawayn@yahoo.com", null, null, "", null, null },
                    { new Guid("9d23b41f-7dea-4499-a3c4-67987a77fe63"), null, null, "Shane.Schultz64@yahoo.com", null, null, "", null, null },
                    { new Guid("9e1d173c-33ca-4d61-887a-6d9e28317336"), null, null, "Sadie_Davis55@hotmail.com", null, null, "", null, null },
                    { new Guid("a356fd32-001d-4762-9f48-7deb3bde329b"), null, null, "Gertrude_Schuster@hotmail.com", null, null, "", null, null },
                    { new Guid("a41c6708-77e6-40c9-816a-7c0f52284c50"), null, null, "Myrtle73@yahoo.com", null, null, "", null, null },
                    { new Guid("a791a00a-47f7-43ee-951a-17e1972d9734"), null, null, "Dewey_Jacobi86@yahoo.com", null, null, "", null, null },
                    { new Guid("b0827f4a-7e02-422b-bf85-e47b692fdf60"), null, null, "Bertha65@hotmail.com", null, null, "", null, null },
                    { new Guid("b0cfd2f6-71ea-4b98-9cdd-5181ff2b300d"), null, null, "Irving59@gmail.com", null, null, "", null, null },
                    { new Guid("b2f160c8-1b0d-4b2f-9a59-40abd6f7c867"), null, null, "Victoria_Stanton@yahoo.com", null, null, "", null, null },
                    { new Guid("b3d40f2f-4e8b-493c-bc48-82953bc62188"), null, null, "Willard_Kiehn@yahoo.com", null, null, "", null, null },
                    { new Guid("b6802da4-0c7b-44ed-bdf4-1a31f7128f7e"), null, null, "Deanna_Kautzer6@yahoo.com", null, null, "", null, null },
                    { new Guid("b680d295-bf42-4217-a481-2c82b91d8d07"), null, null, "Heather_Sipes@yahoo.com", null, null, "", null, null },
                    { new Guid("b6fab0ee-dec8-4b44-9d34-d0e5d51153ac"), null, null, "Randal.Huels1@yahoo.com", null, null, "", null, null },
                    { new Guid("bb55a4d3-1720-4595-883e-8d6b1c2860c2"), null, null, "Theresa_Oberbrunner@hotmail.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("bd4f40b3-2173-45be-aca1-7bb779cbfd31"), null, null, "Stella_Spinka80@hotmail.com", null, null, "", null, null },
                    { new Guid("bd681a89-7f1d-446d-b88e-156bc4441426"), null, null, "Elena_Stroman48@yahoo.com", null, null, "", null, null },
                    { new Guid("c1b98939-5ef0-4b1c-a8c6-3149c31c69c9"), null, null, "Betty_Brown10@gmail.com", null, null, "", null, null },
                    { new Guid("c44b65cb-61cd-4475-84cd-51323043393d"), null, null, "Jill_Osinski30@yahoo.com", null, null, "", null, null },
                    { new Guid("c602e242-cfae-47e0-b53b-3f7e2c79ce41"), null, null, "Sue.Farrell@gmail.com", null, null, "", null, null },
                    { new Guid("c7838f45-4782-47e0-bca6-b9446ba1a359"), null, null, "Homer23@gmail.com", null, null, "", null, null },
                    { new Guid("cd6c115c-f65f-4497-94a7-a7202d0d03ae"), null, null, "Marianne92@gmail.com", null, null, "", null, null },
                    { new Guid("ce9beb37-5d69-41fa-946d-a5700d9a3efa"), null, null, "Angie18@yahoo.com", null, null, "", null, null },
                    { new Guid("d3041bd2-e8ec-466f-8a48-1ac899ca011a"), null, null, "Timmy_Harris12@gmail.com", null, null, "", null, null },
                    { new Guid("d80b968f-b43d-452f-8e1d-d7400d0c674b"), null, null, "Rodolfo.Collins@gmail.com", null, null, "", null, null },
                    { new Guid("dcff9045-d351-4d1c-95d6-a8b21eaf2afd"), null, null, "Vivian_Homenick8@hotmail.com", null, null, "", null, null },
                    { new Guid("e1fcac5c-c997-4e6a-bd20-59d644385c37"), null, null, "Roosevelt8@yahoo.com", null, null, "", null, null },
                    { new Guid("e2456288-f032-48c8-b229-9e8bc2a6c311"), null, null, "Winston_Schamberger@yahoo.com", null, null, "", null, null },
                    { new Guid("e4719c9f-21ac-46fb-8386-df2d6fbc97cc"), null, null, "Desiree_Nitzsche93@hotmail.com", null, null, "", null, null },
                    { new Guid("e8fcbacc-f5e2-4098-868b-005cf5efedb5"), null, null, "Pedro18@hotmail.com", null, null, "", null, null },
                    { new Guid("ead774a0-c268-4d86-a4eb-6d41d6624a84"), null, null, "Kellie64@gmail.com", null, null, "", null, null },
                    { new Guid("eca6bfbd-0cad-451b-8ba6-99b8c529663d"), null, null, "Pearl_Conn@hotmail.com", null, null, "", null, null },
                    { new Guid("ee219dd9-b459-449a-b01a-8ac46f679972"), null, null, "Sylvester33@hotmail.com", null, null, "", null, null },
                    { new Guid("f1346812-57c6-44ae-bfe1-79ce9cb4fb84"), null, null, "Lynn_Fadel@gmail.com", null, null, "", null, null },
                    { new Guid("f28e197d-fbff-42a6-8743-2996463c48fa"), null, null, "Roland_Rippin@hotmail.com", null, null, "", null, null },
                    { new Guid("f7bb2044-1ed0-4a64-8b60-b3590b086821"), null, null, "Kyle86@yahoo.com", null, null, "", null, null },
                    { new Guid("f8033649-7198-4be2-a343-64630a939d7d"), null, null, "Cindy.Russel@hotmail.com", null, null, "", null, null },
                    { new Guid("fa086a0b-d4d5-443c-b47f-06afbf8d3327"), null, null, "Gilbert_Collins74@hotmail.com", null, null, "", null, null },
                    { new Guid("faa0c172-e669-4b5f-8edf-3037d2657608"), null, null, "Terence64@hotmail.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Stacy.Cremin88@yahoo.com", "Stacy", false, "Cremin", "992.397.9730" },
                    { 2, "Herbert_Pfannerstill@yahoo.com", "Herbert", false, "Pfannerstill", "(974) 658-2465 x35225" },
                    { 3, "Joey18@hotmail.com", "Joey", false, "Wyman", "385.307.9740 x30742" },
                    { 4, "Eloise96@hotmail.com", "Eloise", false, "Toy", "765.792.4955" },
                    { 5, "Colleen24@yahoo.com", "Colleen", false, "Heathcote", "(930) 283-2928 x4795" },
                    { 6, "Ken_Hane@gmail.com", "Ken", false, "Hane", "993-312-7927 x914" },
                    { 7, "Alexis93@hotmail.com", "Alexis", false, "Friesen", "932.516.2718 x1979" },
                    { 8, "Rosalie40@gmail.com", "Rosalie", false, "D'Amore", "719.259.9501" },
                    { 9, "Wilfred_Schuppe@yahoo.com", "Wilfred", false, "Schuppe", "1-984-642-1480" },
                    { 10, "Marcella95@gmail.com", "Marcella", false, "Mertz", "1-594-821-2195" },
                    { 11, "Dwight.Wunsch89@yahoo.com", "Dwight", false, "Wunsch", "(300) 953-1947" },
                    { 12, "Wendy_Little99@yahoo.com", "Wendy", false, "Little", "1-316-764-9667 x0795" },
                    { 13, "Cary67@hotmail.com", "Cary", false, "Lemke", "(607) 304-5619" },
                    { 14, "Simon_Rutherford@yahoo.com", "Simon", false, "Rutherford", "849.633.1874" },
                    { 15, "Felipe.Pfeffer@hotmail.com", "Felipe", false, "Pfeffer", "(289) 338-5628" },
                    { 16, "Bryan.Cruickshank@gmail.com", "Bryan", false, "Cruickshank", "1-502-648-1906 x28860" },
                    { 17, "Jesse.Tromp38@gmail.com", "Jesse", false, "Tromp", "371-771-8666 x7267" },
                    { 18, "Velma.Feest@yahoo.com", "Velma", false, "Feest", "531.916.3160 x492" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[] { 19, "Janet_Gibson@hotmail.com", "Janet", false, "Gibson", "668.772.5866 x1036" });

            migrationBuilder.InsertData(
                table: "LessonApprove",
                columns: new[] { "LessonApproveID", "FK_ApproveID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 27, 1 },
                    { 2, 24, 2 },
                    { 3, 1, 3 },
                    { 4, 13, 4 },
                    { 5, 6, 5 },
                    { 6, 3, 6 },
                    { 7, 12, 7 },
                    { 8, 11, 8 },
                    { 9, 16, 9 },
                    { 10, 29, 10 },
                    { 11, 9, 11 },
                    { 12, 14, 12 },
                    { 13, 30, 13 },
                    { 14, 4, 14 },
                    { 15, 21, 15 },
                    { 16, 17, 16 },
                    { 17, 15, 17 },
                    { 18, 10, 18 },
                    { 19, 28, 19 },
                    { 20, 18, 20 },
                    { 21, 19, 21 },
                    { 22, 22, 22 },
                    { 23, 20, 23 },
                    { 24, 5, 24 },
                    { 25, 2, 25 },
                    { 26, 8, 26 },
                    { 27, 7, 27 },
                    { 28, 26, 28 },
                    { 29, 25, 29 },
                    { 30, 23, 30 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 48, 1 },
                    { 2, 7, 2 },
                    { 3, 49, 3 },
                    { 4, 40, 4 },
                    { 5, 13, 5 },
                    { 6, 32, 6 },
                    { 7, 41, 7 },
                    { 8, 16, 8 },
                    { 9, 34, 9 },
                    { 10, 33, 10 },
                    { 11, 35, 11 },
                    { 12, 26, 12 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 13, 17, 13 },
                    { 14, 36, 14 },
                    { 15, 30, 15 },
                    { 16, 46, 16 },
                    { 17, 27, 17 },
                    { 18, 8, 18 },
                    { 19, 42, 19 },
                    { 20, 3, 20 },
                    { 21, 4, 21 },
                    { 22, 37, 22 },
                    { 23, 19, 23 },
                    { 24, 38, 24 },
                    { 25, 43, 25 },
                    { 26, 6, 26 },
                    { 27, 22, 27 },
                    { 28, 23, 28 },
                    { 29, 44, 29 },
                    { 30, 21, 30 },
                    { 31, 39, 31 },
                    { 32, 24, 32 },
                    { 33, 31, 33 },
                    { 34, 11, 34 },
                    { 35, 47, 35 },
                    { 36, 45, 36 },
                    { 37, 5, 37 },
                    { 38, 10, 38 },
                    { 39, 9, 39 },
                    { 40, 1, 40 },
                    { 41, 15, 41 },
                    { 42, 25, 42 },
                    { 43, 12, 43 },
                    { 44, 28, 44 },
                    { 45, 29, 45 },
                    { 46, 18, 46 },
                    { 47, 2, 47 },
                    { 48, 20, 48 },
                    { 49, 14, 49 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 33 },
                    { 3, 3, 21 },
                    { 4, 4, 44 },
                    { 5, 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 6, 6, 48 },
                    { 7, 7, 34 },
                    { 8, 8, 17 },
                    { 9, 9, 27 },
                    { 10, 10, 22 },
                    { 11, 11, 8 },
                    { 12, 12, 15 },
                    { 13, 13, 43 },
                    { 14, 14, 6 },
                    { 15, 15, 7 },
                    { 16, 16, 31 },
                    { 17, 17, 10 },
                    { 18, 18, 38 },
                    { 19, 19, 35 },
                    { 20, 20, 39 },
                    { 21, 21, 4 },
                    { 22, 22, 30 },
                    { 23, 23, 9 },
                    { 24, 24, 28 },
                    { 25, 25, 14 },
                    { 26, 26, 45 },
                    { 27, 27, 37 },
                    { 28, 28, 16 },
                    { 29, 29, 25 },
                    { 30, 30, 32 },
                    { 31, 31, 5 },
                    { 32, 32, 1 },
                    { 33, 33, 12 },
                    { 34, 34, 20 },
                    { 35, 35, 19 },
                    { 36, 36, 47 },
                    { 37, 37, 36 },
                    { 38, 38, 26 },
                    { 39, 39, 41 },
                    { 40, 40, 18 },
                    { 41, 41, 23 },
                    { 42, 42, 42 },
                    { 43, 43, 40 },
                    { 44, 44, 49 },
                    { 45, 45, 13 },
                    { 46, 46, 46 },
                    { 47, 47, 11 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 48, 48, 24 },
                    { 49, 49, 29 }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 2, new Guid("85fe2e66-f975-4066-afe0-83c72ad57732") },
                    { 2, 5, new Guid("b3d40f2f-4e8b-493c-bc48-82953bc62188") },
                    { 3, 9, new Guid("15b24ee0-0762-4815-bc4c-f22adc35964a") },
                    { 4, 9, new Guid("2f0e85dd-f480-4562-94cc-ab45510c55e5") },
                    { 5, 8, new Guid("b6802da4-0c7b-44ed-bdf4-1a31f7128f7e") },
                    { 6, 3, new Guid("96382db9-7edb-4a8a-8281-e25ae4cc48b7") },
                    { 7, 7, new Guid("06906685-3ce5-4100-b691-881c8a0291ee") },
                    { 8, 6, new Guid("2698821e-a146-43be-b63e-e80b4167b9e4") },
                    { 9, 4, new Guid("e8fcbacc-f5e2-4098-868b-005cf5efedb5") },
                    { 10, 4, new Guid("932733f9-fa8b-49a0-9d44-4ac13e9df18d") },
                    { 11, 7, new Guid("478c0c94-ddc7-4f5e-8ec7-0822f89de52e") },
                    { 12, 3, new Guid("85e2ad46-c186-4457-8aaa-720f52b0f615") },
                    { 13, 9, new Guid("e4719c9f-21ac-46fb-8386-df2d6fbc97cc") },
                    { 14, 4, new Guid("23909c57-1326-4fed-8c93-de20dfcdac3e") },
                    { 15, 3, new Guid("263f7539-3b39-4f81-965a-2897a8f0a62e") },
                    { 16, 6, new Guid("08ce2ac6-710d-4a7d-8dc9-65d487f77cdf") },
                    { 17, 9, new Guid("b0827f4a-7e02-422b-bf85-e47b692fdf60") },
                    { 18, 9, new Guid("50e60685-7500-4e6e-bc68-4bee9ea0695e") },
                    { 19, 1, new Guid("509a1833-0cb2-44fd-97f4-7b40699818a5") },
                    { 20, 7, new Guid("347639f1-711a-4bf9-9e2e-0810945f6cb6") },
                    { 21, 5, new Guid("1ea652a3-9184-44e7-a2a8-2f186ad13ad6") },
                    { 22, 9, new Guid("6935011d-9810-449b-842e-bde860e9a6cc") },
                    { 23, 3, new Guid("c7838f45-4782-47e0-bca6-b9446ba1a359") },
                    { 24, 1, new Guid("4aa9ff06-8a75-46cf-ab7c-2339d2061415") },
                    { 25, 2, new Guid("f1346812-57c6-44ae-bfe1-79ce9cb4fb84") },
                    { 26, 5, new Guid("c602e242-cfae-47e0-b53b-3f7e2c79ce41") },
                    { 27, 1, new Guid("26d37d90-eac9-4dd2-9df2-ee1c7aa65c0b") },
                    { 28, 5, new Guid("1d2bad30-f734-4d24-a7bc-5cef29864b05") },
                    { 29, 7, new Guid("b6fab0ee-dec8-4b44-9d34-d0e5d51153ac") },
                    { 30, 9, new Guid("3e930951-79e4-4958-b24d-2276c3381397") },
                    { 31, 4, new Guid("a356fd32-001d-4762-9f48-7deb3bde329b") },
                    { 32, 2, new Guid("0e12725f-878e-492f-b31c-64c90efcb6d3") },
                    { 33, 5, new Guid("dcff9045-d351-4d1c-95d6-a8b21eaf2afd") },
                    { 34, 8, new Guid("f8033649-7198-4be2-a343-64630a939d7d") },
                    { 35, 7, new Guid("5cd28d24-e8e5-477e-a4c2-02dc3fe2bea8") },
                    { 36, 5, new Guid("b2f160c8-1b0d-4b2f-9a59-40abd6f7c867") },
                    { 37, 5, new Guid("7db407d6-faaf-4428-ae32-010d6b128150") },
                    { 38, 3, new Guid("30dfa9d9-e439-4cd3-bc56-da0f5d8079f8") },
                    { 39, 1, new Guid("b0cfd2f6-71ea-4b98-9cdd-5181ff2b300d") },
                    { 40, 8, new Guid("1be54727-a727-4a9d-bb56-95a1ef613b80") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 41, 1, new Guid("9cdcc68c-e423-4d9c-85c1-402b50564a6e") },
                    { 42, 2, new Guid("355d6f15-0fb5-4440-ac69-ea4649150413") },
                    { 43, 7, new Guid("38e03e23-2c4c-4391-b693-d80ae7dd2eff") },
                    { 44, 8, new Guid("7e0c710f-1408-4f67-8ad0-df646d97f4ad") },
                    { 45, 7, new Guid("5cdeb854-329a-496a-bd74-b11207696cba") },
                    { 46, 1, new Guid("56a6f72c-ce56-45f2-a7e1-2d3b5fc738cd") },
                    { 47, 3, new Guid("697abd26-64a5-4d52-a037-8667f7263a7b") },
                    { 48, 7, new Guid("e2456288-f032-48c8-b229-9e8bc2a6c311") },
                    { 49, 1, new Guid("4ef8373d-ec91-426c-be97-d4eac57eced5") },
                    { 50, 4, new Guid("036c372b-e002-4162-9602-132f03ea784e") },
                    { 51, 4, new Guid("13ec9f61-4837-4af4-ad0e-0a32b4f7f2aa") },
                    { 52, 8, new Guid("70e2b282-fcfa-4f9c-b8fd-76654df0d06f") },
                    { 53, 3, new Guid("380c2a9a-5f3e-4a30-b33d-b6863319f28f") },
                    { 54, 2, new Guid("b680d295-bf42-4217-a481-2c82b91d8d07") },
                    { 55, 6, new Guid("faa0c172-e669-4b5f-8edf-3037d2657608") },
                    { 56, 4, new Guid("84f27634-a5e2-4ac5-ad75-63fe63aeddd6") },
                    { 57, 9, new Guid("967621f4-4446-404b-a20e-93c42611c3ff") },
                    { 58, 2, new Guid("ead774a0-c268-4d86-a4eb-6d41d6624a84") },
                    { 59, 4, new Guid("5fee716a-fbcb-40bc-be6d-edd662bf5103") },
                    { 60, 9, new Guid("82714640-3aba-44a2-88e8-bf9081f2815a") },
                    { 61, 9, new Guid("e1fcac5c-c997-4e6a-bd20-59d644385c37") },
                    { 62, 1, new Guid("791b169d-63df-42ed-87d8-364958449785") },
                    { 63, 7, new Guid("1832a4ce-2fb4-4982-a3cb-1ecc3463f3c3") },
                    { 64, 7, new Guid("d80b968f-b43d-452f-8e1d-d7400d0c674b") },
                    { 65, 5, new Guid("056f440c-c986-40b0-9357-4a4d40e498a4") },
                    { 66, 8, new Guid("83651cc1-8b2b-4c11-9403-e6f853252ed6") },
                    { 67, 4, new Guid("f7bb2044-1ed0-4a64-8b60-b3590b086821") },
                    { 68, 3, new Guid("fa086a0b-d4d5-443c-b47f-06afbf8d3327") },
                    { 69, 3, new Guid("28a86d7e-55f8-4675-9bee-ac8a5e4e28f7") },
                    { 70, 7, new Guid("7a99d1ee-d5d3-47aa-8d1d-b0058d3fc042") },
                    { 71, 1, new Guid("f28e197d-fbff-42a6-8743-2996463c48fa") },
                    { 72, 8, new Guid("eca6bfbd-0cad-451b-8ba6-99b8c529663d") },
                    { 73, 6, new Guid("a41c6708-77e6-40c9-816a-7c0f52284c50") },
                    { 74, 5, new Guid("c44b65cb-61cd-4475-84cd-51323043393d") },
                    { 75, 1, new Guid("679a7e91-1103-4f43-bbc1-46c1802cce1b") },
                    { 76, 9, new Guid("bb55a4d3-1720-4595-883e-8d6b1c2860c2") },
                    { 77, 6, new Guid("9b22fb29-3ccf-4225-b98d-7d1a00bc3299") },
                    { 78, 6, new Guid("a791a00a-47f7-43ee-951a-17e1972d9734") },
                    { 79, 7, new Guid("2ab7d0e0-0a38-4774-b0f9-78d31539509d") },
                    { 80, 2, new Guid("d3041bd2-e8ec-466f-8a48-1ac899ca011a") },
                    { 81, 4, new Guid("9d23b41f-7dea-4499-a3c4-67987a77fe63") },
                    { 82, 1, new Guid("2d073fad-47d3-4519-bc69-b5a56bc8c5d7") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 83, 4, new Guid("ce9beb37-5d69-41fa-946d-a5700d9a3efa") },
                    { 84, 5, new Guid("3169052d-1fa7-479b-a35a-0590d32c1435") },
                    { 85, 1, new Guid("6f69b66a-adbd-46c2-bea0-7a441eeb5f0c") },
                    { 86, 8, new Guid("0ded0e2a-f77e-4570-a909-9e8cd5d71ea7") },
                    { 87, 5, new Guid("c1b98939-5ef0-4b1c-a8c6-3149c31c69c9") },
                    { 88, 8, new Guid("cd6c115c-f65f-4497-94a7-a7202d0d03ae") },
                    { 89, 4, new Guid("2529b148-5aa3-483c-8490-da47137efffe") },
                    { 90, 6, new Guid("bd681a89-7f1d-446d-b88e-156bc4441426") },
                    { 91, 2, new Guid("1ba9b1ff-e99e-453e-9f85-fa126ccffcd5") },
                    { 92, 8, new Guid("6cb5634f-d465-4e0d-9546-27b834aa4755") },
                    { 93, 3, new Guid("9e1d173c-33ca-4d61-887a-6d9e28317336") },
                    { 94, 8, new Guid("ee219dd9-b459-449a-b01a-8ac46f679972") },
                    { 95, 8, new Guid("9cd1455c-311f-4b61-88a1-4260e4953339") },
                    { 96, 9, new Guid("56a753bb-d56c-44e7-8513-5e3eb14b5da5") },
                    { 97, 7, new Guid("32ec4e7d-671a-42e2-8bed-91adf7a6e9ab") },
                    { 98, 3, new Guid("bd4f40b3-2173-45be-aca1-7bb779cbfd31") },
                    { 99, 7, new Guid("0b85ee8d-d395-44c8-8195-f77188a0b1e8") },
                    { 100, 8, new Guid("9680bb13-3c47-417c-b639-4bae141f6254") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("85fe2e66-f975-4066-afe0-83c72ad57732") },
                    { 2, 2, new Guid("b3d40f2f-4e8b-493c-bc48-82953bc62188") },
                    { 3, 3, new Guid("15b24ee0-0762-4815-bc4c-f22adc35964a") },
                    { 4, 4, new Guid("2f0e85dd-f480-4562-94cc-ab45510c55e5") },
                    { 5, 5, new Guid("b6802da4-0c7b-44ed-bdf4-1a31f7128f7e") },
                    { 6, 6, new Guid("96382db9-7edb-4a8a-8281-e25ae4cc48b7") },
                    { 7, 7, new Guid("06906685-3ce5-4100-b691-881c8a0291ee") },
                    { 8, 8, new Guid("2698821e-a146-43be-b63e-e80b4167b9e4") },
                    { 9, 9, new Guid("e8fcbacc-f5e2-4098-868b-005cf5efedb5") },
                    { 10, 10, new Guid("932733f9-fa8b-49a0-9d44-4ac13e9df18d") },
                    { 11, 11, new Guid("478c0c94-ddc7-4f5e-8ec7-0822f89de52e") },
                    { 12, 12, new Guid("85e2ad46-c186-4457-8aaa-720f52b0f615") },
                    { 13, 13, new Guid("e4719c9f-21ac-46fb-8386-df2d6fbc97cc") },
                    { 14, 14, new Guid("23909c57-1326-4fed-8c93-de20dfcdac3e") },
                    { 15, 15, new Guid("263f7539-3b39-4f81-965a-2897a8f0a62e") },
                    { 16, 16, new Guid("08ce2ac6-710d-4a7d-8dc9-65d487f77cdf") },
                    { 17, 17, new Guid("b0827f4a-7e02-422b-bf85-e47b692fdf60") },
                    { 18, 18, new Guid("50e60685-7500-4e6e-bc68-4bee9ea0695e") },
                    { 19, 19, new Guid("509a1833-0cb2-44fd-97f4-7b40699818a5") },
                    { 20, 20, new Guid("347639f1-711a-4bf9-9e2e-0810945f6cb6") },
                    { 21, 21, new Guid("1ea652a3-9184-44e7-a2a8-2f186ad13ad6") },
                    { 22, 22, new Guid("6935011d-9810-449b-842e-bde860e9a6cc") },
                    { 23, 23, new Guid("c7838f45-4782-47e0-bca6-b9446ba1a359") },
                    { 24, 24, new Guid("4aa9ff06-8a75-46cf-ab7c-2339d2061415") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 25, 25, new Guid("f1346812-57c6-44ae-bfe1-79ce9cb4fb84") },
                    { 26, 26, new Guid("c602e242-cfae-47e0-b53b-3f7e2c79ce41") },
                    { 27, 27, new Guid("26d37d90-eac9-4dd2-9df2-ee1c7aa65c0b") },
                    { 28, 28, new Guid("1d2bad30-f734-4d24-a7bc-5cef29864b05") },
                    { 29, 29, new Guid("b6fab0ee-dec8-4b44-9d34-d0e5d51153ac") },
                    { 30, 30, new Guid("3e930951-79e4-4958-b24d-2276c3381397") },
                    { 31, 31, new Guid("a356fd32-001d-4762-9f48-7deb3bde329b") },
                    { 32, 32, new Guid("0e12725f-878e-492f-b31c-64c90efcb6d3") },
                    { 33, 33, new Guid("dcff9045-d351-4d1c-95d6-a8b21eaf2afd") },
                    { 34, 34, new Guid("f8033649-7198-4be2-a343-64630a939d7d") },
                    { 35, 35, new Guid("5cd28d24-e8e5-477e-a4c2-02dc3fe2bea8") },
                    { 36, 36, new Guid("b2f160c8-1b0d-4b2f-9a59-40abd6f7c867") },
                    { 37, 37, new Guid("7db407d6-faaf-4428-ae32-010d6b128150") },
                    { 38, 38, new Guid("30dfa9d9-e439-4cd3-bc56-da0f5d8079f8") },
                    { 39, 39, new Guid("b0cfd2f6-71ea-4b98-9cdd-5181ff2b300d") },
                    { 40, 40, new Guid("1be54727-a727-4a9d-bb56-95a1ef613b80") },
                    { 41, 41, new Guid("9cdcc68c-e423-4d9c-85c1-402b50564a6e") },
                    { 42, 42, new Guid("355d6f15-0fb5-4440-ac69-ea4649150413") },
                    { 43, 43, new Guid("38e03e23-2c4c-4391-b693-d80ae7dd2eff") },
                    { 44, 44, new Guid("7e0c710f-1408-4f67-8ad0-df646d97f4ad") },
                    { 45, 45, new Guid("5cdeb854-329a-496a-bd74-b11207696cba") },
                    { 46, 46, new Guid("56a6f72c-ce56-45f2-a7e1-2d3b5fc738cd") },
                    { 47, 47, new Guid("697abd26-64a5-4d52-a037-8667f7263a7b") },
                    { 48, 48, new Guid("e2456288-f032-48c8-b229-9e8bc2a6c311") },
                    { 49, 49, new Guid("4ef8373d-ec91-426c-be97-d4eac57eced5") },
                    { 50, 50, new Guid("036c372b-e002-4162-9602-132f03ea784e") },
                    { 51, 51, new Guid("13ec9f61-4837-4af4-ad0e-0a32b4f7f2aa") },
                    { 52, 52, new Guid("70e2b282-fcfa-4f9c-b8fd-76654df0d06f") },
                    { 53, 53, new Guid("380c2a9a-5f3e-4a30-b33d-b6863319f28f") },
                    { 54, 54, new Guid("b680d295-bf42-4217-a481-2c82b91d8d07") },
                    { 55, 55, new Guid("faa0c172-e669-4b5f-8edf-3037d2657608") },
                    { 56, 56, new Guid("84f27634-a5e2-4ac5-ad75-63fe63aeddd6") },
                    { 57, 57, new Guid("967621f4-4446-404b-a20e-93c42611c3ff") },
                    { 58, 58, new Guid("ead774a0-c268-4d86-a4eb-6d41d6624a84") },
                    { 59, 59, new Guid("5fee716a-fbcb-40bc-be6d-edd662bf5103") },
                    { 60, 60, new Guid("82714640-3aba-44a2-88e8-bf9081f2815a") },
                    { 61, 61, new Guid("e1fcac5c-c997-4e6a-bd20-59d644385c37") },
                    { 62, 62, new Guid("791b169d-63df-42ed-87d8-364958449785") },
                    { 63, 63, new Guid("1832a4ce-2fb4-4982-a3cb-1ecc3463f3c3") },
                    { 64, 64, new Guid("d80b968f-b43d-452f-8e1d-d7400d0c674b") },
                    { 65, 65, new Guid("056f440c-c986-40b0-9357-4a4d40e498a4") },
                    { 66, 66, new Guid("83651cc1-8b2b-4c11-9403-e6f853252ed6") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 67, 67, new Guid("f7bb2044-1ed0-4a64-8b60-b3590b086821") },
                    { 68, 68, new Guid("fa086a0b-d4d5-443c-b47f-06afbf8d3327") },
                    { 69, 69, new Guid("28a86d7e-55f8-4675-9bee-ac8a5e4e28f7") },
                    { 70, 70, new Guid("7a99d1ee-d5d3-47aa-8d1d-b0058d3fc042") },
                    { 71, 71, new Guid("f28e197d-fbff-42a6-8743-2996463c48fa") },
                    { 72, 72, new Guid("eca6bfbd-0cad-451b-8ba6-99b8c529663d") },
                    { 73, 73, new Guid("a41c6708-77e6-40c9-816a-7c0f52284c50") },
                    { 74, 74, new Guid("c44b65cb-61cd-4475-84cd-51323043393d") },
                    { 75, 75, new Guid("679a7e91-1103-4f43-bbc1-46c1802cce1b") },
                    { 76, 76, new Guid("bb55a4d3-1720-4595-883e-8d6b1c2860c2") },
                    { 77, 77, new Guid("9b22fb29-3ccf-4225-b98d-7d1a00bc3299") },
                    { 78, 78, new Guid("a791a00a-47f7-43ee-951a-17e1972d9734") },
                    { 79, 79, new Guid("2ab7d0e0-0a38-4774-b0f9-78d31539509d") },
                    { 80, 80, new Guid("d3041bd2-e8ec-466f-8a48-1ac899ca011a") },
                    { 81, 81, new Guid("9d23b41f-7dea-4499-a3c4-67987a77fe63") },
                    { 82, 82, new Guid("2d073fad-47d3-4519-bc69-b5a56bc8c5d7") },
                    { 83, 83, new Guid("ce9beb37-5d69-41fa-946d-a5700d9a3efa") },
                    { 84, 84, new Guid("3169052d-1fa7-479b-a35a-0590d32c1435") },
                    { 85, 85, new Guid("6f69b66a-adbd-46c2-bea0-7a441eeb5f0c") },
                    { 86, 86, new Guid("0ded0e2a-f77e-4570-a909-9e8cd5d71ea7") },
                    { 87, 87, new Guid("c1b98939-5ef0-4b1c-a8c6-3149c31c69c9") },
                    { 88, 88, new Guid("cd6c115c-f65f-4497-94a7-a7202d0d03ae") },
                    { 89, 89, new Guid("2529b148-5aa3-483c-8490-da47137efffe") },
                    { 90, 90, new Guid("bd681a89-7f1d-446d-b88e-156bc4441426") },
                    { 91, 91, new Guid("1ba9b1ff-e99e-453e-9f85-fa126ccffcd5") },
                    { 92, 92, new Guid("6cb5634f-d465-4e0d-9546-27b834aa4755") },
                    { 93, 93, new Guid("9e1d173c-33ca-4d61-887a-6d9e28317336") },
                    { 94, 94, new Guid("ee219dd9-b459-449a-b01a-8ac46f679972") },
                    { 95, 95, new Guid("9cd1455c-311f-4b61-88a1-4260e4953339") },
                    { 96, 96, new Guid("56a753bb-d56c-44e7-8513-5e3eb14b5da5") },
                    { 97, 97, new Guid("32ec4e7d-671a-42e2-8bed-91adf7a6e9ab") },
                    { 98, 98, new Guid("bd4f40b3-2173-45be-aca1-7bb779cbfd31") },
                    { 99, 99, new Guid("0b85ee8d-d395-44c8-8195-f77188a0b1e8") },
                    { 100, 100, new Guid("9680bb13-3c47-417c-b639-4bae141f6254") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("85fe2e66-f975-4066-afe0-83c72ad57732") },
                    { 2, 1, new Guid("b3d40f2f-4e8b-493c-bc48-82953bc62188") },
                    { 3, 1, new Guid("15b24ee0-0762-4815-bc4c-f22adc35964a") },
                    { 4, 1, new Guid("2f0e85dd-f480-4562-94cc-ab45510c55e5") },
                    { 5, 1, new Guid("b6802da4-0c7b-44ed-bdf4-1a31f7128f7e") },
                    { 6, 1, new Guid("96382db9-7edb-4a8a-8281-e25ae4cc48b7") },
                    { 7, 1, new Guid("06906685-3ce5-4100-b691-881c8a0291ee") },
                    { 8, 1, new Guid("2698821e-a146-43be-b63e-e80b4167b9e4") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 9, 1, new Guid("e8fcbacc-f5e2-4098-868b-005cf5efedb5") },
                    { 10, 1, new Guid("932733f9-fa8b-49a0-9d44-4ac13e9df18d") },
                    { 11, 1, new Guid("478c0c94-ddc7-4f5e-8ec7-0822f89de52e") },
                    { 12, 1, new Guid("85e2ad46-c186-4457-8aaa-720f52b0f615") },
                    { 13, 1, new Guid("e4719c9f-21ac-46fb-8386-df2d6fbc97cc") },
                    { 14, 1, new Guid("23909c57-1326-4fed-8c93-de20dfcdac3e") },
                    { 15, 1, new Guid("263f7539-3b39-4f81-965a-2897a8f0a62e") },
                    { 16, 1, new Guid("08ce2ac6-710d-4a7d-8dc9-65d487f77cdf") },
                    { 17, 1, new Guid("b0827f4a-7e02-422b-bf85-e47b692fdf60") },
                    { 18, 1, new Guid("50e60685-7500-4e6e-bc68-4bee9ea0695e") },
                    { 19, 1, new Guid("509a1833-0cb2-44fd-97f4-7b40699818a5") },
                    { 20, 1, new Guid("347639f1-711a-4bf9-9e2e-0810945f6cb6") },
                    { 21, 1, new Guid("1ea652a3-9184-44e7-a2a8-2f186ad13ad6") },
                    { 22, 1, new Guid("6935011d-9810-449b-842e-bde860e9a6cc") },
                    { 23, 1, new Guid("c7838f45-4782-47e0-bca6-b9446ba1a359") },
                    { 24, 1, new Guid("4aa9ff06-8a75-46cf-ab7c-2339d2061415") },
                    { 25, 1, new Guid("f1346812-57c6-44ae-bfe1-79ce9cb4fb84") },
                    { 26, 1, new Guid("c602e242-cfae-47e0-b53b-3f7e2c79ce41") },
                    { 27, 1, new Guid("26d37d90-eac9-4dd2-9df2-ee1c7aa65c0b") },
                    { 28, 1, new Guid("1d2bad30-f734-4d24-a7bc-5cef29864b05") },
                    { 29, 1, new Guid("b6fab0ee-dec8-4b44-9d34-d0e5d51153ac") },
                    { 30, 1, new Guid("3e930951-79e4-4958-b24d-2276c3381397") },
                    { 31, 1, new Guid("a356fd32-001d-4762-9f48-7deb3bde329b") },
                    { 32, 1, new Guid("0e12725f-878e-492f-b31c-64c90efcb6d3") },
                    { 33, 1, new Guid("dcff9045-d351-4d1c-95d6-a8b21eaf2afd") },
                    { 34, 1, new Guid("f8033649-7198-4be2-a343-64630a939d7d") },
                    { 35, 1, new Guid("5cd28d24-e8e5-477e-a4c2-02dc3fe2bea8") },
                    { 36, 1, new Guid("b2f160c8-1b0d-4b2f-9a59-40abd6f7c867") },
                    { 37, 1, new Guid("7db407d6-faaf-4428-ae32-010d6b128150") },
                    { 38, 1, new Guid("30dfa9d9-e439-4cd3-bc56-da0f5d8079f8") },
                    { 39, 1, new Guid("b0cfd2f6-71ea-4b98-9cdd-5181ff2b300d") },
                    { 40, 1, new Guid("1be54727-a727-4a9d-bb56-95a1ef613b80") },
                    { 41, 1, new Guid("9cdcc68c-e423-4d9c-85c1-402b50564a6e") },
                    { 42, 1, new Guid("355d6f15-0fb5-4440-ac69-ea4649150413") },
                    { 43, 1, new Guid("38e03e23-2c4c-4391-b693-d80ae7dd2eff") },
                    { 44, 1, new Guid("7e0c710f-1408-4f67-8ad0-df646d97f4ad") },
                    { 45, 1, new Guid("5cdeb854-329a-496a-bd74-b11207696cba") },
                    { 46, 1, new Guid("56a6f72c-ce56-45f2-a7e1-2d3b5fc738cd") },
                    { 47, 1, new Guid("697abd26-64a5-4d52-a037-8667f7263a7b") },
                    { 48, 1, new Guid("e2456288-f032-48c8-b229-9e8bc2a6c311") },
                    { 49, 1, new Guid("4ef8373d-ec91-426c-be97-d4eac57eced5") },
                    { 50, 1, new Guid("036c372b-e002-4162-9602-132f03ea784e") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 51, 1, new Guid("13ec9f61-4837-4af4-ad0e-0a32b4f7f2aa") },
                    { 52, 1, new Guid("70e2b282-fcfa-4f9c-b8fd-76654df0d06f") },
                    { 53, 1, new Guid("380c2a9a-5f3e-4a30-b33d-b6863319f28f") },
                    { 54, 1, new Guid("b680d295-bf42-4217-a481-2c82b91d8d07") },
                    { 55, 1, new Guid("faa0c172-e669-4b5f-8edf-3037d2657608") },
                    { 56, 1, new Guid("84f27634-a5e2-4ac5-ad75-63fe63aeddd6") },
                    { 57, 1, new Guid("967621f4-4446-404b-a20e-93c42611c3ff") },
                    { 58, 1, new Guid("ead774a0-c268-4d86-a4eb-6d41d6624a84") },
                    { 59, 1, new Guid("5fee716a-fbcb-40bc-be6d-edd662bf5103") },
                    { 60, 1, new Guid("82714640-3aba-44a2-88e8-bf9081f2815a") },
                    { 61, 1, new Guid("e1fcac5c-c997-4e6a-bd20-59d644385c37") },
                    { 62, 1, new Guid("791b169d-63df-42ed-87d8-364958449785") },
                    { 63, 1, new Guid("1832a4ce-2fb4-4982-a3cb-1ecc3463f3c3") },
                    { 64, 1, new Guid("d80b968f-b43d-452f-8e1d-d7400d0c674b") },
                    { 65, 1, new Guid("056f440c-c986-40b0-9357-4a4d40e498a4") },
                    { 66, 1, new Guid("83651cc1-8b2b-4c11-9403-e6f853252ed6") },
                    { 67, 1, new Guid("f7bb2044-1ed0-4a64-8b60-b3590b086821") },
                    { 68, 1, new Guid("fa086a0b-d4d5-443c-b47f-06afbf8d3327") },
                    { 69, 1, new Guid("28a86d7e-55f8-4675-9bee-ac8a5e4e28f7") },
                    { 70, 1, new Guid("7a99d1ee-d5d3-47aa-8d1d-b0058d3fc042") },
                    { 71, 1, new Guid("f28e197d-fbff-42a6-8743-2996463c48fa") },
                    { 72, 1, new Guid("eca6bfbd-0cad-451b-8ba6-99b8c529663d") },
                    { 73, 1, new Guid("a41c6708-77e6-40c9-816a-7c0f52284c50") },
                    { 74, 1, new Guid("c44b65cb-61cd-4475-84cd-51323043393d") },
                    { 75, 1, new Guid("679a7e91-1103-4f43-bbc1-46c1802cce1b") },
                    { 76, 1, new Guid("bb55a4d3-1720-4595-883e-8d6b1c2860c2") },
                    { 77, 1, new Guid("9b22fb29-3ccf-4225-b98d-7d1a00bc3299") },
                    { 78, 1, new Guid("a791a00a-47f7-43ee-951a-17e1972d9734") },
                    { 79, 1, new Guid("2ab7d0e0-0a38-4774-b0f9-78d31539509d") },
                    { 80, 1, new Guid("d3041bd2-e8ec-466f-8a48-1ac899ca011a") },
                    { 81, 1, new Guid("9d23b41f-7dea-4499-a3c4-67987a77fe63") },
                    { 82, 1, new Guid("2d073fad-47d3-4519-bc69-b5a56bc8c5d7") },
                    { 83, 1, new Guid("ce9beb37-5d69-41fa-946d-a5700d9a3efa") },
                    { 84, 1, new Guid("3169052d-1fa7-479b-a35a-0590d32c1435") },
                    { 85, 1, new Guid("6f69b66a-adbd-46c2-bea0-7a441eeb5f0c") },
                    { 86, 1, new Guid("0ded0e2a-f77e-4570-a909-9e8cd5d71ea7") },
                    { 87, 1, new Guid("c1b98939-5ef0-4b1c-a8c6-3149c31c69c9") },
                    { 88, 1, new Guid("cd6c115c-f65f-4497-94a7-a7202d0d03ae") },
                    { 89, 1, new Guid("2529b148-5aa3-483c-8490-da47137efffe") },
                    { 90, 1, new Guid("bd681a89-7f1d-446d-b88e-156bc4441426") },
                    { 91, 1, new Guid("1ba9b1ff-e99e-453e-9f85-fa126ccffcd5") },
                    { 92, 1, new Guid("6cb5634f-d465-4e0d-9546-27b834aa4755") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 93, 1, new Guid("9e1d173c-33ca-4d61-887a-6d9e28317336") },
                    { 94, 1, new Guid("ee219dd9-b459-449a-b01a-8ac46f679972") },
                    { 95, 1, new Guid("9cd1455c-311f-4b61-88a1-4260e4953339") },
                    { 96, 1, new Guid("56a753bb-d56c-44e7-8513-5e3eb14b5da5") },
                    { 97, 1, new Guid("32ec4e7d-671a-42e2-8bed-91adf7a6e9ab") },
                    { 98, 1, new Guid("bd4f40b3-2173-45be-aca1-7bb779cbfd31") },
                    { 99, 1, new Guid("0b85ee8d-d395-44c8-8195-f77188a0b1e8") },
                    { 100, 1, new Guid("9680bb13-3c47-417c-b639-4bae141f6254") }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 1, 1, 1, 8 },
                    { 2, 2, 1, 14 },
                    { 3, 3, 1, 16 },
                    { 4, 4, 1, 14 },
                    { 5, 5, 1, 14 },
                    { 6, 6, 1, 2 },
                    { 7, 7, 1, 17 },
                    { 8, 8, 1, 13 },
                    { 9, 9, 1, 13 },
                    { 10, 10, 1, 5 },
                    { 11, 11, 1, 8 },
                    { 12, 12, 1, 14 },
                    { 13, 13, 1, 13 },
                    { 14, 14, 1, 15 },
                    { 15, 15, 1, 9 },
                    { 16, 16, 1, 18 },
                    { 17, 17, 1, 10 },
                    { 18, 18, 1, 5 },
                    { 19, 19, 1, 6 },
                    { 20, 20, 1, 1 },
                    { 21, 21, 1, 3 },
                    { 22, 22, 1, 14 },
                    { 23, 23, 1, 10 },
                    { 24, 24, 1, 2 },
                    { 25, 25, 1, 16 },
                    { 26, 26, 1, 13 },
                    { 27, 27, 1, 7 },
                    { 28, 28, 1, 1 },
                    { 29, 29, 1, 15 },
                    { 30, 30, 1, 11 },
                    { 31, 31, 1, 15 },
                    { 32, 32, 1, 10 },
                    { 33, 33, 1, 16 },
                    { 34, 34, 1, 7 },
                    { 35, 35, 1, 2 },
                    { 36, 36, 1, 12 },
                    { 37, 37, 1, 6 },
                    { 38, 38, 1, 8 },
                    { 39, 39, 1, 2 },
                    { 40, 40, 2, 18 },
                    { 41, 41, 2, 18 },
                    { 42, 42, 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 43, 43, 2, 9 },
                    { 44, 44, 2, 5 },
                    { 45, 45, 2, 9 },
                    { 46, 46, 2, 9 },
                    { 47, 47, 2, 9 },
                    { 48, 48, 2, 13 },
                    { 49, 49, 2, 11 },
                    { 50, 50, 2, 11 },
                    { 51, 51, 2, 14 },
                    { 52, 52, 2, 11 },
                    { 53, 53, 2, 8 },
                    { 54, 54, 2, 12 },
                    { 55, 55, 2, 18 },
                    { 56, 56, 2, 15 },
                    { 57, 57, 2, 6 },
                    { 58, 58, 2, 8 },
                    { 59, 59, 2, 16 },
                    { 60, 60, 2, 7 },
                    { 61, 61, 2, 15 },
                    { 62, 62, 2, 13 },
                    { 63, 63, 2, 12 },
                    { 64, 64, 2, 17 },
                    { 65, 65, 2, 14 },
                    { 66, 66, 2, 6 },
                    { 67, 67, 2, 7 },
                    { 68, 68, 2, 14 },
                    { 69, 69, 2, 8 },
                    { 70, 70, 2, 13 },
                    { 71, 71, 2, 1 },
                    { 72, 72, 2, 18 },
                    { 73, 73, 2, 15 },
                    { 74, 74, 2, 15 },
                    { 75, 75, 2, 12 },
                    { 76, 76, 2, 7 },
                    { 77, 77, 2, 5 },
                    { 78, 78, 2, 18 },
                    { 79, 79, 2, 5 },
                    { 80, 80, 3, 8 },
                    { 81, 81, 3, 5 },
                    { 82, 82, 3, 12 },
                    { 83, 83, 3, 9 },
                    { 84, 84, 3, 8 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 85, 85, 3, 6 },
                    { 86, 86, 3, 7 },
                    { 87, 87, 3, 5 },
                    { 88, 88, 3, 14 },
                    { 89, 89, 3, 12 },
                    { 90, 90, 3, 18 },
                    { 91, 91, 3, 2 },
                    { 92, 92, 3, 2 },
                    { 93, 93, 3, 12 },
                    { 94, 94, 3, 9 },
                    { 95, 95, 3, 6 },
                    { 96, 96, 3, 12 },
                    { 97, 97, 3, 12 },
                    { 98, 98, 3, 4 },
                    { 99, 99, 3, 9 },
                    { 100, 100, 3, 1 },
                    { 101, 101, 3, 17 },
                    { 102, 102, 3, 16 },
                    { 103, 103, 3, 8 },
                    { 104, 104, 3, 16 },
                    { 105, 105, 3, 15 },
                    { 106, 106, 3, 15 },
                    { 107, 107, 3, 12 },
                    { 108, 108, 3, 5 },
                    { 109, 109, 3, 13 },
                    { 110, 110, 3, 9 },
                    { 111, 111, 3, 9 },
                    { 112, 112, 3, 12 },
                    { 113, 113, 3, 13 },
                    { 114, 114, 3, 1 },
                    { 115, 115, 3, 4 },
                    { 116, 116, 3, 4 },
                    { 117, 117, 3, 18 },
                    { 118, 118, 3, 16 },
                    { 119, 119, 3, 18 },
                    { 120, 120, 4, 8 },
                    { 121, 121, 4, 12 },
                    { 122, 122, 4, 3 },
                    { 123, 123, 4, 2 },
                    { 124, 124, 4, 18 },
                    { 125, 125, 4, 10 },
                    { 126, 126, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 127, 127, 4, 16 },
                    { 128, 128, 4, 18 },
                    { 129, 129, 4, 6 },
                    { 130, 130, 4, 10 },
                    { 131, 131, 4, 4 },
                    { 132, 132, 4, 1 },
                    { 133, 133, 4, 9 },
                    { 134, 134, 4, 9 },
                    { 135, 135, 4, 13 },
                    { 136, 136, 4, 10 },
                    { 137, 137, 4, 1 },
                    { 138, 138, 4, 2 },
                    { 139, 139, 4, 18 },
                    { 140, 140, 4, 7 },
                    { 141, 141, 4, 5 },
                    { 142, 142, 4, 4 },
                    { 143, 143, 4, 17 },
                    { 144, 144, 4, 18 },
                    { 145, 145, 4, 14 },
                    { 146, 146, 4, 8 },
                    { 147, 147, 4, 12 },
                    { 148, 148, 4, 7 },
                    { 149, 149, 4, 10 },
                    { 150, 150, 4, 17 },
                    { 151, 151, 4, 5 },
                    { 152, 152, 4, 13 },
                    { 153, 153, 4, 5 },
                    { 154, 154, 4, 5 },
                    { 155, 155, 4, 12 },
                    { 156, 156, 4, 13 },
                    { 157, 157, 4, 17 },
                    { 158, 158, 4, 2 },
                    { 159, 159, 4, 2 },
                    { 160, 160, 5, 5 },
                    { 161, 161, 5, 13 },
                    { 162, 162, 5, 2 },
                    { 163, 163, 5, 6 },
                    { 164, 164, 5, 12 },
                    { 165, 165, 5, 5 },
                    { 166, 166, 5, 7 },
                    { 167, 167, 5, 18 },
                    { 168, 168, 5, 12 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 169, 169, 5, 6 },
                    { 170, 170, 5, 12 },
                    { 171, 171, 5, 10 },
                    { 172, 172, 5, 17 },
                    { 173, 173, 5, 11 },
                    { 174, 174, 5, 8 },
                    { 175, 175, 5, 3 },
                    { 176, 176, 5, 3 },
                    { 177, 177, 5, 16 },
                    { 178, 178, 5, 4 },
                    { 179, 179, 5, 7 },
                    { 180, 180, 5, 12 },
                    { 181, 181, 5, 17 },
                    { 182, 182, 5, 11 },
                    { 183, 183, 5, 3 },
                    { 184, 184, 5, 11 },
                    { 185, 185, 5, 14 },
                    { 186, 186, 5, 18 },
                    { 187, 187, 5, 4 },
                    { 188, 188, 5, 17 },
                    { 189, 189, 5, 6 },
                    { 190, 190, 5, 16 },
                    { 191, 191, 5, 15 },
                    { 192, 192, 5, 6 },
                    { 193, 193, 5, 5 },
                    { 194, 194, 5, 3 },
                    { 195, 195, 5, 9 },
                    { 196, 196, 5, 8 },
                    { 197, 197, 5, 13 },
                    { 198, 198, 5, 8 },
                    { 199, 199, 5, 17 },
                    { 200, 200, 6, 1 },
                    { 201, 201, 6, 12 },
                    { 202, 202, 6, 9 },
                    { 203, 203, 6, 17 },
                    { 204, 204, 6, 18 },
                    { 205, 205, 6, 5 },
                    { 206, 206, 6, 17 },
                    { 207, 207, 6, 4 },
                    { 208, 208, 6, 9 },
                    { 209, 209, 6, 2 },
                    { 210, 210, 6, 17 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 211, 211, 6, 8 },
                    { 212, 212, 6, 9 },
                    { 213, 213, 6, 1 },
                    { 214, 214, 6, 17 },
                    { 215, 215, 6, 18 },
                    { 216, 216, 6, 10 },
                    { 217, 217, 6, 13 },
                    { 218, 218, 6, 17 },
                    { 219, 219, 6, 12 },
                    { 220, 220, 6, 16 },
                    { 221, 221, 6, 1 },
                    { 222, 222, 6, 13 },
                    { 223, 223, 6, 12 },
                    { 224, 224, 6, 14 },
                    { 225, 225, 6, 17 },
                    { 226, 226, 6, 13 },
                    { 227, 227, 6, 18 },
                    { 228, 228, 6, 11 },
                    { 229, 229, 6, 9 },
                    { 230, 230, 6, 10 },
                    { 231, 231, 6, 10 },
                    { 232, 232, 6, 1 },
                    { 233, 233, 6, 14 },
                    { 234, 234, 6, 16 },
                    { 235, 235, 6, 17 },
                    { 236, 236, 6, 3 },
                    { 237, 237, 6, 18 },
                    { 238, 238, 6, 6 },
                    { 239, 239, 6, 3 },
                    { 240, 240, 7, 9 },
                    { 241, 241, 7, 17 },
                    { 242, 242, 7, 2 },
                    { 243, 243, 7, 14 },
                    { 244, 244, 7, 13 },
                    { 245, 245, 7, 5 },
                    { 246, 246, 7, 8 },
                    { 247, 247, 7, 12 },
                    { 248, 248, 7, 18 },
                    { 249, 249, 7, 8 },
                    { 250, 250, 7, 10 },
                    { 251, 251, 7, 3 },
                    { 252, 252, 7, 12 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 253, 253, 7, 3 },
                    { 254, 254, 7, 1 },
                    { 255, 255, 7, 1 },
                    { 256, 256, 7, 12 },
                    { 257, 257, 7, 18 },
                    { 258, 258, 7, 6 },
                    { 259, 259, 7, 8 },
                    { 260, 260, 7, 8 },
                    { 261, 261, 7, 5 },
                    { 262, 262, 7, 4 },
                    { 263, 263, 7, 13 },
                    { 264, 264, 7, 1 },
                    { 265, 265, 7, 17 },
                    { 266, 266, 7, 1 },
                    { 267, 267, 7, 2 },
                    { 268, 268, 7, 16 },
                    { 269, 269, 7, 15 },
                    { 270, 270, 7, 11 },
                    { 271, 271, 7, 17 },
                    { 272, 272, 7, 4 },
                    { 273, 273, 7, 2 },
                    { 274, 274, 7, 9 },
                    { 275, 275, 7, 11 },
                    { 276, 276, 7, 16 },
                    { 277, 277, 7, 13 },
                    { 278, 278, 7, 10 },
                    { 279, 279, 7, 1 },
                    { 280, 280, 8, 16 },
                    { 281, 281, 8, 9 },
                    { 282, 282, 8, 2 },
                    { 283, 283, 8, 7 },
                    { 284, 284, 8, 1 },
                    { 285, 285, 8, 14 },
                    { 286, 286, 8, 10 },
                    { 287, 287, 8, 11 },
                    { 288, 288, 8, 15 },
                    { 289, 289, 8, 1 },
                    { 290, 290, 8, 10 },
                    { 291, 291, 8, 5 },
                    { 292, 292, 8, 13 },
                    { 293, 293, 8, 8 },
                    { 294, 294, 8, 18 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 295, 295, 8, 8 },
                    { 296, 296, 8, 14 },
                    { 297, 297, 8, 17 },
                    { 298, 298, 8, 14 },
                    { 299, 299, 8, 14 },
                    { 300, 300, 8, 15 },
                    { 301, 301, 8, 14 },
                    { 302, 302, 8, 16 },
                    { 303, 303, 8, 12 },
                    { 304, 304, 8, 3 },
                    { 305, 305, 8, 12 },
                    { 306, 306, 8, 17 },
                    { 307, 307, 8, 9 },
                    { 308, 308, 8, 1 },
                    { 309, 309, 8, 15 },
                    { 310, 310, 8, 8 },
                    { 311, 311, 8, 18 },
                    { 312, 312, 8, 6 },
                    { 313, 313, 8, 9 },
                    { 314, 314, 8, 1 },
                    { 315, 315, 8, 9 },
                    { 316, 316, 8, 4 },
                    { 317, 317, 8, 6 },
                    { 318, 318, 8, 14 },
                    { 319, 319, 8, 1 },
                    { 320, 320, 9, 6 },
                    { 321, 321, 9, 12 },
                    { 322, 322, 9, 16 },
                    { 323, 323, 9, 9 },
                    { 324, 324, 9, 5 },
                    { 325, 325, 9, 1 },
                    { 326, 326, 9, 6 },
                    { 327, 327, 9, 4 },
                    { 328, 328, 9, 4 },
                    { 329, 329, 9, 14 },
                    { 330, 330, 9, 9 },
                    { 331, 331, 9, 10 },
                    { 332, 332, 9, 17 },
                    { 333, 333, 9, 6 },
                    { 334, 334, 9, 7 },
                    { 335, 335, 9, 1 },
                    { 336, 336, 9, 17 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 337, 337, 9, 18 },
                    { 338, 338, 9, 15 },
                    { 339, 339, 9, 15 },
                    { 340, 340, 9, 2 },
                    { 341, 341, 9, 12 },
                    { 342, 342, 9, 16 },
                    { 343, 343, 9, 14 },
                    { 344, 344, 9, 1 },
                    { 345, 345, 9, 18 },
                    { 346, 346, 9, 6 },
                    { 347, 347, 9, 10 },
                    { 348, 348, 9, 17 },
                    { 349, 349, 9, 5 },
                    { 350, 350, 9, 2 },
                    { 351, 351, 9, 9 },
                    { 352, 352, 9, 2 },
                    { 353, 353, 9, 9 },
                    { 354, 354, 9, 18 },
                    { 355, 355, 9, 12 },
                    { 356, 356, 9, 17 },
                    { 357, 357, 9, 12 },
                    { 358, 358, 9, 7 },
                    { 359, 359, 9, 6 },
                    { 360, 360, 10, 15 },
                    { 361, 361, 10, 9 },
                    { 362, 362, 10, 8 },
                    { 363, 363, 10, 5 },
                    { 364, 364, 10, 15 },
                    { 365, 365, 10, 10 },
                    { 366, 366, 10, 15 },
                    { 367, 367, 10, 9 },
                    { 368, 368, 10, 1 },
                    { 369, 369, 10, 7 },
                    { 370, 370, 10, 2 },
                    { 371, 371, 10, 11 },
                    { 372, 372, 10, 15 },
                    { 373, 373, 10, 16 },
                    { 374, 374, 10, 4 },
                    { 375, 375, 10, 9 },
                    { 376, 376, 10, 3 },
                    { 377, 377, 10, 10 },
                    { 378, 378, 10, 16 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 379, 379, 10, 2 },
                    { 380, 380, 10, 6 },
                    { 381, 381, 10, 7 },
                    { 382, 382, 10, 12 },
                    { 383, 383, 10, 8 },
                    { 384, 384, 10, 13 },
                    { 385, 385, 10, 8 },
                    { 386, 386, 10, 17 },
                    { 387, 387, 10, 7 },
                    { 388, 388, 10, 13 },
                    { 389, 389, 10, 7 },
                    { 390, 390, 10, 10 },
                    { 391, 391, 10, 1 },
                    { 392, 392, 10, 13 },
                    { 393, 393, 10, 4 },
                    { 394, 394, 10, 18 },
                    { 395, 395, 10, 18 },
                    { 396, 396, 10, 2 },
                    { 397, 397, 10, 6 },
                    { 398, 398, 10, 5 },
                    { 399, 399, 10, 17 },
                    { 400, 400, 10, 16 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LessonApprove",
                keyColumn: "LessonApproveID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PersonParent",
                keyColumn: "PersonParentID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Approve",
                keyColumn: "ApproveID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Parent",
                keyColumn: "ParentID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("036c372b-e002-4162-9602-132f03ea784e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("056f440c-c986-40b0-9357-4a4d40e498a4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("08ce2ac6-710d-4a7d-8dc9-65d487f77cdf"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0b85ee8d-d395-44c8-8195-f77188a0b1e8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0ded0e2a-f77e-4570-a909-9e8cd5d71ea7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0e12725f-878e-492f-b31c-64c90efcb6d3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("13ec9f61-4837-4af4-ad0e-0a32b4f7f2aa"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1832a4ce-2fb4-4982-a3cb-1ecc3463f3c3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1ba9b1ff-e99e-453e-9f85-fa126ccffcd5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1be54727-a727-4a9d-bb56-95a1ef613b80"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1d2bad30-f734-4d24-a7bc-5cef29864b05"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1ea652a3-9184-44e7-a2a8-2f186ad13ad6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("23909c57-1326-4fed-8c93-de20dfcdac3e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2529b148-5aa3-483c-8490-da47137efffe"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("263f7539-3b39-4f81-965a-2897a8f0a62e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("26d37d90-eac9-4dd2-9df2-ee1c7aa65c0b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("28a86d7e-55f8-4675-9bee-ac8a5e4e28f7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2ab7d0e0-0a38-4774-b0f9-78d31539509d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2d073fad-47d3-4519-bc69-b5a56bc8c5d7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("30dfa9d9-e439-4cd3-bc56-da0f5d8079f8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3169052d-1fa7-479b-a35a-0590d32c1435"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("32ec4e7d-671a-42e2-8bed-91adf7a6e9ab"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("347639f1-711a-4bf9-9e2e-0810945f6cb6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("355d6f15-0fb5-4440-ac69-ea4649150413"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("380c2a9a-5f3e-4a30-b33d-b6863319f28f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("38e03e23-2c4c-4391-b693-d80ae7dd2eff"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3e930951-79e4-4958-b24d-2276c3381397"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("478c0c94-ddc7-4f5e-8ec7-0822f89de52e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4aa9ff06-8a75-46cf-ab7c-2339d2061415"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4ef8373d-ec91-426c-be97-d4eac57eced5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("509a1833-0cb2-44fd-97f4-7b40699818a5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("50e60685-7500-4e6e-bc68-4bee9ea0695e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("56a6f72c-ce56-45f2-a7e1-2d3b5fc738cd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("56a753bb-d56c-44e7-8513-5e3eb14b5da5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5cd28d24-e8e5-477e-a4c2-02dc3fe2bea8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5cdeb854-329a-496a-bd74-b11207696cba"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5fee716a-fbcb-40bc-be6d-edd662bf5103"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("679a7e91-1103-4f43-bbc1-46c1802cce1b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6935011d-9810-449b-842e-bde860e9a6cc"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("697abd26-64a5-4d52-a037-8667f7263a7b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6cb5634f-d465-4e0d-9546-27b834aa4755"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6f69b66a-adbd-46c2-bea0-7a441eeb5f0c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("70e2b282-fcfa-4f9c-b8fd-76654df0d06f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("791b169d-63df-42ed-87d8-364958449785"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7a99d1ee-d5d3-47aa-8d1d-b0058d3fc042"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7db407d6-faaf-4428-ae32-010d6b128150"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7e0c710f-1408-4f67-8ad0-df646d97f4ad"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("82714640-3aba-44a2-88e8-bf9081f2815a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("83651cc1-8b2b-4c11-9403-e6f853252ed6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("84f27634-a5e2-4ac5-ad75-63fe63aeddd6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("85e2ad46-c186-4457-8aaa-720f52b0f615"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("967621f4-4446-404b-a20e-93c42611c3ff"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9680bb13-3c47-417c-b639-4bae141f6254"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9b22fb29-3ccf-4225-b98d-7d1a00bc3299"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9cd1455c-311f-4b61-88a1-4260e4953339"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9cdcc68c-e423-4d9c-85c1-402b50564a6e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9d23b41f-7dea-4499-a3c4-67987a77fe63"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9e1d173c-33ca-4d61-887a-6d9e28317336"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a356fd32-001d-4762-9f48-7deb3bde329b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a41c6708-77e6-40c9-816a-7c0f52284c50"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a791a00a-47f7-43ee-951a-17e1972d9734"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b0827f4a-7e02-422b-bf85-e47b692fdf60"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b0cfd2f6-71ea-4b98-9cdd-5181ff2b300d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b2f160c8-1b0d-4b2f-9a59-40abd6f7c867"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b680d295-bf42-4217-a481-2c82b91d8d07"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b6fab0ee-dec8-4b44-9d34-d0e5d51153ac"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bb55a4d3-1720-4595-883e-8d6b1c2860c2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bd4f40b3-2173-45be-aca1-7bb779cbfd31"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bd681a89-7f1d-446d-b88e-156bc4441426"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c1b98939-5ef0-4b1c-a8c6-3149c31c69c9"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c44b65cb-61cd-4475-84cd-51323043393d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c602e242-cfae-47e0-b53b-3f7e2c79ce41"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c7838f45-4782-47e0-bca6-b9446ba1a359"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("cd6c115c-f65f-4497-94a7-a7202d0d03ae"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ce9beb37-5d69-41fa-946d-a5700d9a3efa"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d3041bd2-e8ec-466f-8a48-1ac899ca011a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d80b968f-b43d-452f-8e1d-d7400d0c674b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("dcff9045-d351-4d1c-95d6-a8b21eaf2afd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e1fcac5c-c997-4e6a-bd20-59d644385c37"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e2456288-f032-48c8-b229-9e8bc2a6c311"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e4719c9f-21ac-46fb-8386-df2d6fbc97cc"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ead774a0-c268-4d86-a4eb-6d41d6624a84"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("eca6bfbd-0cad-451b-8ba6-99b8c529663d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ee219dd9-b459-449a-b01a-8ac46f679972"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f1346812-57c6-44ae-bfe1-79ce9cb4fb84"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f28e197d-fbff-42a6-8743-2996463c48fa"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f7bb2044-1ed0-4a64-8b60-b3590b086821"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f8033649-7198-4be2-a343-64630a939d7d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fa086a0b-d4d5-443c-b47f-06afbf8d3327"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("faa0c172-e669-4b5f-8edf-3037d2657608"));

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("06906685-3ce5-4100-b691-881c8a0291ee"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("15b24ee0-0762-4815-bc4c-f22adc35964a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2698821e-a146-43be-b63e-e80b4167b9e4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2f0e85dd-f480-4562-94cc-ab45510c55e5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("85fe2e66-f975-4066-afe0-83c72ad57732"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("932733f9-fa8b-49a0-9d44-4ac13e9df18d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("96382db9-7edb-4a8a-8281-e25ae4cc48b7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b3d40f2f-4e8b-493c-bc48-82953bc62188"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b6802da4-0c7b-44ed-bdf4-1a31f7128f7e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e8fcbacc-f5e2-4098-868b-005cf5efedb5"));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parent",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
