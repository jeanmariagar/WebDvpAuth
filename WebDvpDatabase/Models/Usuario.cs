using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDvpDatabase.Models
{
   public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public required string NombreUsuario { get; set; }

        [Required]
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}
