using FluentValidation;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetSubjectsQueryValidator : AbstractValidator<GetSubjectsQuery>
    {
        public GetSubjectsQueryValidator()
        {
            RuleFor(c => c.Pagination).NotNull();
            RuleFor(c => c.QuestionnaireId)
                .NotNull()
                .NotEmpty()
                .NotEqual(0);
        }
    }
}
