using DatabankApi.Entities;

namespace DatabankApi.Repositories;

public interface IUserRepositories
{
    Task RegisterUserAsync(User user, CancellationToken cancellationToken);
    Task<User> GetUserByIdAsync(Guid id);
    Task<List<User>> GetAllUserAsync();
}