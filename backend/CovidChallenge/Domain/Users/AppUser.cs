using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CovidChallenge.Domain.Users
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Actions = new List<AppUserAction>();
            Rewards = new List<AppUserReward>();
        }
                
        public string Name { get; set; }
        public string LastName { get; set; }

        public virtual IList<AppUserAction> Actions { get; set; }
        public virtual IList<AppUserReward> Rewards { get; set; }
    }
}
