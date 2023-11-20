using Escuela.BusinessRules.DTOs.Request.RequestAlumno;

namespace Escuela.BusinessRules.Interfaces.Getways.InputPort
{
    public interface ICreateAlumnoInputPort
    {
        Task Handle(CrearAlumnoRequest crearAlumnoRequest);
    }
}
