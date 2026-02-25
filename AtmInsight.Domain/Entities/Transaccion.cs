using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Domain.Entities
{
    public class Transaccion
    {
        public int Id { get; set; }
        public string AtmId { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
        public string Tipo { get; set; } = string.Empty; // Ejemplo: "Retiro", "Depósito", "Consulta de saldo"
        public decimal Monto { get; set; }
        public string TarjetaHash { get; set; } = string.Empty; // Para anonimizar la información de la tarjeta
        public string Resultado { get; set; } = string.Empty; // Ejemplo: "Aprobada", "Rechazada", "Error"
        public bool ProcesadaEtl { get; set; } = false; // Indica si la transacción ha sido procesada por el ETL

       public virtual Cajero? Cajero { get; set; } = null!;
    }
}
