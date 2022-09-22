using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace Entra21.MiAuDota.Servico.InjecoesDependencia
{
    public static class ServicoExtensions
    {
        public static IServiceCollection AdicionarServicos(this IServiceCollection services)
        {
            services.AddScoped<IAdministradorServico, AdministradorServico>();
            services.AddScoped<IAnimalServico, AnimalServico>();
            services.AddScoped<ILogonServico, LogonServico>();
            services.AddScoped<IProtetorServico, ProtetorServico>();
            services.AddScoped<IUsuarioServico, UsuarioServico>();

            return services;
        }

        public static IServiceCollection AdicionarMapeamentoEntidades(this IServiceCollection services)
        {
            services.AddScoped<IAdministradorMapeamentoEntidade, AdministradorMapeamentoEntidade>();
            services.AddScoped<IAnimalMapeamentoEntidade, AnimalMapeamentoEntidade>();
            services.AddScoped<IProtetorMapeamentoEntidade, ProtetorMapeamentoEntidade>();
            services.AddScoped<IUsuarioMapeamentoEntidade, UsuarioMapeamentoEntidade>();

            return services;
        }

        public static IServiceCollection AdicionarMapeamentoViewModel(this IServiceCollection services)
        {
            services.AddScoped<IAdministradorMapeamentoViewModel, AdministradorMapeamentoViewModel>();
            services.AddScoped<IAnimalMapeamentoViewModel, AnimalMapeamentoViewModel>();
            services.AddScoped<IProtetorMapeamentoViewModel, ProtetorMapeamentoViewModel>();
            services.AddScoped<IUsuarioMapeamentoViewModel, UsuarioMapeamentoViewModel>();

            return services;
        }

        public static IServiceCollection AdicionarAutenticacoes(this IServiceCollection services)
        {
            services.AddScoped<IAutenticacaoAdministrador, AutenticacaoAdministrador>();
            services.AddScoped<IAutenticacaoProtetor, AutenticacaoProtetor>();
            services.AddScoped<IAutenticacaoUsuario, AutenticacaoUsuario>();

            return services;
        }
    }
}
