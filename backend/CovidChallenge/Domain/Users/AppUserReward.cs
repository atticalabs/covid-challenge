using CovidChallenge.Domain.Challenges;
using CovidChallenge.DomainShared.Enums;
using System;

namespace CovidChallenge.Domain.Users
{
    public class AppUserReward
    {
        public string AppUserId { get; set; }
        public AppUser User { get; set; }

        public Guid GoalId { get; set; }
        public Goal Goal { get; set; }

        public RewardType RewardType { get; set; }
    }
}
