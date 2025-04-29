using DatabankApi.Abstract;
using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Entities;
using DatabankApi.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DatabankApi.Endpoints.UserEndpoint;

public class RegisterUserEndpoint : IEndpoint
{

    public void Endpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/create", async ([FromBody] RegisterUserRequest request, IPasswordHasher<User> passwordHasher, IUserService userService) =>
        {
            var newUser = new User
            {
                UserId = request.UserId,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Username = request.Username,
                Password = passwordHasher.HashPassword(new User(), request.Password),
                Email = request.Email,
                Department = request.Department
            };

            try
            {
                var result = await userService.RegisterUserService(newUser, request, passwordHasher);

                if (result)
                {
                    return Results.BadRequest("User registration failed.");
                }

                return Results.Ok("User registered successfully.");
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(ex.Message);
            }
        });
    }
}