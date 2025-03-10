namespace DatabankApi.Entities;

public class User
{
    public Guid UserId { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public bool IsSoftDeleted { get; init; } = false;
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }

}