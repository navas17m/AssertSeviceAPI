namespace AssertsService.Models
{
    public class BudgetApproval
    {
        public int BudgetApprovalId { get; set; }
        public int MunicipalId { get; set; }
        public int SubMunicipalId { get; set; }
        public int UserId { get; set; }
        public bool BudgetApprovals { get; set; }
        public string? BudgetApprovalReason { get; set; }      
        public string? MonitoringBudgetImplementation { get; set; }
        public string? PeriodicReports { get; set; }
        public bool EmergencyModifications { get; set; }
        public string? EmergencyModificationReason { get; set; }
        public string? BudgetDisparity { get; set; }
        public bool BudgetDisparityAction { get; set; }
        public string? BudgetDisparityDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
