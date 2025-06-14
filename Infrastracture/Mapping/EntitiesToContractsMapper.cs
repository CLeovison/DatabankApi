using DatabankApi.Contracts.Response.UserResponse;
using DatabankApi.Domain.Entities;

namespace DatabankApi.Mapping;


public static class EntitiesToContractsMapper
{

    public static RegisterUserResponse ToUserResponse(this User user)
    {
        return new RegisterUserResponse
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Department = user.Department,
            Username = user.Username,

        };
    }
}