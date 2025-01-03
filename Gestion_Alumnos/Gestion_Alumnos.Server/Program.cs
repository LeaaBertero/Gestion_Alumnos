using Gestion_Alumnos.BD.Data;
using Gestion_Alumnos.Server.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

//-------------------------------------------------------------------------------
//configuracion de los servicios en el constructor de la aplicación
var builder = WebApplication.CreateBuilder(args);

//ignora ciclos
#region codigo para ignorar ciclos
builder.Services.AddControllers().AddJsonOptions(
    x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
#endregion

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//conexion con la base de datos
#region Conexion con la base de datos
builder.Services.AddDbContext<Context>(op => op.UseSqlServer("name=conn"));
#endregion


//Servicio de AutoMapper
#region AutoMapper
builder.Services.AddAutoMapper(typeof(Program));
#endregion

//constructor de la interfáz de alumno
#region constructor de la interfaz Alumno
builder.Services.AddScoped<IAlumnoRepositorio, AlumnoRepositorio>();
#endregion

#region constructor de la interfaz Materia
builder.Services.AddScoped<IMateriaRepositorio, MateriaRepositorio>();
#endregion

//--------------------------------------------------------------------------------
//construcción de la aplicación
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
