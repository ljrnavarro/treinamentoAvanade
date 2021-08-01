using Avanade.SubTCSE.Data.Repositories.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repositories;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;

namespace Avanade.SubTCSE.Data.Repositories.Employee
{
    public class EmployeeRepository : 
        BaseRepository<Projeto.Domain.Aggregates.Employee.Entities.Employee, string>
        ,IEmployeeRepository
    {

        public EmployeeRepository(IMongoDBContext mongoDBContext)
           : base(mongoDBContext, "employee")
        {
        }

    }
}
