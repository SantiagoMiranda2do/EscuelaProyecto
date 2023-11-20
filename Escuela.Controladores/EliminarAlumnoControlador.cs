using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Controladores;
using Escuela.BusinessRules.Interfaces.Getways.InputPort;
using Escuela.BusinessRules.Interfaces.Presentadores;

namespace Escuela.Controladores
{
    public class EliminarAlumnoControlador : IDeleteAlumnoController
    {
        readonly IDeleteAlumnoInputPort _inputPort;
        readonly IDeleteAlumnoPresenter _presenter;


        public EliminarAlumnoControlador(IDeleteAlumnoInputPort inputPort, IDeleteAlumnoPresenter presenter)
        {

            _inputPort = inputPort;
            _presenter = presenter;


        }

        public async Task<EnvoltorioEliminarAlumno> EliminarAlumno(int IdAlumno)
        {
            await _inputPort.Handle(IdAlumno);
            return _presenter.Alumno;
        }
    }
}
