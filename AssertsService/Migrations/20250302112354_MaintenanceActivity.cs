using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class MaintenanceActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaintenanceActivitys",
                columns: table => new
                {
                    MaintenanceActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipalId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Maintenancemanagementstyle = table.Column<bool>(type: "bit", nullable: false),
                    Workordernumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeofscheduledmaintenanceId = table.Column<int>(type: "int", nullable: false),
                    Dateoflastmaintenance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nextmaintenancedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeriodicmaintenanceId = table.Column<int>(type: "int", nullable: false),
                    Workorderissuedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Maintenancestartdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Maintenancecompletiondate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PriorityofworkId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resources = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estimatinglaborcosts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approvals = table.Column<bool>(type: "bit", nullable: false),
                    WorkorderstatusId = table.Column<int>(type: "int", nullable: false),
                    Postmaintenance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceActivitys", x => x.MaintenanceActivityId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaintenanceActivitys");
        }
    }
}
