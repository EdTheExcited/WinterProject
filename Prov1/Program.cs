using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write Your Cool Examination Code Here:
            Book b1 = new Book();
            Customer c1 = new Customer();

            Console.WriteLine("You now run a bookshop u peasant, here is your first customer. What gender are they?\n (Male / Female)");
            while (c1.gender != "male" && c1.gender != "female")
            {

                c1.gender = Console.ReadLine().ToLower();
            }
            if (c1.gender == "male")
            {
                Console.WriteLine($"Oh Right, its a dude and his name is {c1.maleName}");
            }
            else if (c1.gender == "female")
            {
                Console.WriteLine($"Right, its a chick and her name is {c1.femaleName}");
            }

            Console.WriteLine("Here is the first Book:");
            b1.PrintInfo();

            Console.ReadLine();

        }
    }
}
