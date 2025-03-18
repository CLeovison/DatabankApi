using DatabankApi.Database;
using DatabankApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabankApi.Repositories;



public class UserRepositories : IUserRepositories
{

    private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

    public UserRepositories(IDbContextFactory<AppDbContext> dbContext)
    {
        _dbContextFactory = dbContext;
    }

    public async Task RegisterUserAsync(User user, CancellationToken cancellationToken)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
        await 

    }

    public async Task<User> GetUserByIdAsync(Guid id)
    {
        using var db
    }


    public async Task<List<User>> GetAllUserAsync()
    {

    }
}
