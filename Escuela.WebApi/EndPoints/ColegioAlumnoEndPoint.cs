using Escuela.BusinessRules.Interfaces.Controladores;

public static class ColegioAlumnoEndPoint
{
    public static WebApplication GetAlumnoEndPoint(this WebApplication app)
    {
        app.MapGet("/alumno/{id}", async (IGetAlumnoByIdController controller, int id) =>
        {
            var alumno = await controller.GetAlumno(id);

            if (alumno == null)
            {
                return Results.StatusCode(StatusCodes.Status500InternalServerError);
            }
            else if (alumno.NumeroError != 0 && !string.IsNullOrEmpty(alumno.Mensaje))
            {
                return Results.BadRequest(alumno);
            }
            else
            {
                return Results.Ok(alumno);
            }
        });

        return app;
    }


}


