using System;
using System.Collections.Generic;

namespace Prov1
{
    public class Customer
    {
        List<string> nameMale = new List<string>()
        {
            "Micke", "Axel", "Morris", "Edvin", "John", "Theo", "Leo", "Sef", "Jing", "Moise", "Amir", "Lorens", "Linkan", "Adam", "Viktor", "Arvid", "Bredvin", "Gangplank", "Rowan", "Oak", "Elm", "Willow", "Birch", "Sycamore",
        };
        List<string> nameFemale = new List<string>() {
            "Amanda", "Tina", "Emma", "Kunigunda", "PissåsnAnette", "Lena", "Stella", "Frida", "Freja", "Hillary", "Hedda", "Magdalena", "Anastasia", "Cleopatra", "Klara", "Theos Mamma", "Morris Mamma", "Nia", "Milf", "Marina", "Milker Mom", "Magnolia", "Juniper", "Ivy"
        };
        public string maleName; //namnger kunden
        public string femaleName;
        protected Random generator = new Random();
        public string gender; //0 = kille, 1= tjej
        public string intrest; // bestämmer vilken kategori kunden vill ha
        public float customerKnowledge;
        public Customer()
        {
            int i = generator.Next(0, nameMale.Count);
            maleName = nameMale[i];
            int u = generator.Next(0, nameFemale.Count);
            femaleName = nameFemale[u];
            customerKnowledge = (float)(0.75 + generator.NextDouble() * 0.25);

        }
        public void genderCheck()
        {
            if (this is StupidCustomer)
            {
                Console.WriteLine("Durr");
            }



            while (gender != "male" && gender != "female")
            {

                gender = Console.ReadLine().ToLower();
            }
            if (gender == "male")
            {
                Console.WriteLine($"Oh Right, its a dude and his name is {maleName}");
                Console.WriteLine(this is StupidCustomer ? "He Looks A Little Strange..." : "");
            }
            else if (gender == "female")
            {
                Console.WriteLine($"Right, its a chick and her name is {femaleName}");
                Console.WriteLine(this is StupidCustomer ? "Her Eyes Are Drifting Apart" : "");

            }
        }

        public Book BuyBook()
        {
            return new Book();
        }


    }
}



