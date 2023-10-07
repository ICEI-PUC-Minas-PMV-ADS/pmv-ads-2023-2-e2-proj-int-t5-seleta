using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seleta.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Necessario usar um email!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Necessario criar uma senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
