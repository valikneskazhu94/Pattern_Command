using ConsoleApp1.Clients;
using ConsoleApp1.Commands;
using ConsoleApp1.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            //GarageDoor
            GarageDoor garageDoor = new GarageDoor();
            GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);
            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

            Light light = new Light();
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);

            TV tv = new TV();
            TvOnCommand tvOnCommand = new TvOnCommand(tv);
            TvOffCommand tvOffCommand = new TvOffCommand(tv);

            Stereo stereo = new Stereo();
            StereoOnCommand stereoOnCommand = new StereoOnCommand(stereo);
            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);


            remoteControl.SetCommand(0, garageDoorOpenCommand, garageDoorCloseCommand);
            remoteControl.SetCommand(1, lightOnCommand, lightOffCommand);
            remoteControl.SetCommand(2, tvOnCommand, tvOffCommand);
            remoteControl.SetCommand(3,stereoOnCommand,stereoOffCommand);


            remoteControl.OnButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);

            Console.WriteLine(remoteControl);

            remoteControl.OffButtonWasPushed(0);
            Console.ReadKey();



        }
    }
}
