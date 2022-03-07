using Questionaire.Application.Infrastructure;

namespace Questionaire.Application.Interfaces
{
    public interface IDataRepository<TKey>
    {
        Task<IEnumerable<TKey>> GetAsync(PaginatedFilter paginationQuery, CancellationToken cancellationToken);
        Task<TKey> GetAsync(int identity, CancellationToken cancellationToken);
        Task<bool> AddAsync(TKey item, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(TKey item, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int identity, CancellationToken cancellationToken);
    }
}
