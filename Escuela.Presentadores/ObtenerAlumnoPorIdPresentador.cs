using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Presentadores;

namespace Escuela.Presentadores
{
    public class ObtenerAlumnoPorIdPresentador : IGetAlumnoByIdPresenter
    {
        public EnvoltorioSeleccionarAlumno Alumno { get; private set; }

        public Task handle(EnvoltorioSeleccionarAlumno alumno)
        {
            Alumno = new EnvoltorioSeleccionarAlumno
            {
                NombreAlumno = Alumno.NombreAlumno,
                NumeroError = Alumno.NumeroError,
                Mensaje = Alumno.Mensaje,
                IdAlumno = Alumno.IdAlumno
            };
            return Task.CompletedTask;


        }

    }
}
