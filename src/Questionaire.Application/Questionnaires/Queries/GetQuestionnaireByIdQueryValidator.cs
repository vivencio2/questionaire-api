using FluentValidation;
namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetQuestionnaireByIdQueryValidator : AbstractValidator<GetQuestionnaireByIdQuery>
    {
        public GetQuestionnaireByIdQueryValidator()
        {
            RuleFor(c => c.QuestionnaireId)
                .NotNull()
                .NotEmpty()
                .NotEqual(0);
        }
    }
}
