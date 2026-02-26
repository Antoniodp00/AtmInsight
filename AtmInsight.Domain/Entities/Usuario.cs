using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AtmInsight.Domain.Entities
{
    public class Usuario
    {
public long id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty; // Almacena el hash de la contraseña
        public string NombreCompleto { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty; // Ejemplo: "Usuario", "Tecnico"
        public string IdiomaPreferido { get; set; } = "es"; // Valor predeterminado: español
        public bool Activo { get; set; } = true; // Indica si el usuario está activo o inactivo

        [JsonIgnore]
        public virtual ICollection<Incidencia> IncidenciasAsignadas { get; set; } = new List<Incidencia>(); // Para técnicos



    }
}
