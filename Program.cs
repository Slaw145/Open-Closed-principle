using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double MyWallet = 30;

            Client client = new Client(new ClientConstructor
            {
                firstname = "Slawomir",
                lastname = "Kowalski",
                zipcode = "81-198",
                myWallet = MyWallet
            });

            ClientCart clientCart = new ClientCart();

            clientCart.Products = new List<string>();
            clientCart.TypesProducts = new List<string>();

            Shop shop = new Shop(100);

            shop.NewClient();
            clientCart.AddProduct("cola");
            clientCart.AddProduct("sprite");
            clientCart.SaveTypeProducts("drink");
            clientCart.SaveTypeProducts("drink");

            Drink drinksInBag = new Drink();
            drinksInBag.GetTypeProductsCount(2);
            clientCart.SumProductsPrice(5.6);
            clientCart.SumProductsPrice(3.5);

            clientCart.AddProduct("candy");
            clientCart.SaveTypeProducts("candys");

            Candy candysInBag = new Candy();
            candysInBag.GetTypeProductsCount(1);
            clientCart.SumProductsPrice(1.4);

            clientCart.AddProduct("orange");
            clientCart.SaveTypeProducts("fruit");

            Fruit fruitsInBag = new Fruit();
            fruitsInBag.GetTypeProductsCount(1);
            clientCart.SumProductsPrice(2.2);

            Order order = new Order();

            Console.WriteLine(order.GiveOrder() +
            "\nThe number of products in the cart: " + clientCart.GetProductsCount() +
            "\nOrder placed by: " + client.FirstName + " " + client.LastName
            + "\nNumber of drinks in the cart: " + drinksInBag.NumberDrinks
            + "\nNumber of fruits in the cart: " + fruitsInBag.NumberFruits
            + "\nThe number of sweets in the cart: " + candysInBag.NumberCandys
            + "\nPrice of all products: " + clientCart.PriceAllProducts);

            Console.WriteLine("It's in my wallet: " + (client.MyWallet - clientCart.PriceAllProducts) + " PLN");

            Console.ReadKey();
        }
    }
}
