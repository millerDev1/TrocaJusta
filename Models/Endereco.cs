namespace TrocaJusta.Models
{
    public class Endereco
    {
        public int EnderecoId {get;set;}
        public string cep {get;set;}
        public string estado {get;set;}
        public string cidade {get;set;}
        public string bairro {get;set;}
        public string logradouro {get;set;}
        public string complemento {get;set;}
        public int numeroCasa {get;set;}
}
}