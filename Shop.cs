using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Shop
    {
        public int NumberProducts { get; set; }
        public int NumberClient { get; set; }

        public Shop(int numberproducts)
        {
            NumberProducts = numberproducts;
        }

        public void NewClient()
        {
            NumberClient += 1;
        }
    }
}
