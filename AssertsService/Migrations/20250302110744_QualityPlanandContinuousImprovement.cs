using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class QualityPlanandContinuousImprovement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QualityPlanandContinuousImprovements",
                columns: table => new
                {
                    QualityPlanandContinuousImprovementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requirement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YesPartiallyNo = table.Column<short>(type: "smallint", nullable: false),
                    AttachLogFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Reasons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipalId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityPlanandContinuousImprovements", x => x.QualityPlanandContinuousImprovementId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QualityPlanandContinuousImprovements");
        }
    }
}
