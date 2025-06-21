using DatabankApi.Contracts.Data;
using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Mapping;

public static class RequestToDtoMapper
{
    public static UserDto ToDto(this RegisterUserRequest request, IPasswordHasher<User> passwordHasher)
    {
        return new UserDto
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Department = request.Department,
            Username = request.Username,
            Password = passwordHasher.HashPassword(new User(), request.Password),
        };
    }
}