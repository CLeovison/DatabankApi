using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Entities;

namespace DatabankApi.Mapping;


public static class ContractsToEntitiesMapper
{
    public static RegisterUserRequest ToRegister(this User user)
    {
        return new RegisterUserRequest
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Department = user.Department,
            Username = user.Username,
            Password = user.Password,
        };
    }
}