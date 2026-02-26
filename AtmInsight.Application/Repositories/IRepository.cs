using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmInsight.Application.Repositories
{
    //La restriccion 'Where T : class' asegura que T sea una entidad de la bbdd
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        //Se susa Object porque el id puede ser string(Cajero) o long(usuario)
        Task<T?> GetByIdAsync(object id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
