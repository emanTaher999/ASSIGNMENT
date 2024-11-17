using ASSIGNMENT.Models;

namespace ASSIGNMENT.Services
{
    public interface IAuthServices
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);

        Task<AuthModel> LoginAsync(LoginModel model);
    }
}
