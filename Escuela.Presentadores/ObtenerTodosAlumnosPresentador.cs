using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Presentadores;

namespace Escuela.Presentadores
{
    public class ObtenerTodosAlumnosPresentador : IGetAllAlumnosPresenter
    {
        public EnvoltorioSeleccionarTodosAlumnos Alumno { get; private set; }

        public ValueTask Handle(EnvoltorioSeleccionarTodosAlumnos alumnos)
        {

            //foreach (var alumno in Alumno)
            //{
            //    Alumno.Append(new EnvoltorioSeleccionarAlumno
            //    {
            //        IdAlumno = alumno.IdActor,
            //        NombreAlumno = alumno.NombreActor,
            //        NumeroError = alumno.ErrorNumber,
            //        Mensaje = string.IsNullOrEmpty(alumno.Message) ? "" : alumno.Message

            //    });
            //}
            Alumno = alumnos;
            return ValueTask.CompletedTask;
        }
    }
}