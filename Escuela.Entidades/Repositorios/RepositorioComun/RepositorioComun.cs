namespace Escuela.Entidades.Repositorios.RepositorioComun
{
    public interface RepositoriosComun<T> where T : class
    {
        Task GetById(int id);
        Task GetByName(string Nombre);
        Task GetByApellido(string Apellido);
        Task GetByEdad(int Edad);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task SaveChanges();
    }
}
