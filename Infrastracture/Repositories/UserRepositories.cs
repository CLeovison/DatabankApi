using DatabankApi.Database;
using DatabankApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabankApi.Repositories;


public sealed class UserRepositories(IDbContextFactory<AppDbContext> dbContextFactory) : IUserRepositories
{

    public async Task<bool> CreateUserAsync(User user)
    {
        var dbContext = dbContextFactory.CreateDbContext();
        var newUser = await dbContext.Set<User>().AddAsync(user);
        await dbContext.SaveChangesAsync();


        return newUser is not null;

    }
    public async Task<IEnumerable<User>> GetAllUserAsync(CancellationToken ct)
    {

        var dbContext = dbContextFactory.CreateDbContext();

        return await dbContext.User.ToListAsync(ct);
      
    }
}