using System.Linq.Expressions;

using PIMTool.Core.Repositories.Interfaces;
using PIMTool.DataAccess;
using PIMTool.Entities;

namespace PIMTool.Core.Repositories
{
    public class ProjectEmployeeRepository(PIMToolDbContext context) : IProjectEmployeeRepository
    {
        private readonly PIMToolDbContext _context = context;

        public void AddAsync(ProjectEmployee entity)
        {
            _context.Set<ProjectEmployee>().Add(entity);
        }

        public void DeleteAsync(ProjectEmployee entity)
        {
            _context.Set<ProjectEmployee>().Remove(entity);
        }

        public void DeleteMultipleAsync(Expression<Func<ProjectEmployee, bool>> where)
        {
            var objToDelete = _context.Set<ProjectEmployee>().Where(where);
            _context.Set<ProjectEmployee>().RemoveRange(objToDelete);
        }

        public IQueryable<ProjectEmployee> GetAllAsync()
        {
            return _context.Set<ProjectEmployee>();
        }

        public IQueryable<ProjectEmployee> GetByConditionAsync(Expression<Func<ProjectEmployee, bool>> condition)
        {
            return _context.Set<ProjectEmployee>().Where(condition);
        }

        public IQueryable<ProjectEmployee>? GetByIdAsync(int projectId)
        {
            return _context.Set<ProjectEmployee>().Where(x => x.ProjectId == projectId);
        }

        public void UpdateAsync(ProjectEmployee entity)
        {
            _context.Set<ProjectEmployee>().Update(entity);
        }
    }
}