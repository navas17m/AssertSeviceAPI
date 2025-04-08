namespace AssertsService.Models
{
    public class KeyPerformanceIndicator
    {
        public int KeyPerformanceIndicatorId { get; set; }
        public int MunicipalId { get; set; }
        public int SubMunicipalId { get; set; }
        public int UserId { get; set; }
        public int KeyPerformanceIndicatorCategoryId { get; set; }
        public int KeyPerformanceIndicatorNameId { get; set; }
        public string? Description { get; set; }           
        public bool IsActive { get; set; }
    }
}
