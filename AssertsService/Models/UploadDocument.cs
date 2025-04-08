namespace AssertsService.Models
{
    public class UploadDocument
    {
        public int UploadDocumentId { get; set; }
        public string? Description { get; set; }
        public string? Defects { get; set; }    
        public int? UploadId { get; set; }      
        public int MunicipalId { get; set; }
        public int SubMunicipalId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
    }
}
