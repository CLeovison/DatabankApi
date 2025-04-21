using DatabankApi.Entities;
using DatabankApi.Repositories;

namespace DatabankApi.Services;

public class UserService : IUserService
{
    private readonly IUserRepositories _userRepositories;


    public UserService(IUserRepositories userRepositories)
    {
        _userRepositories = userRepositories;
    }

    public async Task<bool> RegisterUserService(User user, CancellationToken ct)
    {
        await _userRepositories.RegisterUserAsync(user, ct);
        return true;
    }


}