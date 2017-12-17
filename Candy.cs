using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Candy : TypeProduct
    {
        public int NumberCandys { get; set; }

        public override void GetTypeProductsCount(int quantity)
        {
            NumberCandys += quantity;
        }
    }
}
