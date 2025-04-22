using DatabankApi.Entities;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Services;


public interface IUserService
{
    Task<User?> RegisterUserService(User user, IPasswordHasher<User> passwordHasher);

}