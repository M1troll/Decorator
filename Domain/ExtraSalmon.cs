using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ExtraSalmon:Decorator
    {
        public ExtraSalmon(Dish dish)
            : base(dish)
        {
            Cost += 120;
            Supplemets += "(Дополнительный лосось)";
        }
    }
}
