using DatabankApi.Migrations;

namespace DatabankApi.Services;


public interface IUserService
{
    Task<bool> RegisterUserAsync();
    Task UpdateUserAsync();
    Task<bool> DeleteUserAsync();
    Task<IEnumerable<Users>> GetAllUserAsync();
}