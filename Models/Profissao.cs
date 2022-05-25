using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace TrocaJusta.Models

{
    public class Profissao
    {
        
        public int ProfissaoId { get; set; }

        public string NomeProfissao { get; set; }

        public virtual ICollection <Usuario> Usuarios {get;set;}

        
    }
}