using Dependencyinversion;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.

builder.Services.AddEscuelaServices(builder.Configuration, "MySqlEscuela");
builder.Services.AddControllers();
//Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.DeleteAlumnoEndPoint();
app.GetAlumnoEndPoint();
app.UseHttpsRedirection();
app.CreateAlumnoEndPoint();
app.GetAllAlumnoEndPoint();

app.UseAuthorization();

app.MapControllers();

app.Run();


