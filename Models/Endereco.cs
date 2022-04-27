namespace TrocaJusta.Models
{
    public class Endereco
    {
        public int EnderecoId {get;set;}
        public string Cep {get;set;}
        public string Estado {get;set;}
        public string Cidade {get;set;}
        public string Bairro {get;set;}
        public string Logradouro {get;set;}
        public string Complemento {get;set;}
        public int NumeroCasa {get;set;}
}
}