using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleSqLite1_gim.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Owner = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gifts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "Id", "Name", "Owner", "Price" },
                values: new object[] { 1, "Samochodzik czerwony", "Adaś Małecki", 12.67m });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "Id", "Name", "Owner", "Price" },
                values: new object[] { 2, "Laleczka", "Dominika Małecka", 52.67m });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "Id", "Name", "Owner", "Price" },
                values: new object[] { 3, "Słodycze", "Maria Małecka", 23.99m });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "Id", "Name", "Owner", "Price" },
                values: new object[] { 4, "Płyn do znieczulania", "Tomasz Małecki", 80.67m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gifts");
        }
    }
}
