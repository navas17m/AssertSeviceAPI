namespace AssertsService.Models
{
    public class WorkforceManagement
    {
        public int WorkforceManagementId { get; set; }
        public string Activity { get; set; }
        public string? Description { get; set; }
        public bool YesOrNo { get; set; }
        public string? BriefDescription { get; set; }
        public string? CitingReasons { get; set; }
        public int MunicipalId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
    }
}
