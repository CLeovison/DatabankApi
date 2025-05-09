using DatabankApi.Entities;

namespace DatabankApi.Services;


public interface IUserServices
{
    Task<bool> CreateUserAsync(User user);
}