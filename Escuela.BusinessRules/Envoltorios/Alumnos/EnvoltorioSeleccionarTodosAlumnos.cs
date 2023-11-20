using Escuela.BusinessRules.DTOs.Respuestas;

namespace Escuela.BusinessRules.Envoltorios.Alumnos
{
    public class EnvoltorioSeleccionarTodosAlumnos : EnvoltorioBase
    {

        public List<RespuestaAlumno>? Alumnos { get; set; } = new List<RespuestaAlumno>();
    }
}
