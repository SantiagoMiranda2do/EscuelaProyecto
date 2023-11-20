using Escuela.BusinessRules.Interfaces.Getways.InputPort;
using Escuela.UseCases.CasosDeUso;
using Microsoft.Extensions.DependencyInjection;

namespace Escuela.UseCases.Especificaciones
{
    public static class DependencyContainerAlumno
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateAlumnoInputPort, CrearAlumnoIteractor>();

            services.AddScoped<IDeleteAlumnoInputPort, EliminarAlumnoInteractor>();

            services.AddScoped<IUpdateAlumnoInputPort, ActualizarAlumnoInteractor>();

            services.AddScoped<IGetAlumnoByIdInputPort, ObtenerAlumnoPorIdInteractor>();

            services.AddScoped<IGetAllAlumnosInputPort, ObtenerTodosAlumnosIterator>();


            return services;
        }
    }
}
