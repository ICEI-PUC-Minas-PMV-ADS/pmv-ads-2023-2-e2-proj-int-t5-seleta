using System.ComponentModel.DataAnnotations;

namespace Seleta.Models.ViewModel
{
    public class LoginUsuarioViewModel
    {
        [Required(ErrorMessage = "Necessario usar um email!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Necessario criar uma senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
