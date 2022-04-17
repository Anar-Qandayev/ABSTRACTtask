using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Models
{
    abstract class Vehicle
    {
        public abstract string Color { get; set; }
        public abstract int Year { get; set; }
        public abstract void ShowInfo();
        public Vehicle(int Year)
        {
            this.Year = Year;
        }
    }
}
