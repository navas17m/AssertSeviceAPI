namespace AssertsService.Models
{
    public class ComplianceAndRegulatory
    {
        public int ComplianceAndRegulatoryId { get; set; }
        public int ComplianceAndRegulatoryActivityId { get; set; }
        public string? Description { get; set; }
        public bool YesOrNo { get; set; }
        public string? BriefDescription { get; set; }
        public string? CitingReasons { get; set; }

        public int MunicipalId { get; set; }
        public int SubMunicipalId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
    }
}
