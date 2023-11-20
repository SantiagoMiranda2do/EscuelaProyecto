using Escuela.Entidades.Entidades;
using Escuela.Entidades.Repositorios.RepositorioComun;

namespace Escuela.Entidades.Repositorios
{
    public interface IProfesoresRepositorio : RepositoriosComun<Profesor>, IUnitOfWork
    {
        Task AsignarProfesor(int IdProfesor, int IdMateria);
        Task<IEnumerable<object>> GetAllProfesores();
    }
}
