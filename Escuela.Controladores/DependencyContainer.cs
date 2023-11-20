using Escuela.BusinessRules.Interfaces.Controladores;
using Microsoft.Extensions.DependencyInjection;

namespace Escuela.Controladores
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateAlumnoController, CrearAlumnoControlador>();
            services.AddScoped<IDeleteAlumnoController, EliminarAlumnoControlador>();
            services.AddScoped<IGetAlumnoByIdController, ObtenerAlumnoPorIdControlador>();
            services.AddScoped<IUpdateAlumnoController, ActualizarAlumnoControlador>();
            services.AddScoped<IGetAllAlumnoController, ObtenerTodosAlumnosControlador>();
            return services;

        }
    }
}
