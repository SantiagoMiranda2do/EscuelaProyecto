using Escuela.BusinessRules.Interfaces.Getways.OutputPort;
using Escuela.BusinessRules.Interfaces.Presentadores;
using Microsoft.Extensions.DependencyInjection;

namespace Escuela.Presentadores
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {
            services.AddScoped<ObtenerTodosAlumnosPresentador>();
            services.AddScoped<IGetAllAlumnosOutputPort, ObtenerTodosAlumnosPresentador>();
            services.AddScoped<IGetAllAlumnosPresenter, ObtenerTodosAlumnosPresentador>();
            services.AddScoped<ICreateAlumnoPresenter, CrearAlumnoPresentador>();
            services.AddScoped<IDeleteAlumnoPresenter, EliminarAlumnoPresentador>();
            services.AddScoped<IGetAlumnoByIdPresenter, ObtenerAlumnoPorIdPresentador>();
            services.AddScoped<IUpdateAlumnoPresenter, ActualizarAlumnoPresentador>();

            return services;
        }
    }
}
