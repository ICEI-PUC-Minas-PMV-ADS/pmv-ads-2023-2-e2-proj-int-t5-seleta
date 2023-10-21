using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seleta.Models
{
    [Table("Estabelecimentos")]

    public class Estabelecimento
    {
        [Key]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do estabelecimento")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o endereço do estabelecimento")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o contato do estabelecimento")]
        public string Contato { get; set; }

        public string? UsuarioCPF { get; set; }

        public Usuario? Usuario { get; set; }
    }
}