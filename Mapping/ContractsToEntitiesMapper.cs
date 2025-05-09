using DatabankApi.Contracts.Request.UserRequest;
using DatabankApi.Entities;

namespace DatabankApi.Mapping;


public static class ContractsToEntitiesMapper
{
    public static User ToRegister(this RegisterUserRequest req)
    {
        return new User
        {
            FirstName = req.FirstName,
            LastName = req.LastName,
            Email = req.Email,
            Department = req.Department,
            Username = req.Username,
            Password = req.Password,
        };
    }
}