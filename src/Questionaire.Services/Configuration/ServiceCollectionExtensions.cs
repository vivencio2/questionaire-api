using Microsoft.Extensions.DependencyInjection;
using Questionaire.Application.Interfaces;
using Questionaire.Domain.Analyses;
using Questionaire.Domain.Responses;

namespace Questionaire.Services.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //TODO: IoC Dependencies
            services.AddScoped<ICalculationService<IEnumerable<ResponseObject>, Analysis>, AnalysisCalculationService>();
            return services;
        }
    }
}
