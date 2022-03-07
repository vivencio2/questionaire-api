using Questionaire.Application.Interfaces;
using Questionaire.Domain.Analyses;
using Questionaire.Domain.Responses;

namespace Questionaire.Services
{
    public class AnalysisCalculationService : ICalculationService<IEnumerable<ResponseObject>, Analysis>
    {
        private readonly IEnumerable<ICalculationStrategy> _calculationStrategies;
        public AnalysisCalculationService(IEnumerable<ICalculationStrategy> calculationStrategies)
        {
            _calculationStrategies = calculationStrategies;
        }
        public Task<Analysis> CalculateAsync(IEnumerable<ResponseObject> input, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}