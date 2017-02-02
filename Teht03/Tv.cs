using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class TV
    {
        public bool IsOn { get; set; }
        public int ChannelNumber { get; set; }
        public string ChannelName { get; set; }
        public string Program { get; set; }
        public int Volume { get; set; }
        public void Show()
        {
            Console.WriteLine("Tv is on");
        }
        
        
    }
}
