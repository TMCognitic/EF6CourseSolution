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

            builder.Property(t => t.UserId)
                .IsRequired(false);

            builder.Property(t => t.ParentId)
                .IsRequired(false);

            builder.HasOne<Project>()
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.User)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<Task>()
                .WithMany(t => t.Children)
                .HasForeignKey(t => t.ParentId);

            builder.HasCheckConstraint("CK_Task_ParentId", "(ParentId != Id)");
        }
    }
}
