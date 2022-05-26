using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrocaJusta.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoId {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cep {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Estado {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cidade {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Bairro {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeRua {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Complemento {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int NumeroCasa {get;set;}

        
}
}