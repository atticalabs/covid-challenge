using CovidChallenge.DomainShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChallenge.Domain.Challenges
{
    public class AppAction
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual IList<GoalActionRule> GoalActionsRules { get; set; }

        public ActionArea Areas { get; set; }
        public TimeSpan TimeframeWindow { get; set; }
    }
}
