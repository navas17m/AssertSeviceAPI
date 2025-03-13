namespace AssertsService.DTO
{
    public class UserDetailsDTO
    {
        public int UserDetailsId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Municipal { get; set; }
        public string SubMunicipal { get; set; }
        public int MunicipalId { get; set; }
    }
}
