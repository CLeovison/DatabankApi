using DatabankApi.Entities;

namespace DatabankApi.Repositories;

public interface IUserRepositories
{
    Task RegisterUserAsync(User user);
    Task<List<User>> GetAllUserAsync(CancellationToken cancellationToken);
    Task GetSearchUserAsync(string searchTerm, CancellationToken cancellationToken);
    Task<User?> GetUserByIdAsync(Guid id);
    Task UpdateUserAsync(Guid id, User user);
    Task<bool> DeleteUserAsync(Guid id, CancellationToken cancellationToken);
    Task<bool> ExsitingUserAsync(string username);
}