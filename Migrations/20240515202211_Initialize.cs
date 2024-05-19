using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameShop.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Developer", "ImageFileName", "Name", "Price", "Publisher", "ReleaseDate", "Type" },
                values: new object[,]
                {
                    { 1, "FromSoftware", "EldenRing.jpg", "Elden_Ring", 1300m, "FromSoftware,Bandai Namco Entertainment", 2022, "Action" },
                    { 2, "Valve", "Portal.jpg", "Portal_2", 150m, "Valve", 2011, "Puzzle" },
                    { 3, "Supergiant Games", "Hades.jpg", "Hades", 250m, "Supergiant Games", 2020, "Roguelike" },
                    { 4, "One More Level,3D Realms", "Ghostrunner.jpg", "Ghostrunner", 480m, "505 Games", 2020, "Action" },
                    { 5, "FromSoftware", "Sekiro.jpg", "Sekiro", 1800m, "Activision,FromSoftware", 2019, "Action" },
                    { 6, "Bethesda Game Studios", "Skyrim.jpg", "The_Elder_Scrolls_V_Skyrim", 720m, "Bethesda Softworks", 2016, "Adventure" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
