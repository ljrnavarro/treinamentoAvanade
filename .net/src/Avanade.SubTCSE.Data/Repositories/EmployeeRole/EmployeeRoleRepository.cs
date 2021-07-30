using Avanade.SubTCSE.Data.Repositories.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using System;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Data.Repositories.EmployeeRole
{
    public class EmployeeRoleRepository : BaseRepository<Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>
        , IEmployeeRoleRepository
    {
        public override Task<Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole> AddAsync(Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole entity)
        {
            //fazer qq coisa
            return base.AddAsync(entity);
        }
    }

}
