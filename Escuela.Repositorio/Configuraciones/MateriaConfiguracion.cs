using Escuela.Entidades.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;

namespace Escuela.Repositorio.Configuraciones
{
    public class MateriaConfiguracion : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.ToTable("materias");

            builder.HasKey(m => m.IdMateria); // Clave primaria.

            builder.Property(m => m.IdMateria)
                .IsRequired()
                .HasColumnName("idmateria") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Indica el tipo de dato de la columna en MySql.
                .UseMySQLAutoIncrementColumn("idmateria"); // Indica que es una columna de identidad en MySQL.

            builder.Property(m => m.NombreMateria)
                .HasColumnName("materia") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
