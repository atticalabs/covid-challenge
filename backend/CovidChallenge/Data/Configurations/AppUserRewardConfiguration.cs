using CovidChallenge.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CovidChallenge.Context.Configurations
{
    public class AppUserRewardConfiguration : IEntityTypeConfiguration<AppUserReward>
    {
        public void Configure(EntityTypeBuilder<AppUserReward> builder)
        {
            builder.ToTable("AppUserRewards");
            builder.HasKey(o => new { o.AppUserId, o.GoalId });

            builder.HasOne(o => o.User)
                   .WithMany()
                   .HasForeignKey(o => o.AppUserId);

            builder.HasOne(o => o.Goal)
                   .WithMany()
                   .HasForeignKey(o => o.GoalId);
        }
    }
}
