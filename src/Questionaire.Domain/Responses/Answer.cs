namespace Questionaire.Domain.Responses
{
    public class Answer
    {
        
        public int SubjectId { get; set; }
        public int QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public int AnswerType { get; set; }
        public string? AnswerText { get; set; }

    }
}
