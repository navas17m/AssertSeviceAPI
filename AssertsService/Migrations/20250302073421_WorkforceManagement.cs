using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class WorkforceManagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComplianceAndRegulatorys",
                columns: table => new
                {
                    ComplianceAndRegulatoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YesOrNo = table.Column<bool>(type: "bit", nullable: false),
                    BriefDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitingReasons = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceAndRegulatorys", x => x.ComplianceAndRegulatoryId);
                });

            migrationBuilder.CreateTable(
                name: "WorkforceManagements",
                columns: table => new
                {
                    WorkforceManagementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YesOrNo = table.Column<bool>(type: "bit", nullable: false),
                    BriefDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitingReasons = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkforceManagements", x => x.WorkforceManagementId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplianceAndRegulatorys");

            migrationBuilder.DropTable(
                name: "WorkforceManagements");
        }
    }
}
