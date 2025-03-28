using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CadastroClientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage="O campo nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor selecione se o cliente é 'PF' (Pessoa Física) ou 'PJ' (Pessoa Jurídica)")]
        public string Tipo { get; set; } // "PF" (Pessoa Física) ou "PJ" (Pessoa Jurídica)

        [Required(ErrorMessage ="Informe o Nº Documento do Cliente (CPF ou CNPj)")]
        public string Documento { get; set; }

        [Required]
        [Display(Name ="Data/Hora de Cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Required(ErrorMessage ="O campo telefone é obrigatório!")]
        public string Telefone { get; set; }

        public bool Ativo { get; set; } = true;
    }
}