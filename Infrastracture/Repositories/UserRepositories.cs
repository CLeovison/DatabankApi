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
    public async Task<User?> GetUserByIdAsync(Guid id, CancellationToken ct)
    {
        var dbContext = dbContextFactory.CreateDbContext();

        return await dbContext.User.FindAsync(id, ct);
    }

    public async Task<User?> UpdateUserAsync(User users, CancellationToken ct)
    {
        var dbContext = dbContextFactory.CreateDbContext();
        dbContext.User.Update(users);
        await dbContext.SaveChangesAsync();
        return users;
    }
    public async Task<bool> DeleteUserAsync(User user)
    {
        var dbContext = dbContextFactory.CreateDbContext();

        var deleteUser = dbContext.Set<User>().Remove(user);
        await dbContext.SaveChangesAsync();

        return deleteUser is not null;
    }
}