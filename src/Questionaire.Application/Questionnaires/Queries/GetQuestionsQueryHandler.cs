using MediatR;
using Questionaire.Application.Interfaces;
using Questionaire.Domain.Questionnaires;

namespace Questionaire.Application.Questionnaires.Queries
{
    public class GetQuestionsQueryHandler : IRequestHandler<GetQuestionsQuery, IEnumerable<Question>>
    {
        private readonly IDataRepository<Questionnaire> _dataRepository;
        public GetQuestionsQueryHandler(IDataRepository<Questionnaire> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public async Task<IEnumerable<Question>> Handle(GetQuestionsQuery request, CancellationToken cancellationToken)
        {
            var questionResult = new List<Question>();
            var questionnaire = await _dataRepository.GetAsync(request.QuestionnaireId, cancellationToken);
            var subject = questionnaire.QuestionnaireItems.Where(a => a.SubjectId == request.SubjectId).FirstOrDefault();
            var questions = subject?.QuestionnaireItems;
            if(questions != null)
            {
                questionResult = questions.AsQueryable().Skip(request.Pagination.Skip).Take(request.Pagination.PageSize).ToList();
            }
            return questionResult;
        }
    }
}
