using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using InstitutoWeb;
using InstitutoWeb.Services;
using CurrieTechnologies.Razor.SweetAlert2;
using InstitutoServices.Services.Commons;
using InstitutoServices.Interfaces;
using InstitutoServices.Interfaces.Commons;
using InstitutoServices.Interfaces.Inscripciones;
using InstitutoServices.Interfaces.Horarios;
using InstitutoServices.Services.Horarios;
using InstitutoServices.Interfaces.MesasExamenes;
using InstitutoWeb.Services.Login;
using InstitutoServices.Services.MesasExamenes;
using InstitutoServices.Services.Inscripciones;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Logging.SetMinimumLevel(LogLevel.Debug);
string urlApi = builder.Configuration.GetValue<string>("UrlApiLocal");
if (builder.Configuration.GetValue<bool>("Remoto")==true)
     urlApi = builder.Configuration.GetValue<string>("UrlApiRemoto");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(urlApi) });
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped<IAnioCarreraService, AnioCarreraService>();
builder.Services.AddScoped<IMateriaService, MateriaService>();
builder.Services.AddScoped<IDetalleInscripcionService, DetalleInscripcionService>();
builder.Services.AddScoped<IMesaExamenService, MesaExamenService>();
builder.Services.AddScoped<IHorarioService, HorarioService>();
builder.Services.AddScoped<IDetalleHorarioService, DetalleHorarioService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IInscriptoCarreraService, InscriptoCarreraService>();
builder.Services.AddScoped<IJefaturaSeccionService, JefaturaSeccionService>();
builder.Services.AddScoped<FirebaseAuthService>();

builder.Services.AddSweetAlert2();
await builder.Build().RunAsync();
