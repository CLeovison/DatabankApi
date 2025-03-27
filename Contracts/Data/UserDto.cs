namespace DatabankApi.Contracts.Data;


public class UserDto
{
    public Guid UserId { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Department { get; init; }
    public DateOnly CreatedAt { get; init; }
    public DateOnly UpdatedAt { get; init; }
}