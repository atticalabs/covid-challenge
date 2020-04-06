using CovidChallenge.DomainShared.Enums;
using System;

namespace CovidChallenge.DomainDtos
{
    public class AppActionDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ActionArea Areas { get; set; }
        
    }
}
