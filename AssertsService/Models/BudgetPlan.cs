namespace AssertsService.Models
{
    public class BudgetPlan
    {
        public int BudgetPlanId { get; set; }
        public int MunicipalId { get; set; }
        public int SubMunicipalId { get; set; }
        public int UserId { get; set; }
        public string? MaintenanceManagementStyle { get; set; }
        public string? MaintenanceStrategy { get; set; }
        public decimal HRCosts { get; set; }
        public decimal MaterialCosts { get; set; }
        public decimal EquipmentCosts { get; set; }
        public decimal AdministrativeCosts { get; set; }
        public decimal OperationalCosts { get; set; }
        public string? AllocationEmergencyEudget { get; set; }      
        public string? EstimationOfMaintenance { get; set; }
        public bool ReviewGistoricalData { get; set; }

        public bool IsActive { get; set; }
    }
}
