using DatabankApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        user.Property(n => n.Username)
        .IsRequired()
        .HasMaxLength(20);

        user.Property(n => n.Password)
        .IsRequired()
        .HasMaxLength(250);

        user.Property(n => n.FirstName)
        .IsRequired()
        .HasMaxLength(100);

        user.Property(n => n.LastName)
        .IsRequired()
        .HasMaxLength(100);

        user.Property(n => n.Department)
        .IsRequired();

        user.Property(d => d.CreatedAt)
        .HasDefaultValueSql("current_date");

        user.Property(d => d.UpdatedAt)
        .ValueGeneratedOnAddOrUpdate()
        .HasDefaultValueSql("current_date")
        .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);



    }
}