using DatabankApi.Database;

namespace DatabankApi.Repositories;



public class UserRepositories : IUserRepositories
{

    private readonly AppDbContext _dbContext;

    public UserRepositories(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}