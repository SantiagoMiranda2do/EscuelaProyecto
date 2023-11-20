﻿using Escuela.BusinessRules.Envoltorios.Alumnos;
using Escuela.BusinessRules.Interfaces.Getways.OutputPort;

namespace Escuela.BusinessRules.Interfaces.Presentadores
{
    public interface ICreateAlumnoPresenter : ICreateAlumnoOutputPort
    {

        EnvoltorioCrearAlumno Alumno { get; }
    }
}
