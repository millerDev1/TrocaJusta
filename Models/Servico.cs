  
using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TrocaJusta.Models

{
    public class Servico
    {
        [Key]
        public int ServicoId {get;set;}

        public string NomeServico {get;set;}

        public string data {get;set;}

         public string Feedback {get;set;}
    }
}