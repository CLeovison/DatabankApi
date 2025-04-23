using DatabankApi.Entities;
using DatabankApi.Repositories;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Services;

public class UserService : IUserService
{
    private readonly IUserRepositories _userRepositories;


    public UserService(IUserRepositories userRepositories)
    {
        _userRepositories = userRepositories;
    }

    public async Task<User?> RegisterUserService(User user, IPasswordHasher<User> passwordHasher)

    {

        var users = new User
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Username = user.Username,
            Password = passwordHasher.HashPassword(user, user.Password),
            Email = user.Email,
            Department = user.Department
        };
        await _userRepositories.RegisterUserAsync(users);

        return user;
    }

    public async Task<User?> UpdateUserAsync(Guid id, User user, IPasswordHasher<User> passwordHasher, CancellationToken ct)
    {
        if (await _userRepositories.GetUserByIdAsync(id) is null)
        {
            throw new ArgumentException();
        }

        var userUpdate = new User
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Username = user.Username,
            Password = passwordHasher.HashPassword(user, user.Password),
            Email = user.Email,
            Department = user.Department
        };

        await _userRepositories.UpdateUserAsync(userUpdate, ct);

        return userUpdate;
    }

}