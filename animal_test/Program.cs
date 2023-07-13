using System.Collections.Generic;

namespace Zoo
{
    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public string Color { get; set; }

        // Constructor
        public Animal(string Name, int Legs, string Color)
        {
            Name = Name;
            Legs = Legs;
            Color = Color;
        }

        Animal Animal1 = new Animal("Rabbit", 4, "White");
        Animal Animal2 = new Animal("Kangaroo", 5, "Brown");
        Animal Animal3 = new Animal("Lion", 4, "Brown");
    }
    public class Methods
    {
        public static void Eating()
            {
            Console.WriteLine("");
            }
            public static void Sleeping()
            {
            Console.WriteLine("");
        }
    }
    
} 
    
    