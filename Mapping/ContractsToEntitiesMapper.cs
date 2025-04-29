using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Entities;

using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Mapping;


public static class ContractsToEntitiesMapper
{
    public static User ToCreate(this User user, RegisterUserRequest request, IPasswordHasher<User> passwordHasher)
    {
        return new User
        {
            UserId = request.UserId,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Username = request.Username,
            Password = passwordHasher.HashPassword(user, request.Password),
            Email = request.Email,
            Department = request.Department
        };
    }
}