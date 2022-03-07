using MediatR;
using Questionaire.Application.Infrastructure;
using Questionaire.Domain.Questionnaires;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetSubjectsQuery : IRequest<IEnumerable<Subject>>
    {
        public GetSubjectsQuery(PaginatedFilter pagination, int questionnaireId)
        {
            Pagination = pagination;
            QuestionnaireId = questionnaireId;
        }
        public PaginatedFilter Pagination { get; private set; }
        public int QuestionnaireId { get; private set; }
    }
}
