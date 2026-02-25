using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Domain.Entities
{
    public class Cajero
    {
        public string Id { get; set; } = string.Empty;
        public string Ubicacion { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
        public string? Modelo { get; set; }

        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }

        public bool Activo { get; set; } = true;
    }
}
