using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Glazing:Decorator
    {
        public Glazing(Dish dish)
            : base(dish)
        {
            Cost += 100;
            Supplemets += "(Глазировка в соевом соусе)";
        }
    }
}
