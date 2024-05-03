using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class NivelDeAcesso
    {
        public int NivelDeAcessoID { get; set; }

        [Required]
        [Display(Name = "Nome do Funcionário")]
        public string? Nome { get; set; }

        [Required]
        public int CPF { get; set; }

        [Required]
        public int Telefone { get; set; }

        [Required]
        [Display(Name = "Nível de Acesso")]
        public string? Nivel { get; set; }
    }
}
