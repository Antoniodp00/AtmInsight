using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Domain.Entities
{
    public class Repuesto
    {
        public long Id { get; set; }
        public string Referencia { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int StokActual { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
