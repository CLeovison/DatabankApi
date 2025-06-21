
using DatabankApi.Domain.Entities;


namespace DatabankApi.Repositories;


public interface IUserRepositories
{
    Task<bool> CreateUserAsync(User users);
    Task<IEnumerable<User>> GetAllUserAsync(CancellationToken ct);
    Task<User?> GetUserByIdAsync(Guid id, CancellationToken ct);
    Task<User?> UpdateUserAsync(User users, CancellationToken ct);
    Task<bool> DeleteUserAsync(User users);
}