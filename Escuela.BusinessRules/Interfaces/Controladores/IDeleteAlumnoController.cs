using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Controladores
{
    public interface IDeleteAlumnoController
    {

        Task<EnvoltorioEliminarAlumno> EliminarAlumno(int IdActor);
    }
}
