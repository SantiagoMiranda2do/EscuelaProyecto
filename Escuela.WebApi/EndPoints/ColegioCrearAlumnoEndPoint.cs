using Escuela.BusinessRules.DTOs.Request.RequestAlumno;
using Escuela.BusinessRules.Interfaces.Controladores;

public static class ColegioCrearAlumnoEndPoint
{
    public static WebApplication CreateAlumnoEndPoint(this WebApplication app)
    {
        app.MapPost("/create", async (CrearAlumnoRequest request, ICreateAlumnoController controller) =>
        {
            var result = await controller.CrearAlumno(request);

            if (!string.IsNullOrEmpty(result.Mensaje) || result.ValidacionErrores != null)
            {
                return Results.BadRequest(result);
            }
            else
            {
                return Results.Ok(result);
            }

        });

        return app;
    }

}

