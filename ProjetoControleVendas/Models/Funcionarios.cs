using System.ComponentModel.DataAnnotations;

namespace ProjetoControleVendas.Models
{
    public class Funcionarios
    {
        public int FuncionariosID { get; set; }

        [Required]
        [Display(Name = "Nome do Funcionário")]
        public string? Nome { get; set; }

        [Required]
        [Display(Name = "Função")]
        public string? Funcao { get; set; }

        public int Telefone { get; set; }

        [Display(Name = "Data Cadastro")]
        public DateTime DtCad { get; set; }

        public decimal Salario { get; set; }

        [StringLength(10, MinimumLength = 4, ErrorMessage = "Máximo de 10, mínimo de 4 caracteres")]
        public string? Senha { get; set; }
    }
}

