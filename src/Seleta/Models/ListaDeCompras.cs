using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seleta.Models
{
    [Table("ListaDeCompras")]
    public class ListaDeCompras
    {
        [Key]
        [EmailAddress(ErrorMessage = "Insira um email válido!")]
        public string Email { get; set; }

        public List<ProdutosListaDeCompras> Produtos { get; set; } = new();
    }
}
