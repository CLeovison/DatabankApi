using DatabankApi.Contracts.Data;
using DatabankApi.Entities;

namespace DatabankApi.Repositories;

public interface IUserRepositories
{
    Task RegisterUserAsync(User user, CancellationToken cancellationToken);
    Task<UserDto> GetUserByIdAsync();
    Task<UserDto> GetAllUserAsync();
}