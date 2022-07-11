using EF6CourseSolution.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF6CourseSolution.Context.Configuration
{
    internal class UserConfiguration : ConfigurationBase<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(384);

            builder.Property(u => u.Passwd)
                .IsRequired()
                .HasColumnType("BINARY(64)")
                .HasConversion(new ValueConverter<string?, byte[]?>(v => v.Hash(), v => null));
        }
    }
}
