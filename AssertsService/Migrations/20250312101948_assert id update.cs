using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class assertidupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MunicipalId",
                table: "UserDetails");

            migrationBuilder.AddColumn<int>(
                name: "SubMunicipalId",
                table: "WorkforceManagements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubMunicipalId",
                table: "RiskManagementandContingencyPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubMunicipalId",
                table: "QualityPlanandContinuousImprovements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubMunicipalId",
                table: "MaintenanceActivitys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubMunicipalId",
                table: "KeyPerformanceIndicators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubMunicipalId",
                table: "ComplianceAndRegulatorys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubMunicipalId",
                table: "BudgetPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubMunicipalId",
                table: "BudgetApprovals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssertId",
                table: "AssertRegisters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubAssertId",
                table: "AssertRegisters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubMunicipalId",
                table: "AssertRegisters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubMunicipalId",
                table: "WorkforceManagements");

            migrationBuilder.DropColumn(
                name: "SubMunicipalId",
                table: "RiskManagementandContingencyPlans");

            migrationBuilder.DropColumn(
                name: "SubMunicipalId",
                table: "QualityPlanandContinuousImprovements");

            migrationBuilder.DropColumn(
                name: "SubMunicipalId",
                table: "MaintenanceActivitys");

            migrationBuilder.DropColumn(
                name: "SubMunicipalId",
                table: "KeyPerformanceIndicators");

            migrationBuilder.DropColumn(
                name: "SubMunicipalId",
                table: "ComplianceAndRegulatorys");

            migrationBuilder.DropColumn(
                name: "SubMunicipalId",
                table: "BudgetPlans");

            migrationBuilder.DropColumn(
                name: "SubMunicipalId",
                table: "BudgetApprovals");

            migrationBuilder.DropColumn(
                name: "AssertId",
                table: "AssertRegisters");

            migrationBuilder.DropColumn(
                name: "SubAssertId",
                table: "AssertRegisters");

            migrationBuilder.DropColumn(
                name: "SubMunicipalId",
                table: "AssertRegisters");

            migrationBuilder.AddColumn<int>(
                name: "MunicipalId",
                table: "UserDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
