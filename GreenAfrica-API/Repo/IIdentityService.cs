using GreenAfrica_API.IdentityData;
using System.Threading.Tasks;

namespace GreenAfrica_API.Repo
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        Task<AuthenticationResult> LoginAsync(string email, string password);

        Task<AuthenticationResult> RefreshTokenAsync(string token, string refreshToken);
    }
}
