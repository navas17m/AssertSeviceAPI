using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class subassert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asserts",
                columns: table => new
                {
                    AssertId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssertName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asserts", x => x.AssertId);
                });

            migrationBuilder.CreateTable(
                name: "SubAsserts",
                columns: table => new
                {
                    SubAssertId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubAssertName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAsserts", x => x.SubAssertId);
                });

            migrationBuilder.CreateTable(
                name: "SubMunicipals",
                columns: table => new
                {
                    SubMunicipalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubMunicipalName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMunicipals", x => x.SubMunicipalId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asserts");

            migrationBuilder.DropTable(
                name: "SubAsserts");

            migrationBuilder.DropTable(
                name: "SubMunicipals");
        }
    }
}
