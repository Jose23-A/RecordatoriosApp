using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordatoriosApp.Dominio;
using System.Threading.Tasks;

namespace RecordatoriosApp.Aplicacion.Interfaces
{
    public interface IRecordatorioRepository
    {
        Task AgregarAsync(Recordatorio recordatorio);
    }
}
