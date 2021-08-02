using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole : BaseEntity<string>
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
            RoleName = roleName;
        }

        public EmployeeRole(string roleName)
        {
            Id = Guid.NewGuid().ToString();
            RoleName = roleName;
        }

        public string RoleName { get; set; }
    }
}
