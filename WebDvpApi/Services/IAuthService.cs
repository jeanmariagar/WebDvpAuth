using WebDvpApi.DTOs;

namespace WebDvpApi.Services
{
    public interface IAuthService
    {
        Task<string> Register(RegisterDto dto);
        Task<string> Login(LoginDto dto);
    }
}
