using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    public partial class updatedb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    ParentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.ParentID);
                });

            migrationBuilder.CreateTable(
                name: "PersonParent",
                columns: table => new
                {
                    PersonParentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_UserUUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonParent", x => x.PersonParentID);
                    table.ForeignKey(
                        name: "FK_PersonParent_Parent_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Parent",
                        principalColumn: "ParentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonParent_Person_FK_UserUUID",
                        column: x => x.FK_UserUUID,
                        principalTable: "Person",
                        principalColumn: "UserUUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "UserUUID", "Address", "City", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "ZipCode" },
                values: new object[] { new Guid("2a5a6c19-e060-4b68-970a-14bcf84ceeb6"), null, null, "test@test.com", null, null, "AQAAAAEAACcQAAAAEM8IgGU60dYUZXFF4fWVllbhM1VogG7n9FIvQ0okw0zxoEEzlreBklgK8AmWKqRI0g==", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_PersonParent_FK_UserUUID",
                table: "PersonParent",
                column: "FK_UserUUID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonParent_ParentID",
                table: "PersonParent",
                column: "ParentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonParent");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "UserUUID",
                keyValue: new Guid("2a5a6c19-e060-4b68-970a-14bcf84ceeb6"));
        }
    }
}
