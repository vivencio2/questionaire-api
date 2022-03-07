using Microsoft.Extensions.Options;
using Questionaire.Application.Interfaces;
using Questionaire.Domain.Questionnaires;
using Questionaire.Infrastructure.DataProvider.Configuration;
using JsonFlatFileDataStore;
using Questionaire.Application.Infrastructure;

namespace Questionaire.Infrastructure.DataProvider
{
    public class LocalQuestionnaireDataRepository : IDataRepository<Questionnaire>
    {
        private readonly DataStore _dataStore;
        public LocalQuestionnaireDataRepository(IOptions<DataOptions> dataOptions)
        {
            var questionnaireJsonPath = Path.Combine(Directory.GetCurrentDirectory(), dataOptions.Value.QuestionnairesDataSource);
            _dataStore = new DataStore(questionnaireJsonPath);
        }
        public async Task<bool> AddAsync(Questionnaire item, CancellationToken cancellationToken)
        {
            return await _dataStore.InsertItemAsync<Questionnaire>(item.QuestionnaireId.ToString(), item);
        }
        //TODO: Due to limited time
        public Task<bool> DeleteAsync(int identity, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }

        public Task<IEnumerable<Questionnaire>> GetAsync(PaginatedFilter paginationQuery, CancellationToken cancellationToken)
        {
            var subjects = _dataStore.GetCollection<Subject>("questionnaireItems").AsQueryable();
            var questionnaires = new List<Questionnaire>();
            //mocking list of 100
            for(int i = 0; i < 100; i++)
            {
                questionnaires.Add(new Questionnaire() { QuestionnaireId = (1000 + i), QuestionnaireItems = subjects });
            }
            return Task.FromResult(questionnaires.AsQueryable().Skip(paginationQuery.Skip).Take(paginationQuery.PageSize).AsEnumerable());
        }
        public Task<Questionnaire> GetAsync(int identity, CancellationToken cancellationToken)
        {
            var subjects = _dataStore.GetCollection<Subject>("questionnaireItems").AsQueryable();
            return Task.FromResult(new Questionnaire() { QuestionnaireId = identity, QuestionnaireItems = subjects });
        }
        //TODO: Due to limited time
        public Task<bool> UpdateAsync(Questionnaire item, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}
