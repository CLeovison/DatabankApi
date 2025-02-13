using System.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DatabankApi.Database;

public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateConnectionAsync();
}


public class PostgresConnectionFactory(string connectionString) : IDbConnectionFactory
{

    public async Task<IDbConnection> CreateConnectionAsync()
    {
        var connection = new 
    }
}