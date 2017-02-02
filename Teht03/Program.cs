using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            tv.IsOn = true;
            tv.ChannelName = "Mtv3";
            tv.ChannelNumber = 3;
            tv.Program = "News";
            tv.Show();
            Console.WriteLine("Channel is " + tv.ChannelName);
            Console.WriteLine("Channelnumber is " + tv.ChannelNumber);
            Console.WriteLine("Program is " + tv.Program);


        }
    }
}
