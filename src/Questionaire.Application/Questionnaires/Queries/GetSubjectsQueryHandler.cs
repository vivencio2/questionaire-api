using MediatR;
using Questionaire.Application.Interfaces;
using Questionaire.Domain.Questionnaires;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetSubjectsQueryHandler : IRequestHandler<GetSubjectsQuery, IEnumerable<Subject>>
    {
        private readonly IDataRepository<Questionnaire> _dataRepository;
        public GetSubjectsQueryHandler(IDataRepository<Questionnaire> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public async Task<IEnumerable<Subject>> Handle(GetSubjectsQuery request, CancellationToken cancellationToken)
        {
            var questionnaire = await _dataRepository.GetAsync(request.QuestionnaireId, cancellationToken);
            return questionnaire.QuestionnaireItems.AsQueryable().Skip(request.Pagination.Skip).Take(request.Pagination.PageSize).AsEnumerable();
        }
    }
}
