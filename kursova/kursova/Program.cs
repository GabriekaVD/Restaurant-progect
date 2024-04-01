using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace kursova
{
    class Program
    {
        List<food.Food> orders = new List<food.Food>();

        static void Main(string[] args)
        {
            bool menuAdding = true;
            
            
            while (menuAdding)
            {
                string[] input = Console.ReadLine().Split(", ");



                if ((input[0].Equals("продажби")) || (input[0].Equals("изход")))
                {

                    if (input[0].Equals("продажби"))
                    { 
                    Console.WriteLine("test1");
                    }

                }


                    if (input.Length < 1)
                {
                    continue;
                }

            }
        
    



        }
        
    }
}
