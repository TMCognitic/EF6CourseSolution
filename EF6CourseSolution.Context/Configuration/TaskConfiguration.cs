using EF6CourseSolution.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF6CourseSolution.Context.Configuration
{
    internal class TaskConfiguration : ConfigurationBase<Task>
    {
        public override void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Task");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1000);
        }
    }
}
