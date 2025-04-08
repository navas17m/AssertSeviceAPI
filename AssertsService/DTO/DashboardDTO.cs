namespace AssertsService.DTO
{
    public class DashboardDTO
    {
        public int AssertRegisterCount { get; set; }
        public int BudgetPlanCount { get; set; }
        public int BudgetApprovalCount { get; set; }
        public int KPICount { get; set; }
        public int WorkforceManagementCount { get; set; }
        public int ComplianceandregulatoryCount  { get; set; }
        public int RiskManagementCount { get; set; }
        public int QualityPlanCount { get; set; }
        public int WorkOrderCount { get; set; }

        public decimal TotalCost { get; set; }
        public decimal HRCost { get; set; }
        public decimal HRMaterialCost { get; set; }
        public decimal OtherCost { get; set; }

        public int WorkOrderOpenCount { get; set; }
        public int WorkOrderInProgressCount { get; set; }
        public int WorkOrderPendingCount { get; set; }
        public int WorkOrderClosedCount { get; set; }

        public IEnumerable<StatusCountDTO> TypeOfMaintance { get; set; }

        public AssetRegisterDashboardDTO AssetRegister { get; set; }

     
    }
    public class AssetRegisterDashboardDTO
    {
       
        public IEnumerable<StatusCountDTO> StrategyCount { get; set; }
        public IEnumerable<StatusCountDTO> AssetStatusCount { get; set; }

    }
    public class StatusCountDTO
    {
        public int Count { get; set; }
        public string Name { get; set; }

    }
}
