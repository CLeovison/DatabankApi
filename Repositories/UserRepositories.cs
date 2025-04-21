using DatabankApi.Database;
using DatabankApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabankApi.Repositories;

public class UserRepositories : IUserRepositories
{

    private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

    public UserRepositories(IDbContextFactory<AppDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }
    public async Task RegisterUserAsync(User user, CancellationToken cancellationToken)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);

        await dbContext.Set<User>().AddAsync(user, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<User>> GetAllUserAsync(CancellationToken cancellationToken)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);

        return await dbContext.User.ToListAsync();
    }

    public async Task GetSearchUserAsync(string searchTerm, CancellationToken cancellationToken)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);

        var user = await dbContext.User
        .Where(x => x.Username.Contains(searchTerm)
              || x.FirstName.Contains(searchTerm)
              || x.LastName.Contains(searchTerm))
        .Select(n => new
        {
            n.Username,
            n.FirstName,
            n.LastName
        }).ToListAsync();
    }
    public async Task<User?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
        return await dbContext.User.FindAsync(id, cancellationToken);
    }
    public async Task<bool> UpdateUserAsync(User user, CancellationToken cancellationToken)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
        var userUpdate = dbContext.Set<User>().Update(user);
        await dbContext.SaveChangesAsync(cancellationToken);
        return userUpdate is null;

    }

    public async Task<bool> DeleteUserAsync(Guid id, CancellationToken cancellationToken)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
        var userDelete = dbContext.User.Where(x => x.UserId == id).ExecuteDelete();
        return userDelete > 0;


    }

    public async Task<bool> ExsitingUserAsync(string username)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        return await dbContext.User.AnyAsync(u => u.Username == username);


    }
}
