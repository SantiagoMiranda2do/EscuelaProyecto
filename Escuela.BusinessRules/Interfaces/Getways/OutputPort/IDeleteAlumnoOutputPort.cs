using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Getways.OutputPort
{
    public interface IDeleteAlumnoOutputPort
    {

        Task handle(EnvoltorioEliminarAlumno Alumno);
    }
}
