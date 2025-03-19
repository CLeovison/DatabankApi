using System.Reflection;
using DatabankApi.Database;
using DatabankApi.Entities;
using DatabankApi.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpoint(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration["ConnectionStrings:Database"]);
});


var app = builder.Build();

app.MapEndpoints();
app.Run();


app.MapPost("/api/register", async (AppDbContext dbContext, User user, CancellationToken cancellationToken) =>
{
    dbContext.User.Add(user);

    await dbContext.SaveChangesAsync(cancellationToken);

    return Results.Ok();
});