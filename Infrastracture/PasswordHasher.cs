using System.Security.Cryptography;
using DatabankApi.Entities;
using Microsoft.AspNetCore.Identity;

namespace DatabankApi.Infrastracture;


internal sealed class PasswordHasher : IPasswordHasher<User>
{
    private const int SaltSize = 16;
    private const int HashSize = 32;
    private const int Iterations = 100000;
    private static readonly HashAlgorithmName Algorithm = HashAlgorithmName.SHA512;


    public string HashPassword(User user, string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, Algorithm, HashSize);

        return $"{Convert.ToHexString(hash)}-{Convert.ToHexString(salt)}";
    }

    public PasswordVerificationResult VerifyHashedPassword(User user, string hashedPassword, string providedPassword)
    {
        var providedPasswordHashed = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(providedPassword));
        return hashedPassword == providedPassword ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
    }

}