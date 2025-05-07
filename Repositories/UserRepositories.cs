using DatabankApi.Contracts.Data;
using DatabankApi.Database;
using Microsoft.EntityFrameworkCore;

namespace DatabankApi.Repositories;


public sealed class UserRepositories(IDbContextFactory<AppDbContext> dbContextFactory) : IUserRepositories
{

    public async Task<bool> CreateUserAsync(UserDto userDto)
    {
        var dbContext = dbContextFactory.CreateDbContext();
        var newUser = await dbContext.Set<UserDto>().AddAsync(userDto); 

        return newUser is not null;

    }

}