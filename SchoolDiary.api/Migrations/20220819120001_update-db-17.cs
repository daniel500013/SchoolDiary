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

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 6);

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
                    { 1, 1, 1, "English" },
                    { 2, 1, 2, "Math" },
                    { 3, 1, 3, "PE" },
                    { 4, 1, 4, "English" },
                    { 5, 1, 5, "Math" },
                    { 6, 1, 6, "History" },
                    { 7, 1, 7, "Chemistry" },
                    { 8, 1, 8, "PE" },
                    { 9, 2, 1, "Geography" },
                    { 10, 2, 2, "Chemistry" },
                    { 11, 2, 3, "History" },
                    { 12, 2, 4, "PE" },
                    { 13, 2, 5, "PE" },
                    { 14, 2, 6, "PE" },
                    { 15, 2, 7, "Math" },
                    { 16, 2, 8, "Polish" },
                    { 17, 3, 1, "Physics" },
                    { 18, 3, 2, "Geography" },
                    { 19, 3, 3, "Geography" },
                    { 20, 3, 4, "Math" },
                    { 21, 3, 5, "English" },
                    { 22, 3, 6, "Polish" },
                    { 23, 3, 7, "Geography" },
                    { 24, 3, 8, "Physics" },
                    { 25, 4, 1, "PE" },
                    { 26, 4, 2, "Physics" },
                    { 27, 4, 3, "Chemistry" },
                    { 28, 4, 4, "Polish" },
                    { 29, 4, 5, "Chemistry" },
                    { 30, 4, 6, "PE" },
                    { 31, 4, 7, "Polish" },
                    { 32, 4, 8, "History" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 33, 5, 1, "History" },
                    { 34, 5, 2, "PE" },
                    { 35, 5, 3, "English" },
                    { 36, 5, 4, "Chemistry" },
                    { 37, 5, 5, "Geography" },
                    { 38, 5, 6, "Polish" },
                    { 39, 5, 7, "Polish" },
                    { 40, 5, 8, "Math" },
                    { 41, 1, 1, "Polish" },
                    { 42, 1, 2, "English" },
                    { 43, 1, 3, "Geography" },
                    { 44, 1, 4, "Math" },
                    { 45, 1, 5, "Polish" },
                    { 46, 1, 6, "Physics" },
                    { 47, 1, 7, "English" },
                    { 48, 1, 8, "Physics" },
                    { 49, 2, 1, "Geography" },
                    { 50, 2, 2, "Chemistry" },
                    { 51, 2, 3, "History" },
                    { 52, 2, 4, "Physics" },
                    { 53, 2, 5, "Physics" },
                    { 54, 2, 6, "Polish" },
                    { 55, 2, 7, "Chemistry" },
                    { 56, 2, 8, "Math" },
                    { 57, 3, 1, "Geography" },
                    { 58, 3, 2, "English" },
                    { 59, 3, 3, "Polish" },
                    { 60, 3, 4, "Chemistry" },
                    { 61, 3, 5, "PE" },
                    { 62, 3, 6, "Physics" },
                    { 63, 3, 7, "Polish" },
                    { 64, 3, 8, "History" },
                    { 65, 4, 1, "Polish" },
                    { 66, 4, 2, "English" },
                    { 67, 4, 3, "PE" },
                    { 68, 4, 4, "Polish" },
                    { 69, 4, 5, "Polish" },
                    { 70, 4, 6, "Polish" },
                    { 71, 4, 7, "Physics" },
                    { 72, 4, 8, "Chemistry" },
                    { 73, 5, 1, "Chemistry" },
                    { 74, 5, 2, "Polish" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 75, 5, 3, "Chemistry" },
                    { 76, 5, 4, "Math" },
                    { 77, 5, 5, "Physics" },
                    { 78, 5, 6, "History" },
                    { 79, 5, 7, "History" },
                    { 80, 5, 8, "Geography" },
                    { 81, 1, 1, "History" },
                    { 82, 1, 2, "English" },
                    { 83, 1, 3, "Physics" },
                    { 84, 1, 4, "PE" },
                    { 85, 1, 5, "History" },
                    { 86, 1, 6, "Polish" },
                    { 87, 1, 7, "Physics" },
                    { 88, 1, 8, "Chemistry" },
                    { 89, 2, 1, "English" },
                    { 90, 2, 2, "English" },
                    { 91, 2, 3, "Polish" },
                    { 92, 2, 4, "PE" },
                    { 93, 2, 5, "PE" },
                    { 94, 2, 6, "Physics" },
                    { 95, 2, 7, "Physics" },
                    { 96, 2, 8, "Math" },
                    { 97, 3, 1, "History" },
                    { 98, 3, 2, "PE" },
                    { 99, 3, 3, "English" },
                    { 100, 3, 4, "Polish" },
                    { 101, 3, 5, "Geography" },
                    { 102, 3, 6, "Geography" },
                    { 103, 3, 7, "Geography" },
                    { 104, 3, 8, "PE" },
                    { 105, 4, 1, "English" },
                    { 106, 4, 2, "Physics" },
                    { 107, 4, 3, "English" },
                    { 108, 4, 4, "Geography" },
                    { 109, 4, 5, "PE" },
                    { 110, 4, 6, "Math" },
                    { 111, 4, 7, "Math" },
                    { 112, 4, 8, "Physics" },
                    { 113, 5, 1, "Chemistry" },
                    { 114, 5, 2, "Math" },
                    { 115, 5, 3, "English" },
                    { 116, 5, 4, "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 117, 5, 5, "English" },
                    { 118, 5, 6, "PE" },
                    { 119, 5, 7, "Math" },
                    { 120, 5, 8, "Chemistry" },
                    { 121, 1, 1, "PE" },
                    { 122, 1, 2, "Polish" },
                    { 123, 1, 3, "Math" },
                    { 124, 1, 4, "Math" },
                    { 125, 1, 5, "Math" },
                    { 126, 1, 6, "Polish" },
                    { 127, 1, 7, "Chemistry" },
                    { 128, 1, 8, "PE" },
                    { 129, 2, 1, "Geography" },
                    { 130, 2, 2, "English" },
                    { 131, 2, 3, "History" },
                    { 132, 2, 4, "Geography" },
                    { 133, 2, 5, "PE" },
                    { 134, 2, 6, "Chemistry" },
                    { 135, 2, 7, "Chemistry" },
                    { 136, 2, 8, "Chemistry" },
                    { 137, 3, 1, "PE" },
                    { 138, 3, 2, "PE" },
                    { 139, 3, 3, "English" },
                    { 140, 3, 4, "Math" },
                    { 141, 3, 5, "Physics" },
                    { 142, 3, 6, "Math" },
                    { 143, 3, 7, "English" },
                    { 144, 3, 8, "English" },
                    { 145, 4, 1, "Geography" },
                    { 146, 4, 2, "PE" },
                    { 147, 4, 3, "Chemistry" },
                    { 148, 4, 4, "PE" },
                    { 149, 4, 5, "Math" },
                    { 150, 4, 6, "History" },
                    { 151, 4, 7, "Math" },
                    { 152, 4, 8, "PE" },
                    { 153, 5, 1, "English" },
                    { 154, 5, 2, "PE" },
                    { 155, 5, 3, "Chemistry" },
                    { 156, 5, 4, "Physics" },
                    { 157, 5, 5, "English" },
                    { 158, 5, 6, "Math" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 159, 5, 7, "Polish" },
                    { 160, 5, 8, "History" },
                    { 161, 1, 1, "Chemistry" },
                    { 162, 1, 2, "Chemistry" },
                    { 163, 1, 3, "Chemistry" },
                    { 164, 1, 4, "Polish" },
                    { 165, 1, 5, "PE" },
                    { 166, 1, 6, "Physics" },
                    { 167, 1, 7, "Math" },
                    { 168, 1, 8, "Math" },
                    { 169, 2, 1, "History" },
                    { 170, 2, 2, "English" },
                    { 171, 2, 3, "Math" },
                    { 172, 2, 4, "Geography" },
                    { 173, 2, 5, "History" },
                    { 174, 2, 6, "Geography" },
                    { 175, 2, 7, "Geography" },
                    { 176, 2, 8, "PE" },
                    { 177, 3, 1, "Geography" },
                    { 178, 3, 2, "Physics" },
                    { 179, 3, 3, "History" },
                    { 180, 3, 4, "Geography" },
                    { 181, 3, 5, "Math" },
                    { 182, 3, 6, "PE" },
                    { 183, 3, 7, "Geography" },
                    { 184, 3, 8, "Physics" },
                    { 185, 4, 1, "English" },
                    { 186, 4, 2, "Geography" },
                    { 187, 4, 3, "English" },
                    { 188, 4, 4, "English" },
                    { 189, 4, 5, "Geography" },
                    { 190, 4, 6, "Geography" },
                    { 191, 4, 7, "Math" },
                    { 192, 4, 8, "Math" },
                    { 193, 5, 1, "Polish" },
                    { 194, 5, 2, "Chemistry" },
                    { 195, 5, 3, "Polish" },
                    { 196, 5, 4, "Math" },
                    { 197, 5, 5, "PE" },
                    { 198, 5, 6, "Geography" },
                    { 199, 5, 7, "Math" },
                    { 200, 5, 8, "History" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 201, 1, 1, "Chemistry" },
                    { 202, 1, 2, "PE" },
                    { 203, 1, 3, "PE" },
                    { 204, 1, 4, "Math" },
                    { 205, 1, 5, "PE" },
                    { 206, 1, 6, "PE" },
                    { 207, 1, 7, "English" },
                    { 208, 1, 8, "Polish" },
                    { 209, 2, 1, "Math" },
                    { 210, 2, 2, "Chemistry" },
                    { 211, 2, 3, "Math" },
                    { 212, 2, 4, "Physics" },
                    { 213, 2, 5, "Polish" },
                    { 214, 2, 6, "Math" },
                    { 215, 2, 7, "Physics" },
                    { 216, 2, 8, "Chemistry" },
                    { 217, 3, 1, "Math" },
                    { 218, 3, 2, "Math" },
                    { 219, 3, 3, "Chemistry" },
                    { 220, 3, 4, "Math" },
                    { 221, 3, 5, "English" },
                    { 222, 3, 6, "Chemistry" },
                    { 223, 3, 7, "English" },
                    { 224, 3, 8, "PE" },
                    { 225, 4, 1, "Math" },
                    { 226, 4, 2, "History" },
                    { 227, 4, 3, "PE" },
                    { 228, 4, 4, "Math" },
                    { 229, 4, 5, "Polish" },
                    { 230, 4, 6, "Math" },
                    { 231, 4, 7, "Geography" },
                    { 232, 4, 8, "Math" },
                    { 233, 5, 1, "Chemistry" },
                    { 234, 5, 2, "Polish" },
                    { 235, 5, 3, "Geography" },
                    { 236, 5, 4, "History" },
                    { 237, 5, 5, "English" },
                    { 238, 5, 6, "PE" },
                    { 239, 5, 7, "Geography" },
                    { 240, 5, 8, "Math" },
                    { 241, 1, 1, "Physics" },
                    { 242, 1, 2, "Chemistry" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 243, 1, 3, "History" },
                    { 244, 1, 4, "Math" },
                    { 245, 1, 5, "Chemistry" },
                    { 246, 1, 6, "Chemistry" },
                    { 247, 1, 7, "History" },
                    { 248, 1, 8, "Polish" },
                    { 249, 2, 1, "Polish" },
                    { 250, 2, 2, "Physics" },
                    { 251, 2, 3, "History" },
                    { 252, 2, 4, "Math" },
                    { 253, 2, 5, "Chemistry" },
                    { 254, 2, 6, "Geography" },
                    { 255, 2, 7, "Math" },
                    { 256, 2, 8, "PE" },
                    { 257, 3, 1, "Chemistry" },
                    { 258, 3, 2, "English" },
                    { 259, 3, 3, "Math" },
                    { 260, 3, 4, "Polish" },
                    { 261, 3, 5, "Chemistry" },
                    { 262, 3, 6, "PE" },
                    { 263, 3, 7, "History" },
                    { 264, 3, 8, "History" },
                    { 265, 4, 1, "Chemistry" },
                    { 266, 4, 2, "Polish" },
                    { 267, 4, 3, "Math" },
                    { 268, 4, 4, "Physics" },
                    { 269, 4, 5, "Polish" },
                    { 270, 4, 6, "History" },
                    { 271, 4, 7, "English" },
                    { 272, 4, 8, "Polish" },
                    { 273, 5, 1, "History" },
                    { 274, 5, 2, "History" },
                    { 275, 5, 3, "Polish" },
                    { 276, 5, 4, "PE" },
                    { 277, 5, 5, "Physics" },
                    { 278, 5, 6, "Math" },
                    { 279, 5, 7, "PE" },
                    { 280, 5, 8, "Physics" },
                    { 281, 1, 1, "Geography" },
                    { 282, 1, 2, "Physics" },
                    { 283, 1, 3, "PE" },
                    { 284, 1, 4, "History" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 285, 1, 5, "Geography" },
                    { 286, 1, 6, "Physics" },
                    { 287, 1, 7, "Geography" },
                    { 288, 1, 8, "Polish" },
                    { 289, 2, 1, "PE" },
                    { 290, 2, 2, "Physics" },
                    { 291, 2, 3, "English" },
                    { 292, 2, 4, "Physics" },
                    { 293, 2, 5, "English" },
                    { 294, 2, 6, "History" },
                    { 295, 2, 7, "History" },
                    { 296, 2, 8, "Polish" },
                    { 297, 3, 1, "Physics" },
                    { 298, 3, 2, "Physics" },
                    { 299, 3, 3, "Chemistry" },
                    { 300, 3, 4, "History" },
                    { 301, 3, 5, "English" },
                    { 302, 3, 6, "Math" },
                    { 303, 3, 7, "Math" },
                    { 304, 3, 8, "Physics" },
                    { 305, 4, 1, "Geography" },
                    { 306, 4, 2, "Physics" },
                    { 307, 4, 3, "History" },
                    { 308, 4, 4, "Polish" },
                    { 309, 4, 5, "Chemistry" },
                    { 310, 4, 6, "Polish" },
                    { 311, 4, 7, "English" },
                    { 312, 4, 8, "Polish" },
                    { 313, 5, 1, "English" },
                    { 314, 5, 2, "Chemistry" },
                    { 315, 5, 3, "Chemistry" },
                    { 316, 5, 4, "Polish" },
                    { 317, 5, 5, "Geography" },
                    { 318, 5, 6, "History" },
                    { 319, 5, 7, "History" },
                    { 320, 5, 8, "PE" },
                    { 321, 1, 1, "Math" },
                    { 322, 1, 2, "Chemistry" },
                    { 323, 1, 3, "Chemistry" },
                    { 324, 1, 4, "Geography" },
                    { 325, 1, 5, "PE" },
                    { 326, 1, 6, "Chemistry" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 327, 1, 7, "English" },
                    { 328, 1, 8, "Math" },
                    { 329, 2, 1, "Polish" },
                    { 330, 2, 2, "Geography" },
                    { 331, 2, 3, "Chemistry" },
                    { 332, 2, 4, "English" },
                    { 333, 2, 5, "Physics" },
                    { 334, 2, 6, "English" },
                    { 335, 2, 7, "Geography" },
                    { 336, 2, 8, "Physics" },
                    { 337, 3, 1, "Chemistry" },
                    { 338, 3, 2, "Physics" },
                    { 339, 3, 3, "History" },
                    { 340, 3, 4, "Chemistry" },
                    { 341, 3, 5, "Chemistry" },
                    { 342, 3, 6, "Chemistry" },
                    { 343, 3, 7, "Polish" },
                    { 344, 3, 8, "History" },
                    { 345, 4, 1, "History" },
                    { 346, 4, 2, "Polish" },
                    { 347, 4, 3, "Math" },
                    { 348, 4, 4, "Geography" },
                    { 349, 4, 5, "PE" },
                    { 350, 4, 6, "English" },
                    { 351, 4, 7, "Math" },
                    { 352, 4, 8, "Polish" },
                    { 353, 5, 1, "Math" },
                    { 354, 5, 2, "PE" },
                    { 355, 5, 3, "English" },
                    { 356, 5, 4, "PE" },
                    { 357, 5, 5, "English" },
                    { 358, 5, 6, "Chemistry" },
                    { 359, 5, 7, "Geography" },
                    { 360, 5, 8, "PE" },
                    { 361, 1, 1, "PE" },
                    { 362, 1, 2, "Polish" },
                    { 363, 1, 3, "English" },
                    { 364, 1, 4, "English" },
                    { 365, 1, 5, "English" },
                    { 366, 1, 6, "English" },
                    { 367, 1, 7, "English" },
                    { 368, 1, 8, "English" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 369, 2, 1, "Math" },
                    { 370, 2, 2, "Polish" },
                    { 371, 2, 3, "English" },
                    { 372, 2, 4, "Physics" },
                    { 373, 2, 5, "Geography" },
                    { 374, 2, 6, "English" },
                    { 375, 2, 7, "History" },
                    { 376, 2, 8, "Physics" },
                    { 377, 3, 1, "PE" },
                    { 378, 3, 2, "Polish" },
                    { 379, 3, 3, "English" },
                    { 380, 3, 4, "Polish" },
                    { 381, 3, 5, "PE" },
                    { 382, 3, 6, "Polish" },
                    { 383, 3, 7, "Math" },
                    { 384, 3, 8, "Physics" },
                    { 385, 4, 1, "English" },
                    { 386, 4, 2, "Chemistry" },
                    { 387, 4, 3, "Physics" },
                    { 388, 4, 4, "Math" },
                    { 389, 4, 5, "PE" },
                    { 390, 4, 6, "Geography" },
                    { 391, 4, 7, "PE" },
                    { 392, 4, 8, "Polish" },
                    { 393, 5, 1, "Geography" },
                    { 394, 5, 2, "Geography" },
                    { 395, 5, 3, "Math" },
                    { 396, 5, 4, "Polish" },
                    { 397, 5, 5, "English" },
                    { 398, 5, 6, "English" },
                    { 399, 5, 7, "Chemistry" },
                    { 400, 5, 8, "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Randall.Welch0@gmail.com", "Randall", "Welch", "694.537.5185 x56577" },
                    { 2, "Keith.Murazik38@hotmail.com", "Keith", "Murazik", "1-741-251-1602" },
                    { 3, "Angel_Durgan@gmail.com", "Angel", "Durgan", "652-244-3833 x630" },
                    { 4, "Bennie12@yahoo.com", "Bennie", "Erdman", "504-906-0708 x9693" },
                    { 5, "Roberto_Konopelski@yahoo.com", "Roberto", "Konopelski", "(273) 765-6192 x171" },
                    { 6, "Stuart.Jaskolski36@gmail.com", "Stuart", "Jaskolski", "1-410-547-0390 x528" },
                    { 7, "Scott_Emmerich@hotmail.com", "Scott", "Emmerich", "385.444.5404 x7383" },
                    { 8, "Jenna56@yahoo.com", "Jenna", "Stroman", "1-652-494-5449 x86075" },
                    { 9, "Oscar8@gmail.com", "Oscar", "Schiller", "590-319-0684 x1780" },
                    { 10, "Mary.Kemmer@yahoo.com", "Mary", "Kemmer", "(688) 284-5866 x8926" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 11, "Vincent_Hermiston65@gmail.com", "Vincent", "Hermiston", "1-479-217-6846" },
                    { 12, "Dawn_Prosacco@yahoo.com", "Dawn", "Prosacco", "291.325.9062 x935" },
                    { 13, "Sarah41@yahoo.com", "Sarah", "Bogan", "(811) 769-5076 x0943" },
                    { 14, "Billy68@yahoo.com", "Billy", "Williamson", "823.741.6769 x6992" },
                    { 15, "Doris.Walsh@yahoo.com", "Doris", "Walsh", "664.788.0585 x0363" },
                    { 16, "Robin.Nikolaus25@hotmail.com", "Robin", "Nikolaus", "(377) 924-9309 x6716" },
                    { 17, "Miranda.Oberbrunner46@yahoo.com", "Miranda", "Oberbrunner", "563.394.6701 x34794" },
                    { 18, "Ruth_Jacobi@gmail.com", "Ruth", "Jacobi", "(867) 621-1298 x700" },
                    { 19, "Tara.White42@yahoo.com", "Tara", "White", "(937) 676-9323" },
                    { 20, "Perry7@hotmail.com", "Perry", "Brown", "640-931-7508 x623" },
                    { 21, "Joanne_Stokes@yahoo.com", "Joanne", "Stokes", "369.228.5170" },
                    { 22, "Wilbur.DAmore@gmail.com", "Wilbur", "D'Amore", "(763) 212-6808 x45117" },
                    { 23, "Traci.Ward@hotmail.com", "Traci", "Ward", "247-237-5143 x523" },
                    { 24, "Michael65@hotmail.com", "Michael", "Goldner", "545-333-7481 x58620" },
                    { 25, "Wm57@gmail.com", "Wm", "Hartmann", "747-269-0433 x41554" },
                    { 26, "Nichole4@hotmail.com", "Nichole", "Hane", "(563) 846-6532 x7769" },
                    { 27, "Charlene_Breitenberg@yahoo.com", "Charlene", "Breitenberg", "1-683-664-0351 x8168" },
                    { 28, "Wallace_Schimmel62@hotmail.com", "Wallace", "Schimmel", "244-798-6488 x60402" },
                    { 29, "Lucas.Monahan@gmail.com", "Lucas", "Monahan", "534.776.7426" },
                    { 30, "Orville.Cronin@gmail.com", "Orville", "Cronin", "1-874-363-6209" },
                    { 31, "Krystal_Daniel@gmail.com", "Krystal", "Daniel", "842-582-2704 x149" },
                    { 32, "Verna_Crooks80@gmail.com", "Verna", "Crooks", "1-337-702-5899 x821" },
                    { 33, "Joe.Flatley@yahoo.com", "Joe", "Flatley", "233.488.8815 x4102" },
                    { 34, "Yvonne.Connelly@yahoo.com", "Yvonne", "Connelly", "878.321.5888" },
                    { 35, "Jodi_Waters76@yahoo.com", "Jodi", "Waters", "(661) 421-8514 x129" },
                    { 36, "Sherman_Walker40@hotmail.com", "Sherman", "Walker", "(224) 318-2728" },
                    { 37, "Melody_Kiehn@yahoo.com", "Melody", "Kiehn", "325-783-1725 x81315" },
                    { 38, "Diane.Dibbert66@yahoo.com", "Diane", "Dibbert", "(496) 773-4135 x202" },
                    { 39, "Kyle.Kirlin@hotmail.com", "Kyle", "Kirlin", "921-390-5300" },
                    { 40, "Leticia8@yahoo.com", "Leticia", "Kilback", "463.383.9471 x1818" },
                    { 41, "Noah.Schulist88@gmail.com", "Noah", "Schulist", "344-607-2478 x508" },
                    { 42, "Jeannie90@yahoo.com", "Jeannie", "Koelpin", "(405) 645-4034" },
                    { 43, "Alison.Braun@gmail.com", "Alison", "Braun", "(989) 623-6972 x2688" },
                    { 44, "May15@hotmail.com", "May", "Feeney", "423.837.1578 x720" },
                    { 45, "Luz.Hermann@hotmail.com", "Luz", "Hermann", "(240) 518-7068" },
                    { 46, "Shawn12@gmail.com", "Shawn", "Lockman", "965.651.3667" },
                    { 47, "Donna45@gmail.com", "Donna", "Torp", "(990) 660-1612 x43520" },
                    { 48, "Seth_Zulauf94@yahoo.com", "Seth", "Zulauf", "512-423-2028" },
                    { 49, "Madeline53@hotmail.com", "Madeline", "Abshire", "(213) 243-7957 x443" },
                    { 50, "Tabitha93@hotmail.com", "Tabitha", "Hyatt", "1-275-525-8271 x7738" },
                    { 51, "Marcus_Blanda@hotmail.com", "Marcus", "Blanda", "(962) 455-2325 x303" },
                    { 52, "Joseph_Howell@yahoo.com", "Joseph", "Howell", "1-621-808-3485 x55503" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 53, "Audrey93@hotmail.com", "Audrey", "Feest", "261-574-8699" },
                    { 54, "Dale.Langworth@hotmail.com", "Dale", "Langworth", "1-583-635-3245" },
                    { 55, "Ellis_Schmidt2@yahoo.com", "Ellis", "Schmidt", "384-598-5488" },
                    { 56, "Marcella_Sipes@yahoo.com", "Marcella", "Sipes", "1-827-856-6196 x89409" },
                    { 57, "Terence0@gmail.com", "Terence", "Grant", "244-685-8270" },
                    { 58, "Bruce.Beatty36@gmail.com", "Bruce", "Beatty", "525-556-3894 x302" },
                    { 59, "Veronica.Herman@gmail.com", "Veronica", "Herman", "(541) 241-0576 x86758" },
                    { 60, "Lynda_Mayert@hotmail.com", "Lynda", "Mayert", "983-378-8849" },
                    { 61, "Herman.Hackett@yahoo.com", "Herman", "Hackett", "917.481.6233 x38227" },
                    { 62, "Chester_Wuckert@hotmail.com", "Chester", "Wuckert", "(821) 636-7917 x7259" },
                    { 63, "Lee9@yahoo.com", "Lee", "Wolf", "692-692-9562 x9163" },
                    { 64, "Alma.Bahringer98@yahoo.com", "Alma", "Bahringer", "430-854-5290 x3226" },
                    { 65, "Kristina35@gmail.com", "Kristina", "Flatley", "1-520-986-2228 x849" },
                    { 66, "Erica33@gmail.com", "Erica", "Kessler", "450.958.5173 x37826" },
                    { 67, "Rickey.Larson89@hotmail.com", "Rickey", "Larson", "1-925-724-2550 x75808" },
                    { 68, "Patricia_Skiles@hotmail.com", "Patricia", "Skiles", "325-433-0037 x7537" },
                    { 69, "Clayton_Murphy67@hotmail.com", "Clayton", "Murphy", "1-809-914-0086" },
                    { 70, "Shannon_Barton@gmail.com", "Shannon", "Barton", "(623) 238-5848 x9323" },
                    { 71, "Aaron.Goldner92@gmail.com", "Aaron", "Goldner", "991-544-4096" },
                    { 72, "Nick16@gmail.com", "Nick", "Hilll", "(291) 993-5319 x7199" },
                    { 73, "Kathy72@yahoo.com", "Kathy", "Murazik", "721-498-8476 x519" },
                    { 74, "Katie_Veum@yahoo.com", "Katie", "Veum", "(225) 885-6935 x699" },
                    { 75, "Judy90@hotmail.com", "Judy", "Waters", "382-393-5437" },
                    { 76, "Rosemary11@yahoo.com", "Rosemary", "Douglas", "1-953-777-5743 x0164" },
                    { 77, "Esther.Dickens@hotmail.com", "Esther", "Dickens", "778.785.8674" },
                    { 78, "Roberta_Morissette@hotmail.com", "Roberta", "Morissette", "(950) 345-6006 x63277" },
                    { 79, "Lucia_Fritsch@gmail.com", "Lucia", "Fritsch", "543-436-3837" },
                    { 80, "Julio74@gmail.com", "Julio", "Fisher", "368.970.9645 x27297" },
                    { 81, "Steven_Kassulke@gmail.com", "Steven", "Kassulke", "936.916.6556 x13839" },
                    { 82, "Mable7@yahoo.com", "Mable", "Ruecker", "1-425-931-8817 x888" },
                    { 83, "Melvin_Schulist@hotmail.com", "Melvin", "Schulist", "775-215-6716" },
                    { 84, "Erica31@gmail.com", "Erica", "Keebler", "(920) 847-2576" },
                    { 85, "Santos_Robel48@gmail.com", "Santos", "Robel", "(378) 259-8598 x201" },
                    { 86, "Byron.Murphy23@hotmail.com", "Byron", "Murphy", "324.909.2131 x72839" },
                    { 87, "Gene72@yahoo.com", "Gene", "Ward", "1-607-586-2381 x9355" },
                    { 88, "Kerry74@hotmail.com", "Kerry", "Kunze", "(232) 653-6041 x1783" },
                    { 89, "Betsy.Rolfson83@gmail.com", "Betsy", "Rolfson", "259-395-6905" },
                    { 90, "Christy.Senger14@gmail.com", "Christy", "Senger", "1-253-857-4388 x1561" },
                    { 91, "Virgil_Hauck@gmail.com", "Virgil", "Hauck", "1-612-280-3329" },
                    { 92, "Carl_Paucek74@gmail.com", "Carl", "Paucek", "(568) 278-3574 x1383" },
                    { 93, "Wade_Ullrich46@gmail.com", "Wade", "Ullrich", "(963) 908-6680" },
                    { 94, "Jimmie.Klein23@yahoo.com", "Jimmie", "Klein", "645.580.6667" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 95, "Mamie69@yahoo.com", "Mamie", "Bechtelar", "1-623-539-8154" },
                    { 96, "Jeannette30@gmail.com", "Jeannette", "Grady", "980.267.5740" },
                    { 97, "Kristina_Tromp@yahoo.com", "Kristina", "Tromp", "1-662-989-1649 x15844" },
                    { 98, "Delia_Zemlak42@hotmail.com", "Delia", "Zemlak", "1-729-264-9747" },
                    { 99, "Jill.Wunsch@gmail.com", "Jill", "Wunsch", "791-634-3900 x02265" },
                    { 100, "Raul_Barton@hotmail.com", "Raul", "Barton", "381-544-5563 x766" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), "Nebraska", "Port Hailie", "Emmett.Conn@gmail.com", "Emmett", "Conn", "", "1-288-743-2789 x82883", "57515" },
                    { new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), "Montana", "Reynoldsburgh", "Alison.Stiedemann3@hotmail.com", "Alison", "Stiedemann", "", "435-917-8176 x84264", "02757-8101" },
                    { new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), "New Jersey", "Lake Geoffreyberg", "Crystal.Simonis17@hotmail.com", "Crystal", "Simonis", "", "787-614-9945 x7994", "43413-6912" },
                    { new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), "New York", "Davonbury", "Gayle33@hotmail.com", "Gayle", "Paucek", "", "606-281-7819 x6420", "13244" },
                    { new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), "Florida", "Smithtown", "Jackie2@yahoo.com", "Jackie", "Dickens", "", "405.603.1644 x04051", "44107-1519" },
                    { new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), "Massachusetts", "West Christophaven", "Amos_Kassulke@yahoo.com", "Amos", "Kassulke", "", "1-804-633-6484 x660", "90076" },
                    { new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), "West Virginia", "Port Tressiemouth", "Lindsey_Harvey@yahoo.com", "Lindsey", "Harvey", "", "996.873.4358 x50457", "88198" },
                    { new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), "Wyoming", "Gutkowskishire", "Delbert_Wolff38@gmail.com", "Delbert", "Wolff", "", "719-586-3625 x78848", "56327" },
                    { new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), "Texas", "South Flavioport", "Eddie.OConnell@gmail.com", "Eddie", "O'Connell", "", "542.284.1257 x05154", "15523-2309" },
                    { new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), "Connecticut", "Magdalenborough", "Seth.Funk5@yahoo.com", "Seth", "Funk", "", "777-565-9822 x564", "04640-0474" },
                    { new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), "Tennessee", "Abshirechester", "Dean83@yahoo.com", "Dean", "Emard", "", "(968) 741-0186", "53418" },
                    { new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), "Oklahoma", "South Teresa", "Jessie.Emmerich@gmail.com", "Jessie", "Emmerich", "", "787.203.9694 x1663", "71510-1655" },
                    { new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), "Kansas", "South Nevaberg", "Craig90@yahoo.com", "Craig", "Haley", "", "(241) 292-4102", "57272-3495" },
                    { new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), "Massachusetts", "Tremblayton", "Tracy.Willms1@hotmail.com", "Tracy", "Willms", "", "920-526-7206 x236", "00441-5831" },
                    { new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), "Minnesota", "Howellfurt", "Devin35@yahoo.com", "Devin", "Kovacek", "", "382.246.8937 x9984", "68494" },
                    { new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), "Michigan", "East Eldredton", "Sherri.Lockman72@gmail.com", "Sherri", "Lockman", "", "293.699.1696 x99361", "96440" },
                    { new Guid("377c1675-27c8-4144-af06-084d597f0051"), "Nevada", "Garnetbury", "Janet.Kozey@yahoo.com", "Janet", "Kozey", "", "298.948.5085 x613", "29361" },
                    { new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), "Idaho", "Lake Jayde", "Marty6@hotmail.com", "Marty", "Strosin", "", "671-317-5069", "32781-4108" },
                    { new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), "Nebraska", "Lake Budshire", "Terrence_Miller@hotmail.com", "Terrence", "Miller", "", "899-249-7333 x238", "58093-8975" },
                    { new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), "Texas", "Lake Rosendoside", "Annie48@gmail.com", "Annie", "Dach", "", "(224) 516-7134 x76928", "82769-6968" },
                    { new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), "Hawaii", "North Ryan", "David_Stanton@gmail.com", "David", "Stanton", "", "(469) 255-9035", "42382-9156" },
                    { new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), "Alabama", "Reginaldview", "Mattie_Mohr15@hotmail.com", "Mattie", "Mohr", "", "771.967.2704 x571", "51291-3834" },
                    { new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), "Missouri", "West Angelmouth", "Natasha33@hotmail.com", "Natasha", "Durgan", "", "424.563.3205 x1219", "97703" },
                    { new Guid("48772526-803a-4867-97db-4129d475d6ca"), "Wisconsin", "Julieville", "Glenda.Hudson@yahoo.com", "Glenda", "Hudson", "", "(823) 826-6928", "70661" },
                    { new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), "Georgia", "New Mandyshire", "Ian.Rodriguez@yahoo.com", "Ian", "Rodriguez", "", "503-613-7216", "26926" },
                    { new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), "Virginia", "Joyceton", "Rodney93@gmail.com", "Rodney", "Emmerich", "", "757.404.4118 x63643", "87216-2872" },
                    { new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), "Oklahoma", "South Susanna", "Wallace_Beer91@gmail.com", "Wallace", "Beer", "", "(352) 828-9016", "11799-0563" },
                    { new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), "Hawaii", "East Kristinafurt", "Jean_Kautzer@yahoo.com", "Jean", "Kautzer", "", "1-289-674-6773 x435", "05259" },
                    { new Guid("50384560-2944-4083-9419-a625949344c1"), "West Virginia", "Mazieport", "Lorene89@yahoo.com", "Lorene", "Predovic", "", "1-206-772-3709", "02418-9437" },
                    { new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), "Utah", "Lydiaport", "Mandy_Fahey84@hotmail.com", "Mandy", "Fahey", "", "1-418-934-3188", "05700" },
                    { new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), "Maine", "South Laverna", "Lynn_Kihn82@yahoo.com", "Lynn", "Kihn", "", "423-645-9896", "69816" },
                    { new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), "Indiana", "Onafurt", "Seth.Larson74@gmail.com", "Seth", "Larson", "", "(505) 993-0051 x8085", "44276" },
                    { new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), "Mississippi", "Huelston", "June.Jaskolski57@gmail.com", "June", "Jaskolski", "", "1-601-653-8933 x190", "93763-6210" },
                    { new Guid("62873915-588a-422b-8a3d-520df41b621c"), "Vermont", "Steviebury", "Devin_Balistreri@yahoo.com", "Devin", "Balistreri", "", "1-415-552-9329 x830", "80321-1049" },
                    { new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), "Connecticut", "Dayanaburgh", "Juan.Daniel95@gmail.com", "Juan", "Daniel", "", "955.984.0456", "98678-9094" },
                    { new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), "Alaska", "Port Johnny", "Claire88@gmail.com", "Claire", "Bernier", "", "(764) 224-9266 x313", "56240-1009" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), "Wisconsin", "Blockmouth", "Jacquelyn.Harvey66@gmail.com", "Jacquelyn", "Harvey", "", "(354) 592-6947", "83309" },
                    { new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), "Louisiana", "Alexieborough", "Pearl_Towne69@yahoo.com", "Pearl", "Towne", "", "1-290-560-0320", "96776" },
                    { new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), "Alaska", "Bayertown", "Willie_Feil57@hotmail.com", "Willie", "Feil", "", "1-795-421-2509 x400", "77080" },
                    { new Guid("6f0bfaad-7851-4d81-8ce0-f260c6a7ca00"), "8067 Green Park", "Robelview", "admin@admin.com", "Devin", "Beer", "AQAAAAEAACcQAAAAEPVUodxzUig0advQ7fuqwEIQ05IoI6mng3ucQCRV+ps/m1wkOZZntA9k++uhVjb/KQ==", "771.945.4510 x0284", "45649-2643" },
                    { new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), "Connecticut", "Scotville", "Terrell.Schoen@hotmail.com", "Terrell", "Schoen", "", "360-214-6960 x527", "52166-8334" },
                    { new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), "Ohio", "Bobbiefort", "Gilberto_Hoppe13@hotmail.com", "Gilberto", "Hoppe", "", "1-385-638-6511 x383", "26324-2580" },
                    { new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), "New Jersey", "East Maverickland", "Dexter_Mayer92@hotmail.com", "Dexter", "Mayer", "", "594.990.0691 x2161", "79081-2743" },
                    { new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), "Minnesota", "Kunzeville", "Melody_Donnelly@gmail.com", "Melody", "Donnelly", "", "513-924-7435 x810", "76411-3639" },
                    { new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), "Maryland", "Gottliebfurt", "Arlene23@gmail.com", "Arlene", "Corkery", "", "827.846.3770 x27001", "27055" },
                    { new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), "South Carolina", "Yostbury", "Ethel_Cronin32@hotmail.com", "Ethel", "Cronin", "", "245.234.3260 x21235", "43390-2938" },
                    { new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), "New Mexico", "Macieton", "Rosemary26@yahoo.com", "Rosemary", "Dicki", "", "204.627.3242 x38777", "84142" },
                    { new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), "New Jersey", "West Leolamouth", "Dewey.Johnson0@gmail.com", "Dewey", "Johnson", "", "422-549-6556 x20402", "47280" },
                    { new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), "Oregon", "Swiftshire", "Mary46@yahoo.com", "Mary", "Herzog", "", "(415) 214-6040 x17596", "71802" },
                    { new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), "Wisconsin", "Lake Abigayle", "Lillian70@gmail.com", "Lillian", "King", "", "414.744.3835 x3683", "06084" },
                    { new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), "West Virginia", "East Kaleyport", "Tommie.Larkin@yahoo.com", "Tommie", "Larkin", "", "462-735-2688 x9186", "33538" },
                    { new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), "North Carolina", "Port Charlie", "Alexis.Langworth@yahoo.com", "Alexis", "Langworth", "", "1-694-236-0718 x231", "17977" },
                    { new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), "New Mexico", "Lemketon", "Vanessa26@gmail.com", "Vanessa", "Kautzer", "", "804-872-1364 x1523", "43262-3960" },
                    { new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), "Maryland", "Coystad", "Cheryl.Ortiz68@gmail.com", "Cheryl", "Ortiz", "", "1-886-423-8034 x2012", "64465" },
                    { new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), "California", "North Dominicberg", "Rodney56@hotmail.com", "Rodney", "Bergnaum", "", "410-851-4186", "52028" },
                    { new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), "California", "Avaborough", "Traci44@gmail.com", "Traci", "Boyle", "", "1-825-772-6725", "27755-5336" },
                    { new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), "New York", "Corneliusfort", "Delores.Barton@yahoo.com", "Delores", "Barton", "", "225.327.7981", "37800" },
                    { new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), "Mississippi", "New Salmafurt", "Kristie_Heller@hotmail.com", "Kristie", "Heller", "", "1-600-290-6415", "60335" },
                    { new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), "Iowa", "Kreigerberg", "Kerry.Gislason@hotmail.com", "Kerry", "Gislason", "", "216-478-9547 x1160", "12931" },
                    { new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), "Rhode Island", "Turnerberg", "Emmett85@hotmail.com", "Emmett", "Feest", "", "1-267-324-8022 x412", "39577-3954" },
                    { new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), "Delaware", "Ashleighfurt", "Austin.Cassin@hotmail.com", "Austin", "Cassin", "", "952-718-1911", "17718" },
                    { new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), "West Virginia", "Reillyville", "Estelle15@yahoo.com", "Estelle", "Mueller", "", "1-666-803-0896 x1401", "68045" },
                    { new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), "Virginia", "New Alexzander", "Camille_Ferry52@gmail.com", "Camille", "Ferry", "", "766.623.7881", "48713" },
                    { new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), "Oklahoma", "Grahamchester", "Dallas23@gmail.com", "Dallas", "Lockman", "", "(265) 980-8488 x42294", "86259" },
                    { new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), "Missouri", "Kamronberg", "Mack_Batz@hotmail.com", "Mack", "Batz", "", "853.475.0078", "25634" },
                    { new Guid("a48cafc5-4669-429d-825f-cf007df82222"), "Louisiana", "New Ellisborough", "Donnie_Brakus@yahoo.com", "Donnie", "Brakus", "", "569.934.4950 x696", "58001-2843" },
                    { new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), "Indiana", "Shayleestad", "Randall_Ondricka@hotmail.com", "Randall", "Ondricka", "", "729.916.1176", "56385" },
                    { new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), "Massachusetts", "Ankundington", "Paula_Hills@yahoo.com", "Paula", "Hills", "", "(614) 462-5988 x000", "35812" },
                    { new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), "Wisconsin", "Schowalterport", "Marlon80@yahoo.com", "Marlon", "Herzog", "", "979-765-4236 x4644", "33877" },
                    { new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), "Rhode Island", "Cleoport", "Tyrone.Stiedemann19@hotmail.com", "Tyrone", "Stiedemann", "", "769.498.2779", "77919" },
                    { new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), "Kansas", "West Hansview", "Todd76@gmail.com", "Todd", "Beatty", "", "1-957-518-6288 x885", "59204-2750" },
                    { new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), "Kentucky", "North Augusta", "Phillip34@hotmail.com", "Phillip", "Wuckert", "", "1-501-227-8237 x13802", "72572" },
                    { new Guid("b7149f16-e029-4115-9d35-a4056970636d"), "West Virginia", "New Carter", "Ismael.Renner87@hotmail.com", "Ismael", "Renner", "", "1-331-492-5512", "13668" },
                    { new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), "Louisiana", "West Maialand", "Ruby_Klocko94@gmail.com", "Ruby", "Klocko", "", "(624) 750-9374 x414", "59718" },
                    { new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), "Alaska", "Kozeybury", "Kristin87@yahoo.com", "Kristin", "Medhurst", "", "294-653-4777 x8770", "12430-4113" },
                    { new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), "Louisiana", "West Damaris", "Geoffrey1@yahoo.com", "Geoffrey", "Bechtelar", "", "404-506-4955 x15343", "99328-4780" },
                    { new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), "Maryland", "Dickinsonland", "Pat.Ledner@yahoo.com", "Pat", "Ledner", "", "(763) 810-7641 x3482", "55680" },
                    { new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), "Nevada", "Towneport", "Pedro95@hotmail.com", "Pedro", "O'Keefe", "", "702.727.5548 x316", "35640" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), "Alabama", "East Elaina", "Alison_Hessel44@gmail.com", "Alison", "Hessel", "", "(892) 922-5741", "07406" },
                    { new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), "Arizona", "Juddstad", "Sabrina.Streich@gmail.com", "Sabrina", "Streich", "", "(208) 250-7845 x10871", "69426-9331" },
                    { new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), "Montana", "Hyatthaven", "Kay.Schumm59@hotmail.com", "Kay", "Schumm", "", "(207) 678-0537 x29978", "95002-9467" },
                    { new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), "South Carolina", "Bahringerbury", "Calvin_Rempel@hotmail.com", "Calvin", "Rempel", "", "812.479.7466 x2458", "82752-8357" },
                    { new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), "Louisiana", "Pacochaberg", "Carolyn.Waelchi@yahoo.com", "Carolyn", "Waelchi", "", "966.351.1032", "84521" },
                    { new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), "Iowa", "Keelystad", "Lucille28@hotmail.com", "Lucille", "Parker", "", "1-656-894-9151", "42323-1413" },
                    { new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), "Nebraska", "Augustaland", "Lynn_Welch@hotmail.com", "Lynn", "Welch", "", "824-327-5819 x9670", "11392" },
                    { new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), "Arkansas", "Haagchester", "Jeremiah_Hilll71@yahoo.com", "Jeremiah", "Hilll", "", "(578) 728-2534 x77546", "16559" },
                    { new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), "Oregon", "Port Hattie", "Claire_Keebler91@gmail.com", "Claire", "Keebler", "", "931.825.7389 x343", "95176" },
                    { new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), "North Carolina", "Aylamouth", "Joanna12@gmail.com", "Joanna", "Renner", "", "921-695-5689 x6343", "67594" },
                    { new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), "Indiana", "Lake Chelsey", "Leland50@hotmail.com", "Leland", "Moore", "", "(806) 465-7467", "34470-3534" },
                    { new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), "Montana", "Erickaborough", "Angelo_Kshlerin25@yahoo.com", "Angelo", "Kshlerin", "", "344-265-3634 x930", "91073" },
                    { new Guid("e9550553-7082-46d5-9016-f04b082ce998"), "Minnesota", "West Flavio", "Milton_Becker@yahoo.com", "Milton", "Becker", "", "(395) 497-9718 x50792", "78277-8988" },
                    { new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), "Massachusetts", "New Simonehaven", "Maggie.Streich@gmail.com", "Maggie", "Streich", "", "1-833-554-7225 x846", "13544-0627" },
                    { new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), "California", "Pasqualeberg", "Pamela.Bednar48@gmail.com", "Pamela", "Bednar", "", "996.602.9203 x583", "37635" },
                    { new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), "Delaware", "North Ryleighchester", "Ana_Harris24@yahoo.com", "Ana", "Harris", "", "1-579-789-0415", "91646" },
                    { new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), "Utah", "McClurefort", "Roosevelt_Wiza96@hotmail.com", "Roosevelt", "Wiza", "", "702-569-8326", "45445-0033" },
                    { new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), "Delaware", "Merrittfort", "Edmund_Towne20@gmail.com", "Edmund", "Towne", "", "1-481-265-2578 x9360", "28892" },
                    { new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), "Hawaii", "Port Noemi", "Jaime.Kerluke@gmail.com", "Jaime", "Kerluke", "", "1-338-477-9794 x6885", "68075" },
                    { new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), "Arizona", "Milesfort", "Tommie_Auer0@gmail.com", "Tommie", "Auer", "", "913-402-8871 x6930", "47755-3437" },
                    { new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), "Washington", "Janelleland", "Drew_Bosco71@gmail.com", "Drew", "Bosco", "", "(714) 777-8492 x6935", "84439-7080" },
                    { new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), "Wyoming", "Thielport", "Lorena.Heaney@yahoo.com", "Lorena", "Heaney", "", "221.496.7480 x98589", "18144-4893" },
                    { new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), "California", "South Alexandrofort", "Dana_Bergstrom98@gmail.com", "Dana", "Bergstrom", "", "(570) 838-5108", "94673-6162" }
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "Name",
                value: "Teacher");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "Name",
                value: "Tutor");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "Name",
                value: "LocalAdmin");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 5,
                column: "Name",
                value: "Admin");

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Emma_Marks@gmail.com", "Emma", false, "Marks", "1-946-558-0828" },
                    { 2, "Ellen_Lind@gmail.com", "Ellen", false, "Lind", "643-372-7304" },
                    { 3, "Dora83@hotmail.com", "Dora", false, "Gleichner", "298.865.3252 x04932" },
                    { 4, "Carolyn31@hotmail.com", "Carolyn", false, "Klocko", "(692) 521-6945 x791" },
                    { 5, "Dexter26@yahoo.com", "Dexter", false, "Schneider", "1-910-811-3380 x53276" },
                    { 6, "Hope_Lind@hotmail.com", "Hope", false, "Lind", "655-649-3924 x255" },
                    { 7, "Gina.McLaughlin@gmail.com", "Gina", false, "McLaughlin", "1-227-591-7794" },
                    { 8, "Earl_Raynor31@gmail.com", "Earl", false, "Raynor", "1-520-811-0044 x77768" },
                    { 9, "Homer_Schowalter@yahoo.com", "Homer", false, "Schowalter", "1-344-632-3702" },
                    { 10, "Lola64@hotmail.com", "Lola", false, "Harvey", "(265) 292-9709 x0019" },
                    { 11, "Gilberto11@hotmail.com", "Gilberto", false, "Krajcik", "1-262-422-7115" },
                    { 12, "Patti73@yahoo.com", "Patti", false, "Bayer", "615.795.9372 x12354" },
                    { 13, "Jill81@hotmail.com", "Jill", false, "Zieme", "(340) 906-6445 x7754" },
                    { 14, "Karl_Emmerich49@hotmail.com", "Karl", false, "Emmerich", "(430) 944-5512" },
                    { 15, "Oscar.Lang64@gmail.com", "Oscar", false, "Lang", "1-737-808-9440" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { 16, "Lisa.Swift23@yahoo.com", "Lisa", false, "Swift", "289-918-9501 x9287" },
                    { 17, "Alfredo_Batz@hotmail.com", "Alfredo", false, "Batz", "477-938-0978 x4578" },
                    { 18, "Olga47@hotmail.com", "Olga", false, "Sipes", "426.521.6645" },
                    { 19, "Jason_Wisoky@hotmail.com", "Jason", false, "Wisoky", "(544) 827-8279 x1896" }
                });

            migrationBuilder.InsertData(
                table: "Approve",
                columns: new[] { "ApproveID", "Description", "FK_UserUUID", "Positive" },
                values: new object[,]
                {
                    { 1, "", new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), true },
                    { 2, "", new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), false },
                    { 3, "", new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), false },
                    { 4, "", new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), true },
                    { 5, "", new Guid("a48cafc5-4669-429d-825f-cf007df82222"), false },
                    { 6, "", new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), false },
                    { 7, "", new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), false },
                    { 8, "", new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), false },
                    { 9, "", new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), true },
                    { 10, "", new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), false },
                    { 11, "", new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), true },
                    { 12, "", new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), true },
                    { 13, "", new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), true },
                    { 14, "", new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), true },
                    { 15, "", new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), false },
                    { 16, "", new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), true },
                    { 17, "", new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), false },
                    { 18, "", new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), false },
                    { 19, "", new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), true },
                    { 20, "", new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), true },
                    { 21, "", new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), false },
                    { 22, "", new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), false },
                    { 23, "", new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), true },
                    { 24, "", new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), false },
                    { 25, "", new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), true },
                    { 26, "", new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), false },
                    { 27, "", new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), true },
                    { 28, "", new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), false },
                    { 29, "", new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), false },
                    { 30, "", new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), false }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 1, "", new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), 5, 1 },
                    { 2, "", new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), 5, 3 },
                    { 3, "", new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), 5, 2 },
                    { 4, "", new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), 2, 3 },
                    { 5, "", new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), 1, 1 },
                    { 6, "", new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), 2, 2 },
                    { 7, "", new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), 5, 3 },
                    { 8, "", new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), 3, 1 },
                    { 9, "", new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), 5, 2 },
                    { 10, "", new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), 5, 2 },
                    { 11, "", new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), 1, 1 },
                    { 12, "", new Guid("62873915-588a-422b-8a3d-520df41b621c"), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 13, "", new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), 3, 3 },
                    { 14, "", new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), 3, 2 },
                    { 15, "", new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), 5, 2 },
                    { 16, "", new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), 2, 2 },
                    { 17, "", new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), 4, 2 },
                    { 18, "", new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), 6, 3 },
                    { 19, "", new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), 3, 3 },
                    { 20, "", new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), 3, 3 },
                    { 21, "", new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), 3, 2 },
                    { 22, "", new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), 4, 3 },
                    { 23, "", new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), 6, 3 },
                    { 24, "", new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), 3, 1 },
                    { 25, "", new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), 1, 2 },
                    { 26, "", new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), 6, 3 },
                    { 27, "", new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), 2, 2 },
                    { 28, "", new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), 5, 1 },
                    { 29, "", new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), 6, 1 },
                    { 30, "", new Guid("b7149f16-e029-4115-9d35-a4056970636d"), 6, 3 },
                    { 31, "", new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), 6, 1 },
                    { 32, "", new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), 6, 1 },
                    { 33, "", new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), 1, 1 },
                    { 34, "", new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), 2, 3 },
                    { 35, "", new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), 6, 3 },
                    { 36, "", new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), 1, 2 },
                    { 37, "", new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), 5, 1 },
                    { 38, "", new Guid("377c1675-27c8-4144-af06-084d597f0051"), 4, 1 },
                    { 39, "", new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), 3, 3 },
                    { 40, "", new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), 5, 1 },
                    { 41, "", new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), 5, 1 },
                    { 42, "", new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), 4, 3 },
                    { 43, "", new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), 2, 1 },
                    { 44, "", new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), 2, 1 },
                    { 45, "", new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), 5, 1 },
                    { 46, "", new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), 4, 3 },
                    { 47, "", new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), 3, 1 },
                    { 48, "", new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), 3, 3 },
                    { 49, "", new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), 6, 3 },
                    { 50, "", new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), 1, 3 },
                    { 51, "", new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), 6, 3 },
                    { 52, "", new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), 3, 3 },
                    { 53, "", new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), 2, 1 },
                    { 54, "", new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 55, "", new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), 5, 2 },
                    { 56, "", new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), 6, 1 },
                    { 57, "", new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), 6, 3 },
                    { 58, "", new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), 6, 2 },
                    { 59, "", new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), 2, 2 },
                    { 60, "", new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), 2, 3 },
                    { 61, "", new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), 3, 1 },
                    { 62, "", new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), 4, 3 },
                    { 63, "", new Guid("b7149f16-e029-4115-9d35-a4056970636d"), 6, 1 },
                    { 64, "", new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), 1, 1 },
                    { 65, "", new Guid("48772526-803a-4867-97db-4129d475d6ca"), 6, 3 },
                    { 66, "", new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), 2, 2 },
                    { 67, "", new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), 1, 2 },
                    { 68, "", new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), 4, 1 },
                    { 69, "", new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), 3, 2 },
                    { 70, "", new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), 6, 3 },
                    { 71, "", new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), 3, 3 },
                    { 72, "", new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), 2, 1 },
                    { 73, "", new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), 5, 1 },
                    { 74, "", new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), 5, 2 },
                    { 75, "", new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), 6, 3 },
                    { 76, "", new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), 3, 2 },
                    { 77, "", new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), 6, 2 },
                    { 78, "", new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), 5, 2 },
                    { 79, "", new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), 6, 3 },
                    { 80, "", new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), 6, 3 },
                    { 81, "", new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), 6, 1 },
                    { 82, "", new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), 5, 1 },
                    { 83, "", new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), 6, 2 },
                    { 84, "", new Guid("a48cafc5-4669-429d-825f-cf007df82222"), 4, 2 },
                    { 85, "", new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), 6, 2 },
                    { 86, "", new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), 3, 2 },
                    { 87, "", new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), 3, 3 },
                    { 88, "", new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), 1, 3 },
                    { 89, "", new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), 5, 3 },
                    { 90, "", new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), 3, 1 },
                    { 91, "", new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), 2, 3 },
                    { 92, "", new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), 6, 3 },
                    { 93, "", new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), 4, 3 },
                    { 94, "", new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), 1, 1 },
                    { 95, "", new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), 6, 2 },
                    { 96, "", new Guid("50384560-2944-4083-9419-a625949344c1"), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 97, "", new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), 4, 3 },
                    { 98, "", new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), 6, 3 },
                    { 99, "", new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), 2, 2 },
                    { 100, "", new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), 2, 3 },
                    { 101, "", new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), 3, 3 },
                    { 102, "", new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), 5, 2 },
                    { 103, "", new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), 1, 1 },
                    { 104, "", new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), 6, 1 },
                    { 105, "", new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), 4, 1 },
                    { 106, "", new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), 6, 2 },
                    { 107, "", new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), 5, 3 },
                    { 108, "", new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), 4, 3 },
                    { 109, "", new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), 5, 2 },
                    { 110, "", new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), 1, 2 },
                    { 111, "", new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), 4, 1 },
                    { 112, "", new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), 3, 2 },
                    { 113, "", new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), 1, 3 },
                    { 114, "", new Guid("b7149f16-e029-4115-9d35-a4056970636d"), 4, 2 },
                    { 115, "", new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), 1, 1 },
                    { 116, "", new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), 1, 3 },
                    { 117, "", new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), 4, 2 },
                    { 118, "", new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), 6, 2 },
                    { 119, "", new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), 6, 1 },
                    { 120, "", new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), 6, 2 },
                    { 121, "", new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), 2, 2 },
                    { 122, "", new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), 4, 2 },
                    { 123, "", new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), 1, 1 },
                    { 124, "", new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), 5, 2 },
                    { 125, "", new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), 3, 1 },
                    { 126, "", new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), 6, 3 },
                    { 127, "", new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), 6, 3 },
                    { 128, "", new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), 2, 2 },
                    { 129, "", new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), 2, 2 },
                    { 130, "", new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), 3, 2 },
                    { 131, "", new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), 2, 1 },
                    { 132, "", new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), 1, 1 },
                    { 133, "", new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), 4, 1 },
                    { 134, "", new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), 2, 2 },
                    { 135, "", new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), 3, 3 },
                    { 136, "", new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), 6, 2 },
                    { 137, "", new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), 3, 3 },
                    { 138, "", new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 139, "", new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), 3, 1 },
                    { 140, "", new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), 6, 3 },
                    { 141, "", new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), 5, 1 },
                    { 142, "", new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), 2, 1 },
                    { 143, "", new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), 6, 2 },
                    { 144, "", new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), 2, 1 },
                    { 145, "", new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), 4, 2 },
                    { 146, "", new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), 5, 2 },
                    { 147, "", new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), 3, 3 },
                    { 148, "", new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), 6, 1 },
                    { 149, "", new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), 4, 2 },
                    { 150, "", new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), 4, 1 },
                    { 151, "", new Guid("e9550553-7082-46d5-9016-f04b082ce998"), 5, 1 },
                    { 152, "", new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), 6, 2 },
                    { 153, "", new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), 4, 3 },
                    { 154, "", new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), 5, 1 },
                    { 155, "", new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), 6, 3 },
                    { 156, "", new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), 3, 3 },
                    { 157, "", new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), 1, 1 },
                    { 158, "", new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), 4, 2 },
                    { 159, "", new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), 4, 2 },
                    { 160, "", new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), 1, 2 },
                    { 161, "", new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), 6, 1 },
                    { 162, "", new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), 6, 1 },
                    { 163, "", new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), 3, 2 },
                    { 164, "", new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), 5, 2 },
                    { 165, "", new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), 2, 3 },
                    { 166, "", new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), 5, 3 },
                    { 167, "", new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), 3, 3 },
                    { 168, "", new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), 2, 1 },
                    { 169, "", new Guid("62873915-588a-422b-8a3d-520df41b621c"), 5, 1 },
                    { 170, "", new Guid("377c1675-27c8-4144-af06-084d597f0051"), 2, 3 },
                    { 171, "", new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), 3, 2 },
                    { 172, "", new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), 5, 3 },
                    { 173, "", new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), 3, 3 },
                    { 174, "", new Guid("e9550553-7082-46d5-9016-f04b082ce998"), 6, 1 },
                    { 175, "", new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), 2, 1 },
                    { 176, "", new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), 1, 3 },
                    { 177, "", new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), 5, 2 },
                    { 178, "", new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), 1, 2 },
                    { 179, "", new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), 6, 2 },
                    { 180, "", new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 181, "", new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), 1, 1 },
                    { 182, "", new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), 3, 2 },
                    { 183, "", new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), 6, 3 },
                    { 184, "", new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), 1, 3 },
                    { 185, "", new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), 1, 1 },
                    { 186, "", new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), 2, 2 },
                    { 187, "", new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), 2, 1 },
                    { 188, "", new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), 3, 3 },
                    { 189, "", new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), 5, 3 },
                    { 190, "", new Guid("e9550553-7082-46d5-9016-f04b082ce998"), 2, 2 },
                    { 191, "", new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), 1, 1 },
                    { 192, "", new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), 5, 3 },
                    { 193, "", new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), 3, 3 },
                    { 194, "", new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), 6, 2 },
                    { 195, "", new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), 4, 3 },
                    { 196, "", new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), 3, 2 },
                    { 197, "", new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), 5, 3 },
                    { 198, "", new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), 5, 1 },
                    { 199, "", new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), 5, 3 },
                    { 200, "", new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), 3, 1 },
                    { 201, "", new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), 4, 2 },
                    { 202, "", new Guid("62873915-588a-422b-8a3d-520df41b621c"), 2, 2 },
                    { 203, "", new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), 3, 1 },
                    { 204, "", new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), 3, 1 },
                    { 205, "", new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), 5, 3 },
                    { 206, "", new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), 5, 2 },
                    { 207, "", new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), 5, 1 },
                    { 208, "", new Guid("50384560-2944-4083-9419-a625949344c1"), 4, 2 },
                    { 209, "", new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), 3, 1 },
                    { 210, "", new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), 3, 3 },
                    { 211, "", new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), 5, 1 },
                    { 212, "", new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), 4, 1 },
                    { 213, "", new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), 4, 2 },
                    { 214, "", new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), 5, 2 },
                    { 215, "", new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), 4, 2 },
                    { 216, "", new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), 4, 2 },
                    { 217, "", new Guid("b7149f16-e029-4115-9d35-a4056970636d"), 2, 1 },
                    { 218, "", new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), 1, 1 },
                    { 219, "", new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), 4, 2 },
                    { 220, "", new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), 5, 1 },
                    { 221, "", new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), 6, 2 },
                    { 222, "", new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 223, "", new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), 5, 2 },
                    { 224, "", new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), 5, 2 },
                    { 225, "", new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), 4, 3 },
                    { 226, "", new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), 6, 3 },
                    { 227, "", new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), 6, 3 },
                    { 228, "", new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), 1, 1 },
                    { 229, "", new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), 3, 2 },
                    { 230, "", new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), 5, 1 },
                    { 231, "", new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), 4, 3 },
                    { 232, "", new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), 1, 2 },
                    { 233, "", new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), 1, 2 },
                    { 234, "", new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), 6, 2 },
                    { 235, "", new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), 6, 1 },
                    { 236, "", new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), 1, 1 },
                    { 237, "", new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), 2, 1 },
                    { 238, "", new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), 6, 2 },
                    { 239, "", new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), 3, 1 },
                    { 240, "", new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), 4, 2 },
                    { 241, "", new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), 5, 2 },
                    { 242, "", new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), 3, 3 },
                    { 243, "", new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), 5, 2 },
                    { 244, "", new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), 1, 1 },
                    { 245, "", new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), 2, 1 },
                    { 246, "", new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), 1, 3 },
                    { 247, "", new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), 6, 1 },
                    { 248, "", new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), 4, 1 },
                    { 249, "", new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), 2, 1 },
                    { 250, "", new Guid("48772526-803a-4867-97db-4129d475d6ca"), 4, 3 },
                    { 251, "", new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), 5, 2 },
                    { 252, "", new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), 3, 1 },
                    { 253, "", new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), 4, 1 },
                    { 254, "", new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), 2, 3 },
                    { 255, "", new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), 5, 1 },
                    { 256, "", new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), 1, 2 },
                    { 257, "", new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), 4, 1 },
                    { 258, "", new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), 1, 3 },
                    { 259, "", new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), 1, 3 },
                    { 260, "", new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), 1, 1 },
                    { 261, "", new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), 5, 2 },
                    { 262, "", new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), 6, 2 },
                    { 263, "", new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), 6, 1 },
                    { 264, "", new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 265, "", new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), 6, 3 },
                    { 266, "", new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), 3, 1 },
                    { 267, "", new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), 6, 1 },
                    { 268, "", new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), 6, 2 },
                    { 269, "", new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), 2, 1 },
                    { 270, "", new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), 5, 2 },
                    { 271, "", new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), 3, 2 },
                    { 272, "", new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), 5, 2 },
                    { 273, "", new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), 1, 3 },
                    { 274, "", new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), 2, 2 },
                    { 275, "", new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), 4, 1 },
                    { 276, "", new Guid("a48cafc5-4669-429d-825f-cf007df82222"), 3, 1 },
                    { 277, "", new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), 5, 3 },
                    { 278, "", new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), 6, 1 },
                    { 279, "", new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), 4, 2 },
                    { 280, "", new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), 4, 3 },
                    { 281, "", new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), 1, 1 },
                    { 282, "", new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), 4, 2 },
                    { 283, "", new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), 1, 2 },
                    { 284, "", new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), 4, 2 },
                    { 285, "", new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), 5, 2 },
                    { 286, "", new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), 4, 3 },
                    { 287, "", new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), 6, 2 },
                    { 288, "", new Guid("e9550553-7082-46d5-9016-f04b082ce998"), 1, 2 },
                    { 289, "", new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), 1, 3 },
                    { 290, "", new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), 6, 3 },
                    { 291, "", new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), 2, 3 },
                    { 292, "", new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), 5, 2 },
                    { 293, "", new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), 5, 1 },
                    { 294, "", new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), 2, 1 },
                    { 295, "", new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), 2, 2 },
                    { 296, "", new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), 5, 2 },
                    { 297, "", new Guid("e9550553-7082-46d5-9016-f04b082ce998"), 4, 2 },
                    { 298, "", new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), 3, 1 },
                    { 299, "", new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), 3, 2 },
                    { 300, "", new Guid("a48cafc5-4669-429d-825f-cf007df82222"), 1, 1 },
                    { 301, "", new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), 5, 3 },
                    { 302, "", new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), 5, 1 },
                    { 303, "", new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), 3, 1 },
                    { 304, "", new Guid("50384560-2944-4083-9419-a625949344c1"), 2, 1 },
                    { 305, "", new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), 5, 2 },
                    { 306, "", new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 307, "", new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), 4, 2 },
                    { 308, "", new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), 1, 3 },
                    { 309, "", new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), 1, 2 },
                    { 310, "", new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), 3, 1 },
                    { 311, "", new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), 5, 1 },
                    { 312, "", new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), 4, 3 },
                    { 313, "", new Guid("50384560-2944-4083-9419-a625949344c1"), 2, 3 },
                    { 314, "", new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), 1, 1 },
                    { 315, "", new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), 5, 3 },
                    { 316, "", new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), 1, 1 },
                    { 317, "", new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), 4, 2 },
                    { 318, "", new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), 2, 2 },
                    { 319, "", new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), 4, 1 },
                    { 320, "", new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), 1, 1 },
                    { 321, "", new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), 5, 1 },
                    { 322, "", new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), 4, 3 },
                    { 323, "", new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), 5, 2 },
                    { 324, "", new Guid("48772526-803a-4867-97db-4129d475d6ca"), 2, 1 },
                    { 325, "", new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), 4, 3 },
                    { 326, "", new Guid("62873915-588a-422b-8a3d-520df41b621c"), 2, 3 },
                    { 327, "", new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), 1, 1 },
                    { 328, "", new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), 1, 3 },
                    { 329, "", new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), 3, 1 },
                    { 330, "", new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), 5, 2 },
                    { 331, "", new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), 5, 3 },
                    { 332, "", new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), 4, 3 },
                    { 333, "", new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), 3, 1 },
                    { 334, "", new Guid("50384560-2944-4083-9419-a625949344c1"), 2, 1 },
                    { 335, "", new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), 1, 2 },
                    { 336, "", new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), 2, 1 },
                    { 337, "", new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), 5, 1 },
                    { 338, "", new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), 6, 1 },
                    { 339, "", new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), 5, 1 },
                    { 340, "", new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), 6, 1 },
                    { 341, "", new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), 3, 1 },
                    { 342, "", new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), 3, 3 },
                    { 343, "", new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), 2, 1 },
                    { 344, "", new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), 2, 3 },
                    { 345, "", new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), 6, 2 },
                    { 346, "", new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), 2, 1 },
                    { 347, "", new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), 2, 3 },
                    { 348, "", new Guid("48772526-803a-4867-97db-4129d475d6ca"), 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 349, "", new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), 4, 3 },
                    { 350, "", new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), 2, 2 },
                    { 351, "", new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), 3, 2 },
                    { 352, "", new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), 3, 1 },
                    { 353, "", new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), 4, 1 },
                    { 354, "", new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), 4, 2 },
                    { 355, "", new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), 3, 3 },
                    { 356, "", new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), 3, 1 },
                    { 357, "", new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), 2, 3 },
                    { 358, "", new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), 5, 2 },
                    { 359, "", new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), 2, 3 },
                    { 360, "", new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), 4, 3 },
                    { 361, "", new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), 3, 1 },
                    { 362, "", new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), 1, 3 },
                    { 363, "", new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), 3, 1 },
                    { 364, "", new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), 3, 1 },
                    { 365, "", new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), 6, 2 },
                    { 366, "", new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), 2, 1 },
                    { 367, "", new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), 1, 2 },
                    { 368, "", new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), 3, 1 },
                    { 369, "", new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), 3, 2 },
                    { 370, "", new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), 2, 1 },
                    { 371, "", new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), 6, 2 },
                    { 372, "", new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), 6, 3 },
                    { 373, "", new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), 6, 3 },
                    { 374, "", new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), 1, 2 },
                    { 375, "", new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), 3, 3 },
                    { 376, "", new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), 4, 1 },
                    { 377, "", new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), 5, 1 },
                    { 378, "", new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), 3, 2 },
                    { 379, "", new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), 5, 3 },
                    { 380, "", new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), 2, 3 },
                    { 381, "", new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), 6, 3 },
                    { 382, "", new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), 2, 2 },
                    { 383, "", new Guid("377c1675-27c8-4144-af06-084d597f0051"), 2, 1 },
                    { 384, "", new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), 5, 3 },
                    { 385, "", new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), 2, 3 },
                    { 386, "", new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), 4, 2 },
                    { 387, "", new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), 2, 2 },
                    { 388, "", new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), 2, 3 },
                    { 389, "", new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), 2, 1 },
                    { 390, "", new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 391, "", new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), 6, 1 },
                    { 392, "", new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), 3, 2 },
                    { 393, "", new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), 6, 3 },
                    { 394, "", new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), 5, 3 },
                    { 395, "", new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), 5, 1 },
                    { 396, "", new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), 2, 2 },
                    { 397, "", new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), 1, 1 },
                    { 398, "", new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), 6, 1 },
                    { 399, "", new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), 3, 1 },
                    { 400, "", new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), 3, 3 },
                    { 401, "", new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), 3, 3 },
                    { 402, "", new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), 1, 1 },
                    { 403, "", new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), 3, 1 },
                    { 404, "", new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), 6, 1 },
                    { 405, "", new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), 5, 1 },
                    { 406, "", new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), 3, 2 },
                    { 407, "", new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), 6, 2 },
                    { 408, "", new Guid("377c1675-27c8-4144-af06-084d597f0051"), 4, 3 },
                    { 409, "", new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), 1, 2 },
                    { 410, "", new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), 6, 1 },
                    { 411, "", new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), 1, 1 },
                    { 412, "", new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), 4, 1 },
                    { 413, "", new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), 6, 3 },
                    { 414, "", new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), 2, 2 },
                    { 415, "", new Guid("a48cafc5-4669-429d-825f-cf007df82222"), 1, 2 },
                    { 416, "", new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), 2, 3 },
                    { 417, "", new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), 5, 1 },
                    { 418, "", new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), 5, 2 },
                    { 419, "", new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), 4, 3 },
                    { 420, "", new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), 1, 3 },
                    { 421, "", new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), 4, 2 },
                    { 422, "", new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), 2, 3 },
                    { 423, "", new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), 6, 1 },
                    { 424, "", new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), 3, 1 },
                    { 425, "", new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), 2, 2 },
                    { 426, "", new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), 5, 3 },
                    { 427, "", new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), 5, 3 },
                    { 428, "", new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), 3, 1 },
                    { 429, "", new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), 5, 2 },
                    { 430, "", new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), 1, 3 },
                    { 431, "", new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), 2, 1 },
                    { 432, "", new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 433, "", new Guid("377c1675-27c8-4144-af06-084d597f0051"), 2, 3 },
                    { 434, "", new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), 2, 3 },
                    { 435, "", new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), 6, 1 },
                    { 436, "", new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), 2, 1 },
                    { 437, "", new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), 3, 1 },
                    { 438, "", new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), 6, 1 },
                    { 439, "", new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), 1, 3 },
                    { 440, "", new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), 2, 1 },
                    { 441, "", new Guid("48772526-803a-4867-97db-4129d475d6ca"), 6, 2 },
                    { 442, "", new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), 4, 3 },
                    { 443, "", new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), 1, 3 },
                    { 444, "", new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), 6, 2 },
                    { 445, "", new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), 5, 1 },
                    { 446, "", new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), 6, 1 },
                    { 447, "", new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), 6, 2 },
                    { 448, "", new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), 3, 1 },
                    { 449, "", new Guid("b7149f16-e029-4115-9d35-a4056970636d"), 3, 1 },
                    { 450, "", new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), 2, 3 },
                    { 451, "", new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), 5, 1 },
                    { 452, "", new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), 3, 1 },
                    { 453, "", new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), 6, 1 },
                    { 454, "", new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), 2, 2 },
                    { 455, "", new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), 3, 2 },
                    { 456, "", new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), 2, 3 },
                    { 457, "", new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), 5, 2 },
                    { 458, "", new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), 1, 1 },
                    { 459, "", new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), 3, 3 },
                    { 460, "", new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), 4, 1 },
                    { 461, "", new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), 2, 3 },
                    { 462, "", new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), 6, 2 },
                    { 463, "", new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), 1, 1 },
                    { 464, "", new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), 4, 3 },
                    { 465, "", new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), 6, 2 },
                    { 466, "", new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), 3, 2 },
                    { 467, "", new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), 5, 1 },
                    { 468, "", new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), 2, 3 },
                    { 469, "", new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), 5, 1 },
                    { 470, "", new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), 1, 3 },
                    { 471, "", new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), 1, 2 },
                    { 472, "", new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), 1, 3 },
                    { 473, "", new Guid("a48cafc5-4669-429d-825f-cf007df82222"), 4, 2 },
                    { 474, "", new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 475, "", new Guid("62873915-588a-422b-8a3d-520df41b621c"), 4, 1 },
                    { 476, "", new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), 1, 3 },
                    { 477, "", new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), 4, 3 },
                    { 478, "", new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), 3, 2 },
                    { 479, "", new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), 2, 1 },
                    { 480, "", new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), 1, 1 },
                    { 481, "", new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), 6, 3 },
                    { 482, "", new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), 4, 2 },
                    { 483, "", new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), 1, 1 },
                    { 484, "", new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), 2, 2 },
                    { 485, "", new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), 5, 1 },
                    { 486, "", new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), 4, 2 },
                    { 487, "", new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), 1, 3 },
                    { 488, "", new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), 1, 2 },
                    { 489, "", new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), 1, 3 },
                    { 490, "", new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), 6, 1 },
                    { 491, "", new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), 1, 1 },
                    { 492, "", new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), 1, 3 },
                    { 493, "", new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), 2, 3 },
                    { 494, "", new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), 4, 2 },
                    { 495, "", new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), 5, 1 },
                    { 496, "", new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), 6, 1 },
                    { 497, "", new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), 1, 2 },
                    { 498, "", new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), 3, 3 },
                    { 499, "", new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), 4, 1 },
                    { 500, "", new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), false },
                    { 2, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), false },
                    { 3, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), true },
                    { 4, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), true },
                    { 5, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), false },
                    { 6, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), false },
                    { 7, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), false },
                    { 8, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), false },
                    { 9, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), false },
                    { 10, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), true },
                    { 11, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), true },
                    { 12, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), false },
                    { 13, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), false },
                    { 14, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), true },
                    { 15, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), true },
                    { 16, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a48cafc5-4669-429d-825f-cf007df82222"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 17, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), false },
                    { 18, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), true },
                    { 19, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), false },
                    { 20, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), true },
                    { 21, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), true },
                    { 22, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e9550553-7082-46d5-9016-f04b082ce998"), true },
                    { 23, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), true },
                    { 24, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), false },
                    { 25, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), false },
                    { 26, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), true },
                    { 27, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), true },
                    { 28, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), false },
                    { 29, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), true },
                    { 30, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), false },
                    { 31, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), false },
                    { 32, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), true },
                    { 33, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), false },
                    { 34, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), true },
                    { 35, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), false },
                    { 36, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), false },
                    { 37, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), false },
                    { 38, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), false },
                    { 39, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), false },
                    { 40, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), true },
                    { 41, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), true },
                    { 42, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), true },
                    { 43, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), false },
                    { 44, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), true },
                    { 45, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), false },
                    { 46, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), false },
                    { 47, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), false },
                    { 48, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), false },
                    { 49, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), true },
                    { 50, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), true },
                    { 51, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), false },
                    { 52, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("377c1675-27c8-4144-af06-084d597f0051"), true },
                    { 53, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), false },
                    { 54, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), false },
                    { 55, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), true },
                    { 56, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), true },
                    { 57, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), false },
                    { 58, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 59, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), false },
                    { 60, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), true },
                    { 61, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), false },
                    { 62, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), false },
                    { 63, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), false },
                    { 64, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), true },
                    { 65, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), true },
                    { 66, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), true },
                    { 67, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), false },
                    { 68, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), true },
                    { 69, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), true },
                    { 70, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), false },
                    { 71, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), false },
                    { 72, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), false },
                    { 73, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), true },
                    { 74, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), false },
                    { 75, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), true },
                    { 76, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), false },
                    { 77, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), true },
                    { 78, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), false },
                    { 79, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), true },
                    { 80, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), false },
                    { 81, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), true },
                    { 82, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), false },
                    { 83, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), false },
                    { 84, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), true },
                    { 85, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), false },
                    { 86, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), true },
                    { 87, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), false },
                    { 88, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), true },
                    { 89, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), false },
                    { 90, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), true },
                    { 91, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), true },
                    { 92, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), true },
                    { 93, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), false },
                    { 94, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), false },
                    { 95, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), true },
                    { 96, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), false },
                    { 97, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), false },
                    { 98, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), false },
                    { 99, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), false },
                    { 100, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 101, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), false },
                    { 102, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), false },
                    { 103, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b7149f16-e029-4115-9d35-a4056970636d"), true },
                    { 104, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), false },
                    { 105, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), false },
                    { 106, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), true },
                    { 107, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), false },
                    { 108, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), false },
                    { 109, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("48772526-803a-4867-97db-4129d475d6ca"), true },
                    { 110, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), false },
                    { 111, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), true },
                    { 112, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), true },
                    { 113, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), true },
                    { 114, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), true },
                    { 115, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), false },
                    { 116, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), true },
                    { 117, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), false },
                    { 118, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), true },
                    { 119, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), false },
                    { 120, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), false },
                    { 121, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), false },
                    { 122, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), false },
                    { 123, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), true },
                    { 124, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), false },
                    { 125, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), false },
                    { 126, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("62873915-588a-422b-8a3d-520df41b621c"), true },
                    { 127, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), false },
                    { 128, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), true },
                    { 129, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), true },
                    { 130, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), false },
                    { 131, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), true },
                    { 132, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), false },
                    { 133, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), false },
                    { 134, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), true },
                    { 135, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), true },
                    { 136, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), true },
                    { 137, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), true },
                    { 138, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), false },
                    { 139, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), true },
                    { 140, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), true },
                    { 141, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), true },
                    { 142, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 143, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), false },
                    { 144, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), true },
                    { 145, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), true },
                    { 146, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), true },
                    { 147, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), true },
                    { 148, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), true },
                    { 149, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), false },
                    { 150, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), true },
                    { 151, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), true },
                    { 152, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"), true },
                    { 153, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), true },
                    { 154, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), false },
                    { 155, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), true },
                    { 156, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), true },
                    { 157, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("62873915-588a-422b-8a3d-520df41b621c"), false },
                    { 158, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), true },
                    { 159, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), false },
                    { 160, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), true },
                    { 161, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), false },
                    { 162, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), true },
                    { 163, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), true },
                    { 164, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), true },
                    { 165, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), false },
                    { 166, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), true },
                    { 167, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), false },
                    { 168, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), true },
                    { 169, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b7149f16-e029-4115-9d35-a4056970636d"), true },
                    { 170, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), false },
                    { 171, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), false },
                    { 172, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), false },
                    { 173, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), false },
                    { 174, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), true },
                    { 175, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), false },
                    { 176, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), false },
                    { 177, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), true },
                    { 178, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), false },
                    { 179, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), false },
                    { 180, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), false },
                    { 181, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("377c1675-27c8-4144-af06-084d597f0051"), true },
                    { 182, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), true },
                    { 183, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), false },
                    { 184, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 185, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a48cafc5-4669-429d-825f-cf007df82222"), false },
                    { 186, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), true },
                    { 187, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), true },
                    { 188, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), false },
                    { 189, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), false },
                    { 190, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), false },
                    { 191, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), false },
                    { 192, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), true },
                    { 193, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), true },
                    { 194, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), false },
                    { 195, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), true },
                    { 196, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), false },
                    { 197, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), true },
                    { 198, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), true },
                    { 199, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), false },
                    { 200, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), false },
                    { 201, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), true },
                    { 202, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), false },
                    { 203, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), false },
                    { 204, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), true },
                    { 205, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a48cafc5-4669-429d-825f-cf007df82222"), false },
                    { 206, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("377c1675-27c8-4144-af06-084d597f0051"), true },
                    { 207, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), true },
                    { 208, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), false },
                    { 209, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), false },
                    { 210, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), false },
                    { 211, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a48cafc5-4669-429d-825f-cf007df82222"), true },
                    { 212, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), false },
                    { 213, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), true },
                    { 214, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), true },
                    { 215, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), true },
                    { 216, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), true },
                    { 217, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), false },
                    { 218, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), false },
                    { 219, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), false },
                    { 220, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), false },
                    { 221, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), true },
                    { 222, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), false },
                    { 223, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), true },
                    { 224, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), true },
                    { 225, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), true },
                    { 226, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 227, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), false },
                    { 228, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), false },
                    { 229, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), false },
                    { 230, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), false },
                    { 231, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), true },
                    { 232, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), true },
                    { 233, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), false },
                    { 234, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), false },
                    { 235, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), true },
                    { 236, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), true },
                    { 237, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), false },
                    { 238, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"), false },
                    { 239, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e9550553-7082-46d5-9016-f04b082ce998"), false },
                    { 240, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), false },
                    { 241, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), false },
                    { 242, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), true },
                    { 243, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), true },
                    { 244, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("62873915-588a-422b-8a3d-520df41b621c"), true },
                    { 245, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), false },
                    { 246, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), true },
                    { 247, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), false },
                    { 248, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), false },
                    { 249, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), true },
                    { 250, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), true },
                    { 251, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), true },
                    { 252, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), false },
                    { 253, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), false },
                    { 254, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), true },
                    { 255, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), false },
                    { 256, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), false },
                    { 257, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), false },
                    { 258, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"), false },
                    { 259, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"), true },
                    { 260, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), true },
                    { 261, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), true },
                    { 262, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), false },
                    { 263, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), false },
                    { 264, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), true },
                    { 265, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), true },
                    { 266, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), false },
                    { 267, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), false },
                    { 268, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 269, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), true },
                    { 270, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"), false },
                    { 271, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), false },
                    { 272, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), true },
                    { 273, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), false },
                    { 274, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"), true },
                    { 275, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"), true },
                    { 276, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), true },
                    { 277, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), false },
                    { 278, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), false },
                    { 279, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"), true },
                    { 280, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), false },
                    { 281, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), false },
                    { 282, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), false },
                    { 283, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"), true },
                    { 284, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), true },
                    { 285, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), true },
                    { 286, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), false },
                    { 287, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), true },
                    { 288, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), false },
                    { 289, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("50384560-2944-4083-9419-a625949344c1"), false },
                    { 290, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), false },
                    { 291, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"), false },
                    { 292, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), true },
                    { 293, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), false },
                    { 294, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), true },
                    { 295, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), false },
                    { 296, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), true },
                    { 297, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), false },
                    { 298, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), true },
                    { 299, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), false },
                    { 300, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"), true },
                    { 301, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"), true },
                    { 302, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e9550553-7082-46d5-9016-f04b082ce998"), true },
                    { 303, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), true },
                    { 304, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), false },
                    { 305, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"), true },
                    { 306, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), false },
                    { 307, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), true },
                    { 308, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), false },
                    { 309, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), true },
                    { 310, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 311, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), false },
                    { 312, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), true },
                    { 313, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), true },
                    { 314, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), false },
                    { 315, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), false },
                    { 316, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), true },
                    { 317, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e9550553-7082-46d5-9016-f04b082ce998"), true },
                    { 318, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), false },
                    { 319, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), false },
                    { 320, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), true },
                    { 321, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), false },
                    { 322, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("62873915-588a-422b-8a3d-520df41b621c"), false },
                    { 323, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), false },
                    { 324, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), true },
                    { 325, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), false },
                    { 326, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), true },
                    { 327, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("50384560-2944-4083-9419-a625949344c1"), true },
                    { 328, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b7149f16-e029-4115-9d35-a4056970636d"), false },
                    { 329, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), false },
                    { 330, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), false },
                    { 331, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), true },
                    { 332, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("48772526-803a-4867-97db-4129d475d6ca"), true },
                    { 333, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"), true },
                    { 334, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), false },
                    { 335, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), true },
                    { 336, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), true },
                    { 337, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), false },
                    { 338, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), false },
                    { 339, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), true },
                    { 340, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), false },
                    { 341, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), false },
                    { 342, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), false },
                    { 343, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), false },
                    { 344, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), true },
                    { 345, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), false },
                    { 346, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), false },
                    { 347, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), true },
                    { 348, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), false },
                    { 349, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), true },
                    { 350, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), true },
                    { 351, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), false },
                    { 352, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 353, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), false },
                    { 354, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"), true },
                    { 355, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), false },
                    { 356, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), true },
                    { 357, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), true },
                    { 358, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), true },
                    { 359, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), false },
                    { 360, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), true },
                    { 361, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"), true },
                    { 362, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"), true },
                    { 363, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), true },
                    { 364, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"), false },
                    { 365, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), false },
                    { 366, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"), false },
                    { 367, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), false },
                    { 368, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), true },
                    { 369, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), false },
                    { 370, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), false },
                    { 371, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), false },
                    { 372, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), true },
                    { 373, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), true },
                    { 374, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), true },
                    { 375, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"), true },
                    { 376, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), false },
                    { 377, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("50384560-2944-4083-9419-a625949344c1"), true },
                    { 378, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), true },
                    { 379, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"), false },
                    { 380, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), true },
                    { 381, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), false },
                    { 382, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), true },
                    { 383, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"), true },
                    { 384, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), false },
                    { 385, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), false },
                    { 386, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), false },
                    { 387, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"), true },
                    { 388, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("62873915-588a-422b-8a3d-520df41b621c"), true },
                    { 389, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), false },
                    { 390, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), false },
                    { 391, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), true },
                    { 392, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("48772526-803a-4867-97db-4129d475d6ca"), true },
                    { 393, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("377c1675-27c8-4144-af06-084d597f0051"), true },
                    { 394, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 395, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e9550553-7082-46d5-9016-f04b082ce998"), false },
                    { 396, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), true },
                    { 397, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), true },
                    { 398, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), false },
                    { 399, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"), false },
                    { 400, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"), true },
                    { 401, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"), true },
                    { 402, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"), true },
                    { 403, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"), true },
                    { 404, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), true },
                    { 405, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"), false },
                    { 406, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), false },
                    { 407, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), true },
                    { 408, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"), true },
                    { 409, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"), false },
                    { 410, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("48772526-803a-4867-97db-4129d475d6ca"), true },
                    { 411, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), false },
                    { 412, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), true },
                    { 413, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"), false },
                    { 414, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"), false },
                    { 415, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"), false },
                    { 416, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"), true },
                    { 417, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), false },
                    { 418, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), true },
                    { 419, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), false },
                    { 420, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"), false },
                    { 421, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), false },
                    { 422, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b7149f16-e029-4115-9d35-a4056970636d"), true },
                    { 423, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b78949af-6166-4a64-b1e6-8281240643d7"), true },
                    { 424, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"), false },
                    { 425, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), false },
                    { 426, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), false },
                    { 427, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), true },
                    { 428, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), true },
                    { 429, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"), false },
                    { 430, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("50384560-2944-4083-9419-a625949344c1"), false },
                    { 431, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"), true },
                    { 432, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"), false },
                    { 433, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a48cafc5-4669-429d-825f-cf007df82222"), false },
                    { 434, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"), true },
                    { 435, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"), false },
                    { 436, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 437, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), true },
                    { 438, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), true },
                    { 439, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"), false },
                    { 440, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), true },
                    { 441, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), true },
                    { 442, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), true },
                    { 443, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"), true },
                    { 444, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"), true },
                    { 445, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3a331c1e-17db-4723-8814-868592f7f36d"), true },
                    { 446, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"), false },
                    { 447, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"), false },
                    { 448, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), false },
                    { 449, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), false },
                    { 450, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"), true },
                    { 451, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("29061f01-1b06-4273-bef0-e66e8de10101"), false },
                    { 452, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), true },
                    { 453, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), false },
                    { 454, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), false },
                    { 455, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"), false },
                    { 456, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"), true },
                    { 457, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"), true },
                    { 458, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b7149f16-e029-4115-9d35-a4056970636d"), true },
                    { 459, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"), true },
                    { 460, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("48772526-803a-4867-97db-4129d475d6ca"), true },
                    { 461, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"), true },
                    { 462, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"), true },
                    { 463, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"), true },
                    { 464, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"), false },
                    { 465, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"), false },
                    { 466, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"), false },
                    { 467, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), true },
                    { 468, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("377c1675-27c8-4144-af06-084d597f0051"), false },
                    { 469, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"), false },
                    { 470, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"), true },
                    { 471, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("50384560-2944-4083-9419-a625949344c1"), true },
                    { 472, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"), true },
                    { 473, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), true },
                    { 474, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"), true },
                    { 475, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"), true },
                    { 476, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"), true },
                    { 477, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"), true },
                    { 478, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 479, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("82bc0e13-aa10-4152-b246-548b498ea200"), false },
                    { 480, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"), false },
                    { 481, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"), true },
                    { 482, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("923ed226-5720-4e6b-81d4-a776f511533d"), true },
                    { 483, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"), true },
                    { 484, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"), true },
                    { 485, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"), false },
                    { 486, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"), false },
                    { 487, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1119104b-8392-4126-a7de-72976b5ea61a"), false },
                    { 488, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"), false },
                    { 489, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("27852f8b-8415-41f4-840c-977acf762e7e"), true },
                    { 490, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f3419292-1f72-4ba6-be06-231febc9e225"), true },
                    { 491, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"), true },
                    { 492, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"), true },
                    { 493, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"), false },
                    { 494, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"), true },
                    { 495, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"), true },
                    { 496, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"), false },
                    { 497, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"), false },
                    { 498, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"), true },
                    { 499, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"), true },
                    { 500, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"), false }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 4, new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7") },
                    { 2, 4, new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3") },
                    { 3, 5, new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234") },
                    { 4, 1, new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7") },
                    { 5, 6, new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe") },
                    { 6, 1, new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50") },
                    { 7, 7, new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49") },
                    { 8, 6, new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f") },
                    { 9, 9, new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd") },
                    { 10, 9, new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa") },
                    { 11, 8, new Guid("50384560-2944-4083-9419-a625949344c1") },
                    { 12, 1, new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a") },
                    { 13, 8, new Guid("923ed226-5720-4e6b-81d4-a776f511533d") },
                    { 14, 6, new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e") },
                    { 15, 7, new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4") },
                    { 16, 1, new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739") },
                    { 17, 7, new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac") },
                    { 18, 4, new Guid("3a331c1e-17db-4723-8814-868592f7f36d") },
                    { 19, 7, new Guid("a48cafc5-4669-429d-825f-cf007df82222") },
                    { 20, 8, new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 21, 5, new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69") },
                    { 22, 8, new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940") },
                    { 23, 9, new Guid("f5a83bce-53db-4315-a329-fa9352341fdf") },
                    { 24, 4, new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc") },
                    { 25, 8, new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea") },
                    { 26, 1, new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623") },
                    { 27, 8, new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463") },
                    { 28, 1, new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138") },
                    { 29, 3, new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f") },
                    { 30, 5, new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64") },
                    { 31, 9, new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c") },
                    { 32, 7, new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743") },
                    { 33, 6, new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8") },
                    { 34, 6, new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1") },
                    { 35, 9, new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd") },
                    { 36, 7, new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98") },
                    { 37, 8, new Guid("b78949af-6166-4a64-b1e6-8281240643d7") },
                    { 38, 7, new Guid("82bc0e13-aa10-4152-b246-548b498ea200") },
                    { 39, 5, new Guid("48772526-803a-4867-97db-4129d475d6ca") },
                    { 40, 9, new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41") },
                    { 41, 1, new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630") },
                    { 42, 3, new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe") },
                    { 43, 4, new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e") },
                    { 44, 3, new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116") },
                    { 45, 5, new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568") },
                    { 46, 9, new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f") },
                    { 47, 4, new Guid("97ac1a46-4325-4864-8333-d6b5c707195d") },
                    { 48, 5, new Guid("29061f01-1b06-4273-bef0-e66e8de10101") },
                    { 49, 4, new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61") },
                    { 50, 9, new Guid("f3419292-1f72-4ba6-be06-231febc9e225") },
                    { 51, 6, new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553") },
                    { 52, 2, new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8") },
                    { 53, 2, new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a") },
                    { 54, 8, new Guid("b3b4c220-2450-413a-a331-928f69ec49e7") },
                    { 55, 4, new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330") },
                    { 56, 7, new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc") },
                    { 57, 8, new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86") },
                    { 58, 8, new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706") },
                    { 59, 7, new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a") },
                    { 60, 6, new Guid("e9550553-7082-46d5-9016-f04b082ce998") },
                    { 61, 7, new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529") },
                    { 62, 8, new Guid("377c1675-27c8-4144-af06-084d597f0051") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 63, 8, new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad") },
                    { 64, 5, new Guid("4d81e693-423d-450b-aa27-3068e61df1cd") },
                    { 65, 2, new Guid("3a7f90c4-271e-4077-9025-a9188843a68d") },
                    { 66, 4, new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc") },
                    { 67, 3, new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d") },
                    { 68, 3, new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7") },
                    { 69, 9, new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57") },
                    { 70, 5, new Guid("69b2db0e-33dc-4136-8670-af8ead292e48") },
                    { 71, 2, new Guid("7d59d348-44da-4481-824f-106e5f9e68e5") },
                    { 72, 3, new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a") },
                    { 73, 8, new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff") },
                    { 74, 1, new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3") },
                    { 75, 7, new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d") },
                    { 76, 1, new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12") },
                    { 77, 2, new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb") },
                    { 78, 5, new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35") },
                    { 79, 1, new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8") },
                    { 80, 7, new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1") },
                    { 81, 3, new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66") },
                    { 82, 2, new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01") },
                    { 83, 4, new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4") },
                    { 84, 3, new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980") },
                    { 85, 2, new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62") },
                    { 86, 9, new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51") },
                    { 87, 7, new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4") },
                    { 88, 4, new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14") },
                    { 89, 4, new Guid("1119104b-8392-4126-a7de-72976b5ea61a") },
                    { 90, 2, new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf") },
                    { 91, 7, new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220") },
                    { 92, 1, new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f") },
                    { 93, 7, new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952") },
                    { 94, 8, new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450") },
                    { 95, 8, new Guid("b7149f16-e029-4115-9d35-a4056970636d") },
                    { 96, 3, new Guid("27852f8b-8415-41f4-840c-977acf762e7e") },
                    { 97, 7, new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580") },
                    { 98, 3, new Guid("751ae001-86c7-4801-a698-33f723ddfdb2") },
                    { 99, 7, new Guid("62873915-588a-422b-8a3d-520df41b621c") },
                    { 100, 7, new Guid("93182e12-00ce-4904-b6ae-152d7ef51884") },
                    { 1000, 1, new Guid("6f0bfaad-7851-4d81-8ce0-f260c6a7ca00") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7") },
                    { 2, 2, new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3") },
                    { 3, 3, new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 4, 4, new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7") },
                    { 5, 5, new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe") },
                    { 6, 6, new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50") },
                    { 7, 7, new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49") },
                    { 8, 8, new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f") },
                    { 9, 9, new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd") },
                    { 10, 10, new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa") },
                    { 11, 11, new Guid("50384560-2944-4083-9419-a625949344c1") },
                    { 12, 12, new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a") },
                    { 13, 13, new Guid("923ed226-5720-4e6b-81d4-a776f511533d") },
                    { 14, 14, new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e") },
                    { 15, 15, new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4") },
                    { 16, 16, new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739") },
                    { 17, 17, new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac") },
                    { 18, 18, new Guid("3a331c1e-17db-4723-8814-868592f7f36d") },
                    { 19, 19, new Guid("a48cafc5-4669-429d-825f-cf007df82222") },
                    { 20, 20, new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c") },
                    { 21, 21, new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69") },
                    { 22, 22, new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940") },
                    { 23, 23, new Guid("f5a83bce-53db-4315-a329-fa9352341fdf") },
                    { 24, 24, new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc") },
                    { 25, 25, new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea") },
                    { 26, 26, new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623") },
                    { 27, 27, new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463") },
                    { 28, 28, new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138") },
                    { 29, 29, new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f") },
                    { 30, 30, new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64") },
                    { 31, 31, new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c") },
                    { 32, 32, new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743") },
                    { 33, 33, new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8") },
                    { 34, 34, new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1") },
                    { 35, 35, new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd") },
                    { 36, 36, new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98") },
                    { 37, 37, new Guid("b78949af-6166-4a64-b1e6-8281240643d7") },
                    { 38, 38, new Guid("82bc0e13-aa10-4152-b246-548b498ea200") },
                    { 39, 39, new Guid("48772526-803a-4867-97db-4129d475d6ca") },
                    { 40, 40, new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41") },
                    { 41, 41, new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630") },
                    { 42, 42, new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe") },
                    { 43, 43, new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e") },
                    { 44, 44, new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116") },
                    { 45, 45, new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 46, 46, new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f") },
                    { 47, 47, new Guid("97ac1a46-4325-4864-8333-d6b5c707195d") },
                    { 48, 48, new Guid("29061f01-1b06-4273-bef0-e66e8de10101") },
                    { 49, 49, new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61") },
                    { 50, 50, new Guid("f3419292-1f72-4ba6-be06-231febc9e225") },
                    { 51, 51, new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553") },
                    { 52, 52, new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8") },
                    { 53, 53, new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a") },
                    { 54, 54, new Guid("b3b4c220-2450-413a-a331-928f69ec49e7") },
                    { 55, 55, new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330") },
                    { 56, 56, new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc") },
                    { 57, 57, new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86") },
                    { 58, 58, new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706") },
                    { 59, 59, new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a") },
                    { 60, 60, new Guid("e9550553-7082-46d5-9016-f04b082ce998") },
                    { 61, 61, new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529") },
                    { 62, 62, new Guid("377c1675-27c8-4144-af06-084d597f0051") },
                    { 63, 63, new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad") },
                    { 64, 64, new Guid("4d81e693-423d-450b-aa27-3068e61df1cd") },
                    { 65, 65, new Guid("3a7f90c4-271e-4077-9025-a9188843a68d") },
                    { 66, 66, new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc") },
                    { 67, 67, new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d") },
                    { 68, 68, new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7") },
                    { 69, 69, new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57") },
                    { 70, 70, new Guid("69b2db0e-33dc-4136-8670-af8ead292e48") },
                    { 71, 71, new Guid("7d59d348-44da-4481-824f-106e5f9e68e5") },
                    { 72, 72, new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a") },
                    { 73, 73, new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff") },
                    { 74, 74, new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3") },
                    { 75, 75, new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d") },
                    { 76, 76, new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12") },
                    { 77, 77, new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb") },
                    { 78, 78, new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35") },
                    { 79, 79, new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8") },
                    { 80, 80, new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1") },
                    { 81, 81, new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66") },
                    { 82, 82, new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01") },
                    { 83, 83, new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4") },
                    { 84, 84, new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980") },
                    { 85, 85, new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62") },
                    { 86, 86, new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51") },
                    { 87, 87, new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 88, 88, new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14") },
                    { 89, 89, new Guid("1119104b-8392-4126-a7de-72976b5ea61a") },
                    { 90, 90, new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf") },
                    { 91, 91, new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220") },
                    { 92, 92, new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f") },
                    { 93, 93, new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952") },
                    { 94, 94, new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450") },
                    { 95, 95, new Guid("b7149f16-e029-4115-9d35-a4056970636d") },
                    { 96, 96, new Guid("27852f8b-8415-41f4-840c-977acf762e7e") },
                    { 97, 97, new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580") },
                    { 98, 98, new Guid("751ae001-86c7-4801-a698-33f723ddfdb2") },
                    { 99, 99, new Guid("62873915-588a-422b-8a3d-520df41b621c") },
                    { 100, 100, new Guid("93182e12-00ce-4904-b6ae-152d7ef51884") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7") },
                    { 2, 1, new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3") },
                    { 3, 1, new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234") },
                    { 4, 1, new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7") },
                    { 5, 1, new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe") },
                    { 6, 1, new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50") },
                    { 7, 1, new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49") },
                    { 8, 1, new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f") },
                    { 9, 1, new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd") },
                    { 10, 1, new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa") },
                    { 11, 1, new Guid("50384560-2944-4083-9419-a625949344c1") },
                    { 12, 1, new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a") },
                    { 13, 1, new Guid("923ed226-5720-4e6b-81d4-a776f511533d") },
                    { 14, 1, new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e") },
                    { 15, 1, new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4") },
                    { 16, 1, new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739") },
                    { 17, 1, new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac") },
                    { 18, 1, new Guid("3a331c1e-17db-4723-8814-868592f7f36d") },
                    { 19, 1, new Guid("a48cafc5-4669-429d-825f-cf007df82222") },
                    { 20, 1, new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c") },
                    { 21, 1, new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69") },
                    { 22, 1, new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940") },
                    { 23, 1, new Guid("f5a83bce-53db-4315-a329-fa9352341fdf") },
                    { 24, 1, new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc") },
                    { 25, 1, new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea") },
                    { 26, 1, new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623") },
                    { 27, 1, new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463") },
                    { 28, 1, new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138") },
                    { 29, 1, new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 30, 1, new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64") },
                    { 31, 1, new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c") },
                    { 32, 1, new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743") },
                    { 33, 1, new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8") },
                    { 34, 1, new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1") },
                    { 35, 1, new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd") },
                    { 36, 1, new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98") },
                    { 37, 1, new Guid("b78949af-6166-4a64-b1e6-8281240643d7") },
                    { 38, 1, new Guid("82bc0e13-aa10-4152-b246-548b498ea200") },
                    { 39, 1, new Guid("48772526-803a-4867-97db-4129d475d6ca") },
                    { 40, 1, new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41") },
                    { 41, 1, new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630") },
                    { 42, 1, new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe") },
                    { 43, 1, new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e") },
                    { 44, 1, new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116") },
                    { 45, 1, new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568") },
                    { 46, 1, new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f") },
                    { 47, 1, new Guid("97ac1a46-4325-4864-8333-d6b5c707195d") },
                    { 48, 1, new Guid("29061f01-1b06-4273-bef0-e66e8de10101") },
                    { 49, 1, new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61") },
                    { 50, 1, new Guid("f3419292-1f72-4ba6-be06-231febc9e225") },
                    { 51, 1, new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553") },
                    { 52, 1, new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8") },
                    { 53, 1, new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a") },
                    { 54, 1, new Guid("b3b4c220-2450-413a-a331-928f69ec49e7") },
                    { 55, 1, new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330") },
                    { 56, 1, new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc") },
                    { 57, 1, new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86") },
                    { 58, 1, new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706") },
                    { 59, 1, new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a") },
                    { 60, 1, new Guid("e9550553-7082-46d5-9016-f04b082ce998") },
                    { 61, 1, new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529") },
                    { 62, 1, new Guid("377c1675-27c8-4144-af06-084d597f0051") },
                    { 63, 1, new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad") },
                    { 64, 1, new Guid("4d81e693-423d-450b-aa27-3068e61df1cd") },
                    { 65, 1, new Guid("3a7f90c4-271e-4077-9025-a9188843a68d") },
                    { 66, 1, new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc") },
                    { 67, 1, new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d") },
                    { 68, 1, new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7") },
                    { 69, 1, new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57") },
                    { 70, 1, new Guid("69b2db0e-33dc-4136-8670-af8ead292e48") },
                    { 71, 1, new Guid("7d59d348-44da-4481-824f-106e5f9e68e5") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 72, 1, new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a") },
                    { 73, 1, new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff") },
                    { 74, 1, new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3") },
                    { 75, 1, new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d") },
                    { 76, 1, new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12") },
                    { 77, 1, new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb") },
                    { 78, 1, new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35") },
                    { 79, 1, new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8") },
                    { 80, 1, new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1") },
                    { 81, 1, new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66") },
                    { 82, 1, new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01") },
                    { 83, 1, new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4") },
                    { 84, 1, new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980") },
                    { 85, 1, new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62") },
                    { 86, 1, new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51") },
                    { 87, 1, new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4") },
                    { 88, 1, new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14") },
                    { 89, 1, new Guid("1119104b-8392-4126-a7de-72976b5ea61a") },
                    { 90, 1, new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf") },
                    { 91, 1, new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220") },
                    { 92, 1, new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f") },
                    { 93, 1, new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952") },
                    { 94, 1, new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450") },
                    { 95, 1, new Guid("b7149f16-e029-4115-9d35-a4056970636d") },
                    { 96, 1, new Guid("27852f8b-8415-41f4-840c-977acf762e7e") },
                    { 97, 1, new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580") },
                    { 98, 1, new Guid("751ae001-86c7-4801-a698-33f723ddfdb2") },
                    { 99, 1, new Guid("62873915-588a-422b-8a3d-520df41b621c") },
                    { 100, 1, new Guid("93182e12-00ce-4904-b6ae-152d7ef51884") },
                    { 1000, 5, new Guid("6f0bfaad-7851-4d81-8ce0-f260c6a7ca00") }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 1, 1, 1, 16 },
                    { 2, 1, 2, 18 },
                    { 3, 1, 3, 16 },
                    { 4, 1, 4, 16 },
                    { 5, 1, 5, 1 },
                    { 6, 1, 6, 9 },
                    { 7, 1, 7, 1 },
                    { 8, 1, 8, 12 },
                    { 9, 1, 9, 6 },
                    { 10, 1, 10, 4 },
                    { 11, 1, 11, 18 },
                    { 12, 1, 12, 5 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 13, 1, 13, 4 },
                    { 14, 1, 14, 10 },
                    { 15, 1, 15, 13 },
                    { 16, 1, 16, 18 },
                    { 17, 1, 17, 2 },
                    { 18, 1, 18, 9 },
                    { 19, 1, 19, 8 },
                    { 20, 1, 20, 15 },
                    { 21, 1, 21, 3 },
                    { 22, 1, 22, 8 },
                    { 23, 1, 23, 12 },
                    { 24, 1, 24, 7 },
                    { 25, 1, 25, 5 },
                    { 26, 1, 26, 15 },
                    { 27, 1, 27, 6 },
                    { 28, 1, 28, 11 },
                    { 29, 1, 29, 3 },
                    { 30, 1, 30, 11 },
                    { 31, 1, 31, 11 },
                    { 32, 1, 32, 16 },
                    { 33, 1, 33, 10 },
                    { 34, 1, 34, 8 },
                    { 35, 1, 35, 6 },
                    { 36, 1, 36, 18 },
                    { 37, 1, 37, 16 },
                    { 38, 1, 38, 12 },
                    { 39, 1, 39, 13 },
                    { 40, 2, 40, 9 },
                    { 41, 2, 41, 10 },
                    { 42, 2, 42, 15 },
                    { 43, 2, 43, 8 },
                    { 44, 2, 44, 6 },
                    { 45, 2, 45, 11 },
                    { 46, 2, 46, 11 },
                    { 47, 2, 47, 3 },
                    { 48, 2, 48, 5 },
                    { 49, 2, 49, 16 },
                    { 50, 2, 50, 10 },
                    { 51, 2, 51, 5 },
                    { 52, 2, 52, 9 },
                    { 53, 2, 53, 18 },
                    { 54, 2, 54, 2 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 55, 2, 55, 1 },
                    { 56, 2, 56, 12 },
                    { 57, 2, 57, 7 },
                    { 58, 2, 58, 11 },
                    { 59, 2, 59, 7 },
                    { 60, 2, 60, 18 },
                    { 61, 2, 61, 18 },
                    { 62, 2, 62, 12 },
                    { 63, 2, 63, 5 },
                    { 64, 2, 64, 4 },
                    { 65, 2, 65, 16 },
                    { 66, 2, 66, 15 },
                    { 67, 2, 67, 15 },
                    { 68, 2, 68, 5 },
                    { 69, 2, 69, 11 },
                    { 70, 2, 70, 8 },
                    { 71, 2, 71, 15 },
                    { 72, 2, 72, 12 },
                    { 73, 2, 73, 16 },
                    { 74, 2, 74, 2 },
                    { 75, 2, 75, 6 },
                    { 76, 2, 76, 12 },
                    { 77, 2, 77, 6 },
                    { 78, 2, 78, 12 },
                    { 79, 2, 79, 15 },
                    { 80, 3, 80, 2 },
                    { 81, 3, 81, 17 },
                    { 82, 3, 82, 1 },
                    { 83, 3, 83, 12 },
                    { 84, 3, 84, 17 },
                    { 85, 3, 85, 10 },
                    { 86, 3, 86, 4 },
                    { 87, 3, 87, 6 },
                    { 88, 3, 88, 11 },
                    { 89, 3, 89, 13 },
                    { 90, 3, 90, 2 },
                    { 91, 3, 91, 10 },
                    { 92, 3, 92, 6 },
                    { 93, 3, 93, 6 },
                    { 94, 3, 94, 2 },
                    { 95, 3, 95, 4 },
                    { 96, 3, 96, 5 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 97, 3, 97, 11 },
                    { 98, 3, 98, 6 },
                    { 99, 3, 99, 11 },
                    { 100, 3, 100, 14 },
                    { 101, 3, 101, 7 },
                    { 102, 3, 102, 13 },
                    { 103, 3, 103, 11 },
                    { 104, 3, 104, 2 },
                    { 105, 3, 105, 5 },
                    { 106, 3, 106, 16 },
                    { 107, 3, 107, 4 },
                    { 108, 3, 108, 5 },
                    { 109, 3, 109, 2 },
                    { 110, 3, 110, 16 },
                    { 111, 3, 111, 1 },
                    { 112, 3, 112, 9 },
                    { 113, 3, 113, 13 },
                    { 114, 3, 114, 6 },
                    { 115, 3, 115, 6 },
                    { 116, 3, 116, 15 },
                    { 117, 3, 117, 8 },
                    { 118, 3, 118, 9 },
                    { 119, 3, 119, 15 },
                    { 120, 4, 120, 16 },
                    { 121, 4, 121, 15 },
                    { 122, 4, 122, 11 },
                    { 123, 4, 123, 11 },
                    { 124, 4, 124, 16 },
                    { 125, 4, 125, 15 },
                    { 126, 4, 126, 10 },
                    { 127, 4, 127, 3 },
                    { 128, 4, 128, 4 },
                    { 129, 4, 129, 11 },
                    { 130, 4, 130, 6 },
                    { 131, 4, 131, 3 },
                    { 132, 4, 132, 3 },
                    { 133, 4, 133, 9 },
                    { 134, 4, 134, 12 },
                    { 135, 4, 135, 5 },
                    { 136, 4, 136, 2 },
                    { 137, 4, 137, 2 },
                    { 138, 4, 138, 18 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 139, 4, 139, 7 },
                    { 140, 4, 140, 18 },
                    { 141, 4, 141, 15 },
                    { 142, 4, 142, 15 },
                    { 143, 4, 143, 18 },
                    { 144, 4, 144, 9 },
                    { 145, 4, 145, 7 },
                    { 146, 4, 146, 1 },
                    { 147, 4, 147, 6 },
                    { 148, 4, 148, 15 },
                    { 149, 4, 149, 14 },
                    { 150, 4, 150, 12 },
                    { 151, 4, 151, 13 },
                    { 152, 4, 152, 8 },
                    { 153, 4, 153, 13 },
                    { 154, 4, 154, 9 },
                    { 155, 4, 155, 13 },
                    { 156, 4, 156, 14 },
                    { 157, 4, 157, 17 },
                    { 158, 4, 158, 15 },
                    { 159, 4, 159, 9 },
                    { 160, 5, 160, 12 },
                    { 161, 5, 161, 1 },
                    { 162, 5, 162, 8 },
                    { 163, 5, 163, 9 },
                    { 164, 5, 164, 14 },
                    { 165, 5, 165, 16 },
                    { 166, 5, 166, 8 },
                    { 167, 5, 167, 4 },
                    { 168, 5, 168, 8 },
                    { 169, 5, 169, 8 },
                    { 170, 5, 170, 6 },
                    { 171, 5, 171, 14 },
                    { 172, 5, 172, 8 },
                    { 173, 5, 173, 1 },
                    { 174, 5, 174, 13 },
                    { 175, 5, 175, 5 },
                    { 176, 5, 176, 17 },
                    { 177, 5, 177, 4 },
                    { 178, 5, 178, 12 },
                    { 179, 5, 179, 18 },
                    { 180, 5, 180, 3 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 181, 5, 181, 12 },
                    { 182, 5, 182, 9 },
                    { 183, 5, 183, 1 },
                    { 184, 5, 184, 16 },
                    { 185, 5, 185, 7 },
                    { 186, 5, 186, 2 },
                    { 187, 5, 187, 12 },
                    { 188, 5, 188, 12 },
                    { 189, 5, 189, 6 },
                    { 190, 5, 190, 4 },
                    { 191, 5, 191, 15 },
                    { 192, 5, 192, 13 },
                    { 193, 5, 193, 13 },
                    { 194, 5, 194, 6 },
                    { 195, 5, 195, 5 },
                    { 196, 5, 196, 18 },
                    { 197, 5, 197, 18 },
                    { 198, 5, 198, 8 },
                    { 199, 5, 199, 13 },
                    { 200, 6, 200, 8 },
                    { 201, 6, 201, 6 },
                    { 202, 6, 202, 11 },
                    { 203, 6, 203, 3 },
                    { 204, 6, 204, 9 },
                    { 205, 6, 205, 2 },
                    { 206, 6, 206, 4 },
                    { 207, 6, 207, 4 },
                    { 208, 6, 208, 1 },
                    { 209, 6, 209, 13 },
                    { 210, 6, 210, 17 },
                    { 211, 6, 211, 13 },
                    { 212, 6, 212, 14 },
                    { 213, 6, 213, 15 },
                    { 214, 6, 214, 12 },
                    { 215, 6, 215, 5 },
                    { 216, 6, 216, 15 },
                    { 217, 6, 217, 17 },
                    { 218, 6, 218, 7 },
                    { 219, 6, 219, 12 },
                    { 220, 6, 220, 2 },
                    { 221, 6, 221, 4 },
                    { 222, 6, 222, 14 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 223, 6, 223, 12 },
                    { 224, 6, 224, 18 },
                    { 225, 6, 225, 5 },
                    { 226, 6, 226, 5 },
                    { 227, 6, 227, 6 },
                    { 228, 6, 228, 3 },
                    { 229, 6, 229, 3 },
                    { 230, 6, 230, 12 },
                    { 231, 6, 231, 8 },
                    { 232, 6, 232, 9 },
                    { 233, 6, 233, 11 },
                    { 234, 6, 234, 10 },
                    { 235, 6, 235, 13 },
                    { 236, 6, 236, 1 },
                    { 237, 6, 237, 4 },
                    { 238, 6, 238, 16 },
                    { 239, 6, 239, 2 },
                    { 240, 7, 240, 18 },
                    { 241, 7, 241, 13 },
                    { 242, 7, 242, 10 },
                    { 243, 7, 243, 4 },
                    { 244, 7, 244, 6 },
                    { 245, 7, 245, 3 },
                    { 246, 7, 246, 18 },
                    { 247, 7, 247, 7 },
                    { 248, 7, 248, 6 },
                    { 249, 7, 249, 5 },
                    { 250, 7, 250, 11 },
                    { 251, 7, 251, 3 },
                    { 252, 7, 252, 13 },
                    { 253, 7, 253, 17 },
                    { 254, 7, 254, 17 },
                    { 255, 7, 255, 3 },
                    { 256, 7, 256, 5 },
                    { 257, 7, 257, 3 },
                    { 258, 7, 258, 11 },
                    { 259, 7, 259, 9 },
                    { 260, 7, 260, 5 },
                    { 261, 7, 261, 13 },
                    { 262, 7, 262, 7 },
                    { 263, 7, 263, 11 },
                    { 264, 7, 264, 6 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 265, 7, 265, 13 },
                    { 266, 7, 266, 16 },
                    { 267, 7, 267, 10 },
                    { 268, 7, 268, 6 },
                    { 269, 7, 269, 2 },
                    { 270, 7, 270, 15 },
                    { 271, 7, 271, 15 },
                    { 272, 7, 272, 13 },
                    { 273, 7, 273, 15 },
                    { 274, 7, 274, 8 },
                    { 275, 7, 275, 5 },
                    { 276, 7, 276, 3 },
                    { 277, 7, 277, 9 },
                    { 278, 7, 278, 13 },
                    { 279, 7, 279, 14 },
                    { 280, 8, 280, 16 },
                    { 281, 8, 281, 16 },
                    { 282, 8, 282, 13 },
                    { 283, 8, 283, 18 },
                    { 284, 8, 284, 3 },
                    { 285, 8, 285, 1 },
                    { 286, 8, 286, 13 },
                    { 287, 8, 287, 3 },
                    { 288, 8, 288, 13 },
                    { 289, 8, 289, 2 },
                    { 290, 8, 290, 1 },
                    { 291, 8, 291, 10 },
                    { 292, 8, 292, 10 },
                    { 293, 8, 293, 10 },
                    { 294, 8, 294, 5 },
                    { 295, 8, 295, 9 },
                    { 296, 8, 296, 3 },
                    { 297, 8, 297, 14 },
                    { 298, 8, 298, 5 },
                    { 299, 8, 299, 9 },
                    { 300, 8, 300, 13 },
                    { 301, 8, 301, 17 },
                    { 302, 8, 302, 14 },
                    { 303, 8, 303, 9 },
                    { 304, 8, 304, 3 },
                    { 305, 8, 305, 10 },
                    { 306, 8, 306, 13 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 307, 8, 307, 13 },
                    { 308, 8, 308, 1 },
                    { 309, 8, 309, 17 },
                    { 310, 8, 310, 15 },
                    { 311, 8, 311, 3 },
                    { 312, 8, 312, 1 },
                    { 313, 8, 313, 3 },
                    { 314, 8, 314, 15 },
                    { 315, 8, 315, 13 },
                    { 316, 8, 316, 9 },
                    { 317, 8, 317, 16 },
                    { 318, 8, 318, 15 },
                    { 319, 8, 319, 13 },
                    { 320, 9, 320, 8 },
                    { 321, 9, 321, 18 },
                    { 322, 9, 322, 4 },
                    { 323, 9, 323, 8 },
                    { 324, 9, 324, 13 },
                    { 325, 9, 325, 1 },
                    { 326, 9, 326, 11 },
                    { 327, 9, 327, 17 },
                    { 328, 9, 328, 15 },
                    { 329, 9, 329, 17 },
                    { 330, 9, 330, 13 },
                    { 331, 9, 331, 12 },
                    { 332, 9, 332, 1 },
                    { 333, 9, 333, 10 },
                    { 334, 9, 334, 5 },
                    { 335, 9, 335, 3 },
                    { 336, 9, 336, 5 },
                    { 337, 9, 337, 3 },
                    { 338, 9, 338, 5 },
                    { 339, 9, 339, 13 },
                    { 340, 9, 340, 13 },
                    { 341, 9, 341, 14 },
                    { 342, 9, 342, 4 },
                    { 343, 9, 343, 16 },
                    { 344, 9, 344, 7 },
                    { 345, 9, 345, 18 },
                    { 346, 9, 346, 14 },
                    { 347, 9, 347, 12 },
                    { 348, 9, 348, 8 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 349, 9, 349, 7 },
                    { 350, 9, 350, 4 },
                    { 351, 9, 351, 3 },
                    { 352, 9, 352, 12 },
                    { 353, 9, 353, 2 },
                    { 354, 9, 354, 10 },
                    { 355, 9, 355, 10 },
                    { 356, 9, 356, 4 },
                    { 357, 9, 357, 3 },
                    { 358, 9, 358, 18 },
                    { 359, 9, 359, 10 },
                    { 360, 10, 360, 17 },
                    { 361, 10, 361, 3 },
                    { 362, 10, 362, 14 },
                    { 363, 10, 363, 14 },
                    { 364, 10, 364, 1 },
                    { 365, 10, 365, 11 },
                    { 366, 10, 366, 15 },
                    { 367, 10, 367, 6 },
                    { 368, 10, 368, 16 },
                    { 369, 10, 369, 5 },
                    { 370, 10, 370, 5 },
                    { 371, 10, 371, 14 },
                    { 372, 10, 372, 11 },
                    { 373, 10, 373, 13 },
                    { 374, 10, 374, 3 },
                    { 375, 10, 375, 16 },
                    { 376, 10, 376, 8 },
                    { 377, 10, 377, 6 },
                    { 378, 10, 378, 16 },
                    { 379, 10, 379, 10 },
                    { 380, 10, 380, 14 },
                    { 381, 10, 381, 11 },
                    { 382, 10, 382, 7 },
                    { 383, 10, 383, 10 },
                    { 384, 10, 384, 10 },
                    { 385, 10, 385, 3 },
                    { 386, 10, 386, 3 },
                    { 387, 10, 387, 17 },
                    { 388, 10, 388, 11 },
                    { 389, 10, 389, 4 },
                    { 390, 10, 390, 7 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 391, 10, 391, 7 },
                    { 392, 10, 392, 10 },
                    { 393, 10, 393, 7 },
                    { 394, 10, 394, 7 },
                    { 395, 10, 395, 5 },
                    { 396, 10, 396, 17 },
                    { 397, 10, 397, 17 },
                    { 398, 10, 398, 18 },
                    { 399, 10, 399, 1 },
                    { 400, 10, 400, 3 }
                });

            migrationBuilder.InsertData(
                table: "LessonApprove",
                columns: new[] { "LessonApproveID", "FK_ApproveID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 24, 1 },
                    { 2, 1, 2 },
                    { 3, 28, 3 },
                    { 4, 11, 4 },
                    { 5, 2, 5 },
                    { 6, 9, 6 },
                    { 7, 13, 7 },
                    { 8, 7, 8 },
                    { 9, 26, 9 },
                    { 10, 8, 10 },
                    { 11, 16, 11 },
                    { 12, 25, 12 },
                    { 13, 23, 13 },
                    { 14, 19, 14 },
                    { 15, 30, 15 },
                    { 16, 29, 16 },
                    { 17, 10, 17 },
                    { 18, 3, 18 },
                    { 19, 6, 19 },
                    { 20, 4, 20 },
                    { 21, 15, 21 },
                    { 22, 14, 22 },
                    { 23, 12, 23 },
                    { 24, 17, 24 },
                    { 25, 21, 25 },
                    { 26, 22, 26 },
                    { 27, 5, 27 },
                    { 28, 27, 28 },
                    { 29, 20, 29 },
                    { 30, 18, 30 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 191, 1 },
                    { 2, 409, 2 },
                    { 3, 399, 3 },
                    { 4, 121, 4 },
                    { 5, 145, 5 },
                    { 6, 430, 6 },
                    { 7, 249, 7 },
                    { 8, 23, 8 },
                    { 9, 184, 9 },
                    { 10, 425, 10 },
                    { 11, 433, 11 },
                    { 12, 244, 12 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 13, 255, 13 },
                    { 14, 140, 14 },
                    { 15, 181, 15 },
                    { 16, 195, 16 },
                    { 17, 374, 17 },
                    { 18, 378, 18 },
                    { 19, 428, 19 },
                    { 20, 34, 20 },
                    { 21, 389, 21 },
                    { 22, 16, 22 },
                    { 23, 196, 23 },
                    { 24, 9, 24 },
                    { 25, 330, 25 },
                    { 26, 214, 26 },
                    { 27, 67, 27 },
                    { 28, 22, 28 },
                    { 29, 93, 29 },
                    { 30, 118, 30 },
                    { 31, 429, 31 },
                    { 32, 491, 32 },
                    { 33, 270, 33 },
                    { 34, 263, 34 },
                    { 35, 293, 35 },
                    { 36, 176, 36 },
                    { 37, 250, 37 },
                    { 38, 406, 38 },
                    { 39, 297, 39 },
                    { 40, 71, 40 },
                    { 41, 7, 41 },
                    { 42, 213, 42 },
                    { 43, 279, 43 },
                    { 44, 473, 44 },
                    { 45, 243, 45 },
                    { 46, 424, 46 },
                    { 47, 226, 47 },
                    { 48, 299, 48 },
                    { 49, 187, 49 },
                    { 50, 479, 50 },
                    { 51, 301, 51 },
                    { 52, 3, 52 },
                    { 53, 13, 53 },
                    { 54, 21, 54 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 55, 277, 55 },
                    { 56, 334, 56 },
                    { 57, 394, 57 },
                    { 58, 69, 58 },
                    { 59, 83, 59 },
                    { 60, 486, 60 },
                    { 61, 228, 61 },
                    { 62, 28, 62 },
                    { 63, 352, 63 },
                    { 64, 372, 64 },
                    { 65, 61, 65 },
                    { 66, 333, 66 },
                    { 67, 471, 67 },
                    { 68, 136, 68 },
                    { 69, 413, 69 },
                    { 70, 415, 70 },
                    { 71, 210, 71 },
                    { 72, 240, 72 },
                    { 73, 351, 73 },
                    { 74, 237, 74 },
                    { 75, 51, 75 },
                    { 76, 361, 76 },
                    { 77, 183, 77 },
                    { 78, 163, 78 },
                    { 79, 162, 79 },
                    { 80, 114, 80 },
                    { 81, 261, 81 },
                    { 82, 443, 82 },
                    { 83, 499, 83 },
                    { 84, 463, 84 },
                    { 85, 384, 85 },
                    { 86, 17, 86 },
                    { 87, 201, 87 },
                    { 88, 82, 88 },
                    { 89, 287, 89 },
                    { 90, 112, 90 },
                    { 91, 129, 91 },
                    { 92, 377, 92 },
                    { 93, 459, 93 },
                    { 94, 450, 94 },
                    { 95, 337, 95 },
                    { 96, 481, 96 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 97, 416, 97 },
                    { 98, 211, 98 },
                    { 99, 166, 99 },
                    { 100, 216, 100 },
                    { 101, 147, 101 },
                    { 102, 246, 102 },
                    { 103, 272, 103 },
                    { 104, 314, 104 },
                    { 105, 346, 105 },
                    { 106, 469, 106 },
                    { 107, 472, 107 },
                    { 108, 57, 108 },
                    { 109, 37, 109 },
                    { 110, 305, 110 },
                    { 111, 285, 111 },
                    { 112, 497, 112 },
                    { 113, 32, 113 },
                    { 114, 308, 114 },
                    { 115, 494, 115 },
                    { 116, 64, 116 },
                    { 117, 282, 117 },
                    { 118, 254, 118 },
                    { 119, 295, 119 },
                    { 120, 421, 120 },
                    { 121, 353, 121 },
                    { 122, 369, 122 },
                    { 123, 329, 123 },
                    { 124, 318, 124 },
                    { 125, 105, 125 },
                    { 126, 198, 126 },
                    { 127, 78, 127 },
                    { 128, 242, 128 },
                    { 129, 400, 129 },
                    { 130, 341, 130 },
                    { 131, 278, 131 },
                    { 132, 267, 132 },
                    { 133, 38, 133 },
                    { 134, 215, 134 },
                    { 135, 25, 135 },
                    { 136, 483, 136 },
                    { 137, 362, 137 },
                    { 138, 358, 138 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 139, 340, 139 },
                    { 140, 169, 140 },
                    { 141, 359, 141 },
                    { 142, 94, 142 },
                    { 143, 229, 143 },
                    { 144, 468, 144 },
                    { 145, 411, 145 },
                    { 146, 488, 146 },
                    { 147, 323, 147 },
                    { 148, 253, 148 },
                    { 149, 81, 149 },
                    { 150, 268, 150 },
                    { 151, 155, 151 },
                    { 152, 159, 152 },
                    { 153, 356, 153 },
                    { 154, 298, 154 },
                    { 155, 220, 155 },
                    { 156, 252, 156 },
                    { 157, 434, 157 },
                    { 158, 185, 158 },
                    { 159, 88, 159 },
                    { 160, 273, 160 },
                    { 161, 289, 161 },
                    { 162, 247, 162 },
                    { 163, 440, 163 },
                    { 164, 48, 164 },
                    { 165, 467, 165 },
                    { 166, 348, 166 },
                    { 167, 91, 167 },
                    { 168, 230, 168 },
                    { 169, 466, 169 },
                    { 170, 221, 170 },
                    { 171, 388, 171 },
                    { 172, 92, 172 },
                    { 173, 393, 173 },
                    { 174, 139, 174 },
                    { 175, 203, 175 },
                    { 176, 387, 176 },
                    { 177, 190, 177 },
                    { 178, 4, 178 },
                    { 179, 120, 179 },
                    { 180, 234, 180 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 181, 241, 181 },
                    { 182, 164, 182 },
                    { 183, 462, 183 },
                    { 184, 355, 184 },
                    { 185, 165, 185 },
                    { 186, 111, 186 },
                    { 187, 179, 187 },
                    { 188, 311, 188 },
                    { 189, 336, 189 },
                    { 190, 219, 190 },
                    { 191, 26, 191 },
                    { 192, 276, 192 },
                    { 193, 58, 193 },
                    { 194, 122, 194 },
                    { 195, 141, 195 },
                    { 196, 391, 196 },
                    { 197, 106, 197 },
                    { 198, 239, 198 },
                    { 199, 217, 199 },
                    { 200, 405, 200 },
                    { 201, 419, 201 },
                    { 202, 119, 202 },
                    { 203, 446, 203 },
                    { 204, 484, 204 },
                    { 205, 95, 205 },
                    { 206, 134, 206 },
                    { 207, 248, 207 },
                    { 208, 29, 208 },
                    { 209, 41, 209 },
                    { 210, 142, 210 },
                    { 211, 168, 211 },
                    { 212, 84, 212 },
                    { 213, 77, 213 },
                    { 214, 153, 214 },
                    { 215, 382, 215 },
                    { 216, 404, 216 },
                    { 217, 218, 217 },
                    { 218, 410, 218 },
                    { 219, 347, 219 },
                    { 220, 364, 220 },
                    { 221, 55, 221 },
                    { 222, 31, 222 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 223, 304, 223 },
                    { 224, 408, 224 },
                    { 225, 70, 225 },
                    { 226, 15, 226 },
                    { 227, 375, 227 },
                    { 228, 96, 228 },
                    { 229, 456, 229 },
                    { 230, 397, 230 },
                    { 231, 157, 231 },
                    { 232, 193, 232 },
                    { 233, 14, 233 },
                    { 234, 47, 234 },
                    { 235, 453, 235 },
                    { 236, 445, 236 },
                    { 237, 414, 237 },
                    { 238, 63, 238 },
                    { 239, 19, 239 },
                    { 240, 177, 240 },
                    { 241, 349, 241 },
                    { 242, 280, 242 },
                    { 243, 402, 243 },
                    { 244, 125, 244 },
                    { 245, 123, 245 },
                    { 246, 470, 246 },
                    { 247, 170, 247 },
                    { 248, 18, 248 },
                    { 249, 441, 249 },
                    { 250, 44, 250 },
                    { 251, 232, 251 },
                    { 252, 110, 252 },
                    { 253, 365, 253 },
                    { 254, 458, 254 },
                    { 255, 113, 255 },
                    { 256, 12, 256 },
                    { 257, 259, 257 },
                    { 258, 66, 258 },
                    { 259, 444, 259 },
                    { 260, 6, 260 },
                    { 261, 390, 261 },
                    { 262, 480, 262 },
                    { 263, 104, 263 },
                    { 264, 498, 264 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 265, 172, 265 },
                    { 266, 461, 266 },
                    { 267, 281, 267 },
                    { 268, 87, 268 },
                    { 269, 225, 269 },
                    { 270, 115, 270 },
                    { 271, 109, 271 },
                    { 272, 54, 272 },
                    { 273, 275, 273 },
                    { 274, 45, 274 },
                    { 275, 426, 275 },
                    { 276, 137, 276 },
                    { 277, 432, 277 },
                    { 278, 319, 278 },
                    { 279, 271, 279 },
                    { 280, 251, 280 },
                    { 281, 194, 281 },
                    { 282, 117, 282 },
                    { 283, 315, 283 },
                    { 284, 238, 284 },
                    { 285, 363, 285 },
                    { 286, 392, 286 },
                    { 287, 373, 287 },
                    { 288, 492, 288 },
                    { 289, 380, 289 },
                    { 290, 448, 290 },
                    { 291, 108, 291 },
                    { 292, 186, 292 },
                    { 293, 43, 293 },
                    { 294, 130, 294 },
                    { 295, 489, 295 },
                    { 296, 205, 296 },
                    { 297, 192, 297 },
                    { 298, 439, 298 },
                    { 299, 344, 299 },
                    { 300, 11, 300 },
                    { 301, 79, 301 },
                    { 302, 326, 302 },
                    { 303, 265, 303 },
                    { 304, 407, 304 },
                    { 305, 493, 305 },
                    { 306, 68, 306 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 307, 133, 307 },
                    { 308, 10, 308 },
                    { 309, 452, 309 },
                    { 310, 131, 310 },
                    { 311, 126, 311 },
                    { 312, 235, 312 },
                    { 313, 188, 313 },
                    { 314, 80, 314 },
                    { 315, 269, 315 },
                    { 316, 197, 316 },
                    { 317, 189, 317 },
                    { 318, 116, 318 },
                    { 319, 138, 319 },
                    { 320, 85, 320 },
                    { 321, 24, 321 },
                    { 322, 36, 322 },
                    { 323, 431, 323 },
                    { 324, 2, 324 },
                    { 325, 264, 325 },
                    { 326, 447, 326 },
                    { 327, 103, 327 },
                    { 328, 222, 328 },
                    { 329, 370, 329 },
                    { 330, 435, 330 },
                    { 331, 368, 331 },
                    { 332, 303, 332 },
                    { 333, 132, 333 },
                    { 334, 283, 334 },
                    { 335, 321, 335 },
                    { 336, 475, 336 },
                    { 337, 146, 337 },
                    { 338, 328, 338 },
                    { 339, 327, 339 },
                    { 340, 46, 340 },
                    { 341, 449, 341 },
                    { 342, 442, 342 },
                    { 343, 381, 343 },
                    { 344, 99, 344 },
                    { 345, 182, 345 },
                    { 346, 423, 346 },
                    { 347, 102, 347 },
                    { 348, 417, 348 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 349, 367, 349 },
                    { 350, 477, 350 },
                    { 351, 60, 351 },
                    { 352, 62, 352 },
                    { 353, 100, 353 },
                    { 354, 427, 354 },
                    { 355, 42, 355 },
                    { 356, 149, 356 },
                    { 357, 345, 357 },
                    { 358, 316, 358 },
                    { 359, 286, 359 },
                    { 360, 143, 360 },
                    { 361, 395, 361 },
                    { 362, 496, 362 },
                    { 363, 284, 363 },
                    { 364, 65, 364 },
                    { 365, 20, 365 },
                    { 366, 156, 366 },
                    { 367, 455, 367 },
                    { 368, 325, 368 },
                    { 369, 5, 369 },
                    { 370, 342, 370 },
                    { 371, 332, 371 },
                    { 372, 124, 372 },
                    { 373, 152, 373 },
                    { 374, 148, 374 },
                    { 375, 386, 375 },
                    { 376, 171, 376 },
                    { 377, 383, 377 },
                    { 378, 288, 378 },
                    { 379, 224, 379 },
                    { 380, 150, 380 },
                    { 381, 322, 381 },
                    { 382, 180, 382 },
                    { 383, 418, 383 },
                    { 384, 212, 384 },
                    { 385, 257, 385 },
                    { 386, 500, 386 },
                    { 387, 158, 387 },
                    { 388, 260, 388 },
                    { 389, 206, 389 },
                    { 390, 199, 390 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 391, 258, 391 },
                    { 392, 312, 392 },
                    { 393, 292, 393 },
                    { 394, 160, 394 },
                    { 395, 310, 395 },
                    { 396, 173, 396 },
                    { 397, 74, 397 },
                    { 398, 30, 398 },
                    { 399, 482, 399 },
                    { 400, 39, 400 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 1, 1, 50 },
                    { 2, 2, 119 },
                    { 3, 3, 286 },
                    { 4, 4, 128 },
                    { 5, 5, 450 },
                    { 6, 6, 121 },
                    { 7, 7, 412 },
                    { 8, 8, 470 },
                    { 9, 9, 382 },
                    { 10, 10, 209 },
                    { 11, 11, 318 },
                    { 12, 12, 262 },
                    { 13, 13, 175 },
                    { 14, 14, 327 },
                    { 15, 15, 467 },
                    { 16, 16, 127 },
                    { 17, 17, 98 },
                    { 18, 18, 5 },
                    { 19, 19, 90 },
                    { 20, 20, 304 },
                    { 21, 21, 53 },
                    { 22, 22, 294 },
                    { 23, 23, 170 },
                    { 24, 24, 393 },
                    { 25, 25, 406 },
                    { 26, 26, 440 },
                    { 27, 27, 426 },
                    { 28, 28, 227 },
                    { 29, 29, 200 },
                    { 30, 30, 255 },
                    { 31, 31, 79 },
                    { 32, 32, 458 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 33, 33, 399 },
                    { 34, 34, 226 },
                    { 35, 35, 357 },
                    { 36, 36, 110 },
                    { 37, 37, 457 },
                    { 38, 38, 468 },
                    { 39, 39, 93 },
                    { 40, 40, 498 },
                    { 41, 41, 434 },
                    { 42, 42, 92 },
                    { 43, 43, 350 },
                    { 44, 44, 251 },
                    { 45, 45, 185 },
                    { 46, 46, 427 },
                    { 47, 47, 261 },
                    { 48, 48, 228 },
                    { 49, 49, 270 },
                    { 50, 50, 325 },
                    { 51, 51, 359 },
                    { 52, 52, 21 },
                    { 53, 53, 448 },
                    { 54, 54, 407 },
                    { 55, 55, 328 },
                    { 56, 56, 3 },
                    { 57, 57, 22 },
                    { 58, 58, 374 },
                    { 59, 59, 57 },
                    { 60, 60, 240 },
                    { 61, 61, 2 },
                    { 62, 62, 462 },
                    { 63, 63, 500 },
                    { 64, 64, 371 },
                    { 65, 65, 313 },
                    { 66, 66, 81 },
                    { 67, 67, 215 },
                    { 68, 68, 66 },
                    { 69, 69, 446 },
                    { 70, 70, 14 },
                    { 71, 71, 377 },
                    { 72, 72, 429 },
                    { 73, 73, 408 },
                    { 74, 74, 263 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 75, 75, 486 },
                    { 76, 76, 83 },
                    { 77, 77, 88 },
                    { 78, 78, 63 },
                    { 79, 79, 195 },
                    { 80, 80, 301 },
                    { 81, 81, 415 },
                    { 82, 82, 95 },
                    { 83, 83, 206 },
                    { 84, 84, 441 },
                    { 85, 85, 130 },
                    { 86, 86, 224 },
                    { 87, 87, 61 },
                    { 88, 88, 202 },
                    { 89, 89, 335 },
                    { 90, 90, 38 },
                    { 91, 91, 309 },
                    { 92, 92, 55 },
                    { 93, 93, 375 },
                    { 94, 94, 153 },
                    { 95, 95, 310 },
                    { 96, 96, 402 },
                    { 97, 97, 28 },
                    { 98, 98, 189 },
                    { 99, 99, 111 },
                    { 100, 100, 243 },
                    { 101, 101, 76 },
                    { 102, 102, 162 },
                    { 103, 103, 149 },
                    { 104, 104, 284 },
                    { 105, 105, 246 },
                    { 106, 106, 34 },
                    { 107, 107, 466 },
                    { 108, 108, 30 },
                    { 109, 109, 32 },
                    { 110, 110, 461 },
                    { 111, 111, 494 },
                    { 112, 112, 24 },
                    { 113, 113, 142 },
                    { 114, 114, 383 },
                    { 115, 115, 410 },
                    { 116, 116, 223 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 117, 117, 360 },
                    { 118, 118, 213 },
                    { 119, 119, 112 },
                    { 120, 120, 292 },
                    { 121, 121, 37 },
                    { 122, 122, 182 },
                    { 123, 123, 125 },
                    { 124, 124, 16 },
                    { 125, 125, 146 },
                    { 126, 126, 496 },
                    { 127, 127, 47 },
                    { 128, 128, 276 },
                    { 129, 129, 422 },
                    { 130, 130, 497 },
                    { 131, 131, 160 },
                    { 132, 132, 463 },
                    { 133, 133, 187 },
                    { 134, 134, 472 },
                    { 135, 135, 419 },
                    { 136, 136, 499 },
                    { 137, 137, 115 },
                    { 138, 138, 275 },
                    { 139, 139, 231 },
                    { 140, 140, 300 },
                    { 141, 141, 322 },
                    { 142, 142, 1 },
                    { 143, 143, 101 },
                    { 144, 144, 317 },
                    { 145, 145, 169 },
                    { 146, 146, 473 },
                    { 147, 147, 258 },
                    { 148, 148, 60 },
                    { 149, 149, 137 },
                    { 150, 150, 10 },
                    { 151, 151, 365 },
                    { 152, 152, 73 },
                    { 153, 153, 42 },
                    { 154, 154, 117 },
                    { 155, 155, 123 },
                    { 156, 156, 471 },
                    { 157, 157, 485 },
                    { 158, 158, 78 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 159, 159, 488 },
                    { 160, 160, 348 },
                    { 161, 161, 368 },
                    { 162, 162, 124 },
                    { 163, 163, 356 },
                    { 164, 164, 232 },
                    { 165, 165, 171 },
                    { 166, 166, 389 },
                    { 167, 167, 283 },
                    { 168, 168, 387 },
                    { 169, 169, 295 },
                    { 170, 170, 234 },
                    { 171, 171, 296 },
                    { 172, 172, 341 },
                    { 173, 173, 97 },
                    { 174, 174, 435 },
                    { 175, 175, 476 },
                    { 176, 176, 460 },
                    { 177, 177, 370 },
                    { 178, 178, 184 },
                    { 179, 179, 107 },
                    { 180, 180, 287 },
                    { 181, 181, 106 },
                    { 182, 182, 86 },
                    { 183, 183, 235 },
                    { 184, 184, 388 },
                    { 185, 185, 44 },
                    { 186, 186, 362 },
                    { 187, 187, 336 },
                    { 188, 188, 25 },
                    { 189, 189, 68 },
                    { 190, 190, 203 },
                    { 191, 191, 248 },
                    { 192, 192, 391 },
                    { 193, 193, 181 },
                    { 194, 194, 116 },
                    { 195, 195, 260 },
                    { 196, 196, 364 },
                    { 197, 197, 400 },
                    { 198, 198, 11 },
                    { 199, 199, 87 },
                    { 200, 200, 447 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 201, 201, 242 },
                    { 202, 202, 190 },
                    { 203, 203, 493 },
                    { 204, 204, 238 },
                    { 205, 205, 94 },
                    { 206, 206, 212 },
                    { 207, 207, 431 },
                    { 208, 208, 70 },
                    { 209, 209, 469 },
                    { 210, 210, 109 },
                    { 211, 211, 204 },
                    { 212, 212, 411 },
                    { 213, 213, 165 },
                    { 214, 214, 273 },
                    { 215, 215, 9 },
                    { 216, 216, 268 },
                    { 217, 217, 347 },
                    { 218, 218, 176 },
                    { 219, 219, 197 },
                    { 220, 220, 390 },
                    { 221, 221, 474 },
                    { 222, 222, 291 },
                    { 223, 223, 51 },
                    { 224, 224, 196 },
                    { 225, 225, 91 },
                    { 226, 226, 445 },
                    { 227, 227, 118 },
                    { 228, 228, 168 },
                    { 229, 229, 208 },
                    { 230, 230, 85 },
                    { 231, 231, 36 },
                    { 232, 232, 6 },
                    { 233, 233, 178 },
                    { 234, 234, 282 },
                    { 235, 235, 305 },
                    { 236, 236, 392 },
                    { 237, 237, 361 },
                    { 238, 238, 139 },
                    { 239, 239, 314 },
                    { 240, 240, 455 },
                    { 241, 241, 217 },
                    { 242, 242, 343 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 243, 243, 4 },
                    { 244, 244, 311 },
                    { 245, 245, 193 },
                    { 246, 246, 417 },
                    { 247, 247, 138 },
                    { 248, 248, 482 },
                    { 249, 249, 418 },
                    { 250, 250, 265 },
                    { 251, 251, 156 },
                    { 252, 252, 256 },
                    { 253, 253, 82 },
                    { 254, 254, 363 },
                    { 255, 255, 245 },
                    { 256, 256, 103 },
                    { 257, 257, 161 },
                    { 258, 258, 401 },
                    { 259, 259, 439 },
                    { 260, 260, 58 },
                    { 261, 261, 321 },
                    { 262, 262, 180 },
                    { 263, 263, 122 },
                    { 264, 264, 150 },
                    { 265, 265, 143 },
                    { 266, 266, 395 },
                    { 267, 267, 355 },
                    { 268, 268, 319 },
                    { 269, 269, 298 },
                    { 270, 270, 120 },
                    { 271, 271, 177 },
                    { 272, 272, 491 },
                    { 273, 273, 379 },
                    { 274, 274, 23 },
                    { 275, 275, 132 },
                    { 276, 276, 99 },
                    { 277, 277, 330 },
                    { 278, 278, 173 },
                    { 279, 279, 230 },
                    { 280, 280, 151 },
                    { 281, 281, 8 },
                    { 282, 282, 167 },
                    { 283, 283, 158 },
                    { 284, 284, 349 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 285, 285, 135 },
                    { 286, 286, 269 },
                    { 287, 287, 13 },
                    { 288, 288, 316 },
                    { 289, 289, 424 },
                    { 290, 290, 453 },
                    { 291, 291, 54 },
                    { 292, 292, 369 },
                    { 293, 293, 41 },
                    { 294, 294, 166 },
                    { 295, 295, 144 },
                    { 296, 296, 237 },
                    { 297, 297, 416 },
                    { 298, 298, 352 },
                    { 299, 299, 479 },
                    { 300, 300, 464 },
                    { 301, 301, 141 },
                    { 302, 302, 194 },
                    { 303, 303, 191 },
                    { 304, 304, 134 },
                    { 305, 305, 384 },
                    { 306, 306, 346 },
                    { 307, 307, 278 },
                    { 308, 308, 492 },
                    { 309, 309, 324 },
                    { 310, 310, 490 },
                    { 311, 311, 244 },
                    { 312, 312, 444 },
                    { 313, 313, 155 },
                    { 314, 314, 397 },
                    { 315, 315, 334 },
                    { 316, 316, 302 },
                    { 317, 317, 67 },
                    { 318, 318, 192 },
                    { 319, 319, 342 },
                    { 320, 320, 140 },
                    { 321, 321, 56 },
                    { 322, 322, 114 },
                    { 323, 323, 452 },
                    { 324, 324, 332 },
                    { 325, 325, 315 },
                    { 326, 326, 100 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 327, 327, 323 },
                    { 328, 328, 20 },
                    { 329, 329, 433 },
                    { 330, 330, 74 },
                    { 331, 331, 163 },
                    { 332, 332, 331 },
                    { 333, 333, 46 },
                    { 334, 334, 40 },
                    { 335, 335, 239 },
                    { 336, 336, 443 },
                    { 337, 337, 378 },
                    { 338, 338, 254 },
                    { 339, 339, 257 },
                    { 340, 340, 26 },
                    { 341, 341, 77 },
                    { 342, 342, 174 },
                    { 343, 343, 279 },
                    { 344, 344, 480 },
                    { 345, 345, 495 },
                    { 346, 346, 449 },
                    { 347, 347, 451 },
                    { 348, 348, 413 },
                    { 349, 349, 210 },
                    { 350, 350, 436 },
                    { 351, 351, 274 },
                    { 352, 352, 404 },
                    { 353, 353, 381 },
                    { 354, 354, 280 },
                    { 355, 355, 290 },
                    { 356, 356, 354 },
                    { 357, 357, 89 },
                    { 358, 358, 45 },
                    { 359, 359, 373 },
                    { 360, 360, 52 },
                    { 361, 361, 136 },
                    { 362, 362, 105 },
                    { 363, 363, 241 },
                    { 364, 364, 299 },
                    { 365, 365, 183 },
                    { 366, 366, 96 },
                    { 367, 367, 266 },
                    { 368, 368, 351 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 369, 369, 428 },
                    { 370, 370, 442 },
                    { 371, 371, 312 },
                    { 372, 372, 303 },
                    { 373, 373, 12 },
                    { 374, 374, 152 },
                    { 375, 375, 233 },
                    { 376, 376, 438 },
                    { 377, 377, 465 },
                    { 378, 378, 329 },
                    { 379, 379, 425 },
                    { 380, 380, 372 },
                    { 381, 381, 229 },
                    { 382, 382, 157 },
                    { 383, 383, 71 },
                    { 384, 384, 339 },
                    { 385, 385, 131 },
                    { 386, 386, 39 },
                    { 387, 387, 145 },
                    { 388, 388, 353 },
                    { 389, 389, 211 },
                    { 390, 390, 148 },
                    { 391, 391, 272 },
                    { 392, 392, 188 },
                    { 393, 393, 84 },
                    { 394, 394, 164 },
                    { 395, 395, 253 },
                    { 396, 396, 219 },
                    { 397, 397, 154 },
                    { 398, 398, 337 },
                    { 399, 399, 403 },
                    { 400, 400, 259 }
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
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 40);

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
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 59);

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
                keyValue: 86);

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
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 107);

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
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 167);

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
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 207);

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
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 274);

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
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 300);

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
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 335);

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
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 350);

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
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 396);

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
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 412);

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
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 474);

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
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 495);

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
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 15);

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
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 43);

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
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 64);

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
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 207);

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
                keyValue: 218);

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
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 247);

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
                keyValue: 252);

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
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 285);

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
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 297);

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
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 333);

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
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 358);

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
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 380);

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
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 414);

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
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 454);

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
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 489);

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
                table: "PersonClass",
                keyColumn: "UserClassID",
                keyValue: 1000);

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
                table: "PersonRole",
                keyColumn: "PersonRoleID",
                keyValue: 1000);

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
                keyValue: 34);

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
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 54);

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
                keyValue: 58);

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
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 74);

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
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 88);

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
                keyValue: 96);

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
                keyValue: 112);

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
                keyValue: 129);

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
                keyValue: 132);

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
                keyValue: 150);

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
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 160);

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
                keyValue: 166);

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
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 177);

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
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 206);

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
                keyValue: 219);

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
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 232);

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
                keyValue: 237);

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
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 261);

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
                keyValue: 273);

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
                keyValue: 280);

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
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 289);

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
                keyValue: 295);

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
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 301);

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
                keyValue: 312);

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
                keyValue: 319);

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
                keyValue: 323);

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
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 337);

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
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 345);

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
                keyValue: 365);

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
                keyValue: 378);

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
                keyValue: 387);

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
                keyValue: 419);

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
                keyValue: 431);

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
                keyValue: 444);

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
                keyValue: 448);

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
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 453);

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
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 459);

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
                keyValue: 466);

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
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 477);

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
                keyValue: 16);

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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 34);

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
                keyValue: 55);

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
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 63);

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
                keyValue: 71);

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
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 103);

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
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 109);

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
                keyValue: 112);

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
                keyValue: 154);

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
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 158);

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
                keyValue: 162);

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
                keyValue: 174);

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
                keyValue: 190);

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
                keyValue: 194);

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
                keyValue: 200);

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
                keyValue: 206);

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
                keyValue: 210);

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
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 219);

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
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 235);

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
                keyValue: 243);

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
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 251);

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
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 266);

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
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 287);

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
                keyValue: 298);

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
                keyValue: 301);

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
                keyValue: 321);

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
                keyValue: 334);

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
                keyValue: 349);

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
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 361);

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
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 388);

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
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 399);

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
                keyValue: 422);

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
                keyValue: 429);

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
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 449);

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
                keyValue: 455);

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
                keyValue: 466);

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
                keyValue: 476);

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
                keyValue: 482);

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
                keyValue: 488);

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
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6f0bfaad-7851-4d81-8ce0-f260c6a7ca00"));

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
                keyValue: new Guid("016f226e-5c2b-427e-abf2-8ce2f59a1220"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("01c81aa1-f9bf-41dd-afd2-9d30ad2912a1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("08134bb8-0a9b-48fd-afe1-ff2bf2ec6623"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0c45d8ba-112f-4e74-a908-efd7b7817e2a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0d2f2f52-934a-448a-8b1f-6d5cb3332ad8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0df2c5fe-892c-41ac-8da6-db9127dc9463"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1119104b-8392-4126-a7de-72976b5ea61a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1279a75e-f6a8-4732-8e85-81e27e36c630"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1ad760eb-28a5-4691-9dd2-b7b8f1496743"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("20c6cf46-0f12-4c02-a0b1-19ab79a73940"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("231c0cb6-ebd4-42c1-99c7-882a02d46c14"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("27852f8b-8415-41f4-840c-977acf762e7e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("27dc7c66-1c01-4ae8-8df8-3e82110722dd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("29061f01-1b06-4273-bef0-e66e8de10101"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2e108e38-f00d-48c1-b6a1-9d97626a3bbf"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("31b91a84-ac7b-4bea-81f5-be224ce7fc41"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("377c1675-27c8-4144-af06-084d597f0051"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3a331c1e-17db-4723-8814-868592f7f36d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3a7f90c4-271e-4077-9025-a9188843a68d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("411dc37c-8d81-429e-8b60-a6342b907dbc"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("411e70e5-a541-4930-b3d9-d32a658ad65c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("443cdbb9-e98e-4fa6-8f5f-3c5caaac9553"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("47ac98c5-374f-4c41-b11c-1830e9eada61"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("48772526-803a-4867-97db-4129d475d6ca"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4886ecbf-6ce8-4df2-b596-39270c85bd1d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("490b034a-391d-4d72-9b8f-c6d4bfafbf57"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4b34374a-6e64-494d-ae39-6cc089e822f1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4d81e693-423d-450b-aa27-3068e61df1cd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("50384560-2944-4083-9419-a625949344c1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5c66a34e-7f25-4d5e-ae73-a56c805c6952"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5cefa1f9-6f33-4259-9382-7d9995b954c8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5e4488d4-19ba-4503-b9e9-3d2f2ccf7d01"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5ede16d5-8d5e-4d0c-866d-51a82662bf0a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("62873915-588a-422b-8a3d-520df41b621c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("666e00a0-b360-49c1-aad7-e6209307dbaa"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("682e3d6b-4c59-4ab6-9a6f-c014d54fa980"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("69ae5374-e97b-4088-b8f3-877481f3e2a8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("69b2db0e-33dc-4136-8670-af8ead292e48"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6ab1e480-6be5-4bc5-aaf8-fbfc8c9999d7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("73fd45c1-e9bd-4664-a27f-dd9658537b50"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("751ae001-86c7-4801-a698-33f723ddfdb2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("75aecec7-9a0b-4599-adbc-e07b1a979dac"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("77cd5e7a-8077-41c9-89cd-9ada826a67fe"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("790eeaa6-1a05-48c4-acd3-2a18a1c40330"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7c8e0883-32fb-4946-a919-e2eb86d10450"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7d59d348-44da-4481-824f-106e5f9e68e5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7ff6de89-239c-402b-a3ac-79a2953387f3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("825d48af-5c98-4eaa-9b5a-a75b9da1ae12"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("82bc0e13-aa10-4152-b246-548b498ea200"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("84dfbff9-ef98-4346-940e-0ffc59dd6529"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8570dfaa-e71c-4ad5-92b9-d3b94101ee35"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("88427179-fbaa-4691-8fdd-3ba9bd0a53ff"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8c06b904-8d44-42a0-8219-ddb54a372b69"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8cf97056-bd88-4e31-88df-843a7e9e8efe"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("909f6eb7-1b3b-4dc9-a577-97cbfdd6c234"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("923ed226-5720-4e6b-81d4-a776f511533d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("93182e12-00ce-4904-b6ae-152d7ef51884"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("96e5864e-4669-41d2-bef5-e2c4e5d6b0a4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("97ac1a46-4325-4864-8333-d6b5c707195d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("97f79560-f3f9-4dd0-b0e2-e86049dba9cc"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9c7903d8-c65f-4dcb-bb0f-c0e5e736e7e4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9c860d05-27ce-49f3-a9f5-13eecc1dd580"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a19b2f41-fabf-4a05-8341-62a955227fdc"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a316ebdb-9104-489f-9392-0afc00e8a2ad"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a48cafc5-4669-429d-825f-cf007df82222"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a71b4056-bcb7-4488-af2d-2ba7d1ac5a98"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a8bbd6ab-e400-4265-bed1-1f4ba2122a8c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a8d03801-c1b4-4709-bd2e-8e1d952d31c7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b1c43915-a235-4ffd-aab0-0a13b7ec383f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b1e4e2fe-b2e1-4981-a0d6-97e33c00f63f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b3b4c220-2450-413a-a331-928f69ec49e7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b7149f16-e029-4115-9d35-a4056970636d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b78949af-6166-4a64-b1e6-8281240643d7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b98e0cff-910c-423f-8d55-e7bde63bee49"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ba5b9185-98e0-487d-b448-6ba40bc4690a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bcfcb422-cd25-471d-a0cd-332c89c5284d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bde109d2-a2cc-43c2-a341-6b5cbb76ff62"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("be14e59e-66fa-4b0d-b0fe-acb923cb9d64"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bfcd1e94-0f67-4cee-af55-a4c85cf591bb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c0ff85cc-bbe7-4b4c-967a-9de16dcced1a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c58786ce-5bfa-4d26-88c0-acbad52fd739"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c68bf6da-6211-4a86-a5cb-3bf6aa9e9138"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c8920b4b-c7f0-4451-b17c-fc8a41788ebd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ca04aaec-8374-4066-b3a0-ddc2c843b568"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("cc67b18f-ade1-4969-8367-5466e1e24f51"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d81250e2-dab7-4bc0-8665-8a66dd7fdd66"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d86b2e64-cdf9-4b98-9ccb-cfdda3180116"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d9a03777-8e57-4d8c-9aa8-06e34bc3247e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("dee9fe0d-1c48-4e6c-9c9e-167fd060b1d7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e9550553-7082-46d5-9016-f04b082ce998"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f1f57c0a-17fe-4f38-9baf-2495544bdcea"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f30debe3-7d0c-434d-85c1-dab30c5fe0d3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f3419292-1f72-4ba6-be06-231febc9e225"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f5a83bce-53db-4315-a329-fa9352341fdf"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fa254757-ff2e-4ab1-b791-4ffc5fa9fe86"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fae4e56b-0d1f-4fea-844d-f0ac307d330f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fb20dc15-b0d8-4548-83cf-c3534f012706"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fbbfac4a-b450-49f0-ad7e-0ed707d0d94e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fcff5c6f-7853-4570-8d2b-5d720c022af4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fdf192c0-be69-48c5-bb96-f56a96964a1f"));

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

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "Name",
                value: "Parent");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "Name",
                value: "Teacher");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 4,
                column: "Name",
                value: "Tutor");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 5,
                column: "Name",
                value: "LocalAdmin");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "Name" },
                values: new object[] { 6, "Admin" });

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
