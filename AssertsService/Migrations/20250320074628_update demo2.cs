using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssertsService.Migrations
{
    /// <inheritdoc />
    public partial class updatedemo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Actualcostsofmaintenance",
                table: "MaintenanceActivitys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Actualtimetakenformaintenance",
                table: "MaintenanceActivitys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UploadId",
                table: "BudgetPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UploadId",
                table: "BudgetApprovals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfInspection",
                table: "AssertRegisters",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UploadEvidenseId",
                table: "AssertRegisters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UploadEvidenseId1",
                table: "AssertRegisters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actualcostsofmaintenance",
                table: "MaintenanceActivitys");

            migrationBuilder.DropColumn(
                name: "Actualtimetakenformaintenance",
                table: "MaintenanceActivitys");

            migrationBuilder.DropColumn(
                name: "UploadId",
                table: "BudgetPlans");

            migrationBuilder.DropColumn(
                name: "UploadId",
                table: "BudgetApprovals");

            migrationBuilder.DropColumn(
                name: "DateOfInspection",
                table: "AssertRegisters");

            migrationBuilder.DropColumn(
                name: "UploadEvidenseId",
                table: "AssertRegisters");

            migrationBuilder.DropColumn(
                name: "UploadEvidenseId1",
                table: "AssertRegisters");
        }
    }
}
