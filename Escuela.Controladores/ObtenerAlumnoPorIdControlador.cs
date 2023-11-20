using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Controladores;
using Escuela.BusinessRules.Interfaces.Getways.InputPort;
using Escuela.BusinessRules.Interfaces.Presentadores;

namespace Escuela.Controladores
{
    public class ObtenerAlumnoPorIdControlador : IGetAlumnoByIdController
    {

        readonly IGetAlumnoByIdInputPort _inputPort;
        readonly IGetAlumnoByIdPresenter _presenter;


        public ObtenerAlumnoPorIdControlador(IGetAlumnoByIdInputPort inputPort, IGetAlumnoByIdPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }

        async Task<EnvoltorioSeleccionarAlumno> IGetAlumnoByIdController.GetAlumno(int IdAlumno)
        {
            await _inputPort.Handle(IdAlumno);
            return _presenter.Alumno;
        }
    }
}
