using System;
using System.Collections.Generic;
using System.Text;

namespace kursova.food
{
   public class Food
    {
        public static Dictionary<string, double?> FoodCategory = new Dictionary<string, double?> {
        { "салата", null },
        { "супа", null },
        { "основно ястие", 1 },
        { "десерт", 3 },
        { "напитка", 1.5 },
    };
        public Food(string category, string name, int weight, decimal price)
        {
            this.Category = category;
            this.Name = name;
            this.Weight = weight;
            this.Price = price;

            
        }

       

        public string Category { get; private set; }

        public string Name { get; private set; }

        public int Weight { get; private set; }

        public decimal Price { get; private set; }


        public string FoodInfo()
        {
            return ($"{this.Name} {this.Category} {this.Weight}  {this.Price} ");
        }
















    }




}
