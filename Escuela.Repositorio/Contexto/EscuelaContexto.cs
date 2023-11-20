using Escuela.Entidades.Entidades;
using Escuela.Repositorio.Configuraciones;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Escuela.Repositorio.Contexto
{
    public class EscuelaContexto : DbContext
    {


        // El constructor recibe opciones de configuración de DbContext.
        public EscuelaContexto(DbContextOptions<EscuelaContexto> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=colegio;User=root;Password=root;");



        }

        // DbSet define propiedades para acceder a las tablas en la base de datos.
        public DbSet<Alumno> alumnos { get; set; }
        public DbSet<Curso> cursos { get; set; }
        public DbSet<Materia> materias { get; set; }
        public DbSet<Profesor> profesores { get; set; }


        // Este método se llama al configurar el modelo de base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica configuraciones de entidades desde el ensamblado actual.
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfiguration(new ProfesorConfiguracion());
            modelBuilder.ApplyConfiguration(new AlumnoConfiguracion());
            modelBuilder.ApplyConfiguration(new MateriaConfiguracion());
            modelBuilder.ApplyConfiguration(new CursoConfiguracion());
        }

    }
}
