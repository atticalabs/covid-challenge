using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidChallenge.Domain.Challenges
{
    public class GoalActionRule
    {
        public Guid GoalId { get; set; }
        public Goal Goal { get; set; }

        public Guid ActionId { get; set; }
        public AppAction Action { get; set; }

        public bool Completed { get; set; }

        //PENDIENTE ENUM QUE INDIQUE LA REGLA QUE APLICA: (Falta definir el set de opciones)
        //  REGLA: UnicaVez, Al menos 1 vez, 2vecesPorDiaDurante3Días, etc. 
    }
}
