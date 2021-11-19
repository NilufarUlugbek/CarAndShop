using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Program
    {
        public static string userInput;
        private static object search;
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to buy today? (Fruits|Vegetables)");
            userInput = Console.ReadLine();


            if(userInput == "Fruits")
            {
                List<Fruits> fruits = new List<Fruits>();

                fruits.Add(new Fruits
                {
                    id = 01,
                    productName = "Apple",
                    price = 20, 
                    year = 2021
                });

                fruits.Add(new Fruits
                {
                    id = 02,
                    productName = "Banana",
                    price = 5,
                    year = 2021
                });

                fruits.Add(new Fruits
                {
                    id = 03,
                    productName = "Pineapple",
                    price = 23,
                    year = 2021
                });

                fruits.Add(new Fruits
                {
                    id = 04,
                    productName = "Grape",
                    price = 2,
                    year = 2021
                });

                foreach(var fruit in fruits)
                {
                    Fruits fr = new Fruits();
                    fr.displayProduct(fruit.id, fruit.productName, fruit.price, fruit.year);
                    Console.WriteLine("******************");
                }

                Console.WriteLine("What exactly do you wan to buy?");
                search = Console.ReadLine();

                Fruits fsearch = fruits.Find(id => id.productName.Equals(search));
                if (fsearch != null){
                    Fruits fr = new Fruits();
                    fr.displayProduct(fsearch.id, fsearch.productName, fsearch.price, fsearch.year);
                    Console.WriteLine("******************");
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have this produc for now! Try again");
                  
                }
                search = Console.ReadLine();

                

            }
            else
            {
                List<Vegetables> vegs = new List<Vegetables>();

                vegs.Add(new Vegetables
                {
                    id = 0,
                    productName = "Potato",
                    price = 20,
                    year = 2021
                });

                vegs.Add(new Vegetables
                {
                    id = 6,
                    productName = "Tomato",
                    price = 15,
                    year = 2021
                });

                vegs.Add(new Vegetables
                {
                    id = 9,
                    productName = "Cucumber",
                    price = 33,
                    year = 2021
                });

                vegs.Add(new Vegetables
                {
                    id = 9,
                    productName = "Onion",
                    price = 3,
                    year = 2021
                });

                foreach (var veg in vegs)
                {
                    Vegetables vg = new Vegetables();
                    vg.displayProduct(veg.id, veg.productName, veg.price, veg.year);
                    Console.WriteLine("******************");
                }

                Console.WriteLine("What exactly do you wan to buy?");
                search = Console.ReadLine();

                Vegetables vsearch = vegs.Find(id => id.productName.Equals(search));
                if (vsearch != null)
                {
                    Vegetables vg = new Vegetables();
                    vg.displayProduct(vsearch.id, vsearch.productName, vsearch.price, vsearch.year);
                    Console.WriteLine("******************");
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have this produc for now! Try again");
                  
                }
                search = Console.ReadLine();
            }
        }
    }
}
