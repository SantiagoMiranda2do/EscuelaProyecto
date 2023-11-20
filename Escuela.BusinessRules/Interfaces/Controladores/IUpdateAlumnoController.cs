using Escuela.BusinessRules.DTOs.Request.RequestAlumno;
using Escuela.BusinessRules.Envoltorios.Alumnos;

namespace Escuela.BusinessRules.Interfaces.Controladores
{
    public interface IUpdateAlumnoController
    {
        Task<EnvoltorioActualizarAlumno> ActualizarAlumno(ActualizarAlumnoRequest request);
    }

}