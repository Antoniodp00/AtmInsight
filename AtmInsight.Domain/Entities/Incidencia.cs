using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Domain.Entities
{
    public class Incidencia
    {
        public long Id { get; set; }
        public string AtmId { get; set; } = string.Empty;
        public long? TecnicoId { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty; // Ejemplo: "Abierta", "En Progreso", "Cerrada"
        public int Prioridad { get; set; } // Ejemplo: 1 (Alta), 2 (Media), 3 (Baja)

        public virtual Cajero? Cajero { get; set; } = null!;
        public virtual Usuario? Tecnico { get; set; } = null!;
    }
}
