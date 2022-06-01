
using System;
using TrocaJusta.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TrocaJusta.Models

{
    public class Servico
    {
        [Key]
        public int ServicoId {get;set;}

        public ServicoEnum NomeServico {get;set;}

        public DateTime DataServico {get;set;}

        public string Feedback {get;set;}
        
    }
}