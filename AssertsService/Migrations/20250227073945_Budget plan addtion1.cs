using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class Budgetplanaddtion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BudgetPlans",
                columns: table => new
                {
                    BudgetPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipalId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MaintenanceManagementStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintenanceStrategy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaterialCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EquipmentCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdministrativeCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OperationalCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AllocationEmergencyEudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimationOfMaintenance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewGistoricalData = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetPlans", x => x.BudgetPlanId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetPlans");
        }
    }
}
