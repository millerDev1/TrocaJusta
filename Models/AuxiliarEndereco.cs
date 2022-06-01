using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrocaJusta.Models
{
    public class AuxiliarEndereco
    {
        public int id {get; set;}

        [ForeignKey("Usuario")]
        public int UsuarioId{get; set;}

        [ForeignKey("Endereco")]
        public int EnderecoId {get; set;}
    }
}