using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Questionaire.Application.Interfaces;
using Questionaire.Domain.Questionnaires;
using Questionaire.Domain.Responses;

namespace Questionaire.Infrastructure.DataProvider.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataProvider(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DataOptions>(options =>
            {
                options.QuestionnairesDataSource = configuration.GetConnectionString("QuestionnairesDataSource");
                options.ResponsesDataSource = configuration.GetConnectionString("ResponsesDataSource");
            });
            services.AddScoped<IDataRepository<Questionnaire>, LocalQuestionnaireDataRepository>();
            services.AddScoped<IDataRepository<ResponseObject>, LocalResponseDataRepository>();
            return services;
        }
    }
}
