using PIMTool.Core.Repositories.Interfaces;
using PIMTool.DataAccess;
using PIMTool.Entities;

namespace PIMTool.Core.Repositories
{
    public class ProjectEmployeeRepository(PIMToolDbContext context) : RepositoryBase<ProjectEmployee>(context), IProjectEmployeeRepository
    {
    }
}
