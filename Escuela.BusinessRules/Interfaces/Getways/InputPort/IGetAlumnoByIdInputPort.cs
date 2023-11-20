namespace Escuela.BusinessRules.Interfaces.Getways.InputPort
{
    public interface IGetAlumnoByIdInputPort
    {
        Task Handle(int idAlumno);
    }
}
