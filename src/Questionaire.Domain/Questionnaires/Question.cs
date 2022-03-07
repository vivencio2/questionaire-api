using System.Dynamic;

namespace Questionaire.Domain.Questionnaires
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int SubjectId { get; set; }
        public int AnswerCategoryType { get;set; }
        public int OrderNumber { get; set; }
        public ExpandoObject Texts { get; set; }
        public  int  ItemType { get; set; }
        public IEnumerable<Answer> QuestionnaireItems { get; set; }
    }
}
