using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class Upload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachLogFile",
                table: "RiskManagementandContingencyPlans");

            migrationBuilder.DropColumn(
                name: "AttachLogFile",
                table: "QualityPlanandContinuousImprovements");

            migrationBuilder.AddColumn<int>(
                name: "UploadId",
                table: "RiskManagementandContingencyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UploadId",
                table: "QualityPlanandContinuousImprovements",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UploadId",
                table: "RiskManagementandContingencyPlans");

            migrationBuilder.DropColumn(
                name: "UploadId",
                table: "QualityPlanandContinuousImprovements");

            migrationBuilder.AddColumn<byte[]>(
                name: "AttachLogFile",
                table: "RiskManagementandContingencyPlans",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "AttachLogFile",
                table: "QualityPlanandContinuousImprovements",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
