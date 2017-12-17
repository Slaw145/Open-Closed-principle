using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Drink : TypeProduct
    {
        public int NumberDrinks { get; set; }

        public override void GetTypeProductsCount(int quantity)
        {
            NumberDrinks += quantity;
        }
    }
}
