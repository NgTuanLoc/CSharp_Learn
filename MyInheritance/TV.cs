using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInheritance
{
    public class TV:ElectricalDevice
    {
        public TV(bool isOn, string brand):base(isOn, brand)
        {
        }
        public void WatchTV()
        {
            if(IsOn)
            {
                Console.WriteLine("Watching TV");
            }
            else
            {
                Console.WriteLine("Switch Off TV");
            }
        }
    }
}