using ConsoleApp1.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
   public class TvOffCommand:iCommand
    {
        TV tv = null;
        public TvOffCommand(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.Off();

        }

        public void Undo()
        {
            tv.On();

        }
    }
}
