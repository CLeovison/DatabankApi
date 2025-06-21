namespace DatabankApi.Contracts.Data;


public class UserDto
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }

    public required string Department { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }

}