using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3tisp_school1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudentId);
                    table.ForeignKey(
                        name: "FK_Students_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "GradeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "GradeName", "Section" },
                values: new object[,]
                {
                    { 1, "celujący", "Informatyka" },
                    { 2, "dobry", "Informatyka" },
                    { 3, "dostateczny", "Informatyka" },
                    { 4, "bardzo dobry", "Informatyka" },
                    { 5, "dopuszczający", "Informatyka" },
                    { 6, "niedostateczny", "Informatyka" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "IdStudentId", "DateOfBirth", "GradeId", "Height", "Photo", "StudentName", "Weight" },
                values: new object[,]
                {
                    { 4, new DateTime(1999, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 178m, null, "Urszula", 89.9f },
                    { 2, new DateTime(2005, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 178m, null, "Monika", 89.9f },
                    { 3, new DateTime(2007, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 178m, null, "Tomasz", 89.9f },
                    { 1, new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 178m, null, "Roman", 89.9f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradeId",
                table: "Students",
                column: "GradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Grades");
        }
    }
}
