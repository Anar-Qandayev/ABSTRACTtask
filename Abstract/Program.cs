using Abstract.Models;
using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("MERCEDES","BENZ","BLACK",2010);
            Bus bus = new Bus(35,"BLACK",2019);
            Vehicle[] myArray = new Vehicle[0];
           
            Array.Resize(ref myArray, myArray.Length + 1);
                myArray[0] = car;
           
            Array.Resize(ref myArray, myArray.Length + 1);
                myArray[1] = bus;
             
            foreach (Vehicle myArrays in myArray)
            {
                myArrays.ShowInfo();
                Console.WriteLine("================");
            }

        }
    }
}
