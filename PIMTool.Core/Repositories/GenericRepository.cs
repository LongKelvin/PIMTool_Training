using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using PIMTool.Core.Repositories.Interfaces;
using PIMTool.DataAccess;

namespace PIMTool.Core.Repositories
{
    public class RepositoryBase<T>(PIMToolDbContext context) : IGenericRepository<T> where T : class
    {
        private readonly PIMToolDbContext _context = context;

        public void AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void DeleteMultipleAsync(Expression<Func<T, bool>> where)
        {
            var deleteEnties = _context.Set<T>().Where(where);
            _context.Set<T>().RemoveRange(deleteEnties);
        }

        public IQueryable<T> GetAllAsync()
        {
            return _context.Set<T>().AsQueryable().AsNoTracking();
        }

        public IQueryable<T> GetByConditionAsync(Expression<Func<T, bool>> condition)
        {
            return _context.Set<T>().Where(predicate: condition);
        }

        public T? GetByIdAsync(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}