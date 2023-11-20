using Escuela.BusinessRules.DTOs.DTOValidacion;

namespace Escuela.BusinessRules.Envoltorios.Alumnos
{
    public class EnvoltorioCrearAlumno : EnvoltorioBase
    {


        public int IdAlumno { get; set; }
        public List<ValidacionDTO>? ValidacionErrores { get; set; }
    }
}
