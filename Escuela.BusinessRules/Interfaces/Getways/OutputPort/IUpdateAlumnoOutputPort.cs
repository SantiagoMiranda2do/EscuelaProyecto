using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Getways.OutputPort
{
    public interface IUpdateAlumnoOutputPort
    {
        Task handle(EnvoltorioActualizarAlumno alumno);
    }
}
