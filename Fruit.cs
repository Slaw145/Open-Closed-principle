using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Fruit : TypeProduct
    {
        public int NumberFruits { get; set; }

        public override void GetTypeProductsCount(int quantity)
        {
            NumberFruits += quantity;
        }
    }
}
