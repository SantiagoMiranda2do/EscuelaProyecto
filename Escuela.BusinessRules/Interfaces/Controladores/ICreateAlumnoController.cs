using Escuela.BusinessRules.DTOs.Request.RequestAlumno;
using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Controladores
{
    public interface ICreateAlumnoController
    {

        Task<EnvoltorioCrearAlumno> CrearAlumno(CrearAlumnoRequest request);
    }
}
