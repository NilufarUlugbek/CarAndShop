using System;
using System.Collections.Generic;
using System.Text;

namespace CarSelling
{
   interface ICarDetails
    {
        public int Id { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
        public string year { get; set; }
        public CarCondition condition { get; set; }
      
    }

    public enum CarCondition
    {
        Bad = 0,
        Normal = 1,
        Good = 2
    }
}

