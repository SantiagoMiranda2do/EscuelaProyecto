public static WebApplication DeleteAlumnoEndPoint(this WebApplication app)
{
    app.MapPut("/alumno/delete/{id}", async (IDeleteAlumnoController controller, int id) =>
    {
        var alumno = await controller.DeleteAlumno(id);
        if (alumno == null)
        {
            return Results.StatusCode(StatusCodes.Status500InternalServerError);

        }
        else if (alumno.ErrorNumber != 0 && !string.IsNullOrEmpty(alumno.Mensaje))
        {
            return Results.BadRequest(alumno);
        }

        return Results.Ok(alumno);
    });
    return app;
}

    }
}
