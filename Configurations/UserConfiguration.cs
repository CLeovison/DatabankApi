using DatabankApi.Contracts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabankApi.Configurations;

public sealed class UserConfigurations : IEntityTypeConfiguration<UserDto>
{
    public void Configure(EntityTypeBuilder<UserDto> user)
    {
        user.HasIndex(x => x.UserId);
        user.HasKey(x => x.UserId);
        user.Property(n => n.FirstName);
        user.Property(n => n.LastName);
        user.Property(n => n.Username);
        user.Property(n => n.Password);
    }
}