using System.ComponentModel.DataAnnotations;

namespace ProjetoControleVendas.Models
{
    public class Produtos

    {
        public int ProdutosID { get; set; }

        [Required]
        [Display(Name = "Nome do Produto")]
        public string? NomeProduto { get; set; }

        public string? Categoria { get; set; }

        [Required]
        [Display(Name = "Estoque")]
        public int QuantidadeEmEstoque { get; set; }

        [Required]
        public decimal Valor { get; set; }

    }
}
 