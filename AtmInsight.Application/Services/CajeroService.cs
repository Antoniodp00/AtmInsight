using AtmInsight.Application.Repositories;
using AtmInsight.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Application.Services
{
    public class CajeroService
    {
        private readonly IRepository<Cajero> _cajeroRepository;

        public CajeroService(IRepository<Cajero> cajeroRepository)
        {
            _cajeroRepository = cajeroRepository;
        }

        public async Task<IEnumerable<Cajero>> ObtenerTodosAsync()
        {
            return await _cajeroRepository.GetAllAsync();
        }

        public async Task<Cajero?> ObtenerPorIdAsync(string id)
        {
            return await _cajeroRepository.GetByIdAsync(id);
        }

        public async Task AgregarAsync(Cajero cajero)
        {
            await _cajeroRepository.AddAsync(cajero);
        }

        public async Task ActualizarAsync(Cajero cajero)
        {
            await _cajeroRepository.UpdateAsync(cajero);
        }

        public async Task EliminarAsync(Cajero cajero)
        {
            await _cajeroRepository.DeleteAsync(cajero);
        }
    }
}