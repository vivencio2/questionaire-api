using Microsoft.AspNetCore.Mvc;
using Questionaire.Application.Questionnaires.Queries;
using Questionaire.Domain.Questionnaires;
using Questionaire.Api.Infrastructure;
using Questionaire.Application.Infrastructure;

namespace Questionaire.Api.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]
    public class QuestionnairesController : BaseController
    {
        [HttpGet()]
        [ProducesResponseType(typeof(PaginatedModel<Questionnaire>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        public async Task<PaginatedModel<Questionnaire>> GetQuestionnaires([FromQuery] int? pageSize, [FromQuery] int? pageNumber)
        {
            var pagination = new PaginatedFilter(pageSize, pageNumber);
            var questionnaires = await Mediator.Send(new GetQuestionnairesQuery(pagination));
            return new PaginatedModel<Questionnaire>(questionnaires, pagination);
        }
        [HttpGet("{questionnaireId}")]
        [ProducesResponseType(typeof(Questionnaire), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        public async Task<Questionnaire> GetQuestionnaireById(int questionnaireId)
        {
            return await Mediator.Send(new GetQuestionnaireByIdQuery(questionnaireId));
        }
        [HttpGet("{questionnaireId}/subjects")]
        [ProducesResponseType(typeof(PaginatedModel<Subject>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        public async Task<PaginatedModel<Subject>> GetSubjects(int questionnaireId, [FromQuery] int? pageSize, [FromQuery] int? pageNumber)
        {
            var pagination = new PaginatedFilter(pageSize, pageNumber);
            var subjects = await Mediator.Send(new GetSubjectsQuery(pagination, questionnaireId));
            return new PaginatedModel<Subject>(subjects, pagination);
        }
        [HttpGet("{questionnaireId}/subjects/{subjectId}/questions")]
        [ProducesResponseType(typeof(PaginatedModel<Question>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        public async Task<PaginatedModel<Question>> GetQuestions(int questionnaireId, int subjectId, [FromQuery]int? pageSize, [FromQuery]int? pageNumber)
        {
            var pagination = new PaginatedFilter(pageSize, pageNumber);
            var questions = await Mediator.Send(new GetQuestionsQuery(pagination, questionnaireId, subjectId));
            return new PaginatedModel<Question>(questions, pagination);
        }
    }
}
