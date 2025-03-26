namespace DatabankApi.Contracts.Request.UserRequest;

public class RegisterUserRequest
{
    public Guid UserId { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public DateOnly CreatedAt { get; init; }
}