using RecordatoriosApp.Aplicacion.DTOs;
using RecordatoriosApp.Aplicacion.Interfaces;
using RecordatoriosApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordatoriosApp.Aplicacion.CasosDeUso
{
    public class CrearRecordatorioUseCase : ICrearRecordatorioUseCase
    {
        private readonly IRecordatorioRepository _repositorio;

        public CrearRecordatorioUseCase(IRecordatorioRepository repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task EjecutarAsync(CrearRecordatorioDto dto)
        {
            if(dto.FechaPrograma < DateTime.Now)
            {
                throw new InvalidOperationException("No puedes programar un recordatorio en el pasado.");
            }

            var nuevoRecordatorio = new Recordatorio(dto.Titulo, dto.FechaPrograma);

            await Task.CompletedTask;
        }
    }
}
