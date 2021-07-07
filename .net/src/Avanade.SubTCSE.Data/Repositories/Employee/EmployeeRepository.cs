using Avanade.SubTCSE.Data.Repositories.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repositories;

namespace Avanade.SubTCSE.Data.Repositories.Employee
{
    public class EmployeeRepository : 
        BaseRepository<Projeto.Domain.Aggregates.Employee.Entities.Employee, string>
        ,IEmployeeRepository
    {
      
    }
}
