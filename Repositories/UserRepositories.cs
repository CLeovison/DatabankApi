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
    public async Task RegisterUserAsync(User user)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();

        await dbContext.Set<User>().AddAsync(user);
        await dbContext.SaveChangesAsync();
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
    public async Task<User?> GetUserByIdAsync(Guid id)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        return await dbContext.User.FindAsync(id);
    }
    public async Task UpdateUserAsync(Guid id, User user)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var userUpdate = await dbContext.User.FindAsync(user.UserId);

        if (userUpdate is null) return;

        dbContext.Entry(userUpdate).CurrentValues.SetValues(user);
        await dbContext.SaveChangesAsync();

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
