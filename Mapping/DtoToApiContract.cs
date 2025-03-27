using DatabankApi.Contracts.Data;
using DatabankApi.Contracts.Request.UserRequest;

namespace DatabankApi.Mapping;

public static class DtoToApiContract
{
    public static UserDto ToRegisterUser(this RegisterUserRequest request)
    {
        return new UserDto
        {
            UserId = request.UserId,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Department = request.Department,
            UpdatedAt = request.UpdatedAt,
            CreatedAt = request.CreatedAt
        };
    }
}