using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInheritance
{
    public class Radio:ElectricalDevice
    {
        
        public Radio(bool isOn, string brand):base(isOn, brand)
        {
        }
        public void ListenRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("Listening to the Radio");
            }
            else
            {
                Console.WriteLine("Radio is switched off");
            }
        }
    }
}