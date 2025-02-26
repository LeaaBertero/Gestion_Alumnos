using Gestion_Alumnos.Client;
using Gestion_Alumnos.Client.Servicios;
using Gestion_Alumnos.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<AlumnoService>();
#region Servicio Http
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
#endregion

//Contrucción del servicio de la interfáz de HttpServicio
#region Servicio de Interfaz HttpServicio
builder.Services.AddScoped<IHttpServicio,HttpServicio>();
builder.Services.AddSingleton<ServicioMostrarMenu>();
#endregion

await builder.Build().RunAsync();
