using System;
using System.Collections.Generic;
using System.Text;

namespace CarSelling
{
    abstract class CarList : ICarDetails
    {
        public int Id { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
        public string year { get; set; }
        public CarCondition condition { get; set; }



        public void Display(int Id, string brand, int price, string year)
        {
            Console.WriteLine("ID is : " + Id);
            Console.WriteLine("Brand is : " + brand);
            Console.WriteLine("Price is : " + price);
            Console.WriteLine("Year is : " + year);
            //Add a line for Condition

        }
    }


}