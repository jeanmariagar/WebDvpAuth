using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebDvpApi.DTOs;
using WebDvpDatabase.Data;
using WebDvpDatabase.Models;
using Microsoft.EntityFrameworkCore;


namespace WebDvpApi.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<string> Register(RegisterDto dto)
        {
            var exists = await _context.Usuarios.AnyAsync(u => u.NombreUsuario == dto.NombreUsuario);
            if (exists)
            {
                return "El usuario ya existe";
            }

            var usuario = new Usuario
            {
                NombreUsuario = dto.NombreUsuario,
                Password = dto.Password, // ⚠️ Esto es solo para aprender. En producción debes **encriptar**.
                Email = dto.Email
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return "Usuario registrado correctamente";
        }

        public async Task<string> Login(LoginDto dto)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NombreUsuario == dto.NombreUsuario && u.Password == dto.Password);

            if (usuario == null)
            {
                return "Credenciales inválidas";
            }

            // Generar Token JWT
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, usuario.NombreUsuario),
                new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
