using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Getways.OutputPort
{
    public interface IGetAlumnoByIdOutputPort
    {

        Task handle(EnvoltorioSeleccionarAlumno alumno);
    }
}
