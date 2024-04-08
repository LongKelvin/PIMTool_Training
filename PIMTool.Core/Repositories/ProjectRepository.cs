using PIMTool.Core.Repositories.Interfaces;
using PIMTool.DataAccess;
using PIMTool.Entities;

namespace PIMTool.Core.Repositories
{
    public class ProjectRepository(PIMToolDbContext context) : RepositoryBase<Project>(context), IProjectRepository
    {
    }
}