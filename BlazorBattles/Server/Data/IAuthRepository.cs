using BlazorBattles.Shared;

namespace BlazorBattles.Server.Data
{
    public interface IAuthRepository
    {
        Task<int> Register(User user, string password);
        Task<string> Login(string email, string password);
        Task<bool> UserExists(string email);

    }
}
