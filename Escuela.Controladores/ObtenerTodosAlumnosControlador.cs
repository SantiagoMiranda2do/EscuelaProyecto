using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Controladores;
using Escuela.BusinessRules.Interfaces.Getways.InputPort;
using Escuela.BusinessRules.Interfaces.Presentadores;

namespace Escuela.Controladores
{
    public class ObtenerTodosAlumnosControlador : IGetAllAlumnoController
    {
        readonly IGetAllAlumnosInputPort _inputPort;
        readonly IGetAllAlumnosPresenter _presenter;


        public ObtenerTodosAlumnosControlador(IGetAllAlumnosInputPort inputPort, IGetAllAlumnosPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }


        public async ValueTask<EnvoltorioSeleccionarTodosAlumnos> GetAlumnos()
        {
            await _inputPort.Handle();
            return _presenter.Alumno;
        }
    }
}
