using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class modifyaddusertable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserDetails");
        }
    }
}
