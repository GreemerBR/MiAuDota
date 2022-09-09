using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace Entra21.MiAuDota.Servico.InjecoesDependencia
{
    public static class ServicoExtensions
    {
        public static IServiceCollection AdicionarServicos(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioServico, UsuarioServico>();

            return services;
        }

        public static IServiceCollection AdicionarMapeamentoEntidades(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioMapeamentoEntidade, UsuarioMapeamentoEntidade>();

            return services;
        }
    }
}
