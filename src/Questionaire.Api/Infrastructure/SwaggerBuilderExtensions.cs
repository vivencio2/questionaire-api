using Microsoft.OpenApi.Models;

namespace Questionaire.Api.Infrastructure
{
    public static class SwaggerBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerInformation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("swagger/v1/swagger.json", "Effectory API");
                c.RoutePrefix = string.Empty;
            });
            return app;
        }
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Description = "Effectory API",
                    Title = "Effectory API",
                    Version = "v1",
                    Contact = new OpenApiContact()
                    {
                        Name = "Vivencio Añes Jr",
                        Url = new Uri("https://github.com/vivencio2")
                    }
                });
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                }});
            });
            return services;
        }
    }
}
