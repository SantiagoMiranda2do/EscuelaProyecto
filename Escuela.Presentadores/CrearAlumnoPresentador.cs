using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Presentadores;

namespace Escuela.Presentadores
{
    public class CrearAlumnoPresentador : ICreateAlumnoPresenter
    {
        public EnvoltorioCrearAlumno Alumno { get; private set; } = new EnvoltorioCrearAlumno();

        public Task Handle(EnvoltorioCrearAlumno alumno)
        {
            Alumno.NumeroError = Alumno.NumeroError;
            Alumno.ValidacionErrores = Alumno.ValidacionErrores;
            Alumno.Mensaje = Alumno.Mensaje;
            Alumno.IdAlumno = Alumno.IdAlumno;
            return Task.CompletedTask;
        }
    }
}
