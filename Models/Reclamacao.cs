using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TrocaJusta.Models
{
    public class Reclamacao
    {
        
        public int ReclamacaoId { get; set; }

        public string Email { get; set; }

        public string Chat { get; set; }
    }
}