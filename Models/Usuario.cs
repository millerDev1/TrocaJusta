using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrocaJusta.Models
{
    public class Usuario
    {
        
        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public int GeneroId {get; set;}

        public virtual Genero Genero {get;set;}
        
        public string Cpf { get; set; }

        public string DataNascimento { get; set; }

        public string Telefone {get; set;}

        public int ProfissaoId { get; set; }

        public virtual Profissao profissao { get; set; }

        
        public int LoginId { get; set; }
        
        public int ServicoId{get;set;}
        
        public string Email { get; set; }

        public string Senha { get; set; }

        public int EnderecoId { get; set; }



    }

}
