using PIMTool.Core.Repositories.Interfaces;

namespace PIMTool.Core.Wrapper.Interfaces
{
    public interface IRepositoryWrapper
    {
        IProjectRepository Projects { get; }
        IEmployeeRepository Employees { get; }
        IGroupRepository Groups { get; }
        IProjectEmployeeRepository ProjectEmployees { get; }

        void Save();
    }
}