using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class SprinkleSesame : Decorator
    {
        public SprinkleSesame(Dish dish)
            : base(dish)
        {
            Cost += 15;
            Supplemets += "(Кунжутная посыпка)";
        }
    }
}
