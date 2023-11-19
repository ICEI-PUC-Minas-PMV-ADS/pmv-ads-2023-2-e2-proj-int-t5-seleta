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

        [Display(Name = "CNPJ do Estabelecimento")]
        public string CnpjEstabelecimento { get; set; }

        [ForeignKey("CnpjEstabelecimento")]
        public Estabelecimento? Estabelecimento { get; set; }

        [Display(Name = "Imagem do Produto")]
        public byte[] Imagem { get; set; }  // Campo para armazenar os dados binários da imagem

        [Display(Name = "Tipo de Imagem")]
        public string TipoImagem { get; set; }  // Campo para armazenar o tipo de conteúdo da imagem
        public List<ProdutosListaDeCompras> ListasDeCompras { get; set; } = new();

    }

    public class pesquisa
    {
        public static void Main()
        {
            EnumToString();
            Console.ReadKey();
        }

        private static void EnumToString()
        {
            var massa = TipoCategoria.Massa;
            var massaString = massa.ToString();
            var laticinio = TipoCategoria.Laticínio;
            var laticinioString = laticinio.ToString();
            var bebida = TipoCategoria.Bebida;
            var bebidaString = bebida.ToString();
            var padaria = TipoCategoria.Padaria;
            var padariaString = padaria.ToString();
            var legumes = TipoCategoria.Legumes;
            var legumesString = legumes.ToString();
            var verduras = TipoCategoria.Verduras;
            var verdurasString = verduras.ToString();
            var frutas = TipoCategoria.Frutas;
            var frutasString = frutas.ToString();
            var lanches = TipoCategoria.Lanches;
            var lanchesString = lanches.ToString();
            var refeicao = TipoCategoria.Refeição;
            var refeicaoString = refeicao.ToString();
            var sobremesa = TipoCategoria.Sobremesa;
            var sobremesaString = sobremesa.ToString();



            Console.WriteLine(massaString);
            Console.WriteLine(laticinioString);
            Console.WriteLine(bebidaString);
            Console.WriteLine(padariaString);
            Console.WriteLine(legumesString);
            Console.WriteLine(verdurasString);
            Console.WriteLine(frutasString);
            Console.WriteLine(lanchesString);
            Console.WriteLine(refeicaoString);
            Console.WriteLine(sobremesaString);
            Console.ReadKey();
        }
    }

}

    public enum Restricoes
    {
        [Display(Name = "Intolerância à lactose")]
        LactoseIntolerância,
        [Display(Name = "Diabetes")]
        Diabetes,
        [Display(Name = "Intolerância à gluten")]
        GlutenIntolerância,
        [Display(Name = "Vegano")]
        Vegano
    }

    public enum TipoCategoria
    {
        [Display(Name = "Massa")]
        Massa,
        [Display(Name = "Laticínio")]
        Laticínio,
        [Display(Name = "Bebida")]
        Bebida,
        [Display(Name = "Padaria")]
        Padaria,
        [Display(Name = "Legumes")]
        Legumes,
        [Display(Name = "Verduras")]
        Verduras,
        [Display(Name = "Frutas")]
        Frutas,
        [Display(Name = "Lanches")]
        Lanches,
        [Display(Name = "Refeição")]
        Refeição,
        [Display(Name = "Sobremesa")]
        Sobremesa
    }