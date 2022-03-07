using MediatR;
using Questionaire.Application.Interfaces;
using Questionaire.Domain.Questionnaires;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetQuestionnaireByIdQueryHandler : IRequestHandler<GetQuestionnaireByIdQuery, Questionnaire>
    {
        private readonly IDataRepository<Questionnaire> _dataRepository;
        public GetQuestionnaireByIdQueryHandler(IDataRepository<Questionnaire> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public async Task<Questionnaire> Handle(GetQuestionnaireByIdQuery request, CancellationToken cancellationToken)
        {
            var questionnaire = await _dataRepository.GetAsync(request.QuestionnaireId, cancellationToken);
            
            return questionnaire;
        }
    }
}
