using System.Reflection;
using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Database;
using DatabankApi.Entities;
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



app.MapEndpoints();



app.Run();


