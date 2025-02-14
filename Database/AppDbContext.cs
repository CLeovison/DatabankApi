using DatabankApi.Contracts.Data;
using Microsoft.EntityFrameworkCore;

namespace DatabankApi.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public required DbSet<UserDto> UserDto { get; init; }
}