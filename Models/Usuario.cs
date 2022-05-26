using System;

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
        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Telefone {get; set;}

        [Required(ErrorMessage = "Campo Obrigatório")]  
        public string Profissao { get; set; }
        
        [ForeignKey("Servico")]  
        public string NomeServico{get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Senha { get; set; }

        [ForeignKey("Endereco")]  
        public int Cep { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Genero{get; set;}



    }

}
