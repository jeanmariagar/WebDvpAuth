namespace WebDvpApi.DTOs
{
    public class LoginDto
    {
        public required string NombreUsuario { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
