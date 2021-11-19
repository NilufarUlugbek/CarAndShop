using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
     abstract public class PoductDetails: IProductList
    {
        public int id { get; set; }
   
        public string productName { get; set; }
        public int price { get; set; }
        public int year { get; set; }
        public enum productType
        {
            Fruits = 0, 
            Vegetables = 1
        }
        public void displayProduct(int id, string productName, int year, int price)
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + productName);
            Console.WriteLine("Date: " + year);
            Console.WriteLine("Price: " + price);
        }
    }

   
}
