using System.Threading.Tasks;
using CommunityHoldings.API.DataModels;

namespace CommunityHoldings.API.Data
{
    public interface IIdentityRepository
    {
        public Task<User> Register(User user, string password);
        public Task<User> Login(string username, string password);
        public Task<bool> UserExists(string username);
    }
}