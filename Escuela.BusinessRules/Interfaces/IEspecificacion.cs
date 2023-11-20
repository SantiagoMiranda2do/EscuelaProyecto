namespace Escuela.BusinessRules.Interfaces
{
    public interface IEspecificacion<T> where T : class
    {
        List<string> ErrorMessage { get; }
        bool IsSatisfiedBy(T entity);


    }
}
