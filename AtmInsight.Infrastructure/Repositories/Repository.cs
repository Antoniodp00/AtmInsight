using AtmInsight.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtmInsight.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace AtmInsight.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            //Localiza dinamicamente la tabla correspondiente a la entidad T
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task<T?> GetByIdAsync(object id) => await _dbSet.FindAsync(id);

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity != null)
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
      
    }
}
