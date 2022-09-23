namespace Entra21.MiAuDota.Repositorio.Entidades
{
    public class Usuario : UsuarioBase
    {
        public string? Cpf { get; set; }
        public string? Endereco { get; set; }
        public string? Celular { get; set; }
        public string ConfirmarSenha { get; set; }
        public string? Especialidade { get; set; }
        public bool EhVoluntario { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DataNascimento { get; set; }

        public IList<Animal> Animais { get; set; }
    }
}
