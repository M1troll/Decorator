using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Unagi:Dish
    {
        public Unagi() : base()
        {
            Name = "Унаги ролл";
            Cost += 75;
            Ingredients += "тунец, огурец, морской угорь, крем сыр";
        }
        public Unagi(string name) : base(name)
        {
            Name = $"Унаги ролл {name}";
            Cost += 75;
            Ingredients += "тунец, огурец, морской угорь, крем сыр";
        }
        public Unagi(string name, string ingredients, double cost)
            : base(name,ingredients,cost) 
        {
            Name = $"Унаги ролл {name}";
            Cost += 75;
            Ingredients += "тунец, огурец, морской угорь, крем сыр";
        }
    }
}
