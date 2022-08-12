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
                    { 1, 1, 1, "Polish" },
                    { 2, 1, 2, "Physics" },
                    { 3, 1, 3, "Geography" },
                    { 4, 1, 4, "Chemistry" },
                    { 5, 1, 5, "Geography" },
                    { 6, 1, 6, "Physics" },
                    { 7, 1, 7, "PE" },
                    { 8, 1, 8, "PE" },
                    { 9, 2, 1, "History" },
                    { 10, 2, 2, "Polish" },
                    { 11, 2, 3, "Physics" },
                    { 12, 2, 4, "English" },
                    { 13, 2, 5, "PE" },
                    { 14, 2, 6, "Chemistry" },
                    { 15, 2, 7, "History" },
                    { 16, 2, 8, "Physics" },
                    { 17, 3, 1, "History" },
                    { 18, 3, 2, "Geography" },
                    { 19, 3, 3, "History" },
                    { 20, 3, 4, "English" },
                    { 21, 3, 5, "Polish" },
                    { 22, 3, 6, "English" },
                    { 23, 3, 7, "Math" },
                    { 24, 3, 8, "Math" },
                    { 25, 4, 1, "Chemistry" },
                    { 26, 4, 2, "PE" },
                    { 27, 4, 3, "Physics" },
                    { 28, 4, 4, "History" },
                    { 29, 4, 5, "Geography" },
                    { 30, 4, 6, "English" },
                    { 31, 4, 7, "Chemistry" },
                    { 32, 4, 8, "English" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 33, 5, 1, "History" },
                    { 34, 5, 2, "English" },
                    { 35, 5, 3, "Physics" },
                    { 36, 5, 4, "Math" },
                    { 37, 5, 5, "Polish" },
                    { 38, 5, 6, "Physics" },
                    { 39, 5, 7, "Physics" },
                    { 40, 5, 8, "Geography" },
                    { 41, 1, 1, "Chemistry" },
                    { 42, 1, 2, "Polish" },
                    { 43, 1, 3, "Polish" },
                    { 44, 1, 4, "Math" },
                    { 45, 1, 5, "Math" },
                    { 46, 1, 6, "English" },
                    { 47, 1, 7, "Physics" },
                    { 48, 1, 8, "Polish" },
                    { 49, 2, 1, "Geography" },
                    { 50, 2, 2, "Polish" },
                    { 51, 2, 3, "Physics" },
                    { 52, 2, 4, "English" },
                    { 53, 2, 5, "Math" },
                    { 54, 2, 6, "Physics" },
                    { 55, 2, 7, "History" },
                    { 56, 2, 8, "English" },
                    { 57, 3, 1, "Math" },
                    { 58, 3, 2, "History" },
                    { 59, 3, 3, "History" },
                    { 60, 3, 4, "Physics" },
                    { 61, 3, 5, "Polish" },
                    { 62, 3, 6, "Chemistry" },
                    { 63, 3, 7, "Chemistry" },
                    { 64, 3, 8, "Geography" },
                    { 65, 4, 1, "History" },
                    { 66, 4, 2, "Polish" },
                    { 67, 4, 3, "Chemistry" },
                    { 68, 4, 4, "Geography" },
                    { 69, 4, 5, "Polish" },
                    { 70, 4, 6, "PE" },
                    { 71, 4, 7, "PE" },
                    { 72, 4, 8, "Geography" },
                    { 73, 5, 1, "History" },
                    { 74, 5, 2, "PE" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 75, 5, 3, "PE" },
                    { 76, 5, 4, "Math" },
                    { 77, 5, 5, "Math" },
                    { 78, 5, 6, "Physics" },
                    { 79, 5, 7, "Math" },
                    { 80, 5, 8, "Chemistry" },
                    { 81, 1, 1, "History" },
                    { 82, 1, 2, "English" },
                    { 83, 1, 3, "English" },
                    { 84, 1, 4, "Geography" },
                    { 85, 1, 5, "Physics" },
                    { 86, 1, 6, "Geography" },
                    { 87, 1, 7, "History" },
                    { 88, 1, 8, "Geography" },
                    { 89, 2, 1, "Physics" },
                    { 90, 2, 2, "Chemistry" },
                    { 91, 2, 3, "Math" },
                    { 92, 2, 4, "Physics" },
                    { 93, 2, 5, "Math" },
                    { 94, 2, 6, "PE" },
                    { 95, 2, 7, "History" },
                    { 96, 2, 8, "English" },
                    { 97, 3, 1, "Geography" },
                    { 98, 3, 2, "Physics" },
                    { 99, 3, 3, "Polish" },
                    { 100, 3, 4, "History" },
                    { 101, 3, 5, "Physics" },
                    { 102, 3, 6, "Chemistry" },
                    { 103, 3, 7, "Chemistry" },
                    { 104, 3, 8, "English" },
                    { 105, 4, 1, "Physics" },
                    { 106, 4, 2, "Math" },
                    { 107, 4, 3, "Physics" },
                    { 108, 4, 4, "Polish" },
                    { 109, 4, 5, "PE" },
                    { 110, 4, 6, "PE" },
                    { 111, 4, 7, "Math" },
                    { 112, 4, 8, "Physics" },
                    { 113, 5, 1, "History" },
                    { 114, 5, 2, "Physics" },
                    { 115, 5, 3, "Math" },
                    { 116, 5, 4, "Chemistry" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 117, 5, 5, "History" },
                    { 118, 5, 6, "PE" },
                    { 119, 5, 7, "PE" },
                    { 120, 5, 8, "Physics" },
                    { 121, 1, 1, "History" },
                    { 122, 1, 2, "Geography" },
                    { 123, 1, 3, "Polish" },
                    { 124, 1, 4, "English" },
                    { 125, 1, 5, "PE" },
                    { 126, 1, 6, "Math" },
                    { 127, 1, 7, "Polish" },
                    { 128, 1, 8, "Physics" },
                    { 129, 2, 1, "Physics" },
                    { 130, 2, 2, "Math" },
                    { 131, 2, 3, "English" },
                    { 132, 2, 4, "PE" },
                    { 133, 2, 5, "Geography" },
                    { 134, 2, 6, "History" },
                    { 135, 2, 7, "PE" },
                    { 136, 2, 8, "History" },
                    { 137, 3, 1, "History" },
                    { 138, 3, 2, "PE" },
                    { 139, 3, 3, "Polish" },
                    { 140, 3, 4, "Polish" },
                    { 141, 3, 5, "Geography" },
                    { 142, 3, 6, "PE" },
                    { 143, 3, 7, "Geography" },
                    { 144, 3, 8, "History" },
                    { 145, 4, 1, "Geography" },
                    { 146, 4, 2, "History" },
                    { 147, 4, 3, "Polish" },
                    { 148, 4, 4, "Physics" },
                    { 149, 4, 5, "Physics" },
                    { 150, 4, 6, "PE" },
                    { 151, 4, 7, "Math" },
                    { 152, 4, 8, "PE" },
                    { 153, 5, 1, "Physics" },
                    { 154, 5, 2, "Physics" },
                    { 155, 5, 3, "History" },
                    { 156, 5, 4, "History" },
                    { 157, 5, 5, "Polish" },
                    { 158, 5, 6, "English" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 159, 5, 7, "PE" },
                    { 160, 5, 8, "Math" },
                    { 161, 1, 1, "Math" },
                    { 162, 1, 2, "PE" },
                    { 163, 1, 3, "English" },
                    { 164, 1, 4, "English" },
                    { 165, 1, 5, "Polish" },
                    { 166, 1, 6, "Polish" },
                    { 167, 1, 7, "PE" },
                    { 168, 1, 8, "Math" },
                    { 169, 2, 1, "Math" },
                    { 170, 2, 2, "History" },
                    { 171, 2, 3, "English" },
                    { 172, 2, 4, "Physics" },
                    { 173, 2, 5, "Physics" },
                    { 174, 2, 6, "English" },
                    { 175, 2, 7, "History" },
                    { 176, 2, 8, "History" },
                    { 177, 3, 1, "History" },
                    { 178, 3, 2, "Math" },
                    { 179, 3, 3, "Chemistry" },
                    { 180, 3, 4, "Chemistry" },
                    { 181, 3, 5, "Physics" },
                    { 182, 3, 6, "Polish" },
                    { 183, 3, 7, "PE" },
                    { 184, 3, 8, "History" },
                    { 185, 4, 1, "Physics" },
                    { 186, 4, 2, "PE" },
                    { 187, 4, 3, "Math" },
                    { 188, 4, 4, "Chemistry" },
                    { 189, 4, 5, "History" },
                    { 190, 4, 6, "English" },
                    { 191, 4, 7, "English" },
                    { 192, 4, 8, "Physics" },
                    { 193, 5, 1, "History" },
                    { 194, 5, 2, "PE" },
                    { 195, 5, 3, "Polish" },
                    { 196, 5, 4, "English" },
                    { 197, 5, 5, "History" },
                    { 198, 5, 6, "History" },
                    { 199, 5, 7, "Geography" },
                    { 200, 5, 8, "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 201, 1, 1, "English" },
                    { 202, 1, 2, "Physics" },
                    { 203, 1, 3, "English" },
                    { 204, 1, 4, "English" },
                    { 205, 1, 5, "History" },
                    { 206, 1, 6, "Geography" },
                    { 207, 1, 7, "Physics" },
                    { 208, 1, 8, "Polish" },
                    { 209, 2, 1, "English" },
                    { 210, 2, 2, "Physics" },
                    { 211, 2, 3, "History" },
                    { 212, 2, 4, "PE" },
                    { 213, 2, 5, "Chemistry" },
                    { 214, 2, 6, "English" },
                    { 215, 2, 7, "Physics" },
                    { 216, 2, 8, "Physics" },
                    { 217, 3, 1, "Physics" },
                    { 218, 3, 2, "English" },
                    { 219, 3, 3, "History" },
                    { 220, 3, 4, "English" },
                    { 221, 3, 5, "Math" },
                    { 222, 3, 6, "Math" },
                    { 223, 3, 7, "English" },
                    { 224, 3, 8, "Math" },
                    { 225, 4, 1, "History" },
                    { 226, 4, 2, "Chemistry" },
                    { 227, 4, 3, "English" },
                    { 228, 4, 4, "Physics" },
                    { 229, 4, 5, "Polish" },
                    { 230, 4, 6, "Chemistry" },
                    { 231, 4, 7, "History" },
                    { 232, 4, 8, "Geography" },
                    { 233, 5, 1, "PE" },
                    { 234, 5, 2, "Geography" },
                    { 235, 5, 3, "Polish" },
                    { 236, 5, 4, "Math" },
                    { 237, 5, 5, "Math" },
                    { 238, 5, 6, "Polish" },
                    { 239, 5, 7, "Geography" },
                    { 240, 5, 8, "Math" },
                    { 241, 1, 1, "Polish" },
                    { 242, 1, 2, "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 243, 1, 3, "Geography" },
                    { 244, 1, 4, "PE" },
                    { 245, 1, 5, "History" },
                    { 246, 1, 6, "History" },
                    { 247, 1, 7, "History" },
                    { 248, 1, 8, "PE" },
                    { 249, 2, 1, "History" },
                    { 250, 2, 2, "Geography" },
                    { 251, 2, 3, "PE" },
                    { 252, 2, 4, "Geography" },
                    { 253, 2, 5, "Math" },
                    { 254, 2, 6, "PE" },
                    { 255, 2, 7, "PE" },
                    { 256, 2, 8, "Physics" },
                    { 257, 3, 1, "PE" },
                    { 258, 3, 2, "English" },
                    { 259, 3, 3, "English" },
                    { 260, 3, 4, "Geography" },
                    { 261, 3, 5, "Math" },
                    { 262, 3, 6, "Geography" },
                    { 263, 3, 7, "Polish" },
                    { 264, 3, 8, "Chemistry" },
                    { 265, 4, 1, "Chemistry" },
                    { 266, 4, 2, "Geography" },
                    { 267, 4, 3, "Chemistry" },
                    { 268, 4, 4, "Math" },
                    { 269, 4, 5, "Polish" },
                    { 270, 4, 6, "Chemistry" },
                    { 271, 4, 7, "Chemistry" },
                    { 272, 4, 8, "Physics" },
                    { 273, 5, 1, "English" },
                    { 274, 5, 2, "English" },
                    { 275, 5, 3, "History" },
                    { 276, 5, 4, "English" },
                    { 277, 5, 5, "Polish" },
                    { 278, 5, 6, "English" },
                    { 279, 5, 7, "Math" },
                    { 280, 5, 8, "Geography" },
                    { 281, 1, 1, "History" },
                    { 282, 1, 2, "Geography" },
                    { 283, 1, 3, "Chemistry" },
                    { 284, 1, 4, "PE" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 285, 1, 5, "History" },
                    { 286, 1, 6, "Math" },
                    { 287, 1, 7, "PE" },
                    { 288, 1, 8, "History" },
                    { 289, 2, 1, "Chemistry" },
                    { 290, 2, 2, "Polish" },
                    { 291, 2, 3, "Math" },
                    { 292, 2, 4, "English" },
                    { 293, 2, 5, "Geography" },
                    { 294, 2, 6, "History" },
                    { 295, 2, 7, "Polish" },
                    { 296, 2, 8, "Physics" },
                    { 297, 3, 1, "Polish" },
                    { 298, 3, 2, "Math" },
                    { 299, 3, 3, "English" },
                    { 300, 3, 4, "Chemistry" },
                    { 301, 3, 5, "English" },
                    { 302, 3, 6, "History" },
                    { 303, 3, 7, "Physics" },
                    { 304, 3, 8, "PE" },
                    { 305, 4, 1, "Physics" },
                    { 306, 4, 2, "Geography" },
                    { 307, 4, 3, "Chemistry" },
                    { 308, 4, 4, "Geography" },
                    { 309, 4, 5, "Geography" },
                    { 310, 4, 6, "Math" },
                    { 311, 4, 7, "Math" },
                    { 312, 4, 8, "Geography" },
                    { 313, 5, 1, "Math" },
                    { 314, 5, 2, "History" },
                    { 315, 5, 3, "History" },
                    { 316, 5, 4, "English" },
                    { 317, 5, 5, "History" },
                    { 318, 5, 6, "Physics" },
                    { 319, 5, 7, "Chemistry" },
                    { 320, 5, 8, "History" },
                    { 321, 1, 1, "Chemistry" },
                    { 322, 1, 2, "Polish" },
                    { 323, 1, 3, "Math" },
                    { 324, 1, 4, "English" },
                    { 325, 1, 5, "English" },
                    { 326, 1, 6, "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 327, 1, 7, "Physics" },
                    { 328, 1, 8, "Geography" },
                    { 329, 2, 1, "English" },
                    { 330, 2, 2, "PE" },
                    { 331, 2, 3, "Geography" },
                    { 332, 2, 4, "English" },
                    { 333, 2, 5, "Geography" },
                    { 334, 2, 6, "Geography" },
                    { 335, 2, 7, "History" },
                    { 336, 2, 8, "Polish" },
                    { 337, 3, 1, "PE" },
                    { 338, 3, 2, "Geography" },
                    { 339, 3, 3, "Math" },
                    { 340, 3, 4, "Polish" },
                    { 341, 3, 5, "Math" },
                    { 342, 3, 6, "Physics" },
                    { 343, 3, 7, "Polish" },
                    { 344, 3, 8, "PE" },
                    { 345, 4, 1, "History" },
                    { 346, 4, 2, "Chemistry" },
                    { 347, 4, 3, "Math" },
                    { 348, 4, 4, "Polish" },
                    { 349, 4, 5, "Chemistry" },
                    { 350, 4, 6, "English" },
                    { 351, 4, 7, "Geography" },
                    { 352, 4, 8, "Chemistry" },
                    { 353, 5, 1, "Chemistry" },
                    { 354, 5, 2, "Chemistry" },
                    { 355, 5, 3, "Geography" },
                    { 356, 5, 4, "Polish" },
                    { 357, 5, 5, "Geography" },
                    { 358, 5, 6, "PE" },
                    { 359, 5, 7, "English" },
                    { 360, 5, 8, "Polish" },
                    { 361, 1, 1, "Geography" },
                    { 362, 1, 2, "Chemistry" },
                    { 363, 1, 3, "PE" },
                    { 364, 1, 4, "PE" },
                    { 365, 1, 5, "Physics" },
                    { 366, 1, 6, "Polish" },
                    { 367, 1, 7, "PE" },
                    { 368, 1, 8, "Math" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 369, 2, 1, "Chemistry" },
                    { 370, 2, 2, "Math" },
                    { 371, 2, 3, "Polish" },
                    { 372, 2, 4, "Polish" },
                    { 373, 2, 5, "History" },
                    { 374, 2, 6, "History" },
                    { 375, 2, 7, "Math" },
                    { 376, 2, 8, "History" },
                    { 377, 3, 1, "Math" },
                    { 378, 3, 2, "Geography" },
                    { 379, 3, 3, "Geography" },
                    { 380, 3, 4, "PE" },
                    { 381, 3, 5, "PE" },
                    { 382, 3, 6, "Polish" },
                    { 383, 3, 7, "PE" },
                    { 384, 3, 8, "Polish" },
                    { 385, 4, 1, "English" },
                    { 386, 4, 2, "History" },
                    { 387, 4, 3, "History" },
                    { 388, 4, 4, "Geography" },
                    { 389, 4, 5, "Polish" },
                    { 390, 4, 6, "Geography" },
                    { 391, 4, 7, "History" },
                    { 392, 4, 8, "PE" },
                    { 393, 5, 1, "Physics" },
                    { 394, 5, 2, "English" },
                    { 395, 5, 3, "Math" },
                    { 396, 5, 4, "History" },
                    { 397, 5, 5, "Polish" },
                    { 398, 5, 6, "Chemistry" },
                    { 399, 5, 7, "History" },
                    { 400, 5, 8, "Math" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Mildred_Tromp@gmail.com", "Mildred", "Tromp", "1-967-997-9217" },
                    { 2, "Robert.Gleason6@gmail.com", "Robert", "Gleason", "969.576.5164 x704" },
                    { 3, "Juan_Jacobi46@gmail.com", "Juan", "Jacobi", "(401) 728-8389 x8446" },
                    { 4, "Fred.Balistreri74@hotmail.com", "Fred", "Balistreri", "848-240-6962 x62387" },
                    { 5, "Howard_Fadel@hotmail.com", "Howard", "Fadel", "943.323.2372 x910" },
                    { 6, "Leroy_Stehr54@hotmail.com", "Leroy", "Stehr", "978.550.5987" },
                    { 7, "Erma14@yahoo.com", "Erma", "Koelpin", "845.645.6286" },
                    { 8, "Sergio_Baumbach61@yahoo.com", "Sergio", "Baumbach", "1-997-766-5838 x8339" },
                    { 9, "Grace17@yahoo.com", "Grace", "Will", "1-620-260-4022 x38753" },
                    { 10, "Julio27@yahoo.com", "Julio", "Hammes", "(401) 464-6586 x34910" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 11, "Sabrina_Maggio67@yahoo.com", "Sabrina", "Maggio", "647-606-9107" },
                    { 12, "Abel87@yahoo.com", "Abel", "Aufderhar", "938-378-5141 x0231" },
                    { 13, "Jorge_Marks@yahoo.com", "Jorge", "Marks", "1-630-783-6927 x81779" },
                    { 14, "Wilma_Littel58@yahoo.com", "Wilma", "Littel", "921-275-6409" },
                    { 15, "Mary.Spencer@gmail.com", "Mary", "Spencer", "980.527.6346 x2620" },
                    { 16, "Larry.Quitzon@hotmail.com", "Larry", "Quitzon", "728-955-5501 x8010" },
                    { 17, "Darrel_Casper@hotmail.com", "Darrel", "Casper", "(949) 689-5006" },
                    { 18, "Desiree0@hotmail.com", "Desiree", "Jerde", "(703) 312-4879" },
                    { 19, "Mabel_Welch@gmail.com", "Mabel", "Welch", "832.643.4414" },
                    { 20, "Winston_Huel@yahoo.com", "Winston", "Huel", "1-602-443-8561 x017" },
                    { 21, "Madeline_Thompson@hotmail.com", "Madeline", "Thompson", "803.501.1736" },
                    { 22, "Cindy.Hauck@yahoo.com", "Cindy", "Hauck", "1-960-752-0933 x7060" },
                    { 23, "Joan.Grimes79@hotmail.com", "Joan", "Grimes", "423-543-5177" },
                    { 24, "June53@yahoo.com", "June", "Schaefer", "1-443-478-3247 x947" },
                    { 25, "Betty_Frami62@yahoo.com", "Betty", "Frami", "1-571-316-8814 x4192" },
                    { 26, "Dianne.Considine@gmail.com", "Dianne", "Considine", "1-831-553-1448 x915" },
                    { 27, "Rhonda7@yahoo.com", "Rhonda", "Skiles", "(387) 554-5718 x273" },
                    { 28, "Cedric61@gmail.com", "Cedric", "Armstrong", "281-512-4268" },
                    { 29, "Emilio.Shanahan@gmail.com", "Emilio", "Shanahan", "(495) 278-5583 x4166" },
                    { 30, "Bryant_Larkin@gmail.com", "Bryant", "Larkin", "378.452.8707 x380" },
                    { 31, "Lucia98@gmail.com", "Lucia", "Bins", "431.853.3822 x56101" },
                    { 32, "Fredrick_Rowe89@hotmail.com", "Fredrick", "Rowe", "1-432-912-3534 x2154" },
                    { 33, "Tyrone.Blick80@yahoo.com", "Tyrone", "Blick", "(216) 347-8501" },
                    { 34, "Glenda.Bergnaum@gmail.com", "Glenda", "Bergnaum", "623-634-0146 x344" },
                    { 35, "Willard.Dickinson@gmail.com", "Willard", "Dickinson", "852.912.9240 x09313" },
                    { 36, "Patty55@gmail.com", "Patty", "Oberbrunner", "350.926.7628" },
                    { 37, "Sophie.Krajcik66@hotmail.com", "Sophie", "Krajcik", "445-700-1419" },
                    { 38, "Jon_Olson@hotmail.com", "Jon", "Olson", "1-841-654-2392" },
                    { 39, "Faye_Cole49@gmail.com", "Faye", "Cole", "1-852-713-0805 x951" },
                    { 40, "Chris7@gmail.com", "Chris", "Koch", "1-417-249-7023 x5779" },
                    { 41, "Nichole_Wisoky57@hotmail.com", "Nichole", "Wisoky", "1-326-547-8524 x02018" },
                    { 42, "William42@yahoo.com", "William", "Zemlak", "(992) 868-8754 x688" },
                    { 43, "Wm.Farrell@hotmail.com", "Wm", "Farrell", "825-823-0197" },
                    { 44, "June_Jakubowski23@hotmail.com", "June", "Jakubowski", "562.625.1762" },
                    { 45, "Patrick_Harber85@gmail.com", "Patrick", "Harber", "(816) 659-5352 x5379" },
                    { 46, "Audrey_Bednar@yahoo.com", "Audrey", "Bednar", "274.549.7788" },
                    { 47, "Dallas_Schiller@hotmail.com", "Dallas", "Schiller", "(853) 928-9631 x41328" },
                    { 48, "Corey_Wolff@gmail.com", "Corey", "Wolff", "(831) 903-7700" },
                    { 49, "Gregory.Kutch17@gmail.com", "Gregory", "Kutch", "1-273-329-6497 x567" },
                    { 50, "Ellen_Schumm82@hotmail.com", "Ellen", "Schumm", "1-900-618-6726 x34993" },
                    { 51, "Tom_Wunsch@hotmail.com", "Tom", "Wunsch", "665.938.1027 x331" },
                    { 52, "Russell_Reichert10@gmail.com", "Russell", "Reichert", "1-599-827-2180" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 53, "Jane_White20@yahoo.com", "Jane", "White", "(786) 846-8719 x3967" },
                    { 54, "Brian66@yahoo.com", "Brian", "Jacobi", "(761) 531-0047 x262" },
                    { 55, "Rose_Hansen@hotmail.com", "Rose", "Hansen", "964-928-8373" },
                    { 56, "Ruben.Bode93@hotmail.com", "Ruben", "Bode", "(734) 760-2641 x456" },
                    { 57, "Clint.Olson@gmail.com", "Clint", "Olson", "(903) 839-0445 x30228" },
                    { 58, "Danielle71@hotmail.com", "Danielle", "Satterfield", "875.402.1670 x3676" },
                    { 59, "Pauline_Kozey@hotmail.com", "Pauline", "Kozey", "(933) 225-4619 x4545" },
                    { 60, "Janis_Tremblay68@yahoo.com", "Janis", "Tremblay", "(935) 963-6543 x768" },
                    { 61, "Melvin_Leuschke@hotmail.com", "Melvin", "Leuschke", "(202) 583-3496 x9788" },
                    { 62, "Sergio.Keebler@yahoo.com", "Sergio", "Keebler", "705-802-1485 x1625" },
                    { 63, "Bessie_Wisoky@hotmail.com", "Bessie", "Wisoky", "875-879-6572" },
                    { 64, "Vincent.Ankunding@gmail.com", "Vincent", "Ankunding", "387.741.8832 x39190" },
                    { 65, "Elisa16@hotmail.com", "Elisa", "Miller", "1-743-782-8380" },
                    { 66, "Rodney_Kunde49@yahoo.com", "Rodney", "Kunde", "(545) 584-5254 x857" },
                    { 67, "Chelsea_Okuneva@gmail.com", "Chelsea", "Okuneva", "427.285.8063" },
                    { 68, "Ronald_Witting@gmail.com", "Ronald", "Witting", "371.812.5357 x16732" },
                    { 69, "Mamie93@yahoo.com", "Mamie", "Gleason", "1-947-625-1271" },
                    { 70, "Zachary17@gmail.com", "Zachary", "Lowe", "345-243-0516 x3048" },
                    { 71, "Sherri87@hotmail.com", "Sherri", "Ward", "1-874-387-7370 x1099" },
                    { 72, "Karla43@yahoo.com", "Karla", "Schultz", "267-720-3216 x30097" },
                    { 73, "Winston_OConner@hotmail.com", "Winston", "O'Conner", "333-570-6519 x8996" },
                    { 74, "Sandra.Crona@hotmail.com", "Sandra", "Crona", "574-995-3533" },
                    { 75, "Joel58@hotmail.com", "Joel", "Nolan", "1-792-746-1930 x67574" },
                    { 76, "Muriel_OKon@yahoo.com", "Muriel", "O'Kon", "432.670.5141 x75932" },
                    { 77, "Naomi38@hotmail.com", "Naomi", "Conroy", "(893) 519-7118 x255" },
                    { 78, "Hattie_Nicolas@yahoo.com", "Hattie", "Nicolas", "(462) 480-9724" },
                    { 79, "Antonio16@hotmail.com", "Antonio", "Ryan", "1-628-843-4200" },
                    { 80, "Lionel_Goyette82@gmail.com", "Lionel", "Goyette", "324.268.5222" },
                    { 81, "Edna.McGlynn91@hotmail.com", "Edna", "McGlynn", "703-568-0185" },
                    { 82, "Jill_Lesch@yahoo.com", "Jill", "Lesch", "480.333.3644" },
                    { 83, "Vicki.Goyette@gmail.com", "Vicki", "Goyette", "(326) 297-5733 x789" },
                    { 84, "Guy.Boyer42@hotmail.com", "Guy", "Boyer", "(398) 363-2724 x0028" },
                    { 85, "Angie67@yahoo.com", "Angie", "Murray", "(936) 984-1511 x59470" },
                    { 86, "Scott17@gmail.com", "Scott", "Cummerata", "840-991-4919 x5547" },
                    { 87, "Kent_Mertz69@yahoo.com", "Kent", "Mertz", "(724) 797-1586" },
                    { 88, "Nichole22@hotmail.com", "Nichole", "Schowalter", "1-967-219-4776 x7962" },
                    { 89, "Stacey60@gmail.com", "Stacey", "Stark", "1-658-658-4636 x6733" },
                    { 90, "Natalie_Lehner@hotmail.com", "Natalie", "Lehner", "1-636-705-0147 x36471" },
                    { 91, "Lynette.Lowe19@gmail.com", "Lynette", "Lowe", "333.284.9353 x138" },
                    { 92, "Edward29@gmail.com", "Edward", "Strosin", "973-430-8635" },
                    { 93, "Kurt.Pfeffer19@hotmail.com", "Kurt", "Pfeffer", "843-583-3868 x3949" },
                    { 94, "Gerard_Beahan@gmail.com", "Gerard", "Beahan", "1-964-274-9366 x668" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 95, "Lorene_Dach@gmail.com", "Lorene", "Dach", "632.534.2511" },
                    { 96, "Candice_Maggio@yahoo.com", "Candice", "Maggio", "956-238-6823 x269" },
                    { 97, "Charlotte58@hotmail.com", "Charlotte", "Harber", "268-709-5624 x3319" },
                    { 98, "Sandra27@hotmail.com", "Sandra", "Raynor", "573-744-2639 x3864" },
                    { 99, "Kari.Davis90@hotmail.com", "Kari", "Davis", "837-767-7793" },
                    { 100, "Mack35@hotmail.com", "Mack", "Hills", "755-260-9008" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), "Tennessee", "New Nicole", "Norma.Denesik@yahoo.com", "Norma", "Denesik", "", "(912) 408-0266 x7143", "83610-5842" },
                    { new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), "Louisiana", "East Newell", "Hope70@hotmail.com", "Hope", "Rowe", "", "1-415-914-7285 x8763", "38744" },
                    { new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), "New Mexico", "East Gracie", "Natalie_Durgan@hotmail.com", "Natalie", "Durgan", "", "251.290.3333 x08042", "00150" },
                    { new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), "Montana", "Port Larryside", "Sam70@yahoo.com", "Sam", "Watsica", "", "930-945-0192", "23157" },
                    { new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), "Ohio", "Andersonmouth", "Ralph33@yahoo.com", "Ralph", "Schuster", "", "(347) 257-6999 x149", "63568" },
                    { new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), "Massachusetts", "Rickeytown", "Joshua72@gmail.com", "Joshua", "Boyer", "", "(910) 408-5190", "27339-5502" },
                    { new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), "Arizona", "Lucienneberg", "Corey87@hotmail.com", "Corey", "McGlynn", "", "(883) 756-9430", "16350-0550" },
                    { new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), "Colorado", "Lake Leda", "Leah92@gmail.com", "Leah", "Leffler", "", "732-910-6987", "28766" },
                    { new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), "New Hampshire", "South Jerad", "Alfonso_Pollich@gmail.com", "Alfonso", "Pollich", "", "694.315.9401", "52401-1004" },
                    { new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), "North Dakota", "Lake Nehamouth", "Jared.Lockman40@yahoo.com", "Jared", "Lockman", "", "914-758-6171", "54308" },
                    { new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), "Missouri", "Lake Nakia", "Winifred7@hotmail.com", "Winifred", "Blick", "", "(490) 819-9799", "91208-6636" },
                    { new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), "West Virginia", "Leschstad", "Virginia.Wehner@gmail.com", "Virginia", "Wehner", "", "(345) 260-8063", "84432" },
                    { new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), "Indiana", "North Taureanshire", "Jeffrey.Spinka24@gmail.com", "Jeffrey", "Spinka", "", "986-435-2698", "40181-6193" },
                    { new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), "Utah", "Cronintown", "Jorge_Koelpin93@hotmail.com", "Jorge", "Koelpin", "", "455-850-7027 x458", "11514" },
                    { new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), "Utah", "South Margarettberg", "Glenda_Dibbert13@yahoo.com", "Glenda", "Dibbert", "", "303-585-5688", "68688" },
                    { new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), "Hawaii", "East Rosie", "Gerardo49@gmail.com", "Gerardo", "Pollich", "", "714-669-4116 x747", "96361" },
                    { new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), "Indiana", "New Adrien", "Maria_Hahn@yahoo.com", "Maria", "Hahn", "", "512-349-0417 x881", "79232" },
                    { new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), "New York", "Port Quintenhaven", "Shelia87@yahoo.com", "Shelia", "Robel", "", "825-285-1106", "54306-0275" },
                    { new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), "Indiana", "Kochville", "Lyle_Runolfsdottir29@yahoo.com", "Lyle", "Runolfsdottir", "", "770-535-8063 x8738", "89352" },
                    { new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), "Alaska", "Kerlukeborough", "Beatrice41@hotmail.com", "Beatrice", "Huels", "", "(662) 592-0211", "12567-9485" },
                    { new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), "Utah", "Rogahnview", "Alfredo65@yahoo.com", "Alfredo", "Miller", "", "(875) 579-5492 x36794", "87352-9303" },
                    { new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), "Washington", "Leaview", "Troy21@hotmail.com", "Troy", "Purdy", "", "966-460-9491 x9148", "85028-4465" },
                    { new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), "Wyoming", "Laurianeberg", "Janet.Kling@hotmail.com", "Janet", "Kling", "", "914.270.4335", "40251-0222" },
                    { new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), "Maryland", "Nikkoborough", "Ida75@hotmail.com", "Ida", "Dicki", "", "(213) 419-8016 x38206", "18645" },
                    { new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), "North Dakota", "Aureliofurt", "Naomi.Boehm@yahoo.com", "Naomi", "Boehm", "", "313-605-9634 x04005", "57652-5607" },
                    { new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), "Maryland", "New Keeleytown", "Nancy_Wiegand@hotmail.com", "Nancy", "Wiegand", "", "795.271.7567 x3321", "11204-4407" },
                    { new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), "Rhode Island", "West Ramon", "Mandy_Hills@yahoo.com", "Mandy", "Hills", "", "515-807-5884", "00612" },
                    { new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), "Washington", "South Adolphhaven", "Lonnie_Maggio@gmail.com", "Lonnie", "Maggio", "", "929.346.0709", "30468" },
                    { new Guid("4bea0974-48a9-4c81-9a71-859448886b94"), "98171 Casper Route", "North Jazlynmouth", "admin@admin.com", "Lucy", "O'Keefe", "AQAAAAEAACcQAAAAEPVUodxzUig0advQ7fuqwEIQ05IoI6mng3ucQCRV+ps/m1wkOZZntA9k++uhVjb/KQ==", "(950) 751-9229", "61318" },
                    { new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), "Kentucky", "West Khalidmouth", "Felix_Oberbrunner61@hotmail.com", "Felix", "Oberbrunner", "", "912.640.5142", "66045" },
                    { new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), "Indiana", "North Pierreberg", "Thelma32@gmail.com", "Thelma", "MacGyver", "", "1-740-616-1956 x80807", "79150-0176" },
                    { new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), "Georgia", "New Chaimville", "Vincent26@gmail.com", "Vincent", "Kuhlman", "", "479.307.8326", "30756-1402" },
                    { new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), "Minnesota", "Ivaside", "John43@yahoo.com", "John", "Kohler", "", "797-556-4837", "61372-0882" },
                    { new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), "Montana", "Port Lela", "Jose.McDermott@hotmail.com", "Jose", "McDermott", "", "748-723-5932 x3792", "75252-3633" },
                    { new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), "Illinois", "South Mauricio", "Erik4@gmail.com", "Erik", "Rosenbaum", "", "878.243.1583", "51352" },
                    { new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), "Connecticut", "West Agnesburgh", "Steven_Wilkinson@gmail.com", "Steven", "Wilkinson", "", "(256) 940-9020", "09076" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), "North Dakota", "Port Donaldstad", "Blanche.Breitenberg@hotmail.com", "Blanche", "Breitenberg", "", "1-325-564-7325", "12945" },
                    { new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), "Iowa", "Hellerfurt", "Rochelle_Christiansen@yahoo.com", "Rochelle", "Christiansen", "", "279-961-9787 x776", "58244-9466" },
                    { new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), "West Virginia", "Schillerstad", "Todd40@hotmail.com", "Todd", "Tromp", "", "544.246.4886 x2969", "95548" },
                    { new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), "North Dakota", "New Oscarstad", "Dora59@yahoo.com", "Dora", "Zemlak", "", "204-393-5142", "87242-1207" },
                    { new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), "North Carolina", "Port Adrienfort", "Jessie.Greenfelder79@hotmail.com", "Jessie", "Greenfelder", "", "862.396.8463", "42660" },
                    { new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), "Wyoming", "Corwinburgh", "Alfredo21@hotmail.com", "Alfredo", "Pouros", "", "(467) 810-5030 x50215", "35636" },
                    { new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), "Kansas", "North Marcelport", "Felicia14@gmail.com", "Felicia", "Runolfsson", "", "530-563-0785", "44823" },
                    { new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), "Arkansas", "South Kayley", "James.Dare@gmail.com", "James", "Dare", "", "(825) 604-0440 x0383", "60212-8664" },
                    { new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), "California", "Port Arthur", "Jamie51@yahoo.com", "Jamie", "Gerlach", "", "783-562-7021 x455", "98406" },
                    { new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), "Illinois", "Manleyview", "David.Spinka@hotmail.com", "David", "Spinka", "", "727-573-8517", "40372-7446" },
                    { new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), "Maryland", "West Rolando", "Jessie_Cronin@yahoo.com", "Jessie", "Cronin", "", "218-237-3518 x12079", "91604-1302" },
                    { new Guid("852129c5-792c-4c75-a148-9d065dc70834"), "Mississippi", "Bayerfort", "Jamie_Schulist@yahoo.com", "Jamie", "Schulist", "", "(451) 698-1496 x3521", "48685" },
                    { new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), "Arizona", "New Alexieport", "Jennifer14@yahoo.com", "Jennifer", "Howe", "", "600-651-9017 x976", "65844-0129" },
                    { new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), "Oregon", "Conroyport", "Cary41@hotmail.com", "Cary", "Feeney", "", "(863) 312-0760 x67067", "88497" },
                    { new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), "Kansas", "Port Annette", "Alfonso_Block@hotmail.com", "Alfonso", "Block", "", "926-743-5256 x9861", "82864" },
                    { new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), "Kansas", "West Susanna", "Lewis_Davis76@gmail.com", "Lewis", "Davis", "", "469.620.7726 x184", "73507-8540" },
                    { new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), "Iowa", "South Amanda", "Jenny.Boyer24@yahoo.com", "Jenny", "Boyer", "", "(754) 930-2060 x450", "40495" },
                    { new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), "New York", "Port Katrina", "Mona.Weber19@yahoo.com", "Mona", "Weber", "", "1-316-821-9565", "05917" },
                    { new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), "Delaware", "Akeemmouth", "William_Bradtke53@hotmail.com", "William", "Bradtke", "", "(944) 260-6070 x6682", "62702" },
                    { new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), "Georgia", "East Roy", "Stacey_Powlowski24@gmail.com", "Stacey", "Powlowski", "", "(411) 251-1615", "09088" },
                    { new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), "Louisiana", "Kulasmouth", "Debbie.Schinner56@yahoo.com", "Debbie", "Schinner", "", "1-851-257-8902 x5315", "85826-2541" },
                    { new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), "South Dakota", "Jasperchester", "Chris35@gmail.com", "Chris", "Runolfsson", "", "(656) 498-5840 x614", "26132" },
                    { new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), "Colorado", "Lake Florence", "Erika49@gmail.com", "Erika", "Kuphal", "", "1-358-251-1151", "29618" },
                    { new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), "Hawaii", "Port Maximusfort", "Clara.Harvey67@gmail.com", "Clara", "Harvey", "", "1-937-825-7511 x708", "79737-6659" },
                    { new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), "Connecticut", "Bettyefurt", "Silvia16@yahoo.com", "Silvia", "Shields", "", "675.941.3303", "05131-7497" },
                    { new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), "Arizona", "North Kayliborough", "Pedro_Jast9@gmail.com", "Pedro", "Jast", "", "559.447.6406", "42668-5481" },
                    { new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), "Ohio", "Henryhaven", "Gustavo.Rodriguez4@gmail.com", "Gustavo", "Rodriguez", "", "1-758-718-1972 x79408", "80430" },
                    { new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), "Missouri", "Terryland", "Pauline.Pfeffer25@gmail.com", "Pauline", "Pfeffer", "", "1-382-385-8401 x13146", "86825" },
                    { new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), "Rhode Island", "Port Zula", "Lee_Glover68@hotmail.com", "Lee", "Glover", "", "(893) 283-0313", "77838-4102" },
                    { new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), "Michigan", "North Brent", "Holly76@gmail.com", "Holly", "Douglas", "", "1-978-233-0671 x43387", "71848-1618" },
                    { new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), "Oregon", "Assuntashire", "Ernesto.Terry49@hotmail.com", "Ernesto", "Terry", "", "902.633.4703 x942", "80817" },
                    { new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), "Minnesota", "Hudsonshire", "Abraham.Powlowski@yahoo.com", "Abraham", "Powlowski", "", "749.327.4406", "05227-7128" },
                    { new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), "Ohio", "Reichertton", "George_Cremin66@gmail.com", "George", "Cremin", "", "613.983.8346 x12294", "32899" },
                    { new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), "Oklahoma", "Justicemouth", "Rafael.Bergnaum@hotmail.com", "Rafael", "Bergnaum", "", "(833) 811-0365", "48030-3965" },
                    { new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), "Washington", "New Sebastian", "Jon21@gmail.com", "Jon", "Berge", "", "(997) 352-8187 x09003", "73323-2961" },
                    { new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), "New Mexico", "New Kurtisburgh", "Tami_Muller65@yahoo.com", "Tami", "Muller", "", "1-646-770-1797", "37336" },
                    { new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), "Nebraska", "Kaylistad", "Emanuel_White@gmail.com", "Emanuel", "White", "", "(390) 883-9320", "56177-4715" },
                    { new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), "West Virginia", "Reidside", "Willis58@yahoo.com", "Willis", "Kshlerin", "", "560-806-0241", "90597-5809" },
                    { new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), "Colorado", "West Valerie", "Paulette.Quitzon@gmail.com", "Paulette", "Quitzon", "", "(986) 424-3702 x22474", "04682" },
                    { new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), "New Hampshire", "East Ruben", "Erma57@hotmail.com", "Erma", "Koepp", "", "1-851-499-4983 x7934", "78452" },
                    { new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), "Nebraska", "East Judson", "Charles8@hotmail.com", "Charles", "Windler", "", "1-802-446-6319 x2243", "66902-6043" },
                    { new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), "North Dakota", "Kundemouth", "Bobby_Kiehn@gmail.com", "Bobby", "Kiehn", "", "(490) 903-7099", "17060-0426" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), "Tennessee", "Lake Margaritafort", "Ana.Douglas16@hotmail.com", "Ana", "Douglas", "", "212-938-3814", "67197-2082" },
                    { new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), "Kansas", "Modestaland", "Morris50@gmail.com", "Morris", "Casper", "", "1-331-836-9860 x7423", "98707-2617" },
                    { new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), "Mississippi", "West Cristopherhaven", "Lynn.MacGyver41@hotmail.com", "Lynn", "MacGyver", "", "481.371.2265 x51074", "99591-2808" },
                    { new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), "Vermont", "MacGyvershire", "Ellis.Block46@gmail.com", "Ellis", "Block", "", "(498) 752-8150", "88298-6079" },
                    { new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), "New Mexico", "South Rodgerborough", "Janis.Paucek@hotmail.com", "Janis", "Paucek", "", "1-940-293-0677 x416", "53915-8974" },
                    { new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), "South Carolina", "South Reinafurt", "Joy_Bayer@yahoo.com", "Joy", "Bayer", "", "1-984-468-5279 x132", "38335" },
                    { new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), "New Mexico", "East Matildaborough", "Wanda.Predovic28@yahoo.com", "Wanda", "Predovic", "", "(600) 776-7511", "64245-6235" },
                    { new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), "Virginia", "Schmidtland", "Levi.Pagac@gmail.com", "Levi", "Pagac", "", "652.875.6516", "55782" },
                    { new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), "Delaware", "Providencistad", "Victor_Casper@hotmail.com", "Victor", "Casper", "", "453.651.2751", "77704-2813" },
                    { new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), "Tennessee", "Morganchester", "Eileen51@hotmail.com", "Eileen", "Dickinson", "", "528-923-5686 x34513", "38628-0873" },
                    { new Guid("de92104f-7077-4376-9058-2cccd493d364"), "North Dakota", "Swiftchester", "Noah76@hotmail.com", "Noah", "Deckow", "", "(322) 351-4057", "75538-0542" },
                    { new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), "Minnesota", "East Rosalindamouth", "Randolph_Rolfson@yahoo.com", "Randolph", "Rolfson", "", "346-963-1972", "76983-7409" },
                    { new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), "Wyoming", "Celestinobury", "Dwight.Halvorson71@yahoo.com", "Dwight", "Halvorson", "", "942-902-1349 x6658", "04094" },
                    { new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), "Utah", "South Larryfurt", "Gerald.Beahan@hotmail.com", "Gerald", "Beahan", "", "777-556-8763", "46578-9698" },
                    { new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), "West Virginia", "South Alborough", "Jeremiah.Wisoky78@hotmail.com", "Jeremiah", "Wisoky", "", "616-385-0985", "20333-4925" },
                    { new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), "Florida", "New Arielfurt", "Margaret29@yahoo.com", "Margaret", "Feil", "", "1-761-280-3514 x91027", "34231-6057" },
                    { new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), "South Carolina", "Bransonberg", "Bethany.Okuneva@gmail.com", "Bethany", "Okuneva", "", "930.976.2573", "89976-4884" },
                    { new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), "Wyoming", "Ernsertown", "Alan3@gmail.com", "Alan", "Orn", "", "587-330-6049", "93882-3665" },
                    { new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), "Wisconsin", "West Domenick", "Warren.Boyer@yahoo.com", "Warren", "Boyer", "", "357.301.9207 x162", "67384" },
                    { new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), "Maine", "East Juwanchester", "Viola.Runolfsson73@yahoo.com", "Viola", "Runolfsson", "", "536-946-9830 x362", "52640-5515" },
                    { new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), "Wisconsin", "Lake Justynview", "Kristen.Grady30@yahoo.com", "Kristen", "Grady", "", "563-278-8716", "03091-4650" },
                    { new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), "Kentucky", "North Desmondville", "Ryan.Mitchell@hotmail.com", "Ryan", "Mitchell", "", "618.365.7940 x766", "30621" },
                    { new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), "Oklahoma", "Heaneyport", "Gerald_Brekke@yahoo.com", "Gerald", "Brekke", "", "1-680-203-2548 x8813", "99220-6539" }
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
                    { 1, "Jonathan_Fahey17@hotmail.com", "Jonathan", false, "Fahey", "209-400-5657 x8692" },
                    { 2, "Ramon21@hotmail.com", "Ramon", false, "O'Reilly", "602-603-8809" },
                    { 3, "Malcolm.Rice6@yahoo.com", "Malcolm", false, "Rice", "363-894-7136 x0770" },
                    { 4, "Sherry_McGlynn@yahoo.com", "Sherry", false, "McGlynn", "1-999-775-5196 x5702" },
                    { 5, "Kenneth_Adams@hotmail.com", "Kenneth", false, "Adams", "(625) 340-8809" },
                    { 6, "Abraham82@hotmail.com", "Abraham", false, "Thompson", "1-346-968-8631 x20861" },
                    { 7, "Kate_Koepp15@gmail.com", "Kate", false, "Koepp", "1-649-745-0213 x01979" },
                    { 8, "Tracy.Konopelski@yahoo.com", "Tracy", false, "Konopelski", "(680) 404-7302" },
                    { 9, "Dustin_Jones6@gmail.com", "Dustin", false, "Jones", "(639) 361-1185" },
                    { 10, "Abel.Gerhold3@hotmail.com", "Abel", false, "Gerhold", "(903) 534-9830" },
                    { 11, "Antonia.Braun73@yahoo.com", "Antonia", false, "Braun", "547-933-4009 x6116" },
                    { 12, "Donald_Mertz20@hotmail.com", "Donald", false, "Mertz", "1-714-547-2293 x674" },
                    { 13, "Sophie.McLaughlin@yahoo.com", "Sophie", false, "McLaughlin", "1-821-616-0827 x9094" },
                    { 14, "Janet75@yahoo.com", "Janet", false, "Gerlach", "(530) 713-6257" },
                    { 15, "Irvin_Dickens@hotmail.com", "Irvin", false, "Dickens", "570-356-3780" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { 16, "Frederick_Cremin@yahoo.com", "Frederick", false, "Cremin", "890.343.6397 x70729" },
                    { 17, "Grace81@yahoo.com", "Grace", false, "Larson", "1-722-965-1676" },
                    { 18, "Alfred_Schumm15@hotmail.com", "Alfred", false, "Schumm", "1-382-355-3275" },
                    { 19, "Lydia19@yahoo.com", "Lydia", false, "Conroy", "472-917-2928" }
                });

            migrationBuilder.InsertData(
                table: "Approve",
                columns: new[] { "ApproveID", "Description", "FK_UserUUID", "Positive" },
                values: new object[,]
                {
                    { 1, "", new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), true },
                    { 2, "", new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), true },
                    { 3, "", new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), true },
                    { 4, "", new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), false },
                    { 5, "", new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), true },
                    { 6, "", new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), false },
                    { 7, "", new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), true },
                    { 8, "", new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), true },
                    { 9, "", new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), true },
                    { 10, "", new Guid("852129c5-792c-4c75-a148-9d065dc70834"), false },
                    { 11, "", new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), true },
                    { 12, "", new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), true },
                    { 13, "", new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), true },
                    { 14, "", new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), true },
                    { 15, "", new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), false },
                    { 16, "", new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), false },
                    { 17, "", new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), false },
                    { 18, "", new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), true },
                    { 19, "", new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), false },
                    { 20, "", new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), true },
                    { 21, "", new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), true },
                    { 22, "", new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), false },
                    { 23, "", new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), true },
                    { 24, "", new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), false },
                    { 25, "", new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), true },
                    { 26, "", new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), false },
                    { 27, "", new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), false },
                    { 28, "", new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), true },
                    { 29, "", new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), true },
                    { 30, "", new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), true }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 1, "", new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), 4, 1 },
                    { 2, "", new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), 3, 3 },
                    { 3, "", new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), 6, 2 },
                    { 4, "", new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), 4, 3 },
                    { 5, "", new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), 2, 3 },
                    { 6, "", new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), 4, 2 },
                    { 7, "", new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), 5, 2 },
                    { 8, "", new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), 3, 3 },
                    { 9, "", new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), 2, 2 },
                    { 10, "", new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), 3, 1 },
                    { 11, "", new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), 4, 3 },
                    { 12, "", new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 13, "", new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), 6, 2 },
                    { 14, "", new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), 3, 3 },
                    { 15, "", new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), 4, 3 },
                    { 16, "", new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), 4, 1 },
                    { 17, "", new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), 5, 3 },
                    { 18, "", new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), 2, 2 },
                    { 19, "", new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), 3, 3 },
                    { 20, "", new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), 1, 1 },
                    { 21, "", new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), 3, 2 },
                    { 22, "", new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), 2, 3 },
                    { 23, "", new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), 6, 2 },
                    { 24, "", new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), 4, 2 },
                    { 25, "", new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), 1, 3 },
                    { 26, "", new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), 2, 1 },
                    { 27, "", new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), 5, 3 },
                    { 28, "", new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), 4, 3 },
                    { 29, "", new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), 2, 3 },
                    { 30, "", new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), 2, 2 },
                    { 31, "", new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), 2, 2 },
                    { 32, "", new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), 5, 1 },
                    { 33, "", new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), 4, 3 },
                    { 34, "", new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), 1, 1 },
                    { 35, "", new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), 6, 3 },
                    { 36, "", new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), 2, 3 },
                    { 37, "", new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), 2, 3 },
                    { 38, "", new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), 3, 1 },
                    { 39, "", new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), 2, 2 },
                    { 40, "", new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), 4, 2 },
                    { 41, "", new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), 4, 1 },
                    { 42, "", new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), 1, 1 },
                    { 43, "", new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), 5, 1 },
                    { 44, "", new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), 5, 2 },
                    { 45, "", new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), 6, 1 },
                    { 46, "", new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), 4, 3 },
                    { 47, "", new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), 5, 1 },
                    { 48, "", new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), 5, 3 },
                    { 49, "", new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), 4, 1 },
                    { 50, "", new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), 1, 3 },
                    { 51, "", new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), 4, 1 },
                    { 52, "", new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), 2, 1 },
                    { 53, "", new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), 1, 3 },
                    { 54, "", new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 55, "", new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), 2, 1 },
                    { 56, "", new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), 4, 2 },
                    { 57, "", new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), 4, 1 },
                    { 58, "", new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), 2, 1 },
                    { 59, "", new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), 1, 1 },
                    { 60, "", new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), 2, 1 },
                    { 61, "", new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), 2, 1 },
                    { 62, "", new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), 6, 2 },
                    { 63, "", new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), 3, 2 },
                    { 64, "", new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), 2, 1 },
                    { 65, "", new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), 1, 1 },
                    { 66, "", new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), 5, 3 },
                    { 67, "", new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), 2, 1 },
                    { 68, "", new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), 4, 2 },
                    { 69, "", new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), 3, 1 },
                    { 70, "", new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), 3, 2 },
                    { 71, "", new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), 2, 3 },
                    { 72, "", new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), 5, 1 },
                    { 73, "", new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), 1, 2 },
                    { 74, "", new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), 1, 2 },
                    { 75, "", new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), 1, 3 },
                    { 76, "", new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), 1, 3 },
                    { 77, "", new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), 3, 3 },
                    { 78, "", new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), 6, 3 },
                    { 79, "", new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), 4, 3 },
                    { 80, "", new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), 3, 1 },
                    { 81, "", new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), 2, 2 },
                    { 82, "", new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), 1, 2 },
                    { 83, "", new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), 2, 1 },
                    { 84, "", new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), 5, 3 },
                    { 85, "", new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), 5, 1 },
                    { 86, "", new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), 4, 1 },
                    { 87, "", new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), 6, 3 },
                    { 88, "", new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), 1, 1 },
                    { 89, "", new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), 1, 2 },
                    { 90, "", new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), 6, 3 },
                    { 91, "", new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), 6, 3 },
                    { 92, "", new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), 4, 1 },
                    { 93, "", new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), 3, 1 },
                    { 94, "", new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), 3, 1 },
                    { 95, "", new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), 2, 1 },
                    { 96, "", new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 97, "", new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), 1, 2 },
                    { 98, "", new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), 2, 3 },
                    { 99, "", new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), 6, 1 },
                    { 100, "", new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), 1, 3 },
                    { 101, "", new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), 1, 3 },
                    { 102, "", new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), 3, 3 },
                    { 103, "", new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), 3, 3 },
                    { 104, "", new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), 4, 1 },
                    { 105, "", new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), 2, 1 },
                    { 106, "", new Guid("de92104f-7077-4376-9058-2cccd493d364"), 5, 2 },
                    { 107, "", new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), 6, 1 },
                    { 108, "", new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), 5, 3 },
                    { 109, "", new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), 3, 3 },
                    { 110, "", new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), 6, 3 },
                    { 111, "", new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), 3, 3 },
                    { 112, "", new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), 2, 3 },
                    { 113, "", new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), 6, 1 },
                    { 114, "", new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), 4, 1 },
                    { 115, "", new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), 4, 3 },
                    { 116, "", new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), 2, 3 },
                    { 117, "", new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), 5, 1 },
                    { 118, "", new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), 4, 2 },
                    { 119, "", new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), 6, 1 },
                    { 120, "", new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), 1, 3 },
                    { 121, "", new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), 6, 3 },
                    { 122, "", new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), 1, 2 },
                    { 123, "", new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), 2, 1 },
                    { 124, "", new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), 6, 3 },
                    { 125, "", new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), 2, 3 },
                    { 126, "", new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), 1, 2 },
                    { 127, "", new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), 4, 3 },
                    { 128, "", new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), 6, 3 },
                    { 129, "", new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), 3, 2 },
                    { 130, "", new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), 3, 1 },
                    { 131, "", new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), 1, 1 },
                    { 132, "", new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), 6, 3 },
                    { 133, "", new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), 3, 1 },
                    { 134, "", new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), 4, 3 },
                    { 135, "", new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), 6, 2 },
                    { 136, "", new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), 1, 1 },
                    { 137, "", new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), 3, 3 },
                    { 138, "", new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 139, "", new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), 2, 1 },
                    { 140, "", new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), 5, 1 },
                    { 141, "", new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), 3, 1 },
                    { 142, "", new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), 2, 1 },
                    { 143, "", new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), 5, 1 },
                    { 144, "", new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), 6, 1 },
                    { 145, "", new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), 2, 2 },
                    { 146, "", new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), 1, 2 },
                    { 147, "", new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), 6, 2 },
                    { 148, "", new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), 4, 1 },
                    { 149, "", new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), 2, 2 },
                    { 150, "", new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), 6, 2 },
                    { 151, "", new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), 1, 1 },
                    { 152, "", new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), 2, 2 },
                    { 153, "", new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), 1, 3 },
                    { 154, "", new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), 1, 1 },
                    { 155, "", new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), 3, 1 },
                    { 156, "", new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), 2, 1 },
                    { 157, "", new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), 4, 2 },
                    { 158, "", new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), 3, 3 },
                    { 159, "", new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), 1, 2 },
                    { 160, "", new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), 3, 2 },
                    { 161, "", new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), 5, 3 },
                    { 162, "", new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), 5, 3 },
                    { 163, "", new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), 5, 2 },
                    { 164, "", new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), 5, 1 },
                    { 165, "", new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), 4, 2 },
                    { 166, "", new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), 4, 1 },
                    { 167, "", new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), 2, 1 },
                    { 168, "", new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), 5, 2 },
                    { 169, "", new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), 4, 1 },
                    { 170, "", new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), 5, 3 },
                    { 171, "", new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), 6, 3 },
                    { 172, "", new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), 1, 3 },
                    { 173, "", new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), 4, 1 },
                    { 174, "", new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), 5, 1 },
                    { 175, "", new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), 2, 1 },
                    { 176, "", new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), 3, 1 },
                    { 177, "", new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), 2, 2 },
                    { 178, "", new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), 5, 3 },
                    { 179, "", new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), 5, 3 },
                    { 180, "", new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 181, "", new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), 2, 2 },
                    { 182, "", new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), 6, 3 },
                    { 183, "", new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), 1, 1 },
                    { 184, "", new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), 2, 2 },
                    { 185, "", new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), 3, 2 },
                    { 186, "", new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), 4, 2 },
                    { 187, "", new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), 1, 2 },
                    { 188, "", new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), 6, 3 },
                    { 189, "", new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), 6, 1 },
                    { 190, "", new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), 5, 3 },
                    { 191, "", new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), 6, 3 },
                    { 192, "", new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), 6, 3 },
                    { 193, "", new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), 5, 2 },
                    { 194, "", new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), 3, 1 },
                    { 195, "", new Guid("de92104f-7077-4376-9058-2cccd493d364"), 1, 1 },
                    { 196, "", new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), 5, 1 },
                    { 197, "", new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), 6, 2 },
                    { 198, "", new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), 5, 2 },
                    { 199, "", new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), 2, 1 },
                    { 200, "", new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), 6, 3 },
                    { 201, "", new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), 5, 1 },
                    { 202, "", new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), 5, 2 },
                    { 203, "", new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), 4, 2 },
                    { 204, "", new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), 4, 1 },
                    { 205, "", new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), 6, 1 },
                    { 206, "", new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), 6, 1 },
                    { 207, "", new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), 1, 3 },
                    { 208, "", new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), 4, 2 },
                    { 209, "", new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), 6, 2 },
                    { 210, "", new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), 6, 1 },
                    { 211, "", new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), 3, 2 },
                    { 212, "", new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), 4, 2 },
                    { 213, "", new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), 1, 1 },
                    { 214, "", new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), 6, 1 },
                    { 215, "", new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), 6, 2 },
                    { 216, "", new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), 6, 3 },
                    { 217, "", new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), 5, 2 },
                    { 218, "", new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), 1, 1 },
                    { 219, "", new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), 5, 2 },
                    { 220, "", new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), 4, 1 },
                    { 221, "", new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), 2, 1 },
                    { 222, "", new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 223, "", new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), 1, 3 },
                    { 224, "", new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), 6, 1 },
                    { 225, "", new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), 3, 2 },
                    { 226, "", new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), 6, 3 },
                    { 227, "", new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), 5, 1 },
                    { 228, "", new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), 2, 3 },
                    { 229, "", new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), 6, 3 },
                    { 230, "", new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), 6, 1 },
                    { 231, "", new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), 3, 3 },
                    { 232, "", new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), 2, 1 },
                    { 233, "", new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), 4, 2 },
                    { 234, "", new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), 6, 1 },
                    { 235, "", new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), 6, 3 },
                    { 236, "", new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), 3, 1 },
                    { 237, "", new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), 2, 1 },
                    { 238, "", new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), 5, 1 },
                    { 239, "", new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), 6, 3 },
                    { 240, "", new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), 1, 2 },
                    { 241, "", new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), 3, 2 },
                    { 242, "", new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), 3, 1 },
                    { 243, "", new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), 1, 2 },
                    { 244, "", new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), 6, 1 },
                    { 245, "", new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), 4, 1 },
                    { 246, "", new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), 5, 3 },
                    { 247, "", new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), 2, 1 },
                    { 248, "", new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), 5, 2 },
                    { 249, "", new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), 4, 2 },
                    { 250, "", new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), 4, 3 },
                    { 251, "", new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), 1, 1 },
                    { 252, "", new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), 4, 2 },
                    { 253, "", new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), 3, 1 },
                    { 254, "", new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), 4, 3 },
                    { 255, "", new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), 6, 2 },
                    { 256, "", new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), 6, 2 },
                    { 257, "", new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), 2, 1 },
                    { 258, "", new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), 4, 3 },
                    { 259, "", new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), 4, 2 },
                    { 260, "", new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), 2, 2 },
                    { 261, "", new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), 6, 2 },
                    { 262, "", new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), 1, 3 },
                    { 263, "", new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), 1, 1 },
                    { 264, "", new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 265, "", new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), 3, 1 },
                    { 266, "", new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), 6, 1 },
                    { 267, "", new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), 3, 2 },
                    { 268, "", new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), 1, 2 },
                    { 269, "", new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), 3, 3 },
                    { 270, "", new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), 6, 1 },
                    { 271, "", new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), 4, 1 },
                    { 272, "", new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), 5, 1 },
                    { 273, "", new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), 5, 2 },
                    { 274, "", new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), 2, 3 },
                    { 275, "", new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), 6, 3 },
                    { 276, "", new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), 4, 1 },
                    { 277, "", new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), 3, 2 },
                    { 278, "", new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), 6, 1 },
                    { 279, "", new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), 1, 2 },
                    { 280, "", new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), 3, 2 },
                    { 281, "", new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), 3, 1 },
                    { 282, "", new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), 2, 3 },
                    { 283, "", new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), 6, 3 },
                    { 284, "", new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), 4, 2 },
                    { 285, "", new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), 4, 3 },
                    { 286, "", new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), 4, 2 },
                    { 287, "", new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), 3, 2 },
                    { 288, "", new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), 4, 3 },
                    { 289, "", new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), 3, 2 },
                    { 290, "", new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), 1, 2 },
                    { 291, "", new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), 6, 1 },
                    { 292, "", new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), 5, 3 },
                    { 293, "", new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), 6, 3 },
                    { 294, "", new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), 6, 1 },
                    { 295, "", new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), 3, 2 },
                    { 296, "", new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), 6, 2 },
                    { 297, "", new Guid("852129c5-792c-4c75-a148-9d065dc70834"), 3, 2 },
                    { 298, "", new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), 4, 3 },
                    { 299, "", new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), 1, 3 },
                    { 300, "", new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), 5, 1 },
                    { 301, "", new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), 3, 2 },
                    { 302, "", new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), 5, 2 },
                    { 303, "", new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), 1, 1 },
                    { 304, "", new Guid("de92104f-7077-4376-9058-2cccd493d364"), 1, 1 },
                    { 305, "", new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), 3, 3 },
                    { 306, "", new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 307, "", new Guid("852129c5-792c-4c75-a148-9d065dc70834"), 6, 2 },
                    { 308, "", new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), 6, 3 },
                    { 309, "", new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), 2, 3 },
                    { 310, "", new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), 5, 2 },
                    { 311, "", new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), 3, 1 },
                    { 312, "", new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), 2, 2 },
                    { 313, "", new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), 1, 3 },
                    { 314, "", new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), 3, 3 },
                    { 315, "", new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), 5, 1 },
                    { 316, "", new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), 4, 3 },
                    { 317, "", new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), 1, 3 },
                    { 318, "", new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), 4, 3 },
                    { 319, "", new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), 5, 2 },
                    { 320, "", new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), 3, 1 },
                    { 321, "", new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), 2, 1 },
                    { 322, "", new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), 1, 1 },
                    { 323, "", new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), 1, 2 },
                    { 324, "", new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), 4, 2 },
                    { 325, "", new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), 1, 2 },
                    { 326, "", new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), 2, 1 },
                    { 327, "", new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), 3, 2 },
                    { 328, "", new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), 6, 3 },
                    { 329, "", new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), 2, 2 },
                    { 330, "", new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), 3, 1 },
                    { 331, "", new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), 6, 3 },
                    { 332, "", new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), 4, 3 },
                    { 333, "", new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), 4, 3 },
                    { 334, "", new Guid("de92104f-7077-4376-9058-2cccd493d364"), 4, 2 },
                    { 335, "", new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), 4, 1 },
                    { 336, "", new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), 6, 1 },
                    { 337, "", new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), 4, 1 },
                    { 338, "", new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), 2, 3 },
                    { 339, "", new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), 6, 1 },
                    { 340, "", new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), 6, 1 },
                    { 341, "", new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), 1, 1 },
                    { 342, "", new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), 3, 3 },
                    { 343, "", new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), 5, 1 },
                    { 344, "", new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), 4, 1 },
                    { 345, "", new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), 5, 3 },
                    { 346, "", new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), 4, 1 },
                    { 347, "", new Guid("852129c5-792c-4c75-a148-9d065dc70834"), 2, 2 },
                    { 348, "", new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 349, "", new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), 5, 3 },
                    { 350, "", new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), 5, 2 },
                    { 351, "", new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), 3, 1 },
                    { 352, "", new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), 5, 3 },
                    { 353, "", new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), 1, 1 },
                    { 354, "", new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), 5, 1 },
                    { 355, "", new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), 5, 1 },
                    { 356, "", new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), 5, 1 },
                    { 357, "", new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), 5, 3 },
                    { 358, "", new Guid("de92104f-7077-4376-9058-2cccd493d364"), 5, 2 },
                    { 359, "", new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), 5, 1 },
                    { 360, "", new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), 1, 2 },
                    { 361, "", new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), 5, 2 },
                    { 362, "", new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), 5, 3 },
                    { 363, "", new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), 6, 1 },
                    { 364, "", new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), 3, 1 },
                    { 365, "", new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), 2, 2 },
                    { 366, "", new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), 1, 2 },
                    { 367, "", new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), 5, 3 },
                    { 368, "", new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), 5, 1 },
                    { 369, "", new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), 4, 3 },
                    { 370, "", new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), 6, 2 },
                    { 371, "", new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), 2, 3 },
                    { 372, "", new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), 3, 3 },
                    { 373, "", new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), 3, 1 },
                    { 374, "", new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), 4, 1 },
                    { 375, "", new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), 2, 3 },
                    { 376, "", new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), 6, 3 },
                    { 377, "", new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), 1, 3 },
                    { 378, "", new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), 5, 3 },
                    { 379, "", new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), 6, 2 },
                    { 380, "", new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), 6, 2 },
                    { 381, "", new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), 3, 1 },
                    { 382, "", new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), 1, 2 },
                    { 383, "", new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), 3, 3 },
                    { 384, "", new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), 5, 3 },
                    { 385, "", new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), 4, 2 },
                    { 386, "", new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), 5, 2 },
                    { 387, "", new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), 6, 2 },
                    { 388, "", new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), 2, 3 },
                    { 389, "", new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), 1, 3 },
                    { 390, "", new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 391, "", new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), 4, 1 },
                    { 392, "", new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), 5, 1 },
                    { 393, "", new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), 3, 1 },
                    { 394, "", new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), 5, 2 },
                    { 395, "", new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), 5, 1 },
                    { 396, "", new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), 4, 3 },
                    { 397, "", new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), 4, 3 },
                    { 398, "", new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), 1, 3 },
                    { 399, "", new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), 3, 2 },
                    { 400, "", new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), 5, 3 },
                    { 401, "", new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), 2, 2 },
                    { 402, "", new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), 5, 3 },
                    { 403, "", new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), 4, 1 },
                    { 404, "", new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), 2, 1 },
                    { 405, "", new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), 2, 1 },
                    { 406, "", new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), 4, 2 },
                    { 407, "", new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), 6, 3 },
                    { 408, "", new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), 5, 1 },
                    { 409, "", new Guid("852129c5-792c-4c75-a148-9d065dc70834"), 4, 1 },
                    { 410, "", new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), 5, 1 },
                    { 411, "", new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), 6, 1 },
                    { 412, "", new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), 3, 2 },
                    { 413, "", new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), 4, 2 },
                    { 414, "", new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), 3, 1 },
                    { 415, "", new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), 5, 2 },
                    { 416, "", new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), 2, 1 },
                    { 417, "", new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), 2, 1 },
                    { 418, "", new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), 1, 3 },
                    { 419, "", new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), 4, 3 },
                    { 420, "", new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), 5, 3 },
                    { 421, "", new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), 4, 2 },
                    { 422, "", new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), 4, 3 },
                    { 423, "", new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), 6, 3 },
                    { 424, "", new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), 2, 2 },
                    { 425, "", new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), 4, 3 },
                    { 426, "", new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), 4, 3 },
                    { 427, "", new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), 6, 2 },
                    { 428, "", new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), 2, 2 },
                    { 429, "", new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), 4, 2 },
                    { 430, "", new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), 6, 2 },
                    { 431, "", new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), 4, 3 },
                    { 432, "", new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 433, "", new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), 2, 3 },
                    { 434, "", new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), 2, 3 },
                    { 435, "", new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), 5, 3 },
                    { 436, "", new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), 3, 3 },
                    { 437, "", new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), 6, 3 },
                    { 438, "", new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), 2, 2 },
                    { 439, "", new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), 3, 1 },
                    { 440, "", new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), 6, 1 },
                    { 441, "", new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), 3, 1 },
                    { 442, "", new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), 4, 1 },
                    { 443, "", new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), 2, 3 },
                    { 444, "", new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), 2, 3 },
                    { 445, "", new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), 1, 3 },
                    { 446, "", new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), 1, 3 },
                    { 447, "", new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), 2, 2 },
                    { 448, "", new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), 2, 1 },
                    { 449, "", new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), 4, 2 },
                    { 450, "", new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), 3, 1 },
                    { 451, "", new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), 2, 1 },
                    { 452, "", new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), 6, 1 },
                    { 453, "", new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), 4, 3 },
                    { 454, "", new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), 1, 2 },
                    { 455, "", new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), 4, 1 },
                    { 456, "", new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), 5, 3 },
                    { 457, "", new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), 2, 2 },
                    { 458, "", new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), 4, 1 },
                    { 459, "", new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), 5, 2 },
                    { 460, "", new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), 3, 3 },
                    { 461, "", new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), 5, 1 },
                    { 462, "", new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), 5, 1 },
                    { 463, "", new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), 4, 2 },
                    { 464, "", new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), 5, 2 },
                    { 465, "", new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), 6, 2 },
                    { 466, "", new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), 3, 1 },
                    { 467, "", new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), 2, 1 },
                    { 468, "", new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), 6, 1 },
                    { 469, "", new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), 5, 2 },
                    { 470, "", new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), 2, 1 },
                    { 471, "", new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), 6, 3 },
                    { 472, "", new Guid("852129c5-792c-4c75-a148-9d065dc70834"), 2, 2 },
                    { 473, "", new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), 4, 3 },
                    { 474, "", new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "FK_UserUUID", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 475, "", new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), 4, 3 },
                    { 476, "", new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), 4, 1 },
                    { 477, "", new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), 2, 2 },
                    { 478, "", new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), 4, 2 },
                    { 479, "", new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), 2, 1 },
                    { 480, "", new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), 2, 1 },
                    { 481, "", new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), 6, 2 },
                    { 482, "", new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), 3, 3 },
                    { 483, "", new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), 2, 3 },
                    { 484, "", new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), 6, 1 },
                    { 485, "", new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), 2, 2 },
                    { 486, "", new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), 2, 1 },
                    { 487, "", new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), 5, 1 },
                    { 488, "", new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), 6, 2 },
                    { 489, "", new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), 5, 3 },
                    { 490, "", new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), 4, 2 },
                    { 491, "", new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), 6, 3 },
                    { 492, "", new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), 5, 3 },
                    { 493, "", new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), 4, 1 },
                    { 494, "", new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), 5, 3 },
                    { 495, "", new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), 6, 1 },
                    { 496, "", new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), 2, 2 },
                    { 497, "", new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), 1, 2 },
                    { 498, "", new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), 6, 3 },
                    { 499, "", new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), 1, 1 },
                    { 500, "", new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), true },
                    { 2, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), true },
                    { 3, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), false },
                    { 4, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), true },
                    { 5, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), false },
                    { 6, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), true },
                    { 7, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), true },
                    { 8, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), false },
                    { 9, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), false },
                    { 10, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), false },
                    { 11, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), true },
                    { 12, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), true },
                    { 13, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), true },
                    { 14, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), true },
                    { 15, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), true },
                    { 16, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 17, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), false },
                    { 18, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), false },
                    { 19, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), true },
                    { 20, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), false },
                    { 21, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), false },
                    { 22, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), false },
                    { 23, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), false },
                    { 24, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), true },
                    { 25, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), false },
                    { 26, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), false },
                    { 27, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), true },
                    { 28, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), true },
                    { 29, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), false },
                    { 30, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), false },
                    { 31, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), true },
                    { 32, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), true },
                    { 33, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), true },
                    { 34, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), false },
                    { 35, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), false },
                    { 36, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), false },
                    { 37, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), true },
                    { 38, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), true },
                    { 39, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), false },
                    { 40, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), true },
                    { 41, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), false },
                    { 42, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), true },
                    { 43, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), true },
                    { 44, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), false },
                    { 45, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), false },
                    { 46, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), true },
                    { 47, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), false },
                    { 48, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), false },
                    { 49, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), false },
                    { 50, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), true },
                    { 51, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), true },
                    { 52, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), false },
                    { 53, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), false },
                    { 54, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("852129c5-792c-4c75-a148-9d065dc70834"), false },
                    { 55, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), false },
                    { 56, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), false },
                    { 57, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), true },
                    { 58, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 59, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), true },
                    { 60, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), true },
                    { 61, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), false },
                    { 62, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), true },
                    { 63, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), true },
                    { 64, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), false },
                    { 65, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), true },
                    { 66, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), false },
                    { 67, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), false },
                    { 68, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), false },
                    { 69, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), true },
                    { 70, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), true },
                    { 71, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), true },
                    { 72, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), true },
                    { 73, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), true },
                    { 74, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), false },
                    { 75, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), true },
                    { 76, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), false },
                    { 77, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), true },
                    { 78, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), false },
                    { 79, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), true },
                    { 80, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), false },
                    { 81, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), true },
                    { 82, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), false },
                    { 83, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), true },
                    { 84, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), true },
                    { 85, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), false },
                    { 86, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), false },
                    { 87, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), true },
                    { 88, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), false },
                    { 89, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), true },
                    { 90, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), true },
                    { 91, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), true },
                    { 92, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), false },
                    { 93, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), true },
                    { 94, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), false },
                    { 95, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), true },
                    { 96, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), false },
                    { 97, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), true },
                    { 98, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), true },
                    { 99, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), false },
                    { 100, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 101, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), true },
                    { 102, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), false },
                    { 103, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), false },
                    { 104, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), true },
                    { 105, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), false },
                    { 106, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), true },
                    { 107, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), false },
                    { 108, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), true },
                    { 109, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), true },
                    { 110, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), false },
                    { 111, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), true },
                    { 112, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), true },
                    { 113, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), true },
                    { 114, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), true },
                    { 115, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), false },
                    { 116, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), false },
                    { 117, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), false },
                    { 118, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), false },
                    { 119, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), true },
                    { 120, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), true },
                    { 121, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), false },
                    { 122, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), false },
                    { 123, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), true },
                    { 124, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), false },
                    { 125, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), false },
                    { 126, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), false },
                    { 127, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), false },
                    { 128, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), true },
                    { 129, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), true },
                    { 130, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), true },
                    { 131, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), false },
                    { 132, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), true },
                    { 133, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), true },
                    { 134, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), false },
                    { 135, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), true },
                    { 136, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), true },
                    { 137, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), true },
                    { 138, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), true },
                    { 139, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), true },
                    { 140, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), false },
                    { 141, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), true },
                    { 142, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 143, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), false },
                    { 144, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), false },
                    { 145, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), false },
                    { 146, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), true },
                    { 147, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), true },
                    { 148, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), true },
                    { 149, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), false },
                    { 150, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), true },
                    { 151, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), false },
                    { 152, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), false },
                    { 153, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), true },
                    { 154, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), true },
                    { 155, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), false },
                    { 156, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), false },
                    { 157, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), true },
                    { 158, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), true },
                    { 159, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), true },
                    { 160, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), false },
                    { 161, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), true },
                    { 162, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), false },
                    { 163, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), true },
                    { 164, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), false },
                    { 165, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), true },
                    { 166, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), true },
                    { 167, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), true },
                    { 168, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), false },
                    { 169, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), false },
                    { 170, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), false },
                    { 171, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), true },
                    { 172, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), false },
                    { 173, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), true },
                    { 174, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), false },
                    { 175, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), false },
                    { 176, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), false },
                    { 177, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), false },
                    { 178, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), true },
                    { 179, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), false },
                    { 180, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), true },
                    { 181, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), false },
                    { 182, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), false },
                    { 183, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), true },
                    { 184, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 185, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), true },
                    { 186, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), true },
                    { 187, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), true },
                    { 188, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), false },
                    { 189, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), false },
                    { 190, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), false },
                    { 191, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), true },
                    { 192, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), true },
                    { 193, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), false },
                    { 194, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), true },
                    { 195, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), false },
                    { 196, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), false },
                    { 197, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), false },
                    { 198, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), true },
                    { 199, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), true },
                    { 200, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), false },
                    { 201, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), false },
                    { 202, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), true },
                    { 203, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), false },
                    { 204, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), true },
                    { 205, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), true },
                    { 206, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), true },
                    { 207, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), false },
                    { 208, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("de92104f-7077-4376-9058-2cccd493d364"), true },
                    { 209, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), true },
                    { 210, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), false },
                    { 211, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), false },
                    { 212, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), false },
                    { 213, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), true },
                    { 214, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), false },
                    { 215, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), false },
                    { 216, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), true },
                    { 217, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), true },
                    { 218, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"), true },
                    { 219, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), true },
                    { 220, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), true },
                    { 221, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), false },
                    { 222, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"), false },
                    { 223, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), false },
                    { 224, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), false },
                    { 225, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), true },
                    { 226, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 227, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), true },
                    { 228, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), true },
                    { 229, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), true },
                    { 230, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("852129c5-792c-4c75-a148-9d065dc70834"), true },
                    { 231, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), true },
                    { 232, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), true },
                    { 233, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), true },
                    { 234, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), false },
                    { 235, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), true },
                    { 236, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"), true },
                    { 237, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), false },
                    { 238, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), false },
                    { 239, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), true },
                    { 240, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), false },
                    { 241, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), true },
                    { 242, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), true },
                    { 243, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), true },
                    { 244, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), false },
                    { 245, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), false },
                    { 246, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), true },
                    { 247, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), false },
                    { 248, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), false },
                    { 249, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), true },
                    { 250, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), false },
                    { 251, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), false },
                    { 252, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), true },
                    { 253, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), false },
                    { 254, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), true },
                    { 255, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), false },
                    { 256, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), false },
                    { 257, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), true },
                    { 258, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), true },
                    { 259, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), false },
                    { 260, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), false },
                    { 261, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), false },
                    { 262, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), false },
                    { 263, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), true },
                    { 264, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), false },
                    { 265, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("de92104f-7077-4376-9058-2cccd493d364"), false },
                    { 266, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), false },
                    { 267, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), true },
                    { 268, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 269, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"), true },
                    { 270, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b185edf3-8843-47eb-8195-a5682d26903b"), true },
                    { 271, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), true },
                    { 272, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), false },
                    { 273, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), false },
                    { 274, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), true },
                    { 275, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), true },
                    { 276, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), true },
                    { 277, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), false },
                    { 278, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), false },
                    { 279, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), false },
                    { 280, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), true },
                    { 281, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), true },
                    { 282, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("852129c5-792c-4c75-a148-9d065dc70834"), false },
                    { 283, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), false },
                    { 284, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), true },
                    { 285, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), true },
                    { 286, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), true },
                    { 287, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), false },
                    { 288, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), true },
                    { 289, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), true },
                    { 290, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), true },
                    { 291, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), true },
                    { 292, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), true },
                    { 293, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), false },
                    { 294, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"), false },
                    { 295, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), true },
                    { 296, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), false },
                    { 297, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), true },
                    { 298, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"), true },
                    { 299, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), false },
                    { 300, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), false },
                    { 301, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), true },
                    { 302, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"), true },
                    { 303, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), true },
                    { 304, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), false },
                    { 305, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), true },
                    { 306, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), true },
                    { 307, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), true },
                    { 308, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), true },
                    { 309, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("852129c5-792c-4c75-a148-9d065dc70834"), true },
                    { 310, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 311, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), true },
                    { 312, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), false },
                    { 313, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), false },
                    { 314, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), true },
                    { 315, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"), true },
                    { 316, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), true },
                    { 317, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"), false },
                    { 318, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), true },
                    { 319, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), false },
                    { 320, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), false },
                    { 321, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), false },
                    { 322, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), false },
                    { 323, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"), false },
                    { 324, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), false },
                    { 325, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), false },
                    { 326, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), true },
                    { 327, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), false },
                    { 328, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), true },
                    { 329, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), false },
                    { 330, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), false },
                    { 331, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), true },
                    { 332, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b5afa487-ec89-4a8f-8e95-823450827624"), false },
                    { 333, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), true },
                    { 334, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), false },
                    { 335, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), false },
                    { 336, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), true },
                    { 337, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), false },
                    { 338, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"), false },
                    { 339, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"), false },
                    { 340, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"), true },
                    { 341, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), false },
                    { 342, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), true },
                    { 343, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), false },
                    { 344, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"), false },
                    { 345, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), true },
                    { 346, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"), false },
                    { 347, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), false },
                    { 348, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), true },
                    { 349, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c6b3521d-0cae-47e9-b37f-987854008985"), true },
                    { 350, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"), false },
                    { 351, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), true },
                    { 352, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 353, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), true },
                    { 354, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), false },
                    { 355, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), true },
                    { 356, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), true },
                    { 357, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), false },
                    { 358, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), false },
                    { 359, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"), false },
                    { 360, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"), false },
                    { 361, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"), true },
                    { 362, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), false },
                    { 363, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"), false },
                    { 364, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), true },
                    { 365, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), true },
                    { 366, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), true },
                    { 367, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"), true },
                    { 368, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"), true },
                    { 369, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"), true },
                    { 370, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), false },
                    { 371, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("852129c5-792c-4c75-a148-9d065dc70834"), true },
                    { 372, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), false },
                    { 373, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), true },
                    { 374, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), true },
                    { 375, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"), false },
                    { 376, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), false },
                    { 377, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), true },
                    { 378, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), true },
                    { 379, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), false },
                    { 380, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), true },
                    { 381, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), false },
                    { 382, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), false },
                    { 383, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), false },
                    { 384, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), true },
                    { 385, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"), false },
                    { 386, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"), true },
                    { 387, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"), true },
                    { 388, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), true },
                    { 389, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), false },
                    { 390, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), false },
                    { 391, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), true },
                    { 392, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"), true },
                    { 393, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), false },
                    { 394, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 395, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"), false },
                    { 396, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"), false },
                    { 397, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), true },
                    { 398, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), true },
                    { 399, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), false },
                    { 400, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"), false },
                    { 401, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), false },
                    { 402, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), true },
                    { 403, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"), true },
                    { 404, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), true },
                    { 405, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), true },
                    { 406, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), true },
                    { 407, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), true },
                    { 408, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), true },
                    { 409, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"), true },
                    { 410, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"), false },
                    { 411, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), true },
                    { 412, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"), true },
                    { 413, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), false },
                    { 414, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"), true },
                    { 415, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"), true },
                    { 416, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), false },
                    { 417, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), false },
                    { 418, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), true },
                    { 419, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"), true },
                    { 420, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), true },
                    { 421, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("de92104f-7077-4376-9058-2cccd493d364"), true },
                    { 422, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"), false },
                    { 423, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"), false },
                    { 424, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), false },
                    { 425, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"), false },
                    { 426, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"), true },
                    { 427, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"), false },
                    { 428, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"), true },
                    { 429, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), true },
                    { 430, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), false },
                    { 431, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"), true },
                    { 432, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"), false },
                    { 433, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"), true },
                    { 434, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"), false },
                    { 435, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), false },
                    { 436, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90ec958f-ab51-42fa-b605-03c76823d423"), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 437, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"), true },
                    { 438, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), true },
                    { 439, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), true },
                    { 440, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), true },
                    { 441, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), false },
                    { 442, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), false },
                    { 443, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"), false },
                    { 444, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), false },
                    { 445, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), true },
                    { 446, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), false },
                    { 447, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), true },
                    { 448, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"), true },
                    { 449, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"), true },
                    { 450, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c71a913c-b7da-4704-b823-5738d9b13360"), true },
                    { 451, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"), true },
                    { 452, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"), true },
                    { 453, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"), true },
                    { 454, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), true },
                    { 455, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"), true },
                    { 456, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), true },
                    { 457, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("de92104f-7077-4376-9058-2cccd493d364"), false },
                    { 458, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"), false },
                    { 459, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"), false },
                    { 460, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), false },
                    { 461, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"), false },
                    { 462, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"), true },
                    { 463, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"), true },
                    { 464, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"), true },
                    { 465, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"), true },
                    { 466, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"), true },
                    { 467, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"), false },
                    { 468, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"), true },
                    { 469, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"), true },
                    { 470, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), true },
                    { 471, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"), true },
                    { 472, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"), false },
                    { 473, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"), false },
                    { 474, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"), true },
                    { 475, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"), false },
                    { 476, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("de92104f-7077-4376-9058-2cccd493d364"), false },
                    { 477, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"), true },
                    { 478, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"), true }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "FK_UserUUID", "Present" },
                values: new object[,]
                {
                    { 479, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"), true },
                    { 480, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"), true },
                    { 481, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"), true },
                    { 482, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"), false },
                    { 483, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"), false },
                    { 484, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"), false },
                    { 485, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fec5c35b-3065-4471-9a85-a6c685419699"), true },
                    { 486, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), true },
                    { 487, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), false },
                    { 488, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), false },
                    { 489, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"), false },
                    { 490, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), false },
                    { 491, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"), true },
                    { 492, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"), true },
                    { 493, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"), false },
                    { 494, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"), true },
                    { 495, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), true },
                    { 496, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"), false },
                    { 497, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("833d5312-27fb-434c-82cd-24978c1567e8"), false },
                    { 498, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"), false },
                    { 499, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"), false },
                    { 500, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"), false }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 5, new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0") },
                    { 2, 5, new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b") },
                    { 3, 7, new Guid("de92104f-7077-4376-9058-2cccd493d364") },
                    { 4, 8, new Guid("59f3113f-067d-4253-817c-cca5f39d4c68") },
                    { 5, 2, new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf") },
                    { 6, 6, new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa") },
                    { 7, 8, new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4") },
                    { 8, 7, new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb") },
                    { 9, 5, new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3") },
                    { 10, 9, new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683") },
                    { 11, 1, new Guid("c71a913c-b7da-4704-b823-5738d9b13360") },
                    { 12, 1, new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb") },
                    { 13, 2, new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c") },
                    { 14, 9, new Guid("afda9358-44f7-4d01-9d32-61a0911e1359") },
                    { 15, 9, new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14") },
                    { 16, 2, new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a") },
                    { 17, 8, new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6") },
                    { 18, 1, new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab") },
                    { 19, 5, new Guid("4bf5aade-d6d3-4809-9aad-262951136b03") },
                    { 20, 9, new Guid("90ec958f-ab51-42fa-b605-03c76823d423") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 21, 5, new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695") },
                    { 22, 8, new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7") },
                    { 23, 1, new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7") },
                    { 24, 5, new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5") },
                    { 25, 2, new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29") },
                    { 26, 2, new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861") },
                    { 27, 2, new Guid("b615efa7-85d5-4080-a67d-c835b318cabd") },
                    { 28, 3, new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a") },
                    { 29, 7, new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583") },
                    { 30, 2, new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742") },
                    { 31, 4, new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2") },
                    { 32, 4, new Guid("b185edf3-8843-47eb-8195-a5682d26903b") },
                    { 33, 6, new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a") },
                    { 34, 3, new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53") },
                    { 35, 3, new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f") },
                    { 36, 4, new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3") },
                    { 37, 6, new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225") },
                    { 38, 3, new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344") },
                    { 39, 3, new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff") },
                    { 40, 6, new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9") },
                    { 41, 8, new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7") },
                    { 42, 2, new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec") },
                    { 43, 4, new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a") },
                    { 44, 7, new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28") },
                    { 45, 8, new Guid("fec5c35b-3065-4471-9a85-a6c685419699") },
                    { 46, 2, new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96") },
                    { 47, 2, new Guid("ef906afc-5d4d-406f-a229-465cd81fb912") },
                    { 48, 4, new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd") },
                    { 49, 3, new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169") },
                    { 50, 5, new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65") },
                    { 51, 8, new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b") },
                    { 52, 4, new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64") },
                    { 53, 4, new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19") },
                    { 54, 3, new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843") },
                    { 55, 3, new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1") },
                    { 56, 3, new Guid("90def0a1-3245-4347-8d1e-13706fea54ab") },
                    { 57, 9, new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0") },
                    { 58, 6, new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246") },
                    { 59, 3, new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f") },
                    { 60, 3, new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f") },
                    { 61, 9, new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e") },
                    { 62, 6, new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 63, 2, new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be") },
                    { 64, 9, new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97") },
                    { 65, 7, new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc") },
                    { 66, 3, new Guid("b5afa487-ec89-4a8f-8e95-823450827624") },
                    { 67, 9, new Guid("d783c986-f017-431f-9e87-9232c4cf82c5") },
                    { 68, 9, new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4") },
                    { 69, 5, new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b") },
                    { 70, 7, new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc") },
                    { 71, 2, new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c") },
                    { 72, 7, new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b") },
                    { 73, 1, new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62") },
                    { 74, 4, new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498") },
                    { 75, 4, new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6") },
                    { 76, 1, new Guid("3bda41f1-adcd-4532-b429-25df97b8173c") },
                    { 77, 3, new Guid("c6b3521d-0cae-47e9-b37f-987854008985") },
                    { 78, 7, new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83") },
                    { 79, 2, new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec") },
                    { 80, 7, new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73") },
                    { 81, 8, new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985") },
                    { 82, 6, new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735") },
                    { 83, 4, new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3") },
                    { 84, 5, new Guid("938656bf-4996-40f7-afd7-a597e81cb72c") },
                    { 85, 7, new Guid("f76988f7-6979-4841-ae3c-08483ac5d565") },
                    { 86, 4, new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7") },
                    { 87, 3, new Guid("2596312c-0fd0-470e-b07f-7aee274528d8") },
                    { 88, 9, new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4") },
                    { 89, 2, new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f") },
                    { 90, 9, new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc") },
                    { 91, 1, new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a") },
                    { 92, 4, new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b") },
                    { 93, 3, new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945") },
                    { 94, 5, new Guid("c676b487-22ba-4b1f-baea-7a5af402083e") },
                    { 95, 3, new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e") },
                    { 96, 8, new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2") },
                    { 97, 5, new Guid("852129c5-792c-4c75-a148-9d065dc70834") },
                    { 98, 3, new Guid("833d5312-27fb-434c-82cd-24978c1567e8") },
                    { 99, 7, new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d") },
                    { 100, 9, new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0") },
                    { 2, 2, new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b") },
                    { 3, 3, new Guid("de92104f-7077-4376-9058-2cccd493d364") },
                    { 4, 4, new Guid("59f3113f-067d-4253-817c-cca5f39d4c68") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 5, 5, new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf") },
                    { 6, 6, new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa") },
                    { 7, 7, new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4") },
                    { 8, 8, new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb") },
                    { 9, 9, new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3") },
                    { 10, 10, new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683") },
                    { 11, 11, new Guid("c71a913c-b7da-4704-b823-5738d9b13360") },
                    { 12, 12, new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb") },
                    { 13, 13, new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c") },
                    { 14, 14, new Guid("afda9358-44f7-4d01-9d32-61a0911e1359") },
                    { 15, 15, new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14") },
                    { 16, 16, new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a") },
                    { 17, 17, new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6") },
                    { 18, 18, new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab") },
                    { 19, 19, new Guid("4bf5aade-d6d3-4809-9aad-262951136b03") },
                    { 20, 20, new Guid("90ec958f-ab51-42fa-b605-03c76823d423") },
                    { 21, 21, new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695") },
                    { 22, 22, new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7") },
                    { 23, 23, new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7") },
                    { 24, 24, new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5") },
                    { 25, 25, new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29") },
                    { 26, 26, new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861") },
                    { 27, 27, new Guid("b615efa7-85d5-4080-a67d-c835b318cabd") },
                    { 28, 28, new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a") },
                    { 29, 29, new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583") },
                    { 30, 30, new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742") },
                    { 31, 31, new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2") },
                    { 32, 32, new Guid("b185edf3-8843-47eb-8195-a5682d26903b") },
                    { 33, 33, new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a") },
                    { 34, 34, new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53") },
                    { 35, 35, new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f") },
                    { 36, 36, new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3") },
                    { 37, 37, new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225") },
                    { 38, 38, new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344") },
                    { 39, 39, new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff") },
                    { 40, 40, new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9") },
                    { 41, 41, new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7") },
                    { 42, 42, new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec") },
                    { 43, 43, new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a") },
                    { 44, 44, new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28") },
                    { 45, 45, new Guid("fec5c35b-3065-4471-9a85-a6c685419699") },
                    { 46, 46, new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 47, 47, new Guid("ef906afc-5d4d-406f-a229-465cd81fb912") },
                    { 48, 48, new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd") },
                    { 49, 49, new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169") },
                    { 50, 50, new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65") },
                    { 51, 51, new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b") },
                    { 52, 52, new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64") },
                    { 53, 53, new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19") },
                    { 54, 54, new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843") },
                    { 55, 55, new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1") },
                    { 56, 56, new Guid("90def0a1-3245-4347-8d1e-13706fea54ab") },
                    { 57, 57, new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0") },
                    { 58, 58, new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246") },
                    { 59, 59, new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f") },
                    { 60, 60, new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f") },
                    { 61, 61, new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e") },
                    { 62, 62, new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2") },
                    { 63, 63, new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be") },
                    { 64, 64, new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97") },
                    { 65, 65, new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc") },
                    { 66, 66, new Guid("b5afa487-ec89-4a8f-8e95-823450827624") },
                    { 67, 67, new Guid("d783c986-f017-431f-9e87-9232c4cf82c5") },
                    { 68, 68, new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4") },
                    { 69, 69, new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b") },
                    { 70, 70, new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc") },
                    { 71, 71, new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c") },
                    { 72, 72, new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b") },
                    { 73, 73, new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62") },
                    { 74, 74, new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498") },
                    { 75, 75, new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6") },
                    { 76, 76, new Guid("3bda41f1-adcd-4532-b429-25df97b8173c") },
                    { 77, 77, new Guid("c6b3521d-0cae-47e9-b37f-987854008985") },
                    { 78, 78, new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83") },
                    { 79, 79, new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec") },
                    { 80, 80, new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73") },
                    { 81, 81, new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985") },
                    { 82, 82, new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735") },
                    { 83, 83, new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3") },
                    { 84, 84, new Guid("938656bf-4996-40f7-afd7-a597e81cb72c") },
                    { 85, 85, new Guid("f76988f7-6979-4841-ae3c-08483ac5d565") },
                    { 86, 86, new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7") },
                    { 87, 87, new Guid("2596312c-0fd0-470e-b07f-7aee274528d8") },
                    { 88, 88, new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 89, 89, new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f") },
                    { 90, 90, new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc") },
                    { 91, 91, new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a") },
                    { 92, 92, new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b") },
                    { 93, 93, new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945") },
                    { 94, 94, new Guid("c676b487-22ba-4b1f-baea-7a5af402083e") },
                    { 95, 95, new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e") },
                    { 96, 96, new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2") },
                    { 97, 97, new Guid("852129c5-792c-4c75-a148-9d065dc70834") },
                    { 98, 98, new Guid("833d5312-27fb-434c-82cd-24978c1567e8") },
                    { 99, 99, new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d") },
                    { 100, 100, new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0") },
                    { 2, 1, new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b") },
                    { 3, 1, new Guid("de92104f-7077-4376-9058-2cccd493d364") },
                    { 4, 1, new Guid("59f3113f-067d-4253-817c-cca5f39d4c68") },
                    { 5, 1, new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf") },
                    { 6, 1, new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa") },
                    { 7, 1, new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4") },
                    { 8, 1, new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb") },
                    { 9, 1, new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3") },
                    { 10, 1, new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683") },
                    { 11, 1, new Guid("c71a913c-b7da-4704-b823-5738d9b13360") },
                    { 12, 1, new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb") },
                    { 13, 1, new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c") },
                    { 14, 1, new Guid("afda9358-44f7-4d01-9d32-61a0911e1359") },
                    { 15, 1, new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14") },
                    { 16, 1, new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a") },
                    { 17, 1, new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6") },
                    { 18, 1, new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab") },
                    { 19, 1, new Guid("4bf5aade-d6d3-4809-9aad-262951136b03") },
                    { 20, 1, new Guid("90ec958f-ab51-42fa-b605-03c76823d423") },
                    { 21, 1, new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695") },
                    { 22, 1, new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7") },
                    { 23, 1, new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7") },
                    { 24, 1, new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5") },
                    { 25, 1, new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29") },
                    { 26, 1, new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861") },
                    { 27, 1, new Guid("b615efa7-85d5-4080-a67d-c835b318cabd") },
                    { 28, 1, new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a") },
                    { 29, 1, new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583") },
                    { 30, 1, new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 31, 1, new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2") },
                    { 32, 1, new Guid("b185edf3-8843-47eb-8195-a5682d26903b") },
                    { 33, 1, new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a") },
                    { 34, 1, new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53") },
                    { 35, 1, new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f") },
                    { 36, 1, new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3") },
                    { 37, 1, new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225") },
                    { 38, 1, new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344") },
                    { 39, 1, new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff") },
                    { 40, 1, new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9") },
                    { 41, 1, new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7") },
                    { 42, 1, new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec") },
                    { 43, 1, new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a") },
                    { 44, 1, new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28") },
                    { 45, 1, new Guid("fec5c35b-3065-4471-9a85-a6c685419699") },
                    { 46, 1, new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96") },
                    { 47, 1, new Guid("ef906afc-5d4d-406f-a229-465cd81fb912") },
                    { 48, 1, new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd") },
                    { 49, 1, new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169") },
                    { 50, 1, new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65") },
                    { 51, 1, new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b") },
                    { 52, 1, new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64") },
                    { 53, 1, new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19") },
                    { 54, 1, new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843") },
                    { 55, 1, new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1") },
                    { 56, 1, new Guid("90def0a1-3245-4347-8d1e-13706fea54ab") },
                    { 57, 1, new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0") },
                    { 58, 1, new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246") },
                    { 59, 1, new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f") },
                    { 60, 1, new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f") },
                    { 61, 1, new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e") },
                    { 62, 1, new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2") },
                    { 63, 1, new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be") },
                    { 64, 1, new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97") },
                    { 65, 1, new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc") },
                    { 66, 1, new Guid("b5afa487-ec89-4a8f-8e95-823450827624") },
                    { 67, 1, new Guid("d783c986-f017-431f-9e87-9232c4cf82c5") },
                    { 68, 1, new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4") },
                    { 69, 1, new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b") },
                    { 70, 1, new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc") },
                    { 71, 1, new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c") },
                    { 72, 1, new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 73, 1, new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62") },
                    { 74, 1, new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498") },
                    { 75, 1, new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6") },
                    { 76, 1, new Guid("3bda41f1-adcd-4532-b429-25df97b8173c") },
                    { 77, 1, new Guid("c6b3521d-0cae-47e9-b37f-987854008985") },
                    { 78, 1, new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83") },
                    { 79, 1, new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec") },
                    { 80, 1, new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73") },
                    { 81, 1, new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985") },
                    { 82, 1, new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735") },
                    { 83, 1, new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3") },
                    { 84, 1, new Guid("938656bf-4996-40f7-afd7-a597e81cb72c") },
                    { 85, 1, new Guid("f76988f7-6979-4841-ae3c-08483ac5d565") },
                    { 86, 1, new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7") },
                    { 87, 1, new Guid("2596312c-0fd0-470e-b07f-7aee274528d8") },
                    { 88, 1, new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4") },
                    { 89, 1, new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f") },
                    { 90, 1, new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc") },
                    { 91, 1, new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a") },
                    { 92, 1, new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b") },
                    { 93, 1, new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945") },
                    { 94, 1, new Guid("c676b487-22ba-4b1f-baea-7a5af402083e") },
                    { 95, 1, new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e") },
                    { 96, 1, new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2") },
                    { 97, 1, new Guid("852129c5-792c-4c75-a148-9d065dc70834") },
                    { 98, 1, new Guid("833d5312-27fb-434c-82cd-24978c1567e8") },
                    { 99, 1, new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d") },
                    { 100, 1, new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f") },
                    { 1000, 5, new Guid("4bea0974-48a9-4c81-9a71-859448886b94") }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 1, 1, 1, 14 },
                    { 2, 1, 2, 8 },
                    { 3, 1, 3, 13 },
                    { 4, 1, 4, 16 },
                    { 5, 1, 5, 13 },
                    { 6, 1, 6, 10 },
                    { 7, 1, 7, 15 },
                    { 8, 1, 8, 18 },
                    { 9, 1, 9, 4 },
                    { 10, 1, 10, 4 },
                    { 11, 1, 11, 17 },
                    { 12, 1, 12, 11 },
                    { 13, 1, 13, 3 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 14, 1, 14, 4 },
                    { 15, 1, 15, 8 },
                    { 16, 1, 16, 15 },
                    { 17, 1, 17, 9 },
                    { 18, 1, 18, 14 },
                    { 19, 1, 19, 4 },
                    { 20, 1, 20, 16 },
                    { 21, 1, 21, 16 },
                    { 22, 1, 22, 9 },
                    { 23, 1, 23, 2 },
                    { 24, 1, 24, 8 },
                    { 25, 1, 25, 14 },
                    { 26, 1, 26, 15 },
                    { 27, 1, 27, 8 },
                    { 28, 1, 28, 7 },
                    { 29, 1, 29, 5 },
                    { 30, 1, 30, 15 },
                    { 31, 1, 31, 17 },
                    { 32, 1, 32, 12 },
                    { 33, 1, 33, 10 },
                    { 34, 1, 34, 13 },
                    { 35, 1, 35, 15 },
                    { 36, 1, 36, 16 },
                    { 37, 1, 37, 1 },
                    { 38, 1, 38, 12 },
                    { 39, 1, 39, 17 },
                    { 40, 2, 40, 10 },
                    { 41, 2, 41, 18 },
                    { 42, 2, 42, 15 },
                    { 43, 2, 43, 17 },
                    { 44, 2, 44, 6 },
                    { 45, 2, 45, 16 },
                    { 46, 2, 46, 7 },
                    { 47, 2, 47, 8 },
                    { 48, 2, 48, 4 },
                    { 49, 2, 49, 17 },
                    { 50, 2, 50, 2 },
                    { 51, 2, 51, 11 },
                    { 52, 2, 52, 13 },
                    { 53, 2, 53, 3 },
                    { 54, 2, 54, 16 },
                    { 55, 2, 55, 7 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 56, 2, 56, 2 },
                    { 57, 2, 57, 10 },
                    { 58, 2, 58, 18 },
                    { 59, 2, 59, 8 },
                    { 60, 2, 60, 13 },
                    { 61, 2, 61, 11 },
                    { 62, 2, 62, 12 },
                    { 63, 2, 63, 13 },
                    { 64, 2, 64, 12 },
                    { 65, 2, 65, 11 },
                    { 66, 2, 66, 9 },
                    { 67, 2, 67, 8 },
                    { 68, 2, 68, 5 },
                    { 69, 2, 69, 12 },
                    { 70, 2, 70, 17 },
                    { 71, 2, 71, 2 },
                    { 72, 2, 72, 1 },
                    { 73, 2, 73, 3 },
                    { 74, 2, 74, 10 },
                    { 75, 2, 75, 10 },
                    { 76, 2, 76, 5 },
                    { 77, 2, 77, 9 },
                    { 78, 2, 78, 3 },
                    { 79, 2, 79, 16 },
                    { 80, 3, 80, 17 },
                    { 81, 3, 81, 2 },
                    { 82, 3, 82, 14 },
                    { 83, 3, 83, 3 },
                    { 84, 3, 84, 2 },
                    { 85, 3, 85, 11 },
                    { 86, 3, 86, 9 },
                    { 87, 3, 87, 14 },
                    { 88, 3, 88, 1 },
                    { 89, 3, 89, 16 },
                    { 90, 3, 90, 2 },
                    { 91, 3, 91, 16 },
                    { 92, 3, 92, 9 },
                    { 93, 3, 93, 13 },
                    { 94, 3, 94, 4 },
                    { 95, 3, 95, 16 },
                    { 96, 3, 96, 18 },
                    { 97, 3, 97, 4 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 98, 3, 98, 18 },
                    { 99, 3, 99, 8 },
                    { 100, 3, 100, 5 },
                    { 101, 3, 101, 15 },
                    { 102, 3, 102, 1 },
                    { 103, 3, 103, 14 },
                    { 104, 3, 104, 10 },
                    { 105, 3, 105, 18 },
                    { 106, 3, 106, 16 },
                    { 107, 3, 107, 16 },
                    { 108, 3, 108, 9 },
                    { 109, 3, 109, 6 },
                    { 110, 3, 110, 12 },
                    { 111, 3, 111, 12 },
                    { 112, 3, 112, 6 },
                    { 113, 3, 113, 12 },
                    { 114, 3, 114, 11 },
                    { 115, 3, 115, 12 },
                    { 116, 3, 116, 7 },
                    { 117, 3, 117, 11 },
                    { 118, 3, 118, 3 },
                    { 119, 3, 119, 7 },
                    { 120, 4, 120, 6 },
                    { 121, 4, 121, 8 },
                    { 122, 4, 122, 13 },
                    { 123, 4, 123, 6 },
                    { 124, 4, 124, 2 },
                    { 125, 4, 125, 15 },
                    { 126, 4, 126, 10 },
                    { 127, 4, 127, 5 },
                    { 128, 4, 128, 2 },
                    { 129, 4, 129, 12 },
                    { 130, 4, 130, 3 },
                    { 131, 4, 131, 8 },
                    { 132, 4, 132, 2 },
                    { 133, 4, 133, 9 },
                    { 134, 4, 134, 12 },
                    { 135, 4, 135, 1 },
                    { 136, 4, 136, 17 },
                    { 137, 4, 137, 2 },
                    { 138, 4, 138, 9 },
                    { 139, 4, 139, 9 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 140, 4, 140, 5 },
                    { 141, 4, 141, 6 },
                    { 142, 4, 142, 3 },
                    { 143, 4, 143, 17 },
                    { 144, 4, 144, 7 },
                    { 145, 4, 145, 14 },
                    { 146, 4, 146, 15 },
                    { 147, 4, 147, 14 },
                    { 148, 4, 148, 9 },
                    { 149, 4, 149, 7 },
                    { 150, 4, 150, 16 },
                    { 151, 4, 151, 13 },
                    { 152, 4, 152, 9 },
                    { 153, 4, 153, 18 },
                    { 154, 4, 154, 16 },
                    { 155, 4, 155, 9 },
                    { 156, 4, 156, 17 },
                    { 157, 4, 157, 4 },
                    { 158, 4, 158, 3 },
                    { 159, 4, 159, 11 },
                    { 160, 5, 160, 6 },
                    { 161, 5, 161, 13 },
                    { 162, 5, 162, 13 },
                    { 163, 5, 163, 15 },
                    { 164, 5, 164, 9 },
                    { 165, 5, 165, 18 },
                    { 166, 5, 166, 15 },
                    { 167, 5, 167, 12 },
                    { 168, 5, 168, 6 },
                    { 169, 5, 169, 18 },
                    { 170, 5, 170, 17 },
                    { 171, 5, 171, 5 },
                    { 172, 5, 172, 6 },
                    { 173, 5, 173, 9 },
                    { 174, 5, 174, 15 },
                    { 175, 5, 175, 14 },
                    { 176, 5, 176, 5 },
                    { 177, 5, 177, 12 },
                    { 178, 5, 178, 16 },
                    { 179, 5, 179, 11 },
                    { 180, 5, 180, 10 },
                    { 181, 5, 181, 5 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 182, 5, 182, 16 },
                    { 183, 5, 183, 13 },
                    { 184, 5, 184, 14 },
                    { 185, 5, 185, 7 },
                    { 186, 5, 186, 8 },
                    { 187, 5, 187, 8 },
                    { 188, 5, 188, 11 },
                    { 189, 5, 189, 9 },
                    { 190, 5, 190, 5 },
                    { 191, 5, 191, 16 },
                    { 192, 5, 192, 3 },
                    { 193, 5, 193, 9 },
                    { 194, 5, 194, 1 },
                    { 195, 5, 195, 8 },
                    { 196, 5, 196, 11 },
                    { 197, 5, 197, 2 },
                    { 198, 5, 198, 3 },
                    { 199, 5, 199, 3 },
                    { 200, 6, 200, 12 },
                    { 201, 6, 201, 3 },
                    { 202, 6, 202, 14 },
                    { 203, 6, 203, 11 },
                    { 204, 6, 204, 3 },
                    { 205, 6, 205, 7 },
                    { 206, 6, 206, 12 },
                    { 207, 6, 207, 16 },
                    { 208, 6, 208, 11 },
                    { 209, 6, 209, 9 },
                    { 210, 6, 210, 9 },
                    { 211, 6, 211, 5 },
                    { 212, 6, 212, 2 },
                    { 213, 6, 213, 2 },
                    { 214, 6, 214, 6 },
                    { 215, 6, 215, 13 },
                    { 216, 6, 216, 3 },
                    { 217, 6, 217, 8 },
                    { 218, 6, 218, 13 },
                    { 219, 6, 219, 12 },
                    { 220, 6, 220, 11 },
                    { 221, 6, 221, 9 },
                    { 222, 6, 222, 5 },
                    { 223, 6, 223, 8 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 224, 6, 224, 18 },
                    { 225, 6, 225, 5 },
                    { 226, 6, 226, 2 },
                    { 227, 6, 227, 6 },
                    { 228, 6, 228, 3 },
                    { 229, 6, 229, 15 },
                    { 230, 6, 230, 17 },
                    { 231, 6, 231, 4 },
                    { 232, 6, 232, 10 },
                    { 233, 6, 233, 14 },
                    { 234, 6, 234, 12 },
                    { 235, 6, 235, 17 },
                    { 236, 6, 236, 4 },
                    { 237, 6, 237, 2 },
                    { 238, 6, 238, 12 },
                    { 239, 6, 239, 16 },
                    { 240, 7, 240, 17 },
                    { 241, 7, 241, 14 },
                    { 242, 7, 242, 17 },
                    { 243, 7, 243, 15 },
                    { 244, 7, 244, 3 },
                    { 245, 7, 245, 7 },
                    { 246, 7, 246, 1 },
                    { 247, 7, 247, 14 },
                    { 248, 7, 248, 6 },
                    { 249, 7, 249, 16 },
                    { 250, 7, 250, 8 },
                    { 251, 7, 251, 4 },
                    { 252, 7, 252, 8 },
                    { 253, 7, 253, 18 },
                    { 254, 7, 254, 13 },
                    { 255, 7, 255, 7 },
                    { 256, 7, 256, 7 },
                    { 257, 7, 257, 4 },
                    { 258, 7, 258, 13 },
                    { 259, 7, 259, 15 },
                    { 260, 7, 260, 14 },
                    { 261, 7, 261, 3 },
                    { 262, 7, 262, 18 },
                    { 263, 7, 263, 6 },
                    { 264, 7, 264, 16 },
                    { 265, 7, 265, 9 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 266, 7, 266, 6 },
                    { 267, 7, 267, 2 },
                    { 268, 7, 268, 10 },
                    { 269, 7, 269, 4 },
                    { 270, 7, 270, 8 },
                    { 271, 7, 271, 1 },
                    { 272, 7, 272, 10 },
                    { 273, 7, 273, 6 },
                    { 274, 7, 274, 16 },
                    { 275, 7, 275, 10 },
                    { 276, 7, 276, 11 },
                    { 277, 7, 277, 10 },
                    { 278, 7, 278, 13 },
                    { 279, 7, 279, 14 },
                    { 280, 8, 280, 6 },
                    { 281, 8, 281, 15 },
                    { 282, 8, 282, 1 },
                    { 283, 8, 283, 2 },
                    { 284, 8, 284, 7 },
                    { 285, 8, 285, 5 },
                    { 286, 8, 286, 13 },
                    { 287, 8, 287, 3 },
                    { 288, 8, 288, 11 },
                    { 289, 8, 289, 16 },
                    { 290, 8, 290, 9 },
                    { 291, 8, 291, 11 },
                    { 292, 8, 292, 3 },
                    { 293, 8, 293, 8 },
                    { 294, 8, 294, 18 },
                    { 295, 8, 295, 15 },
                    { 296, 8, 296, 7 },
                    { 297, 8, 297, 11 },
                    { 298, 8, 298, 11 },
                    { 299, 8, 299, 17 },
                    { 300, 8, 300, 17 },
                    { 301, 8, 301, 9 },
                    { 302, 8, 302, 17 },
                    { 303, 8, 303, 18 },
                    { 304, 8, 304, 3 },
                    { 305, 8, 305, 11 },
                    { 306, 8, 306, 9 },
                    { 307, 8, 307, 18 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 308, 8, 308, 5 },
                    { 309, 8, 309, 9 },
                    { 310, 8, 310, 3 },
                    { 311, 8, 311, 13 },
                    { 312, 8, 312, 11 },
                    { 313, 8, 313, 12 },
                    { 314, 8, 314, 18 },
                    { 315, 8, 315, 17 },
                    { 316, 8, 316, 10 },
                    { 317, 8, 317, 7 },
                    { 318, 8, 318, 16 },
                    { 319, 8, 319, 1 },
                    { 320, 9, 320, 18 },
                    { 321, 9, 321, 17 },
                    { 322, 9, 322, 11 },
                    { 323, 9, 323, 15 },
                    { 324, 9, 324, 17 },
                    { 325, 9, 325, 14 },
                    { 326, 9, 326, 1 },
                    { 327, 9, 327, 2 },
                    { 328, 9, 328, 7 },
                    { 329, 9, 329, 12 },
                    { 330, 9, 330, 11 },
                    { 331, 9, 331, 2 },
                    { 332, 9, 332, 13 },
                    { 333, 9, 333, 18 },
                    { 334, 9, 334, 5 },
                    { 335, 9, 335, 17 },
                    { 336, 9, 336, 11 },
                    { 337, 9, 337, 4 },
                    { 338, 9, 338, 11 },
                    { 339, 9, 339, 15 },
                    { 340, 9, 340, 1 },
                    { 341, 9, 341, 16 },
                    { 342, 9, 342, 16 },
                    { 343, 9, 343, 18 },
                    { 344, 9, 344, 6 },
                    { 345, 9, 345, 7 },
                    { 346, 9, 346, 3 },
                    { 347, 9, 347, 15 },
                    { 348, 9, 348, 9 },
                    { 349, 9, 349, 15 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 350, 9, 350, 13 },
                    { 351, 9, 351, 10 },
                    { 352, 9, 352, 13 },
                    { 353, 9, 353, 6 },
                    { 354, 9, 354, 6 },
                    { 355, 9, 355, 17 },
                    { 356, 9, 356, 18 },
                    { 357, 9, 357, 15 },
                    { 358, 9, 358, 2 },
                    { 359, 9, 359, 2 },
                    { 360, 10, 360, 11 },
                    { 361, 10, 361, 12 },
                    { 362, 10, 362, 16 },
                    { 363, 10, 363, 18 },
                    { 364, 10, 364, 17 },
                    { 365, 10, 365, 1 },
                    { 366, 10, 366, 5 },
                    { 367, 10, 367, 10 },
                    { 368, 10, 368, 12 },
                    { 369, 10, 369, 14 },
                    { 370, 10, 370, 13 },
                    { 371, 10, 371, 18 },
                    { 372, 10, 372, 10 },
                    { 373, 10, 373, 12 },
                    { 374, 10, 374, 12 },
                    { 375, 10, 375, 13 },
                    { 376, 10, 376, 3 },
                    { 377, 10, 377, 6 },
                    { 378, 10, 378, 2 },
                    { 379, 10, 379, 10 },
                    { 380, 10, 380, 3 },
                    { 381, 10, 381, 11 },
                    { 382, 10, 382, 1 },
                    { 383, 10, 383, 9 },
                    { 384, 10, 384, 1 },
                    { 385, 10, 385, 3 },
                    { 386, 10, 386, 17 },
                    { 387, 10, 387, 18 },
                    { 388, 10, 388, 5 },
                    { 389, 10, 389, 15 },
                    { 390, 10, 390, 9 },
                    { 391, 10, 391, 16 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_Class", "FK_LessonID", "FK_TeacherID" },
                values: new object[,]
                {
                    { 392, 10, 392, 9 },
                    { 393, 10, 393, 16 },
                    { 394, 10, 394, 8 },
                    { 395, 10, 395, 7 },
                    { 396, 10, 396, 1 },
                    { 397, 10, 397, 8 },
                    { 398, 10, 398, 14 },
                    { 399, 10, 399, 3 },
                    { 400, 10, 400, 5 }
                });

            migrationBuilder.InsertData(
                table: "LessonApprove",
                columns: new[] { "LessonApproveID", "FK_ApproveID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 11, 1 },
                    { 2, 8, 2 },
                    { 3, 3, 3 },
                    { 4, 19, 4 },
                    { 5, 20, 5 },
                    { 6, 29, 6 },
                    { 7, 24, 7 },
                    { 8, 26, 8 },
                    { 9, 14, 9 },
                    { 10, 21, 10 },
                    { 11, 5, 11 },
                    { 12, 9, 12 },
                    { 13, 25, 13 },
                    { 14, 2, 14 },
                    { 15, 6, 15 },
                    { 16, 27, 16 },
                    { 17, 30, 17 },
                    { 18, 22, 18 },
                    { 19, 12, 19 },
                    { 20, 18, 20 },
                    { 21, 1, 21 },
                    { 22, 13, 22 },
                    { 23, 15, 23 },
                    { 24, 4, 24 },
                    { 25, 16, 25 },
                    { 26, 17, 26 },
                    { 27, 7, 27 },
                    { 28, 28, 28 },
                    { 29, 10, 29 },
                    { 30, 23, 30 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 417, 1 },
                    { 2, 293, 2 },
                    { 3, 248, 3 },
                    { 4, 335, 4 },
                    { 5, 423, 5 },
                    { 6, 485, 6 },
                    { 7, 392, 7 },
                    { 8, 28, 8 },
                    { 9, 90, 9 },
                    { 10, 61, 10 },
                    { 11, 273, 11 },
                    { 12, 98, 12 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 13, 428, 13 },
                    { 14, 489, 14 },
                    { 15, 312, 15 },
                    { 16, 191, 16 },
                    { 17, 130, 17 },
                    { 18, 23, 18 },
                    { 19, 368, 19 },
                    { 20, 139, 20 },
                    { 21, 256, 21 },
                    { 22, 27, 22 },
                    { 23, 32, 23 },
                    { 24, 213, 24 },
                    { 25, 416, 25 },
                    { 26, 371, 26 },
                    { 27, 54, 27 },
                    { 28, 177, 28 },
                    { 29, 238, 29 },
                    { 30, 38, 30 },
                    { 31, 147, 31 },
                    { 32, 267, 32 },
                    { 33, 305, 33 },
                    { 34, 222, 34 },
                    { 35, 9, 35 },
                    { 36, 249, 36 },
                    { 37, 320, 37 },
                    { 38, 239, 38 },
                    { 39, 69, 39 },
                    { 40, 426, 40 },
                    { 41, 201, 41 },
                    { 42, 43, 42 },
                    { 43, 347, 43 },
                    { 44, 40, 44 },
                    { 45, 245, 45 },
                    { 46, 35, 46 },
                    { 47, 358, 47 },
                    { 48, 48, 48 },
                    { 49, 404, 49 },
                    { 50, 208, 50 },
                    { 51, 93, 51 },
                    { 52, 76, 52 },
                    { 53, 34, 53 },
                    { 54, 8, 54 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 55, 329, 55 },
                    { 56, 49, 56 },
                    { 57, 169, 57 },
                    { 58, 287, 58 },
                    { 59, 386, 59 },
                    { 60, 367, 60 },
                    { 61, 277, 61 },
                    { 62, 412, 62 },
                    { 63, 175, 63 },
                    { 64, 188, 64 },
                    { 65, 365, 65 },
                    { 66, 6, 66 },
                    { 67, 438, 67 },
                    { 68, 11, 68 },
                    { 69, 242, 69 },
                    { 70, 171, 70 },
                    { 71, 50, 71 },
                    { 72, 189, 72 },
                    { 73, 152, 73 },
                    { 74, 240, 74 },
                    { 75, 324, 75 },
                    { 76, 493, 76 },
                    { 77, 410, 77 },
                    { 78, 15, 78 },
                    { 79, 307, 79 },
                    { 80, 289, 80 },
                    { 81, 357, 81 },
                    { 82, 183, 82 },
                    { 83, 413, 83 },
                    { 84, 495, 84 },
                    { 85, 299, 85 },
                    { 86, 475, 86 },
                    { 87, 233, 87 },
                    { 88, 2, 88 },
                    { 89, 212, 89 },
                    { 90, 42, 90 },
                    { 91, 303, 91 },
                    { 92, 44, 92 },
                    { 93, 341, 93 },
                    { 94, 388, 94 },
                    { 95, 487, 95 },
                    { 96, 12, 96 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 97, 116, 97 },
                    { 98, 482, 98 },
                    { 99, 22, 99 },
                    { 100, 296, 100 },
                    { 101, 216, 101 },
                    { 102, 108, 102 },
                    { 103, 336, 103 },
                    { 104, 403, 104 },
                    { 105, 446, 105 },
                    { 106, 262, 106 },
                    { 107, 325, 107 },
                    { 108, 109, 108 },
                    { 109, 436, 109 },
                    { 110, 223, 110 },
                    { 111, 13, 111 },
                    { 112, 148, 112 },
                    { 113, 490, 113 },
                    { 114, 441, 114 },
                    { 115, 121, 115 },
                    { 116, 184, 116 },
                    { 117, 129, 117 },
                    { 118, 33, 118 },
                    { 119, 301, 119 },
                    { 120, 491, 120 },
                    { 121, 209, 121 },
                    { 122, 269, 122 },
                    { 123, 390, 123 },
                    { 124, 378, 124 },
                    { 125, 180, 125 },
                    { 126, 394, 126 },
                    { 127, 120, 127 },
                    { 128, 91, 128 },
                    { 129, 137, 129 },
                    { 130, 237, 130 },
                    { 131, 149, 131 },
                    { 132, 483, 132 },
                    { 133, 498, 133 },
                    { 134, 231, 134 },
                    { 135, 224, 135 },
                    { 136, 315, 136 },
                    { 137, 337, 137 },
                    { 138, 415, 138 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 139, 445, 139 },
                    { 140, 338, 140 },
                    { 141, 314, 141 },
                    { 142, 81, 142 },
                    { 143, 66, 143 },
                    { 144, 67, 144 },
                    { 145, 408, 145 },
                    { 146, 364, 146 },
                    { 147, 124, 147 },
                    { 148, 36, 148 },
                    { 149, 165, 149 },
                    { 150, 232, 150 },
                    { 151, 286, 151 },
                    { 152, 63, 152 },
                    { 153, 259, 153 },
                    { 154, 424, 154 },
                    { 155, 82, 155 },
                    { 156, 4, 156 },
                    { 157, 133, 157 },
                    { 158, 477, 158 },
                    { 159, 58, 159 },
                    { 160, 197, 160 },
                    { 161, 379, 161 },
                    { 162, 435, 162 },
                    { 163, 228, 163 },
                    { 164, 174, 164 },
                    { 165, 422, 165 },
                    { 166, 210, 166 },
                    { 167, 14, 167 },
                    { 168, 290, 168 },
                    { 169, 144, 169 },
                    { 170, 255, 170 },
                    { 171, 220, 171 },
                    { 172, 103, 172 },
                    { 173, 297, 173 },
                    { 174, 319, 174 },
                    { 175, 55, 175 },
                    { 176, 86, 176 },
                    { 177, 127, 177 },
                    { 178, 31, 178 },
                    { 179, 266, 179 },
                    { 180, 355, 180 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 181, 370, 181 },
                    { 182, 172, 182 },
                    { 183, 251, 183 },
                    { 184, 451, 184 },
                    { 185, 369, 185 },
                    { 186, 434, 186 },
                    { 187, 395, 187 },
                    { 188, 340, 188 },
                    { 189, 235, 189 },
                    { 190, 206, 190 },
                    { 191, 45, 191 },
                    { 192, 419, 192 },
                    { 193, 84, 193 },
                    { 194, 459, 194 },
                    { 195, 282, 195 },
                    { 196, 292, 196 },
                    { 197, 20, 197 },
                    { 198, 229, 198 },
                    { 199, 236, 199 },
                    { 200, 454, 200 },
                    { 201, 342, 201 },
                    { 202, 138, 202 },
                    { 203, 494, 203 },
                    { 204, 396, 204 },
                    { 205, 397, 205 },
                    { 206, 333, 206 },
                    { 207, 411, 207 },
                    { 208, 387, 208 },
                    { 209, 79, 209 },
                    { 210, 328, 210 },
                    { 211, 215, 211 },
                    { 212, 264, 212 },
                    { 213, 166, 213 },
                    { 214, 439, 214 },
                    { 215, 400, 215 },
                    { 216, 234, 216 },
                    { 217, 7, 217 },
                    { 218, 131, 218 },
                    { 219, 430, 219 },
                    { 220, 126, 220 },
                    { 221, 244, 221 },
                    { 222, 135, 222 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 223, 39, 223 },
                    { 224, 25, 224 },
                    { 225, 217, 225 },
                    { 226, 291, 226 },
                    { 227, 288, 227 },
                    { 228, 457, 228 },
                    { 229, 381, 229 },
                    { 230, 406, 230 },
                    { 231, 474, 231 },
                    { 232, 432, 232 },
                    { 233, 221, 233 },
                    { 234, 265, 234 },
                    { 235, 243, 235 },
                    { 236, 30, 236 },
                    { 237, 278, 237 },
                    { 238, 488, 238 },
                    { 239, 281, 239 },
                    { 240, 472, 240 },
                    { 241, 486, 241 },
                    { 242, 302, 242 },
                    { 243, 199, 243 },
                    { 244, 420, 244 },
                    { 245, 77, 245 },
                    { 246, 106, 246 },
                    { 247, 449, 247 },
                    { 248, 186, 248 },
                    { 249, 107, 249 },
                    { 250, 401, 250 },
                    { 251, 204, 251 },
                    { 252, 226, 252 },
                    { 253, 497, 253 },
                    { 254, 331, 254 },
                    { 255, 349, 255 },
                    { 256, 442, 256 },
                    { 257, 96, 257 },
                    { 258, 444, 258 },
                    { 259, 53, 259 },
                    { 260, 75, 260 },
                    { 261, 372, 261 },
                    { 262, 47, 262 },
                    { 263, 153, 263 },
                    { 264, 156, 264 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 265, 211, 265 },
                    { 266, 102, 266 },
                    { 267, 310, 267 },
                    { 268, 170, 268 },
                    { 269, 193, 269 },
                    { 270, 300, 270 },
                    { 271, 160, 271 },
                    { 272, 409, 272 },
                    { 273, 464, 273 },
                    { 274, 318, 274 },
                    { 275, 192, 275 },
                    { 276, 136, 276 },
                    { 277, 479, 277 },
                    { 278, 241, 278 },
                    { 279, 253, 279 },
                    { 280, 294, 280 },
                    { 281, 465, 281 },
                    { 282, 375, 282 },
                    { 283, 316, 283 },
                    { 284, 298, 284 },
                    { 285, 119, 285 },
                    { 286, 41, 286 },
                    { 287, 322, 287 },
                    { 288, 111, 288 },
                    { 289, 431, 289 },
                    { 290, 309, 290 },
                    { 291, 374, 291 },
                    { 292, 373, 292 },
                    { 293, 254, 293 },
                    { 294, 179, 294 },
                    { 295, 161, 295 },
                    { 296, 187, 296 },
                    { 297, 456, 297 },
                    { 298, 5, 298 },
                    { 299, 143, 299 },
                    { 300, 59, 300 },
                    { 301, 366, 301 },
                    { 302, 321, 302 },
                    { 303, 450, 303 },
                    { 304, 376, 304 },
                    { 305, 271, 305 },
                    { 306, 350, 306 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 307, 346, 307 },
                    { 308, 190, 308 },
                    { 309, 114, 309 },
                    { 310, 51, 310 },
                    { 311, 360, 311 },
                    { 312, 159, 312 },
                    { 313, 330, 313 },
                    { 314, 284, 314 },
                    { 315, 311, 315 },
                    { 316, 71, 316 },
                    { 317, 70, 317 },
                    { 318, 306, 318 },
                    { 319, 285, 319 },
                    { 320, 391, 320 },
                    { 321, 176, 321 },
                    { 322, 399, 322 },
                    { 323, 99, 323 },
                    { 324, 356, 324 },
                    { 325, 227, 325 },
                    { 326, 500, 326 },
                    { 327, 462, 327 },
                    { 328, 158, 328 },
                    { 329, 470, 329 },
                    { 330, 100, 330 },
                    { 331, 203, 331 },
                    { 332, 141, 332 },
                    { 333, 274, 333 },
                    { 334, 478, 334 },
                    { 335, 134, 335 },
                    { 336, 425, 336 },
                    { 337, 272, 337 },
                    { 338, 468, 338 },
                    { 339, 88, 339 },
                    { 340, 246, 340 },
                    { 341, 448, 341 },
                    { 342, 74, 342 },
                    { 343, 118, 343 },
                    { 344, 279, 344 },
                    { 345, 481, 345 },
                    { 346, 207, 346 },
                    { 347, 463, 347 },
                    { 348, 37, 348 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 349, 181, 349 },
                    { 350, 398, 350 },
                    { 351, 29, 351 },
                    { 352, 140, 352 },
                    { 353, 218, 353 },
                    { 354, 476, 354 },
                    { 355, 163, 355 },
                    { 356, 87, 356 },
                    { 357, 460, 357 },
                    { 358, 105, 358 },
                    { 359, 18, 359 },
                    { 360, 122, 360 },
                    { 361, 92, 361 },
                    { 362, 151, 362 },
                    { 363, 339, 363 },
                    { 364, 283, 364 },
                    { 365, 492, 365 },
                    { 366, 89, 366 },
                    { 367, 359, 367 },
                    { 368, 327, 368 },
                    { 369, 455, 369 },
                    { 370, 185, 370 },
                    { 371, 361, 371 },
                    { 372, 24, 372 },
                    { 373, 115, 373 },
                    { 374, 353, 374 },
                    { 375, 437, 375 },
                    { 376, 80, 376 },
                    { 377, 280, 377 },
                    { 378, 326, 378 },
                    { 379, 348, 379 },
                    { 380, 383, 380 },
                    { 381, 467, 381 },
                    { 382, 230, 382 },
                    { 383, 142, 383 },
                    { 384, 205, 384 },
                    { 385, 68, 385 },
                    { 386, 260, 386 },
                    { 387, 78, 387 },
                    { 388, 499, 388 },
                    { 389, 162, 389 },
                    { 390, 97, 390 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 391, 95, 391 },
                    { 392, 334, 392 },
                    { 393, 414, 393 },
                    { 394, 433, 394 },
                    { 395, 17, 395 },
                    { 396, 178, 396 },
                    { 397, 317, 397 },
                    { 398, 173, 398 },
                    { 399, 351, 399 },
                    { 400, 352, 400 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 1, 1, 92 },
                    { 2, 2, 361 },
                    { 3, 3, 348 },
                    { 4, 4, 242 },
                    { 5, 5, 76 },
                    { 6, 6, 276 },
                    { 7, 7, 145 },
                    { 8, 8, 257 },
                    { 9, 9, 79 },
                    { 10, 10, 89 },
                    { 11, 11, 110 },
                    { 12, 12, 403 },
                    { 13, 13, 3 },
                    { 14, 14, 342 },
                    { 15, 15, 122 },
                    { 16, 16, 386 },
                    { 17, 17, 473 },
                    { 18, 18, 185 },
                    { 19, 19, 29 },
                    { 20, 20, 56 },
                    { 21, 21, 417 },
                    { 22, 22, 238 },
                    { 23, 23, 9 },
                    { 24, 24, 432 },
                    { 25, 25, 120 },
                    { 26, 26, 370 },
                    { 27, 27, 424 },
                    { 28, 28, 268 },
                    { 29, 29, 70 },
                    { 30, 30, 368 },
                    { 31, 31, 6 },
                    { 32, 32, 117 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 33, 33, 247 },
                    { 34, 34, 332 },
                    { 35, 35, 239 },
                    { 36, 36, 453 },
                    { 37, 37, 341 },
                    { 38, 38, 74 },
                    { 39, 39, 68 },
                    { 40, 40, 323 },
                    { 41, 41, 435 },
                    { 42, 42, 322 },
                    { 43, 43, 285 },
                    { 44, 44, 24 },
                    { 45, 45, 447 },
                    { 46, 46, 193 },
                    { 47, 47, 26 },
                    { 48, 48, 111 },
                    { 49, 49, 282 },
                    { 50, 50, 272 },
                    { 51, 51, 210 },
                    { 52, 52, 142 },
                    { 53, 53, 35 },
                    { 54, 54, 18 },
                    { 55, 55, 377 },
                    { 56, 56, 73 },
                    { 57, 57, 171 },
                    { 58, 58, 36 },
                    { 59, 59, 5 },
                    { 60, 60, 84 },
                    { 61, 61, 13 },
                    { 62, 62, 484 },
                    { 63, 63, 139 },
                    { 64, 64, 283 },
                    { 65, 65, 280 },
                    { 66, 66, 104 },
                    { 67, 67, 477 },
                    { 68, 68, 105 },
                    { 69, 69, 478 },
                    { 70, 70, 143 },
                    { 71, 71, 328 },
                    { 72, 72, 131 },
                    { 73, 73, 166 },
                    { 74, 74, 232 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 75, 75, 274 },
                    { 76, 76, 150 },
                    { 77, 77, 284 },
                    { 78, 78, 273 },
                    { 79, 79, 44 },
                    { 80, 80, 125 },
                    { 81, 81, 421 },
                    { 82, 82, 243 },
                    { 83, 83, 75 },
                    { 84, 84, 126 },
                    { 85, 85, 109 },
                    { 86, 86, 458 },
                    { 87, 87, 135 },
                    { 88, 88, 371 },
                    { 89, 89, 253 },
                    { 90, 90, 407 },
                    { 91, 91, 181 },
                    { 92, 92, 444 },
                    { 93, 93, 398 },
                    { 94, 94, 47 },
                    { 95, 95, 138 },
                    { 96, 96, 460 },
                    { 97, 97, 470 },
                    { 98, 98, 468 },
                    { 99, 99, 259 },
                    { 100, 100, 379 },
                    { 101, 101, 177 },
                    { 102, 102, 309 },
                    { 103, 103, 349 },
                    { 104, 104, 499 },
                    { 105, 105, 176 },
                    { 106, 106, 346 },
                    { 107, 107, 17 },
                    { 108, 108, 452 },
                    { 109, 109, 366 },
                    { 110, 110, 367 },
                    { 111, 111, 157 },
                    { 112, 112, 423 },
                    { 113, 113, 270 },
                    { 114, 114, 211 },
                    { 115, 115, 123 },
                    { 116, 116, 236 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 117, 117, 430 },
                    { 118, 118, 353 },
                    { 119, 119, 331 },
                    { 120, 120, 31 },
                    { 121, 121, 203 },
                    { 122, 122, 316 },
                    { 123, 123, 41 },
                    { 124, 124, 37 },
                    { 125, 125, 4 },
                    { 126, 126, 102 },
                    { 127, 127, 237 },
                    { 128, 128, 115 },
                    { 129, 129, 59 },
                    { 130, 130, 269 },
                    { 131, 131, 412 },
                    { 132, 132, 298 },
                    { 133, 133, 480 },
                    { 134, 134, 479 },
                    { 135, 135, 10 },
                    { 136, 136, 464 },
                    { 137, 137, 173 },
                    { 138, 138, 363 },
                    { 139, 139, 290 },
                    { 140, 140, 118 },
                    { 141, 141, 457 },
                    { 142, 142, 474 },
                    { 143, 143, 355 },
                    { 144, 144, 251 },
                    { 145, 145, 229 },
                    { 146, 146, 365 },
                    { 147, 147, 62 },
                    { 148, 148, 170 },
                    { 149, 149, 434 },
                    { 150, 150, 101 },
                    { 151, 151, 60 },
                    { 152, 152, 308 },
                    { 153, 153, 218 },
                    { 154, 154, 260 },
                    { 155, 155, 497 },
                    { 156, 156, 303 },
                    { 157, 157, 416 },
                    { 158, 158, 163 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 159, 159, 186 },
                    { 160, 160, 262 },
                    { 161, 161, 45 },
                    { 162, 162, 415 },
                    { 163, 163, 149 },
                    { 164, 164, 279 },
                    { 165, 165, 25 },
                    { 166, 166, 95 },
                    { 167, 167, 93 },
                    { 168, 168, 451 },
                    { 169, 169, 188 },
                    { 170, 170, 440 },
                    { 171, 171, 214 },
                    { 172, 172, 213 },
                    { 173, 173, 90 },
                    { 174, 174, 83 },
                    { 175, 175, 112 },
                    { 176, 176, 305 },
                    { 177, 177, 442 },
                    { 178, 178, 201 },
                    { 179, 179, 192 },
                    { 180, 180, 286 },
                    { 181, 181, 267 },
                    { 182, 182, 425 },
                    { 183, 183, 207 },
                    { 184, 184, 315 },
                    { 185, 185, 411 },
                    { 186, 186, 200 },
                    { 187, 187, 212 },
                    { 188, 188, 456 },
                    { 189, 189, 392 },
                    { 190, 190, 455 },
                    { 191, 191, 402 },
                    { 192, 192, 154 },
                    { 193, 193, 405 },
                    { 194, 194, 148 },
                    { 195, 195, 195 },
                    { 196, 196, 140 },
                    { 197, 197, 205 },
                    { 198, 198, 351 },
                    { 199, 199, 155 },
                    { 200, 200, 427 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 201, 201, 340 },
                    { 202, 202, 206 },
                    { 203, 203, 172 },
                    { 204, 204, 141 },
                    { 205, 205, 127 },
                    { 206, 206, 492 },
                    { 207, 207, 80 },
                    { 208, 208, 38 },
                    { 209, 209, 372 },
                    { 210, 210, 281 },
                    { 211, 211, 339 },
                    { 212, 212, 144 },
                    { 213, 213, 495 },
                    { 214, 214, 391 },
                    { 215, 215, 380 },
                    { 216, 216, 310 },
                    { 217, 217, 313 },
                    { 218, 218, 159 },
                    { 219, 219, 250 },
                    { 220, 220, 198 },
                    { 221, 221, 196 },
                    { 222, 222, 34 },
                    { 223, 223, 344 },
                    { 224, 224, 437 },
                    { 225, 225, 69 },
                    { 226, 226, 490 },
                    { 227, 227, 106 },
                    { 228, 228, 320 },
                    { 229, 229, 191 },
                    { 230, 230, 471 },
                    { 231, 231, 466 },
                    { 232, 232, 271 },
                    { 233, 233, 78 },
                    { 234, 234, 373 },
                    { 235, 235, 422 },
                    { 236, 236, 493 },
                    { 237, 237, 114 },
                    { 238, 238, 137 },
                    { 239, 239, 134 },
                    { 240, 240, 321 },
                    { 241, 241, 277 },
                    { 242, 242, 153 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 243, 243, 222 },
                    { 244, 244, 500 },
                    { 245, 245, 445 },
                    { 246, 246, 357 },
                    { 247, 247, 266 },
                    { 248, 248, 14 },
                    { 249, 249, 414 },
                    { 250, 250, 399 },
                    { 251, 251, 369 },
                    { 252, 252, 265 },
                    { 253, 253, 293 },
                    { 254, 254, 336 },
                    { 255, 255, 249 },
                    { 256, 256, 441 },
                    { 257, 257, 304 },
                    { 258, 258, 486 },
                    { 259, 259, 85 },
                    { 260, 260, 449 },
                    { 261, 261, 94 },
                    { 262, 262, 53 },
                    { 263, 263, 226 },
                    { 264, 264, 409 },
                    { 265, 265, 312 },
                    { 266, 266, 433 },
                    { 267, 267, 390 },
                    { 268, 268, 81 },
                    { 269, 269, 288 },
                    { 270, 270, 472 },
                    { 271, 271, 152 },
                    { 272, 272, 387 },
                    { 273, 273, 16 },
                    { 274, 274, 488 },
                    { 275, 275, 329 },
                    { 276, 276, 23 },
                    { 277, 277, 50 },
                    { 278, 278, 91 },
                    { 279, 279, 219 },
                    { 280, 280, 97 },
                    { 281, 281, 307 },
                    { 282, 282, 388 },
                    { 283, 283, 275 },
                    { 284, 284, 209 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 285, 285, 158 },
                    { 286, 286, 343 },
                    { 287, 287, 28 },
                    { 288, 288, 156 },
                    { 289, 289, 381 },
                    { 290, 290, 491 },
                    { 291, 291, 235 },
                    { 292, 292, 216 },
                    { 293, 293, 64 },
                    { 294, 294, 108 },
                    { 295, 295, 467 },
                    { 296, 296, 382 },
                    { 297, 297, 161 },
                    { 298, 298, 221 },
                    { 299, 299, 55 },
                    { 300, 300, 54 },
                    { 301, 301, 8 },
                    { 302, 302, 72 },
                    { 303, 303, 202 },
                    { 304, 304, 98 },
                    { 305, 305, 359 },
                    { 306, 306, 459 },
                    { 307, 307, 338 },
                    { 308, 308, 11 },
                    { 309, 309, 481 },
                    { 310, 310, 12 },
                    { 311, 311, 465 },
                    { 312, 312, 431 },
                    { 313, 313, 2 },
                    { 314, 314, 228 },
                    { 315, 315, 325 },
                    { 316, 316, 356 },
                    { 317, 317, 180 },
                    { 318, 318, 408 },
                    { 319, 319, 337 },
                    { 320, 320, 384 },
                    { 321, 321, 364 },
                    { 322, 322, 393 },
                    { 323, 323, 223 },
                    { 324, 324, 475 },
                    { 325, 325, 375 },
                    { 326, 326, 335 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 327, 327, 178 },
                    { 328, 328, 439 },
                    { 329, 329, 448 },
                    { 330, 330, 418 },
                    { 331, 331, 227 },
                    { 332, 332, 19 },
                    { 333, 333, 1 },
                    { 334, 334, 99 },
                    { 335, 335, 39 },
                    { 336, 336, 133 },
                    { 337, 337, 401 },
                    { 338, 338, 230 },
                    { 339, 339, 327 },
                    { 340, 340, 179 },
                    { 341, 341, 22 },
                    { 342, 342, 333 },
                    { 343, 343, 51 },
                    { 344, 344, 311 },
                    { 345, 345, 7 },
                    { 346, 346, 494 },
                    { 347, 347, 362 },
                    { 348, 348, 306 },
                    { 349, 349, 130 },
                    { 350, 350, 40 },
                    { 351, 351, 52 },
                    { 352, 352, 419 },
                    { 353, 353, 129 },
                    { 354, 354, 217 },
                    { 355, 355, 121 },
                    { 356, 356, 436 },
                    { 357, 357, 187 },
                    { 358, 358, 21 },
                    { 359, 359, 326 },
                    { 360, 360, 318 },
                    { 361, 361, 136 },
                    { 362, 362, 65 },
                    { 363, 363, 167 },
                    { 364, 364, 199 },
                    { 365, 365, 385 },
                    { 366, 366, 324 },
                    { 367, 367, 317 },
                    { 368, 368, 100 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 369, 369, 454 },
                    { 370, 370, 88 },
                    { 371, 371, 128 },
                    { 372, 372, 420 },
                    { 373, 373, 151 },
                    { 374, 374, 438 },
                    { 375, 375, 96 },
                    { 376, 376, 233 },
                    { 377, 377, 254 },
                    { 378, 378, 124 },
                    { 379, 379, 360 },
                    { 380, 380, 404 },
                    { 381, 381, 248 },
                    { 382, 382, 82 },
                    { 383, 383, 220 },
                    { 384, 384, 57 },
                    { 385, 385, 394 },
                    { 386, 386, 146 },
                    { 387, 387, 263 },
                    { 388, 388, 252 },
                    { 389, 389, 169 },
                    { 390, 390, 32 },
                    { 391, 391, 395 },
                    { 392, 392, 400 },
                    { 393, 393, 255 },
                    { 394, 394, 87 },
                    { 395, 395, 27 },
                    { 396, 396, 482 },
                    { 397, 397, 113 },
                    { 398, 398, 66 },
                    { 399, 399, 462 },
                    { 400, 400, 413 }
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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 52);

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
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 62);

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
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 110);

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
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 132);

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
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 164);

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
                keyValue: 182);

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
                keyValue: 198);

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
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 252);

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
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 270);

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
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 332);

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
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 354);

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
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 382);

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
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 402);

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
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 447);

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
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 496);

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
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 33);

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
                keyValue: 46);

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
                keyValue: 58);

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
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 147);

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
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 175);

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
                keyValue: 189);

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
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 215);

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
                keyValue: 231);

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
                keyValue: 241);

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
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 289);

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
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 334);

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
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 389);

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
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 426);

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
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 498);

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
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 20);

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
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 51);

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
                keyValue: 55);

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
                keyValue: 63);

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
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 84);

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
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 103);

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
                keyValue: 124);

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
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 134);

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
                keyValue: 156);

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
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 163);

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
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 181);

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
                keyValue: 197);

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
                keyValue: 204);

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
                keyValue: 224);

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
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 236);

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
                keyValue: 245);

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
                keyValue: 251);

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
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 262);

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
                keyValue: 269);

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
                keyValue: 274);

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
                keyValue: 296);

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
                keyValue: 303);

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
                keyValue: 331);

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
                keyValue: 357);

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
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 361);

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
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 383);

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
                keyValue: 398);

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
                keyValue: 401);

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
                keyValue: 406);

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
                keyValue: 412);

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
                keyValue: 428);

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
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 442);

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
                keyValue: 451);

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
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 460);

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
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 472);

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
                keyValue: 477);

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
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "GradeID",
                keyValue: 486);

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
                keyValue: 31);

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
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 45);

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
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 60);

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
                keyValue: 66);

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
                keyValue: 102);

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
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 118);

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
                keyValue: 159);

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
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 167);

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
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 173);

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
                keyValue: 198);

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
                keyValue: 214);

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
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 223);

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
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 243);

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
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 257);

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
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 298);

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
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 313);

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
                keyValue: 320);

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
                keyValue: 339);

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
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 346);

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
                keyValue: 353);

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
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "MarkID",
                keyValue: 377);

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
                keyValue: 387);

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
                keyValue: 392);

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
                keyValue: 398);

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
                keyValue: 405);

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
                keyValue: 427);

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
                keyValue: 457);

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
                keyValue: 462);

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
                keyValue: 497);

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
                keyValue: new Guid("4bea0974-48a9-4c81-9a71-859448886b94"));

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
                keyValue: new Guid("05e3b30c-f7c1-4b6d-b21a-651712d1ce19"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("074fbb0c-9c0d-4eb3-b6e3-40079396dd53"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("08023032-a127-4d4f-bb49-bab2b9cafb5f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0d248f7f-9d23-4cfd-84eb-3597ee9f4169"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0dce2211-5a93-4d09-b5f4-71e179d5ee4f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0f7cac9d-fec5-4c31-91a1-52fdba97b9b6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1afe373b-297c-485e-97b6-04f4a8cfc2d7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1b1784c0-d34b-453f-a318-8d91efa9eccc"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1cfa6b7b-5123-4422-bac5-0ea7c7fb02ab"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("1e359496-0baf-4c7b-b8b9-a09f5b9b0fe0"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("248c1ddc-f246-4b91-ab27-225c8730bc65"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("24bac3a2-cbb2-4738-815e-c67fca1c7c14"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2596312c-0fd0-470e-b07f-7aee274528d8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("28b569e2-d595-47ba-aaa9-d71b0586486d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2964a03a-4129-48ab-a6f2-15e729d6f0cb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2bb54896-5ce9-45f9-8f3b-f2d07bd4c69b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("32ce1508-9402-4aff-abb0-2f94fdcb72b4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("39e6a092-7e64-443f-8404-0f2941ccd11f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3bda41f1-adcd-4532-b429-25df97b8173c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3be16202-b4e1-4ef8-b6bd-7b9396c8e683"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3d7bef60-7a4b-4b06-84f0-146fe8eb51cd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3e00badd-b24d-4ac9-986e-ae4ec62f33d3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("416c2f59-b9cc-4056-9e7f-7cb3128aa43a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("42922a5c-6e35-437d-83ed-d8f5fd39296b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("46e3cea2-1f7c-4196-82eb-130f0de129f7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("49b6fca6-d1fd-4e19-9fae-4bf792f0eb6b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("49d6ca10-ddc3-43f1-8410-c914de70c583"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4a4553fb-7b6c-4fd3-a7bf-6591056652b2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4bf5aade-d6d3-4809-9aad-262951136b03"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4d3e06be-99f5-471d-9e75-a87071b03c64"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4fd522e4-5814-4fa8-9fe5-28afbd959e5b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("52ac10e5-a114-4cde-ba1b-8bcb6cc99225"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("59f3113f-067d-4253-817c-cca5f39d4c68"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5b334452-33a7-49cf-a0af-a82ed7783e83"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6080493d-3e56-4b65-bc1f-897d510af2b0"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("61300ff2-7dbd-4a81-a98f-3bfb317c1246"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("67bd4f7e-d5bd-49b6-9860-dce6f459723e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6e370365-ce75-46e8-bb46-afca42c44fe4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("75e111f3-5ef1-453f-80c5-2036d6661aec"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7a303ff4-b862-4acc-bac9-1603f3eb7695"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7bb05215-cd13-4db4-9abe-a03353c2bab3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7bb73647-2b05-4b59-b012-c22899c6f8d2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7ef53ff4-2981-4f42-adfd-2e5851f63f29"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7f36fafd-e3a0-43f7-830d-a4bb503d875a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8115db51-6986-4a89-b40a-cce8fa14f11f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("833d5312-27fb-434c-82cd-24978c1567e8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("852129c5-792c-4c75-a148-9d065dc70834"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("87323e3d-7019-4ddc-92e9-4aca88e94faa"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("888d379e-7be6-45c3-88f1-2d659e51dfbf"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8b58cb1f-3afd-4873-9c43-507ed894e64a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8ff6c973-6c76-4128-9c1a-fedf8e4e2945"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9097133a-f5af-49e7-ab5b-ba9d1200e985"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("90def0a1-3245-4347-8d1e-13706fea54ab"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("90ec958f-ab51-42fa-b605-03c76823d423"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9370de4d-ee46-4927-ab02-83fd3f56798a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("938656bf-4996-40f7-afd7-a597e81cb72c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("972d301a-e489-4c2b-8700-58cfd8ca6498"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("97414be0-df76-4d4f-b302-3e9a6af41eff"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("989fee54-ac67-4053-b71f-1fb8f2cab4e2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("999e8b69-c523-4789-bfa6-34aaef14eb28"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9a0302a8-cb72-4fa5-b09f-2d011349bf73"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9c10020d-b4d7-41ee-9751-c9475bd3940b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9d51e7b9-ce79-40c9-bfce-ca68171f2742"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a1ebf176-4698-4356-9d46-1e61347ddbdc"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a74fbc89-efae-4580-8ed9-4cbc9088050c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a8da4807-fcdb-4acc-b7f0-686585255e97"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ab280cf1-09d6-440f-9d76-455f03dbfcf6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ae3e53d8-36fd-4a4a-bc4e-111b437e2a8c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("afda9358-44f7-4d01-9d32-61a0911e1359"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b185edf3-8843-47eb-8195-a5682d26903b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b38bf6d0-cb19-4cc7-875f-2dcd9d718843"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b5afa487-ec89-4a8f-8e95-823450827624"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b615efa7-85d5-4080-a67d-c835b318cabd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b6f2df9a-2592-4ce0-a56b-89a72497079a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("bd25a4f3-88ac-44ca-b7c3-bb5ac18a9735"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c06d26fb-f7dc-43d9-a137-91c8287d7e62"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c2e0c6f1-279e-400c-bb2f-a738a1ce0cbb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c60fa6d7-ce54-4444-ad87-8cf27c3740a1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c676b487-22ba-4b1f-baea-7a5af402083e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c6b3521d-0cae-47e9-b37f-987854008985"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c71a913c-b7da-4704-b823-5738d9b13360"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d1bc6a80-e1a9-465c-9abc-18fe89ac386e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d287edc4-4cb1-4a95-960b-f4e00e71b5be"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d783c986-f017-431f-9e87-9232c4cf82c5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d9106a9d-11a9-4e09-90b0-90d55acdad96"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d995161c-ee6d-46e2-b30b-05c8996ef6a9"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("db05d4dd-4440-42f3-9605-4014cd065fc7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("de92104f-7077-4376-9058-2cccd493d364"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e33eb82d-08f5-4298-8300-1ee6e437d8ec"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e65addb6-498e-48f7-9f9b-7b0c1a457fb4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("eaf77c5e-3a50-4203-82d5-9fa99c80d6fc"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("eb3d74c6-eeaf-41b0-ae4f-93d2d2ca5344"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ec69d3c3-5bc7-4f13-818a-dfd4da88088f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ef906afc-5d4d-406f-a229-465cd81fb912"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f0c957ee-2118-4ad3-b856-7ee80dab22c3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f26228ac-833c-4a65-9bae-db7b55b5a861"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f5e4bbf3-f4aa-43fe-9f4f-00ad5fa858d7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f76988f7-6979-4841-ae3c-08483ac5d565"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fda9cfa2-2a17-4025-9c99-37e11ac4f3a5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fec5c35b-3065-4471-9a85-a6c685419699"));

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
