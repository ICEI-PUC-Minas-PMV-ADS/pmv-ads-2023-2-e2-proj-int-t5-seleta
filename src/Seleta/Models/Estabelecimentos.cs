using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seleta.Models
{
    [Table("Estabelecimentos")]

    public class Estabelecimento
    {
        [Key]
        [Required(ErrorMessage = "Obrigatório informar o CNPJ do estabelecimento")]
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do estabelecimento")]
        [Display(Name = "Nome do Estabelecimento")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o endereço do estabelecimento")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o contato do estabelecimento")]
        public string Contato { get; set; }

        [Display(Name = "CPF do Usuário")]
        public string? UsuarioCPF { get; set; }

        [Display(Name = "Responsável pelo estabelecimento")]
        public Usuario? Usuario { get; set; }

        public ICollection<Produto> Produtos { get; set; } 
    }
}
