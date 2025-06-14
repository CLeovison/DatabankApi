using System.Reflection;
using DatabankApi.Database;
using DatabankApi.Domain.Entities;
using DatabankApi.Extensions;
using DatabankApi.Infrastracture;
using DatabankApi.Repositories;
using DatabankApi.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContextFactory<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"));
});


builder.Services.AddEndpoint(Assembly.GetExecutingAssembly());
builder.Services.AddSingleton<IUserRepositories, UserRepositories>();
builder.Services.AddSingleton<IUserServices, UserServices>();
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();


var app = builder.Build();
app.Endpoint();

app.Run();


