using Questionaire.Api.Infrastructure;
using Questionaire.Application.Configuration;
using Questionaire.Infrastructure.DataProvider.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCorsPolicy();
builder.Services.AddSwagger();
builder.Services.AddControllers();
builder.Services.AddApplication();
builder.Services.AddDataProvider(builder.Configuration);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseSwaggerInformation();
app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();
