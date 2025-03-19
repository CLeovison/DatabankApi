using DatabankApi.Entities;

namespace DatabankApi.Repositories;

public interface IUserRepositories
{
    Task RegisterUserAsync(User user, CancellationToken cancellationToken);
    Task<User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken);
    Task UpdateUserAsync(User user, CancellationToken cancellationToken);
    Task<List<User>> GetAllUserAsync(CancellationToken cancellationToken);
}