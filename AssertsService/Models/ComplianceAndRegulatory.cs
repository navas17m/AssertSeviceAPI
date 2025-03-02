﻿namespace AssertsService.Models
{
    public class ComplianceAndRegulatory
    {
        public int ComplianceAndRegulatoryId { get; set; }
        public string Activity { get; set; }
        public string? Description { get; set; }
        public bool YesOrNo { get; set; }
        public string? BriefDescription { get; set; }
        public string? CitingReasons { get; set; }
    }
}
