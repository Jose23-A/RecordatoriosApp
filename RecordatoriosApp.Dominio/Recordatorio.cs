using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordatoriosApp.Dominio
{
    public class Recordatorio
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaProgramada { get; private set; }
        public bool EstaCompletado { get; private set; }

        public Recordatorio(string titulo, DateTime fechaProgramada) 
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                throw new ArgumentException("El título es obligatorio para crear un recordatorio.");
            }

            Id = Guid.NewGuid();
            Titulo = titulo;
            FechaProgramada = fechaProgramada;
            EstaCompletado = false;
        }

        public void MarcarComoCompletado()
        {
            EstaCompletado = true;
        }

    }
}
