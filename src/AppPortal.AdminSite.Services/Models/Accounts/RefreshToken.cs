namespace AppPortal.AdminSite.Services.Models.Accounts
{
    public class RefreshToken
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public bool Revoked { get; set; }
    }
}
