using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Getways.OutputPort
{
    public interface ICreateAlumnoOutputPort
    {

        Task Handle(EnvoltorioCrearAlumno alumno);
    }
}
