using DatabankApi.Abstract;
using DatabankApi.Entities;
using DatabankApi.Services;

namespace DatabankApi.Endpoints.UserEndpoint;

public class RegisterUserEndpoint : IEndpoint
{
    private readonly IUserService _userServices;
    public RegisterUserEndpoint(IUserService userServices)
    {
        _userServices = userServices;
    }
    public void Endpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/create", async (User user, CancellationToken ct) =>
        {
            await _userServices.RegisterUserService(user, ct);
        });
    }
}