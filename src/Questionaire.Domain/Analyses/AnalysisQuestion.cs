using System.Dynamic;

namespace Questionaire.Domain.Analyses
{
    public class AnalysisQuestion
    {
        public int QuestionId { get; set; }
        public int OrderNumber { get; set; }
        public ExpandoObject Texts { get; set; }
        public AnalysisStatistic Minimum { get; set; }
        public AnalysisStatistic Maximum { get; set; }
        public AnalysisStatistic Average { get; set; }
    }
}
