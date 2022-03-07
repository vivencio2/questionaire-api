using FluentValidation;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetQuestionsQueryValidator : AbstractValidator<GetQuestionsQuery>
    {
        public GetQuestionsQueryValidator()
        {
            RuleFor(c => c.Pagination).NotNull();
            RuleFor(c => c.QuestionnaireId)
                .NotNull()
                .NotEmpty()
                .NotEqual(0);
            RuleFor(c => c.SubjectId)
                .NotNull()
                .NotEmpty()
                .NotEqual(0);
        }
    }
}
