using DatabankApi.Contracts.Data;
using DatabankApi.Entities;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Mapping;


public static class DtoToEntitiesMapper
{
    public static UserDto ToEntities(this User user, IPasswordHasher<User> passwordHasher)
    {
        return new UserDto
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Department = user.Department,
            Username = user.Username,
            Password = passwordHasher.HashPassword(user, user.Password),
        };
    }
}