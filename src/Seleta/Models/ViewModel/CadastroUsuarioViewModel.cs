using System.ComponentModel.DataAnnotations;

namespace Seleta.Models.ViewModel
{
    public class CadastroUsuarioViewModel
    {
        [Key]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Necessário informar seu nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Necessário usar um email!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Necessário criar uma senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare(nameof(Senha), ErrorMessage = "Senha e confirmação de senha devem ser iguais!")]
        public string ConfirmarSenha { get; set; }
    }
}
