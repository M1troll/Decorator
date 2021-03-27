using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Hotate: Dish
    {
        public Hotate() : base()
        {
            Name = "Хотатэ (гребешок)";
            Cost += 205;
            Ingredients += "гребешок";
        }
        public Hotate(string name) : base(name)
        {
            Name = $"Хотатэ (гребешок) {name}";
            Cost += 205;
            Ingredients += "гребешок";
        }
        public Hotate(string name, string ingredients, double cost) 
            : base(name, ingredients, cost)
        {
            Name = $"Хотатэ (гребешок) {name}";
            Cost += 205;
            Ingredients += "гребешок";
        }
    }
}
