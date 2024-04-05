using System.Linq.Expressions;

using PIMTool.Entities;

namespace PIMTool.Core.Repositories.Interfaces
{
    public interface IProjectEmployeeRepository
    {
        IQueryable<ProjectEmployee> GetAllAsync();

        IQueryable<ProjectEmployee>? GetByIdAsync(int projectId);

        void AddAsync(ProjectEmployee entity);

        void UpdateAsync(ProjectEmployee entity);

        void DeleteAsync(ProjectEmployee entity);

        void DeleteMultipleAsync(Expression<Func<ProjectEmployee, bool>> where);

        IQueryable<ProjectEmployee> GetByConditionAsync(Expression<Func<ProjectEmployee, bool>> condition);
    }
}