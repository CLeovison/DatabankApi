using DatabankApi.Contracts.Data;
using DatabankApi.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Mapping;

public static class EntitiesToDtoMapper
{
    public static User ToDto(this UserDto userDto, IPasswordHasher<User> passwordHasher)
    {
        return new User
        {
            FirstName = userDto.FirstName,
            LastName = userDto.LastName,
            Email = userDto.Email,
            Department = userDto.Department,
            Username = userDto.Username,
            Password = passwordHasher.HashPassword(new User(), userDto.Password),
        };
    }



}