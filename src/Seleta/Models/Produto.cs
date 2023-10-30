using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seleta.Models
{

    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o preço")]
        public int Preco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade e/ou peso do produto")]
        public int QuantidadePeso { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a(s) restrição(ões) alimentar(es) associada(s) ao alimento")]
        public string Restricao { get; set;}

        [Required(ErrorMessage = "Obrigatório informar a categoria a qual pertence esse alimento")]
        public string Categoria { get; set; }

    }
}
