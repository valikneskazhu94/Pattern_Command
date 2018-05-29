using ConsoleApp1.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    public class TvOnCommand:iCommand
    {
        TV tv = null;
        public TvOnCommand(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.On();
           
        }

        public void Undo()
        {
          tv.Off();
           
        }
    }
}
