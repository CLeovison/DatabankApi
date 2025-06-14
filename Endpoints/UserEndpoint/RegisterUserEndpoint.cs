using DatabankApi.Abstract;
using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Domain.Entities;
using DatabankApi.Mapping;
using DatabankApi.Services;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Endpoint.UserEndpoint;


public class RegisterUserEndpoint(IUserServices userServices) : IEndpoint
{

    public void Endpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/register", async (RegisterUserRequest req, IPasswordHasher<User> passwordHasher) =>
        {
            var createdUser = req.ToDto(passwordHasher);
            var result = await userServices.CreateUserAsync(createdUser, passwordHasher);

            return result;
        }); 
    }
}
