using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Clientes
    {
        public int ClientesID { get; set; }

        [Required]
        [Display(Name = "Nome do Cliente")]
        public string? Nome { get; set; }

    }
}
