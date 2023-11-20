using Escuela.Entidades.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;

namespace Escuela.Repositorio.Configuraciones
{
    public class ProfesorConfiguracion : IEntityTypeConfiguration<Profesor>
    {
        public void Configure(EntityTypeBuilder<Profesor> builder)
        {
            builder.ToTable("profesores");

            builder.HasKey(p => p.IdProfesor); // Clave primaria.

            builder.Property(p => p.IdProfesor)
                .IsRequired()
                .HasColumnName("idprofesor") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Indica el tipo de dato de la columna en MySql.
                .UseMySQLAutoIncrementColumn("idprofesor"); // Indica que es una columna de identidad en MySQL.

            builder.Property(p => p.Nombre)
                .HasColumnName("nombre") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Apellido)
                .HasColumnName("apellido") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(p => p.Telefono)
                .HasColumnName("telefono") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Indica el tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(p => p.Departamento)
                .HasColumnName("departamento") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") // Indica el tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(p => p.Direccion)
                .HasColumnName("direccion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.DNI)
                .HasColumnName("dni") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(p => p.Materias)
                .HasColumnName("materias") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") // Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
