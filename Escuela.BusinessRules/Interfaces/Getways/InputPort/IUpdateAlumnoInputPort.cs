using Escuela.BusinessRules.DTOs.Request.RequestAlumno;

namespace Escuela.BusinessRules.Interfaces.Getways.InputPort
{
    public interface IUpdateAlumnoInputPort
    {
        Task Handle(ActualizarAlumnoRequest updateAlumnoRequest);
    }
}
