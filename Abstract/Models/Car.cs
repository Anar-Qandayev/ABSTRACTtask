using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Models
{
    class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        public override string Color { get; set; }
        public override int Year { get; set; }
        public Car(string Brand, string Model,string Color, int Year):base(Year)
        {
            this.Brand=Brand;
            this.Model=Model;
            this.Color = Color;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Brand:{ Brand}\nModel: {Model}\nColor: {Color}\nYear: {Year} ");
        }
    }
       
}
