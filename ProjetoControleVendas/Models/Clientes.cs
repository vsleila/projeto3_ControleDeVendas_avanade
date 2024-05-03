using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Clientes
    {
        public int ClientesID { get; set; }

        [Required]
        [Display(Name = "Nome do Cliente")]
        public string? Nome { get; set; }

        [Required]
        public int CPF { get; set; }

        [Required]
        public int Telefone { get; set; }

        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        public string? Bairro { get; set; }

        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Required]
        public string? Atividade { get; set; }
    }
}


