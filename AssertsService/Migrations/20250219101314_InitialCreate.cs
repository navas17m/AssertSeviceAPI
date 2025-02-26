using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssertRegisters",
                columns: table => new
                {
                    AssertRegisterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipalId = table.Column<int>(type: "int", nullable: false),
                    MasterAssertId = table.Column<int>(type: "int", nullable: false),
                    SubAssetId = table.Column<int>(type: "int", nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoordinatesX = table.Column<int>(type: "int", nullable: false),
                    CoordinatesY = table.Column<int>(type: "int", nullable: false),
                    GoogleMapsLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfPurchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfLastInspection = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccidentLog = table.Column<bool>(type: "bit", nullable: false),
                    StrategyLastMaintenanceId = table.Column<int>(type: "int", nullable: false),
                    AssetStatusId = table.Column<int>(type: "int", nullable: false),
                    UtilizationRateId = table.Column<int>(type: "int", nullable: false),
                    FrequentProblems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HistoricalCostsOfMaintenance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuaranteeExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PriorityId = table.Column<int>(type: "int", nullable: false),
                    MaintenanceContractForAsset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evidence = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssertRegisters", x => x.AssertRegisterId);
                });

            migrationBuilder.CreateTable(
                name: "AssetStatus",
                columns: table => new
                {
                    AssetStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetStatus", x => x.AssetStatusId);
                });

            migrationBuilder.CreateTable(
                name: "LastMaintenanceStrategies",
                columns: table => new
                {
                    LastMaintenanceStrategyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastMaintenanceStrategyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastMaintenanceStrategies", x => x.LastMaintenanceStrategyId);
                });

            migrationBuilder.CreateTable(
                name: "MasterAsserts",
                columns: table => new
                {
                    MasterAssertId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterAssertName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterAsserts", x => x.MasterAssertId);
                });

            migrationBuilder.CreateTable(
                name: "Municipals",
                columns: table => new
                {
                    MunicipalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipalName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipals", x => x.MunicipalId);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    PriorityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriorityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.PriorityId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "SubAssets",
                columns: table => new
                {
                    SubAssetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubAssetName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAssets", x => x.SubAssetId);
                });

            migrationBuilder.CreateTable(
                name: "UtilizationRates",
                columns: table => new
                {
                    UtilizationRatesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilizationRate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilizationRates", x => x.UtilizationRatesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssertRegisters");

            migrationBuilder.DropTable(
                name: "AssetStatus");

            migrationBuilder.DropTable(
                name: "LastMaintenanceStrategies");

            migrationBuilder.DropTable(
                name: "MasterAsserts");

            migrationBuilder.DropTable(
                name: "Municipals");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "SubAssets");

            migrationBuilder.DropTable(
                name: "UtilizationRates");
        }
    }
}
