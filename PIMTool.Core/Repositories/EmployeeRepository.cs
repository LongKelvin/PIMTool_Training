using PIMTool.Core.Repositories.Interfaces;
using PIMTool.DataAccess;
using PIMTool.Entities;

namespace PIMTool.Core.Repositories
{
    public class EmployeeRepository(PIMToolDbContext context) : RepositoryBase<Employee>(context), IEmployeeRepository
    {
    }
}
