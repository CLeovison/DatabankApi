using DatabankApi.Enums;

namespace DatabankApi.Entities;

public class User
{
    public Guid UserId { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public DateOnly CreatedAt { get; init; }
}

