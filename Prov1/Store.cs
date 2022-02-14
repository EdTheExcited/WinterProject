using System;
using System.Collections.Generic;
namespace Prov1
{
    public class Store
    {
        public List<Book> Library = new List<Book>();
        public int Money = 15000;
        public bool notBankrupt = true;
        public void bankCheck()
        {
            if (Money <= 0)
            {
                notBankrupt = false;

            }
        }
    }
}