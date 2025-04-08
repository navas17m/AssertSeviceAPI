using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class demochanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activity",
                table: "WorkforceManagements");

            migrationBuilder.DropColumn(
                name: "Baseline",
                table: "KeyPerformanceIndicators");

            migrationBuilder.DropColumn(
                name: "ComingThrough",
                table: "KeyPerformanceIndicators");

            migrationBuilder.DropColumn(
                name: "KeyPerformanceIndicatorName",
                table: "KeyPerformanceIndicators");

            migrationBuilder.DropColumn(
                name: "Activity",
                table: "ComplianceAndRegulatorys");

            migrationBuilder.DropColumn(
                name: "MaintenanceManagementStyle",
                table: "BudgetPlans");

            migrationBuilder.DropColumn(
                name: "MaintenanceStrategy",
                table: "BudgetPlans");

            migrationBuilder.AddColumn<int>(
                name: "WorkforceManagementActivityId",
                table: "WorkforceManagements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KeyPerformanceIndicatorNameId",
                table: "KeyPerformanceIndicators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComplianceAndRegulatoryActivityId",
                table: "ComplianceAndRegulatorys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaintenanceManagementStyleId",
                table: "BudgetPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaintenanceStrategyId",
                table: "BudgetPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalEstimatedCost",
                table: "BudgetPlans",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ComplianceAndRegulatoryActivitys",
                columns: table => new
                {
                    ComplianceAndRegulatoryActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplianceAndRegulatoryActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceAndRegulatoryActivitys", x => x.ComplianceAndRegulatoryActivityId);
                });

            migrationBuilder.CreateTable(
                name: "KeyPerformanceIndicatorNames",
                columns: table => new
                {
                    KeyPerformanceIndicatorNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyPerformanceIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyPerformanceIndicatorNames", x => x.KeyPerformanceIndicatorNameId);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceManagementStyles",
                columns: table => new
                {
                    MaintenanceManagementStyleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceManagementStyleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceManagementStyles", x => x.MaintenanceManagementStyleId);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceStrategies",
                columns: table => new
                {
                    MaintenanceStrategyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceStrategyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceStrategies", x => x.MaintenanceStrategyId);
                });

            migrationBuilder.CreateTable(
                name: "WorkforceManagementActivities",
                columns: table => new
                {
                    WorkforceManagementActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkforceManagementActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkforceManagementActivities", x => x.WorkforceManagementActivityId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplianceAndRegulatoryActivitys");

            migrationBuilder.DropTable(
                name: "KeyPerformanceIndicatorNames");

            migrationBuilder.DropTable(
                name: "MaintenanceManagementStyles");

            migrationBuilder.DropTable(
                name: "MaintenanceStrategies");

            migrationBuilder.DropTable(
                name: "WorkforceManagementActivities");

            migrationBuilder.DropColumn(
                name: "WorkforceManagementActivityId",
                table: "WorkforceManagements");

            migrationBuilder.DropColumn(
                name: "KeyPerformanceIndicatorNameId",
                table: "KeyPerformanceIndicators");

            migrationBuilder.DropColumn(
                name: "ComplianceAndRegulatoryActivityId",
                table: "ComplianceAndRegulatorys");

            migrationBuilder.DropColumn(
                name: "MaintenanceManagementStyleId",
                table: "BudgetPlans");

            migrationBuilder.DropColumn(
                name: "MaintenanceStrategyId",
                table: "BudgetPlans");

            migrationBuilder.DropColumn(
                name: "TotalEstimatedCost",
                table: "BudgetPlans");

            migrationBuilder.AddColumn<string>(
                name: "Activity",
                table: "WorkforceManagements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Baseline",
                table: "KeyPerformanceIndicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComingThrough",
                table: "KeyPerformanceIndicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyPerformanceIndicatorName",
                table: "KeyPerformanceIndicators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Activity",
                table: "ComplianceAndRegulatorys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaintenanceManagementStyle",
                table: "BudgetPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaintenanceStrategy",
                table: "BudgetPlans",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
