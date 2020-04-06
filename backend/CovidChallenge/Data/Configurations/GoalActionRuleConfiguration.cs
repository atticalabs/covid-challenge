using CovidChallenge.Domain.Challenges;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChallenge.Context.Configurations
{
    public class GoalActionRuleConfiguration : IEntityTypeConfiguration<GoalActionRule>

    {
        public void Configure(EntityTypeBuilder<GoalActionRule> builder)
        {
            builder.ToTable("GoalActionRules");
            builder.HasKey(o => new { o.GoalId, o.ActionId });

            builder.HasOne(o => o.Action)
                   .WithMany(o => o.GoalActionsRules)
                   .HasForeignKey(o => o.ActionId);

            builder.HasOne(o => o.Goal)
                   .WithMany(o => o.GoalActionsRules)
                   .HasForeignKey(o => o.GoalId);
        }
    }
}
