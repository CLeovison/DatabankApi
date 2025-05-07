namespace DatabankApi.Services;


public interface IUserServices
{
    Task<bool> CreateUserAsync();
}