using Escuela.Entidades.Entidades;
using Escuela.Entidades.Repositorios.RepositorioComun;

namespace Escuela.Entidades.Repositorios
{
    public interface IAlumnoRepositorio : RepositoriosComun<Alumno>, IUnitOfWork
    {
        new Task<Alumno> GetById(int AlumnoId);
        Task Create(Alumno alumno);
        new Task Update(Alumno alumno);
        Task Delete(Alumno alumno);
        Task<List<Alumno>> GetAllAlumnos();
    }
}
