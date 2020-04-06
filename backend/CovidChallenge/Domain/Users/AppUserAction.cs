using CovidChallenge.Domain.Challenges;
using System;

namespace CovidChallenge.Domain.Users
{
    public class AppUserAction
    {
        public string AppUserId { get; set; }
        public virtual AppUser User { get; set; }

        public Guid GoalId { get; set; }
        public virtual Goal Goal { get; set; }

        public Guid ActionId { get; set; }
        public virtual AppAction Action { get; set; }

        public DateTime CreationDateTime { get; set; }
    }
}
