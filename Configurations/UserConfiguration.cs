using DatabankApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabankApi.Configurations;

public sealed class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> user)
    {
        user.HasIndex(x => x.UserId);
        user.HasKey(x => x.UserId);

        user.Property(c => c.UserId)
        .HasDefaultValueSql("gen_random_uuid()")
        .ValueGeneratedOnAdd();

        user.Property(n => n.FirstName)
        .IsRequired()
        .HasMaxLength(100);


        user.Property(n => n.LastName)
        .IsRequired()
        .HasMaxLength(100);

        user.Property(d => d.CreatedAt)
        .HasDefaultValueSql("current_date");

    }
}