namespace Questionaire.Application.Interfaces
{
    public interface ICalculationService<TInput, TOuput>
    {
        Task<TOuput> CalculateAsync(TInput input, CancellationToken cancellationToken);
    }
}
