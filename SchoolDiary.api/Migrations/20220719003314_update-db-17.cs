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
                    { 1, 1, 1, "Polish" },
                    { 2, 1, 2, "Geography" },
                    { 3, 1, 3, "Geography" },
                    { 4, 1, 4, "Polish" },
                    { 5, 1, 5, "Chemistry" },
                    { 6, 1, 6, "Geography" },
                    { 7, 1, 7, "Math" },
                    { 8, 1, 8, "Chemistry" },
                    { 9, 2, 1, "Polish" },
                    { 10, 2, 2, "PE" },
                    { 11, 2, 3, "History" },
                    { 12, 2, 4, "Math" },
                    { 13, 2, 5, "English" },
                    { 14, 2, 6, "Chemistry" },
                    { 15, 2, 7, "Geography" },
                    { 16, 2, 8, "PE" },
                    { 17, 3, 1, "PE" },
                    { 18, 3, 2, "Physics" },
                    { 19, 3, 3, "PE" },
                    { 20, 3, 4, "Geography" },
                    { 21, 3, 5, "History" },
                    { 22, 3, 6, "PE" },
                    { 23, 3, 7, "Chemistry" },
                    { 24, 3, 8, "English" },
                    { 25, 4, 1, "Geography" },
                    { 26, 4, 2, "PE" },
                    { 27, 4, 3, "English" },
                    { 28, 4, 4, "English" },
                    { 29, 4, 5, "History" },
                    { 30, 4, 6, "Chemistry" },
                    { 31, 4, 7, "English" },
                    { 32, 4, 8, "PE" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 33, 5, 1, "Chemistry" },
                    { 34, 5, 2, "English" },
                    { 35, 5, 3, "PE" },
                    { 36, 5, 4, "Chemistry" },
                    { 37, 5, 5, "PE" },
                    { 38, 5, 6, "Geography" },
                    { 39, 5, 7, "History" },
                    { 40, 5, 8, "Physics" },
                    { 41, 1, 1, "Geography" },
                    { 42, 1, 2, "Geography" },
                    { 43, 1, 3, "Polish" },
                    { 44, 1, 4, "History" },
                    { 45, 1, 5, "Chemistry" },
                    { 46, 1, 6, "English" },
                    { 47, 1, 7, "Polish" },
                    { 48, 1, 8, "English" },
                    { 49, 2, 1, "English" },
                    { 50, 2, 2, "Geography" },
                    { 51, 2, 3, "Polish" },
                    { 52, 2, 4, "Physics" },
                    { 53, 2, 5, "Geography" },
                    { 54, 2, 6, "English" },
                    { 55, 2, 7, "Polish" },
                    { 56, 2, 8, "Math" },
                    { 57, 3, 1, "Geography" },
                    { 58, 3, 2, "Polish" },
                    { 59, 3, 3, "Physics" },
                    { 60, 3, 4, "History" },
                    { 61, 3, 5, "Math" },
                    { 62, 3, 6, "History" },
                    { 63, 3, 7, "Physics" },
                    { 64, 3, 8, "Chemistry" },
                    { 65, 4, 1, "English" },
                    { 66, 4, 2, "Physics" },
                    { 67, 4, 3, "PE" },
                    { 68, 4, 4, "Math" },
                    { 69, 4, 5, "Polish" },
                    { 70, 4, 6, "Chemistry" },
                    { 71, 4, 7, "Math" },
                    { 72, 4, 8, "Polish" },
                    { 73, 5, 1, "Math" },
                    { 74, 5, 2, "English" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 75, 5, 3, "Math" },
                    { 76, 5, 4, "History" },
                    { 77, 5, 5, "English" },
                    { 78, 5, 6, "Math" },
                    { 79, 5, 7, "Chemistry" },
                    { 80, 5, 8, "Chemistry" },
                    { 81, 1, 1, "Geography" },
                    { 82, 1, 2, "History" },
                    { 83, 1, 3, "Geography" },
                    { 84, 1, 4, "Physics" },
                    { 85, 1, 5, "PE" },
                    { 86, 1, 6, "PE" },
                    { 87, 1, 7, "Math" },
                    { 88, 1, 8, "Geography" },
                    { 89, 2, 1, "Physics" },
                    { 90, 2, 2, "History" },
                    { 91, 2, 3, "Math" },
                    { 92, 2, 4, "History" },
                    { 93, 2, 5, "Math" },
                    { 94, 2, 6, "English" },
                    { 95, 2, 7, "Geography" },
                    { 96, 2, 8, "Polish" },
                    { 97, 3, 1, "History" },
                    { 98, 3, 2, "PE" },
                    { 99, 3, 3, "Polish" },
                    { 100, 3, 4, "PE" },
                    { 101, 3, 5, "Geography" },
                    { 102, 3, 6, "Polish" },
                    { 103, 3, 7, "English" },
                    { 104, 3, 8, "Math" },
                    { 105, 4, 1, "Math" },
                    { 106, 4, 2, "Chemistry" },
                    { 107, 4, 3, "Physics" },
                    { 108, 4, 4, "Physics" },
                    { 109, 4, 5, "History" },
                    { 110, 4, 6, "Math" },
                    { 111, 4, 7, "Geography" },
                    { 112, 4, 8, "Chemistry" },
                    { 113, 5, 1, "Math" },
                    { 114, 5, 2, "PE" },
                    { 115, 5, 3, "Chemistry" },
                    { 116, 5, 4, "English" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 117, 5, 5, "Math" },
                    { 118, 5, 6, "Geography" },
                    { 119, 5, 7, "History" },
                    { 120, 5, 8, "Geography" },
                    { 121, 1, 1, "Physics" },
                    { 122, 1, 2, "Math" },
                    { 123, 1, 3, "Geography" },
                    { 124, 1, 4, "English" },
                    { 125, 1, 5, "PE" },
                    { 126, 1, 6, "Physics" },
                    { 127, 1, 7, "Polish" },
                    { 128, 1, 8, "Chemistry" },
                    { 129, 2, 1, "PE" },
                    { 130, 2, 2, "Physics" },
                    { 131, 2, 3, "History" },
                    { 132, 2, 4, "Geography" },
                    { 133, 2, 5, "Geography" },
                    { 134, 2, 6, "Physics" },
                    { 135, 2, 7, "Chemistry" },
                    { 136, 2, 8, "English" },
                    { 137, 3, 1, "PE" },
                    { 138, 3, 2, "Physics" },
                    { 139, 3, 3, "Geography" },
                    { 140, 3, 4, "Chemistry" },
                    { 141, 3, 5, "Polish" },
                    { 142, 3, 6, "Geography" },
                    { 143, 3, 7, "Chemistry" },
                    { 144, 3, 8, "Physics" },
                    { 145, 4, 1, "Physics" },
                    { 146, 4, 2, "Polish" },
                    { 147, 4, 3, "History" },
                    { 148, 4, 4, "Chemistry" },
                    { 149, 4, 5, "Geography" },
                    { 150, 4, 6, "Math" },
                    { 151, 4, 7, "Geography" },
                    { 152, 4, 8, "English" },
                    { 153, 5, 1, "Geography" },
                    { 154, 5, 2, "PE" },
                    { 155, 5, 3, "PE" },
                    { 156, 5, 4, "Physics" },
                    { 157, 5, 5, "Geography" },
                    { 158, 5, 6, "Chemistry" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 159, 5, 7, "Physics" },
                    { 160, 5, 8, "Polish" },
                    { 161, 1, 1, "PE" },
                    { 162, 1, 2, "Geography" },
                    { 163, 1, 3, "History" },
                    { 164, 1, 4, "Geography" },
                    { 165, 1, 5, "Physics" },
                    { 166, 1, 6, "Physics" },
                    { 167, 1, 7, "Geography" },
                    { 168, 1, 8, "History" },
                    { 169, 2, 1, "Polish" },
                    { 170, 2, 2, "PE" },
                    { 171, 2, 3, "English" },
                    { 172, 2, 4, "Chemistry" },
                    { 173, 2, 5, "PE" },
                    { 174, 2, 6, "Physics" },
                    { 175, 2, 7, "PE" },
                    { 176, 2, 8, "English" },
                    { 177, 3, 1, "Geography" },
                    { 178, 3, 2, "History" },
                    { 179, 3, 3, "Math" },
                    { 180, 3, 4, "Physics" },
                    { 181, 3, 5, "History" },
                    { 182, 3, 6, "Chemistry" },
                    { 183, 3, 7, "Chemistry" },
                    { 184, 3, 8, "History" },
                    { 185, 4, 1, "Physics" },
                    { 186, 4, 2, "Physics" },
                    { 187, 4, 3, "Geography" },
                    { 188, 4, 4, "Chemistry" },
                    { 189, 4, 5, "Math" },
                    { 190, 4, 6, "History" },
                    { 191, 4, 7, "Chemistry" },
                    { 192, 4, 8, "Physics" },
                    { 193, 5, 1, "PE" },
                    { 194, 5, 2, "Physics" },
                    { 195, 5, 3, "Physics" },
                    { 196, 5, 4, "History" },
                    { 197, 5, 5, "Geography" },
                    { 198, 5, 6, "English" },
                    { 199, 5, 7, "Math" },
                    { 200, 5, 8, "Geography" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 201, 1, 1, "Math" },
                    { 202, 1, 2, "Polish" },
                    { 203, 1, 3, "PE" },
                    { 204, 1, 4, "Polish" },
                    { 205, 1, 5, "History" },
                    { 206, 1, 6, "Math" },
                    { 207, 1, 7, "PE" },
                    { 208, 1, 8, "Chemistry" },
                    { 209, 2, 1, "Geography" },
                    { 210, 2, 2, "English" },
                    { 211, 2, 3, "Geography" },
                    { 212, 2, 4, "PE" },
                    { 213, 2, 5, "Physics" },
                    { 214, 2, 6, "History" },
                    { 215, 2, 7, "Physics" },
                    { 216, 2, 8, "Math" },
                    { 217, 3, 1, "Geography" },
                    { 218, 3, 2, "PE" },
                    { 219, 3, 3, "English" },
                    { 220, 3, 4, "PE" },
                    { 221, 3, 5, "Chemistry" },
                    { 222, 3, 6, "History" },
                    { 223, 3, 7, "Polish" },
                    { 224, 3, 8, "History" },
                    { 225, 4, 1, "History" },
                    { 226, 4, 2, "Chemistry" },
                    { 227, 4, 3, "Polish" },
                    { 228, 4, 4, "Math" },
                    { 229, 4, 5, "Polish" },
                    { 230, 4, 6, "Geography" },
                    { 231, 4, 7, "English" },
                    { 232, 4, 8, "Math" },
                    { 233, 5, 1, "Physics" },
                    { 234, 5, 2, "Math" },
                    { 235, 5, 3, "Geography" },
                    { 236, 5, 4, "Physics" },
                    { 237, 5, 5, "Physics" },
                    { 238, 5, 6, "Math" },
                    { 239, 5, 7, "Chemistry" },
                    { 240, 5, 8, "English" },
                    { 241, 1, 1, "Math" },
                    { 242, 1, 2, "PE" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 243, 1, 3, "Polish" },
                    { 244, 1, 4, "Chemistry" },
                    { 245, 1, 5, "Chemistry" },
                    { 246, 1, 6, "Chemistry" },
                    { 247, 1, 7, "Physics" },
                    { 248, 1, 8, "English" },
                    { 249, 2, 1, "English" },
                    { 250, 2, 2, "History" },
                    { 251, 2, 3, "History" },
                    { 252, 2, 4, "PE" },
                    { 253, 2, 5, "PE" },
                    { 254, 2, 6, "Physics" },
                    { 255, 2, 7, "English" },
                    { 256, 2, 8, "PE" },
                    { 257, 3, 1, "Physics" },
                    { 258, 3, 2, "Polish" },
                    { 259, 3, 3, "Chemistry" },
                    { 260, 3, 4, "History" },
                    { 261, 3, 5, "PE" },
                    { 262, 3, 6, "Polish" },
                    { 263, 3, 7, "History" },
                    { 264, 3, 8, "PE" },
                    { 265, 4, 1, "History" },
                    { 266, 4, 2, "Polish" },
                    { 267, 4, 3, "English" },
                    { 268, 4, 4, "PE" },
                    { 269, 4, 5, "History" },
                    { 270, 4, 6, "Polish" },
                    { 271, 4, 7, "English" },
                    { 272, 4, 8, "Geography" },
                    { 273, 5, 1, "Math" },
                    { 274, 5, 2, "Geography" },
                    { 275, 5, 3, "Geography" },
                    { 276, 5, 4, "Chemistry" },
                    { 277, 5, 5, "PE" },
                    { 278, 5, 6, "Math" },
                    { 279, 5, 7, "History" },
                    { 280, 5, 8, "Geography" },
                    { 281, 1, 1, "Physics" },
                    { 282, 1, 2, "Physics" },
                    { 283, 1, 3, "Physics" },
                    { 284, 1, 4, "Polish" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 285, 1, 5, "Chemistry" },
                    { 286, 1, 6, "English" },
                    { 287, 1, 7, "History" },
                    { 288, 1, 8, "Polish" },
                    { 289, 2, 1, "PE" },
                    { 290, 2, 2, "Math" },
                    { 291, 2, 3, "Physics" },
                    { 292, 2, 4, "Geography" },
                    { 293, 2, 5, "Chemistry" },
                    { 294, 2, 6, "English" },
                    { 295, 2, 7, "Geography" },
                    { 296, 2, 8, "Polish" },
                    { 297, 3, 1, "English" },
                    { 298, 3, 2, "English" },
                    { 299, 3, 3, "English" },
                    { 300, 3, 4, "Math" },
                    { 301, 3, 5, "Math" },
                    { 302, 3, 6, "Polish" },
                    { 303, 3, 7, "Geography" },
                    { 304, 3, 8, "Polish" },
                    { 305, 4, 1, "Math" },
                    { 306, 4, 2, "Polish" },
                    { 307, 4, 3, "English" },
                    { 308, 4, 4, "English" },
                    { 309, 4, 5, "History" },
                    { 310, 4, 6, "Chemistry" },
                    { 311, 4, 7, "Physics" },
                    { 312, 4, 8, "Polish" },
                    { 313, 5, 1, "Physics" },
                    { 314, 5, 2, "History" },
                    { 315, 5, 3, "History" },
                    { 316, 5, 4, "Math" },
                    { 317, 5, 5, "English" },
                    { 318, 5, 6, "Physics" },
                    { 319, 5, 7, "Chemistry" },
                    { 320, 5, 8, "Physics" },
                    { 321, 1, 1, "History" },
                    { 322, 1, 2, "Geography" },
                    { 323, 1, 3, "Chemistry" },
                    { 324, 1, 4, "Polish" },
                    { 325, 1, 5, "Geography" },
                    { 326, 1, 6, "Geography" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 327, 1, 7, "Geography" },
                    { 328, 1, 8, "Chemistry" },
                    { 329, 2, 1, "Physics" },
                    { 330, 2, 2, "Geography" },
                    { 331, 2, 3, "Geography" },
                    { 332, 2, 4, "Chemistry" },
                    { 333, 2, 5, "English" },
                    { 334, 2, 6, "Chemistry" },
                    { 335, 2, 7, "PE" },
                    { 336, 2, 8, "Geography" },
                    { 337, 3, 1, "English" },
                    { 338, 3, 2, "English" },
                    { 339, 3, 3, "Physics" },
                    { 340, 3, 4, "Math" },
                    { 341, 3, 5, "Physics" },
                    { 342, 3, 6, "PE" },
                    { 343, 3, 7, "Math" },
                    { 344, 3, 8, "Chemistry" },
                    { 345, 4, 1, "Geography" },
                    { 346, 4, 2, "Polish" },
                    { 347, 4, 3, "Physics" },
                    { 348, 4, 4, "English" },
                    { 349, 4, 5, "English" },
                    { 350, 4, 6, "English" },
                    { 351, 4, 7, "Physics" },
                    { 352, 4, 8, "Math" },
                    { 353, 5, 1, "Physics" },
                    { 354, 5, 2, "English" },
                    { 355, 5, 3, "Geography" },
                    { 356, 5, 4, "History" },
                    { 357, 5, 5, "PE" },
                    { 358, 5, 6, "History" },
                    { 359, 5, 7, "Math" },
                    { 360, 5, 8, "Chemistry" },
                    { 361, 1, 1, "English" },
                    { 362, 1, 2, "PE" },
                    { 363, 1, 3, "English" },
                    { 364, 1, 4, "English" },
                    { 365, 1, 5, "English" },
                    { 366, 1, 6, "Geography" },
                    { 367, 1, 7, "PE" },
                    { 368, 1, 8, "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 369, 2, 1, "Polish" },
                    { 370, 2, 2, "Chemistry" },
                    { 371, 2, 3, "History" },
                    { 372, 2, 4, "Polish" },
                    { 373, 2, 5, "Math" },
                    { 374, 2, 6, "PE" },
                    { 375, 2, 7, "Chemistry" },
                    { 376, 2, 8, "Geography" },
                    { 377, 3, 1, "History" },
                    { 378, 3, 2, "Geography" },
                    { 379, 3, 3, "PE" },
                    { 380, 3, 4, "PE" },
                    { 381, 3, 5, "Math" },
                    { 382, 3, 6, "Geography" },
                    { 383, 3, 7, "English" },
                    { 384, 3, 8, "PE" },
                    { 385, 4, 1, "Polish" },
                    { 386, 4, 2, "History" },
                    { 387, 4, 3, "Chemistry" },
                    { 388, 4, 4, "PE" },
                    { 389, 4, 5, "Polish" },
                    { 390, 4, 6, "English" },
                    { 391, 4, 7, "PE" },
                    { 392, 4, 8, "PE" },
                    { 393, 5, 1, "Geography" },
                    { 394, 5, 2, "English" },
                    { 395, 5, 3, "Polish" },
                    { 396, 5, 4, "Math" },
                    { 397, 5, 5, "PE" },
                    { 398, 5, 6, "Physics" },
                    { 399, 5, 7, "Polish" },
                    { 400, 5, 8, "Math" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Mary35@yahoo.com", "Mary", "Funk", "1-998-750-5407 x5238" },
                    { 2, "Lula_Koelpin@hotmail.com", "Lula", "Koelpin", "1-255-372-1914" },
                    { 3, "Muriel_Howell@yahoo.com", "Muriel", "Howell", "997.626.5587" },
                    { 4, "Luther59@yahoo.com", "Luther", "Doyle", "1-478-460-1918" },
                    { 5, "Wm.Witting@yahoo.com", "Wm", "Witting", "1-640-355-7532 x720" },
                    { 6, "Barry.Gottlieb@hotmail.com", "Barry", "Gottlieb", "1-328-576-8610 x88980" },
                    { 7, "Lynn_Russel@hotmail.com", "Lynn", "Russel", "(448) 521-3017 x145" },
                    { 8, "Kelley5@gmail.com", "Kelley", "Zieme", "1-447-842-2048" },
                    { 9, "Juan.Kessler@hotmail.com", "Juan", "Kessler", "746.750.7399" },
                    { 10, "Ellen60@gmail.com", "Ellen", "Corwin", "965-562-8438" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 11, "Ralph12@gmail.com", "Ralph", "Schultz", "839.754.6922 x63666" },
                    { 12, "Kristy_Bogisich@hotmail.com", "Kristy", "Bogisich", "(954) 363-5066" },
                    { 13, "Kara.Green@gmail.com", "Kara", "Green", "236-301-8077 x59189" },
                    { 14, "Andy84@gmail.com", "Andy", "Leannon", "765.707.2448 x6207" },
                    { 15, "May.Adams72@hotmail.com", "May", "Adams", "(421) 528-0915 x897" },
                    { 16, "Steven_Walter20@hotmail.com", "Steven", "Walter", "773-793-5539" },
                    { 17, "Toni.Hackett32@hotmail.com", "Toni", "Hackett", "1-213-731-3416 x99516" },
                    { 18, "Kristie_Schumm73@gmail.com", "Kristie", "Schumm", "422.512.1173 x50194" },
                    { 19, "Leroy_Bayer@hotmail.com", "Leroy", "Bayer", "1-354-597-0913 x260" },
                    { 20, "Kim.Gutkowski33@gmail.com", "Kim", "Gutkowski", "(829) 782-6757 x0912" },
                    { 21, "Brandy10@hotmail.com", "Brandy", "Wilkinson", "817.304.8405" },
                    { 22, "Marion90@hotmail.com", "Marion", "Thompson", "868-937-0830" },
                    { 23, "Ebony91@yahoo.com", "Ebony", "Ebert", "374-789-2398 x6613" },
                    { 24, "Jasmine.Goodwin@yahoo.com", "Jasmine", "Goodwin", "1-751-220-4886 x88123" },
                    { 25, "Hattie_Monahan90@gmail.com", "Hattie", "Monahan", "332-882-6250 x849" },
                    { 26, "Josephine.Bogan25@hotmail.com", "Josephine", "Bogan", "1-227-989-8412 x32235" },
                    { 27, "Matthew6@gmail.com", "Matthew", "Wilkinson", "(945) 344-7405 x709" },
                    { 28, "Johanna_Lockman5@hotmail.com", "Johanna", "Lockman", "436.859.2397 x604" },
                    { 29, "Yvette_Daugherty@gmail.com", "Yvette", "Daugherty", "(927) 701-6617 x6168" },
                    { 30, "Stella13@yahoo.com", "Stella", "Davis", "(238) 923-2439" },
                    { 31, "Terry_Moen74@yahoo.com", "Terry", "Moen", "823.379.5019" },
                    { 32, "Leo35@yahoo.com", "Leo", "Shields", "1-553-994-2831 x264" },
                    { 33, "Chris9@gmail.com", "Chris", "Koss", "645-939-6112 x02138" },
                    { 34, "Patrick7@gmail.com", "Patrick", "Bogan", "1-796-467-2169 x80055" },
                    { 35, "Hannah.Bogisich62@hotmail.com", "Hannah", "Bogisich", "422-795-1502 x93277" },
                    { 36, "Hubert_Beier@hotmail.com", "Hubert", "Beier", "222-848-4351" },
                    { 37, "Danielle48@yahoo.com", "Danielle", "Hyatt", "834-470-1795" },
                    { 38, "Kate.Batz@hotmail.com", "Kate", "Batz", "(895) 202-5662" },
                    { 39, "Johnathan_Funk85@gmail.com", "Johnathan", "Funk", "1-472-407-7277" },
                    { 40, "Greg22@yahoo.com", "Greg", "Barrows", "1-228-413-1756" },
                    { 41, "Annette49@gmail.com", "Annette", "Cormier", "1-859-575-0138" },
                    { 42, "Rodney_Stroman58@hotmail.com", "Rodney", "Stroman", "1-383-345-8552 x565" },
                    { 43, "Jamie26@hotmail.com", "Jamie", "Kilback", "206-839-2016 x4262" },
                    { 44, "Saul63@hotmail.com", "Saul", "Schoen", "205.822.1976" },
                    { 45, "Charlene95@yahoo.com", "Charlene", "Gulgowski", "562-280-8304" },
                    { 46, "Jimmie30@gmail.com", "Jimmie", "Hagenes", "581-652-6982 x11422" },
                    { 47, "Linda.Zieme@hotmail.com", "Linda", "Zieme", "960-706-4043 x9559" },
                    { 48, "Silvia_Collier@hotmail.com", "Silvia", "Collier", "1-353-254-2177 x12710" },
                    { 49, "Kirk_Hirthe@gmail.com", "Kirk", "Hirthe", "(288) 699-1426" },
                    { 50, "Muriel95@hotmail.com", "Muriel", "Emard", "1-281-310-1461 x55907" },
                    { 51, "Leticia39@gmail.com", "Leticia", "Bode", "378-878-2626 x2795" },
                    { 52, "Courtney.Kertzmann71@gmail.com", "Courtney", "Kertzmann", "624.923.9160" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 53, "Ernestine2@yahoo.com", "Ernestine", "Raynor", "949.219.2584 x96810" },
                    { 54, "Terence.Sanford12@yahoo.com", "Terence", "Sanford", "975-394-9617 x16382" },
                    { 55, "Fred.Hilpert49@gmail.com", "Fred", "Hilpert", "663-278-8211" },
                    { 56, "Myrtle_Welch4@yahoo.com", "Myrtle", "Welch", "1-579-936-5733" },
                    { 57, "Paula64@yahoo.com", "Paula", "Lynch", "(329) 425-4064" },
                    { 58, "Allison.Kovacek37@yahoo.com", "Allison", "Kovacek", "(419) 286-1982 x4110" },
                    { 59, "Gwen.Rodriguez61@hotmail.com", "Gwen", "Rodriguez", "249.311.3329 x185" },
                    { 60, "Jack_McKenzie@gmail.com", "Jack", "McKenzie", "(740) 423-0478 x282" },
                    { 61, "Darrel8@yahoo.com", "Darrel", "Weimann", "288.437.3482" },
                    { 62, "Misty50@hotmail.com", "Misty", "Dickens", "744.465.7335 x929" },
                    { 63, "Ian36@gmail.com", "Ian", "Yundt", "1-900-648-5598" },
                    { 64, "Florence.Klocko@yahoo.com", "Florence", "Klocko", "1-638-361-5390" },
                    { 65, "Ruth_Reynolds51@hotmail.com", "Ruth", "Reynolds", "(579) 368-6620" },
                    { 66, "Sonja.OKeefe@gmail.com", "Sonja", "O'Keefe", "792.413.9902" },
                    { 67, "Tim_West@yahoo.com", "Tim", "West", "1-790-818-6065 x848" },
                    { 68, "Johnathan87@yahoo.com", "Johnathan", "Gibson", "728-239-7656" },
                    { 69, "Kathryn92@hotmail.com", "Kathryn", "Schmeler", "(668) 346-0867" },
                    { 70, "Kristi55@hotmail.com", "Kristi", "Dietrich", "1-324-598-9294 x474" },
                    { 71, "Juan19@hotmail.com", "Juan", "Borer", "(429) 544-5292 x040" },
                    { 72, "Nelson92@hotmail.com", "Nelson", "Kunze", "(556) 943-0167" },
                    { 73, "Essie_Wisozk41@yahoo.com", "Essie", "Wisozk", "1-212-466-6445 x10751" },
                    { 74, "Jeannette_Braun79@yahoo.com", "Jeannette", "Braun", "1-350-641-5781 x618" },
                    { 75, "Allan_Bernier16@gmail.com", "Allan", "Bernier", "353-212-6560 x05844" },
                    { 76, "Mattie.Spinka@gmail.com", "Mattie", "Spinka", "276.666.6013 x3310" },
                    { 77, "Mathew29@gmail.com", "Mathew", "Anderson", "967.621.4680 x884" },
                    { 78, "Maggie99@gmail.com", "Maggie", "Weissnat", "769.556.6570 x794" },
                    { 79, "Michelle_Tremblay@yahoo.com", "Michelle", "Tremblay", "1-306-943-9955 x35650" },
                    { 80, "Nadine.Dietrich@yahoo.com", "Nadine", "Dietrich", "982-943-2030" },
                    { 81, "Ruth18@yahoo.com", "Ruth", "Wilderman", "(277) 490-0471" },
                    { 82, "Shannon.Dickinson25@hotmail.com", "Shannon", "Dickinson", "1-821-232-8947 x6814" },
                    { 83, "Valerie_Hand@yahoo.com", "Valerie", "Hand", "1-854-474-6581" },
                    { 84, "Rhonda82@gmail.com", "Rhonda", "Torp", "(958) 556-5084 x33629" },
                    { 85, "Norman_Purdy66@yahoo.com", "Norman", "Purdy", "386-215-4242" },
                    { 86, "Nellie_McKenzie@gmail.com", "Nellie", "McKenzie", "(452) 886-5754 x3365" },
                    { 87, "Brendan85@yahoo.com", "Brendan", "Bins", "1-816-772-5393 x411" },
                    { 88, "Maurice.Jones@gmail.com", "Maurice", "Jones", "1-924-407-3559 x06839" },
                    { 89, "Vanessa.Marks@yahoo.com", "Vanessa", "Marks", "1-576-358-8584 x531" },
                    { 90, "Jeremy.Farrell@yahoo.com", "Jeremy", "Farrell", "963-699-5585 x1710" },
                    { 91, "Johnathan_Wilkinson@yahoo.com", "Johnathan", "Wilkinson", "726.808.8833 x723" },
                    { 92, "Carroll9@yahoo.com", "Carroll", "Roob", "(690) 251-2850 x56504" },
                    { 93, "Meredith.Heaney@yahoo.com", "Meredith", "Heaney", "1-610-922-6118" },
                    { 94, "Francisco65@yahoo.com", "Francisco", "Nitzsche", "377.496.0537 x56684" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 95, "Felipe18@yahoo.com", "Felipe", "Franecki", "395-793-9714" },
                    { 96, "Alonzo_Harber@hotmail.com", "Alonzo", "Harber", "1-459-269-3161" },
                    { 97, "Jasmine_Wiegand12@gmail.com", "Jasmine", "Wiegand", "(679) 862-5533" },
                    { 98, "Alexander45@yahoo.com", "Alexander", "Kshlerin", "532-655-1834" },
                    { 99, "Henry_Wolf@hotmail.com", "Henry", "Wolf", "(406) 224-2606 x01787" },
                    { 100, "Gertrude_DuBuque1@yahoo.com", "Gertrude", "DuBuque", "1-960-448-4459 x68708" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), null, null, "Danny.Kessler@gmail.com", null, null, "", null, null },
                    { new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), null, null, "Mathew.Heathcote8@hotmail.com", null, null, "", null, null },
                    { new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), null, null, "Faye_Tillman66@gmail.com", null, null, "", null, null },
                    { new Guid("075ef475-0520-41cc-ab52-178b0221640e"), null, null, "Kelly59@hotmail.com", null, null, "", null, null },
                    { new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), null, null, "Ella80@hotmail.com", null, null, "", null, null },
                    { new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), null, null, "Robert32@hotmail.com", null, null, "", null, null },
                    { new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), null, null, "Billie.Gleason@gmail.com", null, null, "", null, null },
                    { new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), null, null, "Cornelius41@hotmail.com", null, null, "", null, null },
                    { new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), null, null, "Sylvester40@gmail.com", null, null, "", null, null },
                    { new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), null, null, "Jenny.Welch@hotmail.com", null, null, "", null, null },
                    { new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), null, null, "Sam_Aufderhar98@gmail.com", null, null, "", null, null },
                    { new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), null, null, "Ashley42@yahoo.com", null, null, "", null, null },
                    { new Guid("179ac0de-306b-47de-abf3-f619ec367085"), null, null, "Rene.Wyman66@hotmail.com", null, null, "", null, null },
                    { new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), null, null, "Edith91@gmail.com", null, null, "", null, null },
                    { new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), null, null, "Bob14@yahoo.com", null, null, "", null, null },
                    { new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), null, null, "Fredrick_Bartell@yahoo.com", null, null, "", null, null },
                    { new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), null, null, "Vivian88@hotmail.com", null, null, "", null, null },
                    { new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), null, null, "Regina4@hotmail.com", null, null, "", null, null },
                    { new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), null, null, "Lucas.Kertzmann45@hotmail.com", null, null, "", null, null },
                    { new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), null, null, "Rudy.Witting83@gmail.com", null, null, "", null, null },
                    { new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), null, null, "Karen_Langosh21@gmail.com", null, null, "", null, null },
                    { new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), null, null, "Donna31@gmail.com", null, null, "", null, null },
                    { new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), null, null, "Rene.Ferry@yahoo.com", null, null, "", null, null },
                    { new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), null, null, "Monica_OKeefe@gmail.com", null, null, "", null, null },
                    { new Guid("4307075b-d195-449f-b670-e64f49be87ba"), null, null, "Debra40@hotmail.com", null, null, "", null, null },
                    { new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), null, null, "Joshua.Harris@hotmail.com", null, null, "", null, null },
                    { new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), null, null, "Leah81@hotmail.com", null, null, "", null, null },
                    { new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), null, null, "Tami.Nikolaus@yahoo.com", null, null, "", null, null },
                    { new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), null, null, "Miguel88@hotmail.com", null, null, "", null, null },
                    { new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), null, null, "Everett.Lakin@hotmail.com", null, null, "", null, null },
                    { new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), null, null, "Charlie.Dare38@hotmail.com", null, null, "", null, null },
                    { new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), null, null, "Cynthia.Bednar@hotmail.com", null, null, "", null, null },
                    { new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), null, null, "Kristine.Veum18@yahoo.com", null, null, "", null, null },
                    { new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), null, null, "Lila.Dooley69@gmail.com", null, null, "", null, null },
                    { new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), null, null, "Margaret3@yahoo.com", null, null, "", null, null },
                    { new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), null, null, "Sue_Toy48@hotmail.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), null, null, "Mildred.Towne@gmail.com", null, null, "", null, null },
                    { new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), null, null, "Tommie_Lubowitz18@yahoo.com", null, null, "", null, null },
                    { new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), null, null, "Ruben.Frami@yahoo.com", null, null, "", null, null },
                    { new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), null, null, "Dave_King@hotmail.com", null, null, "", null, null },
                    { new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), null, null, "Bryant5@hotmail.com", null, null, "", null, null },
                    { new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), null, null, "Darrel_Roob29@yahoo.com", null, null, "", null, null },
                    { new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), null, null, "Leslie_Hodkiewicz@hotmail.com", null, null, "", null, null },
                    { new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), null, null, "Keith_Welch8@gmail.com", null, null, "", null, null },
                    { new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), null, null, "Ruth_Glover73@gmail.com", null, null, "", null, null },
                    { new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), null, null, "Cary41@yahoo.com", null, null, "", null, null },
                    { new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), null, null, "Katie.Zulauf@yahoo.com", null, null, "", null, null },
                    { new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), null, null, "Stuart_Toy64@yahoo.com", null, null, "", null, null },
                    { new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), null, null, "Ollie_Krajcik38@yahoo.com", null, null, "", null, null },
                    { new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), null, null, "Georgia14@yahoo.com", null, null, "", null, null },
                    { new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), null, null, "Bennie_Bechtelar@gmail.com", null, null, "", null, null },
                    { new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), null, null, "Gayle_Abbott37@hotmail.com", null, null, "", null, null },
                    { new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), null, null, "Kurt86@gmail.com", null, null, "", null, null },
                    { new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), null, null, "Clinton.Collier13@hotmail.com", null, null, "", null, null },
                    { new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), null, null, "Winifred_Lesch@gmail.com", null, null, "", null, null },
                    { new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), null, null, "Armando_Hyatt25@yahoo.com", null, null, "", null, null },
                    { new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), null, null, "Crystal_Olson@yahoo.com", null, null, "", null, null },
                    { new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), null, null, "Bernard_Hand@yahoo.com", null, null, "", null, null },
                    { new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), null, null, "Tricia50@yahoo.com", null, null, "", null, null },
                    { new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), null, null, "Brenda.Dibbert@gmail.com", null, null, "", null, null },
                    { new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), null, null, "Viola_Kovacek@hotmail.com", null, null, "", null, null },
                    { new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), null, null, "Leon_Ruecker@hotmail.com", null, null, "", null, null },
                    { new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), null, null, "Ruby77@hotmail.com", null, null, "", null, null },
                    { new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), null, null, "Douglas_Padberg@gmail.com", null, null, "", null, null },
                    { new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), null, null, "Karl19@hotmail.com", null, null, "", null, null },
                    { new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), null, null, "Anita_Doyle44@hotmail.com", null, null, "", null, null },
                    { new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), null, null, "Walter_Lesch19@gmail.com", null, null, "", null, null },
                    { new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), null, null, "Randal37@hotmail.com", null, null, "", null, null },
                    { new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), null, null, "Kelly72@hotmail.com", null, null, "", null, null },
                    { new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), null, null, "Wallace_Russel@hotmail.com", null, null, "", null, null },
                    { new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), null, null, "Lucille_Huels@hotmail.com", null, null, "", null, null },
                    { new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), null, null, "Jordan12@hotmail.com", null, null, "", null, null },
                    { new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), null, null, "Nettie.Daniel@yahoo.com", null, null, "", null, null },
                    { new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), null, null, "Mattie.Pouros58@hotmail.com", null, null, "", null, null },
                    { new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), null, null, "Monique_Bednar14@hotmail.com", null, null, "", null, null },
                    { new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), null, null, "Armando.Mitchell21@hotmail.com", null, null, "", null, null },
                    { new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), null, null, "Dwayne.Bernhard@yahoo.com", null, null, "", null, null },
                    { new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), null, null, "Catherine_Gerhold@gmail.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), null, null, "Janie_Lind16@gmail.com", null, null, "", null, null },
                    { new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), null, null, "Elsie_Rath@hotmail.com", null, null, "", null, null },
                    { new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), null, null, "Regina54@yahoo.com", null, null, "", null, null },
                    { new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), null, null, "Josh_Hermann@gmail.com", null, null, "", null, null },
                    { new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), null, null, "Phillip_Russel@gmail.com", null, null, "", null, null },
                    { new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), null, null, "Jay17@yahoo.com", null, null, "", null, null },
                    { new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), null, null, "Josefina.Wiegand64@yahoo.com", null, null, "", null, null },
                    { new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), null, null, "Julie_Kemmer@yahoo.com", null, null, "", null, null },
                    { new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), null, null, "Stephen_OHara@hotmail.com", null, null, "", null, null },
                    { new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), null, null, "Colleen_Trantow4@gmail.com", null, null, "", null, null },
                    { new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), null, null, "Rachael16@yahoo.com", null, null, "", null, null },
                    { new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), null, null, "Jean.Moore@gmail.com", null, null, "", null, null },
                    { new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), null, null, "Carolyn_Blanda@yahoo.com", null, null, "", null, null },
                    { new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), null, null, "Vicki_Kunze4@hotmail.com", null, null, "", null, null },
                    { new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), null, null, "Lloyd.Stark@yahoo.com", null, null, "", null, null },
                    { new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), null, null, "Luz79@yahoo.com", null, null, "", null, null },
                    { new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), null, null, "Shannon29@yahoo.com", null, null, "", null, null },
                    { new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), null, null, "Florence0@gmail.com", null, null, "", null, null },
                    { new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), null, null, "May.Yost88@gmail.com", null, null, "", null, null },
                    { new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), null, null, "Theresa.Powlowski75@gmail.com", null, null, "", null, null },
                    { new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), null, null, "Eloise_Dietrich@yahoo.com", null, null, "", null, null },
                    { new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), null, null, "Hilda.Langworth87@hotmail.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Randall9@gmail.com", "Randall", false, "O'Conner", "(255) 420-7038" },
                    { 2, "Emma92@yahoo.com", "Emma", false, "Spencer", "764.684.1882 x769" },
                    { 3, "Daniel5@hotmail.com", "Daniel", false, "Hartmann", "495.421.3995 x89229" },
                    { 4, "Alberta_Metz@yahoo.com", "Alberta", false, "Metz", "(263) 615-6428" },
                    { 5, "Calvin_Cremin37@yahoo.com", "Calvin", false, "Cremin", "1-527-527-1684 x75975" },
                    { 6, "Anthony_Stokes@gmail.com", "Anthony", false, "Stokes", "259-842-2071 x3951" },
                    { 7, "Zachary_Brekke@gmail.com", "Zachary", false, "Brekke", "485.815.7412 x083" },
                    { 8, "Josh_Lehner@hotmail.com", "Josh", false, "Lehner", "237-520-0069 x8572" },
                    { 9, "Peter_Heidenreich@yahoo.com", "Peter", false, "Heidenreich", "834-986-0863 x0576" },
                    { 10, "Kayla_Hickle@hotmail.com", "Kayla", false, "Hickle", "(475) 732-3336" },
                    { 11, "Austin.Lang52@gmail.com", "Austin", false, "Lang", "(292) 837-0713 x88365" },
                    { 12, "Israel.Gislason19@hotmail.com", "Israel", false, "Gislason", "1-204-245-0733" },
                    { 13, "Dean.Armstrong@yahoo.com", "Dean", false, "Armstrong", "(519) 441-7760 x3222" },
                    { 14, "Vicky.Dibbert@yahoo.com", "Vicky", false, "Dibbert", "(409) 618-0460 x566" },
                    { 15, "Lynn64@gmail.com", "Lynn", false, "MacGyver", "750-761-3032" },
                    { 16, "Pamela56@yahoo.com", "Pamela", false, "Armstrong", "358-559-4665 x83271" },
                    { 17, "Max.Nicolas@hotmail.com", "Max", false, "Nicolas", "1-354-903-3874" },
                    { 18, "Felicia_Kilback7@hotmail.com", "Felicia", false, "Kilback", "993-949-1004 x761" },
                    { 19, "Dallas89@hotmail.com", "Dallas", false, "Block", "894.887.7205" }
                });

            migrationBuilder.InsertData(
                table: "Approve",
                columns: new[] { "ApproveID", "Description", "FK_UserUUID", "Positive" },
                values: new object[,]
                {
                    { 1, "", new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), true },
                    { 2, "", new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), true },
                    { 3, "", new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), true },
                    { 4, "", new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), false },
                    { 5, "", new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), true },
                    { 6, "", new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), false },
                    { 7, "", new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), true },
                    { 8, "", new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), false },
                    { 9, "", new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), false },
                    { 10, "", new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), false },
                    { 11, "", new Guid("4307075b-d195-449f-b670-e64f49be87ba"), true },
                    { 12, "", new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), false },
                    { 13, "", new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), false },
                    { 14, "", new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), true },
                    { 15, "", new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), true },
                    { 16, "", new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), false },
                    { 17, "", new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), true },
                    { 18, "", new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), false },
                    { 19, "", new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), true },
                    { 20, "", new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), true },
                    { 21, "", new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), false },
                    { 22, "", new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), true },
                    { 23, "", new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), false },
                    { 24, "", new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), true },
                    { 25, "", new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), true },
                    { 26, "", new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), false },
                    { 27, "", new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), true },
                    { 28, "", new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), false },
                    { 29, "", new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), false },
                    { 30, "", new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), false }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 1, "", new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), 4, 3 },
                    { 2, "", new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), 5, 2 },
                    { 3, "", new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), 5, 3 },
                    { 4, "", new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), 4, 1 },
                    { 5, "", new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), 4, 3 },
                    { 6, "", new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), 4, 2 },
                    { 7, "", new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), 3, 3 },
                    { 8, "", new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), 5, 2 },
                    { 9, "", new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), 3, 1 },
                    { 10, "", new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), 1, 3 },
                    { 11, "", new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), 1, 3 },
                    { 12, "", new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 13, "", new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), 2, 2 },
                    { 14, "", new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), 4, 2 },
                    { 15, "", new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), 6, 3 },
                    { 16, "", new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), 4, 2 },
                    { 17, "", new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), 3, 3 },
                    { 18, "", new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), 5, 3 },
                    { 19, "", new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), 6, 1 },
                    { 20, "", new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), 4, 2 },
                    { 21, "", new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), 3, 2 },
                    { 22, "", new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), 3, 3 },
                    { 23, "", new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), 6, 3 },
                    { 24, "", new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), 5, 1 },
                    { 25, "", new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), 2, 3 },
                    { 26, "", new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), 2, 1 },
                    { 27, "", new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), 4, 1 },
                    { 28, "", new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), 4, 2 },
                    { 29, "", new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), 5, 1 },
                    { 30, "", new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), 1, 1 },
                    { 31, "", new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), 1, 1 },
                    { 32, "", new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), 1, 2 },
                    { 33, "", new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), 5, 1 },
                    { 34, "", new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), 1, 2 },
                    { 35, "", new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), 2, 1 },
                    { 36, "", new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), 3, 1 },
                    { 37, "", new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), 1, 3 },
                    { 38, "", new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), 6, 1 },
                    { 39, "", new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), 6, 2 },
                    { 40, "", new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), 3, 1 },
                    { 41, "", new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), 2, 2 },
                    { 42, "", new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), 5, 2 },
                    { 43, "", new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), 1, 2 },
                    { 44, "", new Guid("179ac0de-306b-47de-abf3-f619ec367085"), 6, 3 },
                    { 45, "", new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), 5, 3 },
                    { 46, "", new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), 3, 3 },
                    { 47, "", new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), 3, 1 },
                    { 48, "", new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), 6, 3 },
                    { 49, "", new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), 5, 1 },
                    { 50, "", new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), 3, 3 },
                    { 51, "", new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), 5, 1 },
                    { 52, "", new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), 6, 1 },
                    { 53, "", new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), 2, 3 },
                    { 54, "", new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 55, "", new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), 4, 2 },
                    { 56, "", new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), 1, 1 },
                    { 57, "", new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), 2, 1 },
                    { 58, "", new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), 6, 3 },
                    { 59, "", new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), 5, 2 },
                    { 60, "", new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), 5, 3 },
                    { 61, "", new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), 3, 2 },
                    { 62, "", new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), 6, 1 },
                    { 63, "", new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), 2, 3 },
                    { 64, "", new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), 5, 2 },
                    { 65, "", new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), 4, 3 },
                    { 66, "", new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), 6, 3 },
                    { 67, "", new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), 1, 1 },
                    { 68, "", new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), 1, 1 },
                    { 69, "", new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), 4, 2 },
                    { 70, "", new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), 2, 3 },
                    { 71, "", new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), 6, 3 },
                    { 72, "", new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), 4, 2 },
                    { 73, "", new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), 5, 2 },
                    { 74, "", new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), 5, 3 },
                    { 75, "", new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), 5, 1 },
                    { 76, "", new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), 3, 1 },
                    { 77, "", new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), 1, 1 },
                    { 78, "", new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), 5, 1 },
                    { 79, "", new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), 5, 2 },
                    { 80, "", new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), 5, 2 },
                    { 81, "", new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), 3, 2 },
                    { 82, "", new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), 4, 1 },
                    { 83, "", new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), 5, 2 },
                    { 84, "", new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), 5, 3 },
                    { 85, "", new Guid("4307075b-d195-449f-b670-e64f49be87ba"), 4, 2 },
                    { 86, "", new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), 4, 3 },
                    { 87, "", new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), 6, 3 },
                    { 88, "", new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), 5, 3 },
                    { 89, "", new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), 3, 3 },
                    { 90, "", new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), 3, 2 },
                    { 91, "", new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), 6, 1 },
                    { 92, "", new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), 6, 2 },
                    { 93, "", new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), 6, 1 },
                    { 94, "", new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), 3, 3 },
                    { 95, "", new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), 4, 3 },
                    { 96, "", new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 97, "", new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), 2, 2 },
                    { 98, "", new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), 3, 1 },
                    { 99, "", new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), 2, 1 },
                    { 100, "", new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), 1, 1 },
                    { 101, "", new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), 2, 1 },
                    { 102, "", new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), 4, 1 },
                    { 103, "", new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), 6, 3 },
                    { 104, "", new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), 2, 3 },
                    { 105, "", new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), 6, 3 },
                    { 106, "", new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), 2, 2 },
                    { 107, "", new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), 1, 1 },
                    { 108, "", new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), 3, 3 },
                    { 109, "", new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), 3, 2 },
                    { 110, "", new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), 5, 2 },
                    { 111, "", new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), 4, 3 },
                    { 112, "", new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), 1, 2 },
                    { 113, "", new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), 6, 1 },
                    { 114, "", new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), 5, 1 },
                    { 115, "", new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), 6, 1 },
                    { 116, "", new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), 6, 2 },
                    { 117, "", new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), 1, 2 },
                    { 118, "", new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), 1, 2 },
                    { 119, "", new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), 1, 3 },
                    { 120, "", new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), 2, 2 },
                    { 121, "", new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), 5, 3 },
                    { 122, "", new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), 3, 1 },
                    { 123, "", new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), 4, 2 },
                    { 124, "", new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), 6, 3 },
                    { 125, "", new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), 3, 3 },
                    { 126, "", new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), 6, 2 },
                    { 127, "", new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), 1, 3 },
                    { 128, "", new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), 3, 1 },
                    { 129, "", new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), 4, 3 },
                    { 130, "", new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), 4, 3 },
                    { 131, "", new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), 2, 2 },
                    { 132, "", new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), 4, 3 },
                    { 133, "", new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), 5, 1 },
                    { 134, "", new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), 1, 3 },
                    { 135, "", new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), 6, 3 },
                    { 136, "", new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), 4, 3 },
                    { 137, "", new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), 5, 3 },
                    { 138, "", new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 139, "", new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), 2, 2 },
                    { 140, "", new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), 5, 1 },
                    { 141, "", new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), 4, 2 },
                    { 142, "", new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), 6, 1 },
                    { 143, "", new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), 6, 1 },
                    { 144, "", new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), 6, 1 },
                    { 145, "", new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), 3, 3 },
                    { 146, "", new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), 6, 3 },
                    { 147, "", new Guid("4307075b-d195-449f-b670-e64f49be87ba"), 4, 1 },
                    { 148, "", new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), 3, 2 },
                    { 149, "", new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), 1, 2 },
                    { 150, "", new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), 5, 1 },
                    { 151, "", new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), 5, 1 },
                    { 152, "", new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), 1, 2 },
                    { 153, "", new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), 4, 2 },
                    { 154, "", new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), 3, 2 },
                    { 155, "", new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), 4, 1 },
                    { 156, "", new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), 6, 3 },
                    { 157, "", new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), 3, 1 },
                    { 158, "", new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), 5, 1 },
                    { 159, "", new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), 1, 3 },
                    { 160, "", new Guid("075ef475-0520-41cc-ab52-178b0221640e"), 5, 3 },
                    { 161, "", new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), 1, 1 },
                    { 162, "", new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), 6, 2 },
                    { 163, "", new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), 5, 1 },
                    { 164, "", new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), 4, 1 },
                    { 165, "", new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), 5, 2 },
                    { 166, "", new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), 4, 1 },
                    { 167, "", new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), 3, 3 },
                    { 168, "", new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), 2, 3 },
                    { 169, "", new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), 5, 2 },
                    { 170, "", new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), 6, 3 },
                    { 171, "", new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), 1, 1 },
                    { 172, "", new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), 6, 2 },
                    { 173, "", new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), 3, 2 },
                    { 174, "", new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), 2, 3 },
                    { 175, "", new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), 3, 2 },
                    { 176, "", new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), 1, 1 },
                    { 177, "", new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), 5, 3 },
                    { 178, "", new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), 4, 3 },
                    { 179, "", new Guid("179ac0de-306b-47de-abf3-f619ec367085"), 1, 1 },
                    { 180, "", new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 181, "", new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), 2, 1 },
                    { 182, "", new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), 1, 3 },
                    { 183, "", new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), 5, 3 },
                    { 184, "", new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), 3, 1 },
                    { 185, "", new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), 3, 3 },
                    { 186, "", new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), 6, 3 },
                    { 187, "", new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), 6, 1 },
                    { 188, "", new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), 5, 3 },
                    { 189, "", new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), 1, 1 },
                    { 190, "", new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), 5, 2 },
                    { 191, "", new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), 3, 3 },
                    { 192, "", new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), 5, 1 },
                    { 193, "", new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), 1, 3 },
                    { 194, "", new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), 6, 3 },
                    { 195, "", new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), 2, 3 },
                    { 196, "", new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), 4, 3 },
                    { 197, "", new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), 1, 1 },
                    { 198, "", new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), 4, 2 },
                    { 199, "", new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), 5, 2 },
                    { 200, "", new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), 3, 2 },
                    { 201, "", new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), 6, 1 },
                    { 202, "", new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), 4, 1 },
                    { 203, "", new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), 3, 1 },
                    { 204, "", new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), 1, 3 },
                    { 205, "", new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), 4, 1 },
                    { 206, "", new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), 2, 1 },
                    { 207, "", new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), 2, 1 },
                    { 208, "", new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), 4, 3 },
                    { 209, "", new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), 5, 3 },
                    { 210, "", new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), 5, 1 },
                    { 211, "", new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), 1, 3 },
                    { 212, "", new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), 4, 2 },
                    { 213, "", new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), 1, 1 },
                    { 214, "", new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), 6, 1 },
                    { 215, "", new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), 1, 2 },
                    { 216, "", new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), 2, 3 },
                    { 217, "", new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), 4, 1 },
                    { 218, "", new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), 3, 1 },
                    { 219, "", new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), 2, 1 },
                    { 220, "", new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), 1, 3 },
                    { 221, "", new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), 4, 1 },
                    { 222, "", new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 223, "", new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), 4, 3 },
                    { 224, "", new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), 2, 3 },
                    { 225, "", new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), 1, 3 },
                    { 226, "", new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), 2, 2 },
                    { 227, "", new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), 2, 1 },
                    { 228, "", new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), 2, 3 },
                    { 229, "", new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), 1, 2 },
                    { 230, "", new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), 3, 1 },
                    { 231, "", new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), 1, 2 },
                    { 232, "", new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), 1, 1 },
                    { 233, "", new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), 3, 3 },
                    { 234, "", new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), 1, 2 },
                    { 235, "", new Guid("075ef475-0520-41cc-ab52-178b0221640e"), 4, 2 },
                    { 236, "", new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), 1, 2 },
                    { 237, "", new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), 2, 1 },
                    { 238, "", new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), 2, 2 },
                    { 239, "", new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), 3, 1 },
                    { 240, "", new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), 5, 3 },
                    { 241, "", new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), 5, 1 },
                    { 242, "", new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), 4, 1 },
                    { 243, "", new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), 1, 2 },
                    { 244, "", new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), 1, 1 },
                    { 245, "", new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), 6, 1 },
                    { 246, "", new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), 3, 3 },
                    { 247, "", new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), 5, 2 },
                    { 248, "", new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), 6, 2 },
                    { 249, "", new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), 4, 1 },
                    { 250, "", new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), 4, 3 },
                    { 251, "", new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), 3, 3 },
                    { 252, "", new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), 1, 2 },
                    { 253, "", new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), 6, 1 },
                    { 254, "", new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), 5, 2 },
                    { 255, "", new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), 4, 1 },
                    { 256, "", new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), 1, 2 },
                    { 257, "", new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), 4, 3 },
                    { 258, "", new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), 5, 2 },
                    { 259, "", new Guid("075ef475-0520-41cc-ab52-178b0221640e"), 5, 2 },
                    { 260, "", new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), 4, 1 },
                    { 261, "", new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), 6, 1 },
                    { 262, "", new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), 5, 3 },
                    { 263, "", new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), 4, 2 },
                    { 264, "", new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 265, "", new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), 1, 2 },
                    { 266, "", new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), 5, 3 },
                    { 267, "", new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), 1, 1 },
                    { 268, "", new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), 2, 2 },
                    { 269, "", new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), 4, 2 },
                    { 270, "", new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), 2, 3 },
                    { 271, "", new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), 6, 3 },
                    { 272, "", new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), 1, 1 },
                    { 273, "", new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), 3, 3 },
                    { 274, "", new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), 3, 2 },
                    { 275, "", new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), 1, 3 },
                    { 276, "", new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), 1, 1 },
                    { 277, "", new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), 6, 2 },
                    { 278, "", new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), 4, 1 },
                    { 279, "", new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), 3, 2 },
                    { 280, "", new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), 4, 3 },
                    { 281, "", new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), 4, 1 },
                    { 282, "", new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), 6, 3 },
                    { 283, "", new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), 6, 3 },
                    { 284, "", new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), 4, 2 },
                    { 285, "", new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), 2, 1 },
                    { 286, "", new Guid("179ac0de-306b-47de-abf3-f619ec367085"), 3, 3 },
                    { 287, "", new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), 4, 3 },
                    { 288, "", new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), 2, 1 },
                    { 289, "", new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), 3, 3 },
                    { 290, "", new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), 6, 2 },
                    { 291, "", new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), 2, 1 },
                    { 292, "", new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), 3, 3 },
                    { 293, "", new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), 5, 1 },
                    { 294, "", new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), 4, 1 },
                    { 295, "", new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), 6, 3 },
                    { 296, "", new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), 6, 1 },
                    { 297, "", new Guid("4307075b-d195-449f-b670-e64f49be87ba"), 1, 2 },
                    { 298, "", new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), 2, 1 },
                    { 299, "", new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), 4, 2 },
                    { 300, "", new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), 4, 3 },
                    { 301, "", new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), 1, 2 },
                    { 302, "", new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), 1, 1 },
                    { 303, "", new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), 5, 1 },
                    { 304, "", new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), 6, 2 },
                    { 305, "", new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), 5, 3 },
                    { 306, "", new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 307, "", new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), 5, 3 },
                    { 308, "", new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), 5, 2 },
                    { 309, "", new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), 2, 2 },
                    { 310, "", new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), 3, 1 },
                    { 311, "", new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), 2, 1 },
                    { 312, "", new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), 5, 1 },
                    { 313, "", new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), 3, 1 },
                    { 314, "", new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), 2, 3 },
                    { 315, "", new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), 1, 2 },
                    { 316, "", new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), 2, 2 },
                    { 317, "", new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), 5, 3 },
                    { 318, "", new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), 6, 2 },
                    { 319, "", new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), 5, 2 },
                    { 320, "", new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), 2, 2 },
                    { 321, "", new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), 3, 1 },
                    { 322, "", new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), 6, 2 },
                    { 323, "", new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), 1, 3 },
                    { 324, "", new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), 5, 3 },
                    { 325, "", new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), 2, 3 },
                    { 326, "", new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), 3, 2 },
                    { 327, "", new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), 3, 2 },
                    { 328, "", new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), 1, 1 },
                    { 329, "", new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), 3, 2 },
                    { 330, "", new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), 6, 2 },
                    { 331, "", new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), 2, 1 },
                    { 332, "", new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), 4, 2 },
                    { 333, "", new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), 6, 3 },
                    { 334, "", new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), 1, 3 },
                    { 335, "", new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), 5, 2 },
                    { 336, "", new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), 2, 2 },
                    { 337, "", new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), 4, 1 },
                    { 338, "", new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), 4, 3 },
                    { 339, "", new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), 4, 2 },
                    { 340, "", new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), 5, 3 },
                    { 341, "", new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), 2, 2 },
                    { 342, "", new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), 5, 3 },
                    { 343, "", new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), 3, 1 },
                    { 344, "", new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), 6, 1 },
                    { 345, "", new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), 1, 1 },
                    { 346, "", new Guid("4307075b-d195-449f-b670-e64f49be87ba"), 5, 3 },
                    { 347, "", new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), 6, 3 },
                    { 348, "", new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 349, "", new Guid("179ac0de-306b-47de-abf3-f619ec367085"), 6, 1 },
                    { 350, "", new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), 2, 1 },
                    { 351, "", new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), 1, 2 },
                    { 352, "", new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), 1, 1 },
                    { 353, "", new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), 2, 3 },
                    { 354, "", new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), 6, 3 },
                    { 355, "", new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), 4, 1 },
                    { 356, "", new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), 1, 3 },
                    { 357, "", new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), 4, 1 },
                    { 358, "", new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), 1, 1 },
                    { 359, "", new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), 6, 3 },
                    { 360, "", new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), 6, 2 },
                    { 361, "", new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), 6, 1 },
                    { 362, "", new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), 2, 2 },
                    { 363, "", new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), 2, 2 },
                    { 364, "", new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), 5, 2 },
                    { 365, "", new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), 4, 2 },
                    { 366, "", new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), 4, 2 },
                    { 367, "", new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), 1, 3 },
                    { 368, "", new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), 5, 3 },
                    { 369, "", new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), 6, 3 },
                    { 370, "", new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), 5, 3 },
                    { 371, "", new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), 1, 3 },
                    { 372, "", new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), 2, 2 },
                    { 373, "", new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), 6, 1 },
                    { 374, "", new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), 5, 3 },
                    { 375, "", new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), 3, 3 },
                    { 376, "", new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), 6, 1 },
                    { 377, "", new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), 3, 3 },
                    { 378, "", new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), 2, 1 },
                    { 379, "", new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), 2, 1 },
                    { 380, "", new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), 4, 3 },
                    { 381, "", new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), 6, 3 },
                    { 382, "", new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), 4, 1 },
                    { 383, "", new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), 3, 3 },
                    { 384, "", new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), 5, 1 },
                    { 385, "", new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), 3, 2 },
                    { 386, "", new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), 6, 2 },
                    { 387, "", new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), 1, 3 },
                    { 388, "", new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), 2, 2 },
                    { 389, "", new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), 4, 1 },
                    { 390, "", new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 391, "", new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), 4, 2 },
                    { 392, "", new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), 2, 2 },
                    { 393, "", new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), 1, 2 },
                    { 394, "", new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), 6, 1 },
                    { 395, "", new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), 1, 3 },
                    { 396, "", new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), 1, 2 },
                    { 397, "", new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), 1, 3 },
                    { 398, "", new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), 1, 1 },
                    { 399, "", new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), 6, 2 },
                    { 400, "", new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), 1, 1 },
                    { 401, "", new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), 3, 3 },
                    { 402, "", new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), 2, 1 },
                    { 403, "", new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), 2, 2 },
                    { 404, "", new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), 4, 3 },
                    { 405, "", new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), 6, 2 },
                    { 406, "", new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), 3, 3 },
                    { 407, "", new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), 4, 1 },
                    { 408, "", new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), 6, 3 },
                    { 409, "", new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), 2, 3 },
                    { 410, "", new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), 2, 2 },
                    { 411, "", new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), 1, 3 },
                    { 412, "", new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), 4, 3 },
                    { 413, "", new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), 2, 3 },
                    { 414, "", new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), 3, 3 },
                    { 415, "", new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), 4, 3 },
                    { 416, "", new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), 3, 3 },
                    { 417, "", new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), 4, 1 },
                    { 418, "", new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), 5, 2 },
                    { 419, "", new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), 6, 3 },
                    { 420, "", new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), 5, 3 },
                    { 421, "", new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), 1, 1 },
                    { 422, "", new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), 6, 2 },
                    { 423, "", new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), 6, 3 },
                    { 424, "", new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), 2, 2 },
                    { 425, "", new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), 1, 2 },
                    { 426, "", new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), 4, 2 },
                    { 427, "", new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), 4, 2 },
                    { 428, "", new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), 5, 3 },
                    { 429, "", new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), 4, 2 },
                    { 430, "", new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), 6, 3 },
                    { 431, "", new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), 6, 2 },
                    { 432, "", new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 433, "", new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), 2, 3 },
                    { 434, "", new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), 3, 2 },
                    { 435, "", new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), 1, 2 },
                    { 436, "", new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), 5, 3 },
                    { 437, "", new Guid("075ef475-0520-41cc-ab52-178b0221640e"), 5, 3 },
                    { 438, "", new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), 5, 2 },
                    { 439, "", new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), 1, 3 },
                    { 440, "", new Guid("075ef475-0520-41cc-ab52-178b0221640e"), 3, 3 },
                    { 441, "", new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), 5, 2 },
                    { 442, "", new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), 2, 3 },
                    { 443, "", new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), 5, 2 },
                    { 444, "", new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), 3, 3 },
                    { 445, "", new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), 2, 1 },
                    { 446, "", new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), 1, 1 },
                    { 447, "", new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), 6, 2 },
                    { 448, "", new Guid("179ac0de-306b-47de-abf3-f619ec367085"), 3, 3 },
                    { 449, "", new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), 5, 3 },
                    { 450, "", new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), 3, 1 },
                    { 451, "", new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), 3, 2 },
                    { 452, "", new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), 4, 3 },
                    { 453, "", new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), 4, 1 },
                    { 454, "", new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), 1, 2 },
                    { 455, "", new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), 3, 2 },
                    { 456, "", new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), 3, 3 },
                    { 457, "", new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), 6, 3 },
                    { 458, "", new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), 6, 1 },
                    { 459, "", new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), 5, 2 },
                    { 460, "", new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), 5, 1 },
                    { 461, "", new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), 6, 2 },
                    { 462, "", new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), 3, 2 },
                    { 463, "", new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), 5, 1 },
                    { 464, "", new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), 5, 3 },
                    { 465, "", new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), 2, 2 },
                    { 466, "", new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), 2, 3 },
                    { 467, "", new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), 1, 3 },
                    { 468, "", new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), 3, 3 },
                    { 469, "", new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), 6, 3 },
                    { 470, "", new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), 5, 3 },
                    { 471, "", new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), 6, 3 },
                    { 472, "", new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), 2, 3 },
                    { 473, "", new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), 5, 1 },
                    { 474, "", new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 475, "", new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), 4, 1 },
                    { 476, "", new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), 1, 3 },
                    { 477, "", new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), 5, 2 },
                    { 478, "", new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), 2, 3 },
                    { 479, "", new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), 5, 1 },
                    { 480, "", new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), 3, 3 },
                    { 481, "", new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), 6, 3 },
                    { 482, "", new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), 4, 3 },
                    { 483, "", new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), 6, 2 },
                    { 484, "", new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), 1, 2 },
                    { 485, "", new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), 1, 3 },
                    { 486, "", new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), 2, 2 },
                    { 487, "", new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), 4, 3 },
                    { 488, "", new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), 1, 2 },
                    { 489, "", new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), 6, 1 },
                    { 490, "", new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), 4, 3 },
                    { 491, "", new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), 1, 3 },
                    { 492, "", new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), 6, 1 },
                    { 493, "", new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), 6, 1 },
                    { 494, "", new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), 3, 3 },
                    { 495, "", new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), 2, 1 },
                    { 496, "", new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), 1, 1 },
                    { 497, "", new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), 1, 2 },
                    { 498, "", new Guid("4307075b-d195-449f-b670-e64f49be87ba"), 1, 3 },
                    { 499, "", new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), 5, 3 },
                    { 500, "", new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 18, 16, 53, 12, 133, DateTimeKind.Local).AddTicks(9450), new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), false },
                    { 2, new DateTime(2022, 7, 18, 20, 25, 6, 865, DateTimeKind.Local).AddTicks(8573), new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), false },
                    { 3, new DateTime(2022, 7, 18, 4, 53, 25, 935, DateTimeKind.Local).AddTicks(9594), new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), false },
                    { 4, new DateTime(2022, 7, 18, 20, 37, 13, 266, DateTimeKind.Local).AddTicks(2859), new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), false },
                    { 5, new DateTime(2022, 7, 18, 19, 27, 4, 903, DateTimeKind.Local).AddTicks(1813), new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), false },
                    { 6, new DateTime(2022, 7, 18, 5, 47, 26, 165, DateTimeKind.Local).AddTicks(7301), new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), false },
                    { 7, new DateTime(2022, 7, 18, 18, 20, 55, 671, DateTimeKind.Local).AddTicks(6819), new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), true },
                    { 8, new DateTime(2022, 7, 19, 1, 25, 3, 374, DateTimeKind.Local).AddTicks(311), new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), false },
                    { 9, new DateTime(2022, 7, 18, 12, 1, 6, 433, DateTimeKind.Local).AddTicks(9905), new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), false },
                    { 10, new DateTime(2022, 7, 19, 0, 39, 6, 886, DateTimeKind.Local).AddTicks(7420), new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), true },
                    { 11, new DateTime(2022, 7, 18, 9, 58, 56, 880, DateTimeKind.Local).AddTicks(821), new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), true },
                    { 12, new DateTime(2022, 7, 18, 8, 56, 39, 409, DateTimeKind.Local).AddTicks(6387), new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), true },
                    { 13, new DateTime(2022, 7, 18, 10, 27, 6, 710, DateTimeKind.Local).AddTicks(3062), new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), true },
                    { 14, new DateTime(2022, 7, 18, 21, 17, 57, 17, DateTimeKind.Local).AddTicks(7215), new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), true },
                    { 15, new DateTime(2022, 7, 18, 10, 2, 26, 359, DateTimeKind.Local).AddTicks(3588), new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), true },
                    { 16, new DateTime(2022, 7, 19, 1, 47, 59, 393, DateTimeKind.Local).AddTicks(2399), new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 17, new DateTime(2022, 7, 18, 16, 0, 47, 277, DateTimeKind.Local).AddTicks(1887), new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), false },
                    { 18, new DateTime(2022, 7, 18, 16, 38, 39, 239, DateTimeKind.Local).AddTicks(6022), new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), true },
                    { 19, new DateTime(2022, 7, 18, 8, 15, 28, 714, DateTimeKind.Local).AddTicks(1004), new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), false },
                    { 20, new DateTime(2022, 7, 18, 18, 28, 57, 152, DateTimeKind.Local).AddTicks(9111), new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), false },
                    { 21, new DateTime(2022, 7, 18, 23, 26, 18, 181, DateTimeKind.Local).AddTicks(1307), new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), true },
                    { 22, new DateTime(2022, 7, 18, 17, 23, 10, 120, DateTimeKind.Local).AddTicks(497), new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), false },
                    { 23, new DateTime(2022, 7, 19, 1, 12, 43, 787, DateTimeKind.Local).AddTicks(9214), new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), true },
                    { 24, new DateTime(2022, 7, 18, 18, 1, 6, 154, DateTimeKind.Local).AddTicks(9425), new Guid("4307075b-d195-449f-b670-e64f49be87ba"), false },
                    { 25, new DateTime(2022, 7, 18, 15, 38, 48, 139, DateTimeKind.Local).AddTicks(3592), new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), false },
                    { 26, new DateTime(2022, 7, 18, 10, 49, 16, 998, DateTimeKind.Local).AddTicks(6761), new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), false },
                    { 27, new DateTime(2022, 7, 18, 20, 39, 18, 286, DateTimeKind.Local).AddTicks(1154), new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), true },
                    { 28, new DateTime(2022, 7, 18, 19, 36, 12, 257, DateTimeKind.Local).AddTicks(8459), new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), true },
                    { 29, new DateTime(2022, 7, 18, 8, 59, 39, 638, DateTimeKind.Local).AddTicks(1430), new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), false },
                    { 30, new DateTime(2022, 7, 18, 7, 44, 4, 238, DateTimeKind.Local).AddTicks(3410), new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), true },
                    { 31, new DateTime(2022, 7, 18, 6, 47, 23, 140, DateTimeKind.Local).AddTicks(5206), new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), true },
                    { 32, new DateTime(2022, 7, 18, 18, 54, 13, 662, DateTimeKind.Local).AddTicks(2516), new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), false },
                    { 33, new DateTime(2022, 7, 18, 17, 2, 55, 700, DateTimeKind.Local).AddTicks(3309), new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), true },
                    { 34, new DateTime(2022, 7, 18, 20, 47, 5, 913, DateTimeKind.Local).AddTicks(7484), new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), true },
                    { 35, new DateTime(2022, 7, 18, 19, 45, 3, 427, DateTimeKind.Local).AddTicks(3164), new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), true },
                    { 36, new DateTime(2022, 7, 18, 13, 45, 22, 792, DateTimeKind.Local).AddTicks(2366), new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), false },
                    { 37, new DateTime(2022, 7, 18, 8, 20, 8, 575, DateTimeKind.Local).AddTicks(692), new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), false },
                    { 38, new DateTime(2022, 7, 18, 23, 9, 51, 973, DateTimeKind.Local).AddTicks(1602), new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), false },
                    { 39, new DateTime(2022, 7, 18, 10, 46, 31, 814, DateTimeKind.Local).AddTicks(6143), new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), true },
                    { 40, new DateTime(2022, 7, 18, 11, 55, 24, 352, DateTimeKind.Local).AddTicks(6565), new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), true },
                    { 41, new DateTime(2022, 7, 18, 20, 20, 47, 911, DateTimeKind.Local).AddTicks(1531), new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), false },
                    { 42, new DateTime(2022, 7, 18, 5, 19, 20, 909, DateTimeKind.Local).AddTicks(2826), new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), true },
                    { 43, new DateTime(2022, 7, 18, 13, 33, 51, 758, DateTimeKind.Local).AddTicks(5641), new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), false },
                    { 44, new DateTime(2022, 7, 18, 5, 47, 18, 413, DateTimeKind.Local).AddTicks(497), new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), true },
                    { 45, new DateTime(2022, 7, 18, 3, 27, 24, 541, DateTimeKind.Local).AddTicks(9452), new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), true },
                    { 46, new DateTime(2022, 7, 18, 20, 1, 56, 658, DateTimeKind.Local).AddTicks(2134), new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), true },
                    { 47, new DateTime(2022, 7, 18, 14, 53, 31, 682, DateTimeKind.Local).AddTicks(3804), new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), false },
                    { 48, new DateTime(2022, 7, 18, 15, 59, 42, 145, DateTimeKind.Local).AddTicks(8336), new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), false },
                    { 49, new DateTime(2022, 7, 18, 20, 27, 43, 394, DateTimeKind.Local).AddTicks(8252), new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), false },
                    { 50, new DateTime(2022, 7, 18, 19, 55, 29, 193, DateTimeKind.Local).AddTicks(9053), new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), true },
                    { 51, new DateTime(2022, 7, 18, 21, 9, 32, 598, DateTimeKind.Local).AddTicks(1170), new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), false },
                    { 52, new DateTime(2022, 7, 18, 12, 13, 48, 752, DateTimeKind.Local).AddTicks(2378), new Guid("179ac0de-306b-47de-abf3-f619ec367085"), false },
                    { 53, new DateTime(2022, 7, 19, 2, 30, 48, 448, DateTimeKind.Local).AddTicks(1217), new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), false },
                    { 54, new DateTime(2022, 7, 18, 10, 1, 20, 414, DateTimeKind.Local).AddTicks(6930), new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), true },
                    { 55, new DateTime(2022, 7, 18, 8, 59, 10, 529, DateTimeKind.Local).AddTicks(2953), new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), false },
                    { 56, new DateTime(2022, 7, 18, 19, 6, 8, 307, DateTimeKind.Local).AddTicks(4034), new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), false },
                    { 57, new DateTime(2022, 7, 19, 2, 29, 6, 360, DateTimeKind.Local).AddTicks(9279), new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), true },
                    { 58, new DateTime(2022, 7, 18, 15, 55, 32, 345, DateTimeKind.Local).AddTicks(8364), new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 59, new DateTime(2022, 7, 18, 14, 57, 3, 466, DateTimeKind.Local).AddTicks(6980), new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), false },
                    { 60, new DateTime(2022, 7, 18, 11, 26, 30, 924, DateTimeKind.Local).AddTicks(6358), new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), true },
                    { 61, new DateTime(2022, 7, 18, 8, 5, 58, 742, DateTimeKind.Local).AddTicks(3079), new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), true },
                    { 62, new DateTime(2022, 7, 19, 1, 8, 2, 971, DateTimeKind.Local).AddTicks(1245), new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), false },
                    { 63, new DateTime(2022, 7, 18, 14, 52, 52, 47, DateTimeKind.Local).AddTicks(9320), new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), true },
                    { 64, new DateTime(2022, 7, 18, 6, 11, 31, 990, DateTimeKind.Local).AddTicks(3169), new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), false },
                    { 65, new DateTime(2022, 7, 18, 5, 13, 5, 369, DateTimeKind.Local).AddTicks(6847), new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), false },
                    { 66, new DateTime(2022, 7, 18, 3, 59, 16, 435, DateTimeKind.Local).AddTicks(9150), new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), false },
                    { 67, new DateTime(2022, 7, 19, 0, 50, 45, 451, DateTimeKind.Local).AddTicks(2721), new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), true },
                    { 68, new DateTime(2022, 7, 19, 0, 52, 37, 629, DateTimeKind.Local).AddTicks(4096), new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), true },
                    { 69, new DateTime(2022, 7, 18, 12, 17, 32, 56, DateTimeKind.Local).AddTicks(6532), new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), false },
                    { 70, new DateTime(2022, 7, 18, 10, 56, 19, 651, DateTimeKind.Local).AddTicks(6393), new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), false },
                    { 71, new DateTime(2022, 7, 18, 12, 30, 23, 563, DateTimeKind.Local).AddTicks(4436), new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), true },
                    { 72, new DateTime(2022, 7, 18, 16, 36, 12, 199, DateTimeKind.Local).AddTicks(343), new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), true },
                    { 73, new DateTime(2022, 7, 18, 20, 4, 39, 456, DateTimeKind.Local).AddTicks(6866), new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), false },
                    { 74, new DateTime(2022, 7, 18, 7, 55, 31, 638, DateTimeKind.Local).AddTicks(6939), new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), true },
                    { 75, new DateTime(2022, 7, 18, 19, 26, 28, 454, DateTimeKind.Local).AddTicks(1690), new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), false },
                    { 76, new DateTime(2022, 7, 18, 9, 2, 48, 821, DateTimeKind.Local).AddTicks(9326), new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), false },
                    { 77, new DateTime(2022, 7, 18, 10, 23, 22, 79, DateTimeKind.Local).AddTicks(8873), new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), false },
                    { 78, new DateTime(2022, 7, 18, 4, 6, 43, 759, DateTimeKind.Local).AddTicks(8467), new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), false },
                    { 79, new DateTime(2022, 7, 18, 6, 22, 27, 500, DateTimeKind.Local).AddTicks(21), new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), false },
                    { 80, new DateTime(2022, 7, 19, 1, 50, 20, 791, DateTimeKind.Local).AddTicks(3512), new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), true },
                    { 81, new DateTime(2022, 7, 18, 20, 33, 11, 205, DateTimeKind.Local).AddTicks(6140), new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), true },
                    { 82, new DateTime(2022, 7, 18, 7, 7, 0, 320, DateTimeKind.Local).AddTicks(3193), new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), true },
                    { 83, new DateTime(2022, 7, 18, 18, 9, 31, 309, DateTimeKind.Local).AddTicks(3380), new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), false },
                    { 84, new DateTime(2022, 7, 18, 18, 25, 22, 631, DateTimeKind.Local).AddTicks(4215), new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), false },
                    { 85, new DateTime(2022, 7, 18, 9, 54, 11, 263, DateTimeKind.Local).AddTicks(2076), new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), false },
                    { 86, new DateTime(2022, 7, 18, 14, 25, 44, 801, DateTimeKind.Local).AddTicks(9862), new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), true },
                    { 87, new DateTime(2022, 7, 18, 18, 50, 46, 662, DateTimeKind.Local).AddTicks(6049), new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), true },
                    { 88, new DateTime(2022, 7, 18, 13, 22, 19, 41, DateTimeKind.Local).AddTicks(6628), new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), false },
                    { 89, new DateTime(2022, 7, 18, 20, 26, 42, 380, DateTimeKind.Local).AddTicks(3256), new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), false },
                    { 90, new DateTime(2022, 7, 18, 10, 35, 43, 801, DateTimeKind.Local).AddTicks(6741), new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), false },
                    { 91, new DateTime(2022, 7, 18, 7, 47, 40, 810, DateTimeKind.Local).AddTicks(4195), new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), false },
                    { 92, new DateTime(2022, 7, 18, 7, 58, 39, 669, DateTimeKind.Local).AddTicks(1768), new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), false },
                    { 93, new DateTime(2022, 7, 18, 6, 53, 4, 585, DateTimeKind.Local).AddTicks(9741), new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), true },
                    { 94, new DateTime(2022, 7, 19, 0, 45, 4, 501, DateTimeKind.Local).AddTicks(8374), new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), true },
                    { 95, new DateTime(2022, 7, 18, 8, 13, 2, 415, DateTimeKind.Local).AddTicks(7235), new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), false },
                    { 96, new DateTime(2022, 7, 18, 10, 48, 51, 326, DateTimeKind.Local).AddTicks(3023), new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), true },
                    { 97, new DateTime(2022, 7, 18, 8, 19, 29, 798, DateTimeKind.Local).AddTicks(128), new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), false },
                    { 98, new DateTime(2022, 7, 18, 7, 10, 30, 719, DateTimeKind.Local).AddTicks(9390), new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), true },
                    { 99, new DateTime(2022, 7, 18, 17, 8, 37, 256, DateTimeKind.Local).AddTicks(7352), new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), true },
                    { 100, new DateTime(2022, 7, 18, 12, 44, 12, 753, DateTimeKind.Local).AddTicks(2424), new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 101, new DateTime(2022, 7, 18, 22, 26, 38, 431, DateTimeKind.Local).AddTicks(5609), new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), true },
                    { 102, new DateTime(2022, 7, 18, 7, 3, 23, 186, DateTimeKind.Local).AddTicks(6945), new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), true },
                    { 103, new DateTime(2022, 7, 19, 2, 25, 57, 270, DateTimeKind.Local).AddTicks(6333), new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), true },
                    { 104, new DateTime(2022, 7, 19, 2, 18, 50, 775, DateTimeKind.Local).AddTicks(6422), new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), false },
                    { 105, new DateTime(2022, 7, 18, 6, 29, 38, 52, DateTimeKind.Local).AddTicks(8831), new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), true },
                    { 106, new DateTime(2022, 7, 18, 3, 59, 28, 917, DateTimeKind.Local).AddTicks(3310), new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), true },
                    { 107, new DateTime(2022, 7, 18, 18, 10, 5, 559, DateTimeKind.Local).AddTicks(1181), new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), true },
                    { 108, new DateTime(2022, 7, 18, 20, 37, 48, 992, DateTimeKind.Local).AddTicks(4862), new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), false },
                    { 109, new DateTime(2022, 7, 18, 14, 5, 15, 802, DateTimeKind.Local).AddTicks(5240), new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), false },
                    { 110, new DateTime(2022, 7, 18, 12, 3, 52, 627, DateTimeKind.Local).AddTicks(4271), new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), false },
                    { 111, new DateTime(2022, 7, 18, 3, 15, 17, 86, DateTimeKind.Local).AddTicks(8795), new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), true },
                    { 112, new DateTime(2022, 7, 18, 20, 51, 52, 991, DateTimeKind.Local).AddTicks(6787), new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), true },
                    { 113, new DateTime(2022, 7, 18, 22, 21, 39, 794, DateTimeKind.Local).AddTicks(727), new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), false },
                    { 114, new DateTime(2022, 7, 18, 11, 30, 30, 107, DateTimeKind.Local).AddTicks(3373), new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), true },
                    { 115, new DateTime(2022, 7, 18, 10, 5, 31, 195, DateTimeKind.Local).AddTicks(5101), new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), false },
                    { 116, new DateTime(2022, 7, 19, 0, 59, 50, 770, DateTimeKind.Local).AddTicks(3496), new Guid("4307075b-d195-449f-b670-e64f49be87ba"), false },
                    { 117, new DateTime(2022, 7, 18, 22, 54, 1, 465, DateTimeKind.Local).AddTicks(4209), new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), false },
                    { 118, new DateTime(2022, 7, 18, 20, 21, 26, 483, DateTimeKind.Local).AddTicks(926), new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), true },
                    { 119, new DateTime(2022, 7, 18, 10, 56, 55, 897, DateTimeKind.Local).AddTicks(3614), new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), true },
                    { 120, new DateTime(2022, 7, 18, 21, 38, 59, 472, DateTimeKind.Local).AddTicks(9134), new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), false },
                    { 121, new DateTime(2022, 7, 18, 8, 59, 6, 374, DateTimeKind.Local).AddTicks(3433), new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), false },
                    { 122, new DateTime(2022, 7, 18, 14, 41, 7, 38, DateTimeKind.Local).AddTicks(6085), new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), false },
                    { 123, new DateTime(2022, 7, 18, 18, 30, 27, 644, DateTimeKind.Local).AddTicks(3531), new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), false },
                    { 124, new DateTime(2022, 7, 18, 20, 41, 37, 642, DateTimeKind.Local).AddTicks(1284), new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), true },
                    { 125, new DateTime(2022, 7, 18, 5, 37, 8, 850, DateTimeKind.Local).AddTicks(8344), new Guid("075ef475-0520-41cc-ab52-178b0221640e"), false },
                    { 126, new DateTime(2022, 7, 19, 1, 10, 37, 512, DateTimeKind.Local).AddTicks(7645), new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), false },
                    { 127, new DateTime(2022, 7, 19, 1, 29, 32, 379, DateTimeKind.Local).AddTicks(4744), new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), true },
                    { 128, new DateTime(2022, 7, 19, 0, 29, 32, 741, DateTimeKind.Local).AddTicks(653), new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), false },
                    { 129, new DateTime(2022, 7, 18, 5, 5, 33, 140, DateTimeKind.Local).AddTicks(9661), new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), false },
                    { 130, new DateTime(2022, 7, 18, 20, 33, 41, 803, DateTimeKind.Local).AddTicks(6624), new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), true },
                    { 131, new DateTime(2022, 7, 19, 2, 28, 38, 332, DateTimeKind.Local).AddTicks(3014), new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), true },
                    { 132, new DateTime(2022, 7, 19, 0, 34, 49, 958, DateTimeKind.Local).AddTicks(324), new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), true },
                    { 133, new DateTime(2022, 7, 19, 0, 2, 5, 80, DateTimeKind.Local).AddTicks(5660), new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), false },
                    { 134, new DateTime(2022, 7, 18, 16, 4, 52, 139, DateTimeKind.Local).AddTicks(9789), new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), true },
                    { 135, new DateTime(2022, 7, 19, 2, 11, 18, 185, DateTimeKind.Local).AddTicks(6388), new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), true },
                    { 136, new DateTime(2022, 7, 18, 9, 41, 52, 656, DateTimeKind.Local).AddTicks(1598), new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), true },
                    { 137, new DateTime(2022, 7, 19, 2, 1, 48, 267, DateTimeKind.Local).AddTicks(4600), new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), true },
                    { 138, new DateTime(2022, 7, 18, 5, 8, 40, 783, DateTimeKind.Local).AddTicks(1351), new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), true },
                    { 139, new DateTime(2022, 7, 18, 21, 17, 7, 337, DateTimeKind.Local).AddTicks(3837), new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), false },
                    { 140, new DateTime(2022, 7, 18, 5, 43, 51, 176, DateTimeKind.Local).AddTicks(5389), new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), true },
                    { 141, new DateTime(2022, 7, 19, 1, 35, 38, 697, DateTimeKind.Local).AddTicks(2354), new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), false },
                    { 142, new DateTime(2022, 7, 18, 8, 55, 1, 274, DateTimeKind.Local).AddTicks(7943), new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 143, new DateTime(2022, 7, 19, 0, 9, 56, 858, DateTimeKind.Local).AddTicks(5066), new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), false },
                    { 144, new DateTime(2022, 7, 18, 21, 15, 51, 791, DateTimeKind.Local).AddTicks(43), new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), false },
                    { 145, new DateTime(2022, 7, 18, 8, 15, 42, 914, DateTimeKind.Local).AddTicks(2468), new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), true },
                    { 146, new DateTime(2022, 7, 18, 10, 9, 1, 491, DateTimeKind.Local).AddTicks(8546), new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), true },
                    { 147, new DateTime(2022, 7, 18, 9, 40, 54, 275, DateTimeKind.Local).AddTicks(3008), new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), true },
                    { 148, new DateTime(2022, 7, 18, 22, 45, 53, 416, DateTimeKind.Local).AddTicks(4349), new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), true },
                    { 149, new DateTime(2022, 7, 18, 17, 7, 35, 458, DateTimeKind.Local).AddTicks(4075), new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), false },
                    { 150, new DateTime(2022, 7, 18, 21, 49, 24, 390, DateTimeKind.Local).AddTicks(1178), new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), true },
                    { 151, new DateTime(2022, 7, 18, 17, 30, 27, 723, DateTimeKind.Local).AddTicks(7690), new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), true },
                    { 152, new DateTime(2022, 7, 18, 5, 8, 15, 804, DateTimeKind.Local).AddTicks(1651), new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), true },
                    { 153, new DateTime(2022, 7, 18, 20, 25, 0, 797, DateTimeKind.Local).AddTicks(8092), new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), false },
                    { 154, new DateTime(2022, 7, 19, 2, 11, 35, 595, DateTimeKind.Local).AddTicks(3002), new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), false },
                    { 155, new DateTime(2022, 7, 18, 18, 9, 26, 993, DateTimeKind.Local).AddTicks(8463), new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), false },
                    { 156, new DateTime(2022, 7, 18, 3, 37, 44, 594, DateTimeKind.Local).AddTicks(1119), new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), false },
                    { 157, new DateTime(2022, 7, 18, 20, 20, 27, 829, DateTimeKind.Local).AddTicks(6879), new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), false },
                    { 158, new DateTime(2022, 7, 18, 19, 18, 33, 205, DateTimeKind.Local).AddTicks(3896), new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), false },
                    { 159, new DateTime(2022, 7, 18, 5, 49, 2, 998, DateTimeKind.Local).AddTicks(8188), new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), false },
                    { 160, new DateTime(2022, 7, 18, 7, 36, 36, 747, DateTimeKind.Local).AddTicks(9557), new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), false },
                    { 161, new DateTime(2022, 7, 18, 14, 18, 59, 276, DateTimeKind.Local).AddTicks(4949), new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), true },
                    { 162, new DateTime(2022, 7, 19, 0, 7, 8, 373, DateTimeKind.Local).AddTicks(3714), new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), true },
                    { 163, new DateTime(2022, 7, 18, 8, 31, 30, 947, DateTimeKind.Local).AddTicks(1147), new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), false },
                    { 164, new DateTime(2022, 7, 18, 22, 28, 21, 523, DateTimeKind.Local).AddTicks(9676), new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), false },
                    { 165, new DateTime(2022, 7, 18, 8, 35, 35, 786, DateTimeKind.Local).AddTicks(4359), new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), false },
                    { 166, new DateTime(2022, 7, 18, 3, 21, 49, 123, DateTimeKind.Local).AddTicks(1861), new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), false },
                    { 167, new DateTime(2022, 7, 19, 0, 4, 26, 541, DateTimeKind.Local).AddTicks(5040), new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), false },
                    { 168, new DateTime(2022, 7, 18, 6, 14, 59, 513, DateTimeKind.Local).AddTicks(4714), new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), false },
                    { 169, new DateTime(2022, 7, 18, 6, 53, 17, 514, DateTimeKind.Local).AddTicks(6976), new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), true },
                    { 170, new DateTime(2022, 7, 18, 13, 21, 24, 12, DateTimeKind.Local).AddTicks(9988), new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), false },
                    { 171, new DateTime(2022, 7, 18, 11, 24, 15, 433, DateTimeKind.Local).AddTicks(1710), new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), true },
                    { 172, new DateTime(2022, 7, 19, 1, 54, 58, 924, DateTimeKind.Local).AddTicks(7514), new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), true },
                    { 173, new DateTime(2022, 7, 18, 14, 19, 31, 195, DateTimeKind.Local).AddTicks(1470), new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), true },
                    { 174, new DateTime(2022, 7, 18, 15, 25, 34, 780, DateTimeKind.Local).AddTicks(9406), new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), true },
                    { 175, new DateTime(2022, 7, 18, 16, 58, 13, 713, DateTimeKind.Local).AddTicks(6481), new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), true },
                    { 176, new DateTime(2022, 7, 18, 14, 32, 30, 55, DateTimeKind.Local).AddTicks(2594), new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), true },
                    { 177, new DateTime(2022, 7, 18, 7, 22, 54, 659, DateTimeKind.Local).AddTicks(1588), new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), true },
                    { 178, new DateTime(2022, 7, 18, 8, 34, 36, 778, DateTimeKind.Local).AddTicks(9923), new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), false },
                    { 179, new DateTime(2022, 7, 18, 5, 29, 0, 698, DateTimeKind.Local).AddTicks(540), new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), true },
                    { 180, new DateTime(2022, 7, 18, 10, 37, 5, 104, DateTimeKind.Local).AddTicks(5491), new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), true },
                    { 181, new DateTime(2022, 7, 18, 7, 23, 3, 742, DateTimeKind.Local).AddTicks(6988), new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), false },
                    { 182, new DateTime(2022, 7, 18, 4, 23, 46, 730, DateTimeKind.Local).AddTicks(9991), new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), false },
                    { 183, new DateTime(2022, 7, 18, 8, 10, 39, 127, DateTimeKind.Local).AddTicks(1734), new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"), false },
                    { 184, new DateTime(2022, 7, 18, 12, 27, 42, 440, DateTimeKind.Local).AddTicks(8781), new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 185, new DateTime(2022, 7, 18, 21, 23, 3, 292, DateTimeKind.Local).AddTicks(5651), new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), false },
                    { 186, new DateTime(2022, 7, 18, 11, 3, 39, 688, DateTimeKind.Local).AddTicks(6171), new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), false },
                    { 187, new DateTime(2022, 7, 18, 22, 59, 2, 177, DateTimeKind.Local).AddTicks(2095), new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), false },
                    { 188, new DateTime(2022, 7, 18, 13, 23, 29, 676, DateTimeKind.Local).AddTicks(3021), new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), true },
                    { 189, new DateTime(2022, 7, 19, 0, 3, 45, 152, DateTimeKind.Local).AddTicks(156), new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), true },
                    { 190, new DateTime(2022, 7, 18, 23, 5, 14, 690, DateTimeKind.Local).AddTicks(1790), new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), true },
                    { 191, new DateTime(2022, 7, 18, 12, 19, 34, 431, DateTimeKind.Local).AddTicks(9133), new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), true },
                    { 192, new DateTime(2022, 7, 18, 9, 45, 47, 129, DateTimeKind.Local).AddTicks(2989), new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), true },
                    { 193, new DateTime(2022, 7, 18, 4, 44, 23, 206, DateTimeKind.Local).AddTicks(9758), new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), false },
                    { 194, new DateTime(2022, 7, 18, 8, 5, 57, 843, DateTimeKind.Local).AddTicks(4028), new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), true },
                    { 195, new DateTime(2022, 7, 18, 20, 54, 30, 288, DateTimeKind.Local).AddTicks(5535), new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), false },
                    { 196, new DateTime(2022, 7, 18, 5, 56, 38, 53, DateTimeKind.Local).AddTicks(9871), new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), true },
                    { 197, new DateTime(2022, 7, 18, 4, 2, 51, 653, DateTimeKind.Local).AddTicks(2952), new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), false },
                    { 198, new DateTime(2022, 7, 18, 16, 4, 21, 512, DateTimeKind.Local).AddTicks(9510), new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), false },
                    { 199, new DateTime(2022, 7, 18, 7, 26, 23, 108, DateTimeKind.Local).AddTicks(2835), new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), false },
                    { 200, new DateTime(2022, 7, 18, 14, 33, 4, 641, DateTimeKind.Local).AddTicks(7401), new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), true },
                    { 201, new DateTime(2022, 7, 19, 0, 12, 23, 38, DateTimeKind.Local).AddTicks(1145), new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), true },
                    { 202, new DateTime(2022, 7, 18, 15, 53, 47, 393, DateTimeKind.Local).AddTicks(7858), new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"), false },
                    { 203, new DateTime(2022, 7, 18, 3, 49, 7, 920, DateTimeKind.Local).AddTicks(5418), new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), true },
                    { 204, new DateTime(2022, 7, 19, 2, 23, 4, 980, DateTimeKind.Local).AddTicks(8269), new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), false },
                    { 205, new DateTime(2022, 7, 18, 23, 36, 4, 51, DateTimeKind.Local).AddTicks(8001), new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), false },
                    { 206, new DateTime(2022, 7, 18, 16, 50, 57, 314, DateTimeKind.Local).AddTicks(6815), new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), true },
                    { 207, new DateTime(2022, 7, 18, 7, 33, 5, 637, DateTimeKind.Local).AddTicks(3412), new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), true },
                    { 208, new DateTime(2022, 7, 18, 6, 18, 50, 550, DateTimeKind.Local).AddTicks(97), new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), false },
                    { 209, new DateTime(2022, 7, 18, 20, 47, 44, 579, DateTimeKind.Local).AddTicks(8582), new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), false },
                    { 210, new DateTime(2022, 7, 18, 12, 42, 20, 995, DateTimeKind.Local).AddTicks(9546), new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), true },
                    { 211, new DateTime(2022, 7, 18, 17, 33, 43, 134, DateTimeKind.Local).AddTicks(6741), new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), true },
                    { 212, new DateTime(2022, 7, 18, 7, 42, 49, 292, DateTimeKind.Local).AddTicks(9394), new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), true },
                    { 213, new DateTime(2022, 7, 18, 14, 54, 31, 617, DateTimeKind.Local).AddTicks(5946), new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), true },
                    { 214, new DateTime(2022, 7, 18, 9, 44, 21, 8, DateTimeKind.Local).AddTicks(6493), new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), true },
                    { 215, new DateTime(2022, 7, 18, 19, 23, 10, 759, DateTimeKind.Local).AddTicks(7214), new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), true },
                    { 216, new DateTime(2022, 7, 18, 22, 2, 40, 689, DateTimeKind.Local).AddTicks(3811), new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), false },
                    { 217, new DateTime(2022, 7, 18, 22, 22, 32, 258, DateTimeKind.Local).AddTicks(7415), new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), true },
                    { 218, new DateTime(2022, 7, 18, 3, 4, 58, 675, DateTimeKind.Local).AddTicks(9145), new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), true },
                    { 219, new DateTime(2022, 7, 18, 15, 25, 13, 402, DateTimeKind.Local).AddTicks(6099), new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), false },
                    { 220, new DateTime(2022, 7, 18, 9, 31, 0, 518, DateTimeKind.Local).AddTicks(8455), new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), false },
                    { 221, new DateTime(2022, 7, 18, 10, 7, 54, 331, DateTimeKind.Local).AddTicks(3045), new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), true },
                    { 222, new DateTime(2022, 7, 19, 1, 5, 6, 532, DateTimeKind.Local).AddTicks(3877), new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), false },
                    { 223, new DateTime(2022, 7, 18, 17, 40, 22, 327, DateTimeKind.Local).AddTicks(7882), new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), false },
                    { 224, new DateTime(2022, 7, 18, 18, 0, 3, 746, DateTimeKind.Local).AddTicks(2463), new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), true },
                    { 225, new DateTime(2022, 7, 18, 11, 36, 32, 261, DateTimeKind.Local).AddTicks(8792), new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), true },
                    { 226, new DateTime(2022, 7, 19, 0, 6, 6, 442, DateTimeKind.Local).AddTicks(7200), new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 227, new DateTime(2022, 7, 19, 0, 2, 41, 731, DateTimeKind.Local).AddTicks(7411), new Guid("179ac0de-306b-47de-abf3-f619ec367085"), false },
                    { 228, new DateTime(2022, 7, 19, 0, 49, 54, 591, DateTimeKind.Local).AddTicks(8627), new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), true },
                    { 229, new DateTime(2022, 7, 18, 20, 41, 10, 3, DateTimeKind.Local).AddTicks(6971), new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), false },
                    { 230, new DateTime(2022, 7, 18, 6, 10, 17, 530, DateTimeKind.Local).AddTicks(9161), new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), true },
                    { 231, new DateTime(2022, 7, 18, 5, 4, 10, 895, DateTimeKind.Local).AddTicks(8822), new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), true },
                    { 232, new DateTime(2022, 7, 18, 9, 29, 9, 187, DateTimeKind.Local).AddTicks(8078), new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), false },
                    { 233, new DateTime(2022, 7, 18, 19, 37, 16, 247, DateTimeKind.Local).AddTicks(3814), new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), true },
                    { 234, new DateTime(2022, 7, 18, 21, 3, 31, 159, DateTimeKind.Local).AddTicks(4447), new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"), true },
                    { 235, new DateTime(2022, 7, 18, 20, 17, 51, 647, DateTimeKind.Local).AddTicks(7222), new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), true },
                    { 236, new DateTime(2022, 7, 19, 0, 47, 55, 35, DateTimeKind.Local).AddTicks(1744), new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), true },
                    { 237, new DateTime(2022, 7, 18, 17, 6, 44, 511, DateTimeKind.Local).AddTicks(7917), new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), true },
                    { 238, new DateTime(2022, 7, 18, 21, 2, 26, 260, DateTimeKind.Local).AddTicks(9876), new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), false },
                    { 239, new DateTime(2022, 7, 18, 17, 53, 26, 626, DateTimeKind.Local).AddTicks(3755), new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), false },
                    { 240, new DateTime(2022, 7, 18, 6, 46, 46, 124, DateTimeKind.Local).AddTicks(1104), new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), false },
                    { 241, new DateTime(2022, 7, 18, 5, 4, 7, 586, DateTimeKind.Local).AddTicks(882), new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), false },
                    { 242, new DateTime(2022, 7, 18, 18, 43, 16, 321, DateTimeKind.Local).AddTicks(1073), new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), true },
                    { 243, new DateTime(2022, 7, 19, 1, 13, 18, 521, DateTimeKind.Local).AddTicks(9320), new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), false },
                    { 244, new DateTime(2022, 7, 18, 8, 2, 1, 15, DateTimeKind.Local).AddTicks(1785), new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), true },
                    { 245, new DateTime(2022, 7, 19, 1, 59, 55, 822, DateTimeKind.Local).AddTicks(7086), new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), true },
                    { 246, new DateTime(2022, 7, 18, 21, 20, 53, 887, DateTimeKind.Local).AddTicks(756), new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), true },
                    { 247, new DateTime(2022, 7, 18, 3, 49, 13, 797, DateTimeKind.Local).AddTicks(2627), new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), true },
                    { 248, new DateTime(2022, 7, 18, 16, 3, 36, 443, DateTimeKind.Local).AddTicks(6720), new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), true },
                    { 249, new DateTime(2022, 7, 18, 23, 11, 58, 838, DateTimeKind.Local).AddTicks(5711), new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), true },
                    { 250, new DateTime(2022, 7, 18, 9, 50, 0, 746, DateTimeKind.Local).AddTicks(4346), new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), true },
                    { 251, new DateTime(2022, 7, 18, 13, 25, 39, 472, DateTimeKind.Local).AddTicks(5207), new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), false },
                    { 252, new DateTime(2022, 7, 18, 19, 11, 22, 333, DateTimeKind.Local).AddTicks(7459), new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), false },
                    { 253, new DateTime(2022, 7, 18, 17, 52, 37, 283, DateTimeKind.Local).AddTicks(1079), new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), false },
                    { 254, new DateTime(2022, 7, 18, 10, 29, 47, 302, DateTimeKind.Local).AddTicks(3178), new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), true },
                    { 255, new DateTime(2022, 7, 18, 20, 43, 33, 72, DateTimeKind.Local).AddTicks(1407), new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"), true },
                    { 256, new DateTime(2022, 7, 18, 19, 21, 3, 992, DateTimeKind.Local).AddTicks(1892), new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), false },
                    { 257, new DateTime(2022, 7, 18, 19, 18, 0, 222, DateTimeKind.Local).AddTicks(4018), new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), true },
                    { 258, new DateTime(2022, 7, 18, 18, 41, 13, 635, DateTimeKind.Local).AddTicks(4024), new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), false },
                    { 259, new DateTime(2022, 7, 18, 9, 13, 4, 101, DateTimeKind.Local).AddTicks(5019), new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), false },
                    { 260, new DateTime(2022, 7, 18, 14, 24, 29, 72, DateTimeKind.Local).AddTicks(6289), new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), true },
                    { 261, new DateTime(2022, 7, 18, 22, 58, 24, 477, DateTimeKind.Local).AddTicks(828), new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), false },
                    { 262, new DateTime(2022, 7, 18, 10, 24, 34, 878, DateTimeKind.Local).AddTicks(4060), new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), true },
                    { 263, new DateTime(2022, 7, 18, 9, 24, 53, 986, DateTimeKind.Local).AddTicks(6864), new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), false },
                    { 264, new DateTime(2022, 7, 18, 18, 19, 59, 947, DateTimeKind.Local).AddTicks(7666), new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), false },
                    { 265, new DateTime(2022, 7, 18, 16, 0, 32, 853, DateTimeKind.Local).AddTicks(3761), new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), false },
                    { 266, new DateTime(2022, 7, 18, 12, 43, 5, 830, DateTimeKind.Local).AddTicks(8947), new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"), true },
                    { 267, new DateTime(2022, 7, 18, 17, 16, 37, 653, DateTimeKind.Local).AddTicks(9688), new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"), true },
                    { 268, new DateTime(2022, 7, 18, 6, 56, 54, 86, DateTimeKind.Local).AddTicks(1199), new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 269, new DateTime(2022, 7, 18, 15, 47, 14, 450, DateTimeKind.Local).AddTicks(1860), new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), true },
                    { 270, new DateTime(2022, 7, 18, 16, 49, 48, 481, DateTimeKind.Local).AddTicks(2530), new Guid("179ac0de-306b-47de-abf3-f619ec367085"), false },
                    { 271, new DateTime(2022, 7, 18, 4, 36, 2, 53, DateTimeKind.Local).AddTicks(7529), new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), true },
                    { 272, new DateTime(2022, 7, 18, 4, 57, 58, 377, DateTimeKind.Local).AddTicks(5183), new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), false },
                    { 273, new DateTime(2022, 7, 18, 5, 17, 27, 579, DateTimeKind.Local).AddTicks(6655), new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), false },
                    { 274, new DateTime(2022, 7, 18, 6, 39, 2, 755, DateTimeKind.Local).AddTicks(6335), new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), false },
                    { 275, new DateTime(2022, 7, 18, 8, 2, 29, 727, DateTimeKind.Local).AddTicks(8458), new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), false },
                    { 276, new DateTime(2022, 7, 18, 22, 59, 0, 872, DateTimeKind.Local).AddTicks(4723), new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), true },
                    { 277, new DateTime(2022, 7, 18, 16, 19, 58, 132, DateTimeKind.Local).AddTicks(1378), new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), false },
                    { 278, new DateTime(2022, 7, 19, 0, 49, 22, 373, DateTimeKind.Local).AddTicks(3359), new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), false },
                    { 279, new DateTime(2022, 7, 18, 13, 26, 21, 590, DateTimeKind.Local).AddTicks(591), new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), false },
                    { 280, new DateTime(2022, 7, 18, 15, 33, 5, 99, DateTimeKind.Local).AddTicks(9458), new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), false },
                    { 281, new DateTime(2022, 7, 18, 10, 2, 9, 174, DateTimeKind.Local).AddTicks(273), new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), false },
                    { 282, new DateTime(2022, 7, 18, 14, 47, 52, 535, DateTimeKind.Local).AddTicks(7503), new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), false },
                    { 283, new DateTime(2022, 7, 18, 13, 48, 6, 577, DateTimeKind.Local).AddTicks(6749), new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), false },
                    { 284, new DateTime(2022, 7, 18, 21, 37, 19, 119, DateTimeKind.Local).AddTicks(1101), new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), true },
                    { 285, new DateTime(2022, 7, 18, 17, 35, 13, 377, DateTimeKind.Local).AddTicks(5102), new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), true },
                    { 286, new DateTime(2022, 7, 18, 23, 39, 48, 787, DateTimeKind.Local).AddTicks(7323), new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), false },
                    { 287, new DateTime(2022, 7, 18, 11, 7, 48, 528, DateTimeKind.Local).AddTicks(586), new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"), false },
                    { 288, new DateTime(2022, 7, 18, 11, 39, 0, 972, DateTimeKind.Local).AddTicks(509), new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), true },
                    { 289, new DateTime(2022, 7, 18, 4, 40, 31, 411, DateTimeKind.Local).AddTicks(4397), new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), false },
                    { 290, new DateTime(2022, 7, 18, 12, 23, 50, 52, DateTimeKind.Local).AddTicks(6080), new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), true },
                    { 291, new DateTime(2022, 7, 18, 3, 48, 20, 36, DateTimeKind.Local).AddTicks(284), new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), false },
                    { 292, new DateTime(2022, 7, 18, 8, 5, 50, 202, DateTimeKind.Local).AddTicks(7752), new Guid("075ef475-0520-41cc-ab52-178b0221640e"), true },
                    { 293, new DateTime(2022, 7, 18, 20, 20, 34, 766, DateTimeKind.Local).AddTicks(6854), new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), false },
                    { 294, new DateTime(2022, 7, 18, 11, 15, 20, 881, DateTimeKind.Local).AddTicks(9047), new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), true },
                    { 295, new DateTime(2022, 7, 18, 12, 4, 10, 406, DateTimeKind.Local).AddTicks(8790), new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), true },
                    { 296, new DateTime(2022, 7, 18, 11, 40, 14, 534, DateTimeKind.Local).AddTicks(4436), new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), false },
                    { 297, new DateTime(2022, 7, 18, 14, 4, 14, 651, DateTimeKind.Local).AddTicks(9008), new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), true },
                    { 298, new DateTime(2022, 7, 18, 6, 44, 19, 974, DateTimeKind.Local).AddTicks(408), new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), true },
                    { 299, new DateTime(2022, 7, 18, 3, 59, 25, 616, DateTimeKind.Local).AddTicks(2601), new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), false },
                    { 300, new DateTime(2022, 7, 18, 6, 58, 49, 761, DateTimeKind.Local).AddTicks(358), new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), false },
                    { 301, new DateTime(2022, 7, 18, 22, 57, 40, 934, DateTimeKind.Local).AddTicks(4919), new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"), true },
                    { 302, new DateTime(2022, 7, 18, 20, 59, 46, 472, DateTimeKind.Local).AddTicks(8191), new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), true },
                    { 303, new DateTime(2022, 7, 18, 16, 34, 5, 956, DateTimeKind.Local).AddTicks(7479), new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), true },
                    { 304, new DateTime(2022, 7, 18, 17, 28, 50, 345, DateTimeKind.Local).AddTicks(5745), new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"), false },
                    { 305, new DateTime(2022, 7, 18, 7, 15, 37, 351, DateTimeKind.Local).AddTicks(6135), new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), true },
                    { 306, new DateTime(2022, 7, 18, 2, 38, 38, 699, DateTimeKind.Local).AddTicks(8039), new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"), true },
                    { 307, new DateTime(2022, 7, 18, 7, 40, 46, 503, DateTimeKind.Local).AddTicks(8918), new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), true },
                    { 308, new DateTime(2022, 7, 19, 2, 20, 21, 106, DateTimeKind.Local).AddTicks(5105), new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), true },
                    { 309, new DateTime(2022, 7, 19, 0, 55, 25, 304, DateTimeKind.Local).AddTicks(2121), new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), true },
                    { 310, new DateTime(2022, 7, 19, 0, 29, 48, 131, DateTimeKind.Local).AddTicks(4149), new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 311, new DateTime(2022, 7, 18, 11, 20, 42, 221, DateTimeKind.Local).AddTicks(395), new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), true },
                    { 312, new DateTime(2022, 7, 18, 4, 57, 29, 99, DateTimeKind.Local).AddTicks(6952), new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), true },
                    { 313, new DateTime(2022, 7, 18, 10, 1, 41, 691, DateTimeKind.Local).AddTicks(919), new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), false },
                    { 314, new DateTime(2022, 7, 19, 0, 0, 16, 935, DateTimeKind.Local).AddTicks(9094), new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), false },
                    { 315, new DateTime(2022, 7, 18, 18, 7, 10, 678, DateTimeKind.Local).AddTicks(7045), new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), false },
                    { 316, new DateTime(2022, 7, 18, 4, 37, 20, 517, DateTimeKind.Local).AddTicks(8584), new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), true },
                    { 317, new DateTime(2022, 7, 18, 17, 3, 21, 445, DateTimeKind.Local).AddTicks(9054), new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), true },
                    { 318, new DateTime(2022, 7, 18, 14, 8, 29, 413, DateTimeKind.Local).AddTicks(1889), new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), true },
                    { 319, new DateTime(2022, 7, 18, 23, 30, 36, 217, DateTimeKind.Local).AddTicks(6817), new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"), true },
                    { 320, new DateTime(2022, 7, 18, 16, 38, 54, 665, DateTimeKind.Local).AddTicks(7095), new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), true },
                    { 321, new DateTime(2022, 7, 18, 8, 38, 11, 708, DateTimeKind.Local).AddTicks(7805), new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), false },
                    { 322, new DateTime(2022, 7, 18, 18, 43, 16, 865, DateTimeKind.Local).AddTicks(9330), new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), false },
                    { 323, new DateTime(2022, 7, 19, 1, 40, 48, 981, DateTimeKind.Local).AddTicks(524), new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), true },
                    { 324, new DateTime(2022, 7, 18, 6, 45, 41, 702, DateTimeKind.Local).AddTicks(2402), new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), false },
                    { 325, new DateTime(2022, 7, 18, 20, 44, 51, 707, DateTimeKind.Local).AddTicks(9687), new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), true },
                    { 326, new DateTime(2022, 7, 18, 12, 27, 12, 365, DateTimeKind.Local).AddTicks(6464), new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), false },
                    { 327, new DateTime(2022, 7, 18, 5, 33, 54, 578, DateTimeKind.Local).AddTicks(901), new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), false },
                    { 328, new DateTime(2022, 7, 18, 11, 43, 44, 952, DateTimeKind.Local).AddTicks(7620), new Guid("9840b515-74f0-4af0-b950-92055db7fa99"), false },
                    { 329, new DateTime(2022, 7, 18, 20, 13, 17, 144, DateTimeKind.Local).AddTicks(8041), new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), false },
                    { 330, new DateTime(2022, 7, 18, 9, 27, 20, 788, DateTimeKind.Local).AddTicks(8636), new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), false },
                    { 331, new DateTime(2022, 7, 18, 3, 46, 41, 361, DateTimeKind.Local).AddTicks(9496), new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), false },
                    { 332, new DateTime(2022, 7, 18, 5, 14, 42, 163, DateTimeKind.Local).AddTicks(6178), new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"), false },
                    { 333, new DateTime(2022, 7, 18, 8, 32, 30, 212, DateTimeKind.Local).AddTicks(6501), new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), true },
                    { 334, new DateTime(2022, 7, 18, 14, 44, 29, 94, DateTimeKind.Local).AddTicks(25), new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), false },
                    { 335, new DateTime(2022, 7, 19, 0, 9, 6, 392, DateTimeKind.Local).AddTicks(2626), new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), false },
                    { 336, new DateTime(2022, 7, 18, 8, 47, 1, 272, DateTimeKind.Local).AddTicks(7094), new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), true },
                    { 337, new DateTime(2022, 7, 18, 22, 43, 15, 580, DateTimeKind.Local).AddTicks(5379), new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), false },
                    { 338, new DateTime(2022, 7, 18, 3, 53, 28, 310, DateTimeKind.Local).AddTicks(3295), new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"), false },
                    { 339, new DateTime(2022, 7, 18, 17, 25, 56, 491, DateTimeKind.Local).AddTicks(2740), new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"), false },
                    { 340, new DateTime(2022, 7, 18, 16, 2, 13, 950, DateTimeKind.Local).AddTicks(3073), new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"), false },
                    { 341, new DateTime(2022, 7, 19, 1, 41, 54, 164, DateTimeKind.Local).AddTicks(1766), new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), true },
                    { 342, new DateTime(2022, 7, 18, 9, 18, 21, 14, DateTimeKind.Local).AddTicks(8758), new Guid("4307075b-d195-449f-b670-e64f49be87ba"), true },
                    { 343, new DateTime(2022, 7, 19, 2, 10, 21, 167, DateTimeKind.Local).AddTicks(1217), new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), true },
                    { 344, new DateTime(2022, 7, 19, 0, 13, 13, 880, DateTimeKind.Local).AddTicks(4833), new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"), false },
                    { 345, new DateTime(2022, 7, 18, 6, 8, 13, 395, DateTimeKind.Local).AddTicks(5512), new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), true },
                    { 346, new DateTime(2022, 7, 19, 0, 43, 4, 262, DateTimeKind.Local).AddTicks(2599), new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"), false },
                    { 347, new DateTime(2022, 7, 18, 16, 54, 22, 773, DateTimeKind.Local).AddTicks(2782), new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), false },
                    { 348, new DateTime(2022, 7, 18, 19, 21, 46, 228, DateTimeKind.Local).AddTicks(2546), new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), false },
                    { 349, new DateTime(2022, 7, 18, 15, 54, 55, 998, DateTimeKind.Local).AddTicks(3805), new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), true },
                    { 350, new DateTime(2022, 7, 18, 4, 4, 37, 702, DateTimeKind.Local).AddTicks(7609), new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), false },
                    { 351, new DateTime(2022, 7, 18, 15, 10, 57, 933, DateTimeKind.Local).AddTicks(4706), new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), false },
                    { 352, new DateTime(2022, 7, 18, 5, 5, 54, 653, DateTimeKind.Local).AddTicks(4891), new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 353, new DateTime(2022, 7, 19, 2, 11, 19, 309, DateTimeKind.Local).AddTicks(3045), new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), false },
                    { 354, new DateTime(2022, 7, 18, 19, 1, 21, 236, DateTimeKind.Local).AddTicks(1880), new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), true },
                    { 355, new DateTime(2022, 7, 18, 14, 37, 12, 788, DateTimeKind.Local).AddTicks(5015), new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), false },
                    { 356, new DateTime(2022, 7, 18, 17, 30, 40, 840, DateTimeKind.Local).AddTicks(8641), new Guid("4307075b-d195-449f-b670-e64f49be87ba"), false },
                    { 357, new DateTime(2022, 7, 19, 0, 28, 18, 961, DateTimeKind.Local).AddTicks(5845), new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), false },
                    { 358, new DateTime(2022, 7, 18, 9, 53, 39, 593, DateTimeKind.Local).AddTicks(3894), new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"), false },
                    { 359, new DateTime(2022, 7, 18, 2, 57, 7, 738, DateTimeKind.Local).AddTicks(9813), new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), false },
                    { 360, new DateTime(2022, 7, 18, 17, 46, 17, 179, DateTimeKind.Local).AddTicks(924), new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), true },
                    { 361, new DateTime(2022, 7, 18, 14, 46, 7, 214, DateTimeKind.Local).AddTicks(7353), new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), true },
                    { 362, new DateTime(2022, 7, 18, 9, 37, 2, 344, DateTimeKind.Local).AddTicks(5154), new Guid("075ef475-0520-41cc-ab52-178b0221640e"), true },
                    { 363, new DateTime(2022, 7, 19, 0, 56, 59, 312, DateTimeKind.Local).AddTicks(4584), new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"), true },
                    { 364, new DateTime(2022, 7, 18, 19, 26, 40, 56, DateTimeKind.Local).AddTicks(9526), new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), true },
                    { 365, new DateTime(2022, 7, 19, 2, 14, 48, 892, DateTimeKind.Local).AddTicks(2389), new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), false },
                    { 366, new DateTime(2022, 7, 19, 2, 22, 20, 721, DateTimeKind.Local).AddTicks(7816), new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), true },
                    { 367, new DateTime(2022, 7, 18, 7, 22, 1, 597, DateTimeKind.Local).AddTicks(5681), new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), true },
                    { 368, new DateTime(2022, 7, 18, 23, 28, 48, 858, DateTimeKind.Local).AddTicks(7257), new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), false },
                    { 369, new DateTime(2022, 7, 18, 22, 54, 8, 477, DateTimeKind.Local).AddTicks(4844), new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"), true },
                    { 370, new DateTime(2022, 7, 18, 15, 36, 45, 783, DateTimeKind.Local).AddTicks(5459), new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), false },
                    { 371, new DateTime(2022, 7, 19, 2, 17, 20, 819, DateTimeKind.Local).AddTicks(278), new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), false },
                    { 372, new DateTime(2022, 7, 18, 23, 23, 15, 782, DateTimeKind.Local).AddTicks(5777), new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"), false },
                    { 373, new DateTime(2022, 7, 18, 15, 54, 10, 333, DateTimeKind.Local).AddTicks(551), new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"), false },
                    { 374, new DateTime(2022, 7, 18, 20, 23, 24, 334, DateTimeKind.Local).AddTicks(2425), new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), true },
                    { 375, new DateTime(2022, 7, 18, 8, 55, 28, 541, DateTimeKind.Local).AddTicks(3238), new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), false },
                    { 376, new DateTime(2022, 7, 18, 11, 44, 11, 557, DateTimeKind.Local).AddTicks(1983), new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), false },
                    { 377, new DateTime(2022, 7, 18, 8, 6, 52, 212, DateTimeKind.Local).AddTicks(9572), new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), true },
                    { 378, new DateTime(2022, 7, 18, 20, 33, 51, 433, DateTimeKind.Local).AddTicks(4490), new Guid("221f5506-2d87-429e-a621-c042bdbe369c"), true },
                    { 379, new DateTime(2022, 7, 18, 9, 27, 50, 123, DateTimeKind.Local).AddTicks(8965), new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), true },
                    { 380, new DateTime(2022, 7, 18, 14, 19, 55, 202, DateTimeKind.Local).AddTicks(4381), new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), true },
                    { 381, new DateTime(2022, 7, 18, 17, 13, 24, 451, DateTimeKind.Local).AddTicks(955), new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), true },
                    { 382, new DateTime(2022, 7, 18, 21, 18, 31, 580, DateTimeKind.Local).AddTicks(7439), new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), true },
                    { 383, new DateTime(2022, 7, 18, 12, 0, 43, 227, DateTimeKind.Local).AddTicks(2575), new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), true },
                    { 384, new DateTime(2022, 7, 18, 10, 16, 57, 383, DateTimeKind.Local).AddTicks(6473), new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"), true },
                    { 385, new DateTime(2022, 7, 18, 2, 56, 43, 717, DateTimeKind.Local).AddTicks(5658), new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), false },
                    { 386, new DateTime(2022, 7, 18, 12, 51, 21, 742, DateTimeKind.Local).AddTicks(6219), new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), false },
                    { 387, new DateTime(2022, 7, 18, 12, 6, 59, 849, DateTimeKind.Local).AddTicks(3815), new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), false },
                    { 388, new DateTime(2022, 7, 18, 15, 3, 40, 179, DateTimeKind.Local).AddTicks(1368), new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"), false },
                    { 389, new DateTime(2022, 7, 18, 19, 8, 20, 687, DateTimeKind.Local).AddTicks(6787), new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), false },
                    { 390, new DateTime(2022, 7, 18, 19, 3, 38, 908, DateTimeKind.Local).AddTicks(5676), new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), true },
                    { 391, new DateTime(2022, 7, 18, 12, 20, 53, 467, DateTimeKind.Local).AddTicks(3236), new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), false },
                    { 392, new DateTime(2022, 7, 18, 21, 3, 51, 869, DateTimeKind.Local).AddTicks(561), new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"), true },
                    { 393, new DateTime(2022, 7, 18, 22, 43, 20, 542, DateTimeKind.Local).AddTicks(8375), new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), true },
                    { 394, new DateTime(2022, 7, 18, 4, 39, 49, 500, DateTimeKind.Local).AddTicks(539), new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 395, new DateTime(2022, 7, 18, 16, 54, 18, 794, DateTimeKind.Local).AddTicks(7201), new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), true },
                    { 396, new DateTime(2022, 7, 19, 0, 58, 50, 338, DateTimeKind.Local).AddTicks(9860), new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), true },
                    { 397, new DateTime(2022, 7, 18, 21, 26, 6, 71, DateTimeKind.Local).AddTicks(2927), new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), false },
                    { 398, new DateTime(2022, 7, 18, 8, 53, 25, 142, DateTimeKind.Local).AddTicks(3869), new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"), false },
                    { 399, new DateTime(2022, 7, 19, 1, 44, 4, 786, DateTimeKind.Local).AddTicks(1330), new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"), false },
                    { 400, new DateTime(2022, 7, 18, 13, 52, 46, 831, DateTimeKind.Local).AddTicks(5098), new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), false },
                    { 401, new DateTime(2022, 7, 18, 6, 3, 42, 824, DateTimeKind.Local).AddTicks(4764), new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"), false },
                    { 402, new DateTime(2022, 7, 18, 7, 40, 51, 353, DateTimeKind.Local).AddTicks(4255), new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"), true },
                    { 403, new DateTime(2022, 7, 18, 13, 18, 38, 474, DateTimeKind.Local).AddTicks(2732), new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), true },
                    { 404, new DateTime(2022, 7, 18, 11, 15, 18, 499, DateTimeKind.Local).AddTicks(3850), new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), true },
                    { 405, new DateTime(2022, 7, 18, 10, 47, 45, 335, DateTimeKind.Local).AddTicks(3766), new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"), true },
                    { 406, new DateTime(2022, 7, 19, 1, 40, 57, 743, DateTimeKind.Local).AddTicks(8793), new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), true },
                    { 407, new DateTime(2022, 7, 18, 4, 39, 15, 77, DateTimeKind.Local).AddTicks(1200), new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"), true },
                    { 408, new DateTime(2022, 7, 18, 8, 46, 39, 116, DateTimeKind.Local).AddTicks(3248), new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), false },
                    { 409, new DateTime(2022, 7, 18, 14, 44, 20, 63, DateTimeKind.Local).AddTicks(6406), new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), true },
                    { 410, new DateTime(2022, 7, 18, 3, 51, 48, 439, DateTimeKind.Local).AddTicks(4649), new Guid("075ef475-0520-41cc-ab52-178b0221640e"), true },
                    { 411, new DateTime(2022, 7, 19, 1, 39, 28, 837, DateTimeKind.Local).AddTicks(2896), new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), true },
                    { 412, new DateTime(2022, 7, 18, 23, 47, 0, 808, DateTimeKind.Local).AddTicks(5404), new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), true },
                    { 413, new DateTime(2022, 7, 18, 6, 42, 30, 12, DateTimeKind.Local).AddTicks(5832), new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), false },
                    { 414, new DateTime(2022, 7, 18, 9, 13, 35, 511, DateTimeKind.Local).AddTicks(2777), new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), true },
                    { 415, new DateTime(2022, 7, 18, 15, 24, 30, 547, DateTimeKind.Local).AddTicks(9434), new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), true },
                    { 416, new DateTime(2022, 7, 18, 10, 58, 13, 628, DateTimeKind.Local).AddTicks(1376), new Guid("930fb85a-9332-45f0-be07-c60f767421c3"), true },
                    { 417, new DateTime(2022, 7, 18, 17, 47, 8, 973, DateTimeKind.Local).AddTicks(1468), new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), true },
                    { 418, new DateTime(2022, 7, 18, 15, 48, 25, 442, DateTimeKind.Local).AddTicks(3755), new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"), false },
                    { 419, new DateTime(2022, 7, 18, 14, 29, 40, 631, DateTimeKind.Local).AddTicks(2581), new Guid("075ef475-0520-41cc-ab52-178b0221640e"), true },
                    { 420, new DateTime(2022, 7, 18, 23, 24, 22, 659, DateTimeKind.Local).AddTicks(508), new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"), true },
                    { 421, new DateTime(2022, 7, 18, 12, 12, 14, 137, DateTimeKind.Local).AddTicks(3515), new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"), true },
                    { 422, new DateTime(2022, 7, 18, 7, 17, 22, 303, DateTimeKind.Local).AddTicks(9361), new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), true },
                    { 423, new DateTime(2022, 7, 18, 20, 41, 10, 704, DateTimeKind.Local).AddTicks(5868), new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), true },
                    { 424, new DateTime(2022, 7, 18, 23, 7, 15, 193, DateTimeKind.Local).AddTicks(199), new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"), false },
                    { 425, new DateTime(2022, 7, 18, 14, 14, 33, 283, DateTimeKind.Local).AddTicks(9058), new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), true },
                    { 426, new DateTime(2022, 7, 18, 14, 19, 25, 542, DateTimeKind.Local).AddTicks(438), new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), false },
                    { 427, new DateTime(2022, 7, 18, 21, 19, 36, 323, DateTimeKind.Local).AddTicks(7029), new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"), true },
                    { 428, new DateTime(2022, 7, 18, 4, 15, 5, 144, DateTimeKind.Local).AddTicks(1493), new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"), true },
                    { 429, new DateTime(2022, 7, 18, 5, 5, 30, 19, DateTimeKind.Local).AddTicks(8777), new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), false },
                    { 430, new DateTime(2022, 7, 18, 20, 2, 23, 746, DateTimeKind.Local).AddTicks(1561), new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), true },
                    { 431, new DateTime(2022, 7, 19, 1, 40, 8, 438, DateTimeKind.Local).AddTicks(8324), new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"), false },
                    { 432, new DateTime(2022, 7, 18, 11, 42, 54, 508, DateTimeKind.Local).AddTicks(2057), new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"), false },
                    { 433, new DateTime(2022, 7, 18, 17, 49, 36, 468, DateTimeKind.Local).AddTicks(776), new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"), true },
                    { 434, new DateTime(2022, 7, 18, 14, 47, 55, 756, DateTimeKind.Local).AddTicks(7111), new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), true },
                    { 435, new DateTime(2022, 7, 18, 22, 18, 5, 918, DateTimeKind.Local).AddTicks(9352), new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"), false },
                    { 436, new DateTime(2022, 7, 18, 14, 4, 37, 22, DateTimeKind.Local).AddTicks(8780), new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 437, new DateTime(2022, 7, 18, 13, 48, 50, 520, DateTimeKind.Local).AddTicks(4890), new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"), false },
                    { 438, new DateTime(2022, 7, 18, 13, 17, 50, 735, DateTimeKind.Local).AddTicks(8002), new Guid("572f86c0-a281-4aa1-9512-483f4559139b"), true },
                    { 439, new DateTime(2022, 7, 18, 6, 29, 6, 573, DateTimeKind.Local).AddTicks(7770), new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), false },
                    { 440, new DateTime(2022, 7, 18, 6, 10, 0, 887, DateTimeKind.Local).AddTicks(7099), new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"), true },
                    { 441, new DateTime(2022, 7, 18, 18, 57, 5, 753, DateTimeKind.Local).AddTicks(8023), new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"), false },
                    { 442, new DateTime(2022, 7, 18, 16, 27, 36, 459, DateTimeKind.Local).AddTicks(29), new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"), false },
                    { 443, new DateTime(2022, 7, 18, 8, 48, 42, 552, DateTimeKind.Local).AddTicks(9324), new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"), false },
                    { 444, new DateTime(2022, 7, 18, 9, 32, 51, 227, DateTimeKind.Local).AddTicks(558), new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"), false },
                    { 445, new DateTime(2022, 7, 18, 12, 45, 55, 59, DateTimeKind.Local).AddTicks(1245), new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"), false },
                    { 446, new DateTime(2022, 7, 18, 19, 21, 59, 551, DateTimeKind.Local).AddTicks(708), new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"), true },
                    { 447, new DateTime(2022, 7, 18, 13, 46, 30, 404, DateTimeKind.Local).AddTicks(4321), new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"), false },
                    { 448, new DateTime(2022, 7, 18, 20, 36, 37, 968, DateTimeKind.Local).AddTicks(1516), new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"), false },
                    { 449, new DateTime(2022, 7, 18, 6, 50, 25, 958, DateTimeKind.Local).AddTicks(4156), new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), true },
                    { 450, new DateTime(2022, 7, 18, 5, 8, 16, 132, DateTimeKind.Local).AddTicks(9022), new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"), true },
                    { 451, new DateTime(2022, 7, 18, 6, 7, 27, 525, DateTimeKind.Local).AddTicks(1914), new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"), false },
                    { 452, new DateTime(2022, 7, 18, 22, 38, 1, 933, DateTimeKind.Local).AddTicks(3560), new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"), true },
                    { 453, new DateTime(2022, 7, 18, 21, 18, 23, 370, DateTimeKind.Local).AddTicks(880), new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"), false },
                    { 454, new DateTime(2022, 7, 19, 0, 45, 34, 565, DateTimeKind.Local).AddTicks(4183), new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"), false },
                    { 455, new DateTime(2022, 7, 18, 13, 4, 34, 695, DateTimeKind.Local).AddTicks(7777), new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"), false },
                    { 456, new DateTime(2022, 7, 18, 12, 58, 4, 848, DateTimeKind.Local).AddTicks(7641), new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"), false },
                    { 457, new DateTime(2022, 7, 18, 18, 27, 2, 461, DateTimeKind.Local).AddTicks(8132), new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"), false },
                    { 458, new DateTime(2022, 7, 18, 12, 2, 31, 739, DateTimeKind.Local).AddTicks(9895), new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), false },
                    { 459, new DateTime(2022, 7, 19, 1, 36, 10, 225, DateTimeKind.Local).AddTicks(6233), new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"), false },
                    { 460, new DateTime(2022, 7, 18, 23, 29, 48, 94, DateTimeKind.Local).AddTicks(814), new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), true },
                    { 461, new DateTime(2022, 7, 18, 22, 22, 18, 181, DateTimeKind.Local).AddTicks(7164), new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), false },
                    { 462, new DateTime(2022, 7, 18, 21, 15, 53, 41, DateTimeKind.Local).AddTicks(480), new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"), false },
                    { 463, new DateTime(2022, 7, 18, 3, 35, 33, 610, DateTimeKind.Local).AddTicks(700), new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), true },
                    { 464, new DateTime(2022, 7, 18, 6, 47, 23, 932, DateTimeKind.Local).AddTicks(3749), new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), false },
                    { 465, new DateTime(2022, 7, 18, 16, 11, 42, 124, DateTimeKind.Local).AddTicks(1552), new Guid("44ff4700-4231-483d-8594-6799ffc367f6"), true },
                    { 466, new DateTime(2022, 7, 18, 15, 9, 49, 566, DateTimeKind.Local).AddTicks(3799), new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"), false },
                    { 467, new DateTime(2022, 7, 18, 22, 10, 31, 935, DateTimeKind.Local).AddTicks(3468), new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"), false },
                    { 468, new DateTime(2022, 7, 18, 10, 40, 47, 76, DateTimeKind.Local).AddTicks(8157), new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"), true },
                    { 469, new DateTime(2022, 7, 18, 13, 10, 39, 827, DateTimeKind.Local).AddTicks(4769), new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"), true },
                    { 470, new DateTime(2022, 7, 18, 7, 0, 41, 568, DateTimeKind.Local).AddTicks(8409), new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"), true },
                    { 471, new DateTime(2022, 7, 18, 15, 17, 36, 579, DateTimeKind.Local).AddTicks(8773), new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"), false },
                    { 472, new DateTime(2022, 7, 18, 15, 36, 29, 467, DateTimeKind.Local).AddTicks(9496), new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"), true },
                    { 473, new DateTime(2022, 7, 18, 19, 8, 16, 265, DateTimeKind.Local).AddTicks(9047), new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"), false },
                    { 474, new DateTime(2022, 7, 18, 18, 8, 20, 493, DateTimeKind.Local).AddTicks(55), new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"), false },
                    { 475, new DateTime(2022, 7, 18, 19, 44, 27, 30, DateTimeKind.Local).AddTicks(3680), new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"), false },
                    { 476, new DateTime(2022, 7, 18, 18, 8, 14, 406, DateTimeKind.Local).AddTicks(221), new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"), true },
                    { 477, new DateTime(2022, 7, 18, 22, 51, 4, 706, DateTimeKind.Local).AddTicks(641), new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"), true },
                    { 478, new DateTime(2022, 7, 18, 19, 19, 53, 455, DateTimeKind.Local).AddTicks(1227), new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 479, new DateTime(2022, 7, 18, 18, 11, 28, 470, DateTimeKind.Local).AddTicks(1958), new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"), false },
                    { 480, new DateTime(2022, 7, 18, 21, 30, 42, 434, DateTimeKind.Local).AddTicks(4111), new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"), true },
                    { 481, new DateTime(2022, 7, 18, 4, 1, 13, 691, DateTimeKind.Local).AddTicks(5538), new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"), true },
                    { 482, new DateTime(2022, 7, 18, 20, 36, 19, 132, DateTimeKind.Local).AddTicks(623), new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"), false },
                    { 483, new DateTime(2022, 7, 18, 9, 58, 0, 900, DateTimeKind.Local).AddTicks(7245), new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"), true },
                    { 484, new DateTime(2022, 7, 18, 17, 6, 57, 665, DateTimeKind.Local).AddTicks(2440), new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"), true },
                    { 485, new DateTime(2022, 7, 18, 8, 36, 19, 477, DateTimeKind.Local).AddTicks(9260), new Guid("179ac0de-306b-47de-abf3-f619ec367085"), true },
                    { 486, new DateTime(2022, 7, 18, 11, 39, 54, 600, DateTimeKind.Local).AddTicks(7561), new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"), false },
                    { 487, new DateTime(2022, 7, 18, 6, 44, 48, 381, DateTimeKind.Local).AddTicks(1266), new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"), true },
                    { 488, new DateTime(2022, 7, 18, 14, 47, 23, 993, DateTimeKind.Local).AddTicks(8508), new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"), true },
                    { 489, new DateTime(2022, 7, 19, 2, 32, 37, 770, DateTimeKind.Local).AddTicks(9952), new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"), true },
                    { 490, new DateTime(2022, 7, 18, 8, 50, 30, 691, DateTimeKind.Local).AddTicks(1395), new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"), true },
                    { 491, new DateTime(2022, 7, 18, 3, 53, 40, 131, DateTimeKind.Local).AddTicks(1683), new Guid("4307075b-d195-449f-b670-e64f49be87ba"), true },
                    { 492, new DateTime(2022, 7, 18, 13, 11, 15, 465, DateTimeKind.Local).AddTicks(782), new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), true },
                    { 493, new DateTime(2022, 7, 18, 10, 46, 58, 531, DateTimeKind.Local).AddTicks(528), new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), false },
                    { 494, new DateTime(2022, 7, 18, 3, 34, 43, 589, DateTimeKind.Local).AddTicks(1522), new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"), true },
                    { 495, new DateTime(2022, 7, 18, 12, 46, 59, 597, DateTimeKind.Local).AddTicks(6585), new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"), false },
                    { 496, new DateTime(2022, 7, 18, 13, 20, 7, 362, DateTimeKind.Local).AddTicks(5013), new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"), true },
                    { 497, new DateTime(2022, 7, 18, 5, 11, 8, 392, DateTimeKind.Local).AddTicks(6675), new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"), true },
                    { 498, new DateTime(2022, 7, 18, 19, 3, 26, 706, DateTimeKind.Local).AddTicks(4118), new Guid("179ac0de-306b-47de-abf3-f619ec367085"), false },
                    { 499, new DateTime(2022, 7, 18, 9, 41, 12, 644, DateTimeKind.Local).AddTicks(1093), new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"), false },
                    { 500, new DateTime(2022, 7, 19, 0, 46, 48, 250, DateTimeKind.Local).AddTicks(4602), new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"), true }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 7, new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff") },
                    { 2, 3, new Guid("7800ad41-297f-470b-986d-8e4d2c79917e") },
                    { 3, 3, new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92") },
                    { 4, 9, new Guid("b92c898d-241b-4cea-b325-33bd343d06f6") },
                    { 5, 3, new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad") },
                    { 6, 3, new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df") },
                    { 7, 5, new Guid("9298b336-e13c-40ea-990d-dab16e54d80f") },
                    { 8, 3, new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8") },
                    { 9, 4, new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740") },
                    { 10, 7, new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276") },
                    { 11, 2, new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1") },
                    { 12, 6, new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832") },
                    { 13, 5, new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640") },
                    { 14, 9, new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879") },
                    { 15, 6, new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894") },
                    { 16, 2, new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94") },
                    { 17, 4, new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4") },
                    { 18, 1, new Guid("572f86c0-a281-4aa1-9512-483f4559139b") },
                    { 19, 7, new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45") },
                    { 20, 5, new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 21, 3, new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45") },
                    { 22, 9, new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea") },
                    { 23, 2, new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab") },
                    { 24, 5, new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3") },
                    { 25, 6, new Guid("53035ed9-2940-4227-9b55-92e68f6368a2") },
                    { 26, 4, new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f") },
                    { 27, 6, new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f") },
                    { 28, 4, new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0") },
                    { 29, 2, new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570") },
                    { 30, 5, new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db") },
                    { 31, 1, new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c") },
                    { 32, 5, new Guid("930fb85a-9332-45f0-be07-c60f767421c3") },
                    { 33, 2, new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1") },
                    { 34, 9, new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f") },
                    { 35, 2, new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b") },
                    { 36, 2, new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29") },
                    { 37, 6, new Guid("e17832f8-11a1-41ee-9e46-f86393977cff") },
                    { 38, 3, new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f") },
                    { 39, 8, new Guid("80803981-0e13-4c33-9d5f-da6265bf972d") },
                    { 40, 6, new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da") },
                    { 41, 6, new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6") },
                    { 42, 1, new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7") },
                    { 43, 7, new Guid("a287abd0-618d-4f37-a3aa-c79a05711693") },
                    { 44, 4, new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a") },
                    { 45, 6, new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11") },
                    { 46, 6, new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4") },
                    { 47, 8, new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42") },
                    { 48, 1, new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408") },
                    { 49, 1, new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37") },
                    { 50, 8, new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c") },
                    { 51, 8, new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10") },
                    { 52, 8, new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422") },
                    { 53, 9, new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d") },
                    { 54, 2, new Guid("075ef475-0520-41cc-ab52-178b0221640e") },
                    { 55, 3, new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3") },
                    { 56, 6, new Guid("064e2294-6cf0-4371-9300-7a5376a2db27") },
                    { 57, 9, new Guid("f0f2ea50-0e34-442c-9229-97432d23425c") },
                    { 58, 5, new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb") },
                    { 59, 8, new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd") },
                    { 60, 5, new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3") },
                    { 61, 3, new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee") },
                    { 62, 6, new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 63, 5, new Guid("97c9e838-c71c-4c73-b2c0-caf745656350") },
                    { 64, 8, new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6") },
                    { 65, 3, new Guid("9840b515-74f0-4af0-b950-92055db7fa99") },
                    { 66, 9, new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d") },
                    { 67, 6, new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215") },
                    { 68, 3, new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0") },
                    { 69, 8, new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672") },
                    { 70, 6, new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3") },
                    { 71, 4, new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6") },
                    { 72, 1, new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98") },
                    { 73, 4, new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e") },
                    { 74, 4, new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e") },
                    { 75, 2, new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8") },
                    { 76, 6, new Guid("44ff4700-4231-483d-8594-6799ffc367f6") },
                    { 77, 5, new Guid("221f5506-2d87-429e-a621-c042bdbe369c") },
                    { 78, 8, new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba") },
                    { 79, 5, new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c") },
                    { 80, 1, new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4") },
                    { 81, 8, new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645") },
                    { 82, 8, new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d") },
                    { 83, 5, new Guid("179ac0de-306b-47de-abf3-f619ec367085") },
                    { 84, 5, new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1") },
                    { 85, 5, new Guid("d535e730-2d14-49b6-b7da-a277ee86713a") },
                    { 86, 7, new Guid("4307075b-d195-449f-b670-e64f49be87ba") },
                    { 87, 2, new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537") },
                    { 88, 3, new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab") },
                    { 89, 6, new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0") },
                    { 90, 6, new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613") },
                    { 91, 1, new Guid("05adcb80-5b78-420b-b70a-3017939eb85c") },
                    { 92, 1, new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213") },
                    { 93, 5, new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9") },
                    { 94, 3, new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8") },
                    { 95, 3, new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996") },
                    { 96, 5, new Guid("33d661bc-3d32-41d3-9219-43365ed49af8") },
                    { 97, 2, new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830") },
                    { 98, 6, new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe") },
                    { 99, 4, new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104") },
                    { 100, 7, new Guid("28552ffc-9302-4942-aa22-82654eeb5fba") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff") },
                    { 2, 2, new Guid("7800ad41-297f-470b-986d-8e4d2c79917e") },
                    { 3, 3, new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92") },
                    { 4, 4, new Guid("b92c898d-241b-4cea-b325-33bd343d06f6") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 5, 5, new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad") },
                    { 6, 6, new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df") },
                    { 7, 7, new Guid("9298b336-e13c-40ea-990d-dab16e54d80f") },
                    { 8, 8, new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8") },
                    { 9, 9, new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740") },
                    { 10, 10, new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276") },
                    { 11, 11, new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1") },
                    { 12, 12, new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832") },
                    { 13, 13, new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640") },
                    { 14, 14, new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879") },
                    { 15, 15, new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894") },
                    { 16, 16, new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94") },
                    { 17, 17, new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4") },
                    { 18, 18, new Guid("572f86c0-a281-4aa1-9512-483f4559139b") },
                    { 19, 19, new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45") },
                    { 20, 20, new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13") },
                    { 21, 21, new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45") },
                    { 22, 22, new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea") },
                    { 23, 23, new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab") },
                    { 24, 24, new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3") },
                    { 25, 25, new Guid("53035ed9-2940-4227-9b55-92e68f6368a2") },
                    { 26, 26, new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f") },
                    { 27, 27, new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f") },
                    { 28, 28, new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0") },
                    { 29, 29, new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570") },
                    { 30, 30, new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db") },
                    { 31, 31, new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c") },
                    { 32, 32, new Guid("930fb85a-9332-45f0-be07-c60f767421c3") },
                    { 33, 33, new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1") },
                    { 34, 34, new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f") },
                    { 35, 35, new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b") },
                    { 36, 36, new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29") },
                    { 37, 37, new Guid("e17832f8-11a1-41ee-9e46-f86393977cff") },
                    { 38, 38, new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f") },
                    { 39, 39, new Guid("80803981-0e13-4c33-9d5f-da6265bf972d") },
                    { 40, 40, new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da") },
                    { 41, 41, new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6") },
                    { 42, 42, new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7") },
                    { 43, 43, new Guid("a287abd0-618d-4f37-a3aa-c79a05711693") },
                    { 44, 44, new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a") },
                    { 45, 45, new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11") },
                    { 46, 46, new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 47, 47, new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42") },
                    { 48, 48, new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408") },
                    { 49, 49, new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37") },
                    { 50, 50, new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c") },
                    { 51, 51, new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10") },
                    { 52, 52, new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422") },
                    { 53, 53, new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d") },
                    { 54, 54, new Guid("075ef475-0520-41cc-ab52-178b0221640e") },
                    { 55, 55, new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3") },
                    { 56, 56, new Guid("064e2294-6cf0-4371-9300-7a5376a2db27") },
                    { 57, 57, new Guid("f0f2ea50-0e34-442c-9229-97432d23425c") },
                    { 58, 58, new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb") },
                    { 59, 59, new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd") },
                    { 60, 60, new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3") },
                    { 61, 61, new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee") },
                    { 62, 62, new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5") },
                    { 63, 63, new Guid("97c9e838-c71c-4c73-b2c0-caf745656350") },
                    { 64, 64, new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6") },
                    { 65, 65, new Guid("9840b515-74f0-4af0-b950-92055db7fa99") },
                    { 66, 66, new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d") },
                    { 67, 67, new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215") },
                    { 68, 68, new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0") },
                    { 69, 69, new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672") },
                    { 70, 70, new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3") },
                    { 71, 71, new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6") },
                    { 72, 72, new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98") },
                    { 73, 73, new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e") },
                    { 74, 74, new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e") },
                    { 75, 75, new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8") },
                    { 76, 76, new Guid("44ff4700-4231-483d-8594-6799ffc367f6") },
                    { 77, 77, new Guid("221f5506-2d87-429e-a621-c042bdbe369c") },
                    { 78, 78, new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba") },
                    { 79, 79, new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c") },
                    { 80, 80, new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4") },
                    { 81, 81, new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645") },
                    { 82, 82, new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d") },
                    { 83, 83, new Guid("179ac0de-306b-47de-abf3-f619ec367085") },
                    { 84, 84, new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1") },
                    { 85, 85, new Guid("d535e730-2d14-49b6-b7da-a277ee86713a") },
                    { 86, 86, new Guid("4307075b-d195-449f-b670-e64f49be87ba") },
                    { 87, 87, new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537") },
                    { 88, 88, new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 89, 89, new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0") },
                    { 90, 90, new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613") },
                    { 91, 91, new Guid("05adcb80-5b78-420b-b70a-3017939eb85c") },
                    { 92, 92, new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213") },
                    { 93, 93, new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9") },
                    { 94, 94, new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8") },
                    { 95, 95, new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996") },
                    { 96, 96, new Guid("33d661bc-3d32-41d3-9219-43365ed49af8") },
                    { 97, 97, new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830") },
                    { 98, 98, new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe") },
                    { 99, 99, new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104") },
                    { 100, 100, new Guid("28552ffc-9302-4942-aa22-82654eeb5fba") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff") },
                    { 2, 1, new Guid("7800ad41-297f-470b-986d-8e4d2c79917e") },
                    { 3, 1, new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92") },
                    { 4, 1, new Guid("b92c898d-241b-4cea-b325-33bd343d06f6") },
                    { 5, 1, new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad") },
                    { 6, 1, new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df") },
                    { 7, 1, new Guid("9298b336-e13c-40ea-990d-dab16e54d80f") },
                    { 8, 1, new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8") },
                    { 9, 1, new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740") },
                    { 10, 1, new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276") },
                    { 11, 1, new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1") },
                    { 12, 1, new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832") },
                    { 13, 1, new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640") },
                    { 14, 1, new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879") },
                    { 15, 1, new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894") },
                    { 16, 1, new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94") },
                    { 17, 1, new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4") },
                    { 18, 1, new Guid("572f86c0-a281-4aa1-9512-483f4559139b") },
                    { 19, 1, new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45") },
                    { 20, 1, new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13") },
                    { 21, 1, new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45") },
                    { 22, 1, new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea") },
                    { 23, 1, new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab") },
                    { 24, 1, new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3") },
                    { 25, 1, new Guid("53035ed9-2940-4227-9b55-92e68f6368a2") },
                    { 26, 1, new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f") },
                    { 27, 1, new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f") },
                    { 28, 1, new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0") },
                    { 29, 1, new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570") },
                    { 30, 1, new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 31, 1, new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c") },
                    { 32, 1, new Guid("930fb85a-9332-45f0-be07-c60f767421c3") },
                    { 33, 1, new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1") },
                    { 34, 1, new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f") },
                    { 35, 1, new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b") },
                    { 36, 1, new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29") },
                    { 37, 1, new Guid("e17832f8-11a1-41ee-9e46-f86393977cff") },
                    { 38, 1, new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f") },
                    { 39, 1, new Guid("80803981-0e13-4c33-9d5f-da6265bf972d") },
                    { 40, 1, new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da") },
                    { 41, 1, new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6") },
                    { 42, 1, new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7") },
                    { 43, 1, new Guid("a287abd0-618d-4f37-a3aa-c79a05711693") },
                    { 44, 1, new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a") },
                    { 45, 1, new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11") },
                    { 46, 1, new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4") },
                    { 47, 1, new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42") },
                    { 48, 1, new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408") },
                    { 49, 1, new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37") },
                    { 50, 1, new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c") },
                    { 51, 1, new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10") },
                    { 52, 1, new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422") },
                    { 53, 1, new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d") },
                    { 54, 1, new Guid("075ef475-0520-41cc-ab52-178b0221640e") },
                    { 55, 1, new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3") },
                    { 56, 1, new Guid("064e2294-6cf0-4371-9300-7a5376a2db27") },
                    { 57, 1, new Guid("f0f2ea50-0e34-442c-9229-97432d23425c") },
                    { 58, 1, new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb") },
                    { 59, 1, new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd") },
                    { 60, 1, new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3") },
                    { 61, 1, new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee") },
                    { 62, 1, new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5") },
                    { 63, 1, new Guid("97c9e838-c71c-4c73-b2c0-caf745656350") },
                    { 64, 1, new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6") },
                    { 65, 1, new Guid("9840b515-74f0-4af0-b950-92055db7fa99") },
                    { 66, 1, new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d") },
                    { 67, 1, new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215") },
                    { 68, 1, new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0") },
                    { 69, 1, new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672") },
                    { 70, 1, new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3") },
                    { 71, 1, new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6") },
                    { 72, 1, new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 73, 1, new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e") },
                    { 74, 1, new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e") },
                    { 75, 1, new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8") },
                    { 76, 1, new Guid("44ff4700-4231-483d-8594-6799ffc367f6") },
                    { 77, 1, new Guid("221f5506-2d87-429e-a621-c042bdbe369c") },
                    { 78, 1, new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba") },
                    { 79, 1, new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c") },
                    { 80, 1, new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4") },
                    { 81, 1, new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645") },
                    { 82, 1, new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d") },
                    { 83, 1, new Guid("179ac0de-306b-47de-abf3-f619ec367085") },
                    { 84, 1, new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1") },
                    { 85, 1, new Guid("d535e730-2d14-49b6-b7da-a277ee86713a") },
                    { 86, 1, new Guid("4307075b-d195-449f-b670-e64f49be87ba") },
                    { 87, 1, new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537") },
                    { 88, 1, new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab") },
                    { 89, 1, new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0") },
                    { 90, 1, new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613") },
                    { 91, 1, new Guid("05adcb80-5b78-420b-b70a-3017939eb85c") },
                    { 92, 1, new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213") },
                    { 93, 1, new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9") },
                    { 94, 1, new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8") },
                    { 95, 1, new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996") },
                    { 96, 1, new Guid("33d661bc-3d32-41d3-9219-43365ed49af8") },
                    { 97, 1, new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830") },
                    { 98, 1, new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe") },
                    { 99, 1, new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104") },
                    { 100, 1, new Guid("28552ffc-9302-4942-aa22-82654eeb5fba") }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 1, 2, 16 },
                    { 3, 1, 3, 8 },
                    { 4, 1, 4, 7 },
                    { 5, 1, 5, 18 },
                    { 6, 1, 6, 9 },
                    { 7, 1, 7, 16 },
                    { 8, 1, 8, 8 },
                    { 9, 1, 9, 15 },
                    { 10, 1, 10, 1 },
                    { 11, 1, 11, 5 },
                    { 12, 1, 12, 8 },
                    { 13, 1, 13, 7 },
                    { 14, 1, 14, 15 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 15, 1, 15, 10 },
                    { 16, 1, 16, 13 },
                    { 17, 1, 17, 10 },
                    { 18, 1, 18, 7 },
                    { 19, 1, 19, 4 },
                    { 20, 1, 20, 2 },
                    { 21, 1, 21, 1 },
                    { 22, 1, 22, 9 },
                    { 23, 1, 23, 10 },
                    { 24, 1, 24, 18 },
                    { 25, 1, 25, 1 },
                    { 26, 1, 26, 13 },
                    { 27, 1, 27, 9 },
                    { 28, 1, 28, 5 },
                    { 29, 1, 29, 2 },
                    { 30, 1, 30, 3 },
                    { 31, 1, 31, 4 },
                    { 32, 1, 32, 13 },
                    { 33, 1, 33, 2 },
                    { 34, 1, 34, 10 },
                    { 35, 1, 35, 16 },
                    { 36, 1, 36, 7 },
                    { 37, 1, 37, 17 },
                    { 38, 1, 38, 1 },
                    { 39, 1, 39, 13 },
                    { 40, 2, 40, 1 },
                    { 41, 2, 41, 9 },
                    { 42, 2, 42, 17 },
                    { 43, 2, 43, 15 },
                    { 44, 2, 44, 12 },
                    { 45, 2, 45, 4 },
                    { 46, 2, 46, 7 },
                    { 47, 2, 47, 6 },
                    { 48, 2, 48, 3 },
                    { 49, 2, 49, 17 },
                    { 50, 2, 50, 12 },
                    { 51, 2, 51, 16 },
                    { 52, 2, 52, 4 },
                    { 53, 2, 53, 3 },
                    { 54, 2, 54, 18 },
                    { 55, 2, 55, 1 },
                    { 56, 2, 56, 4 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 57, 2, 57, 8 },
                    { 58, 2, 58, 12 },
                    { 59, 2, 59, 12 },
                    { 60, 2, 60, 9 },
                    { 61, 2, 61, 14 },
                    { 62, 2, 62, 17 },
                    { 63, 2, 63, 12 },
                    { 64, 2, 64, 15 },
                    { 65, 2, 65, 13 },
                    { 66, 2, 66, 2 },
                    { 67, 2, 67, 15 },
                    { 68, 2, 68, 4 },
                    { 69, 2, 69, 10 },
                    { 70, 2, 70, 16 },
                    { 71, 2, 71, 17 },
                    { 72, 2, 72, 2 },
                    { 73, 2, 73, 15 },
                    { 74, 2, 74, 4 },
                    { 75, 2, 75, 1 },
                    { 76, 2, 76, 14 },
                    { 77, 2, 77, 10 },
                    { 78, 2, 78, 5 },
                    { 79, 2, 79, 6 },
                    { 80, 3, 80, 10 },
                    { 81, 3, 81, 2 },
                    { 82, 3, 82, 5 },
                    { 83, 3, 83, 8 },
                    { 84, 3, 84, 17 },
                    { 85, 3, 85, 16 },
                    { 86, 3, 86, 2 },
                    { 87, 3, 87, 3 },
                    { 88, 3, 88, 1 },
                    { 89, 3, 89, 9 },
                    { 90, 3, 90, 11 },
                    { 91, 3, 91, 12 },
                    { 92, 3, 92, 6 },
                    { 93, 3, 93, 12 },
                    { 94, 3, 94, 11 },
                    { 95, 3, 95, 12 },
                    { 96, 3, 96, 7 },
                    { 97, 3, 97, 13 },
                    { 98, 3, 98, 8 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 99, 3, 99, 6 },
                    { 100, 3, 100, 10 },
                    { 101, 3, 101, 1 },
                    { 102, 3, 102, 1 },
                    { 103, 3, 103, 1 },
                    { 104, 3, 104, 18 },
                    { 105, 3, 105, 11 },
                    { 106, 3, 106, 16 },
                    { 107, 3, 107, 11 },
                    { 108, 3, 108, 13 },
                    { 109, 3, 109, 17 },
                    { 110, 3, 110, 6 },
                    { 111, 3, 111, 4 },
                    { 112, 3, 112, 17 },
                    { 113, 3, 113, 15 },
                    { 114, 3, 114, 10 },
                    { 115, 3, 115, 2 },
                    { 116, 3, 116, 2 },
                    { 117, 3, 117, 7 },
                    { 118, 3, 118, 18 },
                    { 119, 3, 119, 7 },
                    { 120, 4, 120, 2 },
                    { 121, 4, 121, 5 },
                    { 122, 4, 122, 18 },
                    { 123, 4, 123, 7 },
                    { 124, 4, 124, 14 },
                    { 125, 4, 125, 9 },
                    { 126, 4, 126, 3 },
                    { 127, 4, 127, 3 },
                    { 128, 4, 128, 16 },
                    { 129, 4, 129, 14 },
                    { 130, 4, 130, 6 },
                    { 131, 4, 131, 2 },
                    { 132, 4, 132, 6 },
                    { 133, 4, 133, 8 },
                    { 134, 4, 134, 5 },
                    { 135, 4, 135, 17 },
                    { 136, 4, 136, 2 },
                    { 137, 4, 137, 7 },
                    { 138, 4, 138, 18 },
                    { 139, 4, 139, 16 },
                    { 140, 4, 140, 14 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 141, 4, 141, 4 },
                    { 142, 4, 142, 11 },
                    { 143, 4, 143, 2 },
                    { 144, 4, 144, 13 },
                    { 145, 4, 145, 4 },
                    { 146, 4, 146, 2 },
                    { 147, 4, 147, 7 },
                    { 148, 4, 148, 2 },
                    { 149, 4, 149, 13 },
                    { 150, 4, 150, 13 },
                    { 151, 4, 151, 4 },
                    { 152, 4, 152, 10 },
                    { 153, 4, 153, 7 },
                    { 154, 4, 154, 16 },
                    { 155, 4, 155, 10 },
                    { 156, 4, 156, 13 },
                    { 157, 4, 157, 5 },
                    { 158, 4, 158, 1 },
                    { 159, 4, 159, 10 },
                    { 160, 5, 160, 5 },
                    { 161, 5, 161, 12 },
                    { 162, 5, 162, 4 },
                    { 163, 5, 163, 15 },
                    { 164, 5, 164, 10 },
                    { 165, 5, 165, 11 },
                    { 166, 5, 166, 3 },
                    { 167, 5, 167, 17 },
                    { 168, 5, 168, 6 },
                    { 169, 5, 169, 8 },
                    { 170, 5, 170, 14 },
                    { 171, 5, 171, 17 },
                    { 172, 5, 172, 2 },
                    { 173, 5, 173, 5 },
                    { 174, 5, 174, 16 },
                    { 175, 5, 175, 2 },
                    { 176, 5, 176, 10 },
                    { 177, 5, 177, 8 },
                    { 178, 5, 178, 11 },
                    { 179, 5, 179, 12 },
                    { 180, 5, 180, 8 },
                    { 181, 5, 181, 10 },
                    { 182, 5, 182, 11 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 183, 5, 183, 16 },
                    { 184, 5, 184, 11 },
                    { 185, 5, 185, 13 },
                    { 186, 5, 186, 11 },
                    { 187, 5, 187, 1 },
                    { 188, 5, 188, 4 },
                    { 189, 5, 189, 9 },
                    { 190, 5, 190, 12 },
                    { 191, 5, 191, 3 },
                    { 192, 5, 192, 10 },
                    { 193, 5, 193, 11 },
                    { 194, 5, 194, 14 },
                    { 195, 5, 195, 3 },
                    { 196, 5, 196, 18 },
                    { 197, 5, 197, 1 },
                    { 198, 5, 198, 3 },
                    { 199, 5, 199, 14 },
                    { 200, 6, 200, 5 },
                    { 201, 6, 201, 17 },
                    { 202, 6, 202, 13 },
                    { 203, 6, 203, 16 },
                    { 204, 6, 204, 1 },
                    { 205, 6, 205, 8 },
                    { 206, 6, 206, 1 },
                    { 207, 6, 207, 16 },
                    { 208, 6, 208, 12 },
                    { 209, 6, 209, 13 },
                    { 210, 6, 210, 14 },
                    { 211, 6, 211, 8 },
                    { 212, 6, 212, 13 },
                    { 213, 6, 213, 4 },
                    { 214, 6, 214, 9 },
                    { 215, 6, 215, 17 },
                    { 216, 6, 216, 12 },
                    { 217, 6, 217, 3 },
                    { 218, 6, 218, 11 },
                    { 219, 6, 219, 13 },
                    { 220, 6, 220, 15 },
                    { 221, 6, 221, 2 },
                    { 222, 6, 222, 17 },
                    { 223, 6, 223, 2 },
                    { 224, 6, 224, 18 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 225, 6, 225, 16 },
                    { 226, 6, 226, 17 },
                    { 227, 6, 227, 12 },
                    { 228, 6, 228, 6 },
                    { 229, 6, 229, 7 },
                    { 230, 6, 230, 6 },
                    { 231, 6, 231, 9 },
                    { 232, 6, 232, 9 },
                    { 233, 6, 233, 17 },
                    { 234, 6, 234, 9 },
                    { 235, 6, 235, 17 },
                    { 236, 6, 236, 9 },
                    { 237, 6, 237, 7 },
                    { 238, 6, 238, 2 },
                    { 239, 6, 239, 18 },
                    { 240, 7, 240, 6 },
                    { 241, 7, 241, 2 },
                    { 242, 7, 242, 1 },
                    { 243, 7, 243, 12 },
                    { 244, 7, 244, 8 },
                    { 245, 7, 245, 15 },
                    { 246, 7, 246, 17 },
                    { 247, 7, 247, 5 },
                    { 248, 7, 248, 10 },
                    { 249, 7, 249, 10 },
                    { 250, 7, 250, 10 },
                    { 251, 7, 251, 12 },
                    { 252, 7, 252, 8 },
                    { 253, 7, 253, 8 },
                    { 254, 7, 254, 2 },
                    { 255, 7, 255, 2 },
                    { 256, 7, 256, 15 },
                    { 257, 7, 257, 3 },
                    { 258, 7, 258, 3 },
                    { 259, 7, 259, 7 },
                    { 260, 7, 260, 18 },
                    { 261, 7, 261, 15 },
                    { 262, 7, 262, 8 },
                    { 263, 7, 263, 14 },
                    { 264, 7, 264, 4 },
                    { 265, 7, 265, 7 },
                    { 266, 7, 266, 18 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 267, 7, 267, 17 },
                    { 268, 7, 268, 14 },
                    { 269, 7, 269, 4 },
                    { 270, 7, 270, 15 },
                    { 271, 7, 271, 7 },
                    { 272, 7, 272, 13 },
                    { 273, 7, 273, 10 },
                    { 274, 7, 274, 12 },
                    { 275, 7, 275, 8 },
                    { 276, 7, 276, 14 },
                    { 277, 7, 277, 15 },
                    { 278, 7, 278, 15 },
                    { 279, 7, 279, 1 },
                    { 280, 8, 280, 10 },
                    { 281, 8, 281, 14 },
                    { 282, 8, 282, 16 },
                    { 283, 8, 283, 3 },
                    { 284, 8, 284, 18 },
                    { 285, 8, 285, 3 },
                    { 286, 8, 286, 11 },
                    { 287, 8, 287, 2 },
                    { 288, 8, 288, 15 },
                    { 289, 8, 289, 9 },
                    { 290, 8, 290, 6 },
                    { 291, 8, 291, 9 },
                    { 292, 8, 292, 11 },
                    { 293, 8, 293, 15 },
                    { 294, 8, 294, 12 },
                    { 295, 8, 295, 4 },
                    { 296, 8, 296, 12 },
                    { 297, 8, 297, 10 },
                    { 298, 8, 298, 15 },
                    { 299, 8, 299, 17 },
                    { 300, 8, 300, 11 },
                    { 301, 8, 301, 9 },
                    { 302, 8, 302, 13 },
                    { 303, 8, 303, 13 },
                    { 304, 8, 304, 17 },
                    { 305, 8, 305, 18 },
                    { 306, 8, 306, 2 },
                    { 307, 8, 307, 6 },
                    { 308, 8, 308, 16 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 309, 8, 309, 10 },
                    { 310, 8, 310, 2 },
                    { 311, 8, 311, 15 },
                    { 312, 8, 312, 2 },
                    { 313, 8, 313, 7 },
                    { 314, 8, 314, 5 },
                    { 315, 8, 315, 11 },
                    { 316, 8, 316, 16 },
                    { 317, 8, 317, 10 },
                    { 318, 8, 318, 7 },
                    { 319, 8, 319, 18 },
                    { 320, 9, 320, 14 },
                    { 321, 9, 321, 7 },
                    { 322, 9, 322, 5 },
                    { 323, 9, 323, 15 },
                    { 324, 9, 324, 11 },
                    { 325, 9, 325, 7 },
                    { 326, 9, 326, 1 },
                    { 327, 9, 327, 1 },
                    { 328, 9, 328, 6 },
                    { 329, 9, 329, 11 },
                    { 330, 9, 330, 12 },
                    { 331, 9, 331, 10 },
                    { 332, 9, 332, 6 },
                    { 333, 9, 333, 11 },
                    { 334, 9, 334, 6 },
                    { 335, 9, 335, 16 },
                    { 336, 9, 336, 6 },
                    { 337, 9, 337, 8 },
                    { 338, 9, 338, 6 },
                    { 339, 9, 339, 3 },
                    { 340, 9, 340, 6 },
                    { 341, 9, 341, 10 },
                    { 342, 9, 342, 1 },
                    { 343, 9, 343, 1 },
                    { 344, 9, 344, 12 },
                    { 345, 9, 345, 10 },
                    { 346, 9, 346, 6 },
                    { 347, 9, 347, 3 },
                    { 348, 9, 348, 2 },
                    { 349, 9, 349, 16 },
                    { 350, 9, 350, 6 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 351, 9, 351, 5 },
                    { 352, 9, 352, 3 },
                    { 353, 9, 353, 3 },
                    { 354, 9, 354, 17 },
                    { 355, 9, 355, 4 },
                    { 356, 9, 356, 7 },
                    { 357, 9, 357, 17 },
                    { 358, 9, 358, 18 },
                    { 359, 9, 359, 12 },
                    { 360, 10, 360, 15 },
                    { 361, 10, 361, 14 },
                    { 362, 10, 362, 14 },
                    { 363, 10, 363, 13 },
                    { 364, 10, 364, 18 },
                    { 365, 10, 365, 10 },
                    { 366, 10, 366, 6 },
                    { 367, 10, 367, 9 },
                    { 368, 10, 368, 14 },
                    { 369, 10, 369, 17 },
                    { 370, 10, 370, 16 },
                    { 371, 10, 371, 9 },
                    { 372, 10, 372, 18 },
                    { 373, 10, 373, 3 },
                    { 374, 10, 374, 2 },
                    { 375, 10, 375, 7 },
                    { 376, 10, 376, 13 },
                    { 377, 10, 377, 15 },
                    { 378, 10, 378, 13 },
                    { 379, 10, 379, 10 },
                    { 380, 10, 380, 12 },
                    { 381, 10, 381, 5 },
                    { 382, 10, 382, 1 },
                    { 383, 10, 383, 3 },
                    { 384, 10, 384, 4 },
                    { 385, 10, 385, 12 },
                    { 386, 10, 386, 2 },
                    { 387, 10, 387, 12 },
                    { 388, 10, 388, 2 },
                    { 389, 10, 389, 18 },
                    { 390, 10, 390, 4 },
                    { 391, 10, 391, 1 },
                    { 392, 10, 392, 8 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 393, 10, 393, 8 },
                    { 394, 10, 394, 5 },
                    { 395, 10, 395, 5 },
                    { 396, 10, 396, 1 },
                    { 397, 10, 397, 7 },
                    { 398, 10, 398, 11 },
                    { 399, 10, 399, 10 },
                    { 400, 10, 400, 13 }
                });

            migrationBuilder.InsertData(
                table: "LessonApprove",
                columns: new[] { "LessonApproveID", "FK_ApproveID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 15, 1 },
                    { 2, 9, 2 },
                    { 3, 11, 3 },
                    { 4, 4, 4 },
                    { 5, 7, 5 },
                    { 6, 25, 6 },
                    { 7, 13, 7 },
                    { 8, 6, 8 },
                    { 9, 5, 9 },
                    { 10, 19, 10 },
                    { 11, 30, 11 },
                    { 12, 29, 12 },
                    { 13, 16, 13 },
                    { 14, 23, 14 },
                    { 15, 24, 15 },
                    { 16, 17, 16 },
                    { 17, 21, 17 },
                    { 18, 2, 18 },
                    { 19, 18, 19 },
                    { 20, 12, 20 },
                    { 21, 22, 21 },
                    { 22, 14, 22 },
                    { 23, 8, 23 },
                    { 24, 28, 24 },
                    { 25, 27, 25 },
                    { 26, 1, 26 },
                    { 27, 20, 27 },
                    { 28, 10, 28 },
                    { 29, 3, 29 },
                    { 30, 26, 30 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 88, 1 },
                    { 2, 223, 2 },
                    { 3, 126, 3 },
                    { 4, 461, 4 },
                    { 5, 316, 5 },
                    { 6, 175, 6 },
                    { 7, 436, 7 },
                    { 8, 433, 8 },
                    { 9, 58, 9 },
                    { 10, 303, 10 },
                    { 11, 314, 11 },
                    { 12, 47, 12 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 13, 259, 13 },
                    { 14, 13, 14 },
                    { 15, 249, 15 },
                    { 16, 335, 16 },
                    { 17, 494, 17 },
                    { 18, 474, 18 },
                    { 19, 56, 19 },
                    { 20, 307, 20 },
                    { 21, 282, 21 },
                    { 22, 19, 22 },
                    { 23, 295, 23 },
                    { 24, 476, 24 },
                    { 25, 186, 25 },
                    { 26, 172, 26 },
                    { 27, 459, 27 },
                    { 28, 90, 28 },
                    { 29, 23, 29 },
                    { 30, 7, 30 },
                    { 31, 193, 31 },
                    { 32, 300, 32 },
                    { 33, 102, 33 },
                    { 34, 391, 34 },
                    { 35, 284, 35 },
                    { 36, 396, 36 },
                    { 37, 449, 37 },
                    { 38, 91, 38 },
                    { 39, 54, 39 },
                    { 40, 292, 40 },
                    { 41, 308, 41 },
                    { 42, 465, 42 },
                    { 43, 454, 43 },
                    { 44, 382, 44 },
                    { 45, 62, 45 },
                    { 46, 217, 46 },
                    { 47, 205, 47 },
                    { 48, 475, 48 },
                    { 49, 101, 49 },
                    { 50, 364, 50 },
                    { 51, 493, 51 },
                    { 52, 291, 52 },
                    { 53, 356, 53 },
                    { 54, 118, 54 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 55, 161, 55 },
                    { 56, 275, 56 },
                    { 57, 489, 57 },
                    { 58, 77, 58 },
                    { 59, 61, 59 },
                    { 60, 484, 60 },
                    { 61, 313, 61 },
                    { 62, 469, 62 },
                    { 63, 441, 63 },
                    { 64, 192, 64 },
                    { 65, 424, 65 },
                    { 66, 428, 66 },
                    { 67, 137, 67 },
                    { 68, 332, 68 },
                    { 69, 246, 69 },
                    { 70, 394, 70 },
                    { 71, 71, 71 },
                    { 72, 310, 72 },
                    { 73, 353, 73 },
                    { 74, 417, 74 },
                    { 75, 75, 75 },
                    { 76, 151, 76 },
                    { 77, 340, 77 },
                    { 78, 201, 78 },
                    { 79, 278, 79 },
                    { 80, 380, 80 },
                    { 81, 177, 81 },
                    { 82, 374, 82 },
                    { 83, 328, 83 },
                    { 84, 361, 84 },
                    { 85, 173, 85 },
                    { 86, 225, 86 },
                    { 87, 5, 87 },
                    { 88, 456, 88 },
                    { 89, 497, 89 },
                    { 90, 243, 90 },
                    { 91, 483, 91 },
                    { 92, 20, 92 },
                    { 93, 392, 93 },
                    { 94, 296, 94 },
                    { 95, 480, 95 },
                    { 96, 479, 96 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 97, 198, 97 },
                    { 98, 437, 98 },
                    { 99, 171, 99 },
                    { 100, 499, 100 },
                    { 101, 341, 101 },
                    { 102, 233, 102 },
                    { 103, 238, 103 },
                    { 104, 488, 104 },
                    { 105, 138, 105 },
                    { 106, 375, 106 },
                    { 107, 194, 107 },
                    { 108, 455, 108 },
                    { 109, 348, 109 },
                    { 110, 329, 110 },
                    { 111, 250, 111 },
                    { 112, 51, 112 },
                    { 113, 405, 113 },
                    { 114, 326, 114 },
                    { 115, 435, 115 },
                    { 116, 29, 116 },
                    { 117, 410, 117 },
                    { 118, 139, 118 },
                    { 119, 244, 119 },
                    { 120, 141, 120 },
                    { 121, 389, 121 },
                    { 122, 87, 122 },
                    { 123, 157, 123 },
                    { 124, 209, 124 },
                    { 125, 268, 125 },
                    { 126, 158, 126 },
                    { 127, 236, 127 },
                    { 128, 349, 128 },
                    { 129, 117, 129 },
                    { 130, 407, 130 },
                    { 131, 68, 131 },
                    { 132, 393, 132 },
                    { 133, 113, 133 },
                    { 134, 168, 134 },
                    { 135, 155, 135 },
                    { 136, 46, 136 },
                    { 137, 305, 137 },
                    { 138, 105, 138 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 139, 498, 139 },
                    { 140, 136, 140 },
                    { 141, 457, 141 },
                    { 142, 52, 142 },
                    { 143, 363, 143 },
                    { 144, 125, 144 },
                    { 145, 251, 145 },
                    { 146, 399, 146 },
                    { 147, 132, 147 },
                    { 148, 421, 148 },
                    { 149, 409, 149 },
                    { 150, 98, 150 },
                    { 151, 347, 151 },
                    { 152, 150, 152 },
                    { 153, 320, 153 },
                    { 154, 106, 154 },
                    { 155, 336, 155 },
                    { 156, 84, 156 },
                    { 157, 222, 157 },
                    { 158, 309, 158 },
                    { 159, 148, 159 },
                    { 160, 79, 160 },
                    { 161, 162, 161 },
                    { 162, 147, 162 },
                    { 163, 28, 163 },
                    { 164, 35, 164 },
                    { 165, 9, 165 },
                    { 166, 107, 166 },
                    { 167, 109, 167 },
                    { 168, 277, 168 },
                    { 169, 351, 169 },
                    { 170, 131, 170 },
                    { 171, 257, 171 },
                    { 172, 170, 172 },
                    { 173, 57, 173 },
                    { 174, 11, 174 },
                    { 175, 344, 175 },
                    { 176, 197, 176 },
                    { 177, 339, 177 },
                    { 178, 322, 178 },
                    { 179, 269, 179 },
                    { 180, 178, 180 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 181, 500, 181 },
                    { 182, 120, 182 },
                    { 183, 219, 183 },
                    { 184, 427, 184 },
                    { 185, 285, 185 },
                    { 186, 397, 186 },
                    { 187, 467, 187 },
                    { 188, 14, 188 },
                    { 189, 202, 189 },
                    { 190, 324, 190 },
                    { 191, 367, 191 },
                    { 192, 264, 192 },
                    { 193, 346, 193 },
                    { 194, 181, 194 },
                    { 195, 49, 195 },
                    { 196, 279, 196 },
                    { 197, 73, 197 },
                    { 198, 1, 198 },
                    { 199, 342, 199 },
                    { 200, 203, 200 },
                    { 201, 100, 201 },
                    { 202, 286, 202 },
                    { 203, 256, 203 },
                    { 204, 443, 204 },
                    { 205, 395, 205 },
                    { 206, 143, 206 },
                    { 207, 40, 207 },
                    { 208, 370, 208 },
                    { 209, 288, 209 },
                    { 210, 204, 210 },
                    { 211, 287, 211 },
                    { 212, 416, 212 },
                    { 213, 78, 213 },
                    { 214, 83, 214 },
                    { 215, 232, 215 },
                    { 216, 124, 216 },
                    { 217, 44, 217 },
                    { 218, 276, 218 },
                    { 219, 390, 219 },
                    { 220, 414, 220 },
                    { 221, 315, 221 },
                    { 222, 265, 222 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 223, 53, 223 },
                    { 224, 187, 224 },
                    { 225, 447, 225 },
                    { 226, 153, 226 },
                    { 227, 179, 227 },
                    { 228, 96, 228 },
                    { 229, 470, 229 },
                    { 230, 290, 230 },
                    { 231, 429, 231 },
                    { 232, 234, 232 },
                    { 233, 133, 233 },
                    { 234, 12, 234 },
                    { 235, 226, 235 },
                    { 236, 430, 236 },
                    { 237, 224, 237 },
                    { 238, 76, 238 },
                    { 239, 25, 239 },
                    { 240, 199, 240 },
                    { 241, 220, 241 },
                    { 242, 93, 242 },
                    { 243, 386, 243 },
                    { 244, 258, 244 },
                    { 245, 468, 245 },
                    { 246, 10, 246 },
                    { 247, 228, 247 },
                    { 248, 431, 248 },
                    { 249, 67, 249 },
                    { 250, 104, 250 },
                    { 251, 231, 251 },
                    { 252, 384, 252 },
                    { 253, 163, 253 },
                    { 254, 112, 254 },
                    { 255, 254, 255 },
                    { 256, 267, 256 },
                    { 257, 415, 257 },
                    { 258, 299, 258 },
                    { 259, 240, 259 },
                    { 260, 369, 260 },
                    { 261, 167, 261 },
                    { 262, 452, 262 },
                    { 263, 491, 263 },
                    { 264, 129, 264 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 265, 318, 265 },
                    { 266, 379, 266 },
                    { 267, 208, 267 },
                    { 268, 422, 268 },
                    { 269, 81, 269 },
                    { 270, 32, 270 },
                    { 271, 230, 271 },
                    { 272, 65, 272 },
                    { 273, 325, 273 },
                    { 274, 252, 274 },
                    { 275, 366, 275 },
                    { 276, 460, 276 },
                    { 277, 418, 277 },
                    { 278, 473, 278 },
                    { 279, 311, 279 },
                    { 280, 26, 280 },
                    { 281, 337, 281 },
                    { 282, 420, 282 },
                    { 283, 27, 283 },
                    { 284, 294, 284 },
                    { 285, 362, 285 },
                    { 286, 212, 286 },
                    { 287, 213, 287 },
                    { 288, 164, 288 },
                    { 289, 59, 289 },
                    { 290, 297, 290 },
                    { 291, 152, 291 },
                    { 292, 472, 292 },
                    { 293, 211, 293 },
                    { 294, 103, 294 },
                    { 295, 402, 295 },
                    { 296, 72, 296 },
                    { 297, 438, 297 },
                    { 298, 185, 298 },
                    { 299, 440, 299 },
                    { 300, 413, 300 },
                    { 301, 97, 301 },
                    { 302, 354, 302 },
                    { 303, 359, 303 },
                    { 304, 368, 304 },
                    { 305, 89, 305 },
                    { 306, 180, 306 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 307, 270, 307 },
                    { 308, 188, 308 },
                    { 309, 92, 309 },
                    { 310, 108, 310 },
                    { 311, 458, 311 },
                    { 312, 22, 312 },
                    { 313, 495, 313 },
                    { 314, 135, 314 },
                    { 315, 142, 315 },
                    { 316, 174, 316 },
                    { 317, 453, 317 },
                    { 318, 85, 318 },
                    { 319, 248, 319 },
                    { 320, 439, 320 },
                    { 321, 406, 321 },
                    { 322, 2, 322 },
                    { 323, 434, 323 },
                    { 324, 262, 324 },
                    { 325, 45, 325 },
                    { 326, 403, 326 },
                    { 327, 378, 327 },
                    { 328, 360, 328 },
                    { 329, 144, 329 },
                    { 330, 43, 330 },
                    { 331, 312, 331 },
                    { 332, 16, 332 },
                    { 333, 34, 333 },
                    { 334, 235, 334 },
                    { 335, 121, 335 },
                    { 336, 160, 336 },
                    { 337, 263, 337 },
                    { 338, 383, 338 },
                    { 339, 80, 339 },
                    { 340, 21, 340 },
                    { 341, 334, 341 },
                    { 342, 331, 342 },
                    { 343, 218, 343 },
                    { 344, 111, 344 },
                    { 345, 450, 345 },
                    { 346, 478, 346 },
                    { 347, 445, 347 },
                    { 348, 350, 348 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 349, 451, 349 },
                    { 350, 481, 350 },
                    { 351, 38, 351 },
                    { 352, 128, 352 },
                    { 353, 400, 353 },
                    { 354, 18, 354 },
                    { 355, 492, 355 },
                    { 356, 210, 356 },
                    { 357, 146, 357 },
                    { 358, 343, 358 },
                    { 359, 463, 359 },
                    { 360, 355, 360 },
                    { 361, 446, 361 },
                    { 362, 200, 362 },
                    { 363, 195, 363 },
                    { 364, 39, 364 },
                    { 365, 242, 365 },
                    { 366, 70, 366 },
                    { 367, 165, 367 },
                    { 368, 293, 368 },
                    { 369, 266, 369 },
                    { 370, 116, 370 },
                    { 371, 404, 371 },
                    { 372, 471, 372 },
                    { 373, 241, 373 },
                    { 374, 156, 374 },
                    { 375, 145, 375 },
                    { 376, 127, 376 },
                    { 377, 99, 377 },
                    { 378, 372, 378 },
                    { 379, 376, 379 },
                    { 380, 442, 380 },
                    { 381, 333, 381 },
                    { 382, 482, 382 },
                    { 383, 272, 383 },
                    { 384, 122, 384 },
                    { 385, 41, 385 },
                    { 386, 48, 386 },
                    { 387, 487, 387 },
                    { 388, 462, 388 },
                    { 389, 304, 389 },
                    { 390, 239, 390 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 391, 36, 391 },
                    { 392, 169, 392 },
                    { 393, 381, 393 },
                    { 394, 42, 394 },
                    { 395, 490, 395 },
                    { 396, 86, 396 },
                    { 397, 95, 397 },
                    { 398, 496, 398 },
                    { 399, 33, 399 },
                    { 400, 271, 400 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 1, 1, 381 },
                    { 2, 2, 477 },
                    { 3, 3, 145 },
                    { 4, 4, 404 },
                    { 5, 5, 454 },
                    { 6, 6, 61 },
                    { 7, 7, 186 },
                    { 8, 8, 65 },
                    { 9, 9, 244 },
                    { 10, 10, 264 },
                    { 11, 11, 68 },
                    { 12, 12, 222 },
                    { 13, 13, 89 },
                    { 14, 14, 185 },
                    { 15, 15, 149 },
                    { 16, 16, 90 },
                    { 17, 17, 369 },
                    { 18, 18, 41 },
                    { 19, 19, 274 },
                    { 20, 20, 237 },
                    { 21, 21, 165 },
                    { 22, 22, 252 },
                    { 23, 23, 33 },
                    { 24, 24, 82 },
                    { 25, 25, 207 },
                    { 26, 26, 400 },
                    { 27, 27, 177 },
                    { 28, 28, 395 },
                    { 29, 29, 487 },
                    { 30, 30, 31 },
                    { 31, 31, 103 },
                    { 32, 32, 273 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 33, 33, 326 },
                    { 34, 34, 482 },
                    { 35, 35, 450 },
                    { 36, 36, 468 },
                    { 37, 37, 500 },
                    { 38, 38, 337 },
                    { 39, 39, 122 },
                    { 40, 40, 421 },
                    { 41, 41, 132 },
                    { 42, 42, 317 },
                    { 43, 43, 444 },
                    { 44, 44, 320 },
                    { 45, 45, 417 },
                    { 46, 46, 465 },
                    { 47, 47, 414 },
                    { 48, 48, 271 },
                    { 49, 49, 424 },
                    { 50, 50, 192 },
                    { 51, 51, 175 },
                    { 52, 52, 141 },
                    { 53, 53, 115 },
                    { 54, 54, 128 },
                    { 55, 55, 6 },
                    { 56, 56, 345 },
                    { 57, 57, 284 },
                    { 58, 58, 474 },
                    { 59, 59, 333 },
                    { 60, 60, 87 },
                    { 61, 61, 48 },
                    { 62, 62, 367 },
                    { 63, 63, 448 },
                    { 64, 64, 153 },
                    { 65, 65, 219 },
                    { 66, 66, 389 },
                    { 67, 67, 318 },
                    { 68, 68, 147 },
                    { 69, 69, 362 },
                    { 70, 70, 25 },
                    { 71, 71, 105 },
                    { 72, 72, 228 },
                    { 73, 73, 411 },
                    { 74, 74, 313 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 75, 75, 69 },
                    { 76, 76, 27 },
                    { 77, 77, 471 },
                    { 78, 78, 57 },
                    { 79, 79, 394 },
                    { 80, 80, 37 },
                    { 81, 81, 227 },
                    { 82, 82, 303 },
                    { 83, 83, 488 },
                    { 84, 84, 73 },
                    { 85, 85, 368 },
                    { 86, 86, 184 },
                    { 87, 87, 239 },
                    { 88, 88, 259 },
                    { 89, 89, 364 },
                    { 90, 90, 173 },
                    { 91, 91, 439 },
                    { 92, 92, 99 },
                    { 93, 93, 76 },
                    { 94, 94, 293 },
                    { 95, 95, 220 },
                    { 96, 96, 339 },
                    { 97, 97, 485 },
                    { 98, 98, 456 },
                    { 99, 99, 159 },
                    { 100, 100, 475 },
                    { 101, 101, 312 },
                    { 102, 102, 440 },
                    { 103, 103, 195 },
                    { 104, 104, 13 },
                    { 105, 105, 366 },
                    { 106, 106, 464 },
                    { 107, 107, 205 },
                    { 108, 108, 382 },
                    { 109, 109, 486 },
                    { 110, 110, 348 },
                    { 111, 111, 106 },
                    { 112, 112, 287 },
                    { 113, 113, 84 },
                    { 114, 114, 435 },
                    { 115, 115, 110 },
                    { 116, 116, 255 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 117, 117, 152 },
                    { 118, 118, 292 },
                    { 119, 119, 462 },
                    { 120, 120, 96 },
                    { 121, 121, 391 },
                    { 122, 122, 325 },
                    { 123, 123, 308 },
                    { 124, 124, 161 },
                    { 125, 125, 458 },
                    { 126, 126, 127 },
                    { 127, 127, 376 },
                    { 128, 128, 28 },
                    { 129, 129, 437 },
                    { 130, 130, 22 },
                    { 131, 131, 189 },
                    { 132, 132, 384 },
                    { 133, 133, 385 },
                    { 134, 134, 160 },
                    { 135, 135, 221 },
                    { 136, 136, 176 },
                    { 137, 137, 347 },
                    { 138, 138, 67 },
                    { 139, 139, 428 },
                    { 140, 140, 256 },
                    { 141, 141, 257 },
                    { 142, 142, 316 },
                    { 143, 143, 19 },
                    { 144, 144, 419 },
                    { 145, 145, 459 },
                    { 146, 146, 498 },
                    { 147, 147, 240 },
                    { 148, 148, 267 },
                    { 149, 149, 75 },
                    { 150, 150, 352 },
                    { 151, 151, 38 },
                    { 152, 152, 314 },
                    { 153, 153, 146 },
                    { 154, 154, 353 },
                    { 155, 155, 470 },
                    { 156, 156, 218 },
                    { 157, 157, 224 },
                    { 158, 158, 156 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 159, 159, 409 },
                    { 160, 160, 372 },
                    { 161, 161, 355 },
                    { 162, 162, 429 },
                    { 163, 163, 143 },
                    { 164, 164, 178 },
                    { 165, 165, 397 },
                    { 166, 166, 15 },
                    { 167, 167, 371 },
                    { 168, 168, 134 },
                    { 169, 169, 311 },
                    { 170, 170, 250 },
                    { 171, 171, 114 },
                    { 172, 172, 408 },
                    { 173, 173, 83 },
                    { 174, 174, 341 },
                    { 175, 175, 126 },
                    { 176, 176, 225 },
                    { 177, 177, 157 },
                    { 178, 178, 198 },
                    { 179, 179, 150 },
                    { 180, 180, 310 },
                    { 181, 181, 349 },
                    { 182, 182, 102 },
                    { 183, 183, 467 },
                    { 184, 184, 140 },
                    { 185, 185, 463 },
                    { 186, 186, 59 },
                    { 187, 187, 344 },
                    { 188, 188, 24 },
                    { 189, 189, 373 },
                    { 190, 190, 300 },
                    { 191, 191, 430 },
                    { 192, 192, 58 },
                    { 193, 193, 451 },
                    { 194, 194, 187 },
                    { 195, 195, 342 },
                    { 196, 196, 3 },
                    { 197, 197, 193 },
                    { 198, 198, 52 },
                    { 199, 199, 46 },
                    { 200, 200, 36 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 201, 201, 331 },
                    { 202, 202, 425 },
                    { 203, 203, 108 },
                    { 204, 204, 329 },
                    { 205, 205, 258 },
                    { 206, 206, 260 },
                    { 207, 207, 288 },
                    { 208, 208, 413 },
                    { 209, 209, 14 },
                    { 210, 210, 72 },
                    { 211, 211, 286 },
                    { 212, 212, 18 },
                    { 213, 213, 226 },
                    { 214, 214, 49 },
                    { 215, 215, 34 },
                    { 216, 216, 201 },
                    { 217, 217, 206 },
                    { 218, 218, 492 },
                    { 219, 219, 130 },
                    { 220, 220, 268 },
                    { 221, 221, 171 },
                    { 222, 222, 179 },
                    { 223, 223, 121 },
                    { 224, 224, 111 },
                    { 225, 225, 422 },
                    { 226, 226, 120 },
                    { 227, 227, 81 },
                    { 228, 228, 20 },
                    { 229, 229, 281 },
                    { 230, 230, 16 },
                    { 231, 231, 88 },
                    { 232, 232, 197 },
                    { 233, 233, 183 },
                    { 234, 234, 269 },
                    { 235, 235, 263 },
                    { 236, 236, 473 },
                    { 237, 237, 484 },
                    { 238, 238, 304 },
                    { 239, 239, 133 },
                    { 240, 240, 494 },
                    { 241, 241, 360 },
                    { 242, 242, 452 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 243, 243, 11 },
                    { 244, 244, 289 },
                    { 245, 245, 330 },
                    { 246, 246, 351 },
                    { 247, 247, 403 },
                    { 248, 248, 290 },
                    { 249, 249, 295 },
                    { 250, 250, 254 },
                    { 251, 251, 50 },
                    { 252, 252, 322 },
                    { 253, 253, 445 },
                    { 254, 254, 80 },
                    { 255, 255, 251 },
                    { 256, 256, 301 },
                    { 257, 257, 100 },
                    { 258, 258, 95 },
                    { 259, 259, 359 },
                    { 260, 260, 202 },
                    { 261, 261, 379 },
                    { 262, 262, 10 },
                    { 263, 263, 407 },
                    { 264, 264, 9 },
                    { 265, 265, 180 },
                    { 266, 266, 460 },
                    { 267, 267, 363 },
                    { 268, 268, 354 },
                    { 269, 269, 415 },
                    { 270, 270, 365 },
                    { 271, 271, 151 },
                    { 272, 272, 196 },
                    { 273, 273, 297 },
                    { 274, 274, 248 },
                    { 275, 275, 215 },
                    { 276, 276, 431 },
                    { 277, 277, 188 },
                    { 278, 278, 278 },
                    { 279, 279, 203 },
                    { 280, 280, 35 },
                    { 281, 281, 104 },
                    { 282, 282, 62 },
                    { 283, 283, 323 },
                    { 284, 284, 386 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 285, 285, 392 },
                    { 286, 286, 438 },
                    { 287, 287, 135 },
                    { 288, 288, 29 },
                    { 289, 289, 283 },
                    { 290, 290, 461 },
                    { 291, 291, 191 },
                    { 292, 292, 137 },
                    { 293, 293, 71 },
                    { 294, 294, 8 },
                    { 295, 295, 398 },
                    { 296, 296, 383 },
                    { 297, 297, 139 },
                    { 298, 298, 479 },
                    { 299, 299, 309 },
                    { 300, 300, 336 },
                    { 301, 301, 446 },
                    { 302, 302, 306 },
                    { 303, 303, 208 },
                    { 304, 304, 324 },
                    { 305, 305, 113 },
                    { 306, 306, 136 },
                    { 307, 307, 30 },
                    { 308, 308, 119 },
                    { 309, 309, 390 },
                    { 310, 310, 335 },
                    { 311, 311, 131 },
                    { 312, 312, 74 },
                    { 313, 313, 91 },
                    { 314, 314, 93 },
                    { 315, 315, 396 },
                    { 316, 316, 5 },
                    { 317, 317, 23 },
                    { 318, 318, 78 },
                    { 319, 319, 242 },
                    { 320, 320, 377 },
                    { 321, 321, 117 },
                    { 322, 322, 490 },
                    { 323, 323, 469 },
                    { 324, 324, 436 },
                    { 325, 325, 144 },
                    { 326, 326, 416 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 327, 327, 272 },
                    { 328, 328, 168 },
                    { 329, 329, 266 },
                    { 330, 330, 182 },
                    { 331, 331, 209 },
                    { 332, 332, 499 },
                    { 333, 333, 21 },
                    { 334, 334, 163 },
                    { 335, 335, 375 },
                    { 336, 336, 315 },
                    { 337, 337, 374 },
                    { 338, 338, 401 },
                    { 339, 339, 77 },
                    { 340, 340, 217 },
                    { 341, 341, 327 },
                    { 342, 342, 481 },
                    { 343, 343, 491 },
                    { 344, 344, 158 },
                    { 345, 345, 489 },
                    { 346, 346, 441 },
                    { 347, 347, 234 },
                    { 348, 348, 275 },
                    { 349, 349, 233 },
                    { 350, 350, 265 },
                    { 351, 351, 406 },
                    { 352, 352, 402 },
                    { 353, 353, 442 },
                    { 354, 354, 332 },
                    { 355, 355, 455 },
                    { 356, 356, 433 },
                    { 357, 357, 17 },
                    { 358, 358, 223 },
                    { 359, 359, 370 },
                    { 360, 360, 97 },
                    { 361, 361, 378 },
                    { 362, 362, 328 },
                    { 363, 363, 47 },
                    { 364, 364, 434 },
                    { 365, 365, 170 },
                    { 366, 366, 253 },
                    { 367, 367, 280 },
                    { 368, 368, 230 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 369, 369, 42 },
                    { 370, 370, 380 },
                    { 371, 371, 164 },
                    { 372, 372, 319 },
                    { 373, 373, 169 },
                    { 374, 374, 235 },
                    { 375, 375, 1 },
                    { 376, 376, 453 },
                    { 377, 377, 246 },
                    { 378, 378, 423 },
                    { 379, 379, 98 },
                    { 380, 380, 261 },
                    { 381, 381, 66 },
                    { 382, 382, 51 },
                    { 383, 383, 26 },
                    { 384, 384, 181 },
                    { 385, 385, 231 },
                    { 386, 386, 277 },
                    { 387, 387, 262 },
                    { 388, 388, 118 },
                    { 389, 389, 236 },
                    { 390, 390, 343 },
                    { 391, 391, 291 },
                    { 392, 392, 279 },
                    { 393, 393, 241 },
                    { 394, 394, 70 },
                    { 395, 395, 418 },
                    { 396, 396, 211 },
                    { 397, 397, 247 },
                    { 398, 398, 116 },
                    { 399, 399, 276 },
                    { 400, 400, 497 }
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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 24);

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
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 60);

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
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 110);

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
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 176);

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
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 189);

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
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 207);

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
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 229);

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
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 261);

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
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 298);

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
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 388);

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
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 423);

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
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 486);

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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 32);

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
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 60);

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
                keyValue: 79);

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
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 101);

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
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 162);

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
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 190);

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
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 210);

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
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 334);

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
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 350);

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
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 420);

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
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 443);

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
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 496);

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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 7);

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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 29);

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
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 59);

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
                keyValue: 65);

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
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 71);

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
                keyValue: 75);

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
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 89);

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
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 96);

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
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 106);

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
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 113);

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
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 137);

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
                keyValue: 150);

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
                keyValue: 158);

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
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 163);

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
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 169);

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
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 181);

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
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 188);

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
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 202);

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
                keyValue: 208);

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
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 220);

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
                keyValue: 224);

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
                keyValue: 228);

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
                keyValue: 235);

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
                keyValue: 248);

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
                keyValue: 254);

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
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 259);

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
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 272);

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
                keyValue: 282);

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
                keyValue: 288);

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
                keyValue: 293);

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
                keyValue: 297);

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
                keyValue: 303);

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
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 309);

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
                keyValue: 312);

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
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 320);

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
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 326);

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
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 337);

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
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 354);

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
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 360);

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
                keyValue: 372);

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
                keyValue: 386);

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
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 407);

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
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 415);

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
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 421);

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
                keyValue: 431);

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
                keyValue: 436);

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
                keyValue: 445);

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
                keyValue: 455);

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
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 468);

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
                keyValue: 487);

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
                keyValue: 494);

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
                keyValue: 3);

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
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 42);

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
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 65);

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
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 71);

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
                keyValue: 74);

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
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 84);

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
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 96);

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
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 106);

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
                keyValue: 111);

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
                keyValue: 120);

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
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 156);

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
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 169);

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
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 180);

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
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 193);

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
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 206);

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
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 215);

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
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 225);

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
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 234);

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
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 240);

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
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 255);

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
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 264);

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
                keyValue: 274);

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
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 284);

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
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 301);

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
                keyValue: 306);

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
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 313);

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
                keyValue: 322);

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
                keyValue: 325);

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
                keyValue: 339);

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
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 345);

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
                keyValue: 349);

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
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 371);

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
                keyValue: 374);

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
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 384);

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
                keyValue: 389);

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
                keyValue: 392);

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
                keyValue: 400);

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
                keyValue: 404);

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
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 411);

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
                keyValue: 428);

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
                keyValue: 431);

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
                keyValue: 435);

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
                keyValue: 439);

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
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 450);

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
                keyValue: 458);

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
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 467);

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
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 471);

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
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 479);

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
                keyValue: 490);

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
                keyValue: 494);

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
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 500);

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
                keyValue: new Guid("053d48ab-3f0a-433d-b5c6-e2eca6c813d6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("05adcb80-5b78-420b-b70a-3017939eb85c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("064e2294-6cf0-4371-9300-7a5376a2db27"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("075ef475-0520-41cc-ab52-178b0221640e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0a786ecd-652c-4420-88bb-031d61daf0ab"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0db64e2c-28e0-42d7-a1c7-709e2b351672"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0ef1e9bd-eb68-4be6-98d9-934379a35537"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("100bb356-48f9-4f57-8c07-9f489c1a05fe"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("128b029f-b364-4cd1-9486-d36bdf2552f0"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1465b447-1227-43ea-bcc9-0a1056c7f12c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("15ee4e40-5672-4ab8-9ebf-e0ee61335dc4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("17384934-e7e4-4225-89fa-9b4d34bcd276"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("179ac0de-306b-47de-abf3-f619ec367085"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1fc40999-852f-4645-bf8c-0838d321b1ff"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("221f5506-2d87-429e-a621-c042bdbe369c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2642f89b-a8b2-4d10-87bf-280120db87b8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("28552ffc-9302-4942-aa22-82654eeb5fba"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("29f9d1e0-eb11-45b8-80ca-1e48747f5ba7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2a31125c-86b0-4c3c-af5f-72b9bf070104"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3230dea4-e05a-41ad-8542-23f50b4357fb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("33d661bc-3d32-41d3-9219-43365ed49af8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("35651dbd-c89e-44dc-b5f6-a980177b7740"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3cd3eb29-b09d-466f-878c-984e2a22d0ea"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3f90a46a-af5d-4dab-96bf-5639d6829640"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4307075b-d195-449f-b670-e64f49be87ba"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("438ba30a-00d4-4181-a8c1-6d2bcf08a4dd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("44ff4700-4231-483d-8594-6799ffc367f6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("46b8e731-65cc-445a-9c0e-e51ee1f4d832"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4b06f816-04be-4e78-b274-50b4528bf4e6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4b50fa2b-6155-40c0-8329-bbc00b998ed9"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4bac4693-f3b0-46e5-97f0-c477df52ae98"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4cc01565-65b0-45aa-9bba-78c8292b9ac3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4f714b8b-7783-41ec-9367-9a06af8b6c42"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("52af031b-329a-4f55-a6d5-bf7da18deab3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("53035ed9-2940-4227-9b55-92e68f6368a2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5316c483-af1c-4382-ae1d-3611b1f2901d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("53839b70-e2c2-4864-9c9c-4a26da3f9408"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("54cc0a99-564f-4c34-b341-bb9c5ab830df"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("56948dc2-1c73-45a3-ba06-fc8839dc0ec8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("570f9518-4e15-4360-85a2-d57a673a6eb4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("572f86c0-a281-4aa1-9512-483f4559139b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5a0508bd-c792-453b-9439-3a3ab3c25e9f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5e7c4193-eaac-44f7-ac14-00f8c82f2da3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("652e38c4-c04c-4bde-9d9d-a10ea852ad94"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("65f439b4-3ded-42d4-8e8b-b4be207c740c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6cc32896-9ffc-4b9e-a7aa-ddb50fcb7215"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6d15221d-e4d7-4edd-bc5e-e1f52b8823c0"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6d647543-7e6d-4530-86fa-8fb83f308a6d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6ec7db2a-250a-4fb1-b65a-00116e9c91d1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("740dda5a-2082-4f78-b78d-4af59ae76bee"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7800ad41-297f-470b-986d-8e4d2c79917e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7930fb51-4c8b-4574-960f-72ec2ee6ba4d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7a82ad8a-5c3a-41c1-accc-4510a0927879"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7aa8437d-fa96-4b88-9fc9-b6b373f3dea1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("80803981-0e13-4c33-9d5f-da6265bf972d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("81d8b2c8-83e6-4a42-8393-6c04858d611f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8459c8da-a8c1-4c58-8d0e-5c2c837b751a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("90ebefef-4de3-4e33-9111-a43154fb1e11"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9234c070-d674-4c1e-8c69-efee882f6a0e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9298b336-e13c-40ea-990d-dab16e54d80f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("930fb85a-9332-45f0-be07-c60f767421c3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("93e9c2ac-08aa-4212-9c5c-ae6acf49e213"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("955c7e45-8ed5-4fb6-abef-8fe7afc0a97f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("95786e1e-c62c-4a2a-a249-b11391bd42b8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("95bfe5c9-a121-4caa-9756-af659ae3b5da"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("97c9e838-c71c-4c73-b2c0-caf745656350"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9840b515-74f0-4af0-b950-92055db7fa99"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9c3586b9-1042-47a6-bd60-45f4e3a8a422"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a287abd0-618d-4f37-a3aa-c79a05711693"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a78b675b-8b6e-4750-ba39-c33446fdac2f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("acd26182-8824-4e61-9ced-d4b968d1b53c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b1e34501-ac7a-4b05-9328-43a275f4d894"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b92c898d-241b-4cea-b325-33bd343d06f6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bb2d6254-71b3-48c6-b066-2b0a1a7b925b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bcfdeee4-28f2-4020-95f9-8120bef59645"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c129bef7-2959-4a79-b9a8-65c37aed6b37"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c77add7d-ed5f-4daa-8225-c831a7b424f0"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c7838ab6-f0ac-4db1-9252-45ab4905aff1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("cf8e37ae-b030-4b9b-bc1b-f34aee00e996"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d15554bf-18f0-43f0-997c-b4a1f9cc7570"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d1e7ef41-15ce-40bb-b375-5e722a5c483e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d2a60d32-0a0d-4545-8faa-6494a33b89f5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d411a643-fd17-4aa2-9795-607018c2ffa6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d535e730-2d14-49b6-b7da-a277ee86713a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d5389b35-c4e3-4d3b-9c72-d716e46d3830"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d6fca11a-e34c-4aed-bc71-ebfa275bcc13"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d77afef3-729c-46f9-8a56-794aab7fb9ad"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("db330ce2-f725-47d0-9d62-9b3bd91fc3d3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("dca377e5-0598-43ba-85e5-58ea6b1f94a4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("dd68091d-0cae-4faa-b144-482d85dd5e45"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e17832f8-11a1-41ee-9e46-f86393977cff"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e27aa0db-b07b-4f30-a00e-cc8c7cdeab92"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e55c3e3d-d664-43d4-bdb0-ecf25d91fbba"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e8d35d45-24d4-4c67-b405-a021daf7daab"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ec8ae142-b187-4020-b5ad-dfce0a11ec10"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f023370d-5c52-40a0-9be4-d1033c60ef45"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f0f2ea50-0e34-442c-9229-97432d23425c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f3682427-4fe6-4c41-81ec-dfc32ca9ef29"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f36b00b5-0cca-4560-8a39-fdbe3f25a613"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fe31b758-6604-42f1-88cb-513e73dbe7db"));

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
