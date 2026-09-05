using Microsoft.EntityFrameworkCore;
using RecordatoriosApp.Aplicacion.Interfaces;
using RecordatoriosApp.Aplicacion.CasosDeUso;
using RecordatoriosApp.Infraestructura;

var builder = WebApplication.CreateBuilder(args);

// Habilitar soporte para Controladores HTTP
builder.Services.AddControllers();

// 1. Configurar Entity Framework Core con la cadena de conexión
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Inyectar dependencias (Contrato -> Implementación concreta)
// AddScoped genera una instancia que vive exactamente lo que dura la petición HTTP.
builder.Services.AddScoped<IRecordatorioRepository, RecordatorioRepository>();
builder.Services.AddScoped<ICrearRecordatorioUseCase, CrearRecordatorioUseCase>();

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();
app.Run();