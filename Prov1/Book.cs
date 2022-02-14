using System;
using System.Collections.Generic;
namespace Prov1
{
    public class Book
    {
        public string name { get; private set; }
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();
        List<string> introName = new List<string>()
        {
            "Crazy", "The Amazing", "Curious", "Ultimate", "Illegal", "Sexy", "Sentimental", "Horny", "Baby"
        };
        List<string> endName = new List<string>()
        {
            "George", "Hacker", "Goblin", "Guide", "Game", "Devils", "Curses", "Lord", "Rainbow Dildo"
        };
        List<string> categories = new List<string>(){
            "Horror", "Adventure", "Roleplaying", "Documentary", "Sci-Fi", "Autobiography", "Medieval"
        };

        public override string ToString()
        {
            return name;
        }


        public Book()
        {
            int u = generator.Next(0, introName.Count);
            int u2 = generator.Next(0, endName.Count);
            name = introName[u] + " " + endName[u2];
            actualValue = generator.Next(300, 1501);
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

        public int Price(Customer customer)
        {
            return (int)(actualValue * rarity * customer.customerKnowledge);
        }

        public void PrintInfo(Customer customer)
        {
            Console.WriteLine("Name: " + name + "\n Rarity: " + rarity + "\n Category: " + category + "\n Price " + Price(customer));
        }

    }
}