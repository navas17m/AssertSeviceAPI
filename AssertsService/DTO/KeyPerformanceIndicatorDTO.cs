namespace AssertsService.DTO
{
    public class KeyPerformanceIndicatorDTO
    {
        public int KeyPerformanceIndicatorId { get; set; }     
       
        public string KeyPerformanceIndicatorName { get; set; }
        public string KeyPerformanceIndicatorCategorylName { get; set; }
        public string? Description { get; set; }
        public string? Baseline { get; set; }
        public string? ComingThrough { get; set; }
    }
}
