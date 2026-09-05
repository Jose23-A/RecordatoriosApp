using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordatoriosApp.Aplicacion.Interfaces;
using RecordatoriosApp.Dominio;
using System.Threading.Tasks;

namespace RecordatoriosApp.Infraestructura
{
    // Esta clase concreta implementa la interfaz abstracta IRecordatorioRepository
    public class RecordatorioRepository : IRecordatorioRepository
    {
        private readonly AppDbContext _context;

        // Inyección de Dependencias: solicitamos el DbContext en el constructor.
        // Nunca usamos "new AppDbContext()", delegamos su creación al framework.
        public RecordatorioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AgregarAsync(Recordatorio recordatorio)
        {
            // AddAsync solo rastrea el objeto en memoria (prepara el buffer).
            // Aún no hace el INSERT en SQL Server.
            await _context.Recordatorios.AddAsync(recordatorio);
        }

        public async Task GuardarCambiosAsync()
        {
            // SaveChangesAsync abre una transacción, ejecuta el comando SQL y hace un COMMIT.
            await _context.SaveChangesAsync();
        }
    }
}