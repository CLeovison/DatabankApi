using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Entities;

using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Services;


public interface IUserService
{
    Task<bool> RegisterUserService(User user, RegisterUserRequest request, IPasswordHasher<User> passwordHasher);
    Task<User?> UpdateUserAsync(Guid id, User user, CancellationToken ct);
}