using DatabankApi.Entities;

namespace DatabankApi.Repositories;

public interface IUserRepositories
{
    Task RegisterUserAsync(User user, CancellationToken cancellationToken);
    Task<List<User>> GetAllUserAsync(CancellationToken cancellationToken);
    Task GetSearchUserAsync(string searchTerm, CancellationToken cancellationToken);
    Task<User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<bool> UpdateUserAsync(User user, CancellationToken cancellationToken);
    Task<bool> DeleteUserAsync(Guid id, CancellationToken cancellationToken);
}