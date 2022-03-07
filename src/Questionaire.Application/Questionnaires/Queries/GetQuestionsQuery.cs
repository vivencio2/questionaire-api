using MediatR;
using Questionaire.Application.Infrastructure;
using Questionaire.Domain.Questionnaires;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetQuestionsQuery : IRequest<IEnumerable<Question>>
    {
        public GetQuestionsQuery(PaginatedFilter pagination, int questionnaireId, int subjectId)
        {
            Pagination = pagination;
            QuestionnaireId = questionnaireId;
            SubjectId = subjectId;
        }
        public PaginatedFilter Pagination { get; private set; }
        public int QuestionnaireId { get; private set; }
        public int SubjectId { get; private set; }
    }
}
