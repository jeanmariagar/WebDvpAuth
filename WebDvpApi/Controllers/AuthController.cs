using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebDvpApi.DTOs;
using WebDvpApi.Services;

namespace WebDvpApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var result = await _authService.Register(dto);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var token = await _authService.Login(dto);
            if (token == null)
                return Unauthorized("Credenciales incorrectas");

            return Ok(new { token });
        }

        [Authorize]
        [HttpGet("perfil")]
        public IActionResult Perfil()
        {
            var nombre = User.Identity?.Name;
            return Ok(new { Usuario = nombre });
        }
    }
}
