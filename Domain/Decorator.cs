using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Decorator:Dish
    {
        protected Dish dish;
        public string Supplemets { get; set; }
        public Decorator(Dish dish)
            : base(dish.Name, dish.Ingredients, dish.Cost)
        {
            this.dish= dish;
            if(dish is Decorator)
            {
                var d = (Decorator)dish;
                Supplemets = d.Supplemets; 
            }
        }
        public override string ToString()
        {
            return base.ToString() + Supplemets;
        }
    }
}
