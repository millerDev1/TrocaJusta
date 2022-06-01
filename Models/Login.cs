using System.ComponentModel.DataAnnotations;

namespace TrocaJusta.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Digite seu Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite sua senha")]
        public string Senha { get; set; }
    }
    
}