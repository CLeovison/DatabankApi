using System.Reflection;
using DatabankApi.Database;
using DatabankApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpoint(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<AppDbContext>(options =>{
    
});


var app = builder.Build();

app.MapEndpoints();
app.Run();
