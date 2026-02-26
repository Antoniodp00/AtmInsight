using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Application.Interfaces
{
    public interface IAuthService
    {
        // Recibe credenciales y devuelve el token o null si falla
        Task<string?> LoginAsync(string username, string password);
    }
}
