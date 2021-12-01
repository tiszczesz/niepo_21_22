using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3tig_MySql1Net.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsersTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lastname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOf = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTable", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "UsersTable",
                columns: new[] { "Id", "DateOf", "Firstname", "Lastname" },
                values: new object[] { 1, new DateTime(2012, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antoni", "Małecki" });

            migrationBuilder.InsertData(
                table: "UsersTable",
                columns: new[] { "Id", "DateOf", "Firstname", "Lastname" },
                values: new object[] { 2, new DateTime(2012, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monika", "Dworek" });

            migrationBuilder.InsertData(
                table: "UsersTable",
                columns: new[] { "Id", "DateOf", "Firstname", "Lastname" },
                values: new object[] { 3, new DateTime(2009, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomasz", "Bomasz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersTable");
        }
    }
}
