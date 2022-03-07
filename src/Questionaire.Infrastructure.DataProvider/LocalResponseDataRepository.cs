using JsonFlatFileDataStore;
using Microsoft.Extensions.Options;
using Questionaire.Application.Infrastructure;
using Questionaire.Application.Interfaces;
using Questionaire.Domain.Responses;
using Questionaire.Infrastructure.DataProvider.Configuration;

namespace Questionaire.Infrastructure.DataProvider
{
    public class LocalResponseDataRepository :  IDataRepository<ResponseObject>
    {
        private readonly DataStore _dataStore;
        public LocalResponseDataRepository(IOptions<DataOptions> dataOptions)
        {
            var questionnaireJsonPath = Path.Combine(Directory.GetCurrentDirectory(), dataOptions.Value.ResponsesDataSource);
            _dataStore = new DataStore(questionnaireJsonPath);
        }
        public Task<bool> AddAsync(ResponseObject item, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int identity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ResponseObject>> GetAsync(PaginatedFilter paginationQuery, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseObject> GetAsync(int identity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ResponseObject item, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
