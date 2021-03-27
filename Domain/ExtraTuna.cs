using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ExtraTuna : Decorator
    {
        public ExtraTuna(Dish dish)
            : base(dish)
        {
            Cost += 95;
            Supplemets += "(Дополнительный тунец)";
        }
    }
}
