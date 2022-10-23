namespace Entra21.MiAuDota.Repositorio.Entidades
{
    public class UsuarioBase : BaseEntity
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}