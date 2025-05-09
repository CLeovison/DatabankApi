using DatabankApi.Entities;
using DatabankApi.Repositories;
using Microsoft.AspNetCore.Identity;
using DatabankApi.Mapping;


namespace DatabankApi.Services;

public sealed class UserServices(IPasswordHasher<User> passwordHasher, IUserRepositories userRepositories) : IUserServices
{

    public async Task<bool> CreateUserAsync(User user)
    {
        var userDto = user.ToEntities(passwordHasher);
        return await userRepositories.CreateUserAsync(userDto);
    }
}