using System.ComponentModel.DataAnnotations;

namespace ProjetoControleVendas.Models
{
    public class Administrador
    {

        public int AdministradorID { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Required]
        [Display(Name = "Tipo de Controle")]
        public string? Controle { get; set; }
    }
}

