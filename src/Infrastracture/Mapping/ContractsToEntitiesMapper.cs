using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Mapping;


public static class ContractsToEntitiesMapper
{
    public static User ToRegister(this RegisterUserRequest req, IPasswordHasher<User> passwordHasher)
    {
        return new User
        {
            FirstName = req.FirstName,
            LastName = req.LastName,
            Email = req.Email,
            Department = req.Department,
            Username = req.Username,
            Password = passwordHasher.HashPassword(new User(), req.Password),
        };
    }
}