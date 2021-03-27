using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Dish
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public double Cost { get; set; }
        public Dish() 
        {
            Ingredients = "нори, рис, ";
            Cost = 180;
        }
        public Dish(string name) 
        {
            Name = name;
            Ingredients = "нори, рис, ";
            Cost = 180;
        }
        public Dish(string name, string ingredients, double cost)
        {
            Name = name;
            Ingredients = ingredients; 
            Cost = cost;
        }
        public override string ToString()
        {
            return $"{Name} ({Ingredients}) - {Cost}₽.";
        }
    }
}
