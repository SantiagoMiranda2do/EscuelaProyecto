namespace Escuela.BusinessRules.Interfaces.Getways.InputPort
{
    public interface IDeleteAlumnoInputPort
    {
        Task Handle(int idAlumno);
    }
}
