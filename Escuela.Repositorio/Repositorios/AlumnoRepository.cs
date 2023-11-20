using Escuela.BusinessRules.PersonalExcepcion;
using Escuela.Entidades.Entidades;
using Escuela.Entidades.Repositorios;
using Escuela.Entidades.Repositorios.RepositorioComun;
using Escuela.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace Escuela.Repositorio.Repositorios
{
    public class AlumnoRepository : IAlumnoRepositorio
    {
        readonly EscuelaContexto _context;

        public AlumnoRepository(EscuelaContexto context)
        {
            _context = context;
        }

        public Task Add(Alumno entity)
        {
            throw new NotImplementedException();
        }

        public async Task Create(Alumno alumno)
        {
            try
            {
                await _context.AddAsync(alumno);
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task Delete(int alumnoId)
        {
            try
            {
                var result = await _context.alumnos.FirstOrDefaultAsync(a => a.IdAlumno == alumnoId && a.IsDeleted == false);
                if (result != null)
                {
                    result.IsDeleted = true;
                }
                else
                {
                    throw new DBMySqlException(404, "El registro no fue encontrado");
                }
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public Task Delete(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alumno> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Alumno>> GetAllAlumnos()
        {
            try
            {
                List<Alumno> result = new List<Alumno>();
                result = await _context.alumnos.Where(a => a.IsDeleted == false).ToListAsync();
                return result;
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public Task GetByApellido(string Apellido)
        {
            throw new NotImplementedException();
        }

        public Task GetByEdad(int Edad)
        {
            throw new NotImplementedException();
        }

        public async Task<Alumno> GetById(int alumnoId)
        {
            try
            {
                Alumno result = new Alumno();
                result = await _context.alumnos.FirstOrDefaultAsync(a => a.IdAlumno == alumnoId && a.IsDeleted == false);
                return result;
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public Task GetByName(string Nombre)
        {
            throw new NotImplementedException();
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task Update(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        Task RepositoriosComun<Alumno>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

