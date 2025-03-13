namespace AssertsService.Models
{
    public class KeyPerformanceIndicator
    {
        public int KeyPerformanceIndicatorId { get; set; }
        public int MunicipalId { get; set; }
        public int SubMunicipalId { get; set; }
        public int UserId { get; set; }
        public int KeyPerformanceIndicatorCategoryId { get; set; }
        public string KeyPerformanceIndicatorName { get; set; }
        public string? Description { get; set; }
        public string? Baseline { get; set; }      
        public string? ComingThrough { get; set; }       
        public bool IsActive { get; set; }
    }
}
