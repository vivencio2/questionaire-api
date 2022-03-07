namespace Questionaire.Domain.Responses
{
    public class ResponseObject
    {
        public int ResponseId { get; set; }
        public int QuestionnaireId { get; set; }
        public Identity Identity { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}
