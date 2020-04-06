using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChallenge.DomainDtos
{
    public class GoalActionRuleDto
    {
        public Guid GoalId { get; set; }
        public Guid ActionId { get; set; }
        public AppActionDto Action { get; set; }

        public bool Completed { get; set; }
    }
}
