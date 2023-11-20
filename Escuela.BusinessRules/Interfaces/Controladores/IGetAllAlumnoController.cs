using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Controladores
{
    public interface IGetAllAlumnoController
    {

        ValueTask<EnvoltorioSeleccionarTodosAlumnos> GetAlumnos();
    }
}
