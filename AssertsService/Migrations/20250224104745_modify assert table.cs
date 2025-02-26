using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class modifyasserttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterAsserts");

            migrationBuilder.DropTable(
                name: "SubAssets");

            migrationBuilder.DropColumn(
                name: "MasterAssertId",
                table: "AssertRegisters");

            migrationBuilder.RenameColumn(
                name: "SubAssetId",
                table: "AssertRegisters",
                newName: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AssertRegisters",
                newName: "SubAssetId");

            migrationBuilder.AddColumn<int>(
                name: "MasterAssertId",
                table: "AssertRegisters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MasterAsserts",
                columns: table => new
                {
                    MasterAssertId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterAssertName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterAsserts", x => x.MasterAssertId);
                });

            migrationBuilder.CreateTable(
                name: "SubAssets",
                columns: table => new
                {
                    SubAssetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterAssertId = table.Column<int>(type: "int", nullable: false),
                    SubAssetName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAssets", x => x.SubAssetId);
                });
        }
    }
}
