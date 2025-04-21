namespace WebDvpApi.DTOs
{
    public class RegisterDto
    {
        public required string NombreUsuario { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
