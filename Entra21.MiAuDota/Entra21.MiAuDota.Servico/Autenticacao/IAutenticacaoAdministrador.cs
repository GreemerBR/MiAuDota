using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Servico.Autenticacao
{
    public interface IAutenticacaoAdministrador
    {
        void CriarSessao(Administrador admin);
        Administrador LocalizarSessao();
        void RemoverSessao();
    }
}