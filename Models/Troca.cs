using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TrocaJusta.Models
{
    public class Troca
    {
          
        public int Trocaid { get; set; }
        public int UsuarioId {get;set;}
        public int ProfissaoId {get;set;}
        public int EnderecoId {get;set;}
        public int UsuarioId2 {get;set;}
        public int ProfissaoId2 {get;set;}
    }
}