using DatabankApi.Database;
using DatabankApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace DatabankApi.Repositories;



public class UserRepositories(IDbContextFactory<AppDbContext> _dbContextFactory)
{

    public async Task RegisterUserAsync(User user, CancellationToken cancellationToken)
    {
        using var dbContext = await _dbContextFactory.CreateDbContextAsync(cancellationToken);


    }

}
