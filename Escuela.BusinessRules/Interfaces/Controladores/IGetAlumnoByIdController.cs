using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Controladores
{
    public interface IGetAlumnoByIdController
    {

        Task<EnvoltorioSeleccionarAlumno> GetAlumno(int IdAlumno);
    }
}
