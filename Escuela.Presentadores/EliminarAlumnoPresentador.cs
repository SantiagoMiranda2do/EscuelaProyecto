using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Presentadores;

namespace Escuela.Presentadores
{
    public class EliminarAlumnoPresentador : IDeleteAlumnoPresenter
    {
        public EnvoltorioEliminarAlumno Alumno { get; private set; } = new EnvoltorioEliminarAlumno();

        public Task handle(EnvoltorioEliminarAlumno Alumno)
        {
            Alumno.NumeroError = Alumno.NumeroError;
            Alumno.Mensaje = Alumno.Mensaje;
            Alumno.IdAlumno = Alumno.IdAlumno;
            return Task.CompletedTask;
        }
    }
}
