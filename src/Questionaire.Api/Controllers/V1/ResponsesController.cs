using Microsoft.AspNetCore.Mvc;
using Questionaire.Domain.Responses;

namespace Questionaire.Api.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]
    public class ResponsesController : ControllerBase
    {
        [HttpPost()]
        [ProducesResponseType(typeof(bool), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        public Task<bool> PostResponsesForQuestionnaires()
        {
            return Task.FromResult(true);
        }
        [HttpPost("{questionnaireId}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        public Task<bool> PostResponsesForQuestionnaireById(int questionnaireId)
        {   
            return Task.FromResult(true);
        }
    }
}
