using Escuela.Entidades.Repositorios;
using Escuela.Repositorio.Contexto;
using Escuela.Repositorio.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Escuela.Repositorio
{
    public static class DependencyContainer
    {



        public static IServiceCollection AddServicesRepositories(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<EscuelaContexto>(options =>
            options.UseMySQL(configuration.GetConnectionString("MySqlEscuela")));

            services.AddScoped<IAlumnoRepositorio, AlumnoRepository>();

            return services;
        }
    }
}
