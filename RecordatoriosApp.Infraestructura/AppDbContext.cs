using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecordatoriosApp.Dominio;

namespace RecordatoriosApp.Infraestructura
{
    // Heredamos de DbContext, la clase base de Entity Framework Core
    public class AppDbContext : DbContext
    {
        // Recibimos la configuración (como el string de conexión) desde el exterior
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet representa tu tabla física en la base de datos.
        // EF Core asumirá por defecto que la tabla se llamará "Recordatorios".
        public DbSet<Recordatorio> Recordatorios { get; set; }
    }
}