using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_PersonClass_FK_PersonClass",
                table: "Subject");

            migrationBuilder.RenameColumn(
                name: "FK_PersonClass",
                table: "Subject",
                newName: "FK_Class");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_FK_PersonClass",
                table: "Subject",
                newName: "IX_Subject_FK_Class");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parent",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FK_UserUUID",
                table: "Mark",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FK_UserUUID",
                table: "Grade",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FK_UserUUID",
                table: "Approve",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "Math" },
                    { 2, 1, 2, "History" },
                    { 3, 1, 3, "Chemistry" },
                    { 4, 1, 4, "English" },
                    { 5, 1, 5, "History" },
                    { 6, 1, 6, "English" },
                    { 7, 1, 7, "Polish" },
                    { 8, 1, 8, "PE" },
                    { 9, 2, 1, "Polish" },
                    { 10, 2, 2, "Physics" },
                    { 11, 2, 3, "Chemistry" },
                    { 12, 2, 4, "Math" },
                    { 13, 2, 5, "PE" },
                    { 14, 2, 6, "Polish" },
                    { 15, 2, 7, "PE" },
                    { 16, 2, 8, "History" },
                    { 17, 3, 1, "History" },
                    { 18, 3, 2, "Geography" },
                    { 19, 3, 3, "Math" },
                    { 20, 3, 4, "PE" },
                    { 21, 3, 5, "Geography" },
                    { 22, 3, 6, "Physics" },
                    { 23, 3, 7, "History" },
                    { 24, 3, 8, "English" },
                    { 25, 4, 1, "Polish" },
                    { 26, 4, 2, "History" },
                    { 27, 4, 3, "History" },
                    { 28, 4, 4, "Polish" },
                    { 29, 4, 5, "Chemistry" },
                    { 30, 4, 6, "Polish" },
                    { 31, 4, 7, "PE" },
                    { 32, 4, 8, "English" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 33, 5, 1, "History" },
                    { 34, 5, 2, "Physics" },
                    { 35, 5, 3, "Polish" },
                    { 36, 5, 4, "PE" },
                    { 37, 5, 5, "PE" },
                    { 38, 5, 6, "Geography" },
                    { 39, 5, 7, "PE" },
                    { 40, 5, 8, "History" },
                    { 41, 1, 1, "Chemistry" },
                    { 42, 1, 2, "PE" },
                    { 43, 1, 3, "Polish" },
                    { 44, 1, 4, "Physics" },
                    { 45, 1, 5, "Chemistry" },
                    { 46, 1, 6, "Math" },
                    { 47, 1, 7, "Physics" },
                    { 48, 1, 8, "Math" },
                    { 49, 2, 1, "Physics" },
                    { 50, 2, 2, "Geography" },
                    { 51, 2, 3, "Chemistry" },
                    { 52, 2, 4, "English" },
                    { 53, 2, 5, "English" },
                    { 54, 2, 6, "English" },
                    { 55, 2, 7, "History" },
                    { 56, 2, 8, "Chemistry" },
                    { 57, 3, 1, "Math" },
                    { 58, 3, 2, "Chemistry" },
                    { 59, 3, 3, "Math" },
                    { 60, 3, 4, "PE" },
                    { 61, 3, 5, "English" },
                    { 62, 3, 6, "English" },
                    { 63, 3, 7, "History" },
                    { 64, 3, 8, "Math" },
                    { 65, 4, 1, "Chemistry" },
                    { 66, 4, 2, "Polish" },
                    { 67, 4, 3, "Math" },
                    { 68, 4, 4, "Math" },
                    { 69, 4, 5, "Physics" },
                    { 70, 4, 6, "PE" },
                    { 71, 4, 7, "PE" },
                    { 72, 4, 8, "Chemistry" },
                    { 73, 5, 1, "Polish" },
                    { 74, 5, 2, "Polish" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 75, 5, 3, "History" },
                    { 76, 5, 4, "Math" },
                    { 77, 5, 5, "History" },
                    { 78, 5, 6, "Geography" },
                    { 79, 5, 7, "Physics" },
                    { 80, 5, 8, "PE" },
                    { 81, 1, 1, "Physics" },
                    { 82, 1, 2, "Chemistry" },
                    { 83, 1, 3, "PE" },
                    { 84, 1, 4, "History" },
                    { 85, 1, 5, "English" },
                    { 86, 1, 6, "Physics" },
                    { 87, 1, 7, "PE" },
                    { 88, 1, 8, "Physics" },
                    { 89, 2, 1, "PE" },
                    { 90, 2, 2, "History" },
                    { 91, 2, 3, "Chemistry" },
                    { 92, 2, 4, "History" },
                    { 93, 2, 5, "Polish" },
                    { 94, 2, 6, "History" },
                    { 95, 2, 7, "PE" },
                    { 96, 2, 8, "Geography" },
                    { 97, 3, 1, "PE" },
                    { 98, 3, 2, "Geography" },
                    { 99, 3, 3, "PE" },
                    { 100, 3, 4, "PE" },
                    { 101, 3, 5, "Physics" },
                    { 102, 3, 6, "Physics" },
                    { 103, 3, 7, "Geography" },
                    { 104, 3, 8, "Chemistry" },
                    { 105, 4, 1, "Chemistry" },
                    { 106, 4, 2, "Geography" },
                    { 107, 4, 3, "Math" },
                    { 108, 4, 4, "Physics" },
                    { 109, 4, 5, "Chemistry" },
                    { 110, 4, 6, "Chemistry" },
                    { 111, 4, 7, "Polish" },
                    { 112, 4, 8, "PE" },
                    { 113, 5, 1, "Geography" },
                    { 114, 5, 2, "English" },
                    { 115, 5, 3, "PE" },
                    { 116, 5, 4, "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 117, 5, 5, "Geography" },
                    { 118, 5, 6, "Polish" },
                    { 119, 5, 7, "Polish" },
                    { 120, 5, 8, "Geography" },
                    { 121, 1, 1, "PE" },
                    { 122, 1, 2, "History" },
                    { 123, 1, 3, "English" },
                    { 124, 1, 4, "Geography" },
                    { 125, 1, 5, "Physics" },
                    { 126, 1, 6, "Polish" },
                    { 127, 1, 7, "Math" },
                    { 128, 1, 8, "Physics" },
                    { 129, 2, 1, "Math" },
                    { 130, 2, 2, "Physics" },
                    { 131, 2, 3, "History" },
                    { 132, 2, 4, "Chemistry" },
                    { 133, 2, 5, "English" },
                    { 134, 2, 6, "Chemistry" },
                    { 135, 2, 7, "Geography" },
                    { 136, 2, 8, "PE" },
                    { 137, 3, 1, "Math" },
                    { 138, 3, 2, "History" },
                    { 139, 3, 3, "Math" },
                    { 140, 3, 4, "Geography" },
                    { 141, 3, 5, "Polish" },
                    { 142, 3, 6, "Polish" },
                    { 143, 3, 7, "English" },
                    { 144, 3, 8, "Chemistry" },
                    { 145, 4, 1, "History" },
                    { 146, 4, 2, "Chemistry" },
                    { 147, 4, 3, "PE" },
                    { 148, 4, 4, "English" },
                    { 149, 4, 5, "PE" },
                    { 150, 4, 6, "Physics" },
                    { 151, 4, 7, "History" },
                    { 152, 4, 8, "History" },
                    { 153, 5, 1, "English" },
                    { 154, 5, 2, "Math" },
                    { 155, 5, 3, "Physics" },
                    { 156, 5, 4, "Math" },
                    { 157, 5, 5, "Polish" },
                    { 158, 5, 6, "History" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 159, 5, 7, "PE" },
                    { 160, 5, 8, "History" },
                    { 161, 1, 1, "English" },
                    { 162, 1, 2, "Physics" },
                    { 163, 1, 3, "Chemistry" },
                    { 164, 1, 4, "Geography" },
                    { 165, 1, 5, "History" },
                    { 166, 1, 6, "Polish" },
                    { 167, 1, 7, "Math" },
                    { 168, 1, 8, "PE" },
                    { 169, 2, 1, "PE" },
                    { 170, 2, 2, "Math" },
                    { 171, 2, 3, "Geography" },
                    { 172, 2, 4, "English" },
                    { 173, 2, 5, "PE" },
                    { 174, 2, 6, "Geography" },
                    { 175, 2, 7, "PE" },
                    { 176, 2, 8, "English" },
                    { 177, 3, 1, "Math" },
                    { 178, 3, 2, "Math" },
                    { 179, 3, 3, "Geography" },
                    { 180, 3, 4, "Physics" },
                    { 181, 3, 5, "Physics" },
                    { 182, 3, 6, "Chemistry" },
                    { 183, 3, 7, "Physics" },
                    { 184, 3, 8, "History" },
                    { 185, 4, 1, "English" },
                    { 186, 4, 2, "History" },
                    { 187, 4, 3, "Physics" },
                    { 188, 4, 4, "Physics" },
                    { 189, 4, 5, "History" },
                    { 190, 4, 6, "Math" },
                    { 191, 4, 7, "Chemistry" },
                    { 192, 4, 8, "Physics" },
                    { 193, 5, 1, "Physics" },
                    { 194, 5, 2, "English" },
                    { 195, 5, 3, "Polish" },
                    { 196, 5, 4, "Polish" },
                    { 197, 5, 5, "History" },
                    { 198, 5, 6, "Polish" },
                    { 199, 5, 7, "History" },
                    { 200, 5, 8, "History" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 201, 1, 1, "Math" },
                    { 202, 1, 2, "Math" },
                    { 203, 1, 3, "Physics" },
                    { 204, 1, 4, "PE" },
                    { 205, 1, 5, "Physics" },
                    { 206, 1, 6, "Chemistry" },
                    { 207, 1, 7, "Geography" },
                    { 208, 1, 8, "Math" },
                    { 209, 2, 1, "History" },
                    { 210, 2, 2, "Polish" },
                    { 211, 2, 3, "Chemistry" },
                    { 212, 2, 4, "Polish" },
                    { 213, 2, 5, "History" },
                    { 214, 2, 6, "Math" },
                    { 215, 2, 7, "Math" },
                    { 216, 2, 8, "Math" },
                    { 217, 3, 1, "Math" },
                    { 218, 3, 2, "Polish" },
                    { 219, 3, 3, "Chemistry" },
                    { 220, 3, 4, "Polish" },
                    { 221, 3, 5, "PE" },
                    { 222, 3, 6, "Math" },
                    { 223, 3, 7, "PE" },
                    { 224, 3, 8, "PE" },
                    { 225, 4, 1, "Math" },
                    { 226, 4, 2, "Polish" },
                    { 227, 4, 3, "Math" },
                    { 228, 4, 4, "English" },
                    { 229, 4, 5, "Physics" },
                    { 230, 4, 6, "History" },
                    { 231, 4, 7, "Geography" },
                    { 232, 4, 8, "Physics" },
                    { 233, 5, 1, "English" },
                    { 234, 5, 2, "Geography" },
                    { 235, 5, 3, "English" },
                    { 236, 5, 4, "PE" },
                    { 237, 5, 5, "Physics" },
                    { 238, 5, 6, "Geography" },
                    { 239, 5, 7, "PE" },
                    { 240, 5, 8, "Geography" },
                    { 241, 1, 1, "Geography" },
                    { 242, 1, 2, "English" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 243, 1, 3, "PE" },
                    { 244, 1, 4, "Chemistry" },
                    { 245, 1, 5, "History" },
                    { 246, 1, 6, "Math" },
                    { 247, 1, 7, "PE" },
                    { 248, 1, 8, "Math" },
                    { 249, 2, 1, "English" },
                    { 250, 2, 2, "Chemistry" },
                    { 251, 2, 3, "English" },
                    { 252, 2, 4, "History" },
                    { 253, 2, 5, "Physics" },
                    { 254, 2, 6, "Chemistry" },
                    { 255, 2, 7, "Geography" },
                    { 256, 2, 8, "Polish" },
                    { 257, 3, 1, "PE" },
                    { 258, 3, 2, "Geography" },
                    { 259, 3, 3, "Physics" },
                    { 260, 3, 4, "Math" },
                    { 261, 3, 5, "PE" },
                    { 262, 3, 6, "Math" },
                    { 263, 3, 7, "Physics" },
                    { 264, 3, 8, "Physics" },
                    { 265, 4, 1, "Geography" },
                    { 266, 4, 2, "Chemistry" },
                    { 267, 4, 3, "English" },
                    { 268, 4, 4, "Geography" },
                    { 269, 4, 5, "Math" },
                    { 270, 4, 6, "Math" },
                    { 271, 4, 7, "PE" },
                    { 272, 4, 8, "Polish" },
                    { 273, 5, 1, "Chemistry" },
                    { 274, 5, 2, "History" },
                    { 275, 5, 3, "PE" },
                    { 276, 5, 4, "History" },
                    { 277, 5, 5, "Math" },
                    { 278, 5, 6, "Geography" },
                    { 279, 5, 7, "Polish" },
                    { 280, 5, 8, "Physics" },
                    { 281, 1, 1, "History" },
                    { 282, 1, 2, "Physics" },
                    { 283, 1, 3, "Physics" },
                    { 284, 1, 4, "Geography" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 285, 1, 5, "English" },
                    { 286, 1, 6, "Geography" },
                    { 287, 1, 7, "Polish" },
                    { 288, 1, 8, "History" },
                    { 289, 2, 1, "Geography" },
                    { 290, 2, 2, "Polish" },
                    { 291, 2, 3, "History" },
                    { 292, 2, 4, "History" },
                    { 293, 2, 5, "History" },
                    { 294, 2, 6, "English" },
                    { 295, 2, 7, "Chemistry" },
                    { 296, 2, 8, "Chemistry" },
                    { 297, 3, 1, "Chemistry" },
                    { 298, 3, 2, "Geography" },
                    { 299, 3, 3, "Physics" },
                    { 300, 3, 4, "Chemistry" },
                    { 301, 3, 5, "Math" },
                    { 302, 3, 6, "Physics" },
                    { 303, 3, 7, "Physics" },
                    { 304, 3, 8, "Geography" },
                    { 305, 4, 1, "Geography" },
                    { 306, 4, 2, "Chemistry" },
                    { 307, 4, 3, "History" },
                    { 308, 4, 4, "English" },
                    { 309, 4, 5, "Math" },
                    { 310, 4, 6, "PE" },
                    { 311, 4, 7, "PE" },
                    { 312, 4, 8, "PE" },
                    { 313, 5, 1, "Geography" },
                    { 314, 5, 2, "PE" },
                    { 315, 5, 3, "Physics" },
                    { 316, 5, 4, "Math" },
                    { 317, 5, 5, "Physics" },
                    { 318, 5, 6, "Geography" },
                    { 319, 5, 7, "History" },
                    { 320, 5, 8, "Math" },
                    { 321, 1, 1, "Math" },
                    { 322, 1, 2, "PE" },
                    { 323, 1, 3, "PE" },
                    { 324, 1, 4, "Math" },
                    { 325, 1, 5, "Chemistry" },
                    { 326, 1, 6, "English" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 327, 1, 7, "Math" },
                    { 328, 1, 8, "Math" },
                    { 329, 2, 1, "Geography" },
                    { 330, 2, 2, "PE" },
                    { 331, 2, 3, "PE" },
                    { 332, 2, 4, "English" },
                    { 333, 2, 5, "Physics" },
                    { 334, 2, 6, "English" },
                    { 335, 2, 7, "PE" },
                    { 336, 2, 8, "Geography" },
                    { 337, 3, 1, "Math" },
                    { 338, 3, 2, "Math" },
                    { 339, 3, 3, "Math" },
                    { 340, 3, 4, "Polish" },
                    { 341, 3, 5, "Chemistry" },
                    { 342, 3, 6, "Math" },
                    { 343, 3, 7, "Geography" },
                    { 344, 3, 8, "English" },
                    { 345, 4, 1, "Chemistry" },
                    { 346, 4, 2, "Polish" },
                    { 347, 4, 3, "Chemistry" },
                    { 348, 4, 4, "English" },
                    { 349, 4, 5, "Math" },
                    { 350, 4, 6, "History" },
                    { 351, 4, 7, "Polish" },
                    { 352, 4, 8, "History" },
                    { 353, 5, 1, "Geography" },
                    { 354, 5, 2, "English" },
                    { 355, 5, 3, "Math" },
                    { 356, 5, 4, "Chemistry" },
                    { 357, 5, 5, "Math" },
                    { 358, 5, 6, "Geography" },
                    { 359, 5, 7, "English" },
                    { 360, 5, 8, "Polish" },
                    { 361, 1, 1, "PE" },
                    { 362, 1, 2, "English" },
                    { 363, 1, 3, "Math" },
                    { 364, 1, 4, "Physics" },
                    { 365, 1, 5, "English" },
                    { 366, 1, 6, "PE" },
                    { 367, 1, 7, "Math" },
                    { 368, 1, 8, "PE" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 369, 2, 1, "Chemistry" },
                    { 370, 2, 2, "Physics" },
                    { 371, 2, 3, "Physics" },
                    { 372, 2, 4, "Chemistry" },
                    { 373, 2, 5, "PE" },
                    { 374, 2, 6, "Chemistry" },
                    { 375, 2, 7, "Math" },
                    { 376, 2, 8, "English" },
                    { 377, 3, 1, "Physics" },
                    { 378, 3, 2, "PE" },
                    { 379, 3, 3, "Chemistry" },
                    { 380, 3, 4, "Math" },
                    { 381, 3, 5, "Polish" },
                    { 382, 3, 6, "Math" },
                    { 383, 3, 7, "Geography" },
                    { 384, 3, 8, "History" },
                    { 385, 4, 1, "Geography" },
                    { 386, 4, 2, "Geography" },
                    { 387, 4, 3, "History" },
                    { 388, 4, 4, "History" },
                    { 389, 4, 5, "History" },
                    { 390, 4, 6, "History" },
                    { 391, 4, 7, "English" },
                    { 392, 4, 8, "English" },
                    { 393, 5, 1, "Chemistry" },
                    { 394, 5, 2, "Geography" },
                    { 395, 5, 3, "PE" },
                    { 396, 5, 4, "English" },
                    { 397, 5, 5, "History" },
                    { 398, 5, 6, "Polish" },
                    { 399, 5, 7, "English" },
                    { 400, 5, 8, "PE" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Raquel_Johnston@yahoo.com", "Raquel", "Johnston", "625-304-6441 x5763" },
                    { 2, "Sherri_Fisher47@hotmail.com", "Sherri", "Fisher", "350.644.7536 x71182" },
                    { 3, "Suzanne.Weber44@hotmail.com", "Suzanne", "Weber", "1-317-859-0429 x22101" },
                    { 4, "Beulah_Sporer93@hotmail.com", "Beulah", "Sporer", "435-519-6015 x865" },
                    { 5, "Dan.Lesch91@gmail.com", "Dan", "Lesch", "(305) 613-7502 x177" },
                    { 6, "May.Barrows@hotmail.com", "May", "Barrows", "292-660-7621" },
                    { 7, "Tina62@yahoo.com", "Tina", "Fisher", "(612) 326-3062" },
                    { 8, "Ronnie74@hotmail.com", "Ronnie", "Zboncak", "976-634-6686" },
                    { 9, "Ora.Nicolas90@yahoo.com", "Ora", "Nicolas", "617.687.6399 x759" },
                    { 10, "Angelina.Muller@yahoo.com", "Angelina", "Muller", "392.396.7345 x9788" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 11, "Sheryl_Zboncak13@hotmail.com", "Sheryl", "Zboncak", "(375) 864-3200 x5921" },
                    { 12, "Charles.Abbott22@hotmail.com", "Charles", "Abbott", "(972) 765-9936" },
                    { 13, "Jessie_Parisian86@gmail.com", "Jessie", "Parisian", "401.256.3967 x88375" },
                    { 14, "Clara85@hotmail.com", "Clara", "Jacobs", "604-223-6668" },
                    { 15, "Alejandro53@hotmail.com", "Alejandro", "Ullrich", "(662) 218-6090 x9465" },
                    { 16, "Terry_Kuvalis@gmail.com", "Terry", "Kuvalis", "(484) 670-9025 x04913" },
                    { 17, "Drew.DuBuque58@hotmail.com", "Drew", "DuBuque", "1-494-632-7940 x3327" },
                    { 18, "Bernard.Moore@yahoo.com", "Bernard", "Moore", "535-858-2530" },
                    { 19, "Larry4@gmail.com", "Larry", "Gaylord", "(356) 751-9412" },
                    { 20, "Pam85@hotmail.com", "Pam", "Reinger", "1-670-755-1928 x316" },
                    { 21, "Verna.Considine@yahoo.com", "Verna", "Considine", "(924) 767-9591 x7861" },
                    { 22, "Antonia62@hotmail.com", "Antonia", "Smitham", "(927) 417-0395" },
                    { 23, "Daisy.Bauch@hotmail.com", "Daisy", "Bauch", "1-561-829-5065 x0485" },
                    { 24, "Margaret.Robel@gmail.com", "Margaret", "Robel", "(984) 937-7830" },
                    { 25, "Lana24@hotmail.com", "Lana", "Mante", "1-440-899-2263 x16598" },
                    { 26, "Luther.Hartmann84@gmail.com", "Luther", "Hartmann", "708-536-6799 x50593" },
                    { 27, "Fredrick.Jones22@yahoo.com", "Fredrick", "Jones", "775.271.6535 x801" },
                    { 28, "Katrina.Collins79@yahoo.com", "Katrina", "Collins", "(427) 586-0006 x349" },
                    { 29, "Kerry_Lueilwitz59@gmail.com", "Kerry", "Lueilwitz", "(718) 829-2870" },
                    { 30, "Eduardo_Schinner@yahoo.com", "Eduardo", "Schinner", "305.238.4222 x33470" },
                    { 31, "Christopher.Simonis84@hotmail.com", "Christopher", "Simonis", "(758) 847-8629 x937" },
                    { 32, "Erin29@gmail.com", "Erin", "Stokes", "1-334-236-2388" },
                    { 33, "Brett_Schmidt64@gmail.com", "Brett", "Schmidt", "(281) 479-8300" },
                    { 34, "Dianne.Grimes@yahoo.com", "Dianne", "Grimes", "1-617-297-2955" },
                    { 35, "Marta87@yahoo.com", "Marta", "Wyman", "1-546-703-1176 x04074" },
                    { 36, "Terence16@gmail.com", "Terence", "Quitzon", "473-766-9545 x64921" },
                    { 37, "Denise.Gusikowski44@gmail.com", "Denise", "Gusikowski", "549-274-6644 x4058" },
                    { 38, "Gustavo.Effertz@hotmail.com", "Gustavo", "Effertz", "664.933.4822" },
                    { 39, "Gretchen.Corwin@hotmail.com", "Gretchen", "Corwin", "817-329-9376 x460" },
                    { 40, "Darlene.Wolf89@yahoo.com", "Darlene", "Wolf", "1-878-262-9453 x70356" },
                    { 41, "Bernice95@gmail.com", "Bernice", "Upton", "619.420.8870 x424" },
                    { 42, "Cornelius.Kerluke@gmail.com", "Cornelius", "Kerluke", "202-736-2328 x97594" },
                    { 43, "Tasha96@gmail.com", "Tasha", "Lesch", "1-975-900-8181 x99021" },
                    { 44, "Shannon.OConner54@hotmail.com", "Shannon", "O'Conner", "835.491.2995" },
                    { 45, "Harvey_Ernser@hotmail.com", "Harvey", "Ernser", "333-913-9245" },
                    { 46, "Keith_Rempel@yahoo.com", "Keith", "Rempel", "419.899.0792 x1172" },
                    { 47, "Kate.Cruickshank44@gmail.com", "Kate", "Cruickshank", "873.306.4932 x9989" },
                    { 48, "Neil.Turcotte3@gmail.com", "Neil", "Turcotte", "943.800.3908 x43182" },
                    { 49, "Spencer23@yahoo.com", "Spencer", "Corkery", "(518) 518-3920 x816" },
                    { 50, "Ellen80@gmail.com", "Ellen", "Schneider", "(387) 837-6597 x23236" },
                    { 51, "Kristopher21@gmail.com", "Kristopher", "Rodriguez", "371.888.3380 x13682" },
                    { 52, "Miriam_Gutmann68@hotmail.com", "Miriam", "Gutmann", "(577) 773-3924 x02663" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 53, "Pedro82@gmail.com", "Pedro", "Raynor", "559.859.3065" },
                    { 54, "Benny_Osinski@hotmail.com", "Benny", "Osinski", "1-784-538-2684 x424" },
                    { 55, "Florence.Wiegand37@gmail.com", "Florence", "Wiegand", "(470) 674-3690" },
                    { 56, "Lynne.Hodkiewicz64@hotmail.com", "Lynne", "Hodkiewicz", "616.907.4536 x833" },
                    { 57, "Kathy.OHara@yahoo.com", "Kathy", "O'Hara", "1-584-966-8950 x227" },
                    { 58, "Christian36@yahoo.com", "Christian", "Hayes", "823-716-7179 x6327" },
                    { 59, "Arturo_Kuhic10@gmail.com", "Arturo", "Kuhic", "644.942.6753 x4247" },
                    { 60, "Claude.Stehr@hotmail.com", "Claude", "Stehr", "(568) 719-5132" },
                    { 61, "Julie_Ebert@gmail.com", "Julie", "Ebert", "(430) 263-1920" },
                    { 62, "Kristin_Hudson@yahoo.com", "Kristin", "Hudson", "323-787-9040 x20324" },
                    { 63, "Lena31@yahoo.com", "Lena", "Adams", "373.436.4512 x40314" },
                    { 64, "Marty.Kris28@yahoo.com", "Marty", "Kris", "1-704-985-1750" },
                    { 65, "Timothy5@hotmail.com", "Timothy", "Hilll", "(304) 576-7317" },
                    { 66, "Erik8@hotmail.com", "Erik", "Reichert", "587-600-7787 x0884" },
                    { 67, "Freddie65@hotmail.com", "Freddie", "Fahey", "1-950-487-9729 x774" },
                    { 68, "Gayle_Daugherty73@yahoo.com", "Gayle", "Daugherty", "(897) 877-6678" },
                    { 69, "Wade.Senger@hotmail.com", "Wade", "Senger", "608-430-2251" },
                    { 70, "Mable89@yahoo.com", "Mable", "Ryan", "1-622-428-4850 x92493" },
                    { 71, "Marguerite92@yahoo.com", "Marguerite", "Feil", "1-212-536-1679 x74276" },
                    { 72, "Tiffany_Waters@hotmail.com", "Tiffany", "Waters", "(977) 511-6646" },
                    { 73, "Nettie_Robel@hotmail.com", "Nettie", "Robel", "444-980-4811" },
                    { 74, "Flora7@gmail.com", "Flora", "Von", "1-686-248-6350" },
                    { 75, "Taylor.Weissnat@hotmail.com", "Taylor", "Weissnat", "737-243-2569 x4520" },
                    { 76, "Rudolph.Lowe@hotmail.com", "Rudolph", "Lowe", "1-750-767-6364 x129" },
                    { 77, "Ellis_Stoltenberg@gmail.com", "Ellis", "Stoltenberg", "506-792-3120 x5586" },
                    { 78, "Vicki_Keebler86@hotmail.com", "Vicki", "Keebler", "997-929-1011 x549" },
                    { 79, "Claudia7@hotmail.com", "Claudia", "Gulgowski", "544.931.8429 x1545" },
                    { 80, "Candace46@gmail.com", "Candace", "Simonis", "1-507-601-3932" },
                    { 81, "Jerome.Reynolds21@gmail.com", "Jerome", "Reynolds", "(601) 823-1452 x29793" },
                    { 82, "Gwendolyn_Nader54@hotmail.com", "Gwendolyn", "Nader", "(382) 595-4775" },
                    { 83, "Craig_Homenick59@hotmail.com", "Craig", "Homenick", "580-952-2399 x97350" },
                    { 84, "Rosemary_Glover@gmail.com", "Rosemary", "Glover", "1-533-714-1018 x6611" },
                    { 85, "Warren.Windler56@hotmail.com", "Warren", "Windler", "751-714-6594" },
                    { 86, "Shane_Mitchell@gmail.com", "Shane", "Mitchell", "454-599-9700 x73951" },
                    { 87, "Shannon65@gmail.com", "Shannon", "Fritsch", "419.947.4790" },
                    { 88, "Lionel.Flatley@hotmail.com", "Lionel", "Flatley", "650.624.6507 x3671" },
                    { 89, "Gayle_Ferry94@gmail.com", "Gayle", "Ferry", "650.541.5290" },
                    { 90, "Ricardo_Christiansen@gmail.com", "Ricardo", "Christiansen", "(681) 940-0220" },
                    { 91, "Antonio94@gmail.com", "Antonio", "Fritsch", "1-926-934-2627 x18974" },
                    { 92, "Bonnie.Gaylord@yahoo.com", "Bonnie", "Gaylord", "696.368.7789 x48870" },
                    { 93, "Leslie_Gerhold@yahoo.com", "Leslie", "Gerhold", "227-381-1407 x64962" },
                    { 94, "Cedric46@gmail.com", "Cedric", "Rohan", "(353) 457-1628" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 95, "Garry_MacGyver@yahoo.com", "Garry", "MacGyver", "844-439-2271 x68778" },
                    { 96, "Elias.Huels@gmail.com", "Elias", "Huels", "949.367.6938 x324" },
                    { 97, "Ashley_Koepp80@yahoo.com", "Ashley", "Koepp", "774-720-2729" },
                    { 98, "Mack.Olson2@hotmail.com", "Mack", "Olson", "488.436.8010 x07529" },
                    { 99, "Santiago_Langworth17@hotmail.com", "Santiago", "Langworth", "1-379-448-7297 x39106" },
                    { 100, "Paulette.Hackett79@gmail.com", "Paulette", "Hackett", "466.375.0180 x632" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("06178512-2290-41dd-9f03-713f43b89f48"), "Arizona", "North Halle", "Lewis_Cummerata@yahoo.com", "Lewis", "Cummerata", "", "564-909-5436", "21545" },
                    { new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), "Hawaii", "Kellifort", "Maxine.West15@yahoo.com", "Maxine", "West", "", "1-281-233-7805 x13024", "04474" },
                    { new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), "Montana", "Farrellville", "Clay_OHara94@gmail.com", "Clay", "O'Hara", "", "1-984-866-2075", "67458" },
                    { new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), "New Jersey", "New Kacie", "Ellis_Hilpert@gmail.com", "Ellis", "Hilpert", "", "318.705.3910", "05084-1675" },
                    { new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), "Utah", "East Jaylinville", "Estelle16@yahoo.com", "Estelle", "Ledner", "", "749.960.1796", "05880" },
                    { new Guid("1282556b-d71b-40f9-be66-a22236c75262"), "North Carolina", "Reichertport", "Grace_Romaguera@hotmail.com", "Grace", "Romaguera", "", "762.306.0777 x638", "80207-4143" },
                    { new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), "Maine", "Gerholdberg", "Emily_Fritsch@gmail.com", "Emily", "Fritsch", "", "(357) 413-3814 x505", "44830" },
                    { new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), "Louisiana", "Georgeview", "Rachael94@yahoo.com", "Rachael", "Zulauf", "", "1-484-278-5928 x3035", "65483" },
                    { new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), "Kansas", "Lake Ozella", "Wilbert50@gmail.com", "Wilbert", "Gibson", "", "324-368-7255 x76834", "71972" },
                    { new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), "Wyoming", "West Keshaun", "Raquel20@gmail.com", "Raquel", "Bogan", "", "(292) 603-6209", "42312" },
                    { new Guid("24021955-aa0d-49ca-92b9-01561f491967"), "Nevada", "South Kaneside", "Rogelio48@yahoo.com", "Rogelio", "Bernhard", "", "239-704-3918 x7594", "00212-6435" },
                    { new Guid("24e50499-d459-4100-82b1-626f4a825561"), "Idaho", "Jerdetown", "Jenna39@yahoo.com", "Jenna", "Fay", "", "(268) 862-0886", "76074" },
                    { new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), "Vermont", "Beulahhaven", "Alma.Reilly@gmail.com", "Alma", "Reilly", "", "937-854-3073 x000", "16099-3327" },
                    { new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), "California", "Kleinfort", "Gayle_Hansen@hotmail.com", "Gayle", "Hansen", "", "(971) 447-8829 x4931", "25860" },
                    { new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), "Tennessee", "Friesenview", "Steve32@yahoo.com", "Steve", "Mraz", "", "218.425.1506 x8807", "18122" },
                    { new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), "Massachusetts", "Sengerborough", "Andres17@hotmail.com", "Andres", "Kuvalis", "", "(705) 293-2038 x5402", "92797-4925" },
                    { new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), "Minnesota", "South Waylonville", "Grady99@yahoo.com", "Grady", "Fritsch", "", "1-710-886-8485 x51034", "67492" },
                    { new Guid("32151eef-e041-48a1-880a-5974d14ee349"), "Nebraska", "Gradyville", "Sandra_Mante91@yahoo.com", "Sandra", "Mante", "", "713-289-7980 x6810", "69853-5274" },
                    { new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), "West Virginia", "Andrewstad", "Felicia.Schuster@hotmail.com", "Felicia", "Schuster", "", "(521) 866-6237", "42608-7614" },
                    { new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), "Alabama", "North Wellingtonfurt", "Tabitha_Gislason@gmail.com", "Tabitha", "Gislason", "", "435-879-4004", "93139" },
                    { new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), "Missouri", "Lake Eulaliaton", "Dwight.Homenick@yahoo.com", "Dwight", "Homenick", "", "1-898-697-0693 x8386", "01550-5921" },
                    { new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), "Missouri", "East Anika", "Ramiro.Lindgren@yahoo.com", "Ramiro", "Lindgren", "", "828.338.4975 x90234", "97837-6633" },
                    { new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), "Nebraska", "Braunmouth", "Cristina.Dooley6@gmail.com", "Cristina", "Dooley", "", "1-270-375-2004 x87319", "36969" },
                    { new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), "Wisconsin", "Yvonnetown", "Darla.Reichel@yahoo.com", "Darla", "Reichel", "", "1-328-702-0897 x92329", "74279" },
                    { new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), "New Hampshire", "South Clarabelleton", "Joanna.Streich@gmail.com", "Joanna", "Streich", "", "1-600-206-1420 x8450", "34215" },
                    { new Guid("499537bf-f642-4d94-91f0-234236984b79"), "New York", "West Jess", "Harvey.MacGyver@yahoo.com", "Harvey", "MacGyver", "", "870-852-8992 x8535", "55103" },
                    { new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), "Missouri", "South Amos", "Verna_Bahringer@yahoo.com", "Verna", "Bahringer", "", "557.875.1187", "76606" },
                    { new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), "Connecticut", "Nienowmouth", "Sherri.Kuvalis31@gmail.com", "Sherri", "Kuvalis", "", "330-230-6450 x2427", "28156" },
                    { new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), "Wisconsin", "Adalinefort", "Roderick.Waters92@gmail.com", "Roderick", "Waters", "", "1-830-251-5992", "83801" },
                    { new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), "Missouri", "Lake August", "Claude_Reynolds35@gmail.com", "Claude", "Reynolds", "", "(403) 788-2209", "39613" },
                    { new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), "Connecticut", "Tomview", "Arturo_Becker@yahoo.com", "Arturo", "Becker", "", "389.925.7138 x657", "71267" },
                    { new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), "Iowa", "West Delphahaven", "Santos.Wintheiser@hotmail.com", "Santos", "Wintheiser", "", "(977) 620-7355", "00288-4936" },
                    { new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), "Michigan", "Baronmouth", "Lillian_Terry@yahoo.com", "Lillian", "Terry", "", "278-612-8046 x05120", "28943" },
                    { new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), "Michigan", "West Kelleytown", "Jessie_Funk@hotmail.com", "Jessie", "Funk", "", "1-804-908-0841 x380", "13084" },
                    { new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), "Connecticut", "South Dewayne", "Darrel.Nikolaus@hotmail.com", "Darrel", "Nikolaus", "", "1-475-921-1221 x7571", "05863-7298" },
                    { new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), "Florida", "Nevaborough", "Ray_Feeney29@yahoo.com", "Ray", "Feeney", "", "233-419-5546 x8644", "57055-5119" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), "New Hampshire", "East Calista", "Suzanne36@gmail.com", "Suzanne", "Pfeffer", "", "746-356-8135 x14222", "77018" },
                    { new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), "Indiana", "North Bret", "Leslie69@gmail.com", "Leslie", "Gerlach", "", "1-236-427-1784 x6745", "02983" },
                    { new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), "Indiana", "South Jordyn", "Clifton.Price@hotmail.com", "Clifton", "Price", "", "566.976.7220", "41533" },
                    { new Guid("685df129-d237-414f-8e3d-c676e579dfda"), "Iowa", "East Chaya", "Charles_Block@yahoo.com", "Charles", "Block", "", "638.995.9448", "51475" },
                    { new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), "South Carolina", "West Nathanaelchester", "Shari_Green@gmail.com", "Shari", "Green", "", "(951) 606-9863 x4444", "19681" },
                    { new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), "Wyoming", "Spencerstad", "Jennie.Schulist32@gmail.com", "Jennie", "Schulist", "", "731-625-1167", "06963" },
                    { new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), "Connecticut", "West Lou", "Michelle_Ryan2@hotmail.com", "Michelle", "Ryan", "", "362.791.4824", "39180-6547" },
                    { new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), "Tennessee", "Mayerville", "Rosa.Dach@hotmail.com", "Rosa", "Dach", "", "575-608-2476 x787", "69657" },
                    { new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), "Massachusetts", "Port Candace", "Amber10@yahoo.com", "Amber", "Leuschke", "", "(833) 215-6991 x5703", "59135-4912" },
                    { new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), "Alabama", "Lake Tracemouth", "Virgil41@yahoo.com", "Virgil", "Ortiz", "", "(936) 666-0475 x997", "80868" },
                    { new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), "North Dakota", "Lake Armanifort", "Dorothy35@yahoo.com", "Dorothy", "Gusikowski", "", "1-302-299-6669 x09963", "39363-3881" },
                    { new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), "Pennsylvania", "East Audrabury", "Lucy.Hoeger@hotmail.com", "Lucy", "Hoeger", "", "1-699-537-3921", "97825-6295" },
                    { new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), "New Mexico", "Staceyborough", "Phil_Medhurst@gmail.com", "Phil", "Medhurst", "", "1-611-347-3180", "83839" },
                    { new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), "Michigan", "South Erna", "Terri.Schowalter43@hotmail.com", "Terri", "Schowalter", "", "325-818-6020 x95243", "60048" },
                    { new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), "Montana", "Lake Kaylin", "Tim66@hotmail.com", "Tim", "Bogan", "", "445.677.9320 x375", "82417-9516" },
                    { new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), "New Mexico", "Quitzonport", "Wesley55@gmail.com", "Wesley", "Braun", "", "(624) 368-4105", "59281" },
                    { new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), "Alabama", "Zolamouth", "Marshall.Hilpert@hotmail.com", "Marshall", "Hilpert", "", "1-781-819-0261", "71626-5809" },
                    { new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), "Indiana", "North Chad", "Percy97@hotmail.com", "Percy", "Koch", "", "844.389.1260 x48477", "12763-4809" },
                    { new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), "North Carolina", "Reichelside", "Kerry.Zboncak34@hotmail.com", "Kerry", "Zboncak", "", "677-304-8509 x18338", "40466-8786" },
                    { new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), "Washington", "West Denis", "Debra.Gutmann64@hotmail.com", "Debra", "Gutmann", "", "303-715-1264 x82942", "55248" },
                    { new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), "West Virginia", "New Isac", "Guillermo.Ernser@hotmail.com", "Guillermo", "Ernser", "", "(366) 826-6232", "06614-0316" },
                    { new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), "Pennsylvania", "New Kristopherside", "Linda_McLaughlin43@yahoo.com", "Linda", "McLaughlin", "", "1-383-353-9284 x6886", "54196-1560" },
                    { new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), "Oregon", "Port Neil", "Beatrice.Lehner@yahoo.com", "Beatrice", "Lehner", "", "524-611-4761 x66907", "69417-6650" },
                    { new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), "New Mexico", "East Harmon", "Hazel_Hodkiewicz@gmail.com", "Hazel", "Hodkiewicz", "", "415.428.7706 x63632", "33245-2812" },
                    { new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), "California", "Schuppechester", "Brian_Cormier98@yahoo.com", "Brian", "Cormier", "", "(504) 831-1144", "87564" },
                    { new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), "Virginia", "West Austinburgh", "Javier86@gmail.com", "Javier", "Bode", "", "(307) 926-0277", "86849-0857" },
                    { new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), "Vermont", "Heidenreichfurt", "Marty95@gmail.com", "Marty", "Klocko", "", "827-666-3941 x187", "06192-6814" },
                    { new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), "North Dakota", "Fabiolachester", "Virginia.Smith@yahoo.com", "Virginia", "Smith", "", "951.584.9561", "23346-9491" },
                    { new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), "Alaska", "Zelmafort", "Yvonne95@gmail.com", "Yvonne", "Kub", "", "1-336-524-8360", "95710-4445" },
                    { new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), "New Mexico", "Berthaville", "Kristopher_Legros@gmail.com", "Kristopher", "Legros", "", "337.943.8304 x4102", "66762-6710" },
                    { new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), "Louisiana", "Traceyland", "Ella.Luettgen@hotmail.com", "Ella", "Luettgen", "", "1-470-425-8235", "96526-1696" },
                    { new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), "Pennsylvania", "Murphystad", "Donna_Reilly16@gmail.com", "Donna", "Reilly", "", "875-876-4004", "77222-8539" },
                    { new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), "Nevada", "West Bennett", "Nettie_Leffler@hotmail.com", "Nettie", "Leffler", "", "1-638-942-4747", "58054" },
                    { new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), "Texas", "McDermottburgh", "Angelo80@hotmail.com", "Angelo", "Marks", "", "1-743-425-7238", "31252" },
                    { new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), "West Virginia", "South Valentina", "Martha48@yahoo.com", "Martha", "Schowalter", "", "805-652-3580 x37814", "48567" },
                    { new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), "Maine", "Lake Berneiceside", "Viola_Nicolas36@gmail.com", "Viola", "Nicolas", "", "230.981.9918", "11000-2307" },
                    { new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), "Louisiana", "Bethburgh", "Ramiro.Smitham@gmail.com", "Ramiro", "Smitham", "", "(657) 841-6173", "41928" },
                    { new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), "Mississippi", "Earlmouth", "Kristina.Friesen6@gmail.com", "Kristina", "Friesen", "", "(780) 762-1133 x6525", "26815" },
                    { new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), "New Jersey", "East Lavernebury", "Tonya.Jacobs@yahoo.com", "Tonya", "Jacobs", "", "590.537.8176 x935", "29000" },
                    { new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), "Connecticut", "New Alexandrine", "Dianna_Jacobs@hotmail.com", "Dianna", "Jacobs", "", "227-873-0619 x01091", "46574-5848" },
                    { new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), "Maryland", "North Deanmouth", "Enrique_Murphy@yahoo.com", "Enrique", "Murphy", "", "636-304-6208 x112", "20432-9962" },
                    { new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), "Alabama", "New Oceanefort", "Edmund_Armstrong92@yahoo.com", "Edmund", "Armstrong", "", "(259) 673-5069", "81277-5365" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), "Oklahoma", "North Evansstad", "Dexter.McGlynn@yahoo.com", "Dexter", "McGlynn", "", "370-312-5341 x62227", "13299-2585" },
                    { new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), "Illinois", "Karsonside", "Anna14@gmail.com", "Anna", "Lowe", "", "(775) 259-8214 x2600", "89618" },
                    { new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), "Ohio", "Seamusberg", "Don.MacGyver45@gmail.com", "Don", "MacGyver", "", "454.476.7144 x47416", "48253-1988" },
                    { new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), "Missouri", "East Wyattville", "Lorraine_Ratke15@yahoo.com", "Lorraine", "Ratke", "", "1-620-313-2905 x1791", "73796-5780" },
                    { new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), "Missouri", "East Gustavebury", "Catherine_Lowe30@yahoo.com", "Catherine", "Lowe", "", "834-495-1692 x824", "42722-5238" },
                    { new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), "Nevada", "Cartermouth", "Tami.Daniel25@yahoo.com", "Tami", "Daniel", "", "872.909.9616", "15430" },
                    { new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), "Oregon", "Dameonmouth", "Alexis.Brown80@hotmail.com", "Alexis", "Brown", "", "1-359-299-1649 x842", "08406-9070" },
                    { new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), "Rhode Island", "Stefantown", "Gwen8@gmail.com", "Gwen", "Auer", "", "700-336-4971 x2885", "46021" },
                    { new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), "Tennessee", "Hayleymouth", "Ed_Skiles84@hotmail.com", "Ed", "Skiles", "", "870-211-3102", "27916" },
                    { new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), "New Mexico", "East Cletaside", "Joshua_Weissnat@yahoo.com", "Joshua", "Weissnat", "", "1-216-923-2885", "16737-9628" },
                    { new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), "South Carolina", "South Eleanore", "Gail_Medhurst@hotmail.com", "Gail", "Medhurst", "", "(525) 297-5380", "82094" },
                    { new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), "Arizona", "North Cademouth", "Christina62@gmail.com", "Christina", "Trantow", "", "(299) 785-1135 x813", "11576-5436" },
                    { new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), "New Mexico", "Haagstad", "Lee14@yahoo.com", "Lee", "Hegmann", "", "1-526-857-0017 x1489", "70131-7235" },
                    { new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), "Wyoming", "Port Emma", "Sylvia.Stoltenberg53@yahoo.com", "Sylvia", "Stoltenberg", "", "916-263-2912 x71796", "69069" },
                    { new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), "New Jersey", "North Fayeville", "Doris96@hotmail.com", "Doris", "Hayes", "", "253-878-6090 x39595", "65612-8252" },
                    { new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), "Montana", "Kaitlinview", "Regina.Bruen29@gmail.com", "Regina", "Bruen", "", "713.308.6401 x8608", "25980" },
                    { new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), "Nebraska", "Erdmanland", "Herman.Lueilwitz@yahoo.com", "Herman", "Lueilwitz", "", "1-304-400-4324 x2825", "39880-4994" },
                    { new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), "Louisiana", "Ansleystad", "Bruce82@gmail.com", "Bruce", "Ebert", "", "874-652-9978", "25689" },
                    { new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), "New Jersey", "Bobbyfort", "Claude_Friesen52@yahoo.com", "Claude", "Friesen", "", "931.272.2264 x19843", "94227-9771" },
                    { new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), "Arizona", "North Arnechester", "Gretchen.Durgan17@yahoo.com", "Gretchen", "Durgan", "", "235.797.5997 x18557", "78732" },
                    { new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), "Arkansas", "South Calistaland", "Alejandro.OReilly45@yahoo.com", "Alejandro", "O'Reilly", "", "1-453-876-4152 x76303", "91033" },
                    { new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), "North Dakota", "Wiegandside", "Carl_Weber47@yahoo.com", "Carl", "Weber", "", "1-344-878-3891", "43536" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Mercedes84@yahoo.com", "Mercedes", false, "Okuneva", "(888) 889-7314 x50802" },
                    { 2, "Cora54@yahoo.com", "Cora", false, "Kessler", "(219) 465-7292 x02612" },
                    { 3, "Heather12@yahoo.com", "Heather", false, "Miller", "(609) 997-0985 x95847" },
                    { 4, "Walter_Powlowski@gmail.com", "Walter", false, "Powlowski", "(475) 669-0630 x2625" },
                    { 5, "Leona_Little@gmail.com", "Leona", false, "Little", "753.701.2945 x4229" },
                    { 6, "Silvia.Nienow56@hotmail.com", "Silvia", false, "Nienow", "(757) 513-7773" },
                    { 7, "Alexis_Koch95@gmail.com", "Alexis", false, "Koch", "(668) 385-2867 x395" },
                    { 8, "Jan.Bartoletti@yahoo.com", "Jan", false, "Bartoletti", "1-583-994-7394" },
                    { 9, "Jack_Hoeger@gmail.com", "Jack", false, "Hoeger", "(607) 262-6585" },
                    { 10, "Angelica_Kertzmann60@hotmail.com", "Angelica", false, "Kertzmann", "476.959.7531" },
                    { 11, "Linda_Gaylord29@gmail.com", "Linda", false, "Gaylord", "847-344-8947 x46876" },
                    { 12, "Russell_Klocko@gmail.com", "Russell", false, "Klocko", "333-614-2469" },
                    { 13, "Jeannette_Schmidt@gmail.com", "Jeannette", false, "Schmidt", "(632) 494-2771" },
                    { 14, "Jermaine_Waelchi97@yahoo.com", "Jermaine", false, "Waelchi", "1-949-740-3711 x73054" },
                    { 15, "Dexter_Borer12@gmail.com", "Dexter", false, "Borer", "338.708.5274" },
                    { 16, "Beatrice.Dibbert@hotmail.com", "Beatrice", false, "Dibbert", "(395) 793-2200 x267" },
                    { 17, "Nellie.Erdman@yahoo.com", "Nellie", false, "Erdman", "1-654-449-9462" },
                    { 18, "Sonja.Feil@hotmail.com", "Sonja", false, "Feil", "(682) 487-2549" },
                    { 19, "Claudia37@gmail.com", "Claudia", false, "Ward", "851.209.2262" }
                });

            migrationBuilder.InsertData(
                table: "Approve",
                columns: new[] { "ApproveID", "Description", "FK_UserUUID", "Positive" },
                values: new object[,]
                {
                    { 1, "", new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), true },
                    { 2, "", new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), false },
                    { 3, "", new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), true },
                    { 4, "", new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), false },
                    { 5, "", new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), false },
                    { 6, "", new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), true },
                    { 7, "", new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), true },
                    { 8, "", new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), true },
                    { 9, "", new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), false },
                    { 10, "", new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), false },
                    { 11, "", new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), false },
                    { 12, "", new Guid("24e50499-d459-4100-82b1-626f4a825561"), true },
                    { 13, "", new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), true },
                    { 14, "", new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), false },
                    { 15, "", new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), false },
                    { 16, "", new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), false },
                    { 17, "", new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), true },
                    { 18, "", new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), false },
                    { 19, "", new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), true },
                    { 20, "", new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), true },
                    { 21, "", new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), true },
                    { 22, "", new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), true },
                    { 23, "", new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), false },
                    { 24, "", new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), true },
                    { 25, "", new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), false },
                    { 26, "", new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), true },
                    { 27, "", new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), false },
                    { 28, "", new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), true },
                    { 29, "", new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), false },
                    { 30, "", new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), true }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 1, "", new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), 1, 1 },
                    { 2, "", new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), 6, 1 },
                    { 3, "", new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), 4, 1 },
                    { 4, "", new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), 5, 3 },
                    { 5, "", new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), 3, 1 },
                    { 6, "", new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), 4, 1 },
                    { 7, "", new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), 4, 2 },
                    { 8, "", new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), 5, 3 },
                    { 9, "", new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), 4, 3 },
                    { 10, "", new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), 1, 1 },
                    { 11, "", new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), 2, 1 },
                    { 12, "", new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 13, "", new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), 1, 1 },
                    { 14, "", new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), 6, 2 },
                    { 15, "", new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), 3, 3 },
                    { 16, "", new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), 5, 3 },
                    { 17, "", new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), 1, 3 },
                    { 18, "", new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), 6, 1 },
                    { 19, "", new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), 1, 3 },
                    { 20, "", new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), 4, 3 },
                    { 21, "", new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), 3, 2 },
                    { 22, "", new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), 5, 2 },
                    { 23, "", new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), 4, 2 },
                    { 24, "", new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), 4, 2 },
                    { 25, "", new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), 1, 3 },
                    { 26, "", new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), 5, 2 },
                    { 27, "", new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), 5, 1 },
                    { 28, "", new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), 6, 3 },
                    { 29, "", new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), 1, 3 },
                    { 30, "", new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), 2, 1 },
                    { 31, "", new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), 5, 1 },
                    { 32, "", new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), 6, 2 },
                    { 33, "", new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), 4, 1 },
                    { 34, "", new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), 6, 3 },
                    { 35, "", new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), 4, 1 },
                    { 36, "", new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), 1, 2 },
                    { 37, "", new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), 2, 1 },
                    { 38, "", new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), 5, 3 },
                    { 39, "", new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), 2, 2 },
                    { 40, "", new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), 2, 1 },
                    { 41, "", new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), 2, 2 },
                    { 42, "", new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), 5, 2 },
                    { 43, "", new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), 1, 1 },
                    { 44, "", new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), 1, 1 },
                    { 45, "", new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), 6, 3 },
                    { 46, "", new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), 3, 2 },
                    { 47, "", new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), 1, 2 },
                    { 48, "", new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), 1, 2 },
                    { 49, "", new Guid("24021955-aa0d-49ca-92b9-01561f491967"), 5, 1 },
                    { 50, "", new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), 1, 3 },
                    { 51, "", new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), 1, 3 },
                    { 52, "", new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), 2, 3 },
                    { 53, "", new Guid("1282556b-d71b-40f9-be66-a22236c75262"), 5, 3 },
                    { 54, "", new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 55, "", new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), 4, 2 },
                    { 56, "", new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), 3, 2 },
                    { 57, "", new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), 4, 3 },
                    { 58, "", new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), 2, 1 },
                    { 59, "", new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), 1, 2 },
                    { 60, "", new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), 1, 2 },
                    { 61, "", new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), 5, 2 },
                    { 62, "", new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), 5, 3 },
                    { 63, "", new Guid("24e50499-d459-4100-82b1-626f4a825561"), 1, 3 },
                    { 64, "", new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), 5, 2 },
                    { 65, "", new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), 3, 2 },
                    { 66, "", new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), 2, 2 },
                    { 67, "", new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), 6, 3 },
                    { 68, "", new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), 3, 2 },
                    { 69, "", new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), 4, 2 },
                    { 70, "", new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), 3, 3 },
                    { 71, "", new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), 3, 3 },
                    { 72, "", new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), 3, 3 },
                    { 73, "", new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), 3, 1 },
                    { 74, "", new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), 6, 2 },
                    { 75, "", new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), 6, 1 },
                    { 76, "", new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), 1, 1 },
                    { 77, "", new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), 2, 3 },
                    { 78, "", new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), 2, 3 },
                    { 79, "", new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), 6, 3 },
                    { 80, "", new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), 1, 2 },
                    { 81, "", new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), 4, 3 },
                    { 82, "", new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), 5, 3 },
                    { 83, "", new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), 6, 2 },
                    { 84, "", new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), 5, 1 },
                    { 85, "", new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), 5, 1 },
                    { 86, "", new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), 4, 2 },
                    { 87, "", new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), 3, 1 },
                    { 88, "", new Guid("685df129-d237-414f-8e3d-c676e579dfda"), 6, 3 },
                    { 89, "", new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), 4, 1 },
                    { 90, "", new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), 5, 3 },
                    { 91, "", new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), 2, 3 },
                    { 92, "", new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), 1, 3 },
                    { 93, "", new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), 6, 1 },
                    { 94, "", new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), 2, 2 },
                    { 95, "", new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), 3, 2 },
                    { 96, "", new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 97, "", new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), 3, 1 },
                    { 98, "", new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), 4, 3 },
                    { 99, "", new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), 2, 3 },
                    { 100, "", new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), 2, 1 },
                    { 101, "", new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), 1, 3 },
                    { 102, "", new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), 5, 2 },
                    { 103, "", new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), 5, 3 },
                    { 104, "", new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), 3, 3 },
                    { 105, "", new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), 4, 2 },
                    { 106, "", new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), 3, 3 },
                    { 107, "", new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), 6, 2 },
                    { 108, "", new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), 3, 3 },
                    { 109, "", new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), 3, 3 },
                    { 110, "", new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), 3, 1 },
                    { 111, "", new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), 4, 2 },
                    { 112, "", new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), 2, 1 },
                    { 113, "", new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), 2, 2 },
                    { 114, "", new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), 3, 1 },
                    { 115, "", new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), 1, 3 },
                    { 116, "", new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), 4, 1 },
                    { 117, "", new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), 6, 3 },
                    { 118, "", new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), 1, 2 },
                    { 119, "", new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), 1, 1 },
                    { 120, "", new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), 3, 1 },
                    { 121, "", new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), 3, 2 },
                    { 122, "", new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), 3, 3 },
                    { 123, "", new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), 3, 3 },
                    { 124, "", new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), 5, 1 },
                    { 125, "", new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), 5, 1 },
                    { 126, "", new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), 3, 1 },
                    { 127, "", new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), 2, 3 },
                    { 128, "", new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), 3, 2 },
                    { 129, "", new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), 4, 1 },
                    { 130, "", new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), 2, 1 },
                    { 131, "", new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), 4, 1 },
                    { 132, "", new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), 4, 3 },
                    { 133, "", new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), 4, 1 },
                    { 134, "", new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), 4, 2 },
                    { 135, "", new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), 5, 1 },
                    { 136, "", new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), 4, 2 },
                    { 137, "", new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), 4, 3 },
                    { 138, "", new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 139, "", new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), 3, 1 },
                    { 140, "", new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), 5, 3 },
                    { 141, "", new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), 4, 3 },
                    { 142, "", new Guid("32151eef-e041-48a1-880a-5974d14ee349"), 4, 3 },
                    { 143, "", new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), 2, 2 },
                    { 144, "", new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), 4, 2 },
                    { 145, "", new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), 3, 3 },
                    { 146, "", new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), 5, 3 },
                    { 147, "", new Guid("24e50499-d459-4100-82b1-626f4a825561"), 2, 1 },
                    { 148, "", new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), 5, 2 },
                    { 149, "", new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), 5, 1 },
                    { 150, "", new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), 5, 2 },
                    { 151, "", new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), 4, 1 },
                    { 152, "", new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), 5, 3 },
                    { 153, "", new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), 3, 1 },
                    { 154, "", new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), 4, 3 },
                    { 155, "", new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), 1, 2 },
                    { 156, "", new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), 3, 3 },
                    { 157, "", new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), 5, 1 },
                    { 158, "", new Guid("24021955-aa0d-49ca-92b9-01561f491967"), 4, 3 },
                    { 159, "", new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), 2, 2 },
                    { 160, "", new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), 5, 2 },
                    { 161, "", new Guid("06178512-2290-41dd-9f03-713f43b89f48"), 4, 1 },
                    { 162, "", new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), 5, 2 },
                    { 163, "", new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), 1, 1 },
                    { 164, "", new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), 2, 3 },
                    { 165, "", new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), 3, 3 },
                    { 166, "", new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), 6, 2 },
                    { 167, "", new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), 2, 3 },
                    { 168, "", new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), 2, 1 },
                    { 169, "", new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), 2, 2 },
                    { 170, "", new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), 4, 3 },
                    { 171, "", new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), 4, 3 },
                    { 172, "", new Guid("24e50499-d459-4100-82b1-626f4a825561"), 3, 3 },
                    { 173, "", new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), 1, 1 },
                    { 174, "", new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), 1, 3 },
                    { 175, "", new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), 5, 1 },
                    { 176, "", new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), 4, 1 },
                    { 177, "", new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), 5, 3 },
                    { 178, "", new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), 5, 1 },
                    { 179, "", new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), 2, 1 },
                    { 180, "", new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 181, "", new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), 1, 3 },
                    { 182, "", new Guid("499537bf-f642-4d94-91f0-234236984b79"), 1, 2 },
                    { 183, "", new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), 3, 3 },
                    { 184, "", new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), 2, 3 },
                    { 185, "", new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), 4, 1 },
                    { 186, "", new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), 3, 3 },
                    { 187, "", new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), 2, 1 },
                    { 188, "", new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), 1, 1 },
                    { 189, "", new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), 6, 3 },
                    { 190, "", new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), 3, 2 },
                    { 191, "", new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), 3, 1 },
                    { 192, "", new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), 6, 1 },
                    { 193, "", new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), 5, 2 },
                    { 194, "", new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), 1, 2 },
                    { 195, "", new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), 2, 3 },
                    { 196, "", new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), 5, 3 },
                    { 197, "", new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), 4, 2 },
                    { 198, "", new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), 1, 3 },
                    { 199, "", new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), 1, 1 },
                    { 200, "", new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), 2, 1 },
                    { 201, "", new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), 5, 2 },
                    { 202, "", new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), 1, 3 },
                    { 203, "", new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), 2, 1 },
                    { 204, "", new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), 5, 3 },
                    { 205, "", new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), 5, 2 },
                    { 206, "", new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), 1, 2 },
                    { 207, "", new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), 2, 2 },
                    { 208, "", new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), 3, 3 },
                    { 209, "", new Guid("24021955-aa0d-49ca-92b9-01561f491967"), 3, 2 },
                    { 210, "", new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), 5, 2 },
                    { 211, "", new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), 3, 3 },
                    { 212, "", new Guid("24021955-aa0d-49ca-92b9-01561f491967"), 4, 2 },
                    { 213, "", new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), 6, 2 },
                    { 214, "", new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), 6, 2 },
                    { 215, "", new Guid("32151eef-e041-48a1-880a-5974d14ee349"), 2, 3 },
                    { 216, "", new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), 2, 1 },
                    { 217, "", new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), 4, 1 },
                    { 218, "", new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), 3, 2 },
                    { 219, "", new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), 1, 1 },
                    { 220, "", new Guid("685df129-d237-414f-8e3d-c676e579dfda"), 2, 1 },
                    { 221, "", new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), 1, 3 },
                    { 222, "", new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 223, "", new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), 1, 2 },
                    { 224, "", new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), 6, 3 },
                    { 225, "", new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), 3, 2 },
                    { 226, "", new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), 1, 3 },
                    { 227, "", new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), 1, 3 },
                    { 228, "", new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), 4, 2 },
                    { 229, "", new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), 2, 1 },
                    { 230, "", new Guid("06178512-2290-41dd-9f03-713f43b89f48"), 2, 2 },
                    { 231, "", new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), 2, 3 },
                    { 232, "", new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), 4, 3 },
                    { 233, "", new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), 4, 2 },
                    { 234, "", new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), 6, 1 },
                    { 235, "", new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), 5, 3 },
                    { 236, "", new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), 4, 2 },
                    { 237, "", new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), 1, 2 },
                    { 238, "", new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), 1, 2 },
                    { 239, "", new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), 1, 2 },
                    { 240, "", new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), 2, 3 },
                    { 241, "", new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), 3, 3 },
                    { 242, "", new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), 6, 3 },
                    { 243, "", new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), 3, 3 },
                    { 244, "", new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), 5, 2 },
                    { 245, "", new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), 6, 2 },
                    { 246, "", new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), 3, 1 },
                    { 247, "", new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), 6, 2 },
                    { 248, "", new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), 1, 2 },
                    { 249, "", new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), 6, 3 },
                    { 250, "", new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), 1, 3 },
                    { 251, "", new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), 2, 2 },
                    { 252, "", new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), 2, 1 },
                    { 253, "", new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), 3, 1 },
                    { 254, "", new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), 3, 1 },
                    { 255, "", new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), 5, 2 },
                    { 256, "", new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), 4, 2 },
                    { 257, "", new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), 2, 2 },
                    { 258, "", new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), 6, 2 },
                    { 259, "", new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), 2, 3 },
                    { 260, "", new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), 3, 2 },
                    { 261, "", new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), 1, 3 },
                    { 262, "", new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), 6, 2 },
                    { 263, "", new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), 5, 1 },
                    { 264, "", new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 265, "", new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), 3, 3 },
                    { 266, "", new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), 5, 1 },
                    { 267, "", new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), 5, 2 },
                    { 268, "", new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), 4, 3 },
                    { 269, "", new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), 4, 3 },
                    { 270, "", new Guid("1282556b-d71b-40f9-be66-a22236c75262"), 1, 1 },
                    { 271, "", new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), 1, 2 },
                    { 272, "", new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), 5, 3 },
                    { 273, "", new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), 4, 3 },
                    { 274, "", new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), 2, 3 },
                    { 275, "", new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), 2, 1 },
                    { 276, "", new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), 3, 3 },
                    { 277, "", new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), 4, 3 },
                    { 278, "", new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), 4, 2 },
                    { 279, "", new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), 3, 3 },
                    { 280, "", new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), 1, 3 },
                    { 281, "", new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), 2, 1 },
                    { 282, "", new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), 6, 2 },
                    { 283, "", new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), 6, 2 },
                    { 284, "", new Guid("685df129-d237-414f-8e3d-c676e579dfda"), 4, 2 },
                    { 285, "", new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), 3, 1 },
                    { 286, "", new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), 4, 3 },
                    { 287, "", new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), 6, 2 },
                    { 288, "", new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), 1, 3 },
                    { 289, "", new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), 4, 1 },
                    { 290, "", new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), 5, 1 },
                    { 291, "", new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), 1, 2 },
                    { 292, "", new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), 1, 1 },
                    { 293, "", new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), 4, 1 },
                    { 294, "", new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), 5, 3 },
                    { 295, "", new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), 5, 2 },
                    { 296, "", new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), 5, 1 },
                    { 297, "", new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), 1, 1 },
                    { 298, "", new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), 5, 1 },
                    { 299, "", new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), 5, 3 },
                    { 300, "", new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), 5, 1 },
                    { 301, "", new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), 2, 3 },
                    { 302, "", new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), 6, 2 },
                    { 303, "", new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), 4, 3 },
                    { 304, "", new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), 1, 1 },
                    { 305, "", new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), 6, 1 },
                    { 306, "", new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 307, "", new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), 2, 3 },
                    { 308, "", new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), 1, 3 },
                    { 309, "", new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), 4, 1 },
                    { 310, "", new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), 5, 2 },
                    { 311, "", new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), 1, 1 },
                    { 312, "", new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), 6, 2 },
                    { 313, "", new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), 1, 3 },
                    { 314, "", new Guid("06178512-2290-41dd-9f03-713f43b89f48"), 2, 1 },
                    { 315, "", new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), 3, 1 },
                    { 316, "", new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), 5, 1 },
                    { 317, "", new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), 5, 2 },
                    { 318, "", new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), 2, 3 },
                    { 319, "", new Guid("24e50499-d459-4100-82b1-626f4a825561"), 2, 2 },
                    { 320, "", new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), 1, 1 },
                    { 321, "", new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), 3, 3 },
                    { 322, "", new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), 6, 2 },
                    { 323, "", new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), 3, 3 },
                    { 324, "", new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), 6, 3 },
                    { 325, "", new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), 3, 1 },
                    { 326, "", new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), 1, 2 },
                    { 327, "", new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), 1, 1 },
                    { 328, "", new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), 1, 1 },
                    { 329, "", new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), 5, 3 },
                    { 330, "", new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), 6, 3 },
                    { 331, "", new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), 2, 2 },
                    { 332, "", new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), 3, 3 },
                    { 333, "", new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), 2, 1 },
                    { 334, "", new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), 6, 2 },
                    { 335, "", new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), 6, 2 },
                    { 336, "", new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), 2, 1 },
                    { 337, "", new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), 2, 1 },
                    { 338, "", new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), 3, 2 },
                    { 339, "", new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), 2, 2 },
                    { 340, "", new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), 3, 3 },
                    { 341, "", new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), 3, 3 },
                    { 342, "", new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), 4, 2 },
                    { 343, "", new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), 1, 3 },
                    { 344, "", new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), 2, 2 },
                    { 345, "", new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), 5, 3 },
                    { 346, "", new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), 4, 2 },
                    { 347, "", new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), 3, 1 },
                    { 348, "", new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 349, "", new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), 6, 1 },
                    { 350, "", new Guid("06178512-2290-41dd-9f03-713f43b89f48"), 6, 1 },
                    { 351, "", new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), 4, 3 },
                    { 352, "", new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), 1, 2 },
                    { 353, "", new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), 4, 1 },
                    { 354, "", new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), 1, 3 },
                    { 355, "", new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), 1, 3 },
                    { 356, "", new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), 1, 2 },
                    { 357, "", new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), 5, 1 },
                    { 358, "", new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), 2, 1 },
                    { 359, "", new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), 3, 3 },
                    { 360, "", new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), 5, 3 },
                    { 361, "", new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), 4, 3 },
                    { 362, "", new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), 2, 3 },
                    { 363, "", new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), 5, 3 },
                    { 364, "", new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), 5, 1 },
                    { 365, "", new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), 5, 2 },
                    { 366, "", new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), 4, 2 },
                    { 367, "", new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), 1, 3 },
                    { 368, "", new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), 2, 2 },
                    { 369, "", new Guid("499537bf-f642-4d94-91f0-234236984b79"), 1, 3 },
                    { 370, "", new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), 3, 2 },
                    { 371, "", new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), 4, 2 },
                    { 372, "", new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), 6, 2 },
                    { 373, "", new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), 1, 1 },
                    { 374, "", new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), 3, 3 },
                    { 375, "", new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), 2, 1 },
                    { 376, "", new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), 1, 3 },
                    { 377, "", new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), 1, 1 },
                    { 378, "", new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), 4, 1 },
                    { 379, "", new Guid("499537bf-f642-4d94-91f0-234236984b79"), 2, 3 },
                    { 380, "", new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), 2, 1 },
                    { 381, "", new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), 2, 3 },
                    { 382, "", new Guid("1282556b-d71b-40f9-be66-a22236c75262"), 1, 2 },
                    { 383, "", new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), 5, 1 },
                    { 384, "", new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), 3, 2 },
                    { 385, "", new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), 6, 2 },
                    { 386, "", new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), 1, 3 },
                    { 387, "", new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), 2, 2 },
                    { 388, "", new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), 3, 2 },
                    { 389, "", new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), 3, 2 },
                    { 390, "", new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 391, "", new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), 5, 3 },
                    { 392, "", new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), 5, 2 },
                    { 393, "", new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), 3, 2 },
                    { 394, "", new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), 4, 1 },
                    { 395, "", new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), 3, 3 },
                    { 396, "", new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), 3, 1 },
                    { 397, "", new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), 2, 3 },
                    { 398, "", new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), 6, 1 },
                    { 399, "", new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), 4, 2 },
                    { 400, "", new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), 5, 1 },
                    { 401, "", new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), 6, 2 },
                    { 402, "", new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), 6, 3 },
                    { 403, "", new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), 1, 1 },
                    { 404, "", new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), 4, 1 },
                    { 405, "", new Guid("685df129-d237-414f-8e3d-c676e579dfda"), 2, 2 },
                    { 406, "", new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), 3, 1 },
                    { 407, "", new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), 6, 2 },
                    { 408, "", new Guid("499537bf-f642-4d94-91f0-234236984b79"), 2, 2 },
                    { 409, "", new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), 2, 3 },
                    { 410, "", new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), 1, 1 },
                    { 411, "", new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), 6, 2 },
                    { 412, "", new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), 2, 3 },
                    { 413, "", new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), 4, 1 },
                    { 414, "", new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), 6, 2 },
                    { 415, "", new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), 5, 1 },
                    { 416, "", new Guid("06178512-2290-41dd-9f03-713f43b89f48"), 2, 3 },
                    { 417, "", new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), 5, 2 },
                    { 418, "", new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), 4, 3 },
                    { 419, "", new Guid("1282556b-d71b-40f9-be66-a22236c75262"), 1, 1 },
                    { 420, "", new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), 3, 3 },
                    { 421, "", new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), 4, 2 },
                    { 422, "", new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), 3, 3 },
                    { 423, "", new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), 3, 2 },
                    { 424, "", new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), 3, 1 },
                    { 425, "", new Guid("32151eef-e041-48a1-880a-5974d14ee349"), 5, 1 },
                    { 426, "", new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), 3, 2 },
                    { 427, "", new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), 2, 3 },
                    { 428, "", new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), 3, 1 },
                    { 429, "", new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), 2, 2 },
                    { 430, "", new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), 6, 2 },
                    { 431, "", new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), 1, 1 },
                    { 432, "", new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 433, "", new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), 3, 3 },
                    { 434, "", new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), 3, 2 },
                    { 435, "", new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), 5, 3 },
                    { 436, "", new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), 5, 3 },
                    { 437, "", new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), 5, 3 },
                    { 438, "", new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), 6, 2 },
                    { 439, "", new Guid("24021955-aa0d-49ca-92b9-01561f491967"), 1, 2 },
                    { 440, "", new Guid("32151eef-e041-48a1-880a-5974d14ee349"), 2, 2 },
                    { 441, "", new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), 6, 3 },
                    { 442, "", new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), 3, 2 },
                    { 443, "", new Guid("1282556b-d71b-40f9-be66-a22236c75262"), 4, 1 },
                    { 444, "", new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), 4, 1 },
                    { 445, "", new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), 1, 3 },
                    { 446, "", new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), 1, 3 },
                    { 447, "", new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), 4, 1 },
                    { 448, "", new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), 2, 2 },
                    { 449, "", new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), 4, 3 },
                    { 450, "", new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), 4, 2 },
                    { 451, "", new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), 3, 2 },
                    { 452, "", new Guid("685df129-d237-414f-8e3d-c676e579dfda"), 1, 3 },
                    { 453, "", new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), 6, 1 },
                    { 454, "", new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), 5, 2 },
                    { 455, "", new Guid("32151eef-e041-48a1-880a-5974d14ee349"), 2, 2 },
                    { 456, "", new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), 4, 2 },
                    { 457, "", new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), 3, 2 },
                    { 458, "", new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), 2, 1 },
                    { 459, "", new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), 3, 1 },
                    { 460, "", new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), 4, 1 },
                    { 461, "", new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), 1, 2 },
                    { 462, "", new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), 4, 1 },
                    { 463, "", new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), 1, 2 },
                    { 464, "", new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), 1, 2 },
                    { 465, "", new Guid("499537bf-f642-4d94-91f0-234236984b79"), 3, 3 },
                    { 466, "", new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), 3, 3 },
                    { 467, "", new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), 5, 1 },
                    { 468, "", new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), 5, 3 },
                    { 469, "", new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), 6, 2 },
                    { 470, "", new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), 4, 3 },
                    { 471, "", new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), 6, 2 },
                    { 472, "", new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), 4, 3 },
                    { 473, "", new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), 4, 2 },
                    { 474, "", new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 475, "", new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), 5, 1 },
                    { 476, "", new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), 1, 2 },
                    { 477, "", new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), 2, 2 },
                    { 478, "", new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), 4, 2 },
                    { 479, "", new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), 5, 2 },
                    { 480, "", new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), 2, 2 },
                    { 481, "", new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), 6, 2 },
                    { 482, "", new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), 3, 2 },
                    { 483, "", new Guid("24e50499-d459-4100-82b1-626f4a825561"), 6, 2 },
                    { 484, "", new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), 3, 1 },
                    { 485, "", new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), 2, 1 },
                    { 486, "", new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), 4, 3 },
                    { 487, "", new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), 2, 2 },
                    { 488, "", new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), 3, 2 },
                    { 489, "", new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), 1, 1 },
                    { 490, "", new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), 6, 1 },
                    { 491, "", new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), 4, 1 },
                    { 492, "", new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), 5, 2 },
                    { 493, "", new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), 4, 1 },
                    { 494, "", new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), 2, 2 },
                    { 495, "", new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), 5, 3 },
                    { 496, "", new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), 6, 3 },
                    { 497, "", new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), 5, 2 },
                    { 498, "", new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), 1, 2 },
                    { 499, "", new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), 1, 2 },
                    { 500, "", new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 19, 16, 29, 489, DateTimeKind.Local).AddTicks(3242), new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), true },
                    { 2, new DateTime(2022, 7, 27, 20, 41, 10, 597, DateTimeKind.Local).AddTicks(9767), new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), true },
                    { 3, new DateTime(2022, 7, 27, 17, 10, 0, 262, DateTimeKind.Local).AddTicks(2267), new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), false },
                    { 4, new DateTime(2022, 7, 27, 21, 35, 19, 243, DateTimeKind.Local).AddTicks(5463), new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), true },
                    { 5, new DateTime(2022, 7, 28, 12, 48, 19, 297, DateTimeKind.Local).AddTicks(6629), new Guid("685df129-d237-414f-8e3d-c676e579dfda"), false },
                    { 6, new DateTime(2022, 7, 28, 11, 22, 42, 175, DateTimeKind.Local).AddTicks(675), new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), true },
                    { 7, new DateTime(2022, 7, 28, 5, 6, 0, 108, DateTimeKind.Local).AddTicks(6326), new Guid("499537bf-f642-4d94-91f0-234236984b79"), true },
                    { 8, new DateTime(2022, 7, 28, 4, 20, 39, 138, DateTimeKind.Local).AddTicks(4149), new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), false },
                    { 9, new DateTime(2022, 7, 28, 9, 14, 8, 738, DateTimeKind.Local).AddTicks(5885), new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), true },
                    { 10, new DateTime(2022, 7, 28, 12, 7, 19, 106, DateTimeKind.Local).AddTicks(901), new Guid("1282556b-d71b-40f9-be66-a22236c75262"), false },
                    { 11, new DateTime(2022, 7, 28, 8, 46, 41, 506, DateTimeKind.Local).AddTicks(5917), new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), false },
                    { 12, new DateTime(2022, 7, 28, 10, 50, 15, 667, DateTimeKind.Local).AddTicks(9807), new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), false },
                    { 13, new DateTime(2022, 7, 28, 13, 12, 52, 656, DateTimeKind.Local).AddTicks(1945), new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), false },
                    { 14, new DateTime(2022, 7, 28, 1, 54, 52, 351, DateTimeKind.Local).AddTicks(2992), new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), true },
                    { 15, new DateTime(2022, 7, 27, 21, 41, 4, 337, DateTimeKind.Local).AddTicks(7112), new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), false },
                    { 16, new DateTime(2022, 7, 28, 11, 28, 21, 731, DateTimeKind.Local).AddTicks(4270), new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 17, new DateTime(2022, 7, 28, 13, 18, 24, 492, DateTimeKind.Local).AddTicks(8067), new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), false },
                    { 18, new DateTime(2022, 7, 28, 11, 3, 18, 293, DateTimeKind.Local).AddTicks(9774), new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), true },
                    { 19, new DateTime(2022, 7, 27, 21, 30, 43, 574, DateTimeKind.Local).AddTicks(1649), new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), true },
                    { 20, new DateTime(2022, 7, 28, 12, 29, 22, 239, DateTimeKind.Local).AddTicks(4029), new Guid("32151eef-e041-48a1-880a-5974d14ee349"), false },
                    { 21, new DateTime(2022, 7, 28, 3, 30, 9, 191, DateTimeKind.Local).AddTicks(1290), new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), false },
                    { 22, new DateTime(2022, 7, 28, 10, 0, 35, 124, DateTimeKind.Local).AddTicks(6952), new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), false },
                    { 23, new DateTime(2022, 7, 27, 22, 18, 6, 642, DateTimeKind.Local).AddTicks(4945), new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), false },
                    { 24, new DateTime(2022, 7, 28, 8, 23, 35, 56, DateTimeKind.Local).AddTicks(5283), new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), false },
                    { 25, new DateTime(2022, 7, 28, 0, 38, 3, 317, DateTimeKind.Local).AddTicks(3102), new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), false },
                    { 26, new DateTime(2022, 7, 28, 7, 0, 37, 120, DateTimeKind.Local).AddTicks(2219), new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), false },
                    { 27, new DateTime(2022, 7, 27, 21, 22, 6, 118, DateTimeKind.Local).AddTicks(7699), new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), false },
                    { 28, new DateTime(2022, 7, 28, 0, 19, 39, 276, DateTimeKind.Local).AddTicks(9063), new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), true },
                    { 29, new DateTime(2022, 7, 27, 17, 45, 59, 272, DateTimeKind.Local).AddTicks(5265), new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), false },
                    { 30, new DateTime(2022, 7, 28, 6, 50, 48, 685, DateTimeKind.Local).AddTicks(629), new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), false },
                    { 31, new DateTime(2022, 7, 28, 13, 36, 43, 870, DateTimeKind.Local).AddTicks(358), new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), false },
                    { 32, new DateTime(2022, 7, 27, 22, 32, 20, 948, DateTimeKind.Local).AddTicks(1250), new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), true },
                    { 33, new DateTime(2022, 7, 27, 14, 25, 34, 992, DateTimeKind.Local).AddTicks(8140), new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), false },
                    { 34, new DateTime(2022, 7, 27, 15, 14, 30, 464, DateTimeKind.Local).AddTicks(9678), new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), false },
                    { 35, new DateTime(2022, 7, 27, 22, 38, 14, 538, DateTimeKind.Local).AddTicks(8827), new Guid("24e50499-d459-4100-82b1-626f4a825561"), false },
                    { 36, new DateTime(2022, 7, 28, 12, 37, 49, 551, DateTimeKind.Local).AddTicks(9440), new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), false },
                    { 37, new DateTime(2022, 7, 28, 1, 0, 36, 928, DateTimeKind.Local).AddTicks(9651), new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), true },
                    { 38, new DateTime(2022, 7, 28, 7, 20, 55, 677, DateTimeKind.Local).AddTicks(1721), new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), true },
                    { 39, new DateTime(2022, 7, 28, 2, 40, 33, 793, DateTimeKind.Local).AddTicks(7135), new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), false },
                    { 40, new DateTime(2022, 7, 27, 23, 58, 13, 368, DateTimeKind.Local).AddTicks(3754), new Guid("32151eef-e041-48a1-880a-5974d14ee349"), false },
                    { 41, new DateTime(2022, 7, 28, 12, 2, 17, 299, DateTimeKind.Local).AddTicks(3363), new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), true },
                    { 42, new DateTime(2022, 7, 28, 5, 2, 42, 7, DateTimeKind.Local).AddTicks(6864), new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), false },
                    { 43, new DateTime(2022, 7, 28, 9, 33, 10, 405, DateTimeKind.Local).AddTicks(906), new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), false },
                    { 44, new DateTime(2022, 7, 27, 23, 29, 14, 488, DateTimeKind.Local).AddTicks(627), new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), false },
                    { 45, new DateTime(2022, 7, 28, 13, 20, 42, 716, DateTimeKind.Local).AddTicks(8306), new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), true },
                    { 46, new DateTime(2022, 7, 27, 16, 52, 20, 665, DateTimeKind.Local).AddTicks(4990), new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), false },
                    { 47, new DateTime(2022, 7, 27, 16, 9, 19, 516, DateTimeKind.Local).AddTicks(2242), new Guid("24021955-aa0d-49ca-92b9-01561f491967"), true },
                    { 48, new DateTime(2022, 7, 28, 3, 12, 18, 49, DateTimeKind.Local).AddTicks(417), new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), false },
                    { 49, new DateTime(2022, 7, 28, 5, 13, 59, 623, DateTimeKind.Local).AddTicks(8332), new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), false },
                    { 50, new DateTime(2022, 7, 28, 1, 51, 43, 966, DateTimeKind.Local).AddTicks(6579), new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), false },
                    { 51, new DateTime(2022, 7, 28, 3, 15, 30, 978, DateTimeKind.Local).AddTicks(2391), new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), false },
                    { 52, new DateTime(2022, 7, 27, 16, 51, 33, 420, DateTimeKind.Local).AddTicks(1878), new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), true },
                    { 53, new DateTime(2022, 7, 28, 4, 55, 42, 341, DateTimeKind.Local).AddTicks(2756), new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), true },
                    { 54, new DateTime(2022, 7, 28, 0, 1, 9, 525, DateTimeKind.Local).AddTicks(7371), new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), true },
                    { 55, new DateTime(2022, 7, 28, 3, 57, 55, 397, DateTimeKind.Local).AddTicks(6238), new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), false },
                    { 56, new DateTime(2022, 7, 27, 15, 50, 50, 743, DateTimeKind.Local).AddTicks(8400), new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), true },
                    { 57, new DateTime(2022, 7, 28, 10, 42, 2, 792, DateTimeKind.Local).AddTicks(2049), new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), false },
                    { 58, new DateTime(2022, 7, 28, 3, 29, 31, 876, DateTimeKind.Local).AddTicks(3958), new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 59, new DateTime(2022, 7, 27, 16, 59, 6, 191, DateTimeKind.Local).AddTicks(7618), new Guid("499537bf-f642-4d94-91f0-234236984b79"), false },
                    { 60, new DateTime(2022, 7, 27, 20, 18, 38, 327, DateTimeKind.Local).AddTicks(1687), new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), true },
                    { 61, new DateTime(2022, 7, 27, 15, 39, 14, 655, DateTimeKind.Local).AddTicks(8719), new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), true },
                    { 62, new DateTime(2022, 7, 28, 9, 59, 25, 727, DateTimeKind.Local).AddTicks(9710), new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), true },
                    { 63, new DateTime(2022, 7, 27, 15, 9, 3, 913, DateTimeKind.Local).AddTicks(1209), new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), true },
                    { 64, new DateTime(2022, 7, 27, 19, 43, 41, 73, DateTimeKind.Local).AddTicks(1974), new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), false },
                    { 65, new DateTime(2022, 7, 27, 18, 59, 9, 662, DateTimeKind.Local).AddTicks(9312), new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), false },
                    { 66, new DateTime(2022, 7, 27, 19, 39, 47, 13, DateTimeKind.Local).AddTicks(3471), new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), true },
                    { 67, new DateTime(2022, 7, 27, 22, 0, 50, 819, DateTimeKind.Local).AddTicks(7713), new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), true },
                    { 68, new DateTime(2022, 7, 27, 16, 19, 15, 797, DateTimeKind.Local).AddTicks(8776), new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), false },
                    { 69, new DateTime(2022, 7, 28, 8, 25, 34, 778, DateTimeKind.Local).AddTicks(2353), new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), true },
                    { 70, new DateTime(2022, 7, 27, 16, 12, 36, 94, DateTimeKind.Local).AddTicks(2746), new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), false },
                    { 71, new DateTime(2022, 7, 28, 5, 39, 27, 689, DateTimeKind.Local).AddTicks(6930), new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), false },
                    { 72, new DateTime(2022, 7, 28, 0, 5, 0, 550, DateTimeKind.Local).AddTicks(246), new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), true },
                    { 73, new DateTime(2022, 7, 28, 12, 9, 33, 848, DateTimeKind.Local).AddTicks(2149), new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), true },
                    { 74, new DateTime(2022, 7, 28, 8, 13, 8, 349, DateTimeKind.Local).AddTicks(1402), new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), true },
                    { 75, new DateTime(2022, 7, 28, 8, 18, 24, 921, DateTimeKind.Local).AddTicks(9433), new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), true },
                    { 76, new DateTime(2022, 7, 27, 22, 43, 46, 824, DateTimeKind.Local).AddTicks(239), new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), true },
                    { 77, new DateTime(2022, 7, 28, 3, 39, 27, 169, DateTimeKind.Local).AddTicks(9223), new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), false },
                    { 78, new DateTime(2022, 7, 28, 6, 43, 38, 697, DateTimeKind.Local).AddTicks(7170), new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), true },
                    { 79, new DateTime(2022, 7, 28, 10, 43, 15, 127, DateTimeKind.Local).AddTicks(9174), new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), true },
                    { 80, new DateTime(2022, 7, 27, 23, 48, 30, 625, DateTimeKind.Local).AddTicks(926), new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), true },
                    { 81, new DateTime(2022, 7, 27, 14, 49, 6, 788, DateTimeKind.Local).AddTicks(4431), new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), true },
                    { 82, new DateTime(2022, 7, 27, 21, 33, 9, 123, DateTimeKind.Local).AddTicks(6956), new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), true },
                    { 83, new DateTime(2022, 7, 28, 1, 11, 20, 810, DateTimeKind.Local).AddTicks(3173), new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), false },
                    { 84, new DateTime(2022, 7, 27, 19, 3, 2, 383, DateTimeKind.Local).AddTicks(1022), new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), false },
                    { 85, new DateTime(2022, 7, 28, 10, 25, 54, 888, DateTimeKind.Local).AddTicks(5681), new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), true },
                    { 86, new DateTime(2022, 7, 28, 11, 58, 13, 823, DateTimeKind.Local).AddTicks(9241), new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), true },
                    { 87, new DateTime(2022, 7, 28, 11, 23, 12, 689, DateTimeKind.Local).AddTicks(314), new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), false },
                    { 88, new DateTime(2022, 7, 27, 23, 4, 16, 866, DateTimeKind.Local).AddTicks(3730), new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), false },
                    { 89, new DateTime(2022, 7, 27, 13, 50, 25, 919, DateTimeKind.Local).AddTicks(2990), new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), true },
                    { 90, new DateTime(2022, 7, 27, 22, 42, 17, 17, DateTimeKind.Local).AddTicks(9127), new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), false },
                    { 91, new DateTime(2022, 7, 28, 9, 23, 25, 113, DateTimeKind.Local).AddTicks(1817), new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), false },
                    { 92, new DateTime(2022, 7, 27, 15, 15, 24, 174, DateTimeKind.Local).AddTicks(2083), new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), false },
                    { 93, new DateTime(2022, 7, 27, 16, 18, 33, 302, DateTimeKind.Local).AddTicks(5652), new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), true },
                    { 94, new DateTime(2022, 7, 28, 4, 30, 11, 192, DateTimeKind.Local).AddTicks(6441), new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), false },
                    { 95, new DateTime(2022, 7, 27, 21, 19, 55, 720, DateTimeKind.Local).AddTicks(4083), new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), false },
                    { 96, new DateTime(2022, 7, 28, 5, 51, 55, 106, DateTimeKind.Local).AddTicks(5943), new Guid("32151eef-e041-48a1-880a-5974d14ee349"), false },
                    { 97, new DateTime(2022, 7, 27, 15, 4, 55, 142, DateTimeKind.Local).AddTicks(2630), new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), true },
                    { 98, new DateTime(2022, 7, 28, 4, 12, 32, 729, DateTimeKind.Local).AddTicks(4157), new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), true },
                    { 99, new DateTime(2022, 7, 28, 10, 50, 26, 892, DateTimeKind.Local).AddTicks(6686), new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), false },
                    { 100, new DateTime(2022, 7, 27, 23, 4, 13, 256, DateTimeKind.Local).AddTicks(2080), new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 101, new DateTime(2022, 7, 27, 23, 14, 20, 902, DateTimeKind.Local).AddTicks(3181), new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), false },
                    { 102, new DateTime(2022, 7, 27, 22, 46, 9, 621, DateTimeKind.Local).AddTicks(7341), new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), true },
                    { 103, new DateTime(2022, 7, 28, 9, 4, 59, 487, DateTimeKind.Local).AddTicks(9818), new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), false },
                    { 104, new DateTime(2022, 7, 28, 6, 20, 48, 944, DateTimeKind.Local).AddTicks(6202), new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), false },
                    { 105, new DateTime(2022, 7, 27, 15, 16, 16, 688, DateTimeKind.Local).AddTicks(1865), new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), false },
                    { 106, new DateTime(2022, 7, 27, 18, 35, 59, 996, DateTimeKind.Local).AddTicks(5199), new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), false },
                    { 107, new DateTime(2022, 7, 27, 18, 21, 25, 154, DateTimeKind.Local).AddTicks(3443), new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), false },
                    { 108, new DateTime(2022, 7, 28, 2, 59, 8, 108, DateTimeKind.Local).AddTicks(3042), new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), true },
                    { 109, new DateTime(2022, 7, 28, 13, 31, 7, 601, DateTimeKind.Local).AddTicks(1015), new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), true },
                    { 110, new DateTime(2022, 7, 28, 3, 36, 1, 684, DateTimeKind.Local).AddTicks(7636), new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), false },
                    { 111, new DateTime(2022, 7, 28, 4, 43, 3, 232, DateTimeKind.Local).AddTicks(8638), new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), true },
                    { 112, new DateTime(2022, 7, 28, 12, 50, 15, 829, DateTimeKind.Local).AddTicks(12), new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), false },
                    { 113, new DateTime(2022, 7, 28, 4, 1, 51, 216, DateTimeKind.Local).AddTicks(9786), new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), true },
                    { 114, new DateTime(2022, 7, 27, 18, 19, 13, 127, DateTimeKind.Local).AddTicks(9451), new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), true },
                    { 115, new DateTime(2022, 7, 27, 21, 15, 14, 789, DateTimeKind.Local).AddTicks(8018), new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), true },
                    { 116, new DateTime(2022, 7, 28, 0, 11, 24, 589, DateTimeKind.Local).AddTicks(7063), new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), true },
                    { 117, new DateTime(2022, 7, 27, 23, 39, 35, 551, DateTimeKind.Local).AddTicks(756), new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), true },
                    { 118, new DateTime(2022, 7, 27, 21, 23, 31, 414, DateTimeKind.Local).AddTicks(3801), new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), false },
                    { 119, new DateTime(2022, 7, 28, 0, 36, 26, 447, DateTimeKind.Local).AddTicks(9707), new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), true },
                    { 120, new DateTime(2022, 7, 28, 0, 2, 42, 15, DateTimeKind.Local).AddTicks(9050), new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), true },
                    { 121, new DateTime(2022, 7, 27, 19, 39, 8, 332, DateTimeKind.Local).AddTicks(9249), new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), false },
                    { 122, new DateTime(2022, 7, 28, 11, 37, 59, 875, DateTimeKind.Local).AddTicks(8275), new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), false },
                    { 123, new DateTime(2022, 7, 27, 21, 18, 2, 553, DateTimeKind.Local).AddTicks(2141), new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), false },
                    { 124, new DateTime(2022, 7, 28, 10, 14, 20, 167, DateTimeKind.Local).AddTicks(3840), new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), false },
                    { 125, new DateTime(2022, 7, 27, 22, 53, 53, 954, DateTimeKind.Local).AddTicks(2588), new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), true },
                    { 126, new DateTime(2022, 7, 28, 11, 59, 20, 836, DateTimeKind.Local).AddTicks(1363), new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), false },
                    { 127, new DateTime(2022, 7, 28, 10, 0, 28, 879, DateTimeKind.Local).AddTicks(5897), new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), true },
                    { 128, new DateTime(2022, 7, 28, 6, 12, 58, 220, DateTimeKind.Local).AddTicks(9352), new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), false },
                    { 129, new DateTime(2022, 7, 27, 21, 35, 46, 92, DateTimeKind.Local).AddTicks(6884), new Guid("06178512-2290-41dd-9f03-713f43b89f48"), true },
                    { 130, new DateTime(2022, 7, 27, 23, 46, 30, 958, DateTimeKind.Local).AddTicks(5072), new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), true },
                    { 131, new DateTime(2022, 7, 28, 8, 38, 26, 21, DateTimeKind.Local).AddTicks(3305), new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), true },
                    { 132, new DateTime(2022, 7, 27, 23, 3, 33, 79, DateTimeKind.Local).AddTicks(8278), new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), false },
                    { 133, new DateTime(2022, 7, 27, 19, 2, 23, 712, DateTimeKind.Local).AddTicks(7316), new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), true },
                    { 134, new DateTime(2022, 7, 27, 23, 53, 54, 837, DateTimeKind.Local).AddTicks(2850), new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), true },
                    { 135, new DateTime(2022, 7, 28, 0, 8, 31, 702, DateTimeKind.Local).AddTicks(5798), new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), true },
                    { 136, new DateTime(2022, 7, 28, 7, 37, 44, 634, DateTimeKind.Local).AddTicks(6554), new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), true },
                    { 137, new DateTime(2022, 7, 27, 16, 36, 27, 661, DateTimeKind.Local).AddTicks(895), new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), false },
                    { 138, new DateTime(2022, 7, 27, 23, 22, 54, 995, DateTimeKind.Local).AddTicks(7163), new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), false },
                    { 139, new DateTime(2022, 7, 27, 21, 44, 32, 808, DateTimeKind.Local).AddTicks(9453), new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), true },
                    { 140, new DateTime(2022, 7, 28, 0, 2, 59, 632, DateTimeKind.Local).AddTicks(4022), new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), true },
                    { 141, new DateTime(2022, 7, 28, 0, 10, 5, 527, DateTimeKind.Local).AddTicks(5166), new Guid("685df129-d237-414f-8e3d-c676e579dfda"), false },
                    { 142, new DateTime(2022, 7, 27, 21, 38, 28, 829, DateTimeKind.Local).AddTicks(6712), new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 143, new DateTime(2022, 7, 28, 5, 9, 54, 789, DateTimeKind.Local).AddTicks(4242), new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), true },
                    { 144, new DateTime(2022, 7, 28, 9, 6, 21, 103, DateTimeKind.Local).AddTicks(6932), new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), true },
                    { 145, new DateTime(2022, 7, 27, 15, 36, 51, 144, DateTimeKind.Local).AddTicks(3335), new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), true },
                    { 146, new DateTime(2022, 7, 28, 4, 56, 7, 814, DateTimeKind.Local).AddTicks(4188), new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), false },
                    { 147, new DateTime(2022, 7, 28, 3, 54, 45, 806, DateTimeKind.Local).AddTicks(4089), new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"), true },
                    { 148, new DateTime(2022, 7, 28, 12, 50, 31, 1, DateTimeKind.Local).AddTicks(4023), new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), false },
                    { 149, new DateTime(2022, 7, 28, 9, 31, 21, 348, DateTimeKind.Local).AddTicks(9448), new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), false },
                    { 150, new DateTime(2022, 7, 28, 7, 39, 54, 616, DateTimeKind.Local).AddTicks(1179), new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), true },
                    { 151, new DateTime(2022, 7, 28, 12, 35, 20, 386, DateTimeKind.Local).AddTicks(8336), new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), false },
                    { 152, new DateTime(2022, 7, 27, 19, 35, 10, 15, DateTimeKind.Local).AddTicks(554), new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), true },
                    { 153, new DateTime(2022, 7, 28, 9, 16, 30, 69, DateTimeKind.Local).AddTicks(3150), new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), true },
                    { 154, new DateTime(2022, 7, 28, 6, 38, 11, 508, DateTimeKind.Local).AddTicks(7353), new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), true },
                    { 155, new DateTime(2022, 7, 28, 10, 0, 31, 616, DateTimeKind.Local).AddTicks(8976), new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), true },
                    { 156, new DateTime(2022, 7, 27, 15, 47, 39, 868, DateTimeKind.Local).AddTicks(9111), new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), false },
                    { 157, new DateTime(2022, 7, 28, 13, 4, 18, 372, DateTimeKind.Local).AddTicks(1753), new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), false },
                    { 158, new DateTime(2022, 7, 28, 3, 19, 41, 902, DateTimeKind.Local).AddTicks(1210), new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), true },
                    { 159, new DateTime(2022, 7, 28, 1, 2, 53, 57, DateTimeKind.Local).AddTicks(8928), new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), false },
                    { 160, new DateTime(2022, 7, 28, 5, 16, 26, 65, DateTimeKind.Local).AddTicks(9749), new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), true },
                    { 161, new DateTime(2022, 7, 27, 14, 56, 46, 367, DateTimeKind.Local).AddTicks(912), new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), true },
                    { 162, new DateTime(2022, 7, 28, 12, 6, 56, 491, DateTimeKind.Local).AddTicks(7816), new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), false },
                    { 163, new DateTime(2022, 7, 27, 18, 1, 55, 567, DateTimeKind.Local).AddTicks(9885), new Guid("24021955-aa0d-49ca-92b9-01561f491967"), true },
                    { 164, new DateTime(2022, 7, 28, 3, 11, 32, 138, DateTimeKind.Local).AddTicks(1366), new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), false },
                    { 165, new DateTime(2022, 7, 28, 4, 4, 34, 60, DateTimeKind.Local).AddTicks(1069), new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), false },
                    { 166, new DateTime(2022, 7, 27, 18, 5, 15, 421, DateTimeKind.Local).AddTicks(2833), new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), true },
                    { 167, new DateTime(2022, 7, 27, 22, 1, 11, 902, DateTimeKind.Local).AddTicks(3435), new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), false },
                    { 168, new DateTime(2022, 7, 28, 1, 45, 21, 595, DateTimeKind.Local).AddTicks(365), new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), false },
                    { 169, new DateTime(2022, 7, 28, 9, 4, 53, 452, DateTimeKind.Local).AddTicks(849), new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), true },
                    { 170, new DateTime(2022, 7, 27, 16, 57, 24, 378, DateTimeKind.Local).AddTicks(6896), new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), false },
                    { 171, new DateTime(2022, 7, 28, 7, 39, 14, 79, DateTimeKind.Local).AddTicks(6984), new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), true },
                    { 172, new DateTime(2022, 7, 27, 17, 45, 17, 95, DateTimeKind.Local).AddTicks(9232), new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), false },
                    { 173, new DateTime(2022, 7, 27, 19, 16, 39, 985, DateTimeKind.Local).AddTicks(1359), new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), true },
                    { 174, new DateTime(2022, 7, 27, 16, 33, 50, 792, DateTimeKind.Local).AddTicks(3443), new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), true },
                    { 175, new DateTime(2022, 7, 28, 0, 20, 49, 301, DateTimeKind.Local).AddTicks(872), new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), false },
                    { 176, new DateTime(2022, 7, 27, 19, 40, 31, 88, DateTimeKind.Local).AddTicks(8404), new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), true },
                    { 177, new DateTime(2022, 7, 27, 16, 39, 26, 76, DateTimeKind.Local).AddTicks(8009), new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), false },
                    { 178, new DateTime(2022, 7, 27, 19, 44, 23, 318, DateTimeKind.Local).AddTicks(7683), new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), true },
                    { 179, new DateTime(2022, 7, 28, 6, 57, 44, 419, DateTimeKind.Local).AddTicks(1108), new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), false },
                    { 180, new DateTime(2022, 7, 27, 14, 15, 39, 81, DateTimeKind.Local).AddTicks(9981), new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), false },
                    { 181, new DateTime(2022, 7, 28, 11, 12, 28, 301, DateTimeKind.Local).AddTicks(5767), new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), false },
                    { 182, new DateTime(2022, 7, 28, 12, 49, 52, 185, DateTimeKind.Local).AddTicks(3362), new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), true },
                    { 183, new DateTime(2022, 7, 27, 17, 35, 44, 657, DateTimeKind.Local).AddTicks(2753), new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), true },
                    { 184, new DateTime(2022, 7, 28, 12, 13, 26, 683, DateTimeKind.Local).AddTicks(9328), new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 185, new DateTime(2022, 7, 27, 17, 44, 39, 864, DateTimeKind.Local).AddTicks(265), new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), true },
                    { 186, new DateTime(2022, 7, 28, 12, 48, 38, 766, DateTimeKind.Local).AddTicks(8700), new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), false },
                    { 187, new DateTime(2022, 7, 28, 13, 20, 36, 838, DateTimeKind.Local).AddTicks(9503), new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), false },
                    { 188, new DateTime(2022, 7, 27, 17, 12, 42, 252, DateTimeKind.Local).AddTicks(361), new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), false },
                    { 189, new DateTime(2022, 7, 28, 0, 46, 28, 226, DateTimeKind.Local).AddTicks(9608), new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), false },
                    { 190, new DateTime(2022, 7, 28, 7, 29, 31, 917, DateTimeKind.Local).AddTicks(1522), new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), false },
                    { 191, new DateTime(2022, 7, 28, 10, 22, 14, 118, DateTimeKind.Local).AddTicks(4991), new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), false },
                    { 192, new DateTime(2022, 7, 27, 20, 17, 42, 821, DateTimeKind.Local).AddTicks(1271), new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), false },
                    { 193, new DateTime(2022, 7, 27, 17, 47, 25, 722, DateTimeKind.Local).AddTicks(851), new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), false },
                    { 194, new DateTime(2022, 7, 28, 5, 50, 40, 494, DateTimeKind.Local).AddTicks(1450), new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), false },
                    { 195, new DateTime(2022, 7, 27, 22, 12, 4, 93, DateTimeKind.Local).AddTicks(2455), new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), true },
                    { 196, new DateTime(2022, 7, 28, 8, 19, 7, 668, DateTimeKind.Local).AddTicks(7768), new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"), false },
                    { 197, new DateTime(2022, 7, 27, 15, 17, 27, 544, DateTimeKind.Local).AddTicks(4993), new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), true },
                    { 198, new DateTime(2022, 7, 27, 23, 44, 25, 482, DateTimeKind.Local).AddTicks(5311), new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), false },
                    { 199, new DateTime(2022, 7, 27, 19, 35, 6, 108, DateTimeKind.Local).AddTicks(1331), new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), false },
                    { 200, new DateTime(2022, 7, 28, 4, 41, 6, 192, DateTimeKind.Local).AddTicks(2557), new Guid("24021955-aa0d-49ca-92b9-01561f491967"), true },
                    { 201, new DateTime(2022, 7, 27, 16, 22, 27, 89, DateTimeKind.Local).AddTicks(4129), new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), false },
                    { 202, new DateTime(2022, 7, 28, 8, 44, 18, 609, DateTimeKind.Local).AddTicks(8254), new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), true },
                    { 203, new DateTime(2022, 7, 28, 8, 52, 26, 814, DateTimeKind.Local).AddTicks(6516), new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), false },
                    { 204, new DateTime(2022, 7, 28, 11, 49, 16, 595, DateTimeKind.Local).AddTicks(6180), new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), true },
                    { 205, new DateTime(2022, 7, 28, 7, 57, 12, 215, DateTimeKind.Local).AddTicks(7480), new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), false },
                    { 206, new DateTime(2022, 7, 27, 20, 51, 12, 724, DateTimeKind.Local).AddTicks(638), new Guid("24021955-aa0d-49ca-92b9-01561f491967"), false },
                    { 207, new DateTime(2022, 7, 28, 8, 47, 43, 589, DateTimeKind.Local).AddTicks(2855), new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), true },
                    { 208, new DateTime(2022, 7, 28, 10, 5, 10, 552, DateTimeKind.Local).AddTicks(940), new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), false },
                    { 209, new DateTime(2022, 7, 27, 19, 40, 19, 819, DateTimeKind.Local).AddTicks(919), new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), false },
                    { 210, new DateTime(2022, 7, 27, 16, 10, 21, 44, DateTimeKind.Local).AddTicks(112), new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), false },
                    { 211, new DateTime(2022, 7, 27, 13, 57, 6, 361, DateTimeKind.Local).AddTicks(3461), new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), false },
                    { 212, new DateTime(2022, 7, 28, 10, 41, 54, 637, DateTimeKind.Local).AddTicks(5619), new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), false },
                    { 213, new DateTime(2022, 7, 27, 20, 57, 52, 373, DateTimeKind.Local).AddTicks(6148), new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), true },
                    { 214, new DateTime(2022, 7, 27, 23, 18, 34, 759, DateTimeKind.Local).AddTicks(5176), new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), true },
                    { 215, new DateTime(2022, 7, 28, 0, 3, 32, 826, DateTimeKind.Local).AddTicks(2350), new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), true },
                    { 216, new DateTime(2022, 7, 27, 15, 56, 27, 663, DateTimeKind.Local).AddTicks(5527), new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), false },
                    { 217, new DateTime(2022, 7, 28, 12, 53, 31, 161, DateTimeKind.Local).AddTicks(4672), new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), true },
                    { 218, new DateTime(2022, 7, 27, 21, 21, 24, 917, DateTimeKind.Local).AddTicks(8179), new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), false },
                    { 219, new DateTime(2022, 7, 28, 0, 37, 29, 947, DateTimeKind.Local).AddTicks(7957), new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), true },
                    { 220, new DateTime(2022, 7, 28, 4, 43, 10, 662, DateTimeKind.Local).AddTicks(5415), new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), true },
                    { 221, new DateTime(2022, 7, 28, 8, 18, 46, 218, DateTimeKind.Local).AddTicks(4332), new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), true },
                    { 222, new DateTime(2022, 7, 27, 23, 36, 28, 112, DateTimeKind.Local).AddTicks(9746), new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), false },
                    { 223, new DateTime(2022, 7, 27, 19, 31, 47, 56, DateTimeKind.Local).AddTicks(5803), new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), false },
                    { 224, new DateTime(2022, 7, 28, 0, 37, 30, 303, DateTimeKind.Local).AddTicks(9832), new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), false },
                    { 225, new DateTime(2022, 7, 27, 15, 54, 40, 65, DateTimeKind.Local).AddTicks(3895), new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), false },
                    { 226, new DateTime(2022, 7, 28, 5, 24, 7, 569, DateTimeKind.Local).AddTicks(7121), new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 227, new DateTime(2022, 7, 27, 14, 33, 12, 948, DateTimeKind.Local).AddTicks(6091), new Guid("24e50499-d459-4100-82b1-626f4a825561"), true },
                    { 228, new DateTime(2022, 7, 28, 10, 53, 20, 607, DateTimeKind.Local).AddTicks(2014), new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), false },
                    { 229, new DateTime(2022, 7, 28, 12, 7, 3, 409, DateTimeKind.Local).AddTicks(7070), new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), false },
                    { 230, new DateTime(2022, 7, 27, 19, 40, 45, 402, DateTimeKind.Local).AddTicks(5195), new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), true },
                    { 231, new DateTime(2022, 7, 27, 21, 25, 25, 15, DateTimeKind.Local).AddTicks(2316), new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), true },
                    { 232, new DateTime(2022, 7, 27, 20, 3, 28, 161, DateTimeKind.Local).AddTicks(2745), new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), true },
                    { 233, new DateTime(2022, 7, 27, 17, 56, 41, 499, DateTimeKind.Local).AddTicks(2883), new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), false },
                    { 234, new DateTime(2022, 7, 27, 17, 21, 32, 808, DateTimeKind.Local).AddTicks(6529), new Guid("1282556b-d71b-40f9-be66-a22236c75262"), true },
                    { 235, new DateTime(2022, 7, 28, 13, 23, 10, 485, DateTimeKind.Local).AddTicks(4446), new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), false },
                    { 236, new DateTime(2022, 7, 28, 1, 15, 8, 114, DateTimeKind.Local).AddTicks(3032), new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), false },
                    { 237, new DateTime(2022, 7, 27, 18, 7, 0, 16, DateTimeKind.Local).AddTicks(3624), new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), false },
                    { 238, new DateTime(2022, 7, 27, 17, 36, 8, 240, DateTimeKind.Local).AddTicks(3339), new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), true },
                    { 239, new DateTime(2022, 7, 28, 12, 41, 42, 766, DateTimeKind.Local).AddTicks(2013), new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"), true },
                    { 240, new DateTime(2022, 7, 28, 12, 14, 38, 422, DateTimeKind.Local).AddTicks(2548), new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), true },
                    { 241, new DateTime(2022, 7, 28, 0, 5, 17, 87, DateTimeKind.Local).AddTicks(9979), new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), false },
                    { 242, new DateTime(2022, 7, 27, 13, 54, 51, 726, DateTimeKind.Local).AddTicks(3090), new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), false },
                    { 243, new DateTime(2022, 7, 28, 13, 16, 30, 14, DateTimeKind.Local).AddTicks(3891), new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), false },
                    { 244, new DateTime(2022, 7, 28, 6, 9, 10, 40, DateTimeKind.Local).AddTicks(6694), new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), false },
                    { 245, new DateTime(2022, 7, 28, 6, 59, 16, 670, DateTimeKind.Local).AddTicks(1053), new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), true },
                    { 246, new DateTime(2022, 7, 28, 3, 7, 56, 606, DateTimeKind.Local).AddTicks(1896), new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), true },
                    { 247, new DateTime(2022, 7, 27, 15, 48, 49, 137, DateTimeKind.Local).AddTicks(2200), new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), false },
                    { 248, new DateTime(2022, 7, 28, 11, 32, 41, 629, DateTimeKind.Local).AddTicks(8438), new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), true },
                    { 249, new DateTime(2022, 7, 28, 0, 17, 9, 746, DateTimeKind.Local).AddTicks(9003), new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"), false },
                    { 250, new DateTime(2022, 7, 27, 20, 38, 42, 634, DateTimeKind.Local).AddTicks(3052), new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), true },
                    { 251, new DateTime(2022, 7, 28, 7, 20, 38, 494, DateTimeKind.Local).AddTicks(5456), new Guid("ae035edd-0732-4044-982c-d306f47b49f3"), true },
                    { 252, new DateTime(2022, 7, 28, 1, 2, 25, 40, DateTimeKind.Local).AddTicks(3206), new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), false },
                    { 253, new DateTime(2022, 7, 28, 3, 47, 31, 172, DateTimeKind.Local).AddTicks(4799), new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), true },
                    { 254, new DateTime(2022, 7, 28, 3, 21, 44, 144, DateTimeKind.Local).AddTicks(9938), new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"), true },
                    { 255, new DateTime(2022, 7, 28, 10, 23, 33, 194, DateTimeKind.Local).AddTicks(9384), new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), false },
                    { 256, new DateTime(2022, 7, 27, 15, 26, 42, 849, DateTimeKind.Local).AddTicks(8379), new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), false },
                    { 257, new DateTime(2022, 7, 27, 21, 36, 49, 657, DateTimeKind.Local).AddTicks(9278), new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), true },
                    { 258, new DateTime(2022, 7, 28, 4, 29, 11, 284, DateTimeKind.Local).AddTicks(4743), new Guid("06178512-2290-41dd-9f03-713f43b89f48"), true },
                    { 259, new DateTime(2022, 7, 27, 16, 23, 58, 787, DateTimeKind.Local).AddTicks(9528), new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), false },
                    { 260, new DateTime(2022, 7, 27, 15, 16, 36, 767, DateTimeKind.Local).AddTicks(8230), new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), false },
                    { 261, new DateTime(2022, 7, 27, 22, 4, 0, 77, DateTimeKind.Local).AddTicks(9191), new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), false },
                    { 262, new DateTime(2022, 7, 28, 3, 32, 6, 434, DateTimeKind.Local).AddTicks(5112), new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), false },
                    { 263, new DateTime(2022, 7, 27, 15, 55, 54, 166, DateTimeKind.Local).AddTicks(2309), new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), true },
                    { 264, new DateTime(2022, 7, 28, 10, 49, 46, 44, DateTimeKind.Local).AddTicks(4194), new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), false },
                    { 265, new DateTime(2022, 7, 28, 6, 11, 46, 718, DateTimeKind.Local).AddTicks(7725), new Guid("499537bf-f642-4d94-91f0-234236984b79"), false },
                    { 266, new DateTime(2022, 7, 28, 11, 56, 18, 68, DateTimeKind.Local).AddTicks(4353), new Guid("24e50499-d459-4100-82b1-626f4a825561"), false },
                    { 267, new DateTime(2022, 7, 28, 13, 0, 53, 374, DateTimeKind.Local).AddTicks(78), new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), true },
                    { 268, new DateTime(2022, 7, 27, 20, 4, 2, 595, DateTimeKind.Local).AddTicks(5156), new Guid("32151eef-e041-48a1-880a-5974d14ee349"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 269, new DateTime(2022, 7, 28, 5, 10, 57, 561, DateTimeKind.Local).AddTicks(4077), new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), true },
                    { 270, new DateTime(2022, 7, 28, 12, 3, 41, 600, DateTimeKind.Local).AddTicks(9062), new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), true },
                    { 271, new DateTime(2022, 7, 28, 0, 12, 41, 930, DateTimeKind.Local).AddTicks(2958), new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), false },
                    { 272, new DateTime(2022, 7, 27, 18, 41, 47, 575, DateTimeKind.Local).AddTicks(2910), new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), false },
                    { 273, new DateTime(2022, 7, 28, 4, 56, 9, 803, DateTimeKind.Local).AddTicks(574), new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), false },
                    { 274, new DateTime(2022, 7, 28, 2, 14, 46, 475, DateTimeKind.Local).AddTicks(189), new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"), false },
                    { 275, new DateTime(2022, 7, 27, 23, 22, 43, 781, DateTimeKind.Local).AddTicks(3952), new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), true },
                    { 276, new DateTime(2022, 7, 28, 1, 20, 17, 315, DateTimeKind.Local).AddTicks(4325), new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), false },
                    { 277, new DateTime(2022, 7, 28, 8, 24, 25, 168, DateTimeKind.Local).AddTicks(6473), new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), true },
                    { 278, new DateTime(2022, 7, 27, 18, 15, 45, 579, DateTimeKind.Local).AddTicks(3841), new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), true },
                    { 279, new DateTime(2022, 7, 28, 4, 12, 53, 946, DateTimeKind.Local).AddTicks(450), new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), true },
                    { 280, new DateTime(2022, 7, 27, 18, 21, 33, 558, DateTimeKind.Local).AddTicks(394), new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), true },
                    { 281, new DateTime(2022, 7, 27, 15, 33, 48, 680, DateTimeKind.Local).AddTicks(9027), new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), true },
                    { 282, new DateTime(2022, 7, 28, 12, 13, 4, 703, DateTimeKind.Local).AddTicks(9995), new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), false },
                    { 283, new DateTime(2022, 7, 28, 9, 54, 46, 905, DateTimeKind.Local).AddTicks(5659), new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), false },
                    { 284, new DateTime(2022, 7, 28, 1, 1, 3, 669, DateTimeKind.Local).AddTicks(7648), new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), false },
                    { 285, new DateTime(2022, 7, 27, 17, 13, 45, 934, DateTimeKind.Local).AddTicks(2123), new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), false },
                    { 286, new DateTime(2022, 7, 27, 14, 20, 9, 555, DateTimeKind.Local).AddTicks(7206), new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), true },
                    { 287, new DateTime(2022, 7, 27, 19, 0, 21, 259, DateTimeKind.Local).AddTicks(2036), new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), false },
                    { 288, new DateTime(2022, 7, 28, 12, 41, 1, 293, DateTimeKind.Local).AddTicks(7821), new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), false },
                    { 289, new DateTime(2022, 7, 28, 13, 20, 5, 642, DateTimeKind.Local).AddTicks(2901), new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), true },
                    { 290, new DateTime(2022, 7, 27, 18, 6, 58, 474, DateTimeKind.Local).AddTicks(7023), new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), true },
                    { 291, new DateTime(2022, 7, 27, 22, 38, 24, 592, DateTimeKind.Local).AddTicks(7697), new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), true },
                    { 292, new DateTime(2022, 7, 27, 18, 42, 50, 91, DateTimeKind.Local).AddTicks(2164), new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), false },
                    { 293, new DateTime(2022, 7, 27, 14, 41, 14, 17, DateTimeKind.Local).AddTicks(3603), new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"), false },
                    { 294, new DateTime(2022, 7, 27, 22, 32, 40, 24, DateTimeKind.Local).AddTicks(4387), new Guid("1282556b-d71b-40f9-be66-a22236c75262"), false },
                    { 295, new DateTime(2022, 7, 28, 10, 57, 26, 778, DateTimeKind.Local).AddTicks(7858), new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), true },
                    { 296, new DateTime(2022, 7, 28, 6, 8, 34, 268, DateTimeKind.Local).AddTicks(7049), new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), false },
                    { 297, new DateTime(2022, 7, 28, 11, 4, 20, 329, DateTimeKind.Local).AddTicks(3857), new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), false },
                    { 298, new DateTime(2022, 7, 28, 4, 3, 41, 229, DateTimeKind.Local).AddTicks(7833), new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"), true },
                    { 299, new DateTime(2022, 7, 28, 0, 50, 26, 902, DateTimeKind.Local).AddTicks(8813), new Guid("06178512-2290-41dd-9f03-713f43b89f48"), false },
                    { 300, new DateTime(2022, 7, 28, 12, 48, 0, 236, DateTimeKind.Local).AddTicks(3809), new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), true },
                    { 301, new DateTime(2022, 7, 28, 0, 22, 32, 36, DateTimeKind.Local).AddTicks(5122), new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), true },
                    { 302, new DateTime(2022, 7, 28, 3, 7, 53, 332, DateTimeKind.Local).AddTicks(5474), new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"), false },
                    { 303, new DateTime(2022, 7, 28, 5, 21, 40, 777, DateTimeKind.Local).AddTicks(8316), new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), true },
                    { 304, new DateTime(2022, 7, 27, 18, 25, 45, 924, DateTimeKind.Local).AddTicks(1376), new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"), true },
                    { 305, new DateTime(2022, 7, 28, 9, 24, 27, 209, DateTimeKind.Local).AddTicks(7208), new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), true },
                    { 306, new DateTime(2022, 7, 28, 6, 28, 20, 812, DateTimeKind.Local).AddTicks(9770), new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), false },
                    { 307, new DateTime(2022, 7, 28, 13, 29, 51, 801, DateTimeKind.Local).AddTicks(7861), new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), true },
                    { 308, new DateTime(2022, 7, 28, 1, 0, 32, 331, DateTimeKind.Local).AddTicks(7957), new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), true },
                    { 309, new DateTime(2022, 7, 28, 2, 1, 47, 783, DateTimeKind.Local).AddTicks(209), new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), false },
                    { 310, new DateTime(2022, 7, 27, 15, 18, 22, 41, DateTimeKind.Local).AddTicks(5941), new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 311, new DateTime(2022, 7, 27, 16, 40, 23, 452, DateTimeKind.Local).AddTicks(6334), new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"), false },
                    { 312, new DateTime(2022, 7, 28, 10, 45, 29, 333, DateTimeKind.Local).AddTicks(2308), new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), true },
                    { 313, new DateTime(2022, 7, 28, 7, 14, 18, 818, DateTimeKind.Local).AddTicks(7760), new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), false },
                    { 314, new DateTime(2022, 7, 28, 9, 17, 25, 142, DateTimeKind.Local).AddTicks(6333), new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), true },
                    { 315, new DateTime(2022, 7, 27, 13, 57, 50, 219, DateTimeKind.Local).AddTicks(7418), new Guid("49259203-2d23-4276-8056-c55ac7b17e51"), false },
                    { 316, new DateTime(2022, 7, 27, 17, 53, 36, 999, DateTimeKind.Local).AddTicks(7444), new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), false },
                    { 317, new DateTime(2022, 7, 28, 9, 43, 58, 812, DateTimeKind.Local).AddTicks(3414), new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), true },
                    { 318, new DateTime(2022, 7, 28, 5, 37, 57, 237, DateTimeKind.Local).AddTicks(1311), new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), false },
                    { 319, new DateTime(2022, 7, 28, 0, 58, 8, 567, DateTimeKind.Local).AddTicks(2379), new Guid("24e50499-d459-4100-82b1-626f4a825561"), true },
                    { 320, new DateTime(2022, 7, 27, 16, 18, 17, 865, DateTimeKind.Local).AddTicks(9573), new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), false },
                    { 321, new DateTime(2022, 7, 28, 8, 19, 26, 867, DateTimeKind.Local).AddTicks(1505), new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), false },
                    { 322, new DateTime(2022, 7, 27, 19, 30, 41, 864, DateTimeKind.Local).AddTicks(5039), new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), false },
                    { 323, new DateTime(2022, 7, 27, 14, 52, 6, 979, DateTimeKind.Local).AddTicks(9022), new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), false },
                    { 324, new DateTime(2022, 7, 28, 9, 9, 34, 146, DateTimeKind.Local).AddTicks(7999), new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), false },
                    { 325, new DateTime(2022, 7, 28, 8, 17, 59, 365, DateTimeKind.Local).AddTicks(6329), new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), false },
                    { 326, new DateTime(2022, 7, 28, 3, 15, 51, 666, DateTimeKind.Local).AddTicks(4468), new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"), false },
                    { 327, new DateTime(2022, 7, 28, 11, 51, 57, 691, DateTimeKind.Local).AddTicks(8450), new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), false },
                    { 328, new DateTime(2022, 7, 28, 0, 57, 43, 337, DateTimeKind.Local).AddTicks(1943), new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"), false },
                    { 329, new DateTime(2022, 7, 28, 8, 11, 28, 738, DateTimeKind.Local).AddTicks(1068), new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), false },
                    { 330, new DateTime(2022, 7, 27, 15, 38, 56, 191, DateTimeKind.Local).AddTicks(8624), new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), true },
                    { 331, new DateTime(2022, 7, 27, 17, 37, 16, 243, DateTimeKind.Local).AddTicks(6989), new Guid("88254423-58cb-4878-afec-5c72d69b1e35"), false },
                    { 332, new DateTime(2022, 7, 28, 0, 43, 57, 656, DateTimeKind.Local).AddTicks(6127), new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), true },
                    { 333, new DateTime(2022, 7, 28, 4, 26, 50, 59, DateTimeKind.Local).AddTicks(2399), new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), true },
                    { 334, new DateTime(2022, 7, 28, 5, 52, 26, 343, DateTimeKind.Local).AddTicks(9767), new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"), false },
                    { 335, new DateTime(2022, 7, 28, 10, 31, 22, 238, DateTimeKind.Local).AddTicks(2669), new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"), true },
                    { 336, new DateTime(2022, 7, 28, 2, 16, 33, 456, DateTimeKind.Local).AddTicks(7081), new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"), true },
                    { 337, new DateTime(2022, 7, 28, 0, 2, 0, 785, DateTimeKind.Local).AddTicks(3527), new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), false },
                    { 338, new DateTime(2022, 7, 27, 14, 41, 25, 56, DateTimeKind.Local).AddTicks(3779), new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), false },
                    { 339, new DateTime(2022, 7, 28, 3, 3, 21, 513, DateTimeKind.Local).AddTicks(5179), new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"), true },
                    { 340, new DateTime(2022, 7, 27, 23, 16, 14, 253, DateTimeKind.Local).AddTicks(6193), new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"), true },
                    { 341, new DateTime(2022, 7, 27, 18, 6, 19, 213, DateTimeKind.Local).AddTicks(2203), new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), true },
                    { 342, new DateTime(2022, 7, 28, 4, 21, 39, 364, DateTimeKind.Local).AddTicks(6556), new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"), true },
                    { 343, new DateTime(2022, 7, 28, 3, 10, 59, 446, DateTimeKind.Local).AddTicks(7419), new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), true },
                    { 344, new DateTime(2022, 7, 27, 15, 44, 37, 415, DateTimeKind.Local).AddTicks(1557), new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), true },
                    { 345, new DateTime(2022, 7, 28, 7, 32, 54, 243, DateTimeKind.Local).AddTicks(7148), new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), true },
                    { 346, new DateTime(2022, 7, 28, 9, 41, 58, 871, DateTimeKind.Local).AddTicks(8228), new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), false },
                    { 347, new DateTime(2022, 7, 28, 13, 34, 44, 232, DateTimeKind.Local).AddTicks(5356), new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), true },
                    { 348, new DateTime(2022, 7, 27, 18, 41, 17, 854, DateTimeKind.Local).AddTicks(3094), new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), false },
                    { 349, new DateTime(2022, 7, 28, 4, 2, 58, 508, DateTimeKind.Local).AddTicks(1297), new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), true },
                    { 350, new DateTime(2022, 7, 28, 9, 43, 6, 322, DateTimeKind.Local).AddTicks(2335), new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), false },
                    { 351, new DateTime(2022, 7, 27, 20, 24, 24, 927, DateTimeKind.Local).AddTicks(1815), new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), true },
                    { 352, new DateTime(2022, 7, 28, 6, 18, 14, 33, DateTimeKind.Local).AddTicks(4345), new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 353, new DateTime(2022, 7, 28, 8, 55, 38, 390, DateTimeKind.Local).AddTicks(8724), new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), false },
                    { 354, new DateTime(2022, 7, 28, 8, 11, 3, 289, DateTimeKind.Local).AddTicks(7985), new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"), false },
                    { 355, new DateTime(2022, 7, 27, 21, 37, 4, 726, DateTimeKind.Local).AddTicks(5914), new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), false },
                    { 356, new DateTime(2022, 7, 28, 1, 0, 37, 524, DateTimeKind.Local).AddTicks(3054), new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), true },
                    { 357, new DateTime(2022, 7, 28, 0, 58, 16, 941, DateTimeKind.Local).AddTicks(5204), new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"), false },
                    { 358, new DateTime(2022, 7, 28, 4, 22, 50, 478, DateTimeKind.Local).AddTicks(1176), new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), false },
                    { 359, new DateTime(2022, 7, 27, 21, 9, 39, 517, DateTimeKind.Local).AddTicks(4306), new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), false },
                    { 360, new DateTime(2022, 7, 28, 9, 3, 48, 695, DateTimeKind.Local).AddTicks(9435), new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), false },
                    { 361, new DateTime(2022, 7, 28, 6, 24, 38, 979, DateTimeKind.Local).AddTicks(5384), new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), false },
                    { 362, new DateTime(2022, 7, 27, 16, 28, 47, 282, DateTimeKind.Local).AddTicks(7203), new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), true },
                    { 363, new DateTime(2022, 7, 28, 6, 49, 12, 963, DateTimeKind.Local).AddTicks(5363), new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), false },
                    { 364, new DateTime(2022, 7, 28, 12, 6, 27, 106, DateTimeKind.Local).AddTicks(430), new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"), false },
                    { 365, new DateTime(2022, 7, 28, 4, 27, 52, 232, DateTimeKind.Local).AddTicks(3123), new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), false },
                    { 366, new DateTime(2022, 7, 27, 20, 41, 23, 444, DateTimeKind.Local).AddTicks(804), new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), false },
                    { 367, new DateTime(2022, 7, 27, 20, 10, 22, 482, DateTimeKind.Local).AddTicks(4458), new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), true },
                    { 368, new DateTime(2022, 7, 27, 21, 47, 42, 894, DateTimeKind.Local).AddTicks(2563), new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), false },
                    { 369, new DateTime(2022, 7, 28, 1, 18, 3, 544, DateTimeKind.Local).AddTicks(8739), new Guid("1282556b-d71b-40f9-be66-a22236c75262"), true },
                    { 370, new DateTime(2022, 7, 28, 13, 30, 31, 243, DateTimeKind.Local).AddTicks(5815), new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), true },
                    { 371, new DateTime(2022, 7, 27, 13, 39, 5, 600, DateTimeKind.Local).AddTicks(8907), new Guid("24021955-aa0d-49ca-92b9-01561f491967"), false },
                    { 372, new DateTime(2022, 7, 28, 2, 9, 45, 991, DateTimeKind.Local).AddTicks(3849), new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"), true },
                    { 373, new DateTime(2022, 7, 28, 6, 57, 31, 937, DateTimeKind.Local).AddTicks(7142), new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"), false },
                    { 374, new DateTime(2022, 7, 28, 2, 12, 14, 593, DateTimeKind.Local).AddTicks(2934), new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), false },
                    { 375, new DateTime(2022, 7, 28, 3, 7, 49, 10, DateTimeKind.Local).AddTicks(3194), new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"), true },
                    { 376, new DateTime(2022, 7, 28, 5, 44, 51, 754, DateTimeKind.Local).AddTicks(26), new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), true },
                    { 377, new DateTime(2022, 7, 28, 8, 4, 33, 975, DateTimeKind.Local).AddTicks(2780), new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), false },
                    { 378, new DateTime(2022, 7, 27, 14, 8, 54, 115, DateTimeKind.Local).AddTicks(4828), new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"), true },
                    { 379, new DateTime(2022, 7, 28, 1, 6, 43, 17, DateTimeKind.Local).AddTicks(2551), new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), true },
                    { 380, new DateTime(2022, 7, 28, 1, 41, 52, 591, DateTimeKind.Local).AddTicks(6476), new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), false },
                    { 381, new DateTime(2022, 7, 27, 23, 55, 13, 954, DateTimeKind.Local).AddTicks(1129), new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), false },
                    { 382, new DateTime(2022, 7, 27, 20, 21, 21, 585, DateTimeKind.Local).AddTicks(9151), new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), false },
                    { 383, new DateTime(2022, 7, 27, 23, 0, 29, 254, DateTimeKind.Local).AddTicks(4318), new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), true },
                    { 384, new DateTime(2022, 7, 27, 16, 21, 51, 858, DateTimeKind.Local).AddTicks(4019), new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), false },
                    { 385, new DateTime(2022, 7, 28, 7, 22, 15, 415, DateTimeKind.Local).AddTicks(8948), new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), false },
                    { 386, new DateTime(2022, 7, 27, 16, 37, 44, 641, DateTimeKind.Local).AddTicks(7083), new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), false },
                    { 387, new DateTime(2022, 7, 28, 9, 18, 13, 602, DateTimeKind.Local).AddTicks(1246), new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"), false },
                    { 388, new DateTime(2022, 7, 27, 15, 22, 11, 838, DateTimeKind.Local).AddTicks(7008), new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), false },
                    { 389, new DateTime(2022, 7, 28, 10, 8, 25, 770, DateTimeKind.Local).AddTicks(4499), new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"), true },
                    { 390, new DateTime(2022, 7, 27, 23, 39, 29, 528, DateTimeKind.Local).AddTicks(2435), new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"), true },
                    { 391, new DateTime(2022, 7, 27, 20, 10, 4, 781, DateTimeKind.Local).AddTicks(650), new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"), true },
                    { 392, new DateTime(2022, 7, 27, 14, 15, 38, 732, DateTimeKind.Local).AddTicks(2919), new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), false },
                    { 393, new DateTime(2022, 7, 28, 6, 38, 13, 294, DateTimeKind.Local).AddTicks(8133), new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"), false },
                    { 394, new DateTime(2022, 7, 28, 9, 18, 12, 440, DateTimeKind.Local).AddTicks(2756), new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 395, new DateTime(2022, 7, 27, 18, 54, 40, 485, DateTimeKind.Local).AddTicks(390), new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), true },
                    { 396, new DateTime(2022, 7, 27, 15, 50, 8, 82, DateTimeKind.Local).AddTicks(6054), new Guid("685df129-d237-414f-8e3d-c676e579dfda"), false },
                    { 397, new DateTime(2022, 7, 28, 7, 56, 34, 165, DateTimeKind.Local).AddTicks(454), new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), true },
                    { 398, new DateTime(2022, 7, 28, 3, 42, 33, 481, DateTimeKind.Local).AddTicks(7720), new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), true },
                    { 399, new DateTime(2022, 7, 27, 17, 38, 5, 248, DateTimeKind.Local).AddTicks(2418), new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"), false },
                    { 400, new DateTime(2022, 7, 27, 20, 28, 45, 922, DateTimeKind.Local).AddTicks(5900), new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"), true },
                    { 401, new DateTime(2022, 7, 27, 16, 47, 21, 967, DateTimeKind.Local).AddTicks(4777), new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), true },
                    { 402, new DateTime(2022, 7, 27, 17, 32, 19, 714, DateTimeKind.Local).AddTicks(9269), new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"), true },
                    { 403, new DateTime(2022, 7, 27, 22, 2, 6, 842, DateTimeKind.Local).AddTicks(7628), new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), false },
                    { 404, new DateTime(2022, 7, 28, 8, 8, 7, 225, DateTimeKind.Local).AddTicks(3307), new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), true },
                    { 405, new DateTime(2022, 7, 27, 15, 34, 46, 57, DateTimeKind.Local).AddTicks(1640), new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"), false },
                    { 406, new DateTime(2022, 7, 27, 22, 56, 59, 778, DateTimeKind.Local).AddTicks(2570), new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), true },
                    { 407, new DateTime(2022, 7, 27, 16, 3, 12, 940, DateTimeKind.Local).AddTicks(2826), new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), false },
                    { 408, new DateTime(2022, 7, 28, 8, 38, 35, 793, DateTimeKind.Local).AddTicks(8856), new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), false },
                    { 409, new DateTime(2022, 7, 27, 21, 1, 3, 295, DateTimeKind.Local).AddTicks(9627), new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"), false },
                    { 410, new DateTime(2022, 7, 28, 2, 39, 49, 413, DateTimeKind.Local).AddTicks(1912), new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"), false },
                    { 411, new DateTime(2022, 7, 28, 3, 7, 14, 408, DateTimeKind.Local).AddTicks(6051), new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), false },
                    { 412, new DateTime(2022, 7, 27, 16, 10, 28, 701, DateTimeKind.Local).AddTicks(7473), new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), true },
                    { 413, new DateTime(2022, 7, 27, 21, 36, 25, 395, DateTimeKind.Local).AddTicks(4990), new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), true },
                    { 414, new DateTime(2022, 7, 27, 19, 7, 26, 573, DateTimeKind.Local).AddTicks(9068), new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), true },
                    { 415, new DateTime(2022, 7, 28, 12, 29, 2, 626, DateTimeKind.Local).AddTicks(1915), new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"), false },
                    { 416, new DateTime(2022, 7, 27, 18, 39, 18, 378, DateTimeKind.Local).AddTicks(9783), new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), false },
                    { 417, new DateTime(2022, 7, 28, 7, 16, 26, 343, DateTimeKind.Local).AddTicks(201), new Guid("06178512-2290-41dd-9f03-713f43b89f48"), false },
                    { 418, new DateTime(2022, 7, 28, 7, 21, 21, 455, DateTimeKind.Local).AddTicks(3668), new Guid("06178512-2290-41dd-9f03-713f43b89f48"), true },
                    { 419, new DateTime(2022, 7, 28, 2, 55, 32, 144, DateTimeKind.Local).AddTicks(1073), new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), false },
                    { 420, new DateTime(2022, 7, 28, 12, 42, 3, 708, DateTimeKind.Local).AddTicks(8322), new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), true },
                    { 421, new DateTime(2022, 7, 28, 5, 56, 33, 729, DateTimeKind.Local).AddTicks(728), new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), false },
                    { 422, new DateTime(2022, 7, 28, 5, 29, 6, 700, DateTimeKind.Local).AddTicks(7833), new Guid("423d8677-5aaa-4113-9037-37b9368d5825"), true },
                    { 423, new DateTime(2022, 7, 27, 16, 2, 9, 436, DateTimeKind.Local).AddTicks(1148), new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"), false },
                    { 424, new DateTime(2022, 7, 28, 8, 9, 59, 116, DateTimeKind.Local).AddTicks(3792), new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"), false },
                    { 425, new DateTime(2022, 7, 27, 19, 8, 58, 121, DateTimeKind.Local).AddTicks(4667), new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"), true },
                    { 426, new DateTime(2022, 7, 28, 11, 52, 47, 842, DateTimeKind.Local).AddTicks(8419), new Guid("24e50499-d459-4100-82b1-626f4a825561"), false },
                    { 427, new DateTime(2022, 7, 28, 4, 53, 42, 868, DateTimeKind.Local).AddTicks(7055), new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"), true },
                    { 428, new DateTime(2022, 7, 27, 16, 26, 7, 589, DateTimeKind.Local).AddTicks(6155), new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), false },
                    { 429, new DateTime(2022, 7, 28, 13, 18, 8, 865, DateTimeKind.Local).AddTicks(1156), new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), true },
                    { 430, new DateTime(2022, 7, 28, 12, 12, 20, 487, DateTimeKind.Local).AddTicks(7045), new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"), true },
                    { 431, new DateTime(2022, 7, 27, 19, 46, 8, 662, DateTimeKind.Local).AddTicks(3799), new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"), false },
                    { 432, new DateTime(2022, 7, 27, 23, 51, 36, 988, DateTimeKind.Local).AddTicks(8878), new Guid("1282556b-d71b-40f9-be66-a22236c75262"), true },
                    { 433, new DateTime(2022, 7, 28, 6, 32, 23, 595, DateTimeKind.Local).AddTicks(3632), new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"), true },
                    { 434, new DateTime(2022, 7, 28, 0, 22, 52, 461, DateTimeKind.Local).AddTicks(6568), new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), true },
                    { 435, new DateTime(2022, 7, 27, 14, 20, 10, 301, DateTimeKind.Local).AddTicks(7946), new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), false },
                    { 436, new DateTime(2022, 7, 27, 20, 15, 50, 682, DateTimeKind.Local).AddTicks(5007), new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 437, new DateTime(2022, 7, 28, 0, 6, 49, 866, DateTimeKind.Local).AddTicks(6834), new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"), false },
                    { 438, new DateTime(2022, 7, 27, 14, 40, 10, 484, DateTimeKind.Local).AddTicks(1219), new Guid("f0f28017-a249-4035-8343-bbc9d2420091"), false },
                    { 439, new DateTime(2022, 7, 27, 18, 31, 34, 629, DateTimeKind.Local).AddTicks(5434), new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), true },
                    { 440, new DateTime(2022, 7, 28, 7, 31, 28, 9, DateTimeKind.Local).AddTicks(5969), new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), false },
                    { 441, new DateTime(2022, 7, 28, 6, 31, 55, 775, DateTimeKind.Local).AddTicks(1417), new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"), false },
                    { 442, new DateTime(2022, 7, 28, 5, 56, 37, 776, DateTimeKind.Local).AddTicks(2819), new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"), true },
                    { 443, new DateTime(2022, 7, 28, 0, 42, 53, 659, DateTimeKind.Local).AddTicks(9256), new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), false },
                    { 444, new DateTime(2022, 7, 27, 18, 18, 12, 163, DateTimeKind.Local).AddTicks(4472), new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), true },
                    { 445, new DateTime(2022, 7, 27, 19, 42, 25, 56, DateTimeKind.Local).AddTicks(3681), new Guid("499537bf-f642-4d94-91f0-234236984b79"), false },
                    { 446, new DateTime(2022, 7, 28, 5, 18, 1, 477, DateTimeKind.Local).AddTicks(1144), new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), true },
                    { 447, new DateTime(2022, 7, 27, 22, 39, 21, 162, DateTimeKind.Local).AddTicks(8274), new Guid("805bebe0-f048-40ae-800d-3c059bd94031"), true },
                    { 448, new DateTime(2022, 7, 27, 18, 42, 23, 585, DateTimeKind.Local).AddTicks(2281), new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"), false },
                    { 449, new DateTime(2022, 7, 28, 4, 40, 3, 873, DateTimeKind.Local).AddTicks(823), new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), true },
                    { 450, new DateTime(2022, 7, 27, 21, 14, 59, 77, DateTimeKind.Local).AddTicks(5342), new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), false },
                    { 451, new DateTime(2022, 7, 27, 17, 35, 49, 392, DateTimeKind.Local).AddTicks(8784), new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), true },
                    { 452, new DateTime(2022, 7, 28, 10, 45, 21, 597, DateTimeKind.Local).AddTicks(5269), new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), true },
                    { 453, new DateTime(2022, 7, 28, 1, 13, 1, 418, DateTimeKind.Local).AddTicks(6918), new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"), true },
                    { 454, new DateTime(2022, 7, 28, 0, 20, 22, 356, DateTimeKind.Local).AddTicks(8333), new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"), false },
                    { 455, new DateTime(2022, 7, 28, 13, 20, 48, 290, DateTimeKind.Local).AddTicks(9304), new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"), true },
                    { 456, new DateTime(2022, 7, 28, 0, 22, 4, 482, DateTimeKind.Local).AddTicks(1622), new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), true },
                    { 457, new DateTime(2022, 7, 27, 14, 57, 21, 71, DateTimeKind.Local).AddTicks(8990), new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"), false },
                    { 458, new DateTime(2022, 7, 28, 13, 36, 41, 599, DateTimeKind.Local).AddTicks(3854), new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), false },
                    { 459, new DateTime(2022, 7, 28, 8, 6, 48, 133, DateTimeKind.Local).AddTicks(6761), new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"), true },
                    { 460, new DateTime(2022, 7, 28, 6, 22, 13, 652, DateTimeKind.Local).AddTicks(2428), new Guid("499537bf-f642-4d94-91f0-234236984b79"), true },
                    { 461, new DateTime(2022, 7, 27, 15, 1, 53, 201, DateTimeKind.Local).AddTicks(7083), new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"), true },
                    { 462, new DateTime(2022, 7, 27, 15, 2, 11, 731, DateTimeKind.Local).AddTicks(7280), new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), true },
                    { 463, new DateTime(2022, 7, 27, 20, 16, 10, 943, DateTimeKind.Local).AddTicks(395), new Guid("b20eb39d-234d-49d8-b960-0921756c9717"), true },
                    { 464, new DateTime(2022, 7, 28, 8, 23, 51, 677, DateTimeKind.Local).AddTicks(3528), new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), false },
                    { 465, new DateTime(2022, 7, 28, 5, 23, 34, 329, DateTimeKind.Local).AddTicks(8010), new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"), false },
                    { 466, new DateTime(2022, 7, 28, 4, 37, 35, 956, DateTimeKind.Local).AddTicks(2242), new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), true },
                    { 467, new DateTime(2022, 7, 27, 13, 58, 8, 595, DateTimeKind.Local).AddTicks(1111), new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"), false },
                    { 468, new DateTime(2022, 7, 28, 7, 53, 23, 598, DateTimeKind.Local).AddTicks(8433), new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"), true },
                    { 469, new DateTime(2022, 7, 27, 17, 35, 12, 663, DateTimeKind.Local).AddTicks(2174), new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"), false },
                    { 470, new DateTime(2022, 7, 27, 16, 21, 37, 616, DateTimeKind.Local).AddTicks(5163), new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"), false },
                    { 471, new DateTime(2022, 7, 27, 21, 26, 51, 814, DateTimeKind.Local).AddTicks(3200), new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"), false },
                    { 472, new DateTime(2022, 7, 27, 20, 33, 30, 631, DateTimeKind.Local).AddTicks(1523), new Guid("685df129-d237-414f-8e3d-c676e579dfda"), true },
                    { 473, new DateTime(2022, 7, 28, 12, 18, 22, 228, DateTimeKind.Local).AddTicks(6370), new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), false },
                    { 474, new DateTime(2022, 7, 27, 14, 49, 0, 60, DateTimeKind.Local).AddTicks(5550), new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"), true },
                    { 475, new DateTime(2022, 7, 27, 14, 39, 41, 795, DateTimeKind.Local).AddTicks(8571), new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"), false },
                    { 476, new DateTime(2022, 7, 28, 10, 42, 31, 31, DateTimeKind.Local).AddTicks(8710), new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), false },
                    { 477, new DateTime(2022, 7, 27, 16, 26, 2, 275, DateTimeKind.Local).AddTicks(5896), new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), false },
                    { 478, new DateTime(2022, 7, 28, 2, 40, 19, 765, DateTimeKind.Local).AddTicks(6798), new Guid("c07240e5-af7f-4376-8a0f-697a35673017"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 479, new DateTime(2022, 7, 28, 2, 34, 58, 74, DateTimeKind.Local).AddTicks(1436), new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"), false },
                    { 480, new DateTime(2022, 7, 27, 14, 9, 28, 331, DateTimeKind.Local).AddTicks(7230), new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"), false },
                    { 481, new DateTime(2022, 7, 28, 8, 32, 2, 316, DateTimeKind.Local).AddTicks(7835), new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"), true },
                    { 482, new DateTime(2022, 7, 27, 19, 41, 27, 329, DateTimeKind.Local).AddTicks(8870), new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"), true },
                    { 483, new DateTime(2022, 7, 27, 17, 33, 56, 507, DateTimeKind.Local).AddTicks(3467), new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"), false },
                    { 484, new DateTime(2022, 7, 27, 22, 10, 28, 940, DateTimeKind.Local).AddTicks(4246), new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"), false },
                    { 485, new DateTime(2022, 7, 27, 13, 46, 24, 413, DateTimeKind.Local).AddTicks(7140), new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"), false },
                    { 486, new DateTime(2022, 7, 27, 20, 35, 56, 636, DateTimeKind.Local).AddTicks(3839), new Guid("685df129-d237-414f-8e3d-c676e579dfda"), false },
                    { 487, new DateTime(2022, 7, 28, 1, 9, 11, 259, DateTimeKind.Local).AddTicks(9276), new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"), true },
                    { 488, new DateTime(2022, 7, 28, 0, 53, 24, 781, DateTimeKind.Local).AddTicks(9666), new Guid("d3358746-c456-4ef3-8747-858d7042a12c"), true },
                    { 489, new DateTime(2022, 7, 27, 23, 28, 14, 781, DateTimeKind.Local).AddTicks(7286), new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"), true },
                    { 490, new DateTime(2022, 7, 28, 13, 6, 27, 44, DateTimeKind.Local).AddTicks(9955), new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"), true },
                    { 491, new DateTime(2022, 7, 28, 10, 20, 59, 135, DateTimeKind.Local).AddTicks(3131), new Guid("32151eef-e041-48a1-880a-5974d14ee349"), true },
                    { 492, new DateTime(2022, 7, 27, 14, 50, 30, 572, DateTimeKind.Local).AddTicks(9440), new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"), true },
                    { 493, new DateTime(2022, 7, 28, 0, 44, 57, 513, DateTimeKind.Local).AddTicks(9622), new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"), false },
                    { 494, new DateTime(2022, 7, 27, 17, 53, 41, 850, DateTimeKind.Local).AddTicks(2492), new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"), true },
                    { 495, new DateTime(2022, 7, 27, 22, 56, 58, 581, DateTimeKind.Local).AddTicks(3229), new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"), false },
                    { 496, new DateTime(2022, 7, 27, 20, 3, 24, 123, DateTimeKind.Local).AddTicks(6848), new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"), false },
                    { 497, new DateTime(2022, 7, 28, 0, 52, 3, 876, DateTimeKind.Local).AddTicks(8766), new Guid("37e3b541-c94b-4840-829e-4b33eac62412"), true },
                    { 498, new DateTime(2022, 7, 27, 18, 52, 2, 984, DateTimeKind.Local).AddTicks(8381), new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"), true },
                    { 499, new DateTime(2022, 7, 28, 1, 34, 54, 769, DateTimeKind.Local).AddTicks(2666), new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"), false },
                    { 500, new DateTime(2022, 7, 28, 1, 37, 16, 539, DateTimeKind.Local).AddTicks(9455), new Guid("08923ec7-373c-43c9-b871-5de4208615d1"), true }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 3, new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c") },
                    { 2, 3, new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27") },
                    { 3, 5, new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac") },
                    { 4, 7, new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad") },
                    { 5, 6, new Guid("32151eef-e041-48a1-880a-5974d14ee349") },
                    { 6, 4, new Guid("edf4e2a9-c3da-434f-8535-6c521c200195") },
                    { 7, 7, new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a") },
                    { 8, 6, new Guid("ffbad71b-4553-4da1-8717-96fd86124da7") },
                    { 9, 7, new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30") },
                    { 10, 2, new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9") },
                    { 11, 6, new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3") },
                    { 12, 6, new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082") },
                    { 13, 4, new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6") },
                    { 14, 3, new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4") },
                    { 15, 4, new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605") },
                    { 16, 4, new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa") },
                    { 17, 3, new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a") },
                    { 18, 7, new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e") },
                    { 19, 1, new Guid("2295b75d-12ab-41b8-bb86-d85deb117893") },
                    { 20, 7, new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 21, 7, new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7") },
                    { 22, 2, new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9") },
                    { 23, 9, new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145") },
                    { 24, 1, new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9") },
                    { 25, 7, new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080") },
                    { 26, 8, new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99") },
                    { 27, 4, new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537") },
                    { 28, 2, new Guid("685df129-d237-414f-8e3d-c676e579dfda") },
                    { 29, 7, new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6") },
                    { 30, 8, new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106") },
                    { 31, 2, new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045") },
                    { 32, 3, new Guid("24e50499-d459-4100-82b1-626f4a825561") },
                    { 33, 9, new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7") },
                    { 34, 1, new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2") },
                    { 35, 6, new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20") },
                    { 36, 4, new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a") },
                    { 37, 5, new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea") },
                    { 38, 1, new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a") },
                    { 39, 6, new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2") },
                    { 40, 7, new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f") },
                    { 41, 5, new Guid("aabd0da9-4e63-4113-926d-210eec1b4761") },
                    { 42, 7, new Guid("1282556b-d71b-40f9-be66-a22236c75262") },
                    { 43, 6, new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026") },
                    { 44, 1, new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48") },
                    { 45, 2, new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a") },
                    { 46, 8, new Guid("499537bf-f642-4d94-91f0-234236984b79") },
                    { 47, 7, new Guid("08923ec7-373c-43c9-b871-5de4208615d1") },
                    { 48, 1, new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545") },
                    { 49, 5, new Guid("805bebe0-f048-40ae-800d-3c059bd94031") },
                    { 50, 2, new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f") },
                    { 51, 9, new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394") },
                    { 52, 6, new Guid("b20eb39d-234d-49d8-b960-0921756c9717") },
                    { 53, 2, new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8") },
                    { 54, 8, new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0") },
                    { 55, 9, new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c") },
                    { 56, 6, new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb") },
                    { 57, 9, new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be") },
                    { 58, 4, new Guid("37e3b541-c94b-4840-829e-4b33eac62412") },
                    { 59, 8, new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d") },
                    { 60, 8, new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b") },
                    { 61, 1, new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a") },
                    { 62, 8, new Guid("ae035edd-0732-4044-982c-d306f47b49f3") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 63, 5, new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1") },
                    { 64, 8, new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083") },
                    { 65, 1, new Guid("24021955-aa0d-49ca-92b9-01561f491967") },
                    { 66, 6, new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15") },
                    { 67, 9, new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1") },
                    { 68, 2, new Guid("88254423-58cb-4878-afec-5c72d69b1e35") },
                    { 69, 6, new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365") },
                    { 70, 3, new Guid("fec613b6-4978-4380-ba93-03f9172b66c1") },
                    { 71, 6, new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3") },
                    { 72, 5, new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a") },
                    { 73, 9, new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1") },
                    { 74, 6, new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f") },
                    { 75, 5, new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7") },
                    { 76, 9, new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5") },
                    { 77, 9, new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852") },
                    { 78, 8, new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba") },
                    { 79, 7, new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb") },
                    { 80, 1, new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6") },
                    { 81, 3, new Guid("06178512-2290-41dd-9f03-713f43b89f48") },
                    { 82, 5, new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc") },
                    { 83, 3, new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5") },
                    { 84, 7, new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826") },
                    { 85, 2, new Guid("d3358746-c456-4ef3-8747-858d7042a12c") },
                    { 86, 2, new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e") },
                    { 87, 6, new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97") },
                    { 88, 7, new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45") },
                    { 89, 2, new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984") },
                    { 90, 5, new Guid("f0f28017-a249-4035-8343-bbc9d2420091") },
                    { 91, 5, new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d") },
                    { 92, 2, new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2") },
                    { 93, 7, new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa") },
                    { 94, 1, new Guid("c07240e5-af7f-4376-8a0f-697a35673017") },
                    { 95, 1, new Guid("49259203-2d23-4276-8056-c55ac7b17e51") },
                    { 96, 8, new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7") },
                    { 97, 4, new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e") },
                    { 98, 7, new Guid("423d8677-5aaa-4113-9037-37b9368d5825") },
                    { 99, 5, new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5") },
                    { 100, 1, new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c") },
                    { 2, 2, new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27") },
                    { 3, 3, new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac") },
                    { 4, 4, new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 5, 5, new Guid("32151eef-e041-48a1-880a-5974d14ee349") },
                    { 6, 6, new Guid("edf4e2a9-c3da-434f-8535-6c521c200195") },
                    { 7, 7, new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a") },
                    { 8, 8, new Guid("ffbad71b-4553-4da1-8717-96fd86124da7") },
                    { 9, 9, new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30") },
                    { 10, 10, new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9") },
                    { 11, 11, new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3") },
                    { 12, 12, new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082") },
                    { 13, 13, new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6") },
                    { 14, 14, new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4") },
                    { 15, 15, new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605") },
                    { 16, 16, new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa") },
                    { 17, 17, new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a") },
                    { 18, 18, new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e") },
                    { 19, 19, new Guid("2295b75d-12ab-41b8-bb86-d85deb117893") },
                    { 20, 20, new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533") },
                    { 21, 21, new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7") },
                    { 22, 22, new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9") },
                    { 23, 23, new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145") },
                    { 24, 24, new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9") },
                    { 25, 25, new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080") },
                    { 26, 26, new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99") },
                    { 27, 27, new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537") },
                    { 28, 28, new Guid("685df129-d237-414f-8e3d-c676e579dfda") },
                    { 29, 29, new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6") },
                    { 30, 30, new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106") },
                    { 31, 31, new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045") },
                    { 32, 32, new Guid("24e50499-d459-4100-82b1-626f4a825561") },
                    { 33, 33, new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7") },
                    { 34, 34, new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2") },
                    { 35, 35, new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20") },
                    { 36, 36, new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a") },
                    { 37, 37, new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea") },
                    { 38, 38, new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a") },
                    { 39, 39, new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2") },
                    { 40, 40, new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f") },
                    { 41, 41, new Guid("aabd0da9-4e63-4113-926d-210eec1b4761") },
                    { 42, 42, new Guid("1282556b-d71b-40f9-be66-a22236c75262") },
                    { 43, 43, new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026") },
                    { 44, 44, new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48") },
                    { 45, 45, new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a") },
                    { 46, 46, new Guid("499537bf-f642-4d94-91f0-234236984b79") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 47, 47, new Guid("08923ec7-373c-43c9-b871-5de4208615d1") },
                    { 48, 48, new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545") },
                    { 49, 49, new Guid("805bebe0-f048-40ae-800d-3c059bd94031") },
                    { 50, 50, new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f") },
                    { 51, 51, new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394") },
                    { 52, 52, new Guid("b20eb39d-234d-49d8-b960-0921756c9717") },
                    { 53, 53, new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8") },
                    { 54, 54, new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0") },
                    { 55, 55, new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c") },
                    { 56, 56, new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb") },
                    { 57, 57, new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be") },
                    { 58, 58, new Guid("37e3b541-c94b-4840-829e-4b33eac62412") },
                    { 59, 59, new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d") },
                    { 60, 60, new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b") },
                    { 61, 61, new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a") },
                    { 62, 62, new Guid("ae035edd-0732-4044-982c-d306f47b49f3") },
                    { 63, 63, new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1") },
                    { 64, 64, new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083") },
                    { 65, 65, new Guid("24021955-aa0d-49ca-92b9-01561f491967") },
                    { 66, 66, new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15") },
                    { 67, 67, new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1") },
                    { 68, 68, new Guid("88254423-58cb-4878-afec-5c72d69b1e35") },
                    { 69, 69, new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365") },
                    { 70, 70, new Guid("fec613b6-4978-4380-ba93-03f9172b66c1") },
                    { 71, 71, new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3") },
                    { 72, 72, new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a") },
                    { 73, 73, new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1") },
                    { 74, 74, new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f") },
                    { 75, 75, new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7") },
                    { 76, 76, new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5") },
                    { 77, 77, new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852") },
                    { 78, 78, new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba") },
                    { 79, 79, new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb") },
                    { 80, 80, new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6") },
                    { 81, 81, new Guid("06178512-2290-41dd-9f03-713f43b89f48") },
                    { 82, 82, new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc") },
                    { 83, 83, new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5") },
                    { 84, 84, new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826") },
                    { 85, 85, new Guid("d3358746-c456-4ef3-8747-858d7042a12c") },
                    { 86, 86, new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e") },
                    { 87, 87, new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97") },
                    { 88, 88, new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 89, 89, new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984") },
                    { 90, 90, new Guid("f0f28017-a249-4035-8343-bbc9d2420091") },
                    { 91, 91, new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d") },
                    { 92, 92, new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2") },
                    { 93, 93, new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa") },
                    { 94, 94, new Guid("c07240e5-af7f-4376-8a0f-697a35673017") },
                    { 95, 95, new Guid("49259203-2d23-4276-8056-c55ac7b17e51") },
                    { 96, 96, new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7") },
                    { 97, 97, new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e") },
                    { 98, 98, new Guid("423d8677-5aaa-4113-9037-37b9368d5825") },
                    { 99, 99, new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5") },
                    { 100, 100, new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c") },
                    { 2, 1, new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27") },
                    { 3, 1, new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac") },
                    { 4, 1, new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad") },
                    { 5, 1, new Guid("32151eef-e041-48a1-880a-5974d14ee349") },
                    { 6, 1, new Guid("edf4e2a9-c3da-434f-8535-6c521c200195") },
                    { 7, 1, new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a") },
                    { 8, 1, new Guid("ffbad71b-4553-4da1-8717-96fd86124da7") },
                    { 9, 1, new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30") },
                    { 10, 1, new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9") },
                    { 11, 1, new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3") },
                    { 12, 1, new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082") },
                    { 13, 1, new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6") },
                    { 14, 1, new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4") },
                    { 15, 1, new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605") },
                    { 16, 1, new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa") },
                    { 17, 1, new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a") },
                    { 18, 1, new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e") },
                    { 19, 1, new Guid("2295b75d-12ab-41b8-bb86-d85deb117893") },
                    { 20, 1, new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533") },
                    { 21, 1, new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7") },
                    { 22, 1, new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9") },
                    { 23, 1, new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145") },
                    { 24, 1, new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9") },
                    { 25, 1, new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080") },
                    { 26, 1, new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99") },
                    { 27, 1, new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537") },
                    { 28, 1, new Guid("685df129-d237-414f-8e3d-c676e579dfda") },
                    { 29, 1, new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6") },
                    { 30, 1, new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 31, 1, new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045") },
                    { 32, 1, new Guid("24e50499-d459-4100-82b1-626f4a825561") },
                    { 33, 1, new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7") },
                    { 34, 1, new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2") },
                    { 35, 1, new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20") },
                    { 36, 1, new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a") },
                    { 37, 1, new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea") },
                    { 38, 1, new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a") },
                    { 39, 1, new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2") },
                    { 40, 1, new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f") },
                    { 41, 1, new Guid("aabd0da9-4e63-4113-926d-210eec1b4761") },
                    { 42, 1, new Guid("1282556b-d71b-40f9-be66-a22236c75262") },
                    { 43, 1, new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026") },
                    { 44, 1, new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48") },
                    { 45, 1, new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a") },
                    { 46, 1, new Guid("499537bf-f642-4d94-91f0-234236984b79") },
                    { 47, 1, new Guid("08923ec7-373c-43c9-b871-5de4208615d1") },
                    { 48, 1, new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545") },
                    { 49, 1, new Guid("805bebe0-f048-40ae-800d-3c059bd94031") },
                    { 50, 1, new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f") },
                    { 51, 1, new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394") },
                    { 52, 1, new Guid("b20eb39d-234d-49d8-b960-0921756c9717") },
                    { 53, 1, new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8") },
                    { 54, 1, new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0") },
                    { 55, 1, new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c") },
                    { 56, 1, new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb") },
                    { 57, 1, new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be") },
                    { 58, 1, new Guid("37e3b541-c94b-4840-829e-4b33eac62412") },
                    { 59, 1, new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d") },
                    { 60, 1, new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b") },
                    { 61, 1, new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a") },
                    { 62, 1, new Guid("ae035edd-0732-4044-982c-d306f47b49f3") },
                    { 63, 1, new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1") },
                    { 64, 1, new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083") },
                    { 65, 1, new Guid("24021955-aa0d-49ca-92b9-01561f491967") },
                    { 66, 1, new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15") },
                    { 67, 1, new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1") },
                    { 68, 1, new Guid("88254423-58cb-4878-afec-5c72d69b1e35") },
                    { 69, 1, new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365") },
                    { 70, 1, new Guid("fec613b6-4978-4380-ba93-03f9172b66c1") },
                    { 71, 1, new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3") },
                    { 72, 1, new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 73, 1, new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1") },
                    { 74, 1, new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f") },
                    { 75, 1, new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7") },
                    { 76, 1, new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5") },
                    { 77, 1, new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852") },
                    { 78, 1, new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba") },
                    { 79, 1, new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb") },
                    { 80, 1, new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6") },
                    { 81, 1, new Guid("06178512-2290-41dd-9f03-713f43b89f48") },
                    { 82, 1, new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc") },
                    { 83, 1, new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5") },
                    { 84, 1, new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826") },
                    { 85, 1, new Guid("d3358746-c456-4ef3-8747-858d7042a12c") },
                    { 86, 1, new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e") },
                    { 87, 1, new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97") },
                    { 88, 1, new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45") },
                    { 89, 1, new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984") },
                    { 90, 1, new Guid("f0f28017-a249-4035-8343-bbc9d2420091") },
                    { 91, 1, new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d") },
                    { 92, 1, new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2") },
                    { 93, 1, new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa") },
                    { 94, 1, new Guid("c07240e5-af7f-4376-8a0f-697a35673017") },
                    { 95, 1, new Guid("49259203-2d23-4276-8056-c55ac7b17e51") },
                    { 96, 1, new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7") },
                    { 97, 1, new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e") },
                    { 98, 1, new Guid("423d8677-5aaa-4113-9037-37b9368d5825") },
                    { 99, 1, new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5") },
                    { 100, 1, new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61") }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 1, 1, 1, 3 },
                    { 2, 1, 2, 12 },
                    { 3, 1, 3, 8 },
                    { 4, 1, 4, 18 },
                    { 5, 1, 5, 3 },
                    { 6, 1, 6, 1 },
                    { 7, 1, 7, 6 },
                    { 8, 1, 8, 8 },
                    { 9, 1, 9, 8 },
                    { 10, 1, 10, 15 },
                    { 11, 1, 11, 18 },
                    { 12, 1, 12, 10 },
                    { 13, 1, 13, 4 },
                    { 14, 1, 14, 2 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 15, 1, 15, 15 },
                    { 16, 1, 16, 5 },
                    { 17, 1, 17, 12 },
                    { 18, 1, 18, 5 },
                    { 19, 1, 19, 4 },
                    { 20, 1, 20, 6 },
                    { 21, 1, 21, 14 },
                    { 22, 1, 22, 17 },
                    { 23, 1, 23, 9 },
                    { 24, 1, 24, 7 },
                    { 25, 1, 25, 1 },
                    { 26, 1, 26, 11 },
                    { 27, 1, 27, 7 },
                    { 28, 1, 28, 8 },
                    { 29, 1, 29, 10 },
                    { 30, 1, 30, 9 },
                    { 31, 1, 31, 18 },
                    { 32, 1, 32, 2 },
                    { 33, 1, 33, 10 },
                    { 34, 1, 34, 7 },
                    { 35, 1, 35, 8 },
                    { 36, 1, 36, 1 },
                    { 37, 1, 37, 7 },
                    { 38, 1, 38, 14 },
                    { 39, 1, 39, 18 },
                    { 40, 2, 40, 16 },
                    { 41, 2, 41, 14 },
                    { 42, 2, 42, 11 },
                    { 43, 2, 43, 12 },
                    { 44, 2, 44, 2 },
                    { 45, 2, 45, 15 },
                    { 46, 2, 46, 3 },
                    { 47, 2, 47, 1 },
                    { 48, 2, 48, 3 },
                    { 49, 2, 49, 6 },
                    { 50, 2, 50, 15 },
                    { 51, 2, 51, 5 },
                    { 52, 2, 52, 15 },
                    { 53, 2, 53, 2 },
                    { 54, 2, 54, 4 },
                    { 55, 2, 55, 2 },
                    { 56, 2, 56, 14 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 57, 2, 57, 10 },
                    { 58, 2, 58, 17 },
                    { 59, 2, 59, 15 },
                    { 60, 2, 60, 6 },
                    { 61, 2, 61, 1 },
                    { 62, 2, 62, 1 },
                    { 63, 2, 63, 11 },
                    { 64, 2, 64, 16 },
                    { 65, 2, 65, 10 },
                    { 66, 2, 66, 6 },
                    { 67, 2, 67, 1 },
                    { 68, 2, 68, 11 },
                    { 69, 2, 69, 17 },
                    { 70, 2, 70, 4 },
                    { 71, 2, 71, 18 },
                    { 72, 2, 72, 13 },
                    { 73, 2, 73, 4 },
                    { 74, 2, 74, 13 },
                    { 75, 2, 75, 3 },
                    { 76, 2, 76, 13 },
                    { 77, 2, 77, 5 },
                    { 78, 2, 78, 2 },
                    { 79, 2, 79, 10 },
                    { 80, 3, 80, 8 },
                    { 81, 3, 81, 7 },
                    { 82, 3, 82, 17 },
                    { 83, 3, 83, 5 },
                    { 84, 3, 84, 13 },
                    { 85, 3, 85, 13 },
                    { 86, 3, 86, 14 },
                    { 87, 3, 87, 11 },
                    { 88, 3, 88, 16 },
                    { 89, 3, 89, 10 },
                    { 90, 3, 90, 18 },
                    { 91, 3, 91, 14 },
                    { 92, 3, 92, 8 },
                    { 93, 3, 93, 18 },
                    { 94, 3, 94, 10 },
                    { 95, 3, 95, 9 },
                    { 96, 3, 96, 8 },
                    { 97, 3, 97, 15 },
                    { 98, 3, 98, 12 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 99, 3, 99, 18 },
                    { 100, 3, 100, 13 },
                    { 101, 3, 101, 15 },
                    { 102, 3, 102, 12 },
                    { 103, 3, 103, 7 },
                    { 104, 3, 104, 13 },
                    { 105, 3, 105, 17 },
                    { 106, 3, 106, 6 },
                    { 107, 3, 107, 1 },
                    { 108, 3, 108, 14 },
                    { 109, 3, 109, 17 },
                    { 110, 3, 110, 15 },
                    { 111, 3, 111, 15 },
                    { 112, 3, 112, 13 },
                    { 113, 3, 113, 8 },
                    { 114, 3, 114, 13 },
                    { 115, 3, 115, 10 },
                    { 116, 3, 116, 14 },
                    { 117, 3, 117, 6 },
                    { 118, 3, 118, 2 },
                    { 119, 3, 119, 10 },
                    { 120, 4, 120, 12 },
                    { 121, 4, 121, 12 },
                    { 122, 4, 122, 1 },
                    { 123, 4, 123, 2 },
                    { 124, 4, 124, 7 },
                    { 125, 4, 125, 8 },
                    { 126, 4, 126, 6 },
                    { 127, 4, 127, 4 },
                    { 128, 4, 128, 10 },
                    { 129, 4, 129, 12 },
                    { 130, 4, 130, 1 },
                    { 131, 4, 131, 9 },
                    { 132, 4, 132, 10 },
                    { 133, 4, 133, 7 },
                    { 134, 4, 134, 2 },
                    { 135, 4, 135, 12 },
                    { 136, 4, 136, 14 },
                    { 137, 4, 137, 14 },
                    { 138, 4, 138, 9 },
                    { 139, 4, 139, 2 },
                    { 140, 4, 140, 6 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 141, 4, 141, 7 },
                    { 142, 4, 142, 15 },
                    { 143, 4, 143, 18 },
                    { 144, 4, 144, 2 },
                    { 145, 4, 145, 7 },
                    { 146, 4, 146, 8 },
                    { 147, 4, 147, 13 },
                    { 148, 4, 148, 10 },
                    { 149, 4, 149, 3 },
                    { 150, 4, 150, 2 },
                    { 151, 4, 151, 11 },
                    { 152, 4, 152, 13 },
                    { 153, 4, 153, 2 },
                    { 154, 4, 154, 10 },
                    { 155, 4, 155, 2 },
                    { 156, 4, 156, 7 },
                    { 157, 4, 157, 15 },
                    { 158, 4, 158, 3 },
                    { 159, 4, 159, 12 },
                    { 160, 5, 160, 2 },
                    { 161, 5, 161, 16 },
                    { 162, 5, 162, 4 },
                    { 163, 5, 163, 15 },
                    { 164, 5, 164, 12 },
                    { 165, 5, 165, 8 },
                    { 166, 5, 166, 10 },
                    { 167, 5, 167, 12 },
                    { 168, 5, 168, 11 },
                    { 169, 5, 169, 17 },
                    { 170, 5, 170, 3 },
                    { 171, 5, 171, 12 },
                    { 172, 5, 172, 8 },
                    { 173, 5, 173, 1 },
                    { 174, 5, 174, 4 },
                    { 175, 5, 175, 12 },
                    { 176, 5, 176, 2 },
                    { 177, 5, 177, 2 },
                    { 178, 5, 178, 14 },
                    { 179, 5, 179, 2 },
                    { 180, 5, 180, 10 },
                    { 181, 5, 181, 13 },
                    { 182, 5, 182, 6 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 183, 5, 183, 5 },
                    { 184, 5, 184, 6 },
                    { 185, 5, 185, 4 },
                    { 186, 5, 186, 9 },
                    { 187, 5, 187, 16 },
                    { 188, 5, 188, 6 },
                    { 189, 5, 189, 7 },
                    { 190, 5, 190, 15 },
                    { 191, 5, 191, 17 },
                    { 192, 5, 192, 13 },
                    { 193, 5, 193, 1 },
                    { 194, 5, 194, 13 },
                    { 195, 5, 195, 18 },
                    { 196, 5, 196, 6 },
                    { 197, 5, 197, 4 },
                    { 198, 5, 198, 6 },
                    { 199, 5, 199, 7 },
                    { 200, 6, 200, 5 },
                    { 201, 6, 201, 13 },
                    { 202, 6, 202, 14 },
                    { 203, 6, 203, 15 },
                    { 204, 6, 204, 14 },
                    { 205, 6, 205, 5 },
                    { 206, 6, 206, 9 },
                    { 207, 6, 207, 7 },
                    { 208, 6, 208, 6 },
                    { 209, 6, 209, 1 },
                    { 210, 6, 210, 2 },
                    { 211, 6, 211, 1 },
                    { 212, 6, 212, 12 },
                    { 213, 6, 213, 17 },
                    { 214, 6, 214, 12 },
                    { 215, 6, 215, 1 },
                    { 216, 6, 216, 6 },
                    { 217, 6, 217, 9 },
                    { 218, 6, 218, 17 },
                    { 219, 6, 219, 1 },
                    { 220, 6, 220, 6 },
                    { 221, 6, 221, 8 },
                    { 222, 6, 222, 17 },
                    { 223, 6, 223, 14 },
                    { 224, 6, 224, 3 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 225, 6, 225, 3 },
                    { 226, 6, 226, 14 },
                    { 227, 6, 227, 18 },
                    { 228, 6, 228, 5 },
                    { 229, 6, 229, 3 },
                    { 230, 6, 230, 13 },
                    { 231, 6, 231, 9 },
                    { 232, 6, 232, 8 },
                    { 233, 6, 233, 12 },
                    { 234, 6, 234, 9 },
                    { 235, 6, 235, 8 },
                    { 236, 6, 236, 6 },
                    { 237, 6, 237, 13 },
                    { 238, 6, 238, 2 },
                    { 239, 6, 239, 11 },
                    { 240, 7, 240, 3 },
                    { 241, 7, 241, 3 },
                    { 242, 7, 242, 3 },
                    { 243, 7, 243, 15 },
                    { 244, 7, 244, 1 },
                    { 245, 7, 245, 8 },
                    { 246, 7, 246, 3 },
                    { 247, 7, 247, 5 },
                    { 248, 7, 248, 12 },
                    { 249, 7, 249, 16 },
                    { 250, 7, 250, 17 },
                    { 251, 7, 251, 8 },
                    { 252, 7, 252, 7 },
                    { 253, 7, 253, 18 },
                    { 254, 7, 254, 10 },
                    { 255, 7, 255, 10 },
                    { 256, 7, 256, 12 },
                    { 257, 7, 257, 2 },
                    { 258, 7, 258, 3 },
                    { 259, 7, 259, 7 },
                    { 260, 7, 260, 10 },
                    { 261, 7, 261, 5 },
                    { 262, 7, 262, 7 },
                    { 263, 7, 263, 17 },
                    { 264, 7, 264, 3 },
                    { 265, 7, 265, 8 },
                    { 266, 7, 266, 12 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 267, 7, 267, 11 },
                    { 268, 7, 268, 9 },
                    { 269, 7, 269, 6 },
                    { 270, 7, 270, 13 },
                    { 271, 7, 271, 12 },
                    { 272, 7, 272, 4 },
                    { 273, 7, 273, 17 },
                    { 274, 7, 274, 11 },
                    { 275, 7, 275, 8 },
                    { 276, 7, 276, 1 },
                    { 277, 7, 277, 2 },
                    { 278, 7, 278, 11 },
                    { 279, 7, 279, 2 },
                    { 280, 8, 280, 9 },
                    { 281, 8, 281, 3 },
                    { 282, 8, 282, 10 },
                    { 283, 8, 283, 3 },
                    { 284, 8, 284, 11 },
                    { 285, 8, 285, 1 },
                    { 286, 8, 286, 14 },
                    { 287, 8, 287, 17 },
                    { 288, 8, 288, 13 },
                    { 289, 8, 289, 8 },
                    { 290, 8, 290, 8 },
                    { 291, 8, 291, 17 },
                    { 292, 8, 292, 5 },
                    { 293, 8, 293, 1 },
                    { 294, 8, 294, 18 },
                    { 295, 8, 295, 8 },
                    { 296, 8, 296, 18 },
                    { 297, 8, 297, 4 },
                    { 298, 8, 298, 17 },
                    { 299, 8, 299, 11 },
                    { 300, 8, 300, 12 },
                    { 301, 8, 301, 3 },
                    { 302, 8, 302, 4 },
                    { 303, 8, 303, 17 },
                    { 304, 8, 304, 11 },
                    { 305, 8, 305, 12 },
                    { 306, 8, 306, 8 },
                    { 307, 8, 307, 1 },
                    { 308, 8, 308, 10 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 309, 8, 309, 2 },
                    { 310, 8, 310, 7 },
                    { 311, 8, 311, 8 },
                    { 312, 8, 312, 11 },
                    { 313, 8, 313, 4 },
                    { 314, 8, 314, 16 },
                    { 315, 8, 315, 3 },
                    { 316, 8, 316, 18 },
                    { 317, 8, 317, 10 },
                    { 318, 8, 318, 1 },
                    { 319, 8, 319, 10 },
                    { 320, 9, 320, 12 },
                    { 321, 9, 321, 13 },
                    { 322, 9, 322, 3 },
                    { 323, 9, 323, 9 },
                    { 324, 9, 324, 10 },
                    { 325, 9, 325, 17 },
                    { 326, 9, 326, 18 },
                    { 327, 9, 327, 6 },
                    { 328, 9, 328, 6 },
                    { 329, 9, 329, 12 },
                    { 330, 9, 330, 18 },
                    { 331, 9, 331, 3 },
                    { 332, 9, 332, 15 },
                    { 333, 9, 333, 2 },
                    { 334, 9, 334, 15 },
                    { 335, 9, 335, 15 },
                    { 336, 9, 336, 16 },
                    { 337, 9, 337, 15 },
                    { 338, 9, 338, 2 },
                    { 339, 9, 339, 14 },
                    { 340, 9, 340, 3 },
                    { 341, 9, 341, 16 },
                    { 342, 9, 342, 17 },
                    { 343, 9, 343, 5 },
                    { 344, 9, 344, 15 },
                    { 345, 9, 345, 4 },
                    { 346, 9, 346, 8 },
                    { 347, 9, 347, 16 },
                    { 348, 9, 348, 16 },
                    { 349, 9, 349, 16 },
                    { 350, 9, 350, 10 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 351, 9, 351, 8 },
                    { 352, 9, 352, 9 },
                    { 353, 9, 353, 6 },
                    { 354, 9, 354, 7 },
                    { 355, 9, 355, 17 },
                    { 356, 9, 356, 7 },
                    { 357, 9, 357, 16 },
                    { 358, 9, 358, 16 },
                    { 359, 9, 359, 14 },
                    { 360, 10, 360, 12 },
                    { 361, 10, 361, 8 },
                    { 362, 10, 362, 16 },
                    { 363, 10, 363, 14 },
                    { 364, 10, 364, 8 },
                    { 365, 10, 365, 5 },
                    { 366, 10, 366, 16 },
                    { 367, 10, 367, 3 },
                    { 368, 10, 368, 1 },
                    { 369, 10, 369, 14 },
                    { 370, 10, 370, 13 },
                    { 371, 10, 371, 1 },
                    { 372, 10, 372, 13 },
                    { 373, 10, 373, 7 },
                    { 374, 10, 374, 8 },
                    { 375, 10, 375, 7 },
                    { 376, 10, 376, 9 },
                    { 377, 10, 377, 13 },
                    { 378, 10, 378, 3 },
                    { 379, 10, 379, 18 },
                    { 380, 10, 380, 10 },
                    { 381, 10, 381, 12 },
                    { 382, 10, 382, 10 },
                    { 383, 10, 383, 7 },
                    { 384, 10, 384, 12 },
                    { 385, 10, 385, 13 },
                    { 386, 10, 386, 12 },
                    { 387, 10, 387, 10 },
                    { 388, 10, 388, 16 },
                    { 389, 10, 389, 1 },
                    { 390, 10, 390, 12 },
                    { 391, 10, 391, 11 },
                    { 392, 10, 392, 15 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 393, 10, 393, 15 },
                    { 394, 10, 394, 2 },
                    { 395, 10, 395, 3 },
                    { 396, 10, 396, 2 },
                    { 397, 10, 397, 13 },
                    { 398, 10, 398, 14 },
                    { 399, 10, 399, 13 },
                    { 400, 10, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "LessonApprove",
                columns: new[] { "LessonApproveID", "FK_ApproveID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 25, 1 },
                    { 2, 14, 2 },
                    { 3, 7, 3 },
                    { 4, 21, 4 },
                    { 5, 30, 5 },
                    { 6, 20, 6 },
                    { 7, 22, 7 },
                    { 8, 26, 8 },
                    { 9, 18, 9 },
                    { 10, 12, 10 },
                    { 11, 6, 11 },
                    { 12, 10, 12 },
                    { 13, 4, 13 },
                    { 14, 1, 14 },
                    { 15, 5, 15 },
                    { 16, 27, 16 },
                    { 17, 29, 17 },
                    { 18, 8, 18 },
                    { 19, 13, 19 },
                    { 20, 9, 20 },
                    { 21, 15, 21 },
                    { 22, 23, 22 },
                    { 23, 2, 23 },
                    { 24, 24, 24 },
                    { 25, 28, 25 },
                    { 26, 3, 26 },
                    { 27, 11, 27 },
                    { 28, 19, 28 },
                    { 29, 17, 29 },
                    { 30, 16, 30 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 173, 1 },
                    { 2, 212, 2 },
                    { 3, 227, 3 },
                    { 4, 242, 4 },
                    { 5, 139, 5 },
                    { 6, 500, 6 },
                    { 7, 447, 7 },
                    { 8, 348, 8 },
                    { 9, 287, 9 },
                    { 10, 42, 10 },
                    { 11, 215, 11 },
                    { 12, 25, 12 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 13, 469, 13 },
                    { 14, 432, 14 },
                    { 15, 110, 15 },
                    { 16, 486, 16 },
                    { 17, 479, 17 },
                    { 18, 399, 18 },
                    { 19, 295, 19 },
                    { 20, 484, 20 },
                    { 21, 63, 21 },
                    { 22, 460, 22 },
                    { 23, 234, 23 },
                    { 24, 375, 24 },
                    { 25, 16, 25 },
                    { 26, 451, 26 },
                    { 27, 138, 27 },
                    { 28, 262, 28 },
                    { 29, 57, 29 },
                    { 30, 233, 30 },
                    { 31, 351, 31 },
                    { 32, 82, 32 },
                    { 33, 313, 33 },
                    { 34, 10, 34 },
                    { 35, 175, 35 },
                    { 36, 68, 36 },
                    { 37, 86, 37 },
                    { 38, 320, 38 },
                    { 39, 153, 39 },
                    { 40, 172, 40 },
                    { 41, 94, 41 },
                    { 42, 91, 42 },
                    { 43, 217, 43 },
                    { 44, 355, 44 },
                    { 45, 7, 45 },
                    { 46, 85, 46 },
                    { 47, 413, 47 },
                    { 48, 166, 48 },
                    { 49, 382, 49 },
                    { 50, 316, 50 },
                    { 51, 307, 51 },
                    { 52, 310, 52 },
                    { 53, 395, 53 },
                    { 54, 327, 54 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 55, 70, 55 },
                    { 56, 156, 56 },
                    { 57, 177, 57 },
                    { 58, 155, 58 },
                    { 59, 443, 59 },
                    { 60, 6, 60 },
                    { 61, 371, 61 },
                    { 62, 144, 62 },
                    { 63, 252, 63 },
                    { 64, 119, 64 },
                    { 65, 473, 65 },
                    { 66, 372, 66 },
                    { 67, 384, 67 },
                    { 68, 209, 68 },
                    { 69, 19, 69 },
                    { 70, 300, 70 },
                    { 71, 194, 71 },
                    { 72, 111, 72 },
                    { 73, 122, 73 },
                    { 74, 489, 74 },
                    { 75, 397, 75 },
                    { 76, 335, 76 },
                    { 77, 301, 77 },
                    { 78, 199, 78 },
                    { 79, 66, 79 },
                    { 80, 314, 80 },
                    { 81, 90, 81 },
                    { 82, 231, 82 },
                    { 83, 190, 83 },
                    { 84, 271, 84 },
                    { 85, 238, 85 },
                    { 86, 435, 86 },
                    { 87, 23, 87 },
                    { 88, 12, 88 },
                    { 89, 62, 89 },
                    { 90, 179, 90 },
                    { 91, 126, 91 },
                    { 92, 9, 92 },
                    { 93, 356, 93 },
                    { 94, 329, 94 },
                    { 95, 490, 95 },
                    { 96, 223, 96 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 97, 226, 97 },
                    { 98, 478, 98 },
                    { 99, 368, 99 },
                    { 100, 14, 100 },
                    { 101, 213, 101 },
                    { 102, 394, 102 },
                    { 103, 462, 103 },
                    { 104, 102, 104 },
                    { 105, 207, 105 },
                    { 106, 370, 106 },
                    { 107, 430, 107 },
                    { 108, 352, 108 },
                    { 109, 422, 109 },
                    { 110, 67, 110 },
                    { 111, 31, 111 },
                    { 112, 64, 112 },
                    { 113, 120, 113 },
                    { 114, 285, 114 },
                    { 115, 228, 115 },
                    { 116, 191, 116 },
                    { 117, 342, 117 },
                    { 118, 92, 118 },
                    { 119, 143, 119 },
                    { 120, 37, 120 },
                    { 121, 99, 121 },
                    { 122, 123, 122 },
                    { 123, 21, 123 },
                    { 124, 171, 124 },
                    { 125, 183, 125 },
                    { 126, 185, 126 },
                    { 127, 454, 127 },
                    { 128, 136, 128 },
                    { 129, 306, 129 },
                    { 130, 350, 130 },
                    { 131, 446, 131 },
                    { 132, 95, 132 },
                    { 133, 49, 133 },
                    { 134, 133, 134 },
                    { 135, 84, 135 },
                    { 136, 275, 136 },
                    { 137, 266, 137 },
                    { 138, 118, 138 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 139, 349, 139 },
                    { 140, 232, 140 },
                    { 141, 147, 141 },
                    { 142, 193, 142 },
                    { 143, 222, 143 },
                    { 144, 456, 144 },
                    { 145, 93, 145 },
                    { 146, 149, 146 },
                    { 147, 77, 147 },
                    { 148, 367, 148 },
                    { 149, 361, 149 },
                    { 150, 495, 150 },
                    { 151, 214, 151 },
                    { 152, 265, 152 },
                    { 153, 289, 153 },
                    { 154, 341, 154 },
                    { 155, 230, 155 },
                    { 156, 373, 156 },
                    { 157, 317, 157 },
                    { 158, 282, 158 },
                    { 159, 131, 159 },
                    { 160, 11, 160 },
                    { 161, 3, 161 },
                    { 162, 145, 162 },
                    { 163, 383, 163 },
                    { 164, 117, 164 },
                    { 165, 324, 165 },
                    { 166, 50, 166 },
                    { 167, 174, 167 },
                    { 168, 305, 168 },
                    { 169, 168, 169 },
                    { 170, 48, 170 },
                    { 171, 269, 171 },
                    { 172, 475, 172 },
                    { 173, 80, 173 },
                    { 174, 333, 174 },
                    { 175, 491, 175 },
                    { 176, 267, 176 },
                    { 177, 261, 177 },
                    { 178, 134, 178 },
                    { 179, 471, 179 },
                    { 180, 20, 180 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 181, 344, 181 },
                    { 182, 97, 182 },
                    { 183, 480, 183 },
                    { 184, 17, 184 },
                    { 185, 165, 185 },
                    { 186, 83, 186 },
                    { 187, 81, 187 },
                    { 188, 482, 188 },
                    { 189, 40, 189 },
                    { 190, 87, 190 },
                    { 191, 142, 191 },
                    { 192, 73, 192 },
                    { 193, 13, 193 },
                    { 194, 5, 194 },
                    { 195, 409, 195 },
                    { 196, 402, 196 },
                    { 197, 304, 197 },
                    { 198, 362, 198 },
                    { 199, 488, 199 },
                    { 200, 427, 200 },
                    { 201, 196, 201 },
                    { 202, 55, 202 },
                    { 203, 318, 203 },
                    { 204, 363, 204 },
                    { 205, 115, 205 },
                    { 206, 437, 206 },
                    { 207, 449, 207 },
                    { 208, 188, 208 },
                    { 209, 78, 209 },
                    { 210, 419, 210 },
                    { 211, 281, 211 },
                    { 212, 346, 212 },
                    { 213, 141, 213 },
                    { 214, 241, 214 },
                    { 215, 273, 215 },
                    { 216, 386, 216 },
                    { 217, 182, 217 },
                    { 218, 276, 218 },
                    { 219, 44, 219 },
                    { 220, 263, 220 },
                    { 221, 1, 221 },
                    { 222, 268, 222 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 223, 442, 223 },
                    { 224, 72, 224 },
                    { 225, 457, 225 },
                    { 226, 124, 226 },
                    { 227, 417, 227 },
                    { 228, 418, 228 },
                    { 229, 485, 229 },
                    { 230, 308, 230 },
                    { 231, 330, 231 },
                    { 232, 426, 232 },
                    { 233, 434, 233 },
                    { 234, 277, 234 },
                    { 235, 218, 235 },
                    { 236, 225, 236 },
                    { 237, 247, 237 },
                    { 238, 229, 238 },
                    { 239, 27, 239 },
                    { 240, 104, 240 },
                    { 241, 114, 241 },
                    { 242, 200, 242 },
                    { 243, 476, 243 },
                    { 244, 244, 244 },
                    { 245, 411, 245 },
                    { 246, 162, 246 },
                    { 247, 8, 247 },
                    { 248, 359, 248 },
                    { 249, 127, 249 },
                    { 250, 178, 250 },
                    { 251, 157, 251 },
                    { 252, 22, 252 },
                    { 253, 311, 253 },
                    { 254, 429, 254 },
                    { 255, 98, 255 },
                    { 256, 453, 256 },
                    { 257, 130, 257 },
                    { 258, 290, 258 },
                    { 259, 428, 259 },
                    { 260, 26, 260 },
                    { 261, 328, 261 },
                    { 262, 291, 262 },
                    { 263, 467, 263 },
                    { 264, 107, 264 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 265, 30, 265 },
                    { 266, 319, 266 },
                    { 267, 255, 267 },
                    { 268, 410, 268 },
                    { 269, 274, 269 },
                    { 270, 284, 270 },
                    { 271, 364, 271 },
                    { 272, 459, 272 },
                    { 273, 198, 273 },
                    { 274, 369, 274 },
                    { 275, 146, 275 },
                    { 276, 279, 276 },
                    { 277, 481, 277 },
                    { 278, 205, 278 },
                    { 279, 60, 279 },
                    { 280, 416, 280 },
                    { 281, 393, 281 },
                    { 282, 249, 282 },
                    { 283, 380, 283 },
                    { 284, 195, 284 },
                    { 285, 170, 285 },
                    { 286, 286, 286 },
                    { 287, 204, 287 },
                    { 288, 251, 288 },
                    { 289, 388, 289 },
                    { 290, 294, 290 },
                    { 291, 253, 291 },
                    { 292, 35, 292 },
                    { 293, 246, 293 },
                    { 294, 151, 294 },
                    { 295, 61, 295 },
                    { 296, 101, 296 },
                    { 297, 18, 297 },
                    { 298, 385, 298 },
                    { 299, 243, 299 },
                    { 300, 358, 300 },
                    { 301, 440, 301 },
                    { 302, 404, 302 },
                    { 303, 381, 303 },
                    { 304, 340, 304 },
                    { 305, 353, 305 },
                    { 306, 414, 306 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 307, 51, 307 },
                    { 308, 113, 308 },
                    { 309, 322, 309 },
                    { 310, 164, 310 },
                    { 311, 59, 311 },
                    { 312, 326, 312 },
                    { 313, 391, 313 },
                    { 314, 450, 314 },
                    { 315, 392, 315 },
                    { 316, 176, 316 },
                    { 317, 79, 317 },
                    { 318, 53, 318 },
                    { 319, 43, 319 },
                    { 320, 292, 320 },
                    { 321, 210, 321 },
                    { 322, 493, 322 },
                    { 323, 116, 323 },
                    { 324, 100, 324 },
                    { 325, 483, 325 },
                    { 326, 496, 326 },
                    { 327, 438, 327 },
                    { 328, 347, 328 },
                    { 329, 236, 329 },
                    { 330, 264, 330 },
                    { 331, 109, 331 },
                    { 332, 331, 332 },
                    { 333, 439, 333 },
                    { 334, 211, 334 },
                    { 335, 256, 335 },
                    { 336, 474, 336 },
                    { 337, 76, 337 },
                    { 338, 254, 338 },
                    { 339, 343, 339 },
                    { 340, 220, 340 },
                    { 341, 29, 341 },
                    { 342, 181, 342 },
                    { 343, 108, 343 },
                    { 344, 420, 344 },
                    { 345, 374, 345 },
                    { 346, 472, 346 },
                    { 347, 408, 347 },
                    { 348, 302, 348 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 349, 492, 349 },
                    { 350, 239, 350 },
                    { 351, 321, 351 },
                    { 352, 216, 352 },
                    { 353, 377, 353 },
                    { 354, 283, 354 },
                    { 355, 366, 355 },
                    { 356, 407, 356 },
                    { 357, 405, 357 },
                    { 358, 34, 358 },
                    { 359, 140, 359 },
                    { 360, 197, 360 },
                    { 361, 52, 361 },
                    { 362, 278, 362 },
                    { 363, 221, 363 },
                    { 364, 257, 364 },
                    { 365, 400, 365 },
                    { 366, 433, 366 },
                    { 367, 192, 367 },
                    { 368, 441, 368 },
                    { 369, 36, 369 },
                    { 370, 152, 370 },
                    { 371, 458, 371 },
                    { 372, 250, 372 },
                    { 373, 403, 373 },
                    { 374, 470, 374 },
                    { 375, 69, 375 },
                    { 376, 396, 376 },
                    { 377, 38, 377 },
                    { 378, 125, 378 },
                    { 379, 74, 379 },
                    { 380, 338, 380 },
                    { 381, 389, 381 },
                    { 382, 240, 382 },
                    { 383, 390, 383 },
                    { 384, 339, 384 },
                    { 385, 103, 385 },
                    { 386, 39, 386 },
                    { 387, 425, 387 },
                    { 388, 452, 388 },
                    { 389, 186, 389 },
                    { 390, 464, 390 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 391, 337, 391 },
                    { 392, 203, 392 },
                    { 393, 461, 393 },
                    { 394, 65, 394 },
                    { 395, 121, 395 },
                    { 396, 296, 396 },
                    { 397, 148, 397 },
                    { 398, 463, 398 },
                    { 399, 299, 399 },
                    { 400, 424, 400 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 1, 1, 212 },
                    { 2, 2, 472 },
                    { 3, 3, 456 },
                    { 4, 4, 102 },
                    { 5, 5, 201 },
                    { 6, 6, 293 },
                    { 7, 7, 403 },
                    { 8, 8, 275 },
                    { 9, 9, 107 },
                    { 10, 10, 134 },
                    { 11, 11, 246 },
                    { 12, 12, 23 },
                    { 13, 13, 426 },
                    { 14, 14, 397 },
                    { 15, 15, 347 },
                    { 16, 16, 309 },
                    { 17, 17, 248 },
                    { 18, 18, 170 },
                    { 19, 19, 438 },
                    { 20, 20, 282 },
                    { 21, 21, 97 },
                    { 22, 22, 45 },
                    { 23, 23, 219 },
                    { 24, 24, 10 },
                    { 25, 25, 131 },
                    { 26, 26, 319 },
                    { 27, 27, 206 },
                    { 28, 28, 249 },
                    { 29, 29, 486 },
                    { 30, 30, 72 },
                    { 31, 31, 138 },
                    { 32, 32, 247 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 33, 33, 460 },
                    { 34, 34, 432 },
                    { 35, 35, 111 },
                    { 36, 36, 124 },
                    { 37, 37, 81 },
                    { 38, 38, 261 },
                    { 39, 39, 362 },
                    { 40, 40, 13 },
                    { 41, 41, 410 },
                    { 42, 42, 447 },
                    { 43, 43, 394 },
                    { 44, 44, 390 },
                    { 45, 45, 399 },
                    { 46, 46, 251 },
                    { 47, 47, 336 },
                    { 48, 48, 119 },
                    { 49, 49, 376 },
                    { 50, 50, 63 },
                    { 51, 51, 343 },
                    { 52, 52, 327 },
                    { 53, 53, 279 },
                    { 54, 54, 340 },
                    { 55, 55, 377 },
                    { 56, 56, 78 },
                    { 57, 57, 398 },
                    { 58, 58, 454 },
                    { 59, 59, 41 },
                    { 60, 60, 7 },
                    { 61, 61, 117 },
                    { 62, 62, 308 },
                    { 63, 63, 296 },
                    { 64, 64, 121 },
                    { 65, 65, 283 },
                    { 66, 66, 465 },
                    { 67, 67, 196 },
                    { 68, 68, 159 },
                    { 69, 69, 330 },
                    { 70, 70, 99 },
                    { 71, 71, 492 },
                    { 72, 72, 329 },
                    { 73, 73, 167 },
                    { 74, 74, 446 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 75, 75, 9 },
                    { 76, 76, 428 },
                    { 77, 77, 302 },
                    { 78, 78, 324 },
                    { 79, 79, 75 },
                    { 80, 80, 411 },
                    { 81, 81, 142 },
                    { 82, 82, 244 },
                    { 83, 83, 423 },
                    { 84, 84, 59 },
                    { 85, 85, 317 },
                    { 86, 86, 217 },
                    { 87, 87, 171 },
                    { 88, 88, 205 },
                    { 89, 89, 351 },
                    { 90, 90, 373 },
                    { 91, 91, 94 },
                    { 92, 92, 259 },
                    { 93, 93, 46 },
                    { 94, 94, 444 },
                    { 95, 95, 378 },
                    { 96, 96, 32 },
                    { 97, 97, 260 },
                    { 98, 98, 353 },
                    { 99, 99, 443 },
                    { 100, 100, 54 },
                    { 101, 101, 150 },
                    { 102, 102, 257 },
                    { 103, 103, 331 },
                    { 104, 104, 85 },
                    { 105, 105, 372 },
                    { 106, 106, 91 },
                    { 107, 107, 363 },
                    { 108, 108, 198 },
                    { 109, 109, 341 },
                    { 110, 110, 189 },
                    { 111, 111, 213 },
                    { 112, 112, 172 },
                    { 113, 113, 43 },
                    { 114, 114, 87 },
                    { 115, 115, 366 },
                    { 116, 116, 155 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 117, 117, 226 },
                    { 118, 118, 47 },
                    { 119, 119, 276 },
                    { 120, 120, 89 },
                    { 121, 121, 175 },
                    { 122, 122, 307 },
                    { 123, 123, 16 },
                    { 124, 124, 67 },
                    { 125, 125, 381 },
                    { 126, 126, 176 },
                    { 127, 127, 49 },
                    { 128, 128, 409 },
                    { 129, 129, 452 },
                    { 130, 130, 412 },
                    { 131, 131, 186 },
                    { 132, 132, 162 },
                    { 133, 133, 267 },
                    { 134, 134, 181 },
                    { 135, 135, 139 },
                    { 136, 136, 385 },
                    { 137, 137, 437 },
                    { 138, 138, 358 },
                    { 139, 139, 416 },
                    { 140, 140, 359 },
                    { 141, 141, 440 },
                    { 142, 142, 469 },
                    { 143, 143, 494 },
                    { 144, 144, 348 },
                    { 145, 145, 68 },
                    { 146, 146, 104 },
                    { 147, 147, 355 },
                    { 148, 148, 480 },
                    { 149, 149, 241 },
                    { 150, 150, 165 },
                    { 151, 151, 21 },
                    { 152, 152, 236 },
                    { 153, 153, 141 },
                    { 154, 154, 300 },
                    { 155, 155, 498 },
                    { 156, 156, 232 },
                    { 157, 157, 76 },
                    { 158, 158, 354 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 159, 159, 332 },
                    { 160, 160, 474 },
                    { 161, 161, 382 },
                    { 162, 162, 231 },
                    { 163, 163, 95 },
                    { 164, 164, 459 },
                    { 165, 165, 34 },
                    { 166, 166, 370 },
                    { 167, 167, 230 },
                    { 168, 168, 310 },
                    { 169, 169, 12 },
                    { 170, 170, 132 },
                    { 171, 171, 61 },
                    { 172, 172, 127 },
                    { 173, 173, 215 },
                    { 174, 174, 253 },
                    { 175, 175, 481 },
                    { 176, 176, 420 },
                    { 177, 177, 461 },
                    { 178, 178, 453 },
                    { 179, 179, 449 },
                    { 180, 180, 356 },
                    { 181, 181, 60 },
                    { 182, 182, 346 },
                    { 183, 183, 271 },
                    { 184, 184, 478 },
                    { 185, 185, 342 },
                    { 186, 186, 364 },
                    { 187, 187, 471 },
                    { 188, 188, 475 },
                    { 189, 189, 323 },
                    { 190, 190, 1 },
                    { 191, 191, 140 },
                    { 192, 192, 396 },
                    { 193, 193, 187 },
                    { 194, 194, 58 },
                    { 195, 195, 304 },
                    { 196, 196, 51 },
                    { 197, 197, 118 },
                    { 198, 198, 149 },
                    { 199, 199, 281 },
                    { 200, 200, 269 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 201, 201, 303 },
                    { 202, 202, 427 },
                    { 203, 203, 441 },
                    { 204, 204, 90 },
                    { 205, 205, 156 },
                    { 206, 206, 242 },
                    { 207, 207, 487 },
                    { 208, 208, 224 },
                    { 209, 209, 192 },
                    { 210, 210, 146 },
                    { 211, 211, 17 },
                    { 212, 212, 451 },
                    { 213, 213, 177 },
                    { 214, 214, 395 },
                    { 215, 215, 126 },
                    { 216, 216, 56 },
                    { 217, 217, 311 },
                    { 218, 218, 143 },
                    { 219, 219, 130 },
                    { 220, 220, 388 },
                    { 221, 221, 37 },
                    { 222, 222, 66 },
                    { 223, 223, 352 },
                    { 224, 224, 106 },
                    { 225, 225, 40 },
                    { 226, 226, 285 },
                    { 227, 227, 163 },
                    { 228, 228, 431 },
                    { 229, 229, 100 },
                    { 230, 230, 145 },
                    { 231, 231, 229 },
                    { 232, 232, 289 },
                    { 233, 233, 178 },
                    { 234, 234, 406 },
                    { 235, 235, 424 },
                    { 236, 236, 86 },
                    { 237, 237, 6 },
                    { 238, 238, 294 },
                    { 239, 239, 277 },
                    { 240, 240, 27 },
                    { 241, 241, 19 },
                    { 242, 242, 299 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 243, 243, 237 },
                    { 244, 244, 173 },
                    { 245, 245, 252 },
                    { 246, 246, 497 },
                    { 247, 247, 468 },
                    { 248, 248, 101 },
                    { 249, 249, 258 },
                    { 250, 250, 393 },
                    { 251, 251, 278 },
                    { 252, 252, 419 },
                    { 253, 253, 379 },
                    { 254, 254, 235 },
                    { 255, 255, 5 },
                    { 256, 256, 333 },
                    { 257, 257, 315 },
                    { 258, 258, 129 },
                    { 259, 259, 496 },
                    { 260, 260, 306 },
                    { 261, 261, 70 },
                    { 262, 262, 184 },
                    { 263, 263, 136 },
                    { 264, 264, 493 },
                    { 265, 265, 357 },
                    { 266, 266, 239 },
                    { 267, 267, 391 },
                    { 268, 268, 316 },
                    { 269, 269, 209 },
                    { 270, 270, 287 },
                    { 271, 271, 18 },
                    { 272, 272, 335 },
                    { 273, 273, 284 },
                    { 274, 274, 33 },
                    { 275, 275, 116 },
                    { 276, 276, 57 },
                    { 277, 277, 238 },
                    { 278, 278, 433 },
                    { 279, 279, 297 },
                    { 280, 280, 262 },
                    { 281, 281, 401 },
                    { 282, 282, 216 },
                    { 283, 283, 413 },
                    { 284, 284, 195 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 285, 285, 166 },
                    { 286, 286, 92 },
                    { 287, 287, 405 },
                    { 288, 288, 24 },
                    { 289, 289, 82 },
                    { 290, 290, 421 },
                    { 291, 291, 418 },
                    { 292, 292, 182 },
                    { 293, 293, 337 },
                    { 294, 294, 291 },
                    { 295, 295, 484 },
                    { 296, 296, 422 },
                    { 297, 297, 365 },
                    { 298, 298, 434 },
                    { 299, 299, 273 },
                    { 300, 300, 318 },
                    { 301, 301, 137 },
                    { 302, 302, 109 },
                    { 303, 303, 220 },
                    { 304, 304, 188 },
                    { 305, 305, 414 },
                    { 306, 306, 462 },
                    { 307, 307, 320 },
                    { 308, 308, 62 },
                    { 309, 309, 203 },
                    { 310, 310, 233 },
                    { 311, 311, 148 },
                    { 312, 312, 168 },
                    { 313, 313, 77 },
                    { 314, 314, 185 },
                    { 315, 315, 264 },
                    { 316, 316, 227 },
                    { 317, 317, 466 },
                    { 318, 318, 495 },
                    { 319, 319, 115 },
                    { 320, 320, 479 },
                    { 321, 321, 53 },
                    { 322, 322, 147 },
                    { 323, 323, 228 },
                    { 324, 324, 270 },
                    { 325, 325, 20 },
                    { 326, 326, 290 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 327, 327, 499 },
                    { 328, 328, 73 },
                    { 329, 329, 488 },
                    { 330, 330, 250 },
                    { 331, 331, 345 },
                    { 332, 332, 42 },
                    { 333, 333, 183 },
                    { 334, 334, 152 },
                    { 335, 335, 52 },
                    { 336, 336, 135 },
                    { 337, 337, 407 },
                    { 338, 338, 204 },
                    { 339, 339, 288 },
                    { 340, 340, 22 },
                    { 341, 341, 436 },
                    { 342, 342, 202 },
                    { 343, 343, 122 },
                    { 344, 344, 197 },
                    { 345, 345, 211 },
                    { 346, 346, 295 },
                    { 347, 347, 160 },
                    { 348, 348, 380 },
                    { 349, 349, 473 },
                    { 350, 350, 489 },
                    { 351, 351, 50 },
                    { 352, 352, 112 },
                    { 353, 353, 14 },
                    { 354, 354, 368 },
                    { 355, 355, 128 },
                    { 356, 356, 455 },
                    { 357, 357, 245 },
                    { 358, 358, 133 },
                    { 359, 359, 482 },
                    { 360, 360, 491 },
                    { 361, 361, 11 },
                    { 362, 362, 286 },
                    { 363, 363, 221 },
                    { 364, 364, 31 },
                    { 365, 365, 326 },
                    { 366, 366, 314 },
                    { 367, 367, 485 },
                    { 368, 368, 321 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 369, 369, 272 },
                    { 370, 370, 98 },
                    { 371, 371, 360 },
                    { 372, 372, 218 },
                    { 373, 373, 417 },
                    { 374, 374, 93 },
                    { 375, 375, 2 },
                    { 376, 376, 268 },
                    { 377, 377, 144 },
                    { 378, 378, 64 },
                    { 379, 379, 328 },
                    { 380, 380, 88 },
                    { 381, 381, 445 },
                    { 382, 382, 80 },
                    { 383, 383, 3 },
                    { 384, 384, 375 },
                    { 385, 385, 305 },
                    { 386, 386, 79 },
                    { 387, 387, 415 },
                    { 388, 388, 4 },
                    { 389, 389, 386 },
                    { 390, 390, 338 },
                    { 391, 391, 256 },
                    { 392, 392, 425 },
                    { 393, 393, 402 },
                    { 394, 394, 103 },
                    { 395, 395, 280 },
                    { 396, 396, 442 },
                    { 397, 397, 292 },
                    { 398, 398, 29 },
                    { 399, 399, 350 },
                    { 400, 400, 25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mark_FK_UserUUID",
                table: "Mark",
                column: "FK_UserUUID");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_FK_UserUUID",
                table: "Grade",
                column: "FK_UserUUID");

            migrationBuilder.CreateIndex(
                name: "IX_Approve_FK_UserUUID",
                table: "Approve",
                column: "FK_UserUUID");

            migrationBuilder.AddForeignKey(
                name: "FK_Approve_Person_FK_UserUUID",
                table: "Approve",
                column: "FK_UserUUID",
                principalTable: "Person",
                principalColumn: "UserUUID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Person_FK_UserUUID",
                table: "Grade",
                column: "FK_UserUUID",
                principalTable: "Person",
                principalColumn: "UserUUID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Person_FK_UserUUID",
                table: "Mark",
                column: "FK_UserUUID",
                principalTable: "Person",
                principalColumn: "UserUUID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Class_FK_Class",
                table: "Subject",
                column: "FK_Class",
                principalTable: "Class",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Approve_Person_FK_UserUUID",
                table: "Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Person_FK_UserUUID",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Person_FK_UserUUID",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Class_FK_Class",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Mark_FK_UserUUID",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Grade_FK_UserUUID",
                table: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Approve_FK_UserUUID",
                table: "Approve");

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 28);

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
                keyValue: 41);

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
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 499);

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
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "LessonGrade",
                keyColumn: "GradeLessonID",
                keyValue: 400);

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
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "LessonMark",
                keyColumn: "LessonMarkID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 30);

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
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 500);

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
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 3);

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
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 500);

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
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 29);

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
                keyValue: 37);

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
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 499);

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
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("06178512-2290-41dd-9f03-713f43b89f48"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("08923ec7-373c-43c9-b871-5de4208615d1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("08e2e581-2309-4cf1-93f0-e585467d1f4f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0aaf6d9c-2c2e-4bb0-b0a8-44fadf447d1c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("117a6153-4e18-4022-9381-f55fcd6a79e9"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1282556b-d71b-40f9-be66-a22236c75262"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1892daec-77d0-48ee-a3b5-0a0f64024ef7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("19ed0b25-b0d5-43b8-b770-9c88233718ba"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("20d39911-b1eb-45f6-849a-484c5ca22fa3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2295b75d-12ab-41b8-bb86-d85deb117893"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("24021955-aa0d-49ca-92b9-01561f491967"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("24e50499-d459-4100-82b1-626f4a825561"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("29ad868a-6ab2-4655-b8e0-a3b37b67592b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2c5c7e70-3b0d-4e0e-b172-6903658d80b1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2ce05707-08db-4c9c-97c7-ea3311d0b145"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2e096829-a9d1-4782-8d2f-b817f0d19b4a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2e41513a-d5b2-4ca9-a01f-1cbf24038a1a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("32151eef-e041-48a1-880a-5974d14ee349"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("37e3b541-c94b-4840-829e-4b33eac62412"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3a934bd4-57bc-411f-a9e5-f5ee2ac0a080"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3ecca9f4-469a-45d0-8fec-c52440e7943d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("423d8677-5aaa-4113-9037-37b9368d5825"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("46ee70cb-46e2-498e-b200-9418ed30cb15"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("48823b87-c9a8-4ca4-bfdb-69d97dee17be"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("49259203-2d23-4276-8056-c55ac7b17e51"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("499537bf-f642-4d94-91f0-234236984b79"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4c03da27-67f0-44d4-8f4d-18a37cca2537"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4c0d7c96-7a63-4039-b158-80f1cb3ea106"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4c268ebb-9d26-4330-b0f6-26a6dd666365"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4ec4421d-e9c5-4cbd-8ae4-374660c27026"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("51220f4a-839c-4406-af6e-4d0bb41647a3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("527f6915-e6b0-417b-ba80-65f67d9bc4e6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("54d54be4-8864-4623-bd7b-1c3d5c5ecf45"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("57e9cbdb-1a2c-4838-82fa-c457d50b7afa"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("58aa928f-7b25-46eb-9eba-4df30bd0a52e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("598dddf0-38d2-4a2a-87c5-983ad733a394"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("62474267-6a63-44f9-9525-6f0b456f7e5f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("65d1a0da-6b5a-45b9-a36f-a9c5f45d9fc7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("65f9a764-1286-463d-bb3c-aaced9edbd61"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("685df129-d237-414f-8e3d-c676e579dfda"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6aaa0dd5-a7b8-476f-94bc-17dc37211545"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6e3b3a02-d331-4c80-95d3-bce69228d78a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7127c05d-e56f-4f20-b08e-89f6d6189a20"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("72529ca0-51d4-47ea-8b9b-a790193c44c9"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("76458193-d54d-483c-904c-1b6e4c82e9d1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("769ecd1c-bea7-4b48-98f8-1ecfbbf35bf6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("802f32b5-1511-45aa-88e1-360c74cf8b30"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("805bebe0-f048-40ae-800d-3c059bd94031"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("88254423-58cb-4878-afec-5c72d69b1e35"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8a9ad884-d073-4de1-9da9-a3663c2fb0fc"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8abc4da4-7bc5-405b-a25e-ed967da7e0ac"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8d049cf1-929b-4e10-93ff-82d4d9c12533"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8d3c2a89-4617-4e3a-b7a9-941e9e6df852"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8dd1ede9-ac39-447c-adfd-518712b9f3f5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("90a16ce0-9d60-4527-bc59-ff993ab3ad97"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("94748fb3-e893-4d5b-a351-c7f8ee2efac6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("96e42d95-8bf8-43d7-8e72-da6d98ef493a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("96feb368-363b-4cf2-8ffb-2412835b5fc5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("986fb7b5-0102-4cb8-aa34-24f01822e4ad"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9f5fa7ec-1b9b-4d11-82f6-224e3f95f1d7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9fbf83a5-db4b-4e50-b4a2-9dbdb59d2b1f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a384321b-a994-4eb2-b21c-4162cf6bc3f2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a87833ab-5e97-4e3e-85ba-6f5ea439d96a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a87becc1-50f8-48b4-887a-ed97208c34a0"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("aabd0da9-4e63-4113-926d-210eec1b4761"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ae035edd-0732-4044-982c-d306f47b49f3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b20eb39d-234d-49d8-b960-0921756c9717"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b39e4444-39a7-495a-b0b0-3d26bc177826"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b43258b3-e1ad-46d0-9b1a-fe67a56968c7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b4ac5e6d-02ba-4831-ad82-cd702026d082"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ba699484-02a7-4dc5-908a-01c08ebe44f2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bc38d992-6818-4aa0-a42a-9f781e84fd5a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c07240e5-af7f-4376-8a0f-697a35673017"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c305b1a1-934d-4feb-b901-37be22c4f1f1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c3911c61-14ec-44dd-9991-a3f1fb1091cb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c47b2bb5-0a7d-40e7-a8bb-e051d23f1e99"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c6254b51-26c7-4666-9f41-c3cb34c40e1d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c706e632-8eda-4bbf-8670-9f0f2687398e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("cd01a6e2-b433-4bcd-9457-a6760f50abf9"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d0baa143-d3f6-4bf3-b0f5-7da3034145fa"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d3358746-c456-4ef3-8747-858d7042a12c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d56f0b94-3bf4-48e2-b1e8-9db9a9613605"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d5b418f1-a117-4952-a165-f81c1e49f6ea"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d7d06e21-1484-4e5f-b310-873e7ee4c083"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("db6813f9-df4e-4bcf-b797-a9d40f89e0f5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("dda2a713-5f87-4739-9a9e-a0b5320a1b27"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e44f9e6c-52eb-4832-9fe0-092784f1d984"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e4659c0a-9512-46f5-bafb-7badc86414a8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e99f8461-24eb-4cf6-8ae8-9a3a10adf56a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e9e16a90-9e3f-41ed-af52-349ae7f2a38c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ec342c40-3d4b-421f-bc3d-1cc811997ce2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("edf4e2a9-c3da-434f-8535-6c521c200195"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f0f28017-a249-4035-8343-bbc9d2420091"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f19c87b2-b977-43e0-bab0-68962a0e45f4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f49c37d6-6080-4735-9bfc-1d99a9273c48"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f7c3fcd2-7201-4cc2-a1dc-c191fd20e045"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fb050429-ff6d-4af1-907a-d6c79ffab4eb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fec613b6-4978-4380-ba93-03f9172b66c1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ffbad71b-4553-4da1-8717-96fd86124da7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ffe3bc20-7bc2-4788-a009-33bec392050e"));

            migrationBuilder.DropColumn(
                name: "FK_UserUUID",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "FK_UserUUID",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "FK_UserUUID",
                table: "Approve");

            migrationBuilder.RenameColumn(
                name: "FK_Class",
                table: "Subject",
                newName: "FK_PersonClass");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_FK_Class",
                table: "Subject",
                newName: "IX_Subject_FK_PersonClass");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parent",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_PersonClass_FK_PersonClass",
                table: "Subject",
                column: "FK_PersonClass",
                principalTable: "PersonClass",
                principalColumn: "UserClassID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
