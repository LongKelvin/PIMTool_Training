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

        public RepositoryWrapper(PIMToolDbContext context)
        {
            _dbContext = context;
            _project = new ProjectRepository(_dbContext);
            _group = new GroupRepository(_dbContext);
            _employee = new EmployeeRepository(_dbContext);
        }

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

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}