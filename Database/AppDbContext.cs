
using DatabankApi.Contracts.Data;
using DatabankApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabankApi.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public required DbSet<User> User { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
};

