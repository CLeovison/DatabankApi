
using DatabankApi.Domain.Entities;

namespace DatabankApi.Repositories;


public interface IUserRepositories
{
    Task<bool> CreateUserAsync(User users);
    Task<IEnumerable<User>> GetAllUserAsync(CancellationToken ct);
}