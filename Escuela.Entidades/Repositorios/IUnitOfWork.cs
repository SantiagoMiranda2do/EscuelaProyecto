namespace Escuela.Entidades.Repositorios
{
    public interface IUnitOfWork
    {
        Task SaveChange();
    }
}
