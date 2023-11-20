using Escuela.BusinessRules.DTOs.Respuestas;

namespace Escuela.BusinessRules.Envoltorios.Alumnos
{
    public class EnvoltorioSeleccionarAlumno : EnvoltorioBase
    {
        public RespuestaAlumno Alumno { get; set; }
        public int IdAlumno { get; set; }
        public string NombreAlumno { get; set; }

    }
}
