using System.Linq.Expressions;

namespace PIMTool.Core.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAllAsync();

        T? GetByIdAsync(int id);

        void AddAsync(T entity);

        void UpdateAsync(T entity);

        void DeleteAsync(T entity);

        void DeleteMultipleAsync(Expression<Func<T, bool>> where);

        IQueryable<T> GetByConditionAsync(Expression<Func<T, bool>> condition);
    }
}