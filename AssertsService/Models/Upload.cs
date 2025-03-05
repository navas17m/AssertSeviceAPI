namespace AssertsService.Models
{
    public class Upload
    {
        public int UploadId { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public DateTime? UploadedDate { get; set; }
    }
}
