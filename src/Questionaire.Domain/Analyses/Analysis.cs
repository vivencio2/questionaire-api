using Questionaire.Domain.Shared;

namespace Questionaire.Domain.Analyses
{
    public class Analysis
    {
        public int QuestionnaireId { get; set; }
        public KeyValuePair<Department, IEnumerable<AnalysisSubject>> ResultPerDepartments { get; set; }
    }
}
