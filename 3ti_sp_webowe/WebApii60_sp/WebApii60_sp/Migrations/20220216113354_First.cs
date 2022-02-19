using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApii60_sp.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CreateDate", "Director", "Title" },
                values: new object[] { 1, new DateTime(2010, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomasz Bomasz", "Szeregowiec Ryan" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CreateDate", "Director", "Title" },
                values: new object[] { 2, new DateTime(2010, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Helena Melena", "Gwiezdne wojny 1" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CreateDate", "Director", "Title" },
                values: new object[] { 3, new DateTime(2010, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomasz Małecki", "Gwiezdne wojny 2" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CreateDate", "Director", "Title" },
                values: new object[] { 4, new DateTime(2008, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna Wanna", "Gwinea" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CreateDate", "Director", "Title" },
                values: new object[] { 5, new DateTime(1990, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman Polański", "Wojna i Pokój" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CreateDate", "Director", "Title" },
                values: new object[] { 6, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agta Bałata", "Najnowszy Film" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
