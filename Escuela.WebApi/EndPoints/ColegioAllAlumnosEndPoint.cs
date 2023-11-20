using Escuela.BusinessRules.Interfaces.Controladores;

public static class ColegioAllAlumnosEndPoint
{
    public static WebApplication GetAllAlumnoEndPoint(this WebApplication app)
    {
        app.MapGet("/alumno", async (IGetAllAlumnoController controller) =>
        {
            var alumnos = await controller.GetAlumnos();

            if (alumnos == null)
            {
                return Results.StatusCode(StatusCodes.Status500InternalServerError);
            }
            else if (alumnos.NumeroError != 0 && !string.IsNullOrEmpty(alumnos.Mensaje))
            {
                return Results.BadRequest(alumnos);
            }
            else
            {
                return Results.Ok(alumnos);
            }
        });

        return app;
    }


}
