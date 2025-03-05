using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class Maintancesubtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeriodicMaintenances",
                columns: table => new
                {
                    PeriodicMaintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodicMaintenanceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodicMaintenances", x => x.PeriodicMaintenanceId);
                });

            migrationBuilder.CreateTable(
                name: "PriorityOfWorks",
                columns: table => new
                {
                    PriorityOfWorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriorityOfWorkName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriorityOfWorks", x => x.PriorityOfWorkId);
                });

            migrationBuilder.CreateTable(
                name: "TypeofScheduledMaintenances",
                columns: table => new
                {
                    TypeofScheduledMaintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeofScheduledMaintenanceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeofScheduledMaintenances", x => x.TypeofScheduledMaintenanceId);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrderStatuses",
                columns: table => new
                {
                    WorkOrderStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkOrderStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrderStatuses", x => x.WorkOrderStatusId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeriodicMaintenances");

            migrationBuilder.DropTable(
                name: "PriorityOfWorks");

            migrationBuilder.DropTable(
                name: "TypeofScheduledMaintenances");

            migrationBuilder.DropTable(
                name: "WorkOrderStatuses");
        }
    }
}
