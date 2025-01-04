using Gestion_Alumnos.Client;
using Gestion_Alumnos.Client.Servicios;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

#region Servicio Http
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
#endregion

//Contrucci�n del servicio de la interf�z de HttpServicio
#region Servicio de Interfaz HttpServicio
builder.Services.AddScoped<IHttpServicio,HttpServicio>();
#endregion

await builder.Build().RunAsync();
