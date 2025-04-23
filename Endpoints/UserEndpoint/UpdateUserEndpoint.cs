using DatabankApi.Abstract;
using DatabankApi.Entities;
using DatabankApi.Infrastracture;
using DatabankApi.Services;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Endpoints.UserEndpoint;


public class UpdateUserEndpoint : IEndpoint
{
    private readonly IUserService _userService;
    private readonly IPasswordHasher<User> _passwordHasher;

    public UpdateUserEndpoint(IUserService userService, IPasswordHasher<User> passwordHasher)
    {
        _userService = userService;
        _passwordHasher = passwordHasher;
    }
    public void Endpoint(IEndpointRouteBuilder app)
    {

        app.MapPut("/api/update/{id}", async (Guid id, User user, CancellationToken ct) =>
        {
            await _userService.UpdateUserAsync(id, user, _passwordHasher, ct);
        });
    }
}