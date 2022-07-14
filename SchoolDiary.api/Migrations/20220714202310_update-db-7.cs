using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2017f210-3bae-4642-a8e4-fb2c879f0e20"));

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassID);
                });

            migrationBuilder.CreateTable(
                name: "UserClass",
                columns: table => new
                {
                    UserClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_UserUUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_ClassID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClass", x => x.UserClassID);
                    table.ForeignKey(
                        name: "FK_UserClass_Class_FK_ClassID",
                        column: x => x.FK_ClassID,
                        principalTable: "Class",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserClass_Person_FK_UserUUID",
                        column: x => x.FK_UserUUID,
                        principalTable: "Person",
                        principalColumn: "UserUUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserClass_FK_ClassID",
                table: "UserClass",
                column: "FK_ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_UserClass_FK_UserUUID",
                table: "UserClass",
                column: "FK_UserUUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserClass");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[] { new Guid("2017f210-3bae-4642-a8e4-fb2c879f0e20"), null, null, "test@test.com", null, null, "AQAAAAEAACcQAAAAEKagpYTaF6bqrs3Uufuuk2W90+hfPoz5uVR11oFOOvbx9rIMWML4udQCEtyaPNPY6Q==", null, null });
        }
    }
}
