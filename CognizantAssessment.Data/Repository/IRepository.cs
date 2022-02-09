using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CognizantAssessment.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        T GetSingleOrDefault(Func<T, bool> predicate);
        T GetLastOrDefault(Func<T, bool> predicate);
        T GetFirstOrDefault(Func<T, bool> predicate);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllWithInclude(Expression<Func<T, object>> orderBy, string includeObj);
        Task<List<T>> GetAllAsync();
    }
}
