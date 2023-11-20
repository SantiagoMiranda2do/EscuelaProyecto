using Escuela.Entidades.Entidades.EntidadComun;

namespace Escuela.Entidades.Entidades
{
    public class Alumno : Persona
    {
        public int IdAlumno { get; set; }
        public Curso Nivel { get; set; }
        public int Nota { get; set; }
        public bool IsDeleted { get; set; }
    }
}
