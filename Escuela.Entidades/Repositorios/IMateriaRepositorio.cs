namespace Escuela.Entidades.Repositorios
{
    public interface IMateriaRepositorio
    {
        Task Add(string NombreMateria);
        Task Update(string NombreMateria);
        Task Delete(int id);
        Task GetById(int id);
    }
}
