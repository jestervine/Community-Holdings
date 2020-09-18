namespace CommunityHoldings.API.DataModels
{
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}