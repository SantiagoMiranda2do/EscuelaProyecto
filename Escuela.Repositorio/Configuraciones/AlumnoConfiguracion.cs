using Escuela.Entidades.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escuela.Repositorio.Configuraciones
{
    public class AlumnoConfiguracion : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> builder)
        {
            builder.ToTable("alumnos");

            builder.HasKey(a => a.IdAlumno); // Clave primaria.

            builder.Property(a => a.IdAlumno)
                .IsRequired()
                .HasColumnName("idAlumno") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Indica el tipo de dato de la columna en MySql.
               .HasAnnotation("MySQL:AutoIncrement", true); // Indica que es una columna de identidad en MySQL.

            builder.Property(a => a.Nombre)
                .HasColumnName("Nombre") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(a => a.Apellido)
    .HasColumnName("Apellido") // Nombre de la columna en la base de datos MySQL.
    .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
    .HasMaxLength(45)
    .IsRequired();

            builder.Property(a => a.Telefono)
                .HasColumnName("Telefono") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Indica el tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(a => a.Departamento)
                .HasColumnName("Departamento") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Indica el tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(a => a.Direccion)
                .HasColumnName("Direccion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.DNI)
                .HasColumnName("DNI") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(15)
                .IsRequired();


        }
    }
}
