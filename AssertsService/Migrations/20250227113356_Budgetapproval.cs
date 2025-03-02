using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class Budgetapproval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BudgetApprovals",
                columns: table => new
                {
                    BudgetApprovalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipalId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BudgetApprovals = table.Column<bool>(type: "bit", nullable: false),
                    BudgetApprovalReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitoringBudgetImplementation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodicReports = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyModifications = table.Column<bool>(type: "bit", nullable: false),
                    EmergencyModificationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BudgetDisparity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BudgetDisparityAction = table.Column<bool>(type: "bit", nullable: false),
                    BudgetDisparityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetApprovals", x => x.BudgetApprovalId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetApprovals");
        }
    }
}
