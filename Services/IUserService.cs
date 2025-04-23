using DatabankApi.Entities;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Services;


public interface IUserService
{
    Task<User?> RegisterUserService(User user, IPasswordHasher<User> passwordHasher);
    Task<User?> UpdateUserAsync(Guid id, User user, IPasswordHasher<User> passwordHasher, CancellationToken ct);
}