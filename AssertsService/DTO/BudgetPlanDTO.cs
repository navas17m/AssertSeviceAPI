namespace AssertsService.DTO
{
    public class BudgetPlanDTO
    {
        public int BudgetPlanId { get; set; }    
       
        public string MaintenanceManagementStyle { get; set; }
        public string MaintenanceStrategy { get; set; }
        public decimal HRCosts { get; set; }
        public decimal MaterialCosts { get; set; }
        public decimal EquipmentCosts { get; set; }
    }
}
