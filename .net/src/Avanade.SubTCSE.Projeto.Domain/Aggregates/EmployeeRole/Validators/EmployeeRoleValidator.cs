using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");
            });

            RuleSet("getOrDeleteById", () =>
            {
                RuleFor(e => e.Id)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");
            });

            RuleSet("update", () =>
            {
                 RuleFor(e => e.Id)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");
                 RuleFor(e => e.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");
            });
        }
    }
}
