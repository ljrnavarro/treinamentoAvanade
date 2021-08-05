using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole : BaseEntity<string>
    {
        [BsonConstructor]
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }

        [BsonElement("rolename")]
        public string RoleName { get; set; }
    }
}
