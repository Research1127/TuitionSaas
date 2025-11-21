using System.Threading.Tasks;
using TuitionSaaS.Application.Users.DTOs;

namespace TuitionSaaS.Application.Users;

public interface IUserService
{
    Task<AuthResponse> RegisterAsync(RegisterUserRequest request);
    Task<AuthResponse> LoginAsync(LoginRequest request);
}