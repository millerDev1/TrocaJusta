using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrocaJusta.Enums;

namespace TrocaJusta.Models
{
    public class Troca
    {
        [Key]  
        public int Trocaid { get; set; }
        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        [ForeignKey("ProfissaoEnum")]
        public ProfissaoEnum Profissao { get; set; }

        [ForeignKey("ServicoEnum")]
        public ServicoEnum Servico { get; set; }

        public bool Disponivel { get; set; }      
    }
}