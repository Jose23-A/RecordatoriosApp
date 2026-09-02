using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordatoriosApp.Aplicacion.DTOs;

namespace RecordatoriosApp.Aplicacion.Interfaces
{
    public interface ICrearRecordatorioUseCase
    {
        Task EjecutarAsync(CrearRecordatorioDto dto);
    }
}
