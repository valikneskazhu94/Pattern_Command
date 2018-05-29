using ConsoleApp1.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands
{
    public class StereoOnCommand:iCommand
    {
        Stereo stereo = null;
        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.On();
        }
        public void Undo()
        {
            stereo.Off();
        }
    }
}
