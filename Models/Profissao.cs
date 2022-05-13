using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrocaJusta.Models

{
    public class Profissao
    {
        
        public int ProfissaoId { get; set; }

        public string NomeProfissao { get; set; }

        public int UsuarioId {get;set;}

        public virtual Usuario Usuario {get;set;}

        
    }
}