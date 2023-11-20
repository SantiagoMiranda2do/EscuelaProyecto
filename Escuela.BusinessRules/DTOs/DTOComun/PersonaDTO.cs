namespace Escuela.BusinessRules.DTOs.DTOComun
{
    public class PersonaDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
        public int DNI { get; set; }
    }
}
