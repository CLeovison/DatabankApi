using DatabankApi.Contracts.Data;
using DatabankApi.Entities;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Services;


public interface IUserServices
{
    Task<bool> CreateUserAsync(UserDto user, IPasswordHasher<User> passwordHasher);
}