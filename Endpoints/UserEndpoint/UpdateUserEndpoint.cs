using DatabankApi.Abstract;
using DatabankApi.Entities;
using DatabankApi.Infrastracture;
using DatabankApi.Services;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Endpoints.UserEndpoint;


public class UpdateUserEndpoint : IEndpoint
{
    private readonly IUserService _userService;


    public UpdateUserEndpoint(IUserService userService)
    {
        _userService = userService;

    }
    public void Endpoint(IEndpointRouteBuilder app)
    {

        app.MapPut("/api/update/{id}", async (Guid id, User user, CancellationToken ct) =>
        {
            await _userService.UpdateUserAsync(id, user, ct);
        });
    }
}