using DevFreela.Application.Commands.CreateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Description)
                .MaximumLength(400)
                .WithMessage("Descrição do projeto pode conter até 400 caracteres.");

            RuleFor(p => p.Title)
                .MaximumLength(55)
                .WithMessage("Tamanho do Título tem que ter o minimo de 5 e no máximo 55 caracteres.");
        }
    }
}
