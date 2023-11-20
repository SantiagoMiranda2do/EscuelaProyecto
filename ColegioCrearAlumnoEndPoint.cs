public static class ColegioCrearAlumnoEndPoint
{
    public static WebApplication CreateAlumnoEndPoint(this WebApplication app)
    {
        app.MapPost("/create", async (CrearAlumnoRequest request, ICreateAlumnoController controller) =>
        {
            var result = await controller.CreateAlumno(request);

            if (!string.IsNullOrEmpty(result.Mensaje) || result.ValidationErrors != null)
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
}
