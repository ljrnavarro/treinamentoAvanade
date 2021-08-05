using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppService
    {
        Task<EmployeeRoleDto> AddEmployeeRoleAsync(EmployeeRoleDto employeeRoleDto);

        Task<List<EmployeeRoleDto>> GetAllEmployeeRoleAsync();

        Task<EmployeeRoleDto> GetByIdAsync(string id);

        Task<EmployeeRoleDto> DeleteByIdAsync(string id);

        Task<EmployeeRoleDto> UpdateAsync(EmployeeRoleDto employeeRoleDto);
    }
}
