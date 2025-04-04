using System.Reflection;
using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Database;
using DatabankApi.Entities;
using DatabankApi.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpoint(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"));
});


var app = builder.Build();

app.MapEndpoints();

// app.MapPost("/api/register", async (AppDbContext dbContext, RegisterUserRequest request, CancellationToken cancellationToken) =>
// {

//     User user = new()
//     {
//         UserId = Guid.NewGuid(),
//         Username = request.Username,
//         Password = request.Password,
//         FirstName = request.FirstName,
//         LastName = request.LastName,
//         Email = request.Email,
//         Department = request.Department

//     };

//     dbContext.User.Add(user);

//     await dbContext.SaveChangesAsync(cancellationToken);

//     return Results.Ok();
// });
// app.MapPut("api/update", async(AppDbContext dbContext, User user) =>{
//     dbContext.User.Update(user);
//     await dbContext.SaveChangesAsync();

//     return Results.Ok();
// });
// app.MapGet("/api", async (AppDbContext dbContext) =>
// {
//     return await dbContext.User.ToListAsync();
// });

// app.MapGet("/api/{id}", async (Guid id, AppDbContext dbContext) =>
// {
//     return await dbContext.User.FindAsync(id);
// });

// app.MapDelete("/api/{id}", async (Guid id, AppDbContext dbContext) =>
// {   
//     var result = await dbContext.User.Where(x => x.UserId == id).ExecuteDeleteAsync();
//     return result > 0;
// });

app.Run();


