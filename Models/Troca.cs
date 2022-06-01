using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TrocaJusta.Models
{
    public class Troca
    {
        [Key]  
        public int Trocaid { get; set; }

        public int UsuarioId1 {get;set;}

        public int UsuarioId2 {get;set;}

        public int ServicoId1 {get;set;}

        public int ServicoId2 {get;set;}

        public int EnderecoId1 {get;set;}
        
        public int EnderecoId2 {get;set;}
        
        
    }
}