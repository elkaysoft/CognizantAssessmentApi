using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CognizantAssessment.Data.Repository
{
    public class EntityRepository<T> : IRepository<T> where T : class
    {
        private VehicleStoreContext _context;
        private DbSet<T> _dbSet;

        public EntityRepository(VehicleStoreContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task<List<T>> GetAllWithInclude(Expression<Func<T, object>> orderBy, string includeObj)
        {
            IOrderedQueryable<T> query = _dbSet.Include(includeObj).OrderBy(orderBy);
            return await query.ToListAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public T GetFirstOrDefault(Func<T, bool> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public T GetLastOrDefault(Func<T, bool> predicate)
        {
            return _dbSet.LastOrDefault(predicate);
        }

        public T GetSingleOrDefault(Func<T, bool> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }
    }
}
