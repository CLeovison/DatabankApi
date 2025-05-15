namespace DatabankApi.Contracts.Response.UserResponse;

public sealed class RegisterUserResponse
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
    public required string Department { get; init; }
    public required string Username { get; init; }
    public DateOnly CreatedAt { get; init; }
}