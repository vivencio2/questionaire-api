using Microsoft.AspNetCore.Mvc;
using Questionaire.Domain.Analyses;

namespace Questionaire.Api.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]
    public class AnalysesController : BaseController
    {
        [HttpGet()]
        [ProducesResponseType(typeof(List<Analysis>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        public Task<List<Analysis>> GetQuestionnaireAnalyses()
        {
            var analysis = new Analysis() { QuestionnaireId = 1000 };
            var analyses = new List<Analysis>();
            analyses.Add(analysis);
            return Task.FromResult(analyses);
        }
        [HttpGet("{questionnaireId}")]
        [ProducesResponseType(typeof(Analysis), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        public Task<Analysis> GetQuestionnaireAnalysis(int questionnaireId)
        {
            var analysis = new Analysis() { QuestionnaireId = questionnaireId };
            return Task.FromResult(analysis);
        }
    }
}
