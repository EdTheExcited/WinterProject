using System;

namespace Prov1
{
    public class UI
    {
        public void updateMoney(int money)
        {
            int oldLeft = Console.CursorLeft;

            Console.CursorLeft = 90;
            Console.CursorTop = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{money}$");
            Console.CursorLeft = oldLeft;
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
}