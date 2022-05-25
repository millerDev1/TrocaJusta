using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TrocaJusta.Models
{
    public class Genero
    {
        public int GeneroId {get;set;}

        public string NomeGenero{get;set;}

        public virtual ICollection <Usuario> Usuarios {get;set;}
    }
}