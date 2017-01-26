using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.IsOn = true;
            washer.Temperature = 40;
            washer.WashTime = 30;
            washer.Program = "Fastwash";
            washer.Wash();
            Console.WriteLine("Washing program is " + washer.Program);
            Console.WriteLine("Temperature is " + washer.Temperature + " celsius");
            Console.WriteLine("Washtime is " + washer.WashTime + " min");
            
        }
    }
}
