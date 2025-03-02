using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class KeyPerformanceIndicator1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyPerformanceIndicatorCategorys",
                columns: table => new
                {
                    KeyPerformanceIndicatorCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyPerformanceIndicatorCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyPerformanceIndicatorCategorys", x => x.KeyPerformanceIndicatorCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "KeyPerformanceIndicators",
                columns: table => new
                {
                    KeyPerformanceIndicatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipalId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    KeyPerformanceIndicatorCategorylId = table.Column<int>(type: "int", nullable: false),
                    KeyPerformanceIndicatorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baseline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComingThrough = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyPerformanceIndicators", x => x.KeyPerformanceIndicatorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeyPerformanceIndicatorCategorys");

            migrationBuilder.DropTable(
                name: "KeyPerformanceIndicators");
        }
    }
}
