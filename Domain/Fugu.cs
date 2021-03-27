using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Fugu:Dish
    {
        public Fugu() : base() 
        {
            Name = "Суши с Фугу";
            Cost += 150;
            Ingredients += "филе Фугу, огурец, кунжут, крем сыр";
        }
        public Fugu(string name) : base(name) 
        {
            Name = $"Суши с Фугу {name}";
            Cost += 150;
            Ingredients += "филе Фугу, огурец, кунжут, крем сыр";
        }
        public Fugu(string name, string ingredients, double cost) 
            : base(name, ingredients, cost)
        {
            Name = $"Суши с Фугу {name}";
            Cost += 150;
            Ingredients += "филе Фугу, огурец, кунжут, крем сыр";
        }
    }
}
