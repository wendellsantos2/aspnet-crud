using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud.Models
{
    [Table("Vaga")]
      public class Vaga
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Empresa é obrigatório")]
        public required string Empresa { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório")]
        public required string CNPJ { get; set; }

        [Required(ErrorMessage = "O campo Fone Solicitante é obrigatório")]
        public required string requiredFoneSolicitante { get; set; }

        [Required(ErrorMessage = "O campo Nome Solicitante é obrigatório")]
        public required  string NomeSolicitante { get; set; }

        [Required(ErrorMessage = "O campo Modelo de Contratação é obrigatório")]
        public required string ModeloContratacao { get; set; }

        [Required(ErrorMessage = "O campo Tipo de Contratação é obrigatório")]
        public required string TipoContratacao { get; set; }

        [Required(ErrorMessage = "O campo Local de Contratação é obrigatório")]
        public required string LocalContratacao { get; set; }

        [Required(ErrorMessage = "O campo Cargo é obrigatório")]
        public required  string Cargo { get; set; }

        [Required(ErrorMessage = "O campo Horário de Trabalho é obrigatório")]
        public required string HorarioTrabalho { get; set; }

        [Required(ErrorMessage = "O campo Prioridade de Contratação é obrigatório")]
        public required string PrioridadeContratacao { get; set; }

        [Required(ErrorMessage = "O campo Senioridade é obrigatório")]
        public required string Senioridade { get; set; }

        [Required(ErrorMessage = "O campo Regime de Trabalho é obrigatório")]
        public required string RegimeTrabalho { get; set; }

        [Required(ErrorMessage = "O campo Budget Máximo é obrigatório")]
        public decimal BudgetMaximo { get; set; }
    }
}
