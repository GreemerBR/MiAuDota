using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Entra21.MiAuDota.Repositorio.InjecoesDependencia
{
    public static class RepositorioExtensions
    {
        public static IServiceCollection AdicionarRepositorios(this IServiceCollection services)
        {
            services.AddScoped<IAnimalRepositorio, AnimalRepositorio>();
            services.AddScoped<IProtetorRepositorio, ProtetorRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

            return services;
        }

        public static IServiceCollection AdicionarEntityFramework(
            this IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.AddDbContext<MiAuDotaContexto>(options =>
                options.UseSqlServer(configurationManager.GetConnectionString("SqlServer")));

            return services;
        }
    }
}
