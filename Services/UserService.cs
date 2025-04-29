using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Entities;
using DatabankApi.Mapping;
using DatabankApi.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DatabankApi.Services;

public class UserService : IUserService
{
    private readonly IUserRepositories _userRepositories;


    public UserService(IUserRepositories userRepositories)
    {
        _userRepositories = userRepositories;
    }

    public async Task<bool> RegisterUserService(User user, [FromBody] RegisterUserRequest request, IPasswordHasher<User> passwordHasher)
    {

        var existingUser = await _userRepositories.ExsitingUserAsync(user.Username);
        if (existingUser is true)
        {
            throw new ArgumentException("The User Already Exist");
        }

        var userDto = user.ToCreate(request,passwordHasher);

        await _userRepositories.RegisterUserAsync(userDto);

        return userDto is null;
    }

    public async Task<User?> UpdateUserAsync(Guid id, User user, CancellationToken ct)
    {
        var existingUser = await _userRepositories.GetUserByIdAsync(user.UserId);

        if (existingUser is null)
        {
            throw new ArgumentException("The User Didn't Exist");
        }

        existingUser.FirstName = user.FirstName;
        existingUser.LastName = user.LastName;
        existingUser.Username = user.Username;
        existingUser.Password = user.Password;
        existingUser.Email = user.Email;

        await _userRepositories.UpdateUserAsync(id, existingUser);
        return user;
    }

}