using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Models
{
    class Bus:Vehicle
    {
        public int PassengerCount { get; set; }
        public override string Color { get ; set ; }
        public override int Year { get; set; }
        public Bus(int PassengerCount, string Color, int Year) :base(Year)
        {
            this.PassengerCount = PassengerCount;
            this.Color = Color;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"PassengerCount:{ PassengerCount}\nColor: {Color}\nYear: {Year} ");
        }

    }
}
