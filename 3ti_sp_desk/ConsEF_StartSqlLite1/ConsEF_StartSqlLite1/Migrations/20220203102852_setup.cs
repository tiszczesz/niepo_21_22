using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsEF_StartSqlLite1.Migrations
{
    public partial class setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { 1, "kwitowa 12/7", "Adam", "Nowak" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { 2, "kwitowa 12/7", "Monika", "Nowak" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { 3, "Długa 16/1", "Tomasz", "Bomasz" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { 4, "Grochowa 12/7", "Roman", "Tomera" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
