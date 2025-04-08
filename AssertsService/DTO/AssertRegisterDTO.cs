namespace AssertsService.DTO
{
    public class AssertRegisterDTO 
    {
        public int AssertRegisterId { get; set; }
        public int MunicipalId { get; set; }       
        public string IdentificationNumber { get; set; }
        public string AssertName { get; set; }
        public string SubAssertName { get; set; }
        public string LocationOfOrigin { get; set; }
        public int CoordinatesX { get; set; }
        public int CoordinatesY { get; set; }
        public string GoogleMapsLink { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public string DepartmentName { get; set; }
        public DateTime DateOfLastInspection { get; set; }
        public bool AccidentLog { get; set; }
        public int StrategyLastMaintenanceId { get; set; }
        public int AssetStatusId { get; set; }
        public int UtilizationRateId { get; set; }
        public string FrequentProblems { get; set; }
        public string HistoricalCostsOfMaintenance { get; set; }
        public DateTime GuaranteeExpiryDate { get; set; }
        public int PriorityId { get; set; }
        public string MaintenanceContractForAsset { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
