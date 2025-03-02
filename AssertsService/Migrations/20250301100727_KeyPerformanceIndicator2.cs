using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class KeyPerformanceIndicator2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KeyPerformanceIndicatorCategorylId",
                table: "KeyPerformanceIndicators",
                newName: "KeyPerformanceIndicatorCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KeyPerformanceIndicatorCategoryId",
                table: "KeyPerformanceIndicators",
                newName: "KeyPerformanceIndicatorCategorylId");
        }
    }
}
