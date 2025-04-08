using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class workordercolumadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actualcostsofmaintenance",
                table: "MaintenanceActivitys");

            migrationBuilder.AddColumn<decimal>(
                name: "HRCost",
                table: "MaintenanceActivitys",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HRMaterialCost",
                table: "MaintenanceActivitys",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MaintenanceCost",
                table: "MaintenanceActivitys",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OtherCost",
                table: "MaintenanceActivitys",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HRCost",
                table: "MaintenanceActivitys");

            migrationBuilder.DropColumn(
                name: "HRMaterialCost",
                table: "MaintenanceActivitys");

            migrationBuilder.DropColumn(
                name: "MaintenanceCost",
                table: "MaintenanceActivitys");

            migrationBuilder.DropColumn(
                name: "OtherCost",
                table: "MaintenanceActivitys");

            migrationBuilder.AddColumn<string>(
                name: "Actualcostsofmaintenance",
                table: "MaintenanceActivitys",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
