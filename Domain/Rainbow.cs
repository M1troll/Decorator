using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rainbow : Dish
    {
        public Rainbow() : base()
        {
            Name = "Ролл Радуга";
            Cost += 65;
            Ingredients += "авокадо, краб, тунец, крем сыр";
        }
        public Rainbow(string name) : base(name)
        {
            Name = $"Ролл Радуга {name}";
            Cost += 65;
            Ingredients += "авокадо, краб, тунец, крем сыр";
        }
        public Rainbow(string name, string ingredients, double cost)
            : base(name, ingredients, cost)
        {
            Name = $"Ролл Радуга {name}";
            Cost += 65;
            Ingredients += "авокадо, краб, тунец, крем сыр";
        }
    }
}
