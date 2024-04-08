using System.Linq.Expressions;

using PIMTool.Entities;

namespace PIMTool.Core.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAllAsync();

        T? GetByIdAsync(int id);

        void AddAsync(T entity);

        void UpdateAsync(T entity);

        void DeleteAsync(T entity);

        void DeleteMultipleAsync(Expression<Func<T, bool>> where);

        void Delete(int id);

        void Delete(int[] ids);

        IQueryable<T> GetByConditionAsync(Expression<Func<T, bool>> condition);
    }
}