using System;
using System.Collections.Generic;

namespace Prov1
{
    public class Customer
    {
        List<string> nameMale = new List<string>()
        {
            "Micke", "Axel", "Morris", "Edvin", "John"
        };
        List<string> nameFemale = new List<string>() {
            "Amanda", "Tina", "Emma", "Kunigunda", "PissåsnAnette"
        };
        public string maleName; //namnger kunden
        public string femaleName;
        private Random generator = new Random();
        public string gender; //0 = kille, 1= tjej
        public string intrest; // bestämmer vilken kategori kunden vill ha
        public Customer()
        {
            int i = generator.Next(0, nameMale.Count);
            maleName = nameMale[i];
            int u = generator.Next(0, nameFemale.Count);
            femaleName = nameFemale[u];

        }
    }
}