using Questionaire.Application.Infrastructure;
using Questionaire.Api.Infrastructure;
using Xunit;
using System.Collections.Generic;

namespace Questionaire.UnitTests
{
    public class PaginationTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(null, null, 0)]
        [InlineData(2, 20, 38)]
        [InlineData(3, 10, 27)]
        public void PaginatedFilterSkipTest(int? pageSize, int? pageNumber, int expectedSkip)
        {
            var paginated = new PaginatedFilter(pageSize, pageNumber);
            Assert.Equal(expectedSkip, paginated.Skip);
            Assert.Equal(pageNumber.HasValue ? pageNumber.Value : 1, paginated.PageNumber);
            Assert.Equal(pageSize.HasValue ? pageSize.Value : 20, paginated.PageSize);
        }
        [Theory]
        [InlineData(0, 0, 2, true)]
        [InlineData(2, 20, 5, true)]
        [InlineData(3, 10, 20, true)]
        [InlineData(3, 10, 60, true)]
        public void PaginatedModelTests(int pageSize, int pageNumber, int sampleSize, bool isTrue)
        {
            var paginated = new PaginatedFilter(pageSize, pageNumber);
            var items = new List<int>();
            for(int i = 0; i < sampleSize; i++)
            {
                items.Add(i);
            }
            var paginatedModel = new PaginatedModel<int>(items, paginated);
            Assert.Equal(string.IsNullOrEmpty(paginatedModel.NextPage), isTrue);
        }
    }
}