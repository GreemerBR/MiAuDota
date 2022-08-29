namespace Entra21.TrabalhoFinal.Repositorio.Entidades
{
    public class Protetor : BaseModel
    {
        public string Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Celular { get; set; }
        public string? Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Pix { get; set; }
        public string Sobre { get; set; }
        public string? Instagram { get; set; }
        public string? Facebook { get; set; }
        public bool StatusConta { get; set; }
        public bool EhProtetor { get; set; }
    }
}
