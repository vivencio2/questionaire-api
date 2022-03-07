using MediatR;
using Questionaire.Application.Interfaces;
using Questionaire.Domain.Questionnaires;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetQuestionnairesQueryHandler : IRequestHandler<GetQuestionnairesQuery, IEnumerable<Questionnaire>>
    {
        private readonly IDataRepository<Questionnaire> _dataRepository;
        public GetQuestionnairesQueryHandler(IDataRepository<Questionnaire> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public async Task<IEnumerable<Questionnaire>> Handle(GetQuestionnairesQuery request, CancellationToken cancellationToken)
        {
            var questionnaires = await _dataRepository.GetAsync(request.Pagination, cancellationToken);
            return questionnaires;
        }
    }
}
