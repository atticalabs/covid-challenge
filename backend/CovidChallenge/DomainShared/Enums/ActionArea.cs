using System;

namespace CovidChallenge.DomainShared.Enums
{
    [Flags]
    public enum ActionArea
    {
        Personal_Heathcare = 0,
        Home_Heathcare = 1,
        Social_Behavior = 2,
        //nextItem = 4,
        //nextItem = 8,
        //POTENCIA DE 2
    }
}
