using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Services;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Services
{
    public class EmployeeRoleService : IEmployeeRoleService
    {
        private readonly IValidator<Entities.EmployeeRole> _validator;

        private readonly IEmployeeRoleRepository _employeeRoleRepository;

        public EmployeeRoleService(
            IValidator<Entities.EmployeeRole> validator,
            IEmployeeRoleRepository employeeRoleRepository)
        {
            _validator = validator;
            _employeeRoleRepository = employeeRoleRepository;
        }

        public async Task<Entities.EmployeeRole> AddEmployeeRoleAsync(Entities.EmployeeRole employeeRole)
        {
            var validated = await _validator.ValidateAsync(employeeRole, opt =>
            {
                opt.IncludeRuleSets("new");
            });

            employeeRole.validationResult = validated;

            if (!employeeRole.validationResult.IsValid)
            {
                return employeeRole;
            }

            await _employeeRoleRepository.AddAsync(employeeRole);

            return employeeRole;
        }

        public async Task<List<Entities.EmployeeRole>> GetAllAsync()
        {
            return await _employeeRoleRepository.FindAllAsync();
        }

        public async Task<Entities.EmployeeRole> DeleteByIdAsync(string id)
        {
            var employeeRoleValidator = await this.GetByIdAsync(id);

            if (employeeRoleValidator != null)
            {
                var validated = await _validator.ValidateAsync(employeeRoleValidator, opt =>
                {
                    opt.IncludeRuleSets("new");
                });

                employeeRoleValidator.validationResult = validated;

                if (!employeeRoleValidator.validationResult.IsValid)
                {
                    return employeeRoleValidator;
                }
            }
            else
            {
                employeeRoleValidator = new Entities.EmployeeRole(id: id, string.Empty);
                employeeRoleValidator.validationResult = new FluentValidation.Results.ValidationResult();
                employeeRoleValidator.validationResult.Errors.Add(new FluentValidation.Results.ValidationFailure("", "Role não existe."));
                return employeeRoleValidator;
            }

            return await _employeeRoleRepository.DeleteByIdAsync(id);
        }

        public async Task<Entities.EmployeeRole> GetByIdAsync(string id)
        {
            var employeeRoleValidator = new Entities.EmployeeRole(id: id, string.Empty);

            var validated = await _validator.ValidateAsync(employeeRoleValidator, opt =>
            {
                opt.IncludeRuleSets("getOrDeleteById");
            });

            employeeRoleValidator.validationResult = validated;

            if (!employeeRoleValidator.validationResult.IsValid)
            {
                return employeeRoleValidator;
            }

            return await _employeeRoleRepository.FindByIdAsync(id);
        }

        public async Task<Entities.EmployeeRole> UpdateEmployeeRoleAsync(Entities.EmployeeRole employeeRole)
        {

            var validated = await _validator.ValidateAsync(await this.GetByIdAsync(employeeRole.Id), opt =>
            {
                opt.IncludeRuleSets("update");
            });

            employeeRole.validationResult = validated;

            if (!employeeRole.validationResult.IsValid)
            {
                return employeeRole;
            }

            await _employeeRoleRepository.UpdateAsync(employeeRole);

            return employeeRole;
        }
    }
}
