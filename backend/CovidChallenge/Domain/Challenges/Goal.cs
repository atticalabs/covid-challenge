﻿using CovidChallenge.DomainShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChallenge.Domain.Challenges
{
    public class Goal
    {
        public Goal()
        {
            GoalActionsRules = new List<GoalActionRule>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual IList<GoalActionRule> GoalActionsRules { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public RewardType RewardType { get; set; }

    }
}
