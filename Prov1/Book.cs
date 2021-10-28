using System;
using System.Collections.Generic;

namespace Prov1
{
    public class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();
        List<string> introName = new List<string>()
        {
            "Crazy", "The Amazing", "Curious", "Ultimate", "Illegal"
        };
        List<string> endName = new List<string>()
        {
            "George", "Hacker", "Goblin", "Guide", "Game"
        };
        List<string> categories = new List<string>(){
            "Scary", "Adventure", "Roleplaying", "Documentary", "Sci-Fi"
        };


        public Book()
        {
            int u = generator.Next(0, introName.Count);
            int u2 = generator.Next(0, endName.Count);
            name = introName[u] + "" + endName[u2];
            actualValue = generator.Next(300, 150001);
            rarity = generator.Next(1, 11);
            int i = generator.Next(0, 2);
            if (i == 0)
            {
                cursed = false;
            }
            else
            {
                cursed = true;
            }
            int z = generator.Next(0, categories.Count);
            category = categories[z];


        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name + " Rarity: " + rarity + " Category: " + category + " Price " + price);
        }

    }
}