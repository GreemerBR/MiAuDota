using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Servico.Autenticacao
{
    public interface IAutenticacaoUsuario
    {
        void CriarSessao(Usuario usuario);
        Usuario LocalizarSessao();
        void RemoverSessao();
    }
}