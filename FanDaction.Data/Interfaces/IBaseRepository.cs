using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace FanDaction.Data.Interfaces
{
    public interface IBaseRepository<T> : IDisposable
        where T : class
    {
        IQueryable<T> AsQueryable();
        IEnumerable<T> All();
        Task<IEnumerable<T>> AllAsync();

        bool Any(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        IPagedList<T> Where(Expression<Func<T, bool>> predicate, int pageNumber, int pageSize);

        T Find(Expression<Func<T, bool>> predicate);
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
        T FindById(int id);
        Task<T> FindByIdAsync(int id);
        bool Contains(Expression<Func<T, bool>> predicate);
        Task<bool> ContainsAsync(Expression<Func<T, bool>> predicate);
        int Count { get; }

        T Create(T t);
        Task<T> CreateAsync(T t);
        int Update(T t);
        Task<int> UpdateAsync(T t);
        int Delete(T t);
        Task<int> DeleteAsync(T t);
        int Delete(Expression<Func<T, bool>> predicate);
        Task<int> DeleteAsync(Expression<Func<T, bool>> predicate);
    }
}
