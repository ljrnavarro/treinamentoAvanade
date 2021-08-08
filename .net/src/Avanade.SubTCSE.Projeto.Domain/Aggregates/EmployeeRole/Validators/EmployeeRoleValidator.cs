using FluentValidation;
using FluentValidation.Results;
using System.Threading;
using System.Threading.Tasks;

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
                RuleFor(e => e)
                .NotNull()
                .WithMessage("EmployeeRole is null or not exists");
                RuleFor(e => e.Id)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");
                RuleFor(e => e.RoleName)
               .NotEmpty()
               .WithMessage("{PropertyName} can not be empty");
            });
        }

        public override async Task<ValidationResult> ValidateAsync(ValidationContext<Entities.EmployeeRole> context, CancellationToken cancellation = default(CancellationToken))
        {
            return context.InstanceToValidate == null
                ? new ValidationResult(new[] { new ValidationFailure(nameof(EmployeeRole), "Object cannot be null") })
                : await base.ValidateAsync(context, cancellation);
        }
    }
}
