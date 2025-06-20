using DatabankApi.Contracts.Data;
using DatabankApi.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Services;


public interface IUserServices
{
    Task<bool> CreateUserAsync(UserDto user, IPasswordHasher<User> passwordHasher);
    Task<IEnumerable<User>> GetAllUserAsync(CancellationToken ct);
    Task<User?> GetUserByIdAsync(Guid id);
    Task<User?> UpdateUserAsync(Guid id, User users, CancellationToken ct);
    Task<bool> DeleteUserAsync(Guid id);
}