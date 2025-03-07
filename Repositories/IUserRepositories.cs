using DatabankApi.Contracts.Data;

namespace DatabankApi.Repositories;

public interface IUserRepositories
{
    Task<bool> RegisterUserAsync();
    Task<UserDto> GetUserByIdAsync();
    Task<UserDto> GetAllUserAsync();
}