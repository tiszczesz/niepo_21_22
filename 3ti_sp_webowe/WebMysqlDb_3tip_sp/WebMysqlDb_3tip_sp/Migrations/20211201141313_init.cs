using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMysqlDb_3tip_sp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Author = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Author", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Tomasz Bomasz", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samo zło" },
                    { 2, "Maurycy Murzecki", new DateTime(2009, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rybacy" },
                    { 3, "Monika Małecka", new DateTime(2004, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wisna" },
                    { 4, "Egeniusz Pawlikowski", new DateTime(2013, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nie wiem" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
