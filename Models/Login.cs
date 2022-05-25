using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TrocaJusta.Models
{
    public class Login
    {
        
        public int LoginId{ get; set; }

        public string Email {get;set;}

        public  string Senha  {get;set;}

      

       

    }
}