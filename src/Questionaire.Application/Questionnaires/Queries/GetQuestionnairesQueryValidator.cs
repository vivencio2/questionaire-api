using FluentValidation;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetQuestionnairesQueryValidator : AbstractValidator<GetQuestionnairesQuery>
    {
        public GetQuestionnairesQueryValidator()
        {
            RuleFor(c => c.Pagination).NotNull();
        }
    }
}
