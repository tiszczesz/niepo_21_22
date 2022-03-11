using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFormsSqLite1.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bakeries",
                columns: table => new
                {
                    BakeryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakeries", x => x.BakeryId);
                });

            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    CakeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    BakeryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cakes", x => x.CakeId);
                    table.ForeignKey(
                        name: "FK_Cakes_Bakeries_BakeryId",
                        column: x => x.BakeryId,
                        principalTable: "Bakeries",
                        principalColumn: "BakeryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bakeries",
                columns: new[] { "BakeryId", "Address", "Name" },
                values: new object[] { 1, "Nowy Sącz 32-222", "Piekarnia sądecka" });

            migrationBuilder.InsertData(
                table: "Bakeries",
                columns: new[] { "BakeryId", "Address", "Name" },
                values: new object[] { 2, "Kraków 31-222", "Piekarz i Spółka" });

            migrationBuilder.InsertData(
                table: "Bakeries",
                columns: new[] { "BakeryId", "Address", "Name" },
                values: new object[] { 3, "Bochnia 34-333", "Staropolska Piekarnia" });

            migrationBuilder.InsertData(
                table: "Bakeries",
                columns: new[] { "BakeryId", "Address", "Name" },
                values: new object[] { 4, "Kraków 31-233", "Wypieki własne" });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "BakeryId", "Description", "Name", "Price" },
                values: new object[] { 1, 1, "długi opis piekarni", "Mały Hiszpan", 2.66m });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "BakeryId", "Description", "Name", "Price" },
                values: new object[] { 2, 1, "długi opis piekarni", "Rolada mała", 12.99m });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "BakeryId", "Description", "Name", "Price" },
                values: new object[] { 3, 2, "długi opis piekarni", "Pączek średni", 0.99m });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "BakeryId", "Description", "Name", "Price" },
                values: new object[] { 4, 2, "długi opis piekarni", "Torcik wenecki", 8.99m });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "BakeryId", "Description", "Name", "Price" },
                values: new object[] { 5, 3, "długi opis piekarni", "Drożdżowe ciastko", 1.66m });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "BakeryId", "Description", "Name", "Price" },
                values: new object[] { 6, 3, "długi opis piekarni", "Tort średni", 7.66m });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "BakeryId", "Description", "Name", "Price" },
                values: new object[] { 7, 3, "długi opis piekarni", "Faworki", 12.89m });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "BakeryId", "Description", "Name", "Price" },
                values: new object[] { 8, 4, "długi opis piekarni", "Napoleon", 3.99m });

            migrationBuilder.CreateIndex(
                name: "IX_Cakes_BakeryId",
                table: "Cakes",
                column: "BakeryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cakes");

            migrationBuilder.DropTable(
                name: "Bakeries");
        }
    }
}
