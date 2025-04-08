using AssertsService.Models;
using Microsoft.EntityFrameworkCore;
namespace AssertsService.Data
{
    public class AssertDBContext:DbContext
    {
        public AssertDBContext(DbContextOptions<AssertDBContext> options) : base(options)
        { 
        
        }
        public DbSet<Municipal> Municipals { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }        
        public DbSet<AssertRegister> AssertRegisters { get; set; }
        public DbSet<AssetStatus> AssetStatus { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<LastMaintenanceStrategy> LastMaintenanceStrategies { get; set; }
        public DbSet<UtilizationRates> UtilizationRates { get; set; }
        public DbSet<BudgetPlan> BudgetPlans { get; set; }
        public DbSet<BudgetApproval> BudgetApprovals { get; set; }
        public DbSet<KeyPerformanceIndicator> KeyPerformanceIndicators { get; set; }
        public DbSet<KeyPerformanceIndicatorCategory> KeyPerformanceIndicatorCategorys { get; set; }
        public DbSet<WorkforceManagement> WorkforceManagements { get; set; }
        public DbSet<ComplianceAndRegulatory> ComplianceAndRegulatorys { get; set; }
        public DbSet<RiskManagementandContingencyPlan> RiskManagementandContingencyPlans { get; set; }
        public DbSet<QualityPlanandContinuousImprovement> QualityPlanandContinuousImprovements { get; set; }
        public DbSet<MaintenanceActivity> MaintenanceActivitys { get; set; }
        public DbSet<Upload> Uploads { get; set; }
        public DbSet<PeriodicMaintenance> PeriodicMaintenances { get; set; }
        public DbSet<WorkOrderStatus> WorkOrderStatuses { get; set; }
        public DbSet<TypeofScheduledMaintenance> TypeofScheduledMaintenances { get; set; }
        public DbSet<PriorityOfWork> PriorityOfWorks { get; set; }
        public DbSet<Assert> Asserts { get; set; }
        public DbSet<SubAssert> SubAsserts { get; set; }
        public DbSet<SubMunicipal> SubMunicipals { get; set; }

        public DbSet<ComplianceAndRegulatoryActivity> ComplianceAndRegulatoryActivitys { get; set; }
        public DbSet<KeyPerformanceIndicatorName> KeyPerformanceIndicatorNames { get; set; }
        public DbSet<MaintenanceManagementStyle> MaintenanceManagementStyles { get; set; }
        public DbSet<MaintenanceStrategy> MaintenanceStrategies { get; set; }

        public DbSet<WorkforceManagementActivity> WorkforceManagementActivities { get; set; }
        public DbSet<UploadDocument> UploadDocuments { get; set; }

    }
}
