using Escuela.Controladores;
using Escuela.Presentadores;
using Escuela.Repositorio;
using Escuela.UseCases.Especificaciones;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dependencyinversion
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddEscuelaServices(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            return services
                .AddServicesRepositories(configuration, connectionString)
                .AddServicesUseCases()
                .AddServicesPresenter()
                .AddServicesControllers();
        }

    }

}