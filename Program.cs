using System.Reflection;
using DatabankApi.Database;
using DatabankApi.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpoint(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration["ConnectionStrings:Database"]!);
});


var app = builder.Build();

app.MapEndpoints();
app.Run();
