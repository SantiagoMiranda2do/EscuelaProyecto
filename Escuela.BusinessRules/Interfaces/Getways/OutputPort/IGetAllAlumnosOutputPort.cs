using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Getways.OutputPort
{
    public interface IGetAllAlumnosOutputPort
    {

        ValueTask Handle(EnvoltorioSeleccionarTodosAlumnos alumnos);
    }
}
