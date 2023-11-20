using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Presentadores;

namespace Escuela.Presentadores
{
    public class ActualizarAlumnoPresentador : IUpdateAlumnoPresenter
    {
        public EnvoltorioActualizarAlumno Alumno => throw new NotImplementedException();

        public Task handle(EnvoltorioActualizarAlumno alumno)
        {
            throw new NotImplementedException();
        }
    }
}
