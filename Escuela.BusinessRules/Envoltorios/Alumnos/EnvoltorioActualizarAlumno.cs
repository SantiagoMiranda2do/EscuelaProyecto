using Escuela.BusinessRules.DTOs.DTOValidacion;

namespace Escuela.BusinessRules.Envoltorios.Alumnos
{
    public class EnvoltorioActualizarAlumno : EnvoltorioBase
    {

        public int IdAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public List<ValidacionDTO>? ValidationErrors { get; set; }
    }
}
