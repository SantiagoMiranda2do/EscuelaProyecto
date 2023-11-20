using Escuela.BusinessRules.DTOs.DTOValidacion;
using Escuela.BusinessRules.DTOs.Request.RequestAlumno;
using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Getways.InputPort;
using Escuela.BusinessRules.Interfaces.Presentadores;
using Escuela.BusinessRules.PersonalExcepcion;
using Escuela.Entidades.Entidades;
using Escuela.Entidades.Repositorios;
using Escuela.UseCases.Especificaciones.AlumnoEspecificaciones;

namespace Escuela.UseCases.CasosDeUso
{
    public class CrearAlumnoIteractor : ICreateAlumnoInputPort
    {
        readonly IAlumnoRepositorio _repository;
        readonly ICreateAlumnoPresenter _presenter;

        /// <summary>
        /// Constructor de la clase CreateAlumnoIteractor.
        /// </summary>
        /// <param name="repository">El repositorio de alumnos.</param>
        /// <param name="presenter">El presentador para la creación de alumnos.</param>
        public CrearAlumnoIteractor(IAlumnoRepositorio repository, ICreateAlumnoPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        /// <summary>
        /// Maneja la creación de un nuevo alumno.
        /// </summary>
        /// <param name="createAlumnoRequest">Los datos para crear el alumno.</param>
        /// <returns>El ID del nuevo alumno creado o 0 si hubo errores.</returns>
        public async Task Handle(CrearAlumnoRequest createAlumnoRequest)
        {
            List<ValidacionDTO> errors = new List<ValidacionDTO>();
            errors = ValidateAlumno(createAlumnoRequest);
            EnvoltorioCrearAlumno alumnoResponse = new();

            if (errors.Any())
            {
                alumnoResponse.ValidacionErrores = errors;
                await _presenter.Handle(alumnoResponse);
                return;
            }

            Alumno newAlumno = new()
            {
                Nombre = createAlumnoRequest.NombreAlumno
            };

            try
            {
                await _repository.Create(newAlumno);
                await _repository.SaveChange();
                alumnoResponse.IdAlumno = newAlumno.IdAlumno;
            }
            catch (DBMySqlException ex)
            {
                alumnoResponse.NumeroError = ex.Numero;
                alumnoResponse.Mensaje = ex.ErrorMensaje;
            }
            finally
            {
                await _presenter.Handle(alumnoResponse);
            }
        }

        private List<ValidacionDTO> ValidateAlumno(CrearAlumnoRequest createAlumnoRequest)
        {
            var specification = new CrearAlumnoEspecificacion(createAlumnoRequest);
            return specification.IsValid();
        }
    }
}
