using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Devices
{
   public class Stereo
    {
        public void On()
        {
            Console.WriteLine("TV is on!");
        }
        public void Off()
        {
            Console.WriteLine("TV is off!");
        }
     
        public void setVolume()
        {
            Console.WriteLine("Volume level is 10");
        }
        public void setCd()
        {
            Console.WriteLine("Now CD is ready!");
        }
        public void setDVD()
        {
            Console.WriteLine("Now DVD is ready!");
        }
        public void setRadio()
        {
            Console.WriteLine("Now radio is ready!");
        }
    }
}
