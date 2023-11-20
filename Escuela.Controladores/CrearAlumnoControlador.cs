using Escuela.BusinessRules.DTOs.Request.RequestAlumno;
using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Controladores;
using Escuela.BusinessRules.Interfaces.Getways.InputPort;
using Escuela.BusinessRules.Interfaces.Presentadores;

namespace Escuela.Controladores
{
    public class CrearAlumnoControlador : ICreateAlumnoController
    {
        readonly ICreateAlumnoInputPort _inputPort;
        readonly ICreateAlumnoPresenter _presenter;


        public CrearAlumnoControlador(ICreateAlumnoInputPort inputPort, ICreateAlumnoPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }



        public async Task<EnvoltorioCrearAlumno> CrearAlumno(CrearAlumnoRequest request)
        {
            await _inputPort.Handle(request);
            return _presenter.Alumno;
        }
    }
}
