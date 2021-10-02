using System;
using System.Collections.Generic;
namespace ข้อ_3_กลางภาค_Flowerstore
{
    
    class Flower
    {
        public string name;
        public List<string> flowerlist = new List<string>();

        public Flower (string flowername)
        {
            name = flowername;
        }
       
    }
    class Cart 
    {
        public List<string> cart = new List<string>();

        public void addToCart(string name)
        {
            cart.Add(name);
        }

        public void showCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("My cart :");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
        }
      
    }

    class Program
    {
        static void Main(string[] args)
        {
            string decide;
            string selectflower;
            do
            {

                Console.WriteLine("select number for buy flower :");
                Console.WriteLine("1 Rose");
                Console.WriteLine("2 Lotus");
                Flower nameflower1 = new Flower("Rose");
                Flower nameflower2 = new Flower("Lotus");

                 selectflower = Console.ReadLine();
                if (selectflower == "1")
                {
                    Console.WriteLine("Added" + nameflower1.name);
                }
                else if (selectflower == "2")
                {
                    Console.WriteLine("Add" + nameflower2.name);
                }
                else
                {
                    Console.WriteLine("Not Added to cart. found select number of flower");
                }
                Console.WriteLine("You can stop this progress ? exit for >>exit<< progress and press any key for continute");

                 decide = Console.ReadLine();
                Cart cart = new Cart();
                if (decide == "exit")
                {
                    Console.Write("Current my cart");
                    cart.showCart();

                }
            } while (decide != "exit");
            

        }

    }
} 