using CovidChallenge.DomainShared.Enums;
using System;
using System.Collections.Generic;

namespace CovidChallenge.DomainDtos
{
    public class GoalDto
    {
        public GoalDto()
        {
            GoalActionsRules = new List<GoalActionRuleDto>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public IList<GoalActionRuleDto> GoalActionsRules { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public RewardType RewardType { get; set; }
    }
}
