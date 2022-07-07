using EF6CourseSolution.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF6CourseSolution.Context.Configuration
{
    internal class ProjectConfiguration : ConfigurationBase<Project>
    {
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(p => p.DeadLine)
                .IsRequired()
                .HasColumnType("DATE");
        }
    }
}
