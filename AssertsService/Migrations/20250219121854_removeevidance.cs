using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class removeevidance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "AssertRegisters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "AssertRegisters",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
