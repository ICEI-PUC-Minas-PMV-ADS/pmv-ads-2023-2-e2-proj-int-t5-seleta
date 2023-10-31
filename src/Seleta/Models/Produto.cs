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
        [Display(Name = "Preço")]
        public int Preco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade e/ou peso do produto")]
        [Display(Name = "Quantidade/Peso")]
        public int QuantidadePeso { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a categoria a qual pertence esse alimento")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição do alimento")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Restrição(ões) alimentar(es)")]
        public Restricoes Restricoes { get; set; }

        [Display(Name = "Estabelecimento")]
        [Required(ErrorMessage = "Obrigatório informar o estabelecimento")]
        public int CnpjEstabelecimento { get; set; }

        [ForeignKey("CnpjEstabelecimento")]
        public Estabelecimento Estabelecimento { get; set; }

    }

    public enum Restricoes
    {
        LactoseIntolerancia,
        Diabetes,
        GlutenIntolerancia
    }
}
