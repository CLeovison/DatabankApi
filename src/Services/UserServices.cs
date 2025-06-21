using DatabankApi.Domain.Entities;
using DatabankApi.Repositories;
using Microsoft.AspNetCore.Identity;
using DatabankApi.Mapping;
using DatabankApi.Contracts.Data;
using DatababankApi.Abstract.Result;

namespace DatabankApi.Services;

public sealed class UserServices(IUserRepositories userRepositories) : IUserServices
{

    public async Task<bool> CreateUserAsync(UserDto user, IPasswordHasher<User> passwordHasher)
    {
        var userDto = user.ToDto(passwordHasher);
        return await userRepositories.CreateUserAsync(userDto);
    }

    public async Task<IEnumerable<User>> GetAllUserAsync(CancellationToken ct)
    {
        return await userRepositories.GetAllUserAsync(ct);

    }


    public async Task<User?> GetUserByIdAsync(Guid id, CancellationToken ct)
    {
        var getUserId = await userRepositories.GetUserByIdAsync(id, ct);

        if (getUserId is null)
        {
            Results.NotFound();
        }
        return getUserId;
    }

    public async Task<bool> DeleteUserAsync(Guid id, CancellationToken ct)
    {
        var existingUser = await userRepositories.GetUserByIdAsync(id, ct);

        if (existingUser is null)
        {
            throw new ArgumentException("User not found.");
        }

        return await userRepositories.DeleteUserAsync(existingUser);
    }

}