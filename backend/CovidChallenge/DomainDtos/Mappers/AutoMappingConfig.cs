using AutoMapper;
using CovidChallenge.Domain.Challenges;

namespace CovidChallenge.DomainDtos.Mappers
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<Goal, GoalDto>();
            CreateMap<AppAction, AppActionDto>();
            CreateMap<GoalActionRule, GoalActionRuleDto>();
        }
    }
}
