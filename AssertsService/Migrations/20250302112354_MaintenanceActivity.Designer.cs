﻿// <auto-generated />
using System;
using AssertsService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssertsService.Migrations
{
    [DbContext(typeof(AssertDBContext))]
    [Migration("20250302112354_MaintenanceActivity")]
    partial class MaintenanceActivity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssertsService.Models.AssertRegister", b =>
                {
                    b.Property<int>("AssertRegisterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssertRegisterId"));

                    b.Property<bool>("AccidentLog")
                        .HasColumnType("bit");

                    b.Property<int>("AssetStatusId")
                        .HasColumnType("int");

                    b.Property<int>("CoordinatesX")
                        .HasColumnType("int");

                    b.Property<int>("CoordinatesY")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfLastInspection")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfPurchase")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrequentProblems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoogleMapsLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuaranteeExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HistoricalCostsOfMaintenance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LocationOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaintenanceContractForAsset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<int>("PriorityId")
                        .HasColumnType("int");

                    b.Property<int>("StrategyLastMaintenanceId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UtilizationRateId")
                        .HasColumnType("int");

                    b.HasKey("AssertRegisterId");

                    b.ToTable("AssertRegisters");
                });

            modelBuilder.Entity("AssertsService.Models.AssetStatus", b =>
                {
                    b.Property<int>("AssetStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssetStatusId"));

                    b.Property<string>("AssetStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssetStatusId");

                    b.ToTable("AssetStatus");
                });

            modelBuilder.Entity("AssertsService.Models.BudgetApproval", b =>
                {
                    b.Property<int>("BudgetApprovalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BudgetApprovalId"));

                    b.Property<string>("BudgetApprovalReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BudgetApprovals")
                        .HasColumnType("bit");

                    b.Property<string>("BudgetDisparity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BudgetDisparityAction")
                        .HasColumnType("bit");

                    b.Property<string>("BudgetDisparityDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyModificationReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmergencyModifications")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MonitoringBudgetImplementation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<string>("PeriodicReports")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BudgetApprovalId");

                    b.ToTable("BudgetApprovals");
                });

            modelBuilder.Entity("AssertsService.Models.BudgetPlan", b =>
                {
                    b.Property<int>("BudgetPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BudgetPlanId"));

                    b.Property<decimal>("AdministrativeCosts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AllocationEmergencyEudget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("EquipmentCosts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EstimationOfMaintenance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HRCosts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MaintenanceManagementStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaintenanceStrategy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaterialCosts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<decimal>("OperationalCosts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("ReviewGistoricalData")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BudgetPlanId");

                    b.ToTable("BudgetPlans");
                });

            modelBuilder.Entity("AssertsService.Models.ComplianceAndRegulatory", b =>
                {
                    b.Property<int>("ComplianceAndRegulatoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComplianceAndRegulatoryId"));

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BriefDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CitingReasons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("YesOrNo")
                        .HasColumnType("bit");

                    b.HasKey("ComplianceAndRegulatoryId");

                    b.ToTable("ComplianceAndRegulatorys");
                });

            modelBuilder.Entity("AssertsService.Models.KeyPerformanceIndicator", b =>
                {
                    b.Property<int>("KeyPerformanceIndicatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KeyPerformanceIndicatorId"));

                    b.Property<string>("Baseline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComingThrough")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("KeyPerformanceIndicatorCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("KeyPerformanceIndicatorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("KeyPerformanceIndicatorId");

                    b.ToTable("KeyPerformanceIndicators");
                });

            modelBuilder.Entity("AssertsService.Models.KeyPerformanceIndicatorCategory", b =>
                {
                    b.Property<int>("KeyPerformanceIndicatorCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KeyPerformanceIndicatorCategoryId"));

                    b.Property<string>("KeyPerformanceIndicatorCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KeyPerformanceIndicatorCategoryId");

                    b.ToTable("KeyPerformanceIndicatorCategorys");
                });

            modelBuilder.Entity("AssertsService.Models.LastMaintenanceStrategy", b =>
                {
                    b.Property<int>("LastMaintenanceStrategyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LastMaintenanceStrategyId"));

                    b.Property<string>("LastMaintenanceStrategyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LastMaintenanceStrategyId");

                    b.ToTable("LastMaintenanceStrategies");
                });

            modelBuilder.Entity("AssertsService.Models.MaintenanceActivity", b =>
                {
                    b.Property<int>("MaintenanceActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaintenanceActivityId"));

                    b.Property<bool>("Approvals")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Dateoflastmaintenance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estimatinglaborcosts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Maintenancecompletiondate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Maintenancemanagementstyle")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Maintenancestartdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Nextmaintenancedate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PeriodicmaintenanceId")
                        .HasColumnType("int");

                    b.Property<string>("Postmaintenance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriorityofworkId")
                        .HasColumnType("int");

                    b.Property<string>("Resources")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeofscheduledmaintenanceId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Workorderissuedate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Workordernumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkorderstatusId")
                        .HasColumnType("int");

                    b.HasKey("MaintenanceActivityId");

                    b.ToTable("MaintenanceActivitys");
                });

            modelBuilder.Entity("AssertsService.Models.Municipal", b =>
                {
                    b.Property<int>("MunicipalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MunicipalId"));

                    b.Property<string>("MunicipalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MunicipalId");

                    b.ToTable("Municipals");
                });

            modelBuilder.Entity("AssertsService.Models.Priority", b =>
                {
                    b.Property<int>("PriorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriorityId"));

                    b.Property<string>("PriorityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PriorityId");

                    b.ToTable("Priorities");
                });

            modelBuilder.Entity("AssertsService.Models.QualityPlanandContinuousImprovement", b =>
                {
                    b.Property<int>("QualityPlanandContinuousImprovementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QualityPlanandContinuousImprovementId"));

                    b.Property<byte[]>("AttachLogFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<string>("Reasons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<short>("YesPartiallyNo")
                        .HasColumnType("smallint");

                    b.HasKey("QualityPlanandContinuousImprovementId");

                    b.ToTable("QualityPlanandContinuousImprovements");
                });

            modelBuilder.Entity("AssertsService.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegionId"));

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("AssertsService.Models.RiskManagementandContingencyPlan", b =>
                {
                    b.Property<int>("RiskManagementandContingencyPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RiskManagementandContingencyPlanId"));

                    b.Property<byte[]>("AttachLogFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<string>("Reasons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<short>("YesPartiallyNo")
                        .HasColumnType("smallint");

                    b.HasKey("RiskManagementandContingencyPlanId");

                    b.ToTable("RiskManagementandContingencyPlans");
                });

            modelBuilder.Entity("AssertsService.Models.UserDetails", b =>
                {
                    b.Property<int>("UserDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserDetailsId"));

                    b.Property<DateTime>("LoginDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserDetailsId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("AssertsService.Models.UtilizationRates", b =>
                {
                    b.Property<int>("UtilizationRatesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UtilizationRatesId"));

                    b.Property<string>("UtilizationRate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UtilizationRatesId");

                    b.ToTable("UtilizationRates");
                });

            modelBuilder.Entity("AssertsService.Models.WorkforceManagement", b =>
                {
                    b.Property<int>("WorkforceManagementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkforceManagementId"));

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BriefDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CitingReasons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MunicipalId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("YesOrNo")
                        .HasColumnType("bit");

                    b.HasKey("WorkforceManagementId");

                    b.ToTable("WorkforceManagements");
                });
#pragma warning restore 612, 618
        }
    }
}
