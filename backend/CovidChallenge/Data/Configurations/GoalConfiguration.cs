using CovidChallenge.Domain.Challenges;
using CovidChallenge.DomainShared.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChallenge.Context.Configurations
{
    public class GoalConfiguration : IEntityTypeConfiguration<Goal>

    {
        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            //TODO: investigar como agregar entidades en cascada

            //var goalId = Guid.NewGuid();
            //var actionId = Guid.NewGuid();

            //builder.HasData(
            //    new Goal
            //    {
            //        Id = goalId,
            //        Title = "Al Corona con jabón",
            //        Description = "Una descripción",
            //        StartDate = DateTime.Now.Date,
            //        EndDate = DateTime.Now.Date.AddDays(15),
            //        RewardType = RewardType.Star,
            //        GoalActionsRules = new List<GoalActionRule>
            //         {
            //             new GoalActionRule
            //             {
            //                 GoalId = goalId,
            //                 ActionId =actionId,
            //                 Action = new AppAction
            //                 {
            //                     Id = actionId,
            //                     Title ="Lavarse las manos",
            //                     Description = "Lavarse las manos es una de las mejores prácticas...",
            //                     Areas = ActionArea.Personal_Heathcare,
            //                     TimeframeWindow = TimeSpan.FromMinutes(15)
            //                 }
            //             }
            //         }
            //    });
        }
    }
}
