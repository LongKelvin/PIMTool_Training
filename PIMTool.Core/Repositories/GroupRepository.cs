using PIMTool.Core.Repositories.Interfaces;
using PIMTool.DataAccess;
using PIMTool.Entities;

namespace PIMTool.Core.Repositories
{
    public class GroupRepository(PIMToolDbContext context) : RepositoryBase<Group>(context), IGroupRepository
    {
    }
}