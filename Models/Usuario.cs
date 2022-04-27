namespace TrocaJusta.Models
{
    public class Usuarios
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public int ProfissaoId { get; set; }
        public string Senha { get; set; }
        public int EnderecoId { get; set; }



    }
}