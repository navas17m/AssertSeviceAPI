namespace AssertsService.Models
{
    public class UserDetails
    {
        public int UserDetailsId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int MunicipalId { get; set; }
        public int SubMunicipalId { get; set; }
        public DateTime LoginDateTime { get; set; }
        public bool IsActive { get; set; }

    }
}
