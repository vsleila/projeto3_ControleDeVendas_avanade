using System.ComponentModel.DataAnnotations;

namespace ProjetoControleVendas.Models
{
    public class Vendas
    {
        public int VendasID { get; set; }

        [Required]
        [Display(Name = "Nome do Produto")]
        public string? NomeP { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Nome do Funcionário")]
        public string? FuncionarioVenda { get; set; }

        [Required]
        [Display(Name = "Valor Total")]
        public int ValorTotal { get; set; }
    }
}
