using System.Dynamic;

namespace Questionaire.Domain.Questionnaires
{
    public class Answer
    {
        public int? AnswerId { get; set; } = null;
        public int QuestionId { get; set; }
        public int AnswerType { get; set; }
        public int ItemType { get; set; }
        public int OrderNumber { get; set; }
        public ExpandoObject? Texts { get; set; } = null;
        public List<dynamic>? QuestionnaireItems { get; set; } = null;
    }
}
