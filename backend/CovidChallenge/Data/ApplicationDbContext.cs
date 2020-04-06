using CovidChallenge.Context.Configurations;
using CovidChallenge.Domain.Challenges;
using CovidChallenge.Domain.Users;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChallenge.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
        }

        #region DbSet
        public DbSet<AppAction> Actions { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<GoalActionRule> GoalActionRules { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserAction> AppUserActions { get; set; }
        public DbSet<AppUserReward> AppUserRewards { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AppUserActionConfiguration());
            builder.ApplyConfiguration(new AppUserRewardConfiguration());
            builder.ApplyConfiguration(new GoalActionRuleConfiguration());

        }
    }
}
