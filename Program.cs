using System.Reflection;
using DatabankApi.Database;
using DatabankApi.Extensions;
using DatabankApi.Repositories;
using DatabankApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"));
});


builder.Services.AddEndpoint(Assembly.GetExecutingAssembly());
builder.Services.AddSingleton<IUserRepositories, UserRepositories>();
builder.Services.AddSingleton<IUserService, UserService>();


var app = builder.Build();

app.Endpoint();

app.Run();


