using MediatR;
using Questionaire.Domain.Questionnaires;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetQuestionnaireByIdQuery : IRequest<Questionnaire>
    {
        public GetQuestionnaireByIdQuery(int questionnaireId)
        {
            QuestionnaireId = questionnaireId;
        }
        public int QuestionnaireId { get; private set; }
    }
}
