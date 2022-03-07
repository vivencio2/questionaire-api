namespace Questionaire.Domain.Questionnaires
{
    public class Questionnaire
    {
        public int QuestionnaireId { get; set; }
        public IEnumerable<Subject> QuestionnaireItems { get; set; }
    }
}