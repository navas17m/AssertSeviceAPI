namespace AssertsService.Models
{
    public class QualityPlanandContinuousImprovement
    {
        public int QualityPlanandContinuousImprovementId { get; set; }
        public string Requirement { get; set; }
        public string? Description { get; set; }
        public short YesPartiallyNo { get; set; }
        public int? UploadId { get; set; }
        public string? Reasons { get; set; }
        public int MunicipalId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
    }
}
