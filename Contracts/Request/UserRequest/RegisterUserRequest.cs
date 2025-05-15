namespace DatabankApi.Contracts.Request.UserRequest;

public sealed class RegisterUserRequest
{
    public Guid UserId { get; init; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public bool IsSoftDeleted { get; set; } = false;
    public DateOnly CreatedAt { get; init; }

}