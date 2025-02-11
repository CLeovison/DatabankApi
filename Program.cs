using System.Reflection;
using DatabankApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpoint(Assembly.GetExecutingAssembly());



var app = builder.Build();

app.MapEndpoints();
app.Run();
