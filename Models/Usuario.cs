using System;
using TrocaJusta.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrocaJusta.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Phone(ErrorMessage = "O número de telefone informado não é valido")]
        public string Telefone {get; set;}
 
        public ProfissaoEnum Profissao { get; set; }
        
        public ServicoEnum NomeServico{get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Senha { get; set; }

        public GeneroEnum Genero { get ; set; }

        [ForeignKey("Usuario")]
        public int EnderecoId { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
    
}
