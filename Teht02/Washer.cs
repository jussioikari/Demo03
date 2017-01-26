using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Washer
    {
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int WashTime { get; set; }
        public string Program { get; set; }
        public void Wash()
        {
            Console.WriteLine("Washingmachine is on. Hurrrr....");
        }
    }
}
