using Escuela.BusinessRules.DTOs.DTOValidacion;
using Escuela.BusinessRules.DTOs.Request.RequestAlumno;
using Escuela.BusinessRules.Interfaces;

namespace Escuela.UseCases.Especificaciones.AlumnoEspecificaciones
{
    public class ActualizarAlumnoEspecificacion : IEspecificacion<ActualizarAlumnoRequest>
    {

        readonly ActualizarAlumnoRequest _entity;
        readonly List<ValidacionDTO> _errors = new List<ValidacionDTO>();

        public ActualizarAlumnoEspecificacion(ActualizarAlumnoRequest entity)
        {
            _entity = entity;
        }

        public List<string> ErrorMessage => throw new NotImplementedException();

        public bool IsSatisfiedBy(ActualizarAlumnoRequest entity)
        {
            throw new NotImplementedException();
        }

        public List<ValidacionDTO> IsValid()
        {
            if (_entity.IdAlumno == 0)
            {
                _errors.Add(new ValidacionDTO()
                {
                    PropertyName = "Id",
                    ErrorMessage = "Debe especificar el Id que desea actualizar"
                });
            }

            if (string.IsNullOrEmpty(_entity.NombreAlumno))
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nomre Alumno",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            if (!string.IsNullOrEmpty(_entity.NombreAlumno) && _entity.NombreAlumno.Length > 45)
            {
                _errors.Add(new ValidacionDTO
                {
                    PropertyName = "Nomre Alumno",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
