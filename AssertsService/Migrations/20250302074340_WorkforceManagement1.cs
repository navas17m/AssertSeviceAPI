using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class WorkforceManagement1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "WorkforceManagements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MunicipalId",
                table: "WorkforceManagements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "WorkforceManagements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ComplianceAndRegulatorys",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MunicipalId",
                table: "ComplianceAndRegulatorys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ComplianceAndRegulatorys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "WorkforceManagements");

            migrationBuilder.DropColumn(
                name: "MunicipalId",
                table: "WorkforceManagements");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "WorkforceManagements");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ComplianceAndRegulatorys");

            migrationBuilder.DropColumn(
                name: "MunicipalId",
                table: "ComplianceAndRegulatorys");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ComplianceAndRegulatorys");
        }
    }
}
