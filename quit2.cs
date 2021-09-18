using System;
using System.Collections.Generic;

namespace week6_quit2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRose, numSunflower;
            Console.WriteLine("Input total Rose: ");
            numRose = int.Parse(Console.ReadLine());
            Console.WriteLine("Input total Sunflower: ");
            numSunflower = int.Parse(Console.ReadLine());

            Rose firstrose = new Rose(numRose, 1, "redrose", "beauty", 2, 2, 1.5);
            Rose secondrose = new Rose(numRose, 2, "blackrose", "beauty, nice", 2, 1.8, 1.4);

            Sunflower firstsun = new Rose(numSunflower, 1, "smallsunflower", "normal", 2, 5, 3);
            Sunflower firstsun = new Rose(numSunflower, 2, "bigsunflower", "beauty", 2, 5, 2);

        }
    }

    class Tree
    {
        public int totalflower;
        public int id;
        public string name;
        public string description;
        public int amount;
        public int height;
        public int circumference;

        public Tree (int totalflower, int id, string name, string description, int amount, int height, int circumference)
        {
            this.totalflower = totalflower;
            this.id = id;
            this.name = name;
            this.description = description;
            this.amount = amount;
            this.height = height;
            this.circumference = circumference;
        }
    }

    class Rose: Tree {}
    class Sunflower: Tree {}
   
}
