namespace Entra21.MiAuDota.Repositorio.Entidades
{
    public class Protetor : UsuarioBase
    {
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public string? Endereco { get; set; }
        public string Celular { get; set; }
        public string? Telefone { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public string? Pix { get; set; }
        public string? Sobre { get; set; }
        public string? Instagram { get; set; }
        public string? Facebook { get; set; }
        public bool IsActive { get; set; }

        public IList<Animal> Animais { get; set; }

        public void AlterarStatus()
        {
            IsActive = true;
        }
    }
}
