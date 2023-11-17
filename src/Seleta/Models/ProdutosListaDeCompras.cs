using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seleta.Models
{
    [Table("ProdutosListaDeCompras")]
    public class ProdutosListaDeCompras
    {
        [Key]
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } = null!;
        public string ListaDeComprasEmail { get; set; }
        public ListaDeCompras ListaDeCompras { get; set; } = null!;
    }
}
