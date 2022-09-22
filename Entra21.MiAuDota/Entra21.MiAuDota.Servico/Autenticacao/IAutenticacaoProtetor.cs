using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Servico.Autenticacao
{
    public interface IAutenticacaoProtetor
    {
        void CriarSessao(Protetor protetor);
        Protetor LocalizarSessao();
        void RemoverSessao();        
    }
}