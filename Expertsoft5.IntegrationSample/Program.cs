using Expertsoft5.IntegrationSample;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddAuthentication("SecretCodeAuthentication").AddScheme<AuthenticationSchemeOptions, SecretCodeAuthentication>("SecretCodeAuthentication", null);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
