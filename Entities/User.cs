

namespace DatabankApi.Entities;

public class User
{
    public Guid UserId { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
    public required string Department { get; init; }

    public DateOnly CreatedAt { get; init; }
    public DateOnly UpdatedAt { get; init; }
}

