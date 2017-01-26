using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new instance from Car class
            Car ford = new Car();
            ford.PrintData();
            ford.Model = "Ford Fiesta";
            ford.Color = "Yellow";
            ford.Engine = 0.5;
            ford.Speed = 10;
            ford.FuzzyDices = true;
            ford.DoorCount = 2;
            ford.Accelerate();
            ford.PrintData();
            ford.Brake(7);
            Car.SomeProperty = 56;
            ford.PrintData();

            //create another car object
            string model = "Speedster";
            Car nascar = new CarApplication.Car(model);
            nascar.PrintData();
            nascar.Color = "Black";
            Console.WriteLine("Color is " + nascar.Color);
            
        }
    }
}
