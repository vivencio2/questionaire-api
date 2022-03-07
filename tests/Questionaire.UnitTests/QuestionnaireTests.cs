using Questionaire.Application.Interfaces;
using Questionaire.Domain.Questionnaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NSubstitute;
using Questionaire.Application.Questionnaires.Queries;
using Questionaire.Application.Infrastructure;
using System.Threading;

namespace Questionaire.UnitTests
{
    public class QuestionnaireTests
    {
        private readonly IDataRepository<Questionnaire> _dataRepository;
        private PaginatedFilter _paginatedFilter;
        public QuestionnaireTests()
        {
            _dataRepository = Substitute.For<IDataRepository<Questionnaire>>();
        }
        [Fact]
        public async Task GetQuestionnairesQueryTests()
        {
            //Arrange
            var questionnaire = new List<Questionnaire>();
            _paginatedFilter = new PaginatedFilter(null, null);
            _dataRepository.GetAsync(_paginatedFilter, CancellationToken.None).Returns(questionnaire);
            var request = new GetQuestionnairesQuery(_paginatedFilter);
            var handler = new GetQuestionnairesQueryHandler(_dataRepository);
            //Act
            var result = await handler.Handle(request, CancellationToken.None);
            //Assert
            Assert.NotNull(result);
            Assert.True(_paginatedFilter.Skip == 0);
            Assert.IsType<List<Questionnaire>>(result);
        }
        [Fact]
        public async Task GetQuestionsQueryTests()
        {
            //Arrange
            var subjects = new List<Subject>();
            var subject = new Subject() { SubjectId = 1 };
            subjects.Add(subject);
            var questionnaire = new Questionnaire() {  QuestionnaireId = 1000, QuestionnaireItems = subjects};
            _paginatedFilter = new PaginatedFilter(2, 20);
            _dataRepository.GetAsync(1000, CancellationToken.None).Returns(questionnaire);
            var request = new GetQuestionsQuery(_paginatedFilter, 1000, 1);
            var handler = new GetQuestionsQueryHandler(_dataRepository);
            //Act
            var result = await handler.Handle(request, CancellationToken.None);
            //Assert
            Assert.NotNull(result);
            Assert.True(request.Pagination.Skip == 38);
            Assert.IsType<List<Question>>(result);
        }
        [Fact]
        public async Task GetSubjectsQueryTests()
        {
            //Arrange
            var subjects = new List<Subject>();
            var subject = new Subject() { SubjectId = 1 };
            subjects.Add(subject);
            var questionnaire = new Questionnaire() { QuestionnaireId = 1000, QuestionnaireItems = subjects };
            _dataRepository.GetAsync(1000, CancellationToken.None).Returns(questionnaire);
            _paginatedFilter = new PaginatedFilter(3, 10);
            var request = new GetSubjectsQuery(_paginatedFilter, 1000);
            var handler = new GetSubjectsQueryHandler(_dataRepository);
            //Act
            var result = await handler.Handle(request, CancellationToken.None);
            //Assert
            Assert.NotNull(result);
            Assert.True(request.Pagination.Skip == 27);
            Assert.IsType<List<Subject>>(result.ToList());
        }
    }
}
