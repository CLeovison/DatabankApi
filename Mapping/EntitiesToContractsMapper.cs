using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Entities;

namespace DatabankApi.Mapping;


public static class EntitiesToContractsMapper
{
    public static RegisterUserRequest ToService(this User user)
    {
        return new RegisterUserRequest
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Username = user.Username,
            Password = user.Password,
            Email = user.Email,
            Department = user.Department
        };
    }
}