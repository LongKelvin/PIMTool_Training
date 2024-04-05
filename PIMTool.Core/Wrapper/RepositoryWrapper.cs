using PIMTool.Core.Repositories;
using PIMTool.Core.Repositories.Interfaces;
using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.DataAccess;

namespace PIMTool.Core.Wrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly PIMToolDbContext _dbContext;
        private IProjectRepository _project;
        private IGroupRepository _group;
        private IEmployeeRepository _employee;
        private IProjectEmployeeRepository _projectEmployee;

        public IProjectRepository Projects
        {
            get
            {
                _project ??= new ProjectRepository(_dbContext);
                return _project;
            }
        }



        public IEmployeeRepository Employees
        {
            get
            {
                _employee ??= new EmployeeRepository(_dbContext);
                return _employee;
            }
        }

        public IGroupRepository Groups
        {
            get
            {
                _group ??= new GroupRepository(_dbContext);
                return _group;
            }
        }

        public IProjectEmployeeRepository ProjectEmployees
        {
            get
            {
                _projectEmployee ??= new ProjectEmployeeRepository(_dbContext);
                return _projectEmployee;
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
