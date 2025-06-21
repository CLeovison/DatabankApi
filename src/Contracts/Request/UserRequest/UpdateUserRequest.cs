namespace DatabankApi.Contracts.Request.UserRequest;
public class UpdateUserRequest
{
    public Guid UserId { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
    public required string Department { get; init; }
    public required DateTime UpdatedAt { get; init; }
    public bool IsSoftDeleted { get; init; }
}