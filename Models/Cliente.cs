using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CadastroClientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Tipo { get; set; } // "PF" (Pessoa Física) ou "PJ" (Pessoa Jurídica)

        [Required]
        public string Documento { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Required]
        public string Telefone { get; set; }

        public bool Ativo { get; set; } = true;
    }
}