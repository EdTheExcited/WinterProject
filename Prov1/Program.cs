using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write Your Cool Examination Code Here:
            Store store = new Store();
            UI ui = new UI();

            System.Console.WriteLine();
            while (store.notBankrupt == true)
            {
                ui.updateMoney(store.Money);
                Console.WriteLine(@"
 ________  ________  ________  ___  ___  _______   ________  ___  ___  ________  ________  _______      
|\   __  \|\   __  \|\   ____\|\  \|\  \|\  ___ \ |\   ____\|\  \|\  \|\   __  \|\   __  \|\  ___ \     
\ \  \|\  \ \  \|\  \ \  \___|\ \  \\\  \ \   __/|\ \  \___|\ \  \\\  \ \  \|\  \ \  \|\  \ \   __/|    
 \ \   __  \ \   _  _\ \  \    \ \   __  \ \  \_|/_\ \  \    \ \   __  \ \  \\\  \ \   _  _\ \  \_|/__  
  \ \  \ \  \ \  \\  \\ \  \____\ \  \ \  \ \  \_|\ \ \  \____\ \  \ \  \ \  \\\  \ \  \\  \\ \  \_|\ \ 
   \ \__\ \__\ \__\\ _\\ \_______\ \__\ \__\ \_______\ \_______\ \__\ \__\ \_______\ \__\\ _\\ \_______\
    \|__|\|__|\|__|\|__|\|_______|\|__|\|__|\|_______|\|_______|\|__|\|__|\|_______|\|__|\|__|\|_______|
                                                                                                        
                                                                                                        
                                                                                                        ");

                Random generator = new Random();

                Customer c1 = generator.Next(10) == 0 ? new StupidCustomer() : new Customer();




                Console.WriteLine("Whablam! A new seller aproaches!! What gender are they?\n (Male / Female)");
                c1.genderCheck();
                Console.WriteLine($"Here is the Book:");

                Book b1 = new Book();
                b1.PrintInfo(c1);
                Console.WriteLine("Are you intrested in buying?");
                string a = "";
                while (a != "yes" && a != "no")
                {
                    a = Console.ReadLine().ToLower().Trim();

                }
                if (a == "yes")
                {
                    store.Money -= b1.Price(c1);
                    ui.updateMoney(store.Money);
                    store.Library.Add(b1);
                }
                else
                {
                    Console.WriteLine("Ok, moving on...");
                }
                Console.WriteLine("Next, would you like to auction out one of your purchased books(s), or have another seller come by the store?(b) (s/b)");
                while (a != "s" && a != "b")
                {
                    a = Console.ReadLine().ToLower().Trim();

                }
                if (a == "s")
                {
                    for (int i = 0; i < store.Library.Count; i++)
                    {
                        Console.WriteLine(i + ". " + store.Library[i].name);

                    }

                    int bookID = -1;
                    System.Console.WriteLine("What book would you like to auction? \n");
                    while (bookID < 0 || bookID >= store.Library.Count)
                    {
                        System.Console.WriteLine("Press the corresponding number on the keyboard");
                        bookID = (int)char.GetNumericValue(Console.ReadKey().KeyChar);
                    }

                    System.Console.WriteLine($"Are you sure about putting {store.Library[bookID]} for sale?\n (y/n)");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {

                        Book book = store.Library[bookID];
                        Console.WriteLine($"How much do you wish to list the book for? You purchased the book for {book.Price(c1)} ");

                        int askingPrice = 0;
                        bool correctInput = false;
                        while (!correctInput)
                        {
                            correctInput = int.TryParse(Console.ReadLine(), out askingPrice);
                            if (correctInput == false)
                            {
                                System.Console.WriteLine("Please Enter a valid asking price, (Integer)");
                            }
                            else
                            {
                                if (askingPrice < b1.Price(c1))
                                {
                                    store.Money += askingPrice;
                                    ui.updateMoney(store.Money);

                                }
                                else
                                {
                                    System.Console.WriteLine("Book Did not sell, try lowering the price! \n (Enter a new asking price");

                                }
                            }
                        }







                        store.Library.Remove(book);
                        Console.Clear();
                        for (int i = 0; i < store.Library.Count; i++)
                        {
                            Console.WriteLine(i + ". " + store.Library[i].name);

                        }
                        System.Console.WriteLine("Your Book Has Perished Peasant. GO die");

                    }
                    else
                    {
                        System.Console.WriteLine("asshat");
                    }
                    // vilkenbok = -1
                    // loopa så länge vilkenbok inte är 0-library.count
                    //  Läsa in siffra
                    //  Tryparsa

                    // Ta bort Library[vilkenbok]

                    Console.ReadLine();
                }
                else
                {

                }
                store.bankCheck();
            }
            Console.WriteLine("Shit Bro, Youre Outta Moneys. Your Store is now on Fire, and your uncle is dead...");
            Console.ReadLine();
        }



    }
}

