using MediatR;
using Questionaire.Application.Infrastructure;
using Questionaire.Domain.Questionnaires;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetQuestionnairesQuery : IRequest<IEnumerable<Questionnaire>>
    {
        public GetQuestionnairesQuery(PaginatedFilter pagination)
        {
            Pagination = pagination;
        }
        public PaginatedFilter Pagination { get; private set; }
    }
}
