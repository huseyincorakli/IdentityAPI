namespace IdentityAPI.Application.DTOs.Token
{
    public class Token
    {
        public string AccessToken { get; set; }
        public DateTime Expiration { get; set; }
    }
}
