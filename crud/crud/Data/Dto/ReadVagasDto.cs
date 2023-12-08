namespace FilmesApi.Data.Dtos
{
    using System.ComponentModel.DataAnnotations;

    namespace FilmesApi.Data.Dtos
    {
        public class ReadVagasDto
        {
            [Required(ErrorMessage = "O campo Empresa é obrigatório")]
            public string? Empresa { get; set; }

            [Required(ErrorMessage = "O campo Email é obrigatório")]
            [EmailAddress(ErrorMessage = "E-mail inválido")]
            public string? Email { get; set; }

            [Required(ErrorMessage = "O campo CNPJ é obrigatório")]
            public string? CNPJ { get; set; }

            [Required(ErrorMessage = "O campo Fone Solicitante é obrigatório")]
            public string? FoneSolicitante { get; set; }

            [Required(ErrorMessage = "O campo Nome Solicitante é obrigatório")]
            public string? NomeSolicitante { get; set; }

            [Required(ErrorMessage = "O campo Modelo de Contratação é obrigatório")]
            public string? ModeloContratacao { get; set; }

            [Required(ErrorMessage = "O campo Tipo de Contratação é obrigatório")]
            public required string TipoContratacao { get; set; }

            [Required(ErrorMessage = "O campo Local de Contratação é obrigatório")]
            public string? LocalContratacao { get; set; }

            [Required(ErrorMessage = "O campo Cargo é obrigatório")]
            public string? Cargo { get; set; }

            [Required(ErrorMessage = "O campo Horário de Trabalho é obrigatório")]
            public string? HorarioTrabalho { get; set; }

            [Required(ErrorMessage = "O campo Prioridade de Contratação é obrigatório")]
            public string? PrioridadeContratacao { get; set; }

            [Required(ErrorMessage = "O campo Senioridade é obrigatório")]
            public string? Senioridade { get; set; }

            [Required(ErrorMessage = "O campo Regime de Trabalho é obrigatório")]
            public string? RegimeTrabalho { get; set; }

            [Required(ErrorMessage = "O campo Budget Máximo é obrigatório")]
            public decimal BudgetMaximo { get; set; }

            // Se você deseja manter os campos da classe original
            [Required(ErrorMessage = "O campo de nome é obrigatório.")]
            public string? Nome { get; set; }

            public int EnderecoId { get; set; }
        }
    }

}
