using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealershipApp.Domain
{
    public class Car
    {
        public string Number;
        public string Model;
        public int YearMaking;
        public string Color;
        public long Price;
        
        public Car(string number, string model, int year, string color, long price)
        {
            Number = number;
            Model = model;
            YearMaking = year;
            Color = color;
            Price = price;
        }
    }
}
