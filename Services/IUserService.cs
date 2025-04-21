using DatabankApi.Entities;

namespace DatabankApi.Services;


public interface IUserService
{
    Task<bool> RegisterUserService(User user, CancellationToken ct);

}