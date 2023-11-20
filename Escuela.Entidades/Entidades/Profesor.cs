using Escuela.Entidades.Entidades.EntidadComun;

namespace Escuela.Entidades.Entidades
{
    public class Profesor : Persona
    {
        public int IdProfesor { get; set; }
        public object Materias { get; set; }
    }
}
