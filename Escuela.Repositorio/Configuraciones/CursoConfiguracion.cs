using Escuela.Entidades.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;

namespace Escuela.Repositorio.Configuraciones
{
    public class CursoConfiguracion : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("cursos");

            builder.HasKey(c => c.IdCurso); // Clave primaria.

            builder.Property(c => c.IdCurso)
                .IsRequired()
                .HasColumnName("idcurso") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Indica el tipo de dato de la columna en MySql.
                .UseMySQLAutoIncrementColumn("idcurso"); // Indica que es una columna de identidad en MySQL.

            builder.Property(c => c.NombreCurso)
                .HasColumnName("nombrecurso") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
