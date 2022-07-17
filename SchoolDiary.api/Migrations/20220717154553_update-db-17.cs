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
                    { 1, "", false },
                    { 2, "", false },
                    { 3, "", false },
                    { 4, "", true },
                    { 5, "", false },
                    { 6, "", false },
                    { 7, "", true },
                    { 8, "", true },
                    { 9, "", true },
                    { 10, "", false },
                    { 11, "", false },
                    { 12, "", false },
                    { 13, "", true },
                    { 14, "", false },
                    { 15, "", true },
                    { 16, "", true },
                    { 17, "", false },
                    { 18, "", false },
                    { 19, "", false },
                    { 20, "", false },
                    { 21, "", false },
                    { 22, "", true },
                    { 23, "", true },
                    { 24, "", true },
                    { 25, "", false },
                    { 26, "", false },
                    { 27, "", true },
                    { 28, "", true },
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
                    { 1, "", 6, 1 },
                    { 2, "", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 3, "", 3, 3 },
                    { 4, "", 2, 3 },
                    { 5, "", 6, 2 },
                    { 6, "", 6, 3 },
                    { 7, "", 4, 1 },
                    { 8, "", 4, 3 },
                    { 9, "", 1, 2 },
                    { 10, "", 1, 2 },
                    { 11, "", 1, 2 },
                    { 12, "", 4, 1 },
                    { 13, "", 1, 3 },
                    { 14, "", 3, 2 },
                    { 15, "", 4, 1 },
                    { 16, "", 3, 3 },
                    { 17, "", 5, 1 },
                    { 18, "", 4, 1 },
                    { 19, "", 4, 2 },
                    { 20, "", 1, 3 },
                    { 21, "", 5, 1 },
                    { 22, "", 2, 1 },
                    { 23, "", 6, 2 },
                    { 24, "", 6, 3 },
                    { 25, "", 4, 3 },
                    { 26, "", 2, 2 },
                    { 27, "", 2, 1 },
                    { 28, "", 3, 2 },
                    { 29, "", 1, 3 },
                    { 30, "", 5, 2 },
                    { 31, "", 1, 3 },
                    { 32, "", 5, 2 },
                    { 33, "", 1, 1 },
                    { 34, "", 6, 1 },
                    { 35, "", 2, 1 },
                    { 36, "", 3, 2 },
                    { 37, "", 6, 1 },
                    { 38, "", 5, 1 },
                    { 39, "", 2, 2 },
                    { 40, "", 1, 1 },
                    { 41, "", 6, 3 },
                    { 42, "", 4, 1 },
                    { 43, "", 3, 2 },
                    { 44, "", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "GradeID", "Description", "GradeValue", "Weight" },
                values: new object[,]
                {
                    { 45, "", 5, 1 },
                    { 46, "", 2, 3 },
                    { 47, "", 4, 1 },
                    { 48, "", 1, 1 },
                    { 49, "", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "English" },
                    { 2, 1, 2, "Math" },
                    { 3, 1, 3, "Physics" },
                    { 4, 1, 4, "Geography" },
                    { 5, 1, 5, "PE" },
                    { 6, 1, 6, "Math" },
                    { 7, 1, 7, "Geography" },
                    { 8, 2, 1, "Polish" },
                    { 9, 2, 2, "Math" },
                    { 10, 2, 3, "PE" },
                    { 11, 2, 4, "English" },
                    { 12, 2, 5, "Geography" },
                    { 13, 2, 6, "History" },
                    { 14, 2, 7, "Geography" },
                    { 15, 3, 1, "Math" },
                    { 16, 3, 2, "English" },
                    { 17, 3, 3, "Physics" },
                    { 18, 3, 4, "Physics" },
                    { 19, 3, 5, "English" },
                    { 20, 3, 6, "Chemistry" },
                    { 21, 3, 7, "Math" },
                    { 22, 4, 1, "History" },
                    { 23, 4, 2, "PE" },
                    { 24, 4, 3, "Chemistry" },
                    { 25, 4, 4, "Chemistry" },
                    { 26, 4, 5, "PE" },
                    { 27, 4, 6, "Math" },
                    { 28, 4, 7, "Math" },
                    { 29, 5, 1, "Physics" },
                    { 30, 5, 2, "History" },
                    { 31, 5, 3, "History" },
                    { 32, 5, 4, "Geography" },
                    { 33, 5, 5, "Geography" },
                    { 34, 5, 6, "PE" },
                    { 35, 5, 7, "Polish" },
                    { 36, 6, 1, "Chemistry" },
                    { 37, 6, 2, "Polish" }
                });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonID", "Day", "Hour", "Name" },
                values: new object[,]
                {
                    { 38, 6, 3, "History" },
                    { 39, 6, 4, "Chemistry" },
                    { 40, 6, 5, "Geography" },
                    { 41, 6, 6, "English" },
                    { 42, 6, 7, "Physics" },
                    { 43, 7, 1, "English" },
                    { 44, 7, 2, "Chemistry" },
                    { 45, 7, 3, "Physics" },
                    { 46, 7, 4, "Physics" },
                    { 47, 7, 5, "Polish" },
                    { 48, 7, 6, "English" },
                    { 49, 7, 7, "History" }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "Present" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 16, 19, 9, 34, 414, DateTimeKind.Local).AddTicks(7718), true },
                    { 2, new DateTime(2022, 7, 17, 11, 21, 11, 629, DateTimeKind.Local).AddTicks(8680), false },
                    { 3, new DateTime(2022, 7, 17, 11, 34, 26, 969, DateTimeKind.Local).AddTicks(9750), true },
                    { 4, new DateTime(2022, 7, 17, 0, 24, 40, 755, DateTimeKind.Local).AddTicks(6545), true },
                    { 5, new DateTime(2022, 7, 16, 23, 55, 54, 246, DateTimeKind.Local).AddTicks(410), true },
                    { 6, new DateTime(2022, 7, 16, 18, 2, 28, 547, DateTimeKind.Local).AddTicks(7751), false },
                    { 7, new DateTime(2022, 7, 16, 20, 26, 40, 589, DateTimeKind.Local).AddTicks(7069), true },
                    { 8, new DateTime(2022, 7, 17, 9, 33, 33, 918, DateTimeKind.Local).AddTicks(4501), true },
                    { 9, new DateTime(2022, 7, 16, 19, 22, 24, 868, DateTimeKind.Local).AddTicks(5170), false },
                    { 10, new DateTime(2022, 7, 17, 1, 47, 48, 867, DateTimeKind.Local).AddTicks(5000), true },
                    { 11, new DateTime(2022, 7, 17, 0, 29, 6, 509, DateTimeKind.Local).AddTicks(3987), true },
                    { 12, new DateTime(2022, 7, 17, 11, 22, 27, 172, DateTimeKind.Local).AddTicks(8936), false },
                    { 13, new DateTime(2022, 7, 17, 7, 8, 54, 939, DateTimeKind.Local).AddTicks(7122), true },
                    { 14, new DateTime(2022, 7, 16, 21, 55, 19, 208, DateTimeKind.Local).AddTicks(768), false },
                    { 15, new DateTime(2022, 7, 17, 16, 20, 53, 770, DateTimeKind.Local).AddTicks(606), true },
                    { 16, new DateTime(2022, 7, 17, 2, 58, 25, 666, DateTimeKind.Local).AddTicks(3220), false },
                    { 17, new DateTime(2022, 7, 17, 9, 49, 51, 534, DateTimeKind.Local).AddTicks(567), true },
                    { 18, new DateTime(2022, 7, 17, 3, 8, 53, 643, DateTimeKind.Local).AddTicks(9624), false },
                    { 19, new DateTime(2022, 7, 16, 20, 5, 59, 724, DateTimeKind.Local).AddTicks(8778), true },
                    { 20, new DateTime(2022, 7, 17, 13, 5, 47, 814, DateTimeKind.Local).AddTicks(8953), true },
                    { 21, new DateTime(2022, 7, 17, 0, 37, 34, 136, DateTimeKind.Local).AddTicks(7243), true },
                    { 22, new DateTime(2022, 7, 16, 18, 2, 16, 137, DateTimeKind.Local).AddTicks(3367), true },
                    { 23, new DateTime(2022, 7, 17, 14, 15, 45, 954, DateTimeKind.Local).AddTicks(3067), true },
                    { 24, new DateTime(2022, 7, 17, 16, 14, 18, 892, DateTimeKind.Local).AddTicks(874), false },
                    { 25, new DateTime(2022, 7, 17, 12, 47, 24, 675, DateTimeKind.Local).AddTicks(8423), false },
                    { 26, new DateTime(2022, 7, 16, 20, 0, 1, 291, DateTimeKind.Local).AddTicks(8801), false },
                    { 27, new DateTime(2022, 7, 16, 21, 51, 25, 941, DateTimeKind.Local).AddTicks(9959), false },
                    { 28, new DateTime(2022, 7, 17, 13, 50, 33, 0, DateTimeKind.Local).AddTicks(9240), false },
                    { 29, new DateTime(2022, 7, 17, 14, 41, 17, 276, DateTimeKind.Local).AddTicks(5227), false },
                    { 30, new DateTime(2022, 7, 16, 23, 45, 10, 930, DateTimeKind.Local).AddTicks(2770), false }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "MarkID", "Date", "Present" },
                values: new object[,]
                {
                    { 31, new DateTime(2022, 7, 17, 3, 14, 20, 437, DateTimeKind.Local).AddTicks(929), false },
                    { 32, new DateTime(2022, 7, 17, 15, 44, 20, 557, DateTimeKind.Local).AddTicks(1753), true },
                    { 33, new DateTime(2022, 7, 17, 8, 1, 18, 598, DateTimeKind.Local).AddTicks(116), true },
                    { 34, new DateTime(2022, 7, 16, 20, 50, 9, 575, DateTimeKind.Local).AddTicks(1674), false },
                    { 35, new DateTime(2022, 7, 17, 17, 12, 18, 928, DateTimeKind.Local).AddTicks(6600), false },
                    { 36, new DateTime(2022, 7, 17, 6, 48, 19, 614, DateTimeKind.Local).AddTicks(7525), false },
                    { 37, new DateTime(2022, 7, 16, 18, 14, 35, 693, DateTimeKind.Local).AddTicks(4260), false },
                    { 38, new DateTime(2022, 7, 17, 16, 32, 44, 656, DateTimeKind.Local).AddTicks(3143), true },
                    { 39, new DateTime(2022, 7, 17, 9, 45, 34, 311, DateTimeKind.Local).AddTicks(8316), false },
                    { 40, new DateTime(2022, 7, 16, 23, 35, 34, 137, DateTimeKind.Local).AddTicks(4373), false },
                    { 41, new DateTime(2022, 7, 17, 16, 7, 18, 950, DateTimeKind.Local).AddTicks(3816), true },
                    { 42, new DateTime(2022, 7, 17, 12, 4, 10, 648, DateTimeKind.Local).AddTicks(957), false },
                    { 43, new DateTime(2022, 7, 17, 16, 48, 35, 554, DateTimeKind.Local).AddTicks(3350), false },
                    { 44, new DateTime(2022, 7, 16, 19, 5, 27, 418, DateTimeKind.Local).AddTicks(721), true },
                    { 45, new DateTime(2022, 7, 16, 18, 28, 23, 864, DateTimeKind.Local).AddTicks(9456), true },
                    { 46, new DateTime(2022, 7, 17, 0, 19, 13, 169, DateTimeKind.Local).AddTicks(2382), false },
                    { 47, new DateTime(2022, 7, 16, 22, 53, 47, 472, DateTimeKind.Local).AddTicks(2525), true },
                    { 48, new DateTime(2022, 7, 17, 17, 18, 4, 731, DateTimeKind.Local).AddTicks(3332), true },
                    { 49, new DateTime(2022, 7, 17, 1, 22, 1, 531, DateTimeKind.Local).AddTicks(9337), false }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Charles_Bednar69@hotmail.com", "Charles", "Bednar", "1-233-202-6759 x5456" },
                    { 2, "Tracey_Lind@yahoo.com", "Tracey", "Lind", "970-940-2051 x522" },
                    { 3, "Rosalie31@gmail.com", "Rosalie", "Bogan", "521-289-4057 x07714" },
                    { 4, "Sheila_OConnell@hotmail.com", "Sheila", "O'Connell", "(663) 644-9598" },
                    { 5, "Jay_West6@gmail.com", "Jay", "West", "1-394-403-3052 x2035" },
                    { 6, "Eddie_Ondricka@yahoo.com", "Eddie", "Ondricka", "1-925-583-0199" },
                    { 7, "Cindy_Zulauf93@gmail.com", "Cindy", "Zulauf", "352-477-0956 x1301" },
                    { 8, "Grant_Anderson@hotmail.com", "Grant", "Anderson", "1-870-772-8518 x5768" },
                    { 9, "Bobbie.Botsford@yahoo.com", "Bobbie", "Botsford", "1-945-661-1575 x5087" },
                    { 10, "Craig_Rau19@hotmail.com", "Craig", "Rau", "(484) 578-1652 x981" },
                    { 11, "Tiffany.Hessel39@gmail.com", "Tiffany", "Hessel", "608.547.5157" },
                    { 12, "Ramona58@gmail.com", "Ramona", "Rau", "639-493-3447" },
                    { 13, "Susie35@hotmail.com", "Susie", "Mann", "756-428-3590" },
                    { 14, "Allison.Schmitt@gmail.com", "Allison", "Schmitt", "(384) 879-2125 x19409" },
                    { 15, "Sheila_Hagenes@gmail.com", "Sheila", "Hagenes", "634-972-4700 x7946" },
                    { 16, "Judith.Hayes@hotmail.com", "Judith", "Hayes", "1-434-908-4766" },
                    { 17, "Lydia.Kovacek79@gmail.com", "Lydia", "Kovacek", "348.719.1930" },
                    { 18, "Cody_Skiles83@gmail.com", "Cody", "Skiles", "962.937.4544 x197" },
                    { 19, "Salvador.King@gmail.com", "Salvador", "King", "1-778-858-7117" },
                    { 20, "Karen_Ritchie@gmail.com", "Karen", "Ritchie", "1-715-727-7283 x4164" },
                    { 21, "Grace_Ankunding39@yahoo.com", "Grace", "Ankunding", "(823) 455-6118 x8136" },
                    { 22, "Pat.Kris85@yahoo.com", "Pat", "Kris", "660.382.8097" },
                    { 23, "Josephine95@gmail.com", "Josephine", "Greenholt", "867.407.5467 x01075" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 24, "Diane.Stamm69@hotmail.com", "Diane", "Stamm", "1-692-419-8862" },
                    { 25, "Jimmy48@hotmail.com", "Jimmy", "Morissette", "(585) 787-2343 x1165" },
                    { 26, "Ana10@yahoo.com", "Ana", "Dicki", "634-937-1074" },
                    { 27, "Garry_Pacocha87@yahoo.com", "Garry", "Pacocha", "(396) 342-1674 x8099" },
                    { 28, "Jenny_Gottlieb@hotmail.com", "Jenny", "Gottlieb", "913.770.3156 x440" },
                    { 29, "Marcella.Heaney@yahoo.com", "Marcella", "Heaney", "(699) 641-4827" },
                    { 30, "Ian.Botsford@yahoo.com", "Ian", "Botsford", "732.931.8680" },
                    { 31, "Naomi44@gmail.com", "Naomi", "Lemke", "1-415-325-3101" },
                    { 32, "Phyllis44@gmail.com", "Phyllis", "Kessler", "1-510-793-5007 x3847" },
                    { 33, "Miguel62@yahoo.com", "Miguel", "Beatty", "456.442.2018 x490" },
                    { 34, "Bob_Rodriguez78@gmail.com", "Bob", "Rodriguez", "1-309-784-4420" },
                    { 35, "Marvin_Prohaska15@yahoo.com", "Marvin", "Prohaska", "599.313.2179 x9460" },
                    { 36, "Perry7@yahoo.com", "Perry", "Schuster", "1-908-925-1961 x65518" },
                    { 37, "Bobbie_Ondricka@yahoo.com", "Bobbie", "Ondricka", "429-947-3258" },
                    { 38, "Lucia.Auer58@gmail.com", "Lucia", "Auer", "1-927-699-4519 x255" },
                    { 39, "Mamie_Kiehn@gmail.com", "Mamie", "Kiehn", "(905) 900-0721 x4506" },
                    { 40, "Annie_Swaniawski37@hotmail.com", "Annie", "Swaniawski", "(274) 414-0476" },
                    { 41, "Shelley_Wehner@yahoo.com", "Shelley", "Wehner", "(282) 717-0079 x741" },
                    { 42, "Clint66@hotmail.com", "Clint", "Nader", "207-402-9409" },
                    { 43, "Greg_Kozey@gmail.com", "Greg", "Kozey", "(276) 836-3104" },
                    { 44, "Lila.Powlowski@hotmail.com", "Lila", "Powlowski", "(292) 996-1398" },
                    { 45, "Katherine95@gmail.com", "Katherine", "Fay", "855.759.1703 x6810" },
                    { 46, "Laurence.Walker7@yahoo.com", "Laurence", "Walker", "640-537-3972 x78693" },
                    { 47, "Lillian.Hegmann@yahoo.com", "Lillian", "Hegmann", "619-775-0332 x185" },
                    { 48, "Amber_Mueller89@hotmail.com", "Amber", "Mueller", "1-900-800-7850" },
                    { 49, "Hector56@hotmail.com", "Hector", "Rau", "880-940-3370" },
                    { 50, "Lionel.Ankunding57@gmail.com", "Lionel", "Ankunding", "1-343-589-9904 x2668" },
                    { 51, "Melvin.Stanton@hotmail.com", "Melvin", "Stanton", "1-860-562-2445" },
                    { 52, "Gordon_Smitham52@yahoo.com", "Gordon", "Smitham", "1-923-310-3755" },
                    { 53, "Ron.Daugherty@hotmail.com", "Ron", "Daugherty", "893-738-2798 x3111" },
                    { 54, "Hilda_Bradtke@hotmail.com", "Hilda", "Bradtke", "538.509.7843 x7304" },
                    { 55, "Pauline74@gmail.com", "Pauline", "Treutel", "606.239.5525 x29110" },
                    { 56, "Joel41@yahoo.com", "Joel", "Larkin", "(372) 791-7732 x5419" },
                    { 57, "Brian.Moen48@yahoo.com", "Brian", "Moen", "(895) 215-2413 x4686" },
                    { 58, "Meghan.Hickle8@gmail.com", "Meghan", "Hickle", "(907) 262-1931" },
                    { 59, "Matt43@gmail.com", "Matt", "Kertzmann", "816.568.3418 x3987" },
                    { 60, "Israel.Ziemann@hotmail.com", "Israel", "Ziemann", "656.667.3707 x16122" },
                    { 61, "Lora.Hickle22@hotmail.com", "Lora", "Hickle", "481.679.5966" },
                    { 62, "Thomas.Nienow@gmail.com", "Thomas", "Nienow", "(829) 845-1045" },
                    { 63, "Simon_Sipes23@hotmail.com", "Simon", "Sipes", "385-519-5039 x40693" },
                    { 64, "Roberta.Hickle68@yahoo.com", "Roberta", "Hickle", "(919) 404-1583" },
                    { 65, "Edward.Schamberger61@yahoo.com", "Edward", "Schamberger", "706.332.2338" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "ParentID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 66, "Tracey53@yahoo.com", "Tracey", "Wolf", "235.711.6861 x433" },
                    { 67, "Josefina72@yahoo.com", "Josefina", "Ratke", "1-330-777-8019 x62213" },
                    { 68, "Diana46@gmail.com", "Diana", "Reynolds", "387-327-1427 x75047" },
                    { 69, "Van.Ward@gmail.com", "Van", "Ward", "229.500.7756" },
                    { 70, "Adrienne_Greenfelder@hotmail.com", "Adrienne", "Greenfelder", "877-232-0836 x71233" },
                    { 71, "Ricky_Wilderman46@yahoo.com", "Ricky", "Wilderman", "1-298-432-1436 x285" },
                    { 72, "Anna18@hotmail.com", "Anna", "Balistreri", "846.309.5728" },
                    { 73, "Eduardo.Schneider@yahoo.com", "Eduardo", "Schneider", "707-699-4904" },
                    { 74, "Deanna_Pfannerstill@hotmail.com", "Deanna", "Pfannerstill", "(580) 624-2192 x9655" },
                    { 75, "Domingo.Langworth@gmail.com", "Domingo", "Langworth", "236-868-0651 x7424" },
                    { 76, "Nathaniel_Armstrong44@gmail.com", "Nathaniel", "Armstrong", "(757) 521-9159" },
                    { 77, "Jody.Dickens@yahoo.com", "Jody", "Dickens", "316-850-6069 x25610" },
                    { 78, "Theresa98@gmail.com", "Theresa", "Jenkins", "657-707-8170 x4380" },
                    { 79, "Emilio_Koch71@hotmail.com", "Emilio", "Koch", "(375) 594-0228 x65351" },
                    { 80, "Joanna.Waters89@gmail.com", "Joanna", "Waters", "1-981-858-8118" },
                    { 81, "Esther17@hotmail.com", "Esther", "Lowe", "1-861-247-5556" },
                    { 82, "Wm45@yahoo.com", "Wm", "Smith", "655.234.4789 x2610" },
                    { 83, "Alicia_Hamill49@hotmail.com", "Alicia", "Hamill", "574-551-8862 x3078" },
                    { 84, "Ivan_Ortiz@yahoo.com", "Ivan", "Ortiz", "1-272-913-2902 x208" },
                    { 85, "Kerry_Wiegand52@hotmail.com", "Kerry", "Wiegand", "968-687-6787" },
                    { 86, "Devin31@yahoo.com", "Devin", "White", "1-695-826-5687" },
                    { 87, "Eva13@yahoo.com", "Eva", "Boehm", "1-660-437-6714 x9724" },
                    { 88, "Donna.Tromp@gmail.com", "Donna", "Tromp", "(730) 879-2461" },
                    { 89, "Jacob_Kuhlman@yahoo.com", "Jacob", "Kuhlman", "293-289-4461 x0931" },
                    { 90, "Johnnie.Hammes@yahoo.com", "Johnnie", "Hammes", "230-931-5384 x13199" },
                    { 91, "Moses47@yahoo.com", "Moses", "Walker", "1-905-601-5432" },
                    { 92, "Marco_Sporer87@hotmail.com", "Marco", "Sporer", "1-643-650-9795 x5227" },
                    { 93, "Catherine61@gmail.com", "Catherine", "Klocko", "262.741.0199 x02802" },
                    { 94, "Angel89@yahoo.com", "Angel", "Lindgren", "454.905.1455" },
                    { 95, "Dana.Kutch@gmail.com", "Dana", "Kutch", "506.912.6025 x184" },
                    { 96, "Leo_Ernser25@gmail.com", "Leo", "Ernser", "(370) 698-6097 x4248" },
                    { 97, "Samantha.Nicolas96@yahoo.com", "Samantha", "Nicolas", "855-327-4236 x0368" },
                    { 98, "Mike23@gmail.com", "Mike", "Schoen", "(921) 884-1727 x3028" },
                    { 99, "Miriam_Kassulke@yahoo.com", "Miriam", "Kassulke", "(954) 722-2527" },
                    { 100, "Joyce97@yahoo.com", "Joyce", "Marvin", "1-932-359-6899 x5943" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("015de306-ea97-406d-bdde-8ae679dea4d4"), null, null, "Charles_MacGyver@hotmail.com", null, null, "", null, null },
                    { new Guid("0225c85e-90d9-4e05-9789-17ed96d37ba6"), null, null, "Madeline.White85@hotmail.com", null, null, "", null, null },
                    { new Guid("02925ed1-cc80-4e59-9aee-b4c4cd2299b5"), null, null, "Nellie2@yahoo.com", null, null, "", null, null },
                    { new Guid("0464327d-440b-49d2-a3a1-9957708037da"), null, null, "Elmer77@gmail.com", null, null, "", null, null },
                    { new Guid("0529083b-4689-45d8-a0d7-049520c854f9"), null, null, "Jaime_Hills@yahoo.com", null, null, "", null, null },
                    { new Guid("09d0f383-83fb-4c94-a9cc-6ac398eeca9c"), null, null, "Gayle.Johns@gmail.com", null, null, "", null, null },
                    { new Guid("0a7d9590-232d-4671-80e4-f9184e615d06"), null, null, "Teri74@hotmail.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("0c5cd5d4-f659-4a8e-ac78-e4570f11ed42"), null, null, "Travis.Dach87@gmail.com", null, null, "", null, null },
                    { new Guid("163fab97-3928-4b48-8de7-3ec49e4a39e7"), null, null, "Duane_Stehr73@gmail.com", null, null, "", null, null },
                    { new Guid("210f1bba-bace-4243-a288-2a73c45f5fac"), null, null, "Violet.Tremblay61@yahoo.com", null, null, "", null, null },
                    { new Guid("21665a27-f6b0-44e4-8362-5861dbc67945"), null, null, "Tammy.Rutherford94@hotmail.com", null, null, "", null, null },
                    { new Guid("22929aa0-aff3-42a7-8ec6-757ffdba820d"), null, null, "Mary36@gmail.com", null, null, "", null, null },
                    { new Guid("234da0a1-ac49-452c-9186-fd31c2ff7f2d"), null, null, "Opal.Zieme@gmail.com", null, null, "", null, null },
                    { new Guid("23618f27-8122-406f-8531-da1f27e78acb"), null, null, "Bobbie.Prosacco16@yahoo.com", null, null, "", null, null },
                    { new Guid("25885572-7dc2-4faf-b53e-0f39d6685d2c"), null, null, "Louis.Hane36@hotmail.com", null, null, "", null, null },
                    { new Guid("2621aa1e-0c55-40b7-ab7f-94fd32e517c4"), null, null, "Gail_Mertz5@yahoo.com", null, null, "", null, null },
                    { new Guid("2ff5dc15-af57-4d39-b427-70fc98fbbbb4"), null, null, "Kristen.Fritsch@hotmail.com", null, null, "", null, null },
                    { new Guid("317b6cf8-2375-488b-9c4a-81e29ed8a9b8"), null, null, "Matt.Wuckert@gmail.com", null, null, "", null, null },
                    { new Guid("339db9e6-4ecf-4ea5-96d5-505b645ed3ca"), null, null, "Luther.Moore@hotmail.com", null, null, "", null, null },
                    { new Guid("35f1caf9-08f3-4d44-9fe7-6bee89312942"), null, null, "Shelia12@gmail.com", null, null, "", null, null },
                    { new Guid("36daf101-56c5-4162-93fe-5ed4157f9344"), null, null, "Lonnie_Mayert@hotmail.com", null, null, "", null, null },
                    { new Guid("3d1fba97-c557-4631-a1ab-5c037f4ca055"), null, null, "Paulette.Deckow85@gmail.com", null, null, "", null, null },
                    { new Guid("3e9c228b-992a-493d-83a4-7dde56afa02c"), null, null, "Becky.Haag@gmail.com", null, null, "", null, null },
                    { new Guid("415f27e6-a41f-46a1-ac38-0fbf86e8a1d5"), null, null, "Daisy_Christiansen@hotmail.com", null, null, "", null, null },
                    { new Guid("44b15ea8-f419-4102-a64a-2db2b5a0aa8f"), null, null, "Laverne24@hotmail.com", null, null, "", null, null },
                    { new Guid("470a064e-b5e7-485d-9326-e588e9326abd"), null, null, "Maxine.Walter29@yahoo.com", null, null, "", null, null },
                    { new Guid("47f3e468-070b-420d-b118-92da80a01e46"), null, null, "Rufus_Carroll28@yahoo.com", null, null, "", null, null },
                    { new Guid("481faa6c-3b29-47c5-bde0-eb5e9c060b23"), null, null, "Casey89@gmail.com", null, null, "", null, null },
                    { new Guid("4a970ef1-a9f2-4ab4-b181-06e1ebd0ce2a"), null, null, "Paul54@hotmail.com", null, null, "", null, null },
                    { new Guid("4ff7814f-ae30-4979-9724-143ab3dddc76"), null, null, "Jason_Shanahan@gmail.com", null, null, "", null, null },
                    { new Guid("50342add-c11b-4761-814c-7780a0423649"), null, null, "Celia_Bradtke@hotmail.com", null, null, "", null, null },
                    { new Guid("52c2b7e9-8feb-446b-a330-41cedfa3794d"), null, null, "Wilson_Huels@hotmail.com", null, null, "", null, null },
                    { new Guid("5523881e-2337-4aef-939c-cce25509a216"), null, null, "Leslie94@yahoo.com", null, null, "", null, null },
                    { new Guid("56c570fc-8c5f-41d1-b81b-1be1f35140ec"), null, null, "Genevieve_Thompson@yahoo.com", null, null, "", null, null },
                    { new Guid("5c2bf0be-2f71-43cc-af7f-8e112b55a813"), null, null, "Beulah_Lang@yahoo.com", null, null, "", null, null },
                    { new Guid("5cd98324-fe46-4980-9954-d6d5f7276021"), null, null, "Kathleen85@hotmail.com", null, null, "", null, null },
                    { new Guid("5d0b59cd-2728-49b4-b384-1437157f9312"), null, null, "Belinda.Grant74@yahoo.com", null, null, "", null, null },
                    { new Guid("5e0a2509-13ef-44c7-8f18-5ece1f593b2d"), null, null, "Gayle_Macejkovic27@gmail.com", null, null, "", null, null },
                    { new Guid("60fda660-96e3-465c-8c53-3ff1898cae7b"), null, null, "Horace55@yahoo.com", null, null, "", null, null },
                    { new Guid("618181a4-70f5-4c49-9fcc-301bb5027e8d"), null, null, "Blanca.Konopelski@hotmail.com", null, null, "", null, null },
                    { new Guid("6259697b-df90-4743-96e1-02bd1da4508d"), null, null, "Kerry_Feil70@hotmail.com", null, null, "", null, null },
                    { new Guid("63510290-a92c-41de-a616-b6c11f6c49cf"), null, null, "Lula.Deckow34@hotmail.com", null, null, "", null, null },
                    { new Guid("67aae709-f0b5-408a-8158-52e834961d26"), null, null, "Inez50@gmail.com", null, null, "", null, null },
                    { new Guid("682b662a-3f1c-472c-a206-941063f58411"), null, null, "Colin92@gmail.com", null, null, "", null, null },
                    { new Guid("6873322e-38e2-4a1a-b3f5-c053189b1c5a"), null, null, "Ramon_Howe56@yahoo.com", null, null, "", null, null },
                    { new Guid("6bd2d173-3252-454e-b808-a68dff674586"), null, null, "Lillie38@yahoo.com", null, null, "", null, null },
                    { new Guid("71cb75e3-70e5-4d7e-a64d-d53805d99668"), null, null, "Kenneth_Welch83@yahoo.com", null, null, "", null, null },
                    { new Guid("73247590-367b-4818-b5a5-e0536567c69b"), null, null, "Rebecca_Cassin@hotmail.com", null, null, "", null, null },
                    { new Guid("77232b63-846b-40b2-b75b-588e11ab9f56"), null, null, "Christy.Welch43@hotmail.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("775b920b-b809-4b9e-9580-2593e2ec306b"), null, null, "Seth_Lemke@hotmail.com", null, null, "", null, null },
                    { new Guid("7fcce17d-edfd-48a2-81e5-6e31b1f05c13"), null, null, "Kevin.Krajcik@hotmail.com", null, null, "", null, null },
                    { new Guid("81e9d812-abfe-4704-b30c-458a11e6a70b"), null, null, "Ben97@yahoo.com", null, null, "", null, null },
                    { new Guid("8453f48a-7b2d-452a-ac90-17e0641577d3"), null, null, "Joyce_Koepp@hotmail.com", null, null, "", null, null },
                    { new Guid("848ace5c-42ea-4d90-92f9-bae6dd8c96fb"), null, null, "Darnell.Tromp@gmail.com", null, null, "", null, null },
                    { new Guid("84ca8db1-b237-4750-9325-69520282a2ca"), null, null, "Patti31@yahoo.com", null, null, "", null, null },
                    { new Guid("86e1265b-a688-4d33-b14b-1528072cfaad"), null, null, "Elbert.Reynolds@yahoo.com", null, null, "", null, null },
                    { new Guid("895f6f0c-d118-4088-8e9b-6f5735c7d179"), null, null, "Beatrice.Gislason52@hotmail.com", null, null, "", null, null },
                    { new Guid("8abe36b0-cc67-45d2-871f-ebf7893b75d8"), null, null, "Alberto.Bashirian16@gmail.com", null, null, "", null, null },
                    { new Guid("8dedbfb1-5e2d-4154-9478-3d01257f1d7f"), null, null, "Perry33@yahoo.com", null, null, "", null, null },
                    { new Guid("9603ae28-386b-4159-9c86-3db095d6db9c"), null, null, "Elias.Kautzer@hotmail.com", null, null, "", null, null },
                    { new Guid("975633ec-5906-4605-9d2a-0b2ebb8c18c2"), null, null, "Yvonne_Brakus@hotmail.com", null, null, "", null, null },
                    { new Guid("9b5f67fb-66ef-479b-ba87-d4bb25177d73"), null, null, "Kyle59@gmail.com", null, null, "", null, null },
                    { new Guid("9b6b5bf9-c0b3-46a7-aa64-1f3a833e0939"), null, null, "Joshua10@gmail.com", null, null, "", null, null },
                    { new Guid("a14ae734-b7d9-44d9-895c-a916156ee1f5"), null, null, "Eugene_Gusikowski88@hotmail.com", null, null, "", null, null },
                    { new Guid("a1f35f5d-0b9a-4225-9f62-5b8f5c5cbcd5"), null, null, "Dianna90@gmail.com", null, null, "", null, null },
                    { new Guid("a2ca1d92-d6ea-4dff-83cd-197e8ee00c9d"), null, null, "Christopher79@gmail.com", null, null, "", null, null },
                    { new Guid("a2ee9441-1f57-41f5-bffa-9dead8b72eb5"), null, null, "Noel.Durgan@yahoo.com", null, null, "", null, null },
                    { new Guid("a5e4403c-9c98-4176-b389-b7b84afcf763"), null, null, "Roxanne64@hotmail.com", null, null, "", null, null },
                    { new Guid("ac2c1b2d-a8a5-4ec6-8148-86f7b8118d58"), null, null, "Andrew_Morissette82@hotmail.com", null, null, "", null, null },
                    { new Guid("ae16e228-50a0-4743-a492-8e48d7e81d44"), null, null, "Sonia_Maggio@hotmail.com", null, null, "", null, null },
                    { new Guid("af5480cb-5b4e-464f-9b6d-32450c932d29"), null, null, "Andrew.Hodkiewicz@gmail.com", null, null, "", null, null },
                    { new Guid("b66ee7ca-0ce7-44f3-ba8d-38eac5fcdc5b"), null, null, "Wayne_Hermann@gmail.com", null, null, "", null, null },
                    { new Guid("c4095df2-e34a-4ae4-8835-d736685e3600"), null, null, "Terrance_OConner68@hotmail.com", null, null, "", null, null },
                    { new Guid("c4b68f9b-316c-4082-917f-818ef01a7b8a"), null, null, "Danielle.Jaskolski26@yahoo.com", null, null, "", null, null },
                    { new Guid("c6605539-22bb-4f1f-8af0-f59d42f605ae"), null, null, "Kathleen.Kuhic@hotmail.com", null, null, "", null, null },
                    { new Guid("c6a8bc65-7249-4059-ae62-563ab122f937"), null, null, "Edward11@yahoo.com", null, null, "", null, null },
                    { new Guid("ccdf89ef-0864-46a9-a70b-8122784a8ea0"), null, null, "Julius50@gmail.com", null, null, "", null, null },
                    { new Guid("ce79681b-ad7c-4083-9b8e-010e08d17f2e"), null, null, "Hector_Parisian@yahoo.com", null, null, "", null, null },
                    { new Guid("d0998b46-bdf3-44d0-be0f-1b3259fc48ca"), null, null, "Kay.Moore20@yahoo.com", null, null, "", null, null },
                    { new Guid("d1f18213-2941-4380-9523-98742b59669a"), null, null, "Shaun.Cruickshank@gmail.com", null, null, "", null, null },
                    { new Guid("d3b61522-a181-4612-a59d-d33535e2d187"), null, null, "Myrtle.Hegmann@yahoo.com", null, null, "", null, null },
                    { new Guid("d5c38aff-0a13-4071-9c7d-28b3cc3485e5"), null, null, "Michele.Keebler13@hotmail.com", null, null, "", null, null },
                    { new Guid("d9e80907-d290-4939-9ac0-e4fa7f0ff4e8"), null, null, "Mitchell.Wehner@yahoo.com", null, null, "", null, null },
                    { new Guid("db23ba83-0ab4-4a3c-8a7f-409fb02fd5bb"), null, null, "Samuel33@hotmail.com", null, null, "", null, null },
                    { new Guid("dbbb282d-78bb-4299-8cfa-8582e765d478"), null, null, "Perry_Labadie@gmail.com", null, null, "", null, null },
                    { new Guid("dbcbf8f7-6ca2-4625-8828-b1e4c3f93eb0"), null, null, "Rosalie.Frami@hotmail.com", null, null, "", null, null },
                    { new Guid("de2f6c21-0cc6-4c58-956b-228bd43eeac9"), null, null, "Denise28@gmail.com", null, null, "", null, null },
                    { new Guid("df4cc918-9c4f-4668-994b-b835c72f9be1"), null, null, "Joey68@yahoo.com", null, null, "", null, null },
                    { new Guid("e470efd0-796d-45f1-b590-1a2a71f89a14"), null, null, "Emilio_Breitenberg50@gmail.com", null, null, "", null, null },
                    { new Guid("e9581e34-3e82-4834-b0f8-8ca088be55d2"), null, null, "Homer.Schuster68@yahoo.com", null, null, "", null, null },
                    { new Guid("f1f5b181-8e02-46ed-b728-8d840b3601a6"), null, null, "Evan57@hotmail.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("f333c4ce-589f-4f20-a57d-f00801d05960"), null, null, "Karl_Homenick@gmail.com", null, null, "", null, null },
                    { new Guid("f4c1448c-fdf0-4264-9f89-c76551d42955"), null, null, "Jamie9@yahoo.com", null, null, "", null, null },
                    { new Guid("f4cfd1ce-1897-43bb-b2f5-a1a8a014b5ee"), null, null, "Micheal23@hotmail.com", null, null, "", null, null },
                    { new Guid("f4f9e211-8ca3-4972-b8c4-589694ac9135"), null, null, "Tammy_Kihn10@gmail.com", null, null, "", null, null },
                    { new Guid("f7611d8a-8ece-4da8-8dbd-b6a8b51c6372"), null, null, "Tommie83@yahoo.com", null, null, "", null, null },
                    { new Guid("f7c9fe4d-3e54-4824-a811-8b799cc67fbb"), null, null, "Melissa41@gmail.com", null, null, "", null, null },
                    { new Guid("f8d8b1fc-f707-4e05-9209-ed9231cf01c1"), null, null, "Melvin62@yahoo.com", null, null, "", null, null },
                    { new Guid("fcc1b6c5-52d8-498a-96af-690add00c73f"), null, null, "Jane.Metz33@yahoo.com", null, null, "", null, null },
                    { new Guid("fcf7ebc2-20dc-4299-85ac-3acdd9517912"), null, null, "Fernando17@yahoo.com", null, null, "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherID", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Wilma_Parker48@gmail.com", "Wilma", false, "Parker", "1-920-351-4263 x517" },
                    { 2, "Terence.Kulas@gmail.com", "Terence", false, "Kulas", "775.433.6718 x20467" },
                    { 3, "Claire_King43@gmail.com", "Claire", false, "King", "731.620.3117 x605" },
                    { 4, "Lydia60@gmail.com", "Lydia", false, "Borer", "909-543-3818 x2880" },
                    { 5, "Elmer.Schamberger@yahoo.com", "Elmer", false, "Schamberger", "394-450-6891 x16721" },
                    { 6, "Mae.Price@yahoo.com", "Mae", false, "Price", "443.944.6369 x088" },
                    { 7, "Stewart99@gmail.com", "Stewart", false, "Bins", "397-890-2842 x17729" },
                    { 8, "Terrance12@hotmail.com", "Terrance", false, "Kshlerin", "829.488.0541 x098" },
                    { 9, "Jorge.Schoen@hotmail.com", "Jorge", false, "Schoen", "(942) 562-6122 x9065" },
                    { 10, "Willis.King@gmail.com", "Willis", false, "King", "867.946.4333" },
                    { 11, "Verna.Torphy@gmail.com", "Verna", false, "Torphy", "1-998-240-9820 x523" },
                    { 12, "Gerard_Walter37@hotmail.com", "Gerard", false, "Walter", "447.420.7851 x406" },
                    { 13, "Wilbert.Kovacek@yahoo.com", "Wilbert", false, "Kovacek", "331.535.7248 x8345" },
                    { 14, "Lorene67@hotmail.com", "Lorene", false, "Wuckert", "1-597-620-9588" },
                    { 15, "Jessie27@yahoo.com", "Jessie", false, "Padberg", "(741) 640-3261 x782" },
                    { 16, "Rochelle33@yahoo.com", "Rochelle", false, "Carter", "1-202-791-8535 x4902" },
                    { 17, "Sherry_Vandervort37@gmail.com", "Sherry", false, "Vandervort", "(983) 488-6124 x76499" },
                    { 18, "Salvador_Olson@gmail.com", "Salvador", false, "Olson", "(296) 224-3382 x41579" },
                    { 19, "Craig.Cruickshank@yahoo.com", "Craig", false, "Cruickshank", "(559) 579-1378" }
                });

            migrationBuilder.InsertData(
                table: "LessonApprove",
                columns: new[] { "LessonApproveID", "FK_ApproveID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 24, 1 },
                    { 2, 5, 2 },
                    { 3, 12, 3 },
                    { 4, 10, 4 },
                    { 5, 30, 5 },
                    { 6, 27, 6 },
                    { 7, 16, 7 },
                    { 8, 29, 8 },
                    { 9, 20, 9 },
                    { 10, 14, 10 },
                    { 11, 1, 11 },
                    { 12, 19, 12 },
                    { 13, 3, 13 },
                    { 14, 8, 14 },
                    { 15, 4, 15 },
                    { 16, 22, 16 },
                    { 17, 6, 17 },
                    { 18, 18, 18 },
                    { 19, 11, 19 },
                    { 20, 2, 20 },
                    { 21, 21, 21 },
                    { 22, 15, 22 },
                    { 23, 25, 23 },
                    { 24, 28, 24 },
                    { 25, 17, 25 },
                    { 26, 23, 26 },
                    { 27, 7, 27 },
                    { 28, 9, 28 },
                    { 29, 13, 29 },
                    { 30, 26, 30 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 1, 19, 1 },
                    { 2, 3, 2 },
                    { 3, 5, 3 },
                    { 4, 2, 4 },
                    { 5, 40, 5 },
                    { 6, 46, 6 },
                    { 7, 13, 7 },
                    { 8, 43, 8 },
                    { 9, 34, 9 },
                    { 10, 10, 10 },
                    { 11, 20, 11 },
                    { 12, 22, 12 }
                });

            migrationBuilder.InsertData(
                table: "LessonGrade",
                columns: new[] { "GradeLessonID", "FK_GradeID", "FK_LessonID" },
                values: new object[,]
                {
                    { 13, 23, 13 },
                    { 14, 45, 14 },
                    { 15, 44, 15 },
                    { 16, 24, 16 },
                    { 17, 18, 17 },
                    { 18, 41, 18 },
                    { 19, 47, 19 },
                    { 20, 31, 20 },
                    { 21, 25, 21 },
                    { 22, 29, 22 },
                    { 23, 12, 23 },
                    { 24, 1, 24 },
                    { 25, 37, 25 },
                    { 26, 35, 26 },
                    { 27, 27, 27 },
                    { 28, 32, 28 },
                    { 29, 7, 29 },
                    { 30, 16, 30 },
                    { 31, 15, 31 },
                    { 32, 4, 32 },
                    { 33, 28, 33 },
                    { 34, 48, 34 },
                    { 35, 33, 35 },
                    { 36, 49, 36 },
                    { 37, 38, 37 },
                    { 38, 8, 38 },
                    { 39, 30, 39 },
                    { 40, 21, 40 },
                    { 41, 11, 41 },
                    { 42, 17, 42 },
                    { 43, 9, 43 },
                    { 44, 6, 44 },
                    { 45, 39, 45 },
                    { 46, 42, 46 },
                    { 47, 26, 47 },
                    { 48, 36, 48 },
                    { 49, 14, 49 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 1, 1, 47 },
                    { 2, 2, 15 },
                    { 3, 3, 38 },
                    { 4, 4, 44 },
                    { 5, 5, 49 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 6, 6, 27 },
                    { 7, 7, 19 },
                    { 8, 8, 7 },
                    { 9, 9, 35 },
                    { 10, 10, 3 },
                    { 11, 11, 8 },
                    { 12, 12, 40 },
                    { 13, 13, 10 },
                    { 14, 14, 16 },
                    { 15, 15, 4 },
                    { 16, 16, 1 },
                    { 17, 17, 42 },
                    { 18, 18, 28 },
                    { 19, 19, 5 },
                    { 20, 20, 25 },
                    { 21, 21, 17 },
                    { 22, 22, 26 },
                    { 23, 23, 21 },
                    { 24, 24, 22 },
                    { 25, 25, 33 },
                    { 26, 26, 48 },
                    { 27, 27, 9 },
                    { 28, 28, 2 },
                    { 29, 29, 14 },
                    { 30, 30, 34 },
                    { 31, 31, 46 },
                    { 32, 32, 30 },
                    { 33, 33, 11 },
                    { 34, 34, 37 },
                    { 35, 35, 39 },
                    { 36, 36, 32 },
                    { 37, 37, 6 },
                    { 38, 38, 45 },
                    { 39, 39, 24 },
                    { 40, 40, 31 },
                    { 41, 41, 13 },
                    { 42, 42, 41 },
                    { 43, 43, 12 },
                    { 44, 44, 36 },
                    { 45, 45, 43 },
                    { 46, 46, 29 },
                    { 47, 47, 18 }
                });

            migrationBuilder.InsertData(
                table: "LessonMark",
                columns: new[] { "LessonMarkID", "FK_LessonID", "FK_MarkID" },
                values: new object[,]
                {
                    { 48, 48, 23 },
                    { 49, 49, 20 }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 2, new Guid("0225c85e-90d9-4e05-9789-17ed96d37ba6") },
                    { 2, 6, new Guid("7fcce17d-edfd-48a2-81e5-6e31b1f05c13") },
                    { 3, 6, new Guid("81e9d812-abfe-4704-b30c-458a11e6a70b") },
                    { 4, 4, new Guid("6873322e-38e2-4a1a-b3f5-c053189b1c5a") },
                    { 5, 5, new Guid("e9581e34-3e82-4834-b0f8-8ca088be55d2") },
                    { 6, 6, new Guid("5d0b59cd-2728-49b4-b384-1437157f9312") },
                    { 7, 3, new Guid("56c570fc-8c5f-41d1-b81b-1be1f35140ec") },
                    { 8, 4, new Guid("9b5f67fb-66ef-479b-ba87-d4bb25177d73") },
                    { 9, 9, new Guid("db23ba83-0ab4-4a3c-8a7f-409fb02fd5bb") },
                    { 10, 5, new Guid("f7611d8a-8ece-4da8-8dbd-b6a8b51c6372") },
                    { 11, 3, new Guid("21665a27-f6b0-44e4-8362-5861dbc67945") },
                    { 12, 9, new Guid("23618f27-8122-406f-8531-da1f27e78acb") },
                    { 13, 9, new Guid("481faa6c-3b29-47c5-bde0-eb5e9c060b23") },
                    { 14, 1, new Guid("015de306-ea97-406d-bdde-8ae679dea4d4") },
                    { 15, 5, new Guid("de2f6c21-0cc6-4c58-956b-228bd43eeac9") },
                    { 16, 8, new Guid("f7c9fe4d-3e54-4824-a811-8b799cc67fbb") },
                    { 17, 8, new Guid("6bd2d173-3252-454e-b808-a68dff674586") },
                    { 18, 3, new Guid("f4c1448c-fdf0-4264-9f89-c76551d42955") },
                    { 19, 3, new Guid("3e9c228b-992a-493d-83a4-7dde56afa02c") },
                    { 20, 9, new Guid("4a970ef1-a9f2-4ab4-b181-06e1ebd0ce2a") },
                    { 21, 7, new Guid("a1f35f5d-0b9a-4225-9f62-5b8f5c5cbcd5") },
                    { 22, 1, new Guid("d3b61522-a181-4612-a59d-d33535e2d187") },
                    { 23, 4, new Guid("8453f48a-7b2d-452a-ac90-17e0641577d3") },
                    { 24, 1, new Guid("0a7d9590-232d-4671-80e4-f9184e615d06") },
                    { 25, 2, new Guid("ae16e228-50a0-4743-a492-8e48d7e81d44") },
                    { 26, 8, new Guid("975633ec-5906-4605-9d2a-0b2ebb8c18c2") },
                    { 27, 5, new Guid("8abe36b0-cc67-45d2-871f-ebf7893b75d8") },
                    { 28, 3, new Guid("c4095df2-e34a-4ae4-8835-d736685e3600") },
                    { 29, 2, new Guid("84ca8db1-b237-4750-9325-69520282a2ca") },
                    { 30, 7, new Guid("ce79681b-ad7c-4083-9b8e-010e08d17f2e") },
                    { 31, 5, new Guid("415f27e6-a41f-46a1-ac38-0fbf86e8a1d5") },
                    { 32, 3, new Guid("fcf7ebc2-20dc-4299-85ac-3acdd9517912") },
                    { 33, 2, new Guid("d1f18213-2941-4380-9523-98742b59669a") },
                    { 34, 1, new Guid("71cb75e3-70e5-4d7e-a64d-d53805d99668") },
                    { 35, 1, new Guid("44b15ea8-f419-4102-a64a-2db2b5a0aa8f") },
                    { 36, 2, new Guid("86e1265b-a688-4d33-b14b-1528072cfaad") },
                    { 37, 4, new Guid("67aae709-f0b5-408a-8158-52e834961d26") },
                    { 38, 1, new Guid("dbcbf8f7-6ca2-4625-8828-b1e4c3f93eb0") },
                    { 39, 2, new Guid("0c5cd5d4-f659-4a8e-ac78-e4570f11ed42") },
                    { 40, 5, new Guid("47f3e468-070b-420d-b118-92da80a01e46") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 41, 7, new Guid("9603ae28-386b-4159-9c86-3db095d6db9c") },
                    { 42, 7, new Guid("a2ee9441-1f57-41f5-bffa-9dead8b72eb5") },
                    { 43, 5, new Guid("77232b63-846b-40b2-b75b-588e11ab9f56") },
                    { 44, 3, new Guid("210f1bba-bace-4243-a288-2a73c45f5fac") },
                    { 45, 1, new Guid("63510290-a92c-41de-a616-b6c11f6c49cf") },
                    { 46, 4, new Guid("d9e80907-d290-4939-9ac0-e4fa7f0ff4e8") },
                    { 47, 2, new Guid("c6a8bc65-7249-4059-ae62-563ab122f937") },
                    { 48, 4, new Guid("c6605539-22bb-4f1f-8af0-f59d42f605ae") },
                    { 49, 8, new Guid("73247590-367b-4818-b5a5-e0536567c69b") },
                    { 50, 2, new Guid("9b6b5bf9-c0b3-46a7-aa64-1f3a833e0939") },
                    { 51, 6, new Guid("d0998b46-bdf3-44d0-be0f-1b3259fc48ca") },
                    { 52, 7, new Guid("2ff5dc15-af57-4d39-b427-70fc98fbbbb4") },
                    { 53, 9, new Guid("e470efd0-796d-45f1-b590-1a2a71f89a14") },
                    { 54, 1, new Guid("ac2c1b2d-a8a5-4ec6-8148-86f7b8118d58") },
                    { 55, 5, new Guid("4ff7814f-ae30-4979-9724-143ab3dddc76") },
                    { 56, 1, new Guid("af5480cb-5b4e-464f-9b6d-32450c932d29") },
                    { 57, 3, new Guid("36daf101-56c5-4162-93fe-5ed4157f9344") },
                    { 58, 2, new Guid("5e0a2509-13ef-44c7-8f18-5ece1f593b2d") },
                    { 59, 8, new Guid("6259697b-df90-4743-96e1-02bd1da4508d") },
                    { 60, 6, new Guid("0464327d-440b-49d2-a3a1-9957708037da") },
                    { 61, 9, new Guid("d5c38aff-0a13-4071-9c7d-28b3cc3485e5") },
                    { 62, 8, new Guid("c4b68f9b-316c-4082-917f-818ef01a7b8a") },
                    { 63, 4, new Guid("a5e4403c-9c98-4176-b389-b7b84afcf763") },
                    { 64, 1, new Guid("234da0a1-ac49-452c-9186-fd31c2ff7f2d") },
                    { 65, 9, new Guid("f333c4ce-589f-4f20-a57d-f00801d05960") },
                    { 66, 4, new Guid("8dedbfb1-5e2d-4154-9478-3d01257f1d7f") },
                    { 67, 6, new Guid("a2ca1d92-d6ea-4dff-83cd-197e8ee00c9d") },
                    { 68, 4, new Guid("5cd98324-fe46-4980-9954-d6d5f7276021") },
                    { 69, 5, new Guid("f1f5b181-8e02-46ed-b728-8d840b3601a6") },
                    { 70, 6, new Guid("09d0f383-83fb-4c94-a9cc-6ac398eeca9c") },
                    { 71, 3, new Guid("618181a4-70f5-4c49-9fcc-301bb5027e8d") },
                    { 72, 4, new Guid("35f1caf9-08f3-4d44-9fe7-6bee89312942") },
                    { 73, 6, new Guid("317b6cf8-2375-488b-9c4a-81e29ed8a9b8") },
                    { 74, 5, new Guid("02925ed1-cc80-4e59-9aee-b4c4cd2299b5") },
                    { 75, 2, new Guid("a14ae734-b7d9-44d9-895c-a916156ee1f5") },
                    { 76, 3, new Guid("25885572-7dc2-4faf-b53e-0f39d6685d2c") },
                    { 77, 4, new Guid("3d1fba97-c557-4631-a1ab-5c037f4ca055") },
                    { 78, 1, new Guid("895f6f0c-d118-4088-8e9b-6f5735c7d179") },
                    { 79, 6, new Guid("f4cfd1ce-1897-43bb-b2f5-a1a8a014b5ee") },
                    { 80, 3, new Guid("5523881e-2337-4aef-939c-cce25509a216") },
                    { 81, 1, new Guid("22929aa0-aff3-42a7-8ec6-757ffdba820d") },
                    { 82, 9, new Guid("f4f9e211-8ca3-4972-b8c4-589694ac9135") }
                });

            migrationBuilder.InsertData(
                table: "PersonClass",
                columns: new[] { "UserClassID", "FK_ClassID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 83, 7, new Guid("2621aa1e-0c55-40b7-ab7f-94fd32e517c4") },
                    { 84, 9, new Guid("775b920b-b809-4b9e-9580-2593e2ec306b") },
                    { 85, 8, new Guid("163fab97-3928-4b48-8de7-3ec49e4a39e7") },
                    { 86, 8, new Guid("0529083b-4689-45d8-a0d7-049520c854f9") },
                    { 87, 1, new Guid("50342add-c11b-4761-814c-7780a0423649") },
                    { 88, 9, new Guid("52c2b7e9-8feb-446b-a330-41cedfa3794d") },
                    { 89, 2, new Guid("dbbb282d-78bb-4299-8cfa-8582e765d478") },
                    { 90, 8, new Guid("df4cc918-9c4f-4668-994b-b835c72f9be1") },
                    { 91, 4, new Guid("682b662a-3f1c-472c-a206-941063f58411") },
                    { 92, 5, new Guid("fcc1b6c5-52d8-498a-96af-690add00c73f") },
                    { 93, 7, new Guid("848ace5c-42ea-4d90-92f9-bae6dd8c96fb") },
                    { 94, 1, new Guid("60fda660-96e3-465c-8c53-3ff1898cae7b") },
                    { 95, 1, new Guid("5c2bf0be-2f71-43cc-af7f-8e112b55a813") },
                    { 96, 4, new Guid("339db9e6-4ecf-4ea5-96d5-505b645ed3ca") },
                    { 97, 1, new Guid("b66ee7ca-0ce7-44f3-ba8d-38eac5fcdc5b") },
                    { 98, 5, new Guid("f8d8b1fc-f707-4e05-9209-ed9231cf01c1") },
                    { 99, 6, new Guid("470a064e-b5e7-485d-9326-e588e9326abd") },
                    { 100, 1, new Guid("ccdf89ef-0864-46a9-a70b-8122784a8ea0") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("0225c85e-90d9-4e05-9789-17ed96d37ba6") },
                    { 2, 2, new Guid("7fcce17d-edfd-48a2-81e5-6e31b1f05c13") },
                    { 3, 3, new Guid("81e9d812-abfe-4704-b30c-458a11e6a70b") },
                    { 4, 4, new Guid("6873322e-38e2-4a1a-b3f5-c053189b1c5a") },
                    { 5, 5, new Guid("e9581e34-3e82-4834-b0f8-8ca088be55d2") },
                    { 6, 6, new Guid("5d0b59cd-2728-49b4-b384-1437157f9312") },
                    { 7, 7, new Guid("56c570fc-8c5f-41d1-b81b-1be1f35140ec") },
                    { 8, 8, new Guid("9b5f67fb-66ef-479b-ba87-d4bb25177d73") },
                    { 9, 9, new Guid("db23ba83-0ab4-4a3c-8a7f-409fb02fd5bb") },
                    { 10, 10, new Guid("f7611d8a-8ece-4da8-8dbd-b6a8b51c6372") },
                    { 11, 11, new Guid("21665a27-f6b0-44e4-8362-5861dbc67945") },
                    { 12, 12, new Guid("23618f27-8122-406f-8531-da1f27e78acb") },
                    { 13, 13, new Guid("481faa6c-3b29-47c5-bde0-eb5e9c060b23") },
                    { 14, 14, new Guid("015de306-ea97-406d-bdde-8ae679dea4d4") },
                    { 15, 15, new Guid("de2f6c21-0cc6-4c58-956b-228bd43eeac9") },
                    { 16, 16, new Guid("f7c9fe4d-3e54-4824-a811-8b799cc67fbb") },
                    { 17, 17, new Guid("6bd2d173-3252-454e-b808-a68dff674586") },
                    { 18, 18, new Guid("f4c1448c-fdf0-4264-9f89-c76551d42955") },
                    { 19, 19, new Guid("3e9c228b-992a-493d-83a4-7dde56afa02c") },
                    { 20, 20, new Guid("4a970ef1-a9f2-4ab4-b181-06e1ebd0ce2a") },
                    { 21, 21, new Guid("a1f35f5d-0b9a-4225-9f62-5b8f5c5cbcd5") },
                    { 22, 22, new Guid("d3b61522-a181-4612-a59d-d33535e2d187") },
                    { 23, 23, new Guid("8453f48a-7b2d-452a-ac90-17e0641577d3") },
                    { 24, 24, new Guid("0a7d9590-232d-4671-80e4-f9184e615d06") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 25, 25, new Guid("ae16e228-50a0-4743-a492-8e48d7e81d44") },
                    { 26, 26, new Guid("975633ec-5906-4605-9d2a-0b2ebb8c18c2") },
                    { 27, 27, new Guid("8abe36b0-cc67-45d2-871f-ebf7893b75d8") },
                    { 28, 28, new Guid("c4095df2-e34a-4ae4-8835-d736685e3600") },
                    { 29, 29, new Guid("84ca8db1-b237-4750-9325-69520282a2ca") },
                    { 30, 30, new Guid("ce79681b-ad7c-4083-9b8e-010e08d17f2e") },
                    { 31, 31, new Guid("415f27e6-a41f-46a1-ac38-0fbf86e8a1d5") },
                    { 32, 32, new Guid("fcf7ebc2-20dc-4299-85ac-3acdd9517912") },
                    { 33, 33, new Guid("d1f18213-2941-4380-9523-98742b59669a") },
                    { 34, 34, new Guid("71cb75e3-70e5-4d7e-a64d-d53805d99668") },
                    { 35, 35, new Guid("44b15ea8-f419-4102-a64a-2db2b5a0aa8f") },
                    { 36, 36, new Guid("86e1265b-a688-4d33-b14b-1528072cfaad") },
                    { 37, 37, new Guid("67aae709-f0b5-408a-8158-52e834961d26") },
                    { 38, 38, new Guid("dbcbf8f7-6ca2-4625-8828-b1e4c3f93eb0") },
                    { 39, 39, new Guid("0c5cd5d4-f659-4a8e-ac78-e4570f11ed42") },
                    { 40, 40, new Guid("47f3e468-070b-420d-b118-92da80a01e46") },
                    { 41, 41, new Guid("9603ae28-386b-4159-9c86-3db095d6db9c") },
                    { 42, 42, new Guid("a2ee9441-1f57-41f5-bffa-9dead8b72eb5") },
                    { 43, 43, new Guid("77232b63-846b-40b2-b75b-588e11ab9f56") },
                    { 44, 44, new Guid("210f1bba-bace-4243-a288-2a73c45f5fac") },
                    { 45, 45, new Guid("63510290-a92c-41de-a616-b6c11f6c49cf") },
                    { 46, 46, new Guid("d9e80907-d290-4939-9ac0-e4fa7f0ff4e8") },
                    { 47, 47, new Guid("c6a8bc65-7249-4059-ae62-563ab122f937") },
                    { 48, 48, new Guid("c6605539-22bb-4f1f-8af0-f59d42f605ae") },
                    { 49, 49, new Guid("73247590-367b-4818-b5a5-e0536567c69b") },
                    { 50, 50, new Guid("9b6b5bf9-c0b3-46a7-aa64-1f3a833e0939") },
                    { 51, 51, new Guid("d0998b46-bdf3-44d0-be0f-1b3259fc48ca") },
                    { 52, 52, new Guid("2ff5dc15-af57-4d39-b427-70fc98fbbbb4") },
                    { 53, 53, new Guid("e470efd0-796d-45f1-b590-1a2a71f89a14") },
                    { 54, 54, new Guid("ac2c1b2d-a8a5-4ec6-8148-86f7b8118d58") },
                    { 55, 55, new Guid("4ff7814f-ae30-4979-9724-143ab3dddc76") },
                    { 56, 56, new Guid("af5480cb-5b4e-464f-9b6d-32450c932d29") },
                    { 57, 57, new Guid("36daf101-56c5-4162-93fe-5ed4157f9344") },
                    { 58, 58, new Guid("5e0a2509-13ef-44c7-8f18-5ece1f593b2d") },
                    { 59, 59, new Guid("6259697b-df90-4743-96e1-02bd1da4508d") },
                    { 60, 60, new Guid("0464327d-440b-49d2-a3a1-9957708037da") },
                    { 61, 61, new Guid("d5c38aff-0a13-4071-9c7d-28b3cc3485e5") },
                    { 62, 62, new Guid("c4b68f9b-316c-4082-917f-818ef01a7b8a") },
                    { 63, 63, new Guid("a5e4403c-9c98-4176-b389-b7b84afcf763") },
                    { 64, 64, new Guid("234da0a1-ac49-452c-9186-fd31c2ff7f2d") },
                    { 65, 65, new Guid("f333c4ce-589f-4f20-a57d-f00801d05960") },
                    { 66, 66, new Guid("8dedbfb1-5e2d-4154-9478-3d01257f1d7f") }
                });

            migrationBuilder.InsertData(
                table: "PersonParent",
                columns: new[] { "PersonParentID", "FK_ParentID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 67, 67, new Guid("a2ca1d92-d6ea-4dff-83cd-197e8ee00c9d") },
                    { 68, 68, new Guid("5cd98324-fe46-4980-9954-d6d5f7276021") },
                    { 69, 69, new Guid("f1f5b181-8e02-46ed-b728-8d840b3601a6") },
                    { 70, 70, new Guid("09d0f383-83fb-4c94-a9cc-6ac398eeca9c") },
                    { 71, 71, new Guid("618181a4-70f5-4c49-9fcc-301bb5027e8d") },
                    { 72, 72, new Guid("35f1caf9-08f3-4d44-9fe7-6bee89312942") },
                    { 73, 73, new Guid("317b6cf8-2375-488b-9c4a-81e29ed8a9b8") },
                    { 74, 74, new Guid("02925ed1-cc80-4e59-9aee-b4c4cd2299b5") },
                    { 75, 75, new Guid("a14ae734-b7d9-44d9-895c-a916156ee1f5") },
                    { 76, 76, new Guid("25885572-7dc2-4faf-b53e-0f39d6685d2c") },
                    { 77, 77, new Guid("3d1fba97-c557-4631-a1ab-5c037f4ca055") },
                    { 78, 78, new Guid("895f6f0c-d118-4088-8e9b-6f5735c7d179") },
                    { 79, 79, new Guid("f4cfd1ce-1897-43bb-b2f5-a1a8a014b5ee") },
                    { 80, 80, new Guid("5523881e-2337-4aef-939c-cce25509a216") },
                    { 81, 81, new Guid("22929aa0-aff3-42a7-8ec6-757ffdba820d") },
                    { 82, 82, new Guid("f4f9e211-8ca3-4972-b8c4-589694ac9135") },
                    { 83, 83, new Guid("2621aa1e-0c55-40b7-ab7f-94fd32e517c4") },
                    { 84, 84, new Guid("775b920b-b809-4b9e-9580-2593e2ec306b") },
                    { 85, 85, new Guid("163fab97-3928-4b48-8de7-3ec49e4a39e7") },
                    { 86, 86, new Guid("0529083b-4689-45d8-a0d7-049520c854f9") },
                    { 87, 87, new Guid("50342add-c11b-4761-814c-7780a0423649") },
                    { 88, 88, new Guid("52c2b7e9-8feb-446b-a330-41cedfa3794d") },
                    { 89, 89, new Guid("dbbb282d-78bb-4299-8cfa-8582e765d478") },
                    { 90, 90, new Guid("df4cc918-9c4f-4668-994b-b835c72f9be1") },
                    { 91, 91, new Guid("682b662a-3f1c-472c-a206-941063f58411") },
                    { 92, 92, new Guid("fcc1b6c5-52d8-498a-96af-690add00c73f") },
                    { 93, 93, new Guid("848ace5c-42ea-4d90-92f9-bae6dd8c96fb") },
                    { 94, 94, new Guid("60fda660-96e3-465c-8c53-3ff1898cae7b") },
                    { 95, 95, new Guid("5c2bf0be-2f71-43cc-af7f-8e112b55a813") },
                    { 96, 96, new Guid("339db9e6-4ecf-4ea5-96d5-505b645ed3ca") },
                    { 97, 97, new Guid("b66ee7ca-0ce7-44f3-ba8d-38eac5fcdc5b") },
                    { 98, 98, new Guid("f8d8b1fc-f707-4e05-9209-ed9231cf01c1") },
                    { 99, 99, new Guid("470a064e-b5e7-485d-9326-e588e9326abd") },
                    { 100, 100, new Guid("ccdf89ef-0864-46a9-a70b-8122784a8ea0") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("0225c85e-90d9-4e05-9789-17ed96d37ba6") },
                    { 2, 1, new Guid("7fcce17d-edfd-48a2-81e5-6e31b1f05c13") },
                    { 3, 1, new Guid("81e9d812-abfe-4704-b30c-458a11e6a70b") },
                    { 4, 1, new Guid("6873322e-38e2-4a1a-b3f5-c053189b1c5a") },
                    { 5, 1, new Guid("e9581e34-3e82-4834-b0f8-8ca088be55d2") },
                    { 6, 1, new Guid("5d0b59cd-2728-49b4-b384-1437157f9312") },
                    { 7, 1, new Guid("56c570fc-8c5f-41d1-b81b-1be1f35140ec") },
                    { 8, 1, new Guid("9b5f67fb-66ef-479b-ba87-d4bb25177d73") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 9, 1, new Guid("db23ba83-0ab4-4a3c-8a7f-409fb02fd5bb") },
                    { 10, 1, new Guid("f7611d8a-8ece-4da8-8dbd-b6a8b51c6372") },
                    { 11, 1, new Guid("21665a27-f6b0-44e4-8362-5861dbc67945") },
                    { 12, 1, new Guid("23618f27-8122-406f-8531-da1f27e78acb") },
                    { 13, 1, new Guid("481faa6c-3b29-47c5-bde0-eb5e9c060b23") },
                    { 14, 1, new Guid("015de306-ea97-406d-bdde-8ae679dea4d4") },
                    { 15, 1, new Guid("de2f6c21-0cc6-4c58-956b-228bd43eeac9") },
                    { 16, 1, new Guid("f7c9fe4d-3e54-4824-a811-8b799cc67fbb") },
                    { 17, 1, new Guid("6bd2d173-3252-454e-b808-a68dff674586") },
                    { 18, 1, new Guid("f4c1448c-fdf0-4264-9f89-c76551d42955") },
                    { 19, 1, new Guid("3e9c228b-992a-493d-83a4-7dde56afa02c") },
                    { 20, 1, new Guid("4a970ef1-a9f2-4ab4-b181-06e1ebd0ce2a") },
                    { 21, 1, new Guid("a1f35f5d-0b9a-4225-9f62-5b8f5c5cbcd5") },
                    { 22, 1, new Guid("d3b61522-a181-4612-a59d-d33535e2d187") },
                    { 23, 1, new Guid("8453f48a-7b2d-452a-ac90-17e0641577d3") },
                    { 24, 1, new Guid("0a7d9590-232d-4671-80e4-f9184e615d06") },
                    { 25, 1, new Guid("ae16e228-50a0-4743-a492-8e48d7e81d44") },
                    { 26, 1, new Guid("975633ec-5906-4605-9d2a-0b2ebb8c18c2") },
                    { 27, 1, new Guid("8abe36b0-cc67-45d2-871f-ebf7893b75d8") },
                    { 28, 1, new Guid("c4095df2-e34a-4ae4-8835-d736685e3600") },
                    { 29, 1, new Guid("84ca8db1-b237-4750-9325-69520282a2ca") },
                    { 30, 1, new Guid("ce79681b-ad7c-4083-9b8e-010e08d17f2e") },
                    { 31, 1, new Guid("415f27e6-a41f-46a1-ac38-0fbf86e8a1d5") },
                    { 32, 1, new Guid("fcf7ebc2-20dc-4299-85ac-3acdd9517912") },
                    { 33, 1, new Guid("d1f18213-2941-4380-9523-98742b59669a") },
                    { 34, 1, new Guid("71cb75e3-70e5-4d7e-a64d-d53805d99668") },
                    { 35, 1, new Guid("44b15ea8-f419-4102-a64a-2db2b5a0aa8f") },
                    { 36, 1, new Guid("86e1265b-a688-4d33-b14b-1528072cfaad") },
                    { 37, 1, new Guid("67aae709-f0b5-408a-8158-52e834961d26") },
                    { 38, 1, new Guid("dbcbf8f7-6ca2-4625-8828-b1e4c3f93eb0") },
                    { 39, 1, new Guid("0c5cd5d4-f659-4a8e-ac78-e4570f11ed42") },
                    { 40, 1, new Guid("47f3e468-070b-420d-b118-92da80a01e46") },
                    { 41, 1, new Guid("9603ae28-386b-4159-9c86-3db095d6db9c") },
                    { 42, 1, new Guid("a2ee9441-1f57-41f5-bffa-9dead8b72eb5") },
                    { 43, 1, new Guid("77232b63-846b-40b2-b75b-588e11ab9f56") },
                    { 44, 1, new Guid("210f1bba-bace-4243-a288-2a73c45f5fac") },
                    { 45, 1, new Guid("63510290-a92c-41de-a616-b6c11f6c49cf") },
                    { 46, 1, new Guid("d9e80907-d290-4939-9ac0-e4fa7f0ff4e8") },
                    { 47, 1, new Guid("c6a8bc65-7249-4059-ae62-563ab122f937") },
                    { 48, 1, new Guid("c6605539-22bb-4f1f-8af0-f59d42f605ae") },
                    { 49, 1, new Guid("73247590-367b-4818-b5a5-e0536567c69b") },
                    { 50, 1, new Guid("9b6b5bf9-c0b3-46a7-aa64-1f3a833e0939") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 51, 1, new Guid("d0998b46-bdf3-44d0-be0f-1b3259fc48ca") },
                    { 52, 1, new Guid("2ff5dc15-af57-4d39-b427-70fc98fbbbb4") },
                    { 53, 1, new Guid("e470efd0-796d-45f1-b590-1a2a71f89a14") },
                    { 54, 1, new Guid("ac2c1b2d-a8a5-4ec6-8148-86f7b8118d58") },
                    { 55, 1, new Guid("4ff7814f-ae30-4979-9724-143ab3dddc76") },
                    { 56, 1, new Guid("af5480cb-5b4e-464f-9b6d-32450c932d29") },
                    { 57, 1, new Guid("36daf101-56c5-4162-93fe-5ed4157f9344") },
                    { 58, 1, new Guid("5e0a2509-13ef-44c7-8f18-5ece1f593b2d") },
                    { 59, 1, new Guid("6259697b-df90-4743-96e1-02bd1da4508d") },
                    { 60, 1, new Guid("0464327d-440b-49d2-a3a1-9957708037da") },
                    { 61, 1, new Guid("d5c38aff-0a13-4071-9c7d-28b3cc3485e5") },
                    { 62, 1, new Guid("c4b68f9b-316c-4082-917f-818ef01a7b8a") },
                    { 63, 1, new Guid("a5e4403c-9c98-4176-b389-b7b84afcf763") },
                    { 64, 1, new Guid("234da0a1-ac49-452c-9186-fd31c2ff7f2d") },
                    { 65, 1, new Guid("f333c4ce-589f-4f20-a57d-f00801d05960") },
                    { 66, 1, new Guid("8dedbfb1-5e2d-4154-9478-3d01257f1d7f") },
                    { 67, 1, new Guid("a2ca1d92-d6ea-4dff-83cd-197e8ee00c9d") },
                    { 68, 1, new Guid("5cd98324-fe46-4980-9954-d6d5f7276021") },
                    { 69, 1, new Guid("f1f5b181-8e02-46ed-b728-8d840b3601a6") },
                    { 70, 1, new Guid("09d0f383-83fb-4c94-a9cc-6ac398eeca9c") },
                    { 71, 1, new Guid("618181a4-70f5-4c49-9fcc-301bb5027e8d") },
                    { 72, 1, new Guid("35f1caf9-08f3-4d44-9fe7-6bee89312942") },
                    { 73, 1, new Guid("317b6cf8-2375-488b-9c4a-81e29ed8a9b8") },
                    { 74, 1, new Guid("02925ed1-cc80-4e59-9aee-b4c4cd2299b5") },
                    { 75, 1, new Guid("a14ae734-b7d9-44d9-895c-a916156ee1f5") },
                    { 76, 1, new Guid("25885572-7dc2-4faf-b53e-0f39d6685d2c") },
                    { 77, 1, new Guid("3d1fba97-c557-4631-a1ab-5c037f4ca055") },
                    { 78, 1, new Guid("895f6f0c-d118-4088-8e9b-6f5735c7d179") },
                    { 79, 1, new Guid("f4cfd1ce-1897-43bb-b2f5-a1a8a014b5ee") },
                    { 80, 1, new Guid("5523881e-2337-4aef-939c-cce25509a216") },
                    { 81, 1, new Guid("22929aa0-aff3-42a7-8ec6-757ffdba820d") },
                    { 82, 1, new Guid("f4f9e211-8ca3-4972-b8c4-589694ac9135") },
                    { 83, 1, new Guid("2621aa1e-0c55-40b7-ab7f-94fd32e517c4") },
                    { 84, 1, new Guid("775b920b-b809-4b9e-9580-2593e2ec306b") },
                    { 85, 1, new Guid("163fab97-3928-4b48-8de7-3ec49e4a39e7") },
                    { 86, 1, new Guid("0529083b-4689-45d8-a0d7-049520c854f9") },
                    { 87, 1, new Guid("50342add-c11b-4761-814c-7780a0423649") },
                    { 88, 1, new Guid("52c2b7e9-8feb-446b-a330-41cedfa3794d") },
                    { 89, 1, new Guid("dbbb282d-78bb-4299-8cfa-8582e765d478") },
                    { 90, 1, new Guid("df4cc918-9c4f-4668-994b-b835c72f9be1") },
                    { 91, 1, new Guid("682b662a-3f1c-472c-a206-941063f58411") },
                    { 92, 1, new Guid("fcc1b6c5-52d8-498a-96af-690add00c73f") }
                });

            migrationBuilder.InsertData(
                table: "PersonRole",
                columns: new[] { "PersonRoleID", "FK_RoleID", "FK_UserUUID" },
                values: new object[,]
                {
                    { 93, 1, new Guid("848ace5c-42ea-4d90-92f9-bae6dd8c96fb") },
                    { 94, 1, new Guid("60fda660-96e3-465c-8c53-3ff1898cae7b") },
                    { 95, 1, new Guid("5c2bf0be-2f71-43cc-af7f-8e112b55a813") },
                    { 96, 1, new Guid("339db9e6-4ecf-4ea5-96d5-505b645ed3ca") },
                    { 97, 1, new Guid("b66ee7ca-0ce7-44f3-ba8d-38eac5fcdc5b") },
                    { 98, 1, new Guid("f8d8b1fc-f707-4e05-9209-ed9231cf01c1") },
                    { 99, 1, new Guid("470a064e-b5e7-485d-9326-e588e9326abd") },
                    { 100, 1, new Guid("ccdf89ef-0864-46a9-a70b-8122784a8ea0") }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 1, 1, 3, 12 },
                    { 2, 2, 10, 12 },
                    { 3, 3, 10, 14 },
                    { 4, 4, 7, 2 },
                    { 5, 5, 1, 10 },
                    { 6, 6, 5, 15 },
                    { 7, 7, 4, 3 },
                    { 8, 8, 4, 7 },
                    { 9, 9, 10, 4 },
                    { 10, 10, 4, 4 },
                    { 11, 11, 1, 11 },
                    { 12, 12, 6, 10 },
                    { 13, 13, 4, 2 },
                    { 14, 14, 9, 3 },
                    { 15, 15, 8, 2 },
                    { 16, 16, 10, 1 },
                    { 17, 17, 6, 7 },
                    { 18, 18, 2, 3 },
                    { 19, 19, 5, 6 },
                    { 20, 20, 3, 12 },
                    { 21, 21, 9, 12 },
                    { 22, 22, 6, 3 },
                    { 23, 23, 5, 11 },
                    { 24, 24, 10, 18 },
                    { 25, 25, 3, 2 },
                    { 26, 26, 7, 11 },
                    { 27, 27, 3, 8 },
                    { 28, 28, 5, 1 },
                    { 29, 29, 10, 1 },
                    { 30, 30, 4, 8 },
                    { 31, 31, 8, 17 },
                    { 32, 32, 6, 16 },
                    { 33, 33, 5, 11 },
                    { 34, 34, 9, 7 },
                    { 35, 35, 6, 16 },
                    { 36, 36, 5, 1 },
                    { 37, 37, 6, 4 },
                    { 38, 38, 4, 14 },
                    { 39, 39, 2, 6 },
                    { 40, 40, 5, 13 },
                    { 41, 41, 7, 6 },
                    { 42, 42, 9, 17 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectID", "FK_LessonID", "FK_PersonClass", "FK_TeacherID" },
                values: new object[,]
                {
                    { 43, 43, 6, 16 },
                    { 44, 44, 5, 8 },
                    { 45, 45, 7, 6 },
                    { 46, 46, 4, 4 },
                    { 47, 47, 7, 6 },
                    { 48, 48, 6, 13 },
                    { 49, 49, 2, 6 }
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
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "TeacherID",
                keyValue: 9);

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
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Class",
                keyColumn: "ClassID",
                keyValue: 8);

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
                keyValue: new Guid("015de306-ea97-406d-bdde-8ae679dea4d4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("02925ed1-cc80-4e59-9aee-b4c4cd2299b5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0464327d-440b-49d2-a3a1-9957708037da"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0529083b-4689-45d8-a0d7-049520c854f9"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("09d0f383-83fb-4c94-a9cc-6ac398eeca9c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0a7d9590-232d-4671-80e4-f9184e615d06"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0c5cd5d4-f659-4a8e-ac78-e4570f11ed42"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("163fab97-3928-4b48-8de7-3ec49e4a39e7"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("210f1bba-bace-4243-a288-2a73c45f5fac"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("21665a27-f6b0-44e4-8362-5861dbc67945"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("22929aa0-aff3-42a7-8ec6-757ffdba820d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("234da0a1-ac49-452c-9186-fd31c2ff7f2d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("23618f27-8122-406f-8531-da1f27e78acb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("25885572-7dc2-4faf-b53e-0f39d6685d2c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2621aa1e-0c55-40b7-ab7f-94fd32e517c4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2ff5dc15-af57-4d39-b427-70fc98fbbbb4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("317b6cf8-2375-488b-9c4a-81e29ed8a9b8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("339db9e6-4ecf-4ea5-96d5-505b645ed3ca"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("35f1caf9-08f3-4d44-9fe7-6bee89312942"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("36daf101-56c5-4162-93fe-5ed4157f9344"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3d1fba97-c557-4631-a1ab-5c037f4ca055"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("3e9c228b-992a-493d-83a4-7dde56afa02c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("415f27e6-a41f-46a1-ac38-0fbf86e8a1d5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("44b15ea8-f419-4102-a64a-2db2b5a0aa8f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("470a064e-b5e7-485d-9326-e588e9326abd"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("47f3e468-070b-420d-b118-92da80a01e46"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("481faa6c-3b29-47c5-bde0-eb5e9c060b23"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4a970ef1-a9f2-4ab4-b181-06e1ebd0ce2a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("4ff7814f-ae30-4979-9724-143ab3dddc76"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("50342add-c11b-4761-814c-7780a0423649"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("52c2b7e9-8feb-446b-a330-41cedfa3794d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5523881e-2337-4aef-939c-cce25509a216"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5c2bf0be-2f71-43cc-af7f-8e112b55a813"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5cd98324-fe46-4980-9954-d6d5f7276021"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5e0a2509-13ef-44c7-8f18-5ece1f593b2d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("60fda660-96e3-465c-8c53-3ff1898cae7b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("618181a4-70f5-4c49-9fcc-301bb5027e8d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6259697b-df90-4743-96e1-02bd1da4508d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("63510290-a92c-41de-a616-b6c11f6c49cf"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("67aae709-f0b5-408a-8158-52e834961d26"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("682b662a-3f1c-472c-a206-941063f58411"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6bd2d173-3252-454e-b808-a68dff674586"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("71cb75e3-70e5-4d7e-a64d-d53805d99668"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("73247590-367b-4818-b5a5-e0536567c69b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("77232b63-846b-40b2-b75b-588e11ab9f56"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("775b920b-b809-4b9e-9580-2593e2ec306b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8453f48a-7b2d-452a-ac90-17e0641577d3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("848ace5c-42ea-4d90-92f9-bae6dd8c96fb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("84ca8db1-b237-4750-9325-69520282a2ca"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("86e1265b-a688-4d33-b14b-1528072cfaad"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("895f6f0c-d118-4088-8e9b-6f5735c7d179"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8abe36b0-cc67-45d2-871f-ebf7893b75d8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("8dedbfb1-5e2d-4154-9478-3d01257f1d7f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9603ae28-386b-4159-9c86-3db095d6db9c"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("975633ec-5906-4605-9d2a-0b2ebb8c18c2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9b6b5bf9-c0b3-46a7-aa64-1f3a833e0939"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a14ae734-b7d9-44d9-895c-a916156ee1f5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a1f35f5d-0b9a-4225-9f62-5b8f5c5cbcd5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a2ca1d92-d6ea-4dff-83cd-197e8ee00c9d"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a2ee9441-1f57-41f5-bffa-9dead8b72eb5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("a5e4403c-9c98-4176-b389-b7b84afcf763"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ac2c1b2d-a8a5-4ec6-8148-86f7b8118d58"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ae16e228-50a0-4743-a492-8e48d7e81d44"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("af5480cb-5b4e-464f-9b6d-32450c932d29"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("b66ee7ca-0ce7-44f3-ba8d-38eac5fcdc5b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c4095df2-e34a-4ae4-8835-d736685e3600"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c4b68f9b-316c-4082-917f-818ef01a7b8a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c6605539-22bb-4f1f-8af0-f59d42f605ae"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("c6a8bc65-7249-4059-ae62-563ab122f937"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ccdf89ef-0864-46a9-a70b-8122784a8ea0"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("ce79681b-ad7c-4083-9b8e-010e08d17f2e"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d0998b46-bdf3-44d0-be0f-1b3259fc48ca"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d1f18213-2941-4380-9523-98742b59669a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d3b61522-a181-4612-a59d-d33535e2d187"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d5c38aff-0a13-4071-9c7d-28b3cc3485e5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("d9e80907-d290-4939-9ac0-e4fa7f0ff4e8"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("dbbb282d-78bb-4299-8cfa-8582e765d478"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("dbcbf8f7-6ca2-4625-8828-b1e4c3f93eb0"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("de2f6c21-0cc6-4c58-956b-228bd43eeac9"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("df4cc918-9c4f-4668-994b-b835c72f9be1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e470efd0-796d-45f1-b590-1a2a71f89a14"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f1f5b181-8e02-46ed-b728-8d840b3601a6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f333c4ce-589f-4f20-a57d-f00801d05960"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f4c1448c-fdf0-4264-9f89-c76551d42955"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f4cfd1ce-1897-43bb-b2f5-a1a8a014b5ee"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f4f9e211-8ca3-4972-b8c4-589694ac9135"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f7c9fe4d-3e54-4824-a811-8b799cc67fbb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f8d8b1fc-f707-4e05-9209-ed9231cf01c1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fcc1b6c5-52d8-498a-96af-690add00c73f"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("fcf7ebc2-20dc-4299-85ac-3acdd9517912"));

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
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("0225c85e-90d9-4e05-9789-17ed96d37ba6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("56c570fc-8c5f-41d1-b81b-1be1f35140ec"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("5d0b59cd-2728-49b4-b384-1437157f9312"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("6873322e-38e2-4a1a-b3f5-c053189b1c5a"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("7fcce17d-edfd-48a2-81e5-6e31b1f05c13"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("81e9d812-abfe-4704-b30c-458a11e6a70b"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("9b5f67fb-66ef-479b-ba87-d4bb25177d73"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("db23ba83-0ab4-4a3c-8a7f-409fb02fd5bb"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("e9581e34-3e82-4834-b0f8-8ca088be55d2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("f7611d8a-8ece-4da8-8dbd-b6a8b51c6372"));

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
