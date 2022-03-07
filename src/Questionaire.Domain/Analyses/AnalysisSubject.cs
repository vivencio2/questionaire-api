using System.Dynamic;

namespace Questionaire.Domain.Analyses
{
    public class AnalysisSubject
    {
        public int SubjectId { get; set; }
        public ExpandoObject Texts { get; set; }
        public int OrderNumber { get; set; }
        public  IEnumerable<AnalysisQuestion> Questions { get; set; }
    }
}
