using System.Dynamic;

namespace Questionaire.Domain.Questionnaires
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public int OrderNumber { get; set; }
        public ExpandoObject Texts { get; set; }
        public int ItemType { get; set; }
        public IEnumerable<Question> QuestionnaireItems { get; set; }
    }
}
