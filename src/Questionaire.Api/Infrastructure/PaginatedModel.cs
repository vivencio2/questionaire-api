using Questionaire.Application.Infrastructure;

namespace Questionaire.Api.Infrastructure
{
    public class PaginatedModel<T>
    {   
        private PaginatedModel() { }
        public PaginatedModel(IEnumerable<T> items, PaginatedFilter pagination)
        {
            Items = items;
            PageNumber = pagination.PageNumber;
            PageSize = pagination.PageSize;
            NextPage = PageNumber >= 1 && Items.Count() == PageSize ? $"pageNumber={PageNumber + 1}&pageSize={PageSize}" : String.Empty;
            PreviousPage = PageNumber - 1 >= 1 ? $"pageNumber={PageNumber - 1}&pageSize={PageSize}" : String.Empty;
        }
        public IEnumerable<T> Items { get; private set; }
        public  int PageNumber { get; private set; }
        public int PageSize { get; private set; }
        public string NextPage { get; private set; }
        public string PreviousPage { get; private set; }
    }
}
