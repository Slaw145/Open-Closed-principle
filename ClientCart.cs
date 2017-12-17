using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ClientCart
    {
        public List<string> Products { get; set; }
        public List<string> TypesProducts { get; set; }

        public int NumberProducts { get; set; }
        public double PriceAllProducts { get; set; }

        public void SaveTypeProducts(string typeproduct)
        {
            if (TypesProducts.Contains(typeproduct))
            {
                Console.WriteLine("This type of product is already in the cart!");
            }
            else
            {
                TypesProducts.Add(typeproduct);
            }
        }

        public void GetTypeProductsCount(TypeProduct typeproduct, int quantity)
        {
            typeproduct.GetTypeProductsCount(quantity);
        }

        public double SumProductsPrice(double priceproduct)
        {
            return PriceAllProducts += priceproduct;
        }

        public int GetProductsCount()
        {
            return NumberProducts = Products.Count;
        }

        public void AddProduct(string product)
        {
            Products.Add(product);
        }
    }
}
