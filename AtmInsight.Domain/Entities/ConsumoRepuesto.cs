using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Domain.Entities
{
    public class ConsumoRepuesto
    {
        public long Id { get; set; }
       public long IncidenciaId { get; set; }
        public long RepuestoId { get; set; }
        public int Cantidad { get; set; }
        public virtual Incidencia? Incidencia { get; set; } = null!;
        public virtual Repuesto? Repuesto { get; set; }
    }
}
