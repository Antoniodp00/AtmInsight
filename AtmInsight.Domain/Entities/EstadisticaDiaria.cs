using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Domain.Entities
{
    public class EstadisticaDiaria
    {
        public int Id { get; set; }
        public string AtmId { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public int TotalTransacciones { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoPromedio { get; set; }
        public int UsuariosUnicos { get; set; }
        public int TransaccionesRetiro { get; set; }
        public int TransaccionesDeposito { get; set; }
        public int TransaccionesConsultaSaldo { get; set; }
        [ForeignKey("AtmId")]
        public virtual Cajero? Cajero { get; set; } = null!;
    }
}
