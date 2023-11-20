using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Getways.InputPort;
using Escuela.BusinessRules.Interfaces.Presentadores;
using Escuela.BusinessRules.PersonalExcepcion;
using Escuela.Entidades.Repositorios;

namespace Escuela.UseCases.CasosDeUso
{
    public class EliminarAlumnoInteractor : IDeleteAlumnoInputPort
    {
        private readonly IAlumnoRepositorio _repository;
        private readonly IDeleteAlumnoPresenter _presenter;

        public EliminarAlumnoInteractor(IAlumnoRepositorio repository, IDeleteAlumnoPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int idAlumno)
        {

            EnvoltorioEliminarAlumno alumnoResponse = new();
            try
            {
                // Eliminar el alumno
                await _repository.Delete(idAlumno);
                await _repository.SaveChange();
                alumnoResponse.IdAlumno = idAlumno;
            }
            catch (DBMySqlException ex)
            {
                // Manejar errores
                alumnoResponse.NumeroError = ex.Numero;
                alumnoResponse.Mensaje = ex.ErrorMensaje;
            }
            finally
            {
                // Notificar al presentador que se eliminó el alumno.
                await _presenter.handle(alumnoResponse);
            }
        }
    }
}
