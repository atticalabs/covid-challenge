using CovidChallenge.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CovidChallenge.Context.Configurations
{
    public class AppUserActionConfiguration : IEntityTypeConfiguration<AppUserAction>
    {
        public void Configure(EntityTypeBuilder<AppUserAction> builder)
        {
            builder.ToTable("AppUserActions");
            builder.HasKey(o => new { o.AppUserId, o.GoalId, o.ActionId });

            builder.HasOne(o => o.User)
                        .WithMany(o => o.Actions)
                        .HasForeignKey(o => o.AppUserId);

            builder.HasOne(o => o.Action)
                        .WithMany()
                        .HasForeignKey(o => o.ActionId);

            builder.HasOne(o => o.Goal)
                        .WithMany()
                        .HasForeignKey(o => o.GoalId);
        }
    }
}
