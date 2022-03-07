namespace Questionaire.Application.Infrastructure
{
    public class PaginatedFilter
    {
        public int PageSize { get; private set; } = 20;
        public int PageNumber { get; private set; } = 1;
        public int Skip { get; private set; }
        private PaginatedFilter() { }
        public PaginatedFilter(int? pageSize, int? pageNumber)
        {
            PageSize = pageSize.HasValue ? pageSize.Value : PageSize;
            PageNumber = pageNumber.HasValue ? pageNumber.Value : PageNumber;
            Skip = (PageNumber - 1) * PageSize;
        }
    }
}
