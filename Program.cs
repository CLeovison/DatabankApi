using System.Reflection;
using DatabankApi.Database;
using DatabankApi.Extensions;
using DatabankApi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpoint(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"));
});


var app = builder.Build();


app.MapPost("", async (AppDbContext dbContext, UserRepositories repositories) =>
{
    var connection = dbContext.User.Add()
});

app.MapEndpoints();



app.Run();


