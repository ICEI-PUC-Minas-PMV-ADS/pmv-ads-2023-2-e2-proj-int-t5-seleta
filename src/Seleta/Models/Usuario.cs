﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seleta.Models
{
    [Table("Usuarios")]
    public class Usuario
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

        public List<Estabelecimento>? Estabelecimentos { get; set; }
    }
}
