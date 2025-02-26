using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class modifysubasserttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MasterAssertId",
                table: "SubAssets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MasterAssertId",
                table: "SubAssets");
        }
    }
}
