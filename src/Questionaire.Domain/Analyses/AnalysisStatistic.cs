using System.Dynamic;

namespace Questionaire.Domain.Analyses
{
    public class AnalysisStatistic
    {
        public int AnswerId {get;set;}
        public ExpandoObject Texts { get; set; }
    }
}
